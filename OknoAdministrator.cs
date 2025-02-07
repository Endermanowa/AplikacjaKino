using AplikacjaKino.UserControls;
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
    public partial class OknoAdministrator : Form
    {
        private Użytkownik użytkownik;

        public OknoAdministrator()
        {
            InitializeComponent();

            tabPage1.Controls.Clear();

            WidokLogs widokLogs = new WidokLogs();
            widokLogs.Dock = DockStyle.Fill;

            tabPage1.Controls.Add(widokLogs);
        }

        public OknoAdministrator(Użytkownik użytkownik)
        {
            InitializeComponent();

            tabPage1.Controls.Clear();

            WidokLogs widokLogs = new WidokLogs();
            widokLogs.Dock = DockStyle.Fill;

            tabPage1.Controls.Add(widokLogs);

            this.użytkownik = użytkownik;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex)
            {
                case 0:
                    tabPage1.Controls.Clear();

                    WidokLogs widokLogs = new WidokLogs();
                    widokLogs.Dock = DockStyle.Fill;

                    tabPage1.Controls.Add(widokLogs);
                    break;
                case 1:
                    tabPage2.Controls.Clear();

                    WidokLokalizacjeAdmin widokLokalizacje = new WidokLokalizacjeAdmin();
                    widokLokalizacje.Dock = DockStyle.Fill;

                    tabPage2.Controls.Add(widokLokalizacje);
                    break;
                case 2:
                    tabPage3.Controls.Clear();

                    WidokFilmyAdmin widokFilmy = new WidokFilmyAdmin(użytkownik);
                    widokFilmy.Dock = DockStyle.Fill;

                    tabPage3.Controls.Add(widokFilmy);
                    break;
                case 3:
                    tabPage4.Controls.Clear();

                    WidokUżytkownicy widokUżytkownicy = new WidokUżytkownicy(użytkownik);
                    widokUżytkownicy.Dock = DockStyle.Fill;

                    tabPage4.Controls.Add(widokUżytkownicy);
                    break;

            }
        }
    }
}
