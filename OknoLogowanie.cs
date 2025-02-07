using AplikacjaKino.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AplikacjaKino
{
    public partial class OknoLogowanie : Form
    {
        public OknoLogowanie()
        {
            InitializeComponent();

            if (!File.Exists("ActivityLog.log"))
            {
                File.Create("ActivityLog.log").Close();
            }

            AppContext.SetSwitch("Npgsql.EnableDateOnlyTimeOnlySupport", true);
            LoadData();
        }

        private void LoadData()
        {
            DatabaseHelper db = new DatabaseHelper();

            DataStorage.Lokalizacje = db.GetAllLokalizacje();

            DataStorage.Filmy = db.GetAllFilmy();

            DataStorage.Użytkownicy = db.GetAllUżytkownicy();

            DataStorage.Sale = db.GetAllSale();

            DataStorage.Seanse = db.GetAllSeanse();

            DataStorage.Rezerwacje = db.GetAllRezerwacje();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxImię.Text == "" || textBoxNazwisko.Text == "" || textBoxTelefon.Text == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola logowania!", "", MessageBoxButtons.OK);
            }
            else
            {
                Użytkownik użytkownik = DataStorage.Użytkownicy.FirstOrDefault(p => p.imie == textBoxImię.Text && p.nazwisko == textBoxNazwisko.Text && p.numerTelefonu == textBoxTelefon.Text.Replace(" ", ""));

                try
                {
                    if (użytkownik == null)
                    {
                        throw new UserNotFoundException();
                    }
                    else
                    {
                        if (użytkownik.admin)
                        {
                            OknoAdministrator oknoAdministrator = new OknoAdministrator(użytkownik);
                            oknoAdministrator.FormClosed += (s, args) => this.Close();
                            oknoAdministrator.Show();
                            Hide();
                        }
                        else
                        {
                            OknoUżytkownik oknoUżytkownik = new OknoUżytkownik(użytkownik);
                            oknoUżytkownik.FormClosed += (s, args) => this.Close();
                            oknoUżytkownik.Show();
                            Hide();
                        }
                    }
                }
                catch (UserNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
                }

            }
        }
    }
}
