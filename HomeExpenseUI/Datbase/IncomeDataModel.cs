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
        public static bool AddMenutoDb(SqlConnection conn, string sourcName, string sourceType)
        {
            var userName = LoginInfo.UserName;
            try
            {
                SqlCommand insertCommand = new("INSERT INTO IncomeMenuTable VALUES (@UserName, @SourceName, @SourceType)", conn);

                insertCommand.CommandType = CommandType.Text;
                insertCommand.Parameters.AddWithValue("@UserName", userName);
                insertCommand.Parameters.AddWithValue("@SourceName", sourcName);
                insertCommand.Parameters.AddWithValue("@SourceType", sourceType);
                conn.Open();
                insertCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public List<string> GetMenuNamesfromDb(SqlConnection sqlConnection,string columName)
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
            catch(Exception )
            {
            }
            finally
            {
                sqlConnection.Close();
            }
            return menus;          
        }


        public static bool InsertIncomeDetailsToDb(SqlConnection conn, string sourceName, string sourceType,
            DateTime dateTime,string incomeValue)
        {
            var userName = LoginInfo.UserName;
            try
            {
                SqlCommand insertCommand = new("INSERT INTO IncomeTable VALUES (@UserName, @SourceName, @SourceType, @Date, @MoneyValue)", conn);
                insertCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
                insertCommand.Parameters.Add("@SourceName", SqlDbType.VarChar).Value = sourceName;
                insertCommand.Parameters.Add("@SourceType", SqlDbType.VarChar).Value =sourceType;
                insertCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = dateTime;
                insertCommand.Parameters.Add("@MoneyValue", SqlDbType.VarChar).Value = incomeValue;
                conn.Open();
                insertCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception )
            {
               
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool AddPreviousMonthAmountDetailToDb(SqlConnection conn, DateTime dateTime, string incomeValue)
        {
            var userName = LoginInfo.UserName;
            try
            {
                SqlCommand insertCommand = new("INSERT INTO PreviousAmount VALUES (@UserName, @Date, @Amount)", conn);
                insertCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
                insertCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = dateTime;
                insertCommand.Parameters.Add("@Amount", SqlDbType.VarChar).Value = incomeValue;
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

    }
}
