using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;

namespace HomeExpenseUI.Datbase
{
    class ExpenseDataModel
    {
        internal static bool AddMenutoDb(SqlConnection conn, string sourcName, string sourceType)
        {
            var userName = LoginInfo.UserName;
            try
            {
                SqlCommand insertCommand = new("INSERT INTO ExpenseMenuTable VALUES (@UserName, @SourceName, @SourceType)", conn);

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
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        internal static List<string> GetMenuNamesfromDb(SqlConnection sqlConnection, string columName)
        {
            List<string> menus = new();
            string userName = LoginInfo.UserName;
            try
            {

                SqlCommand command = new("Select DISTINCT " + columName + " from [ExpenseMenuTable] where UserName=@UserName", sqlConnection);
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
            catch (Exception)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
            return menus;
        }


        internal static bool InsertExpenseDetailsToDb(SqlConnection conn, string expenseName, string expenseType,
            DateTime dateTime, string incomeValue)
        {
            var userName = LoginInfo.UserName;
            try
            {
                SqlCommand insertCommand = new("INSERT INTO ExpenseTable VALUES (@UserName, @ExpenseName, @ExpenseType, @Date, @MoneyValue)", conn);
                //insertCommand.CommandType = CommandType.Text;
                //insertCommand.Parameters.AddWithValue("@UserName", userName);
                //insertCommand.Parameters.AddWithValue("@SourceName", sourceName);
                //insertCommand.Parameters.AddWithValue("@SourceType", sourceType);
                //insertCommand.Parameters.AddWithValue("@Date", dateTime);
                //insertCommand.Parameters.AddWithValue("@MoneyValue", incomeValue);
                insertCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
                insertCommand.Parameters.Add("@ExpenseName", SqlDbType.VarChar).Value = expenseName;
                insertCommand.Parameters.Add("@ExpenseType", SqlDbType.VarChar).Value = expenseType;
                insertCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = dateTime;
                insertCommand.Parameters.Add("@MoneyValue", SqlDbType.VarChar).Value = incomeValue;
                conn.Open();
                insertCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Stacj" + e.StackTrace);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
