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
    public partial class WidokFilmyUser : UserControl
    {
        public WidokFilmyUser()
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

        private void WidokFilmy_Resize(object sender, EventArgs e)
        {
            buttonViewSeanse.Top = (this.ClientSize.Height - buttonViewSeanse.Height) / 2;
        }

        private void buttonViewSeanse_Click(object sender, EventArgs e)
        {
            if (listViewFilmy.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewFilmy.SelectedItems[0];

                int lokalizacja = getLokalizacja();

                if(lokalizacja >= 0)
                {
                    createForm(lokalizacja, int.Parse(selectedItem.SubItems[0].Text), selectedItem.SubItems[1].Text).Show();
                }
                else
                {
                    createForm().Show();
                }
            }
            else
            {
                createForm().Show();
            }
        }

        private Form createForm()
        {
            Form form = new Form();
            WidokSeanseUser widokSeanse = new WidokSeanseUser();

            form.Text = "Seanse";
            form.Size = new Size(500, 300);

            widokSeanse.Dock = DockStyle.Fill;
            form.Controls.Add(widokSeanse);

            return form;
        }

        private Form createForm(int lokalizacja, int filmID, string filmNazwa)
        {
            Form form = new Form();
            WidokSeanseUser widokSeanse = new WidokSeanseUser(lokalizacja, filmID);

            form.Text = "Seanse dla filmu \"" + filmNazwa + "\"";
            form.Size = new Size(500, 300);

            widokSeanse.Dock = DockStyle.Fill;
            form.Controls.Add(widokSeanse);

            return form;
        }

        private int getLokalizacja()
        {
            int lokalizacja = -1;

            using (var dialog = new WyborLokalizacji())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    lokalizacja = dialog.selectedLokalizacja;
                }
            }

            return lokalizacja;
        }
    }
}
