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
    public class MySqlWind
    {
        private static readonly string SELECT = "SELECT mjerenje_id, jacina_udara, pravac, opis, vjetar_id FROM `vjetar_mjerenje`;";
        private static readonly string INSERT = "INSERT INTO vjetar_mjerenje(mjerenje_id, jacina_udara, pravac, opis, vjetar_id) VALUES (@Id, @Jacina, @Pravac, @Opis, @VjetarId);";
        private static readonly string UPDATE = "UPDATE `vjetar_mjerenje` SET jacina_udara=@Jacina AND pravac=@Pravac AND opis=@Opis AND vjetar_id=@VjetarId WHERE mjerenje_id=@Id);";
        private static readonly string DELETE = "DELETE FROM `vjetar_mjerenje` WHERE mjerenje_id=@Id;";
        private static readonly string SELECT_BY_ID = "SELECT jacina_udara, pravac, opis, vjetar_id FROM vjetar_mjerenje WHERE mjerenje_id=@Id;";

        public void InsertWind(Wind wind)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;

            MySqlWindName mySqlWindName = new MySqlWindName();
            int idWind = mySqlWindName.GetIdByName(wind.Name);
            try
            {

                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Id", wind.Measurement.ID);
                cmd.Parameters.AddWithValue("@Jacina", wind.Strength);
                cmd.Parameters.AddWithValue("@Pravac", wind.Direction);
                cmd.Parameters.AddWithValue("@Opis", wind.Description);
                cmd.Parameters.AddWithValue("@VjetarId", idWind);

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

        public Wind getWindById(int id)
        {
            Wind result = null;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            MySqlMeasurement mySqlMeasurement = new MySqlMeasurement();
            MySqlWindName mySqlWindName = new MySqlWindName();

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_ID;
                cmd.Parameters.AddWithValue("@Id", id);

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = new Wind()
                    {
                        Measurement = mySqlMeasurement.getMeasurenmentById(id),
                        Strength = reader.GetString(0),
                        Direction = reader.GetString(1),
                        Description = reader.GetString(2),
                        Name = mySqlWindName.getById(reader.GetInt32(3)).Name
                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlCountry", ex);
             //   return null;
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }


    }
}
