using Npgsql;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Reflection;
using System.Diagnostics;

namespace AplikacjaKino.Entities
{
    public class DatabaseHelper
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=kino;";

        public List<Film> GetAllFilmy()
        {
            List<Film> filmy = new List<Film>();

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, nazwa, gatunki, dlugosc FROM filmy";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var film = new Film(
                                    reader.GetInt32(reader.GetOrdinal("id")), 
                                    reader.GetString(reader.GetOrdinal("nazwa")),
                                    reader.GetString(reader.GetOrdinal("gatunki")),
                                    reader.GetInt32(reader.GetOrdinal("dlugosc"))
                                    );

                                filmy.Add(film);
                            }
                        }
                    }
                }
                ImportSuccess<Film>();
            }
            catch (Exception ex)
            {
                ImportError<Film>();
            }

            return filmy;
        }

        public List<Lokalizacja> GetAllLokalizacje()
        {
            List<Lokalizacja> lokalizacje = new List<Lokalizacja>();

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, nazwa, miejscowosc, adres FROM lokalizacje";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var lokalizacja = new Lokalizacja(
                                    reader.GetInt32(reader.GetOrdinal("id")),
                                    reader.GetString(reader.GetOrdinal("nazwa")),
                                    reader.GetString(reader.GetOrdinal("miejscowosc")),
                                    reader.GetString(reader.GetOrdinal("adres"))
                                    );

                                lokalizacje.Add(lokalizacja);
                            }
                        }
                    }
                }
                ImportSuccess<Lokalizacja>();
            }
            catch (Exception ex)
            {
                ImportError<Lokalizacja>();
            }

            return lokalizacje;
        }

        public List<Rezerwacja> GetAllRezerwacje()
        {
            List<Rezerwacja> rezerwacje = new List<Rezerwacja>();

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, uzytkownik, seans, liczba_biletow, miejsca FROM rezerwacje";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var rezerwacja = new Rezerwacja(
                                    reader.GetInt32(reader.GetOrdinal("id")),
                                    reader.GetInt32(reader.GetOrdinal("uzytkownik")),
                                    reader.GetInt32(reader.GetOrdinal("seans")),
                                    reader.GetInt32(reader.GetOrdinal("liczba_biletow")),
                                    JsonConvert.DeserializeObject<List<string>>(reader.GetString(reader.GetOrdinal("miejsca")))
                                    );

                                rezerwacje.Add(rezerwacja);
                            }
                        }
                    }
                }
                ImportSuccess<Rezerwacja>();
            }
            catch (Exception ex)
            {
                ImportError<Rezerwacja>();
            }

            return rezerwacje;
        }

        public List<Sala> GetAllSale()
        {
            List<Sala> sale = new List<Sala>();

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, lokalizacja, numer, liczba_miejsc, miejsca FROM sale";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var sala = new Sala(
                                    reader.GetInt32(reader.GetOrdinal("id")),
                                    reader.GetInt32(reader.GetOrdinal("lokalizacja")),
                                    reader.GetString(reader.GetOrdinal("numer")),
                                    reader.GetInt32(reader.GetOrdinal("liczba_miejsc")),
                                    JsonConvert.DeserializeObject<Miejsca>(reader.GetString(reader.GetOrdinal("miejsca")))
                                    );

                                sale.Add(sala);
                            }
                        }
                    }
                }
                ImportSuccess<Sala>();
            }
            catch (Exception ex)
            {
                ImportError<Sala>();
            }

            return sale;
        }

        public List<Seans> GetAllSeanse()
        {
            List<Seans> seanse = new List<Seans>();

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, film, sala, data, godzina, typ, jezyk, miejsca FROM seanse";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var seans = new Seans(
                                    reader.GetInt32(reader.GetOrdinal("id")),
                                    reader.GetInt32(reader.GetOrdinal("film")),
                                    reader.GetInt32(reader.GetOrdinal("sala")),
                                    reader.GetFieldValue<DateOnly>(reader.GetOrdinal("data")),
                                    reader.GetFieldValue<TimeOnly>(reader.GetOrdinal("godzina")),
                                    reader.GetString(reader.GetOrdinal("typ")),
                                    reader.GetString(reader.GetOrdinal("jezyk")),
                                    JsonConvert.DeserializeObject<Miejsca>(reader.GetString(reader.GetOrdinal("miejsca")))
                                );

                                seans.lokalizacja = DataStorage.Sale.FirstOrDefault(p => p.id == seans.sala).lokalizacja;

                                seanse.Add(seans);
                            }
                        }
                    }
                }
                ImportSuccess<Seans>();
            }
            catch (Exception ex)
            {
                ImportError<Seans>();
            }

            return seanse;
        }

        public List<Użytkownik> GetAllUżytkownicy()
        {
            List<Użytkownik> użytkownicy = new List<Użytkownik>();

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, imie, nazwisko, numer_telefonu, admin FROM uzytkownicy";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var użytkownik = new Użytkownik(
                                    reader.GetInt32(reader.GetOrdinal("id")),
                                    reader.GetString(reader.GetOrdinal("imie")),
                                    reader.GetString(reader.GetOrdinal("nazwisko")),
                                    reader.GetString(reader.GetOrdinal("numer_telefonu")),
                                    reader.GetBoolean(reader.GetOrdinal("admin"))
                                    );

                                użytkownicy.Add(użytkownik);
                            }
                        }
                    }
                }
                ImportSuccess<Użytkownik>();
            }
            catch (Exception ex)
            {
                ImportError<Użytkownik>();
            }

            return użytkownicy;
        }

        public void AddRezerwacjaToDatabase(Rezerwacja rezerwacja)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    INSERT INTO rezerwacje (uzytkownik, seans, liczba_biletow, miejsca)
                    VALUES (@uzytkownik, @seans, @liczba_biletow, @miejsca);";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("uzytkownik", rezerwacja.użytkownik);
                        cmd.Parameters.AddWithValue("seans", rezerwacja.seans);
                        cmd.Parameters.AddWithValue("liczba_biletow", rezerwacja.liczbaBiletów);
                        cmd.Parameters.AddWithValue("miejsca", NpgsqlTypes.NpgsqlDbType.Jsonb, JsonConvert.SerializeObject(rezerwacja.miejsca));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        public void AddSeansToDatabase(Seans seans)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    INSERT INTO seanse (film, sala, data, godzina, typ, jezyk, miejsca)
                    VALUES (@film, @sala, @data, @godzina, @typ, @jezyk, @miejsca);";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("film", seans.film);
                        cmd.Parameters.AddWithValue("sala", seans.sala);
                        cmd.Parameters.AddWithValue("data", seans.data);
                        cmd.Parameters.AddWithValue("godzina", seans.godzina);
                        cmd.Parameters.AddWithValue("typ", seans.typ);
                        cmd.Parameters.AddWithValue("jezyk", seans.jezyk);
                        cmd.Parameters.AddWithValue("miejsca", NpgsqlTypes.NpgsqlDbType.Jsonb, JsonConvert.SerializeObject(seans.miejsca));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        public void UpdateSeansInDatabase(Seans seans)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        UPDATE seanse
                        SET film = @film,
                            sala = @sala,
                            data = @data,
                            godzina = @godzina,
                            typ = @typ,
                            jezyk = @jezyk
                        WHERE id = @id;";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("film", seans.film);
                        cmd.Parameters.AddWithValue("sala", seans.sala);
                        cmd.Parameters.AddWithValue("data", seans.data);
                        cmd.Parameters.AddWithValue("godzina", seans.godzina);
                        cmd.Parameters.AddWithValue("typ", seans.typ);
                        cmd.Parameters.AddWithValue("jezyk", seans.jezyk);
                        cmd.Parameters.AddWithValue("id", seans.id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        public void UpdateSeansMiejscaInDatabase(Seans seans)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        UPDATE seanse
                        SET miejsca = @miejsca
                        WHERE id = @id;";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("miejsca", NpgsqlTypes.NpgsqlDbType.Jsonb, JsonConvert.SerializeObject(seans.miejsca));
                        cmd.Parameters.AddWithValue("id", seans.id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        public void RemoveSeansFromDatabase(int id)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    DELETE FROM seanse
                    WHERE id = @id;";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id", id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można usunąć użytkownika z powodu aktywnych rezerwacji");
            }
        }

        public void RemoveRezerwacjaFromDatabase(int id)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    DELETE FROM rezerwacje
                    WHERE id = @id;";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id", id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        public void RemoveUżytkownikFromDatabase(int id)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    DELETE FROM uzytkownicy
                    WHERE id = @id;";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id", id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można usunąć użytkownika z powodu aktywnych rezerwacji");
            }
        }

        public static void ImportSuccess<T>()
        {
            Type type = typeof(T);
            var attribute = type.GetCustomAttribute<TabelaAttribute>();

            if (attribute != null)
            {
                Debug.WriteLine($"Pomyślnie załadowano tabelę: {attribute.Nazwa}");
            }
            else
            {
                Debug.WriteLine("Podana klasa nie posiada atrybutu 'Tabela'");
            }
        }

        public static void ImportError<T>() 
        {
            Type type = typeof(T);
            var attribute = type.GetCustomAttribute<TabelaAttribute>();

            if (attribute != null)
            {
                Debug.WriteLine($"Błąd operacji na tabeli: {attribute.Nazwa}");
            }
            else
            {
                Debug.WriteLine("Podana klasa nie posiada atrybutu 'Tabela'");
            }
        }
    }
}
