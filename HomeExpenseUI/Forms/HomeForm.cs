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
            totalIncomeValue.Location = new System.Drawing.Point(totalIncomeValue.Location.X, totalIncomeLabel.Location.Y+30);
            previousAmountValue.Location = new System.Drawing.Point(previousAmountValue.Location.X, previouAmountLabel.Location.Y+16);
            totalExpenseValue.Location = new System.Drawing.Point(totalExpenseValue.Location.X, totalExpenseLabel.Location.Y+16);
            thisMonthsavingValue.Location = new System.Drawing.Point(thisMonthsavingValue.Location.X, savingLabel.Location.Y + 16);
            totalIncomePreviPlusCurrValue.Location = new System.Drawing.Point(totalIncomePreviPlusCurrValue.Location.X, totalIncomePerviPlusCurrLabel.Location.Y + 16);
            currentBankBalanceValue.Location = new System.Drawing.Point(currentBankBalanceValue.Location.X, currentBankBalanceLabel.Location.Y + 16);
           

            DateTime startDate = new(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, 1);
             var monthEndDay = DateTime.DaysInMonth(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month);
            DateTime endDate = new(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, monthEndDay);
            LoadData(startDate, endDate);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            ClearValues();
           DateTime startDate = new(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, 1);
            var monthEndDay = DateTime.DaysInMonth(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month);
           DateTime endDate = new(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, monthEndDay);
            LoadData(startDate, endDate);
        }

        private void ClearValues()
        {
            currentBankBalanceValue.Text = "0.00";
            previousAmountValue.Text = "0.00";
            totalExpenseValue.Text = "0.00";
            currentBankBalanceValue.Text = "0.00";
            totalIncomePreviPlusCurrValue.Text = "0.00";

        }

        private void LoadData(DateTime startDate, DateTime endDate)
        {
            var currencySymbol = LoacalCulture.GetCurrancySymbol();
            var expenses= LoadExpenses(startDate, endDate);
            totalExpenseValue.Text = String.Format("{0:C}", expenses);
        
            var incomes = LoadIncomes(startDate, endDate);
            totalIncomeValue.Text = String.Format("{0:C}", incomes);
         
            var previousAmount = GetPreviousAmount(startDate, endDate);
            // previousAmountValue.Text = currencySymbol + previousAmount;

            previousAmountValue.Text= String.Format("{0:C}", previousAmount);

            var totalbalance = incomes + previousAmount - expenses;
            currentBankBalanceValue.Text = String.Format("{0:C}", totalbalance);

            var totalIncme = incomes + previousAmount;
            totalIncomePreviPlusCurrValue.Text = String.Format("{0:C}", totalIncme);

            var savingValue = incomes - expenses;
            thisMonthsavingValue.Text = String.Format("{0:C}", savingValue);
        }
        private double GetPreviousAmount(DateTime startDate, DateTime endDate)
        {
            double previousAmount = 0;
            try
            {
                //Expense

                var expenseDataReader = SqlDataFetchModel.GetPreviuosAmountBetweenTwoDates(_sqlconnection, startDate,
                    endDate);
                List<double> totalPreviousAmount = new();
                if (expenseDataReader is null) { return previousAmount; }
                while (expenseDataReader.Read())
                {
                    var myString = expenseDataReader.GetString(3); //The 0 stands for "the 0'th column", so the first column of the result.
                    totalPreviousAmount.Add(double.Parse(myString));
                }
                previousAmount = MathUtils.CalculateSum(totalPreviousAmount);
                return previousAmount;

            }
            catch
            {
                Form_Alert frm = new();
                frm.showAlert("No Expense Found", Form_Alert.AlertType.Warning);
            }
            finally
            {
                _sqlconnection.Close();
            }
            return previousAmount;
        }
        private double LoadExpenses(DateTime startDate, DateTime endDate)
        {
            double expense = 0;
            try
            {
                //Expense

                var expenseDataReader = SqlDataFetchModel.GetExpensedataBetweenTwoDates(_sqlconnection, startDate,
                    endDate);
                List<double> totalExpenseList = new();
                if(expenseDataReader is null) { return expense; }
                while (expenseDataReader.Read())
                {
                    var myString = expenseDataReader.GetString(5); //The 0 stands for "the 0'th column", so the first column of the result.
                    totalExpenseList.Add(double.Parse(myString));
                }
                expense = MathUtils.CalculateSum(totalExpenseList);
                return expense;

            }
            catch
            {
                Form_Alert frm = new();
                frm.showAlert("No Expense Found", Form_Alert.AlertType.Warning);
            }
            finally
            {
                _sqlconnection.Close();
            }
            return expense;
        }
        private double LoadIncomes(DateTime startDate, DateTime endDate)
        {
            double income = 0;
           
            try
            {
                //Income
                var incomeDataReader = SqlDataFetchModel.GetIncomedataBetweenTwoDates(_sqlconnection, startDate,
                  endDate);
                List<double> totalIncomeList = new();
                if (incomeDataReader is null) { return income; }
                while (incomeDataReader.Read())
                {
                    var myString = incomeDataReader.GetString(5); //The 0 stands for "the 0'th column", so the first column of the result.
                    totalIncomeList.Add(double.Parse(myString));
                }
                income = MathUtils.CalculateSum(totalIncomeList);
             
                return income;
            }

            catch
            {
                Form_Alert frm = new();
                frm.showAlert("No Income Found", Form_Alert.AlertType.Warning);
            }
            finally
            {
                _sqlconnection.Close();
            }
            return income;
        }
    }
}
