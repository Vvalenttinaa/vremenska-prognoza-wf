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
    internal class MySqlWeatherStation
    {
        private static readonly string SELECT = "SELECT meteoroloska_stanica.id, adresa.id, adresa.ulica, adresa.broj, grad.naziv, drzava.naziv " +
            "FROM `meteoroloska_stanica` INNER JOIN adresa on meteoroloska_stanica.adresa_id=adresa.id " +
            "INNER JOIN grad ON adresa.grad_id=grad.id " +
            "INNER JOIN drzava ON grad.drzava_id=drzava.id;";
        private static readonly string INSERT = "INSERT INTO meteoroloska_stanica(adresa_id) VALUES (@IdAddress)";
        private static readonly string EXISTS = "SELECT COUNT(*) FROM `meteoroloska_stanica` WHERE adresa_id=@IdAddress";
        private static readonly string SELECT_ID_BY_STATION = "SELECT id FROM `meteoroloska_stanica` WHERE adresa_id=@IdAddress";
        private static readonly string DELETE = "DELETE FROM `meteoroloska_stanica` WHERE id=@Id";
        private static readonly string GET_BY_ID = "SELECT adresa_id FROM `meteoroloska_stanica` WHERE id=@Id;";
        private static readonly string UPDATE = "UPDATE `meteoroloska_stanica` SET adresa_id=@AddressId WHERE id=@Id";


        public void InsertWeatherStation(int idAddress)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@IdAddress", idAddress);
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

        public Boolean existsWeatherStation(int addressId)
        {
            Boolean result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = EXISTS;
                cmd.Parameters.AddWithValue("@IdAddress", addressId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                //     reader = cmd.ExecuteReader();
                if (count > 0)
                {
                    result = true;
                }
                else { result = false; }

            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAccount", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public List<WeatherStation> GetWeatherStations()
        {
            List<WeatherStation> result = new List<WeatherStation>();
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
                    result.Add(new WeatherStation()
                    {
                        ID = reader.GetInt32(0),
                        AddressDetails = new AddressDetails()
                        {
                            ID = reader.GetInt32(1),
                            Street = reader.GetString(2),
                            Number = reader.GetInt32(3),
                            City = reader.GetString(4),
                            Country = reader.GetString(5)
                        }
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

        public int GetId(String street, int number, String city)
        {
            int result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            MySqlAddress mySqlAddress = new MySqlAddress();
            int idAddress  = mySqlAddress.GetId(street, number, city);

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ID_BY_STATION;
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

        public int GetIdByAddressId(int addressId)
        {
            int result ;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;        

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ID_BY_STATION;
                cmd.Parameters.AddWithValue("@IdAddress", addressId);

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
        public WeatherStation GetById(int id)
        {
            WeatherStation result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            MySqlAddress mySqlAddress = new MySqlAddress();
            
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = GET_BY_ID;
                cmd.Parameters.AddWithValue("@Id", id);

                reader = cmd.ExecuteReader();
                reader.Read();
                result = new WeatherStation()
                {
                    ID = id,
                    AddressDetails = mySqlAddress.GetAddressById(reader.GetInt32(0))
                };
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

        public Boolean DeleteStationById(int stationId)
        {

            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@Id", stationId);
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

        public void Update(int AddressId, int Id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@AddressId", AddressId);
                cmd.ExecuteNonQuery();
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
    } 
}
