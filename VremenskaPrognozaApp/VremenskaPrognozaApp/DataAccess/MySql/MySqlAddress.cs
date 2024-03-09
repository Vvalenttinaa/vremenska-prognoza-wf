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
    internal class MySqlAddress
    {
        private static readonly string SELECT_ALL = "SELECT adresa.id, adresa.ulica, adresa.broj, grad.naziv, drzava.naziv FROM `adresa`" + 
                                                    "INNER JOIN grad ON grad.id=adresa.grad_id " +
                                                    "INNER JOIN drzava ON drzava.id=grad.drzava_id";
        private static readonly string INSERT = "INSERT INTO adresa (ulica, broj, grad_id) VALUES (@Street, @Number, @CityId)";
        private static readonly string SELECT_BY_CITY_ID = "SELECT adresa.id, adresa.ulica, adresa.broj, adresa.grad_id FROM `adresa`"
                                                 + "INNER JOIN grad ON adresa.grad_id = grad.id "
                                                 + "WHERE grad.naziv=@NameCity;";
        private static readonly string EXISTS = "SELECT COUNT(*) FROM `adresa` WHERE ulica=@Name AND broj=@Number AND grad_id=@CityId";
        private static readonly string SELECT_ID_BY_ADDRESS = "SELECT id FROM `adresa` WHERE ulica=@Street AND broj=@Number AND grad_id=@CityId";
        private static readonly string SELECT_ADDRESS_BY_ID = "SELECT adresa.ulica, adresa.broj, grad.naziv, drzava.naziv FROM `adresa`" +
                                                             "INNER JOIN grad ON grad.id=adresa.grad_id " +
                                                             "INNER JOIN drzava ON drzava.id=grad.drzava_id WHERE adresa.id=@Id;";
        private static readonly string DELETE = "DELETE FROM `adresa` WHERE id=@Id";


        public List<AddressDetails> GetAdresses()
        {
            List<AddressDetails> result = new List<AddressDetails>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ALL;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new AddressDetails()
                    {
                        ID = reader.GetInt32(0),
                        Street = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        City = reader.GetString(3),
                        Country = reader.GetString(4),
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

        public List<Address> GetAdressesFromCity(String city)
        {
            List<Address> result = new List<Address>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_CITY_ID;
                cmd.Parameters.AddWithValue("@NameCity", city);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Address()
                    {
                        ID = reader.GetInt32(0),
                        StreetName = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        CityId = reader.GetInt32(3)
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
        public void InsertAdress(String street, int number, int cityId)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Street", street);
                cmd.Parameters.AddWithValue("@Number", number);
                cmd.Parameters.AddWithValue("@CityId", cityId);
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

        public Boolean existsAddress(string street, int number, int cityId)
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
                cmd.Parameters.AddWithValue("@Name", street);
                cmd.Parameters.AddWithValue("@Number", number);
                cmd.Parameters.AddWithValue("@CityId", cityId);
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

        public int GetId(String street, int number, String city)
        {
            int result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;


            int cityId;
            MySqlCity mySqlCity = new MySqlCity();
            cityId = mySqlCity.GetId(city);

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ID_BY_ADDRESS;
                cmd.Parameters.AddWithValue("@Street", street);
                cmd.Parameters.AddWithValue("@Number", number);
                cmd.Parameters.AddWithValue("CityId", cityId);
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

        public AddressDetails GetAddressById(int id)
        {
            AddressDetails result = null;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            MySqlCity mySqlCity = new MySqlCity();

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ADDRESS_BY_ID;
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = new AddressDetails()
                    {
                        ID = id,
                        Street = reader.GetString(0),
                        Number = reader.GetInt32(1),
                        City = reader.GetString(2),
                        Country = reader.GetString(3)
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
        public Boolean DeleteAddressById(int addressId)
        {

            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@Id", addressId);
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

    }
}
