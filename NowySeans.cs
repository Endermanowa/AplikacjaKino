using AplikacjaKino.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaKino
{
    public partial class NowySeans : Form
    {
        Seans seans = new Seans();

        public NowySeans()
        {
            InitializeComponent();

            seans = new Seans();

            textData.Value = DateTime.Today;
        }

        private void buttonSelectSala_Click(object sender, EventArgs e)
        {
            using (var dialog = new WyborSali())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Sala sala = DataStorage.Sale.FirstOrDefault(p => p.id == dialog.selectedSala);

                    textSala.Text = sala.numer + ", miejsca: " + sala.liczbaMiejsc.ToString();

                    seans.sala = sala.id;
                    seans.miejsca = sala.miejsca;
                }
            }
        }

        private void buttonSelectFilm_Click(object sender, EventArgs e)
        {
            using (var dialog = new WyborFilmu())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Film film = DataStorage.Filmy.FirstOrDefault(p => p.id == dialog.selectedFilm);

                    textFilm.Text = film.nazwa;

                    seans.film = dialog.selectedFilm;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            seans.data = DateOnly.FromDateTime(textData.Value);
            seans.godzina = TimeOnly.FromDateTime(textGodzina.Value);
            seans.typ = textTyp.Text;
            seans.jezyk = textJęzyk.Text;

            DatabaseHelper db = new DatabaseHelper();
            db.AddSeansToDatabase(seans);

            DataStorage.Seanse = db.GetAllSeanse();

            DialogResult = DialogResult.OK;
        }
    }
}
