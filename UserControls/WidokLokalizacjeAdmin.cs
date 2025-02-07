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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplikacjaKino.UserControls
{
    public partial class WidokLokalizacjeAdmin : UserControl
    {
        public WidokLokalizacjeAdmin()
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

        private void WidokLokalizacje_Resize(object sender, EventArgs e)
        {
            buttonViewSale.Top = (this.ClientSize.Height - buttonViewSale.Height) / 2;
        }

        private void buttonViewSale_Click(object sender, EventArgs e)
        {
            if(listViewLokalizacje.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewLokalizacje.SelectedItems[0];

                createForm(int.Parse(selectedItem.SubItems[0].Text)).Show();
            }
            else
            {
                createForm().Show();
            }
        }

        private Form createForm()
        {
            Form form = new Form();
            WidokSale widokSale = new WidokSale();

            form.Text = "Sale w lokalizacjach";
            form.Size = new Size(400, 300);

            widokSale.Dock = DockStyle.Fill;
            form.Controls.Add(widokSale);

            return form;
        }

        private Form createForm(int lokalizacja)
        {
            Form form = new Form();
            WidokSale widokSale = new WidokSale(lokalizacja);

            form.Text = "Sale w lokalizacji numer " + lokalizacja.ToString();
            form.Size = new Size(500, 300);

            widokSale.Dock = DockStyle.Fill;
            form.Controls.Add(widokSale);

            return form;
        }
    }
}
