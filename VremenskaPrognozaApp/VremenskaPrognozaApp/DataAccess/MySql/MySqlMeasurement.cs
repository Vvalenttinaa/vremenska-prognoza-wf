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
    internal class MySqlMeasurement
    {
        private static readonly string EXISTS_BY_USER = "SELECT COUNT(*) FROM `mjerenje` WHERE zaposleni_osoba_id=@IdEmployee";
        private static readonly string SELECT_ALL = "SELECT id_mjerenje, vrijeme_mjerenja, zaposleni_osoba_id, adresa_id, lokacija_instrumenata_id  FROM `mjerenje`;";
        private static readonly string SELECT_BY_ID = "SELECT vrijeme_mjerenja, zaposleni_osoba_id, adresa_id, lokacija_instrumenata_id  FROM `mjerenje` WHERE id_mjerenje=@Id;";
        private static readonly string INSERT = "INSERT INTO `mjerenje` (vrijeme_mjerenja, zaposleni_osoba_id, adresa_id, lokacija_instrumenata_id) VALUES (@TimeAndData, @EmployeeId, @AddressId, @InstrumentsLocationId);";
        private static readonly string UPDATE = "UPDATE `mjerenje` SET vrijeme_mjerenja=@DataAndTime, zaposleni_osoba_id=@EmployeeId, adresa_id=@AddressId, lokacija_instrumenata_id=@InstrumentsLocationId Where id_mjerenje=@Id";
        private static readonly string SELECT_ALL_BY_EMPLOYEE_ID = "SELECT id_mjerenje, vrijeme_mjerenja, adresa_id, lokacija_instrumenata_id  FROM `mjerenje` WHERE zaposleni_osoba_id=@Id;";
        private static readonly string DELETE = "DELETE FROM `mjerenje` WHERE id_mjerenje=@id";


        public List<Measurement> GetMeasurements()
        {
            List<Measurement> result = new List<Measurement>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ALL;
                reader = cmd.ExecuteReader();
                MySqlEmployee employee = new MySqlEmployee();
                MySqlAddress address = new MySqlAddress();
                MySqlInstruments instruments = new MySqlInstruments();

                while (reader.Read())
                {
                    result.Add(new Measurement()
                    {
                        ID = reader.GetInt32(0),
                        DateTime = reader.GetDateTime(1),
                        Employee = employee.GetEmployeeById( reader.GetInt32(2)),
                        Address = address.GetAddressById( reader.GetInt32(3) ),
                        WeatherInstruments = instruments.GetInstrumentsById( reader.GetInt32(4)),
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

        public int InsertMeasurement(int idAddress, int idEmployee, int instrumentLocation, DateTime dateTime)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            int lastInsertedId = -1;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@AddressId", idAddress);
                cmd.Parameters.AddWithValue("@InstrumentsLocationId", instrumentLocation);
                cmd.Parameters.AddWithValue("@EmployeeId", idEmployee);
                cmd.Parameters.AddWithValue("@TimeAndData", dateTime);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT LAST_INSERT_ID()";
                lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlCountry", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }

            return lastInsertedId;
        }

        public Measurement getMeasurenmentById(int id)
        {
            Measurement result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            MySqlEmployee mySqlEmployee = new MySqlEmployee();
            MySqlAddress mySqlAddress = new MySqlAddress();
            MySqlInstruments mySqlInstruments = new MySqlInstruments();

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_ID;
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();
                reader.Read();
                result = new Measurement()
                {
                    ID = id,
                    DateTime = reader.GetDateTime(0),
                    Employee = mySqlEmployee.GetEmployeeById(reader.GetInt32(1)),
                    Address = mySqlAddress.GetAddressById(reader.GetInt32(2)),
                    WeatherInstruments = mySqlInstruments.GetInstrumentsById(reader.GetInt32(3))
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

        public List<Measurement> getMeasurenmentsByEmployeeId(int id)
        {
            List<Measurement> result = new List<Measurement>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            MySqlEmployee mySqlEmployee = new MySqlEmployee();
            MySqlAddress mySqlAddress = new MySqlAddress();
            MySqlInstruments mySqlInstruments = new MySqlInstruments();

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ALL_BY_EMPLOYEE_ID;
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Measurement()
                    {
                        ID = reader.GetInt32(0),
                        DateTime = reader.GetDateTime(1),
                        Address = mySqlAddress.GetAddressById(reader.GetInt32(2)),
                        WeatherInstruments = mySqlInstruments.GetInstrumentsById(reader.GetInt32(3))
                    });
                }
            
            }
            catch (Exception ex)
            {
                //throw new DataAccessException("Exception in MySqlEmployee", ex);
                return null;
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
                cmd.Parameters.AddWithValue("@id", Id);
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

        public void Update(Measurement m)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Id", m.ID);
                cmd.Parameters.AddWithValue("@DataAndTime", m.DateTime );
                cmd.Parameters.AddWithValue("@EmployeeId", m.Employee.ID);
                cmd.Parameters.AddWithValue("@AddressId", m.Address.ID);
                cmd.Parameters.AddWithValue("@InstrumentsLocationId", m.WeatherInstruments.ID);
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
