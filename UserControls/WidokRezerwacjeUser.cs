using AplikacjaKino.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AplikacjaKino.UserControls
{
    public partial class WidokRezerwacjeUser : UserControl
    {
        public Użytkownik użytkownik;

        public delegate void RezerwacjeUpdatedEventHandler();

        public event RezerwacjeUpdatedEventHandler OnRezerwacjeUpdated;

        public WidokRezerwacjeUser(Użytkownik użytkownik)
        {
            InitializeComponent();

            this.użytkownik = użytkownik;

            OnRezerwacjeUpdated += setupListView;

            setupListView();
        }

        private void setupListView()
        {
            listViewRezerwacje.Clear();

            listViewRezerwacje.Columns.Add("id");
            listViewRezerwacje.Columns.Add("seans");
            listViewRezerwacje.Columns.Add("liczba biletów");
            listViewRezerwacje.Columns.Add("miejsca");

            listViewRezerwacje.ListViewItemSorter = new ListViewItemComparer(0);
            listViewRezerwacje.Sort();

            foreach (var obj in DataStorage.Rezerwacje)
            {
                if (obj.użytkownik == użytkownik.id)
                {
                    var item = new ListViewItem(obj.id.ToString());
                    item.SubItems.Add(obj.seans.ToString());
                    item.SubItems.Add(obj.liczbaBiletów.ToString());
                    item.SubItems.Add(string.Join(", ", obj.miejsca));

                    listViewRezerwacje.Items.Add(item);
                }
            }

            listViewRezerwacje.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewRezerwacje.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRezerwacje.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRezerwacje.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void WidokRezerwacjeUser_Resize(object sender, EventArgs e)
        {
            panelButtons.Top = (this.ClientSize.Height - panelButtons.Height) / 2;
        }

        private void buttonAddRezerwacja_Click(object sender, EventArgs e)
        {
            using (var dialog = new NowaRezerwacja(użytkownik.id))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    OnRezerwacjeUpdated?.Invoke();

                    using (StreamWriter writer = File.AppendText("ActivityLog.log"))
                    {
                        writer.WriteLine("Użytkownik " + użytkownik.imie + " " + użytkownik.nazwisko + " tel." + użytkownik.numerTelefonu + " dodał rezerwację");
                    }
                }
            }
        }

        private void buttonDeleteRezerwacja_Click(object sender, EventArgs e)
        {
            if (listViewRezerwacje.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć rezerwację?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedItem = listViewRezerwacje.SelectedItems[0];

                    Seans seans = DataStorage.Seanse.FirstOrDefault(p => p.id == int.Parse(selectedItem.SubItems[1].Text));
                    Rezerwacja rezerwacja = DataStorage.Rezerwacje.FirstOrDefault(p => p.id == int.Parse(selectedItem.SubItems[0].Text));

                    for(int i = 0; i < seans.miejsca.rzedy; i++)
                    {
                        for(int j = 0; j < seans.miejsca.kolumny; j++)
                        {
                            int index = i*seans.miejsca.kolumny + j;

                            if (seans.miejsca.miejsca[index] == true)
                            {
                                foreach (string s in rezerwacja.miejsca)
                                {
                                    if (seans.miejsca.getMiejsce(i+1, j+1).Equals(s))
                                    {
                                        seans.miejsca.miejsca[index] = false;
                                    }
                                }
                            }
                        }
                    }

                    DatabaseHelper db = new DatabaseHelper();
                    db.RemoveRezerwacjaFromDatabase(int.Parse(selectedItem.SubItems[0].Text));
                    db.UpdateSeansMiejscaInDatabase(seans);

                    DataStorage.Rezerwacje = db.GetAllRezerwacje();
                    DataStorage.Seanse = db.GetAllSeanse();

                    OnRezerwacjeUpdated?.Invoke();

                    using (StreamWriter writer = File.AppendText("ActivityLog.log"))
                    {
                        writer.WriteLine("Użytkownik " + użytkownik.imie + " " + użytkownik.nazwisko + " tel." + użytkownik.numerTelefonu + " usunął rezerwację");
                    }
                }
            }
        }
    }
}
