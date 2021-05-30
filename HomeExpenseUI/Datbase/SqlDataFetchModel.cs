using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeExpenseUI.Datbase
{
    class SqlDataFetchModel
    {
        public static SqlDataReader GetExpensedataBetweenTwoDates(SqlConnection sqlConnection, DateTime startDate, DateTime endDate)
        {
            try
            {
                List<string> menus = new();
                var userName = LoginInfo.UserName;
                SqlCommand getExpenseCmd = new("Select * from ExpenseTable where  UserName='" + userName + "'and Date between'" + startDate.ToString("MM/dd/yyyy") + "'and '" + endDate.ToString("MM/dd/yyyy") + "'", sqlConnection);
                getExpenseCmd.CommandType = CommandType.Text;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = getExpenseCmd.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    return sqlDataReader;
                }
                else
                {
                    return null;

                }
            }
            catch (Exception e)
            {
                sqlConnection.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static SqlDataReader GetPreviuosAmountBetweenTwoDates(SqlConnection sqlConnection, DateTime startDate, DateTime endDate)
        {
            try
            {
                List<string> menus = new();
                var userName = LoginInfo.UserName;
                SqlCommand getExpenseCmd = new("Select * from PreviousAmount where  UserName='" + userName + "'and Date between'" + startDate.ToString("MM/dd/yyyy") + "'and '" + endDate.ToString("MM/dd/yyyy") + "'", sqlConnection);
                getExpenseCmd.CommandType = CommandType.Text;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = getExpenseCmd.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    return sqlDataReader;
                }
                else
                {
                    return null;

                }
            }
            catch (Exception e)
            {
                sqlConnection.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }
        internal static SqlDataReader GetIncomedataBetweenTwoDates(SqlConnection sqlConnection, DateTime startDate, DateTime endDate)
        {
            try
            {
                var userName = LoginInfo.UserName;
                List<string> menus = new();
                SqlCommand loginCommand = new("Select * from IncomeTable where UserName='" + userName + "'and Date between'" + startDate.ToString("MM/dd/yyyy") + "'and '" + endDate.ToString("MM/dd/yyyy") + "'", sqlConnection);
                loginCommand.CommandType = CommandType.Text;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = loginCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    return sqlDataReader;
                }
                else
                {
                    return null;

                }
            }
            catch (Exception e)
            {
                sqlConnection.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        internal static bool  DeleteIncomeFromDb(SqlConnection sqlconnection, int id)
        {
            try
            {
                using (var cmd = sqlconnection.CreateCommand())
                {
                    sqlconnection.Open();
                    cmd.CommandText = "DELETE FROM IncomeTable WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                sqlconnection.Close();
            }
        }
        internal static bool DeleteExpenseFromDb(SqlConnection sqlconnection, int id)
        {
            try
            {
                using (var cmd = sqlconnection.CreateCommand())
                {
                    sqlconnection.Open();
                    cmd.CommandText = "DELETE FROM ExpenseTable WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                sqlconnection.Close();
            }
        }
    }
}
