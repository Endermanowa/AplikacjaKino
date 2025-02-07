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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AplikacjaKino
{
    public partial class NowaRezerwacja : Form
    {
        public Rezerwacja rezerwacja;
        public Seans seans;
        public Miejsca savedMiejsca;

        public NowaRezerwacja()
        {
            InitializeComponent();
        }

        public NowaRezerwacja(int użytkownik)
        {
            InitializeComponent();

            rezerwacja = new Rezerwacja();
            rezerwacja.użytkownik = użytkownik;

            panel1.Visible = false;
            buttonAdd.Visible = false;
        }

        private void buttonSelectSeans_Click(object sender, EventArgs e)
        {
            using (var dialog = new WyborSeansu())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Lokalizacja lokalizacja = DataStorage.Lokalizacje.FirstOrDefault(p => p.id == dialog.selectedLokalizacja);
                    Film film = DataStorage.Filmy.FirstOrDefault(p => p.id == dialog.selectedFilm);
                    seans = DataStorage.Seanse.FirstOrDefault(p => p.id == dialog.selectedSeans);

                    textKino.Text = lokalizacja.nazwa + ", " + lokalizacja.miejscowosc + ", " + lokalizacja.adres;
                    textFilm.Text = film.nazwa;
                    textData.Text = seans.data.ToString();
                    textGodzina.Text = seans.godzina.ToString();

                    rezerwacja.seans = seans.id;

                    panel1.Visible = true;
                }
            }
        }

        private void buttonSelectMiejsca_Click(object sender, EventArgs e)
        {
            savedMiejsca = new Miejsca
            {
                rzedy = seans.miejsca.rzedy,
                kolumny = seans.miejsca.kolumny,
                miejsca = new List<bool>(seans.miejsca.miejsca)
            };

            using (var dialog = new WyborMiejsc(savedMiejsca, (int)textLiczbaBiletow.Value))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    rezerwacja.miejsca = dialog.selectedMiejsca;
                    savedMiejsca = dialog.miejsca;

                    rezerwacja.liczbaBiletów = (int)textLiczbaBiletow.Value;
                    textMiejsca.Text = string.Join(", ", rezerwacja.miejsca);

                    buttonAdd.Visible = true;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            seans.miejsca = savedMiejsca;

            DatabaseHelper db = new DatabaseHelper();
            db.AddRezerwacjaToDatabase(rezerwacja);
            db.UpdateSeansMiejscaInDatabase(seans);

            DataStorage.Seanse = db.GetAllSeanse();
            DataStorage.Rezerwacje = db.GetAllRezerwacje();

            DialogResult = DialogResult.OK;
        }

        private void textLiczbaBiletow_ValueChanged(object sender, EventArgs e)
        {
            buttonAdd.Visible = false;
        }
    }
}
