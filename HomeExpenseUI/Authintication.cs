using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HomeExpenseUI
{
    public class Authintication
    {
        SqlConnection conn = new SqlConnection(@"Data Source=Laxman;Initial Catalog=HomeExpense;Integrated Security=True");
        public bool IsValidUser(string userName, string password)
        {
         
                SqlCommand loginCommand = new SqlCommand("Select * from UserLogin where UserName='"+userName+"'and Password='"+password+"'", conn);
                loginCommand.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader sqlDataReader = loginCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    return true;
                }
                else
                  return false;

        }
        public bool RegisterUser(string userName, string password, string gmail)
        {
            try
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO UserLogin VALUES (@userName, @password, @gmail)", conn);
                insertCommand.CommandType = CommandType.Text;
                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@password", password);
                insertCommand.Parameters.AddWithValue("@gmail", gmail);

                conn.Open();
                insertCommand.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
