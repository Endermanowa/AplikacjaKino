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
    public partial class WidokLokalizacjeUser : UserControl
    {
        public WidokLokalizacjeUser()
        {
            InitializeComponent();

            setupListView();
        }

        private void setupListView()
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
    }
}
