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

namespace AplikacjaKino
{
    public partial class WyborSeansu : Form
    {
        public int selectedLokalizacja = -1;
        public int selectedSeans;
        public int selectedFilm = -1;

        public WyborSeansu()
        {
            InitializeComponent();

            setupListViewLokalizacje();
            setupListViewFilmy();
        }

        private void setupListViewLokalizacje()
        {
            listViewLokalizacje.Columns.Add("id");
            listViewLokalizacje.Columns.Add("nazwa");
            listViewLokalizacje.Columns.Add("miejscowosc");
            listViewLokalizacje.Columns.Add("adres");

            listViewLokalizacje.ListViewItemSorter = new ListViewItemComparer(0);
            listViewLokalizacje.Sort();

            foreach (var obj in DataStorage.Lokalizacje)
            {
                var item = new ListViewItem(obj.id.ToString());
                item.SubItems.Add(obj.nazwa);
                item.SubItems.Add(obj.miejscowosc);
                item.SubItems.Add(obj.adres);

                listViewLokalizacje.Items.Add(item);
            }

            listViewLokalizacje.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewLokalizacje.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewLokalizacje.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewLokalizacje.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void setupListViewFilmy()
        {
            listViewFilmy.Columns.Add("id");
            listViewFilmy.Columns.Add("nazwa");
            listViewFilmy.Columns.Add("gatunki");
            listViewFilmy.Columns.Add("dlugosc");

            listViewFilmy.ListViewItemSorter = new ListViewItemComparer(0);
            listViewFilmy.Sort();

            foreach (var obj in DataStorage.Filmy)
            {
                var item = new ListViewItem(obj.id.ToString());
                item.SubItems.Add(obj.nazwa);
                item.SubItems.Add(obj.gatunki);
                item.SubItems.Add(obj.dlugosc.ToString());

                listViewFilmy.Items.Add(item);
            }

            listViewFilmy.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewFilmy.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewFilmy.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewFilmy.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void setupListViewSeanse()
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
                if ((obj.lokalizacja == selectedLokalizacja) && (obj.film == selectedFilm))
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

        private void buttonSelectLokalizacja_Click(object sender, EventArgs e)
        {
            if(listViewLokalizacje.SelectedItems.Count > 0)
            {
                selectedLokalizacja = int.Parse(listViewLokalizacje.SelectedItems[0].SubItems[0].Text);

                if ((selectedLokalizacja >= 0) && (selectedFilm >= 0))
                {
                    setupListViewSeanse();
                }
            }
        }

        private void buttonSelectFilm_Click(object sender, EventArgs e)
        {
            if(listViewFilmy.SelectedItems.Count > 0)
            {
                selectedFilm = int.Parse(listViewFilmy.SelectedItems[0].SubItems[0].Text);

                if ((selectedLokalizacja >= 0) && (selectedFilm >= 0))
                {
                    setupListViewSeanse();
                }
            }
        }

        private void buttonSelectSeans_Click(object sender, EventArgs e)
        {
            if(listViewSeanse.SelectedItems.Count > 0)
            {
                selectedSeans = int.Parse(listViewSeanse.SelectedItems[0].SubItems[0].Text);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
