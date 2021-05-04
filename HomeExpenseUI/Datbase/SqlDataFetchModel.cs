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
        public static bool GetExpensedataBetweenTwoDates(SqlConnection sqlConnection, DateTime startDate, DateTime endDate)
        {
            try
            {
             
                SqlCommand loginCommand = new("Select * from ExpenseTable where Date between='" + startDate.ToString("MM/dd/yyyy") + "'and '" + endDate.ToString("MM/dd/yyyy") + "'", sqlConnection);
                loginCommand.CommandType = CommandType.Text;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = loginCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
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
            catch (Exception e)
            {
                sqlConnection.Close();
                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
}
