using HomeExpenseUI.Datbase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExpenseUtils;
using System.Globalization;

namespace HomeExpenseUI.Forms
{
    public partial class HomeForm : Form
    {
        SqlConnection _sqlconnection;
        public HomeForm(SqlConnection conn)
        {
            _sqlconnection = conn;
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = new (dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month,1 );
            var monthEndDay = DateTime.DaysInMonth(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month);
            DateTime endDate = new (dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, monthEndDay);
            double income = 0;
            double expense = 0;
            CultureInfo indianCurrency = new("hi-IN");
            try
            {
                //Expense
               
                var expenseDataReader = SqlDataFetchModel.GetExpensedataBetweenTwoDates(_sqlconnection, startDate,
                    endDate);
                List<double> totalExpenseList = new();
                while (expenseDataReader.Read())
                {
                    var myString = expenseDataReader.GetString(4); //The 0 stands for "the 0'th column", so the first column of the result.
                    totalExpenseList.Add(double.Parse(myString));
                }
                expense = MathUtils.CalculateSum(totalExpenseList);
               
                string text = string.Format(indianCurrency, "{0:c}", expense);
                totalExpenseValue.Text = text;
                _sqlconnection.Close();
            }
            catch
            {
                Form_Alert frm = new ();
                frm.showAlert("No Expense Found", Form_Alert.enmType.Warning);
            }
            try
            {
                //Income
                var incomeDataReader = SqlDataFetchModel.GetIncomedataBetweenTwoDates(_sqlconnection, startDate,
                  endDate);
                List<double> totalIncomeList = new();
                while (incomeDataReader.Read())
                {
                    var myString = incomeDataReader.GetString(4); //The 0 stands for "the 0'th column", so the first column of the result.
                    totalIncomeList.Add(double.Parse(myString));
                }
                income = MathUtils.CalculateSum(totalIncomeList);
                string incomeText = string.Format(indianCurrency, "{0:c}", income);
                totalIncomeValue.Text = incomeText;
                //Total balance
                var totalbalance = income + double.Parse(previousAmountValue.Text) - expense;
                totalBalamceValue.Text = string.Format(indianCurrency, "{0:c}", totalbalance);
            }
            
            catch
            {
                Form_Alert frm = new ();
                frm.showAlert("No Income Found", Form_Alert.enmType.Warning);
            }
            finally
            {
                _sqlconnection.Close();
            }
        }
    }
}
