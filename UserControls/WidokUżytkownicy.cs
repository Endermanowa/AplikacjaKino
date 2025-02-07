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

namespace AplikacjaKino.UserControls
{
    public partial class WidokUżytkownicy : UserControl
    {
        private Użytkownik użytkownik;

        public delegate void UżytkownicyUpdatedEventHandler();

        public event UżytkownicyUpdatedEventHandler OnUżytkownicyUpdated;

        public WidokUżytkownicy()
        {
            InitializeComponent();

            OnUżytkownicyUpdated += setupListView;

            setupListView();
        }

        public WidokUżytkownicy(Użytkownik użytkownik)
        {
            InitializeComponent();

            this.użytkownik = użytkownik;

            OnUżytkownicyUpdated += setupListView;

            setupListView();
        }

        private void setupListView()
        {
            listViewUżytkownicy.Clear();

            listViewUżytkownicy.Columns.Add("id");
            listViewUżytkownicy.Columns.Add("imie");
            listViewUżytkownicy.Columns.Add("nazwisko");
            listViewUżytkownicy.Columns.Add("numer telefonu");
            listViewUżytkownicy.Columns.Add("admin");

            listViewUżytkownicy.ListViewItemSorter = new ListViewItemComparer(0);
            listViewUżytkownicy.Sort();

            foreach (var obj in DataStorage.Użytkownicy)
            {
                var item = new ListViewItem(obj.id.ToString());
                item.SubItems.Add(obj.imie);
                item.SubItems.Add(obj.nazwisko);
                item.SubItems.Add(obj.numerTelefonu);
                item.SubItems.Add(obj.admin.ToString());

                listViewUżytkownicy.Items.Add(item);
            }

            listViewUżytkownicy.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewUżytkownicy.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewUżytkownicy.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewUżytkownicy.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewUżytkownicy.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void WidokUżytkownicy_Resize(object sender, EventArgs e)
        {
            panelButtons.Top = (this.ClientSize.Height - panelButtons.Height) / 2;
        }

        private void buttonViewRezerwacje_Click(object sender, EventArgs e)
        {
            if (listViewUżytkownicy.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewUżytkownicy.SelectedItems[0];

                createForm(int.Parse(selectedItem.SubItems[0].Text)).Show();
            }
            else
            {
                createForm().Show();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewUżytkownicy.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć użytkownika?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedItem = listViewUżytkownicy.SelectedItems[0];

                    DatabaseHelper db = new DatabaseHelper();
                    db.RemoveUżytkownikFromDatabase(int.Parse(selectedItem.SubItems[0].Text));

                    DataStorage.Użytkownicy = db.GetAllUżytkownicy();

                    OnUżytkownicyUpdated?.Invoke();

                    using (StreamWriter writer = File.AppendText("ActivityLog.log"))
                    {
                        writer.WriteLine("Administrator " + użytkownik.imie + " " + użytkownik.nazwisko + " tel." + użytkownik.numerTelefonu + " usunął użytkownika");
                    }
                }
            }
        }

        private Form createForm()
        {
            Form form = new Form();
            WidokRezerwacjeAdmin widokRezerwacje = new WidokRezerwacjeAdmin();

            form.Text = "Rezerwacje";
            form.Size = new Size(500, 300);

            widokRezerwacje.Dock = DockStyle.Fill;
            form.Controls.Add(widokRezerwacje);

            return form;
        }

        private Form createForm(int użytkownik)
        {
            Form form = new Form();
            WidokRezerwacjeAdmin widokRezerwacje = new WidokRezerwacjeAdmin(użytkownik);

            form.Text = "Seanse dla użytkownika " + użytkownik;
            form.Size = new Size(500, 300);

            widokRezerwacje.Dock = DockStyle.Fill;
            form.Controls.Add(widokRezerwacje);

            return form;
        }
    }
}
