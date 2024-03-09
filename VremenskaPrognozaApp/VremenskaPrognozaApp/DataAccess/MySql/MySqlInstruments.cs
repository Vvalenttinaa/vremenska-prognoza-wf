using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.Exceptions;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.DataAccess.MySql
{
    internal class MySqlInstruments
    {
        private static readonly string SELECT = "SELECT lokacija_instrumenata.id, adresa.id, adresa.ulica, adresa.broj, grad.naziv, drzava.naziv, meteoroloska_stanica_id " +
            "FROM `lokacija_instrumenata` INNER JOIN adresa on lokacija_instrumenata.adresa_id=adresa.id " +
            "INNER JOIN grad ON adresa.grad_id=grad.id " +
            "INNER JOIN drzava ON grad.drzava_id=drzava.id;";
        private static readonly string INSERT = "INSERT INTO lokacija_instrumenata(adresa_id, meteoroloska_stanica_id) VALUES (@IdAddress, @IdStation)";
        private static readonly string EXISTS = "SELECT COUNT(*) FROM `meteoroloska_stanica` WHERE adresa_id=@IdAddress";
        private static readonly string SELECT_ID_BY_ADDRESS = "SELECT id FROM `lokacija_instrumenata` WHERE adresa_id=@IdAddress";
        private static readonly string DELETE = "DELETE FROM `lokacija_instrumenata` WHERE id=@Id";
        private static readonly string SELECT_BY_ID = "SELECT lokacija_instrumenata.id, adresa.id, adresa.ulica, adresa.broj, grad.naziv, drzava.naziv, meteoroloska_stanica_id " +
                        "FROM `lokacija_instrumenata` INNER JOIN adresa on lokacija_instrumenata.adresa_id=adresa.id " + 
                        "INNER JOIN grad ON adresa.grad_id=grad.id " +
                        "INNER JOIN drzava ON grad.drzava_id=drzava.id WHERE lokacija_instrumenata.id=@Id;";


        public List<WeatherInstruments> GetInstruments()
        {
            List<WeatherInstruments> result = new List<WeatherInstruments>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new WeatherInstruments()
                    {
                        ID = reader.GetInt32(0),
                        AddressDetails = new AddressDetails()
                        {
                            ID = reader.GetInt32(1),
                            Street = reader.GetString(2),
                            Number = reader.GetInt32(3),
                            City = reader.GetString(4),
                            Country = reader.GetString(5)
                        },
                        WeatherStation = reader.GetInt32(6)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlCountry", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void InsertInstruments(int idAddress, int idStation)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@IdAddress", idAddress);
                cmd.Parameters.AddWithValue("@IdStation", idStation);
                cmd.ExecuteNonQuery();
                // country.ID = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlCountry", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public Boolean DeleteInstrumentsById(int instrumentsId)
        {

            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@Id", instrumentsId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // throw new DataAccessException("Exception in MySqlCountry", ex);
                return false;
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return true;
        }

        public int GetId(String street, int number, String city)
        {
            int result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            MySqlAddress mySqlAddress = new MySqlAddress();
            int idAddress = mySqlAddress.GetId(street, number, city);

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ID_BY_ADDRESS;
                cmd.Parameters.AddWithValue("@IdAddress", idAddress);

                reader = cmd.ExecuteReader();
                reader.Read();
                result = reader.GetInt32(0);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAddress", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public WeatherInstruments GetInstrumentsById(int id)
        {
            
            WeatherInstruments result = null;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            MySqlCity mySqlCity = new MySqlCity();
            MySqlAddress mySqlAddress = new MySqlAddress();
            MySqlWeatherStation mySqlWeatherStation = new MySqlWeatherStation();

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_ID;
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    result = new WeatherInstruments()
                    {
                        ID = id,
                        AddressDetails = mySqlAddress.GetAddressById(reader.GetInt32(0)),
                        WeatherStation = reader.GetInt32(1),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAddress", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
    }
}
