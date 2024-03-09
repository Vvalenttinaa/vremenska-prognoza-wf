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
    public class MySqlTemperature
    {
        private static readonly string SELECT = "SELECT mjerenje_id, vrijednost FROM `temperatura`";
        private static readonly string INSERT = "INSERT INTO temperatura(mjerenje_id, vrijednost) VALUES (@Id, @Value)";
        private static readonly string UPDATE = "UPDATE `temperatura` SET vrijednost=@Value WHERE mjerenje_id=@Id";
        private static readonly string DELETE = "DELETE FROM `temperatura` WHERE mjerenje_id=@Id";
        private static readonly string SELECT_BY_ID = "SELECT vrijednost FROM temperatura WHERE mjerenje_id=@Id";

            public void InsertTemperature(Temperature temperature)
            {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Id", temperature.Measurenment.ID);
                cmd.Parameters.AddWithValue("@Value", temperature.Value);
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

        public Temperature getTemperatureById(int id)
        {
            Temperature result = null;
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
                if (reader.Read())
                {
                    result = new Temperature()
                    {
                        Measurenment = mySqlMeasurement.getMeasurenmentById(id),
                        Value = reader.GetInt32(0)
                    };
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
        public Boolean DeleteById(int Id)
        {

            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@Id", Id);
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

        public void Update(Temperature temperature)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Id", temperature.Measurenment.ID);
                cmd.Parameters.AddWithValue("@Value", temperature.Value);
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
