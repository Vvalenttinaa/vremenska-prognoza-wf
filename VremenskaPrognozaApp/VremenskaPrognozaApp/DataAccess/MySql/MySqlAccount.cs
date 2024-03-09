using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.Exceptions;
using VremenskaPrognozaApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VremenskaPrognozaApp.DataAccess.MySql
{
    internal class MySqlAccount
    {
        private static readonly string EXISTS = "SELECT COUNT(*) FROM `nalog` WHERE korisnicko_ime=@Username AND lozinka=@Password";
        private static readonly string SELECT_ALL = "SELECT id, lozinka, korisnicko_" +
            "ime, uloga, jezik, tema  FROM `nalog`;";
        private static readonly string SELECT_BY_ID = "SELECT id, lozinka, korisnicko_ime, uloga, jezik, tema FROM `nalog` WHERE id=@Id";
        private static readonly string INSERT_ACCOUNT = "INSERT INTO `nalog` (lozinka, korisnicko_ime, uloga, jezik, tema) VALUES (@Password, @Username, @Role, 1, 1)";
        private static readonly string UPDATE_ACCOUNT = "UPDATE `nalog` SET korisnicko_ime=@Username, lozinka=@Password, uloga=@Role, jezik=@Language, tema=@Theme Where id=@Id";
        private static readonly string SELECT_ID = "SELECT id FROM `nalog` WHERE lozinka=@Password AND korisnicko_ime=@Username;";


        public Boolean existsAccount(string password, string username)
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
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                
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

        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ALL;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Account account = new Account()
                    {
                        ID = reader.GetInt32(0),
                        Password = reader.GetString(1),
                        Username = reader.GetString(2),
                        Role = reader.GetChar(3),
                    };
                    accounts.Add(account);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAccount", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return accounts;
        }

        public Account selectAccountById(int id)
        {
            Account account = new Account();

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_ID;
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    account = new Account()
                    {
                        ID = reader.GetInt32(0),
                        Password = reader.GetString(1),
                        Username = reader.GetString(2),
                        Role = reader.GetChar(3),
                        Language = reader.GetInt32(4),
                        Theme = reader.GetInt32(5),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAccount", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return account;
        }

        public int GetAccountId(String username, String password)
        {
            int result;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ID;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("Password", password);
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

        public int insertAccount(Account account)
        {
            int result;
            MySqlConnection conn = null;
            MySqlCommand cmd;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_ACCOUNT;
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@Role", account.Role);
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

        public int updateAccount(Account account)
        {
            int result;
            MySqlConnection conn = null;
            MySqlCommand cmd;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_ACCOUNT;
                cmd.Parameters.AddWithValue("@Id", account.ID);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@Role", account.Role);
                cmd.Parameters.AddWithValue("@Language", account.Language);
                cmd.Parameters.AddWithValue("@Theme", account.Theme);
                result = cmd.ExecuteNonQuery();

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
    }
}
