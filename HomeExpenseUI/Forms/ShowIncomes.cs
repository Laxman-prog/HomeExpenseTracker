﻿using HomeExpenseUI.Datbase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace HomeExpenseUI.Forms
{
    public partial class IncomesBoard : Form
    {
        SqlConnection _sqlconnection;
        DashBoard _parentForm; 
        public IncomesBoard(SqlConnection conn, DashBoard parentForm)
        {
            _sqlconnection = conn;
            InitializeComponent();
            _parentForm = parentForm;
            LoadIncomes();
        }
        private void LoadIncomes()
        {

            DateTime startDate = new(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, 1);
            var monthEndDay = DateTime.DaysInMonth(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month);
            DateTime endDate = new(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, monthEndDay);
            var currencySymbol = LoacalCulture.GetCurrancySymbol();
            double sum = 0;
            try
            {
                //Expense
                int rowNumber = 0;
                var rdr = SqlDataFetchModel.GetIncomedataBetweenTwoDates(_sqlconnection, startDate,
                    endDate);
                List<double> totalExpenseList = new();
                if(rdr is null) { ShowAlert("No Data Found", Form_Alert.AlertType.Warning); }
                while (rdr.Read())
                {
                    var moneyValue =Int32.Parse(rdr.GetString(5));
                    sum += moneyValue;
                    string amount = currencySymbol + moneyValue;
                    showIncomeDataGrid.Rows.Add(rdr.GetString(2), rdr.GetString(3), rdr.GetDateTime(4), amount,
                        rdr.GetInt32(0));
                    rowNumber += 1;
                }
                totalIncomeLabel.Text = "Total Income:  " + currencySymbol + sum;
                _sqlconnection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "Stack\n" + e.StackTrace);
                ShowAlert("No Income Found", Form_Alert.AlertType.Warning);
            }
            finally
            {
                _sqlconnection.Close();
            }

        }

        private void ShowIncomeDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (showIncomeDataGrid.Columns[e.ColumnIndex].Name == "Edit")
            {
                

            }
            else if (showIncomeDataGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = (int)showIncomeDataGrid.CurrentRow.Cells["Id"].Value;
                int rowNumber = showIncomeDataGrid.CurrentRow.Index;
                if (SqlDataFetchModel.DeleteIncomeFromDb(_sqlconnection, id))
                {
                    ShowAlert("Deleted Success", Form_Alert.AlertType.Success);
                    showIncomeDataGrid.Rows.RemoveAt(rowNumber);
                }
                else
                    ShowAlert("Unable To Delete", Form_Alert.AlertType.Error);
            }

        }
        private void ShowAlert( string msg, Form_Alert.AlertType alerType)
        {
            Form_Alert frm = new();
            frm.showAlert(msg, alerType);
        }

        private void AddIncomes(object sender, EventArgs e)
        {
            var incomeInsertion = new IncomeInsertionForm(_sqlconnection,_parentForm);
            _parentForm.OpenChildForm(incomeInsertion);
            
        }
    }
}
