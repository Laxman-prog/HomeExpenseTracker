using HomeExpenseUI.Datbase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace HomeExpenseUI.Forms
{
    public partial class ShowIncomes : Form
    {
        SqlConnection _sqlconnection;
        public ShowIncomes(SqlConnection conn)
        {
            _sqlconnection = conn;
            InitializeComponent();
            LoadIncomes();
        }
        private void LoadIncomes()
        {

            DateTime startDate = new(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, 1);
            var monthEndDay = DateTime.DaysInMonth(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month);
            DateTime endDate = new(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, monthEndDay);
            CultureInfo indianCurrency = new("hi-IN");
            try
            {
                //Expense
                var rdr = SqlDataFetchModel.GetIncomedataBetweenTwoDates(_sqlconnection, startDate,
                    endDate);
                List<double> totalExpenseList = new();
                if(rdr is null) { ShowAlert("No Data Found", Form_Alert.AlertType.Warning); }
                while (rdr.Read())
                {
                    var sa =Int32.Parse(rdr.GetString(5));
                    string amount = string.Format(indianCurrency, "{0:c}", sa);
                    showIncomeDataGrid.Rows.Add(rdr.GetString(2), rdr.GetString(3), rdr.GetDateTime(4), amount,
                        rdr.GetInt32(0));

                }
                _sqlconnection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "Stack\n" + e.StackTrace);
                ShowAlert("No Expense Found", Form_Alert.AlertType.Warning);
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
                if (SqlDataFetchModel.GetIncomedataBetweenTwoDates(_sqlconnection, id))
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
    }
}
