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
    public partial class WidokSeanseUser : UserControl
    {
        private int film = -1;
        private int lokalizacja = -1;

        public WidokSeanseUser()
        {
            InitializeComponent();

            setupListView();
        }

        public WidokSeanseUser(int lokalizacja, int film)
        {
            InitializeComponent();

            this.film = film;
            this.lokalizacja = lokalizacja;

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
                if ((lokalizacja >= 0) && (film >= 0))
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
    }
}
