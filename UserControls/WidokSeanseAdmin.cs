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
    public partial class WidokSeanseAdmin : UserControl
    {
        private int film = -1;
        private int lokalizacja = -1;
        private Użytkownik użytkownik;

        public delegate void SeanseUpdatedEventHandler();

        public event SeanseUpdatedEventHandler OnSeanseUpdated;

        public WidokSeanseAdmin()
        {
            InitializeComponent();

            OnSeanseUpdated += setupListView;

            setupListView();
        }

        public WidokSeanseAdmin(Użytkownik użytkownik)
        {
            InitializeComponent();

            this.użytkownik = użytkownik;

            OnSeanseUpdated += setupListView;

            setupListView();
        }

        public WidokSeanseAdmin(int lokalizacja, int film, Użytkownik użytkownik)
        {
            InitializeComponent();

            this.film = film;
            this.lokalizacja = lokalizacja;
            this.użytkownik = użytkownik;

            OnSeanseUpdated += setupListView;

            setupListView();
        }

        private void setupListView()
        {
            listViewSeanse.Clear();

            listViewSeanse.Columns.Add("id");
            listViewSeanse.Columns.Add("sala");
            listViewSeanse.Columns.Add("data");
            listViewSeanse.Columns.Add("godzina");
            listViewSeanse.Columns.Add("typ");
            listViewSeanse.Columns.Add("jezyk");

            listViewSeanse.ListViewItemSorter = new ListViewItemComparer(0);
            listViewSeanse.Sort();

            foreach (var obj in DataStorage.Seanse)
            {
                if((lokalizacja >= 0) && (film >= 0))
                {
                    if ((obj.lokalizacja == lokalizacja) && (obj.film == film))
                    {
                        var item = new ListViewItem(obj.id.ToString());
                        item.SubItems.Add(obj.sala.ToString());
                        item.SubItems.Add(obj.data.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(obj.godzina.ToString("HH:mm"));
                        item.SubItems.Add(obj.typ);
                        item.SubItems.Add(obj.jezyk);

                        listViewSeanse.Items.Add(item);
                    }
                }
                else
                {
                    var item = new ListViewItem(obj.id.ToString());
                    item.SubItems.Add(obj.sala.ToString());
                    item.SubItems.Add(obj.data.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(obj.godzina.ToString("HH:mm"));
                    item.SubItems.Add(obj.typ);
                    item.SubItems.Add(obj.jezyk);

                    listViewSeanse.Items.Add(item);
                }
            }

            listViewSeanse.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewSeanse.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewSeanse.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewSeanse.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewSeanse.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewSeanse.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void WidokSeanseAdmin_Resize(object sender, EventArgs e)
        {
            panelButtons.Top = (this.ClientSize.Height - panelButtons.Height) / 2;
        }

        private void buttonAddSeans_Click(object sender, EventArgs e)
        {
            using (var dialog = new NowySeans())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    OnSeanseUpdated?.Invoke();

                    using (StreamWriter writer = File.AppendText("ActivityLog.log"))
                    {
                        writer.WriteLine("Administrator " + użytkownik.imie + " " + użytkownik.nazwisko + " tel." + użytkownik.numerTelefonu + " dodał seans");
                    }
                }
            }
        }

        private void buttonEditSeans_Click(object sender, EventArgs e)
        {
            if (listViewSeanse.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewSeanse.SelectedItems[0];

                using (var dialog = new ZmianaSeansu(int.Parse(selectedItem.SubItems[0].Text)))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        OnSeanseUpdated?.Invoke();

                        using (StreamWriter writer = File.AppendText("ActivityLog.log"))
                        {
                            writer.WriteLine("Administrator " + użytkownik.imie + " " + użytkownik.nazwisko + " tel." + użytkownik.numerTelefonu + " edytował seans");
                        }
                    }
                } 
            }
        }

        private void buttonDeleteSeans_Click(object sender, EventArgs e)
        {
            if (listViewSeanse.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć seans?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedItem = listViewSeanse.SelectedItems[0];

                    DatabaseHelper db = new DatabaseHelper();
                    db.RemoveSeansFromDatabase(int.Parse(selectedItem.SubItems[0].Text));

                    DataStorage.Seanse = db.GetAllSeanse();

                    OnSeanseUpdated?.Invoke();

                    using (StreamWriter writer = File.AppendText("ActivityLog.log"))
                    {
                        writer.WriteLine("Administrator " + użytkownik.imie + " " + użytkownik.nazwisko + " tel." + użytkownik.numerTelefonu + " usunął seans");
                    }
                }
            }
        }
    }
}
