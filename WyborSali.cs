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
    public partial class WyborSali : Form
    {
        public int selectedLokalizacja = -1;
        public int selectedSala;

        public WyborSali()
        {
            InitializeComponent();

            setupListViewLokalizacje();
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

        private void setupListViewSale()
        {
            listViewSale.Clear();

            listViewSale.Columns.Add("id");
            listViewSale.Columns.Add("numer");
            listViewSale.Columns.Add("liczba miejsc");

            listViewSale.ListViewItemSorter = new ListViewItemComparer(0);
            listViewSale.Sort();

            foreach (var obj in DataStorage.Sale)
            {
                if (obj.lokalizacja == selectedLokalizacja)
                {
                    var item = new ListViewItem(obj.id.ToString());
                    item.SubItems.Add(obj.numer);
                    item.SubItems.Add(obj.liczbaMiejsc.ToString());

                    listViewSale.Items.Add(item);
                }
            }

            listViewSale.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewSale.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewSale.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonSelectLokalizacja_Click(object sender, EventArgs e)
        {
            if (listViewLokalizacje.SelectedItems.Count > 0)
            {
                selectedLokalizacja = int.Parse(listViewLokalizacje.SelectedItems[0].SubItems[0].Text);

                setupListViewSale();
            }
        }

        private void buttonSelectSala_Click(object sender, EventArgs e)
        {
            if (listViewSale.SelectedItems.Count > 0)
            {
                selectedSala = int.Parse(listViewSale.SelectedItems[0].SubItems[0].Text);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
