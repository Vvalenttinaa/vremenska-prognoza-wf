using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using VremenskaPrognozaApp.DataAccess.Exceptions;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.DataAccess.MySql
{
    internal class MySqlCountry
    {
        private static readonly string SELECT = "SELECT id, naziv FROM `drzava` ORDER BY naziv";
        private static readonly string INSERT = "INSERT INTO drzava(naziv) VALUES (@naziv)";
        private static readonly string UPDATE = "UPDATE `drzava` SET naziv=@naziv WHERE id=@id";
        private static readonly string DELETE = "DELETE FROM `drzava` WHERE id=@id";
        private static readonly string SELECT_COUNTRY_ID_BY_NAME = "SELECT id FROM drzava WHERE naziv=@CountryName";
        private static readonly string EXISTS = "SELECT COUNT(*) FROM `drzava` WHERE naziv=@Name";
        private static readonly string SELECT_COUNTRY_NAME_BY_ID = "SELECT naziv FROM drzava WHERE id=@CountryId";

        public Boolean existsCountry(string country)
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
                cmd.Parameters.AddWithValue("@Name", country);
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


        public Boolean DeleteCountryById(int countryId)
        {
            
                MySqlConnection conn = null;
                MySqlCommand cmd;
                try
                {
                    conn = MySqlUtil.GetConnection();
                    cmd = conn.CreateCommand();
                    cmd.CommandText = DELETE;
                    cmd.Parameters.AddWithValue("@id", countryId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                  //  throw new DataAccessException("Exception in MySqlCountry", ex);
                    return false;
                }
                finally
                {
                    MySqlUtil.CloseQuietly(conn);
                }
            return true;
        }

        public List<Country> GetCountries()
        {
            List<Country> result = new List<Country>();
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
                    result.Add(new Country()
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1)
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
        public int GetCountryIdByName(String name)
        {
            int result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_COUNTRY_ID_BY_NAME;
                cmd.Parameters.AddWithValue("@CountryName", name);
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

        public String GetCountryNameById(int id)
        {
            String result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_COUNTRY_NAME_BY_ID;
                cmd.Parameters.AddWithValue("@CountryId", id);
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

        public void SaveCountry(Country country)
        {
            if (country.ID <= 0)
            {
                InsertCountry(country.Name);
            }
            else
            {
                UpdateCountry(country);
            }
        }

        public void InsertCountry(String country)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@naziv", country);
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

        public void UpdateCountry(Country country)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@id", country.ID);
                cmd.Parameters.AddWithValue("@naziv", country.Name);
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
