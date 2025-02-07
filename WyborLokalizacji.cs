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
    public partial class WyborLokalizacji : Form
    {
        public int selectedLokalizacja;

        public WyborLokalizacji()
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

        private void WyborLokalizacji_Resize(object sender, EventArgs e)
        {
            buttonSelect.Top = (this.ClientSize.Height - buttonSelect.Height) / 2;
        }
        
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listViewLokalizacje.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewLokalizacje.SelectedItems[0];

                selectedLokalizacja = int.Parse(selectedItem.SubItems[0].Text);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
