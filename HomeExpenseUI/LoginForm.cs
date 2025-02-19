﻿using HomeExpenseUI.Datbase;
using HomeExpenseUI.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HomeExpenseUI
{
    public partial class LoginForm : Form
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

        public readonly SqlConnection conn = new (ConnectionString);
        public LoginForm()
        {
            InitializeComponent();
            countryListCombo.Items.AddRange(Localization.GetCountryList().ToArray());
            countryListCombo.SelectedItem = "India";
        }
        public void Alert(string msg, Form_Alert.AlertType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Authintication authintication = new();
            if (authintication.IsValidUser(userNameTextBox.Text, passwordTextBox.Text, conn))
            {
                LoginInfo.UserName = userNameTextBox.Text;
                LoginInfo.Password = passwordTextBox.Text;
                DashBoard dashBoard = new (this);
                dashBoard.Show();
                userNameTextBox.Clear();
                passwordTextBox.Clear();
                this.Alert("Success Alert", Form_Alert.AlertType.Success);
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }
            //DashBoard dashBoard = new DashBoard();
            //dashBoard.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            gmailLabel.Show();
            gmailTextBox.Show();
            signInButton.Hide();
            addAcountButton.Show();
            addAcountButton.Location = new System.Drawing.Point(signInButton.Location.X, signInButton.Location.Y);
            userNameTextBox.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gmailLabel.Hide();
            gmailTextBox.Hide();
            addAcountButton.Hide();
            
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            Authintication authintication = new ();
            if (authintication.RegisterUser(userNameTextBox.Text, passwordTextBox.Text, gmailTextBox.Text,conn))
            {
                MessageBox.Show("Registered Successfully. Please Go to Login");
                gmailLabel.Hide();
                gmailTextBox.Hide();
                addAcountButton.Hide();
            }
            else
            {
                MessageBox.Show("User name exists. Please try another user name");
            }
        }

        private void countryListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
    }
}
