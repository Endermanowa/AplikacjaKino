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
    public partial class WidokSale : UserControl
    {
        public WidokSale()
        {
            InitializeComponent();

            setupListView();
        }

        public WidokSale(int lokalizacja)
        {
            InitializeComponent();

            setupListView(lokalizacja);
        }

        private void setupListView()
        {
            listViewSale.Columns.Add("id");
            listViewSale.Columns.Add("lokalizacja");
            listViewSale.Columns.Add("numer");
            listViewSale.Columns.Add("liczba miejsc");

            listViewSale.ListViewItemSorter = new ListViewItemComparer(0);
            listViewSale.Sort();

            foreach (var obj in DataStorage.Sale)
            {
                var item = new ListViewItem(obj.id.ToString());
                item.SubItems.Add(obj.lokalizacja.ToString());
                item.SubItems.Add(obj.numer);
                item.SubItems.Add(obj.liczbaMiejsc.ToString());

                listViewSale.Items.Add(item);
            }

            listViewSale.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewSale.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewSale.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewSale.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void setupListView(int lokalizacja)
        {
            listViewSale.Columns.Add("id");
            listViewSale.Columns.Add("numer");
            listViewSale.Columns.Add("liczba miejsc");

            listViewSale.ListViewItemSorter = new ListViewItemComparer(0);
            listViewSale.Sort();

            foreach (var obj in DataStorage.Sale)
            {
                if(obj.lokalizacja == lokalizacja)
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
    }
}
