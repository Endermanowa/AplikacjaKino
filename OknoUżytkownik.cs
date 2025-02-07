using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaKino.Entities;
using AplikacjaKino.UserControls;
using static System.Net.Mime.MediaTypeNames;

namespace AplikacjaKino
{
    public partial class OknoUżytkownik : Form
    {
        private Użytkownik użytkownik;
        public OknoUżytkownik()
        {
            InitializeComponent();
            użytkownik = new Użytkownik();

            tabPage1.Controls.Clear();

            WidokLokalizacjeUser widoLokalizacje = new WidokLokalizacjeUser();
            widoLokalizacje.Dock = DockStyle.Fill;

            tabPage1.Controls.Add(widoLokalizacje);
        }

        public OknoUżytkownik(Użytkownik user)
        {
            InitializeComponent();
            this.użytkownik = user;

            tabPage1.Controls.Clear();

            WidokLokalizacjeUser widokLokalizacje = new WidokLokalizacjeUser();
            widokLokalizacje.Dock = DockStyle.Fill;

            tabPage1.Controls.Add(widokLokalizacje);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    tabPage1.Controls.Clear();

                    WidokLokalizacjeUser widokLokalizacje = new WidokLokalizacjeUser();
                    widokLokalizacje.Dock = DockStyle.Fill;

                    tabPage1.Controls.Add(widokLokalizacje);
                    break;
                case 1:
                    tabPage2.Controls.Clear();

                    WidokFilmyUser widokFilmy = new WidokFilmyUser();
                    widokFilmy.Dock = DockStyle.Fill;

                    tabPage2.Controls.Add(widokFilmy);
                    break;
                case 2:
                    tabPage3.Controls.Clear();

                    WidokRezerwacjeUser widokRezerwacje = new WidokRezerwacjeUser(użytkownik);
                    widokRezerwacje.Dock = DockStyle.Fill;

                    tabPage3.Controls.Add(widokRezerwacje);
                    break;
            }
        }
    }
}
