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
    public partial class WyborFilmu : Form
    {
        public int selectedFilm;

        public WyborFilmu()
        {
            InitializeComponent();

            setupListView();
        }

        private void setupListView()
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

        private void WyborFilmu_Resize(object sender, EventArgs e)
        {
            buttonSelect.Top = (this.ClientSize.Height - buttonSelect.Height) / 2;
        }
        
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listViewFilmy.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewFilmy.SelectedItems[0];

                selectedFilm = int.Parse(selectedItem.SubItems[0].Text);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
