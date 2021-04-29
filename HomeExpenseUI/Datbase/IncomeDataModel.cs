using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;

namespace HomeExpenseUI.Datbase
{
    public class IncomeDataModel
    {
        internal static bool AddMenutoDb(SqlConnection conn, string sourcName, string sourceType)
        {
            var userName = LoginInfo.UserName;
            try
            {
                SqlCommand insertCommand = new("INSERT INTO IncomeMenuTable VALUES (@UserName, @SourceName, @SourceType)", conn);

                // SqlCommand insertCommand = new("INSERT INTO IncomeMenuTable (UserName, "+ columnName+") VALUES ('" + userName + "','" + menuName+"')", conn);
                insertCommand.CommandType = CommandType.Text;
                insertCommand.Parameters.AddWithValue("@UserName", userName);
                insertCommand.Parameters.AddWithValue("@SourceName", sourcName);
                insertCommand.Parameters.AddWithValue("@SourceType", sourceType);
                //insertCommand.Parameters.AddWithValue("@Date", dateTime);
                //insertCommand.Parameters.AddWithValue("@MoneyValue", incomeValue);
                //insertCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
                //insertCommand.Parameters.Add("@SourceName", SqlDbType.VarChar).Value = sourcName;
                //insertCommand.Parameters.Add("@SourceType", SqlDbType.VarChar).Value = soutceType;
                conn.Open();
                insertCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Stack" + e.StackTrace);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        internal List<string> GetMenuNamesfromDb(SqlConnection sqlConnection,string columName)
        {
            List<string> menus= new List<string>();
            string userName = LoginInfo.UserName;
            try
            {

                SqlCommand command = new ("Select DISTINCT " + columName + " from [IncomeMenuTable] where UserName=@UserName", sqlConnection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@UserName", userName);
                sqlConnection.Open();
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var myString = reader.GetString(0); //The 0 stands for "the 0'th column", so the first column of the result.
                        menus.Add(myString);
                    }

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message+"stack" + e.StackTrace);
            }
            finally
            {
                sqlConnection.Close();
            }
            return menus;          
        }

        internal void AddIncomeSourceNamestoDb(List<string> menusList, SqlConnection sqlConnection)
        {
            string userName = LoginInfo.UserName;
            try
            {

                using MemoryStream memStream = new MemoryStream();
                StreamWriter sw = new StreamWriter(memStream);
                sw.Write(menusList);
                if (!IsUserPresentInDb(sqlConnection, userName))
                {
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO IncomeTable VALUES (@userName, @menus)", sqlConnection);

                    //  SqlCommand insertCommand = new SqlCommand("INSERT INTO SubIncomeTable(IncomeSourceNames) VALUES (@VarBinary)", sqlConnection);
                    insertCommand.Parameters.AddWithValue("@userName", userName);

                    insertCommand.Parameters.Add("@menus", SqlDbType.VarBinary, Int32.MaxValue);
                    insertCommand.Parameters["@menus"].Value = memStream.GetBuffer();

                    sqlConnection.Open();
                    insertCommand.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand insertCommand = new SqlCommand("UPDATE IncomeSubTable SET IncomeSourceNames =@imcomeMenus WHERE UserName = @userName", sqlConnection);

                    //  SqlCommand insertCommand = new SqlCommand("INSERT INTO SubIncomeTable(IncomeSourceNames) VALUES (@VarBinary)", sqlConnection);
                    insertCommand.Parameters.AddWithValue("@userName", userName);

                    insertCommand.Parameters.Add("@menus", SqlDbType.VarBinary, Int32.MaxValue);
                    insertCommand.Parameters["@menus"].Value = memStream.GetBuffer();

                    sqlConnection.Open();
                    insertCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message+"stack"+e.StackTrace);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private bool IsUserPresentInDb(SqlConnection sqlConnection, string userName)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select * from IncomeSubTable where userName=@userName", sqlConnection);
                command.Parameters.AddWithValue("@userName", userName);
                sqlConnection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "stack" + e.StackTrace);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        internal static bool InsertIncomeDetailsToDb(SqlConnection conn, string sourceName, string sourceType,
            DateTime dateTime,string incomeValue)
        {
            var userName = LoginInfo.UserName;
            try
            {
                SqlCommand insertCommand = new("INSERT INTO IncomeTable VALUES (@UserName, @SourceName, @SourceType, @Date, @MoneyValue)", conn);
                //insertCommand.CommandType = CommandType.Text;
                //insertCommand.Parameters.AddWithValue("@UserName", userName);
                //insertCommand.Parameters.AddWithValue("@SourceName", sourceName);
                //insertCommand.Parameters.AddWithValue("@SourceType", sourceType);
                //insertCommand.Parameters.AddWithValue("@Date", dateTime);
                //insertCommand.Parameters.AddWithValue("@MoneyValue", incomeValue);
                insertCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
                insertCommand.Parameters.Add("@SourceName", SqlDbType.VarChar).Value = sourceName;
                insertCommand.Parameters.Add("@SourceType", SqlDbType.VarChar).Value =sourceType;
                insertCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = dateTime;
                insertCommand.Parameters.Add("@MoneyValue", SqlDbType.VarChar).Value = incomeValue;
                conn.Open();
                insertCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
               
                MessageBox.Show(e.Message+"Stack"+e.StackTrace);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool IsValidUser(SqlConnection conn, string userName)
        {
            try
            {

                SqlCommand loginCommand = new SqlCommand("Select * from IncomeSubTable where UserName='" + userName + "'", conn);
                loginCommand.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader sqlDataReader = loginCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
