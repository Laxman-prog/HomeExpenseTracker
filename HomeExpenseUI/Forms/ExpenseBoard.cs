using HomeExpenseUI.Datbase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeExpenseUI.Forms
{
    public partial class ExpenseBoard : Form
    {
        SqlConnection _sqlconnection;
        DashBoard _parentForm;
        public ExpenseBoard(SqlConnection conn, DashBoard parentForm)
        {
            _sqlconnection = conn;
            InitializeComponent();
            _parentForm = parentForm;
            LoadExpenses();
        }
        private void LoadExpenses()
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
                var rdr = SqlDataFetchModel.GetExpensedataBetweenTwoDates(_sqlconnection, startDate,
                    endDate);
                List<double> totalExpenseList = new();
                if (rdr is null) { ShowAlert("No Data Found", Form_Alert.AlertType.Warning); }
                while (rdr.Read())
                {
                    var moneyValue = Int32.Parse(rdr.GetString(5));
                    sum += moneyValue;
                    string moneyValueStr = currencySymbol + moneyValue;
                    showIncomeDataGrid.Rows.Add(rdr.GetString(2), rdr.GetString(3), rdr.GetDateTime(4), moneyValueStr,
                        rdr.GetInt32(0));
                    rowNumber += 1;

                }
                totalExpleseLabel.Text = "Total Expeses:  " + currencySymbol + sum;
                _sqlconnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Stack\n" + e.StackTrace);
                ShowAlert("No Expense Found", Form_Alert.AlertType.Warning);
            }
            finally
            {
                _sqlconnection.Close();
            }

        }
        private void ShowAlert(string msg, Form_Alert.AlertType alerType)
        {
            Form_Alert frm = new();
            frm.showAlert(msg, alerType);
        }


        private void ShowExpeses(object sender, EventArgs e)
        {
            _parentForm.OpenChildForm(new ExpenseInsertion(_sqlconnection, _parentForm));
        }

        private void showIncomeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showIncomeDataGrid.Columns[e.ColumnIndex].Name == "Edit")
            {


            }
            else if (showIncomeDataGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = (int)showIncomeDataGrid.CurrentRow.Cells["Id"].Value;
                int rowNumber = showIncomeDataGrid.CurrentRow.Index;
                if (SqlDataFetchModel.DeleteExpenseFromDb(_sqlconnection, id))
                {
                    ShowAlert("Deleted Success", Form_Alert.AlertType.Success);
                    showIncomeDataGrid.Rows.RemoveAt(rowNumber);
                }
                else
                    ShowAlert("Unable To Delete", Form_Alert.AlertType.Error);
            }

        }
    }
}
