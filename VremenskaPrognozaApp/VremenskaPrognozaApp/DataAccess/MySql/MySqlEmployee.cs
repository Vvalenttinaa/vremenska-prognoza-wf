using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.Exceptions;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.DataAccess.MySql
{
    public class MySqlEmployee
    {
        private static readonly string SELECT = "SELECT id, ime, prezime, meteoroloska_stanica_id, nalog_id FROM `zaposleni` ORDER BY ime";
        private static readonly string INSERT = "INSERT INTO `zaposleni` (ime, prezime, meteoroloska_stanica_id, nalog_id) VALUES (@FirstName, @SecondName, @IdStation, @IdAccount);";
        private static readonly string SELECT_BY_ID = "SELECT ime, prezime, meteoroloska_stanica_id, nalog_id FROM `zaposleni` WHERE id=@Id;";
        private static readonly string SELECT_BY_ACCOUNT_ID = "SELECT id, ime, prezime, meteoroloska_stanica_id FROM `zaposleni` WHERE nalog_id=@Id;";
        private static readonly string UPDATE = "UPDATE `zaposleni` SET ime=@FirstName, prezime=@SecondName, meteoroloska_stanica_id=@MetId, nalog_id=@NalogId WHERE id=@Id";
        private static readonly string DELETE = "DELETE FROM `zaposleni` WHERE id=@id";

        public int insertEmployee(Employee employee)
        {
            int result;
            MySqlConnection conn = null;
            MySqlCommand cmd;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@SecondName", employee.LastName);
                cmd.Parameters.AddWithValue("@IdStation", employee.weatherStationId);
                cmd.Parameters.AddWithValue("@IdAccount", employee.accountId);
                cmd.ExecuteNonQuery();
                result = (int)cmd.LastInsertedId;



            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAccountInsert", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return result;
        }

        public Employee GetEmployeeById(int id)
        {
            Employee result;
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
                result = new Employee()
                {
                    ID = id,
                    FirstName = reader.GetString(0),
                    LastName = reader.GetString(1),
                    weatherStationId = reader.GetInt32(2),
                    accountId = reader.GetInt32(3)
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

        public Employee GetEmployeeByAccountId(int id)
        {
            Employee result = null;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_ACCOUNT_ID;
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();
                reader.Read();

                result = new Employee()
                {
                    ID = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    weatherStationId = reader.GetInt32(3),
                };

            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlEmployee", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public List<Employee> GetAll()
        {
            List<Employee> result = new List<Employee>();
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
                    result.Add(new Employee()
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1), 
                        LastName = reader.GetString(2),
                        weatherStationId=reader.GetInt32(3),
                        accountId = reader.GetInt32(4)
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

        public void Update(Employee employee)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Id", employee.ID);
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@SecondName", employee.LastName);
                cmd.Parameters.AddWithValue("@MetId", employee.weatherStationId);
                cmd.Parameters.AddWithValue("@NalogId", employee.accountId);
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


