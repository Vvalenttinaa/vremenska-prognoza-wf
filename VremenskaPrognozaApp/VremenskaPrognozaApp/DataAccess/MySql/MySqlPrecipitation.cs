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
    public class MySqlPrecipitation
    {
        private static readonly string SELECT = "SELECT mjerenje_id, padavine_id, opis, vjerovatnoca, kolicina FROM `padavine_mjerenje`'";
        private static readonly string INSERT = "INSERT INTO padavine_mjerenje(mjerenje_id, padavine_id, opis, vjerovatnoca, kolicina) VALUES (@Id, @IdPadavine, @Opis, @Vjerovatnoca, @Kolicina);";
        private static readonly string UPDATE = "UPDATE `padavine_mjerenje` SET padavine_id=@IdPadavine AND opis=@Opis AND vjerovatnoca=@Vjerovatnoca AND kolicina=@Kolicina WHERE mjerenje_id=@Id);";
        private static readonly string DELETE = "DELETE FROM `padavine_mjerenje` WHERE mjerenje_id=@Id;";
        private static readonly string SELECT_BY_ID = "SELECT padavine_id, opis, vjerovatnoca, kolicina FROM padavine_mjerenje WHERE mjerenje_id=@Id;";

        public void Insert(Precipitation precipitation)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;

            MySqlPrecipitationName mySqlPrecipitationName = new MySqlPrecipitationName();
            try
            {

                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Id", precipitation.Measurement.ID);
                cmd.Parameters.AddWithValue("@IdPadavine", mySqlPrecipitationName.GetIdByName(precipitation.Name));
                cmd.Parameters.AddWithValue("@Opis", precipitation.Description);
                cmd.Parameters.AddWithValue("@Vjerovatnoca", precipitation.Probability);
                cmd.Parameters.AddWithValue("@Kolicina", precipitation.Amount);

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

        public Precipitation getById(int id)
        {
            Precipitation result = null;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            MySqlMeasurement mySqlMeasurement = new MySqlMeasurement();
            MySqlPrecipitationName mySqlName = new MySqlPrecipitationName();

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_ID;
                cmd.Parameters.AddWithValue("@Id", id);

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = new Precipitation()
                    {
                        Measurement = mySqlMeasurement.getMeasurenmentById(id),
                        Name = mySqlName.getById(reader.GetInt32(0)).Name,
                        Description = reader.GetString(1),
                        Probability = reader.GetString(2),
                        Amount = reader.GetString(3)
                    };

                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlPrec", ex);
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

        public void Update(Precipitation precipitation)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;

            MySqlPrecipitationName mySqlPrecipitationName = new MySqlPrecipitationName();
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Id", precipitation.Measurement.ID);
                cmd.Parameters.AddWithValue("@IdPadavine", mySqlPrecipitationName.GetIdByName(precipitation.Name));
                cmd.Parameters.AddWithValue("@Opis", precipitation.Description);
                cmd.Parameters.AddWithValue("@Vjerovatnoca", precipitation.Probability);
                cmd.Parameters.AddWithValue("@Kolicina", precipitation.Amount);

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
