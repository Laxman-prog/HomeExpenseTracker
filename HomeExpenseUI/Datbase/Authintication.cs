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
        public bool IsValidUser(string userName, string password, SqlConnection conn)
        {
            try
            {

                SqlCommand loginCommand = new ("Select * from UserLogin where UserName='" + userName + "'and Password='" + password + "'", conn);
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
            catch(Exception e)
            {
                conn.Close();
                MessageBox.Show(e.Message);
                return false;
            }

        }
        public bool RegisterUser(string userName, string password, string gmail, SqlConnection conn)
        {
            try
            {
                SqlCommand insertCommand = new ("INSERT INTO UserLogin VALUES (@userName, @password, @gmail)", conn);
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
                conn.Close();
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
