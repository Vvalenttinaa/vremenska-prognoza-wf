using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VremenskaPrognozaApp.DataAccess.Exceptions;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.DataAccess.MySql
{
    internal class MySqlCity
    {
        private static readonly string SELECT = "SELECT grad.id, grad.naziv, drzava.naziv  FROM `grad`"
                                                + "INNER JOIN drzava ON grad.drzava_id = drzava.id";
        private static readonly string SELECT_BY_COUNTRY_ID = "SELECT grad.id, grad.naziv, grad.drzava_id, drzava.naziv  FROM `grad`"
                                                 + "INNER JOIN drzava ON grad.drzava_id = drzava.id "
                                                 + "WHERE drzava.naziv=@NameCountry;";
        private static readonly string INSERT = "INSERT INTO `grad`(naziv, drzava_id) VALUES (@CityName, @CountryId)";
        private static readonly string UPDATE = "UPDATE `grad` SET naziv=@name, drzava_id=@idCountry WHERE id=@idCity";
        private static readonly string DELETE = "DELETE FROM `grad` WHERE id=@idCity";
        private static readonly string EXISTS = "SELECT COUNT(*) FROM `grad` WHERE naziv=@Name";
        private static readonly string SELECT_ID_BY_NAME = "SELECT id FROM `grad` WHERE naziv=@Name";
        private static readonly string SELECT_NAME_BY_ID = "SELECT naziv FROM `grad` WHERE id=@CityId";



        public Boolean existsCity(string city)
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
                cmd.Parameters.AddWithValue("@Name", city);
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

        public Boolean DeleteCityById(int cityId)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@idCity", cityId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //   throw new DataAccessException("Exception in MySqlCity", ex);
            //    MessageBox.Show("Can't delete already used value!");
                return false;
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return true;
        }

        public List<City> GetCities1()
        {
            List<City> result = new List<City>();
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
                    result.Add(new City()
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Country = reader.GetString(2)
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

        public List<City> GetCitesFromCountry(String country)
        {
            List<City> result = new List<City>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_COUNTRY_ID;
                cmd.Parameters.AddWithValue("@NameCountry", country);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new City()
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Country = reader.GetString(2)
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

        public int GetId(String city)
        {
            int result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ID_BY_NAME;
                cmd.Parameters.AddWithValue("@Name", city);
                reader = cmd.ExecuteReader();
                reader.Read();
                result = reader.GetInt32(0);
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

        public void SaveCity(City city)
        {
            throw new NotImplementedException();
        }

        public void InsertCity(String name, String countryName)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;

            MySqlCountry mySqlCountry = new MySqlCountry();

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@CityName", name);
                cmd.Parameters.AddWithValue("@CountryId", mySqlCountry.GetCountryIdByName(countryName));
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

        public String GetCityNameById(int id)
        {
            String result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_NAME_BY_ID;
                cmd.Parameters.AddWithValue("@CityId", id);
                reader = cmd.ExecuteReader();
                reader.Read();
                result = reader.GetString(0);
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

        public void UpdateCity(City city)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@idCity", city.ID);
                cmd.Parameters.AddWithValue("@name", city.Name);

                MySqlCountry mySqlCountry = new MySqlCountry();
                int countriId = mySqlCountry.GetCountryIdByName(city.Country);

                cmd.Parameters.AddWithValue("@idCountry", countriId);

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
