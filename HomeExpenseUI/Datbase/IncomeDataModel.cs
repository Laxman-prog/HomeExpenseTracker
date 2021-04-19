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
        internal List<string> GetDropdownsMenusfromDb(SqlConnection sqlConnection)
        {
            List<string> menus= new List<string>();
            string userName = LoginInfo.UserName;
            try
            {
                SqlCommand command = new SqlCommand("Select IncomeSourceNames from [SubIncomeTable] where userName=@userName", sqlConnection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@userName", userName);
                sqlConnection.Open();
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        menus = (List<string>)reader["IncomeSourceNames"];
                        sqlConnection.Close();
                    }

                }
            }
            catch(Exception e)
            {
                sqlConnection.Close();
                MessageBox.Show(e.Message);
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
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO IncomeSubTable VALUES (@userName, @menus)", sqlConnection);

                    //  SqlCommand insertCommand = new SqlCommand("INSERT INTO SubIncomeTable(IncomeSourceNames) VALUES (@VarBinary)", sqlConnection);
                    insertCommand.Parameters.AddWithValue("@userName", userName);

                    insertCommand.Parameters.Add("@menus", SqlDbType.VarBinary, Int32.MaxValue);
                    insertCommand.Parameters["@menus"].Value = memStream.GetBuffer();

                    sqlConnection.Open();
                    insertCommand.ExecuteNonQuery();
                    sqlConnection.Close();
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
                    sqlConnection.Close();
                }
            }
            catch (Exception e)
            {
                sqlConnection.Close();
                MessageBox.Show(e.Message+"stack"+e.StackTrace);
              
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
                    sqlConnection.Close();
                    return true;
                }
                else
                {
                    sqlConnection.Close();
                    return false;

                }
            }
            catch(Exception e)
            {
                sqlConnection.Close();
                MessageBox.Show(e.Message + "stack" + e.StackTrace);
                return false;
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
                    conn.Close();
                    return true;

                }
                else
                {
                    conn.Close();
                    return false;

                }
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
}
