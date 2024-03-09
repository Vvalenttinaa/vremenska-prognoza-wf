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
    public class MySqlWindName
    {
        private static readonly string SELECT = "SELECT id, naziv FROM `vjetar`";
        private static readonly string INSERT = "INSERT INTO vjetar(naziv) VALUES (@Name)";
        private static readonly string UPDATE = "UPDATE `vjetar` SET naziv=@Name WHERE id=@Id";
        private static readonly string DELETE = "DELETE FROM `vjetar` WHERE id=@Id";
        private static readonly string SELECT_BY_ID = "SELECT naziv FROM vjetar WHERE id=@Id";
        private static readonly string SELECT_ID_BY_NAME = "SELECT id FROM vjetar WHERE naziv=@Name";


        public void InsertWindName(String name)
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
                throw new DataAccessException("Exception in MySqlCountry", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public WindName getById(int id)
        {
            WindName result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            MySqlMeasurement mySqlMeasurement = new MySqlMeasurement();

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_ID;
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();
                reader.Read();
                result = new WindName()
                {
                    ID = id,
                    Name = reader.GetString(0)
                };
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
                throw new DataAccessException("Exception in MySqlWindName", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public List<WindName> GetAll()
        {
            List<WindName> result = new List<WindName>();
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
                    result.Add(new WindName()
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlWindName", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }


    }
}
