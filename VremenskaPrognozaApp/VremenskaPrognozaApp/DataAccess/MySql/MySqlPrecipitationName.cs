using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VremenskaPrognozaApp.DataAccess.Exceptions;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.DataAccess.MySql
{
    public class MySqlPrecipitationName
    {
        private static readonly string SELECT = "SELECT id, naziv FROM `padavine` ORDER BY naziv";
        private static readonly string INSERT = "INSERT INTO padavine(naziv) VALUES (@Name)";
        private static readonly string UPDATE = "UPDATE `padavine` SET naziv=@Name WHERE id=@Id";
        private static readonly string DELETE = "DELETE FROM `padavine` WHERE id=@Id";
        private static readonly string SELECT_BY_ID = "SELECT naziv FROM padavine WHERE id=@Id";
        private static readonly string SELECT_ID_BY_NAME = "SELECT id FROM padavine WHERE naziv=@Name";



        public void Insert(String name)

        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlPrec", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public PrecipitationName getById(int id)
        {
            PrecipitationName result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_ID;
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();
                reader.Read();
                result = new PrecipitationName()
                {
                    ID = id,
                    Name = reader.GetString(0)
                };
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlPrecip", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public int GetIdByName(String name)
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
                cmd.Parameters.AddWithValue("@Name", name);
                reader = cmd.ExecuteReader();
                reader.Read();
                result = reader.GetInt32(0);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlPrecip", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public List<PrecipitationName> GetAll()
        {
            List<PrecipitationName> result = new List<PrecipitationName>();
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
                    result.Add(new PrecipitationName()
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
    }
}
