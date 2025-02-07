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
    public partial class WidokLogs : UserControl
    {
        public WidokLogs()
        {
            InitializeComponent();

            if (File.Exists("ActivityLog.log"))
            {
                richTextBox1.Text = File.ReadAllText("ActivityLog.log");
            }
            else
            {
                File.Create("ActivityLog.log").Dispose();
                richTextBox1.Text = File.ReadAllText("ActivityLog.log");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (File.Exists("ActivityLog.log"))
            {
                richTextBox1.Text = File.ReadAllText("ActivityLog.log");
            }
            else
            {
                File.Create("ActivityLog.log").Dispose();
                richTextBox1.Text = File.ReadAllText("ActivityLog.log");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wyczyścić plik ActivityLog?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                File.WriteAllText("ActivityLog.log", string.Empty);
                richTextBox1.Text = File.ReadAllText("ActivityLog.log");
            }
        }
    }
}
