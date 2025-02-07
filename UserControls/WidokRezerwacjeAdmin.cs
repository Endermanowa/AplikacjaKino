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
    public partial class WidokRezerwacjeAdmin : UserControl
    {
        public WidokRezerwacjeAdmin()
        {
            InitializeComponent();

            setupListView();
        }

        public WidokRezerwacjeAdmin(int użytkownik)
        {
            InitializeComponent();

            setupListView(użytkownik);
        }

        private void setupListView()
        {
            listViewRezerwacje.Columns.Add("id");
            listViewRezerwacje.Columns.Add("uzytkownik");
            listViewRezerwacje.Columns.Add("seans");
            listViewRezerwacje.Columns.Add("liczba biletow");
            listViewRezerwacje.Columns.Add("miejsca");
            
            listViewRezerwacje.ListViewItemSorter = new ListViewItemComparer(0);
            listViewRezerwacje.Sort();

            foreach (var obj in DataStorage.Rezerwacje)
            {
                var item = new ListViewItem(obj.id.ToString());
                item.SubItems.Add(obj.użytkownik.ToString());
                item.SubItems.Add(obj.seans.ToString());
                item.SubItems.Add(obj.liczbaBiletów.ToString());
                item.SubItems.Add(string.Join(", ", obj.miejsca));

                listViewRezerwacje.Items.Add(item);
            }

            listViewRezerwacje.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewRezerwacje.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRezerwacje.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRezerwacje.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRezerwacje.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void setupListView(int użytkownik)
        {
            listViewRezerwacje.Columns.Add("id");
            listViewRezerwacje.Columns.Add("seans");
            listViewRezerwacje.Columns.Add("liczba biletów");
            listViewRezerwacje.Columns.Add("miejsca");

            listViewRezerwacje.ListViewItemSorter = new ListViewItemComparer(0);
            listViewRezerwacje.Sort();

            foreach (var obj in DataStorage.Rezerwacje)
            {
                if (obj.użytkownik == użytkownik)
                {
                    var item = new ListViewItem(obj.id.ToString());
                    item.SubItems.Add(obj.seans.ToString());
                    item.SubItems.Add(obj.liczbaBiletów.ToString());
                    item.SubItems.Add(string.Join(", ", obj.miejsca));

                    listViewRezerwacje.Items.Add(item);
                }
            }

            listViewRezerwacje.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewRezerwacje.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRezerwacje.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRezerwacje.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
