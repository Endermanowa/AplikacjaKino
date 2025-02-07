using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKino.Entities
{
    public class ListViewItemComparer : IComparer
    {
        private int columnIndex;

        public ListViewItemComparer(int column)
        {
            columnIndex = column;
        }

        public int Compare(object x, object y)
        {
            string textX = ((ListViewItem)x).SubItems[columnIndex].Text;
            string textY = ((ListViewItem)y).SubItems[columnIndex].Text;

            if (int.TryParse(textX, out int numX) && int.TryParse(textY, out int numY))
            {
                return numX.CompareTo(numY);
            }

            return string.Compare(textX, textY, StringComparison.Ordinal);
        }
    }
}
