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
    public partial class ExpenseInsertion : Form
    {
        SqlConnection _sqlConnection;
        List<string> _sourceNameList = new();
        List<string> _sourceTypeList = new();
        bool _isIncomeType;
        DashBoard _parentForm;
        public ExpenseInsertion(SqlConnection sqlConnection, DashBoard parentForm)
        {
            _sqlConnection = sqlConnection;
            _parentForm = parentForm;
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.AlertType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void ExpenseInsertion_Load(object sender, EventArgs e)
        {
            addNewOption.Visible = false;
            addNewOptionButton.Visible = false;
            addNewOptionCancel.Visible = false;
            addNewOptionTextBox.Visible = false;

            //Source Type
            _expenseTypeDropdown.Items.Add("Home rent");
            _expenseTypeDropdown.Items.Add("EMI");
            _expenseTypeDropdown.Items.Add("Genral store");
            _expenseTypeDropdown.Items.Add("Light bill ");
            _expenseTypeDropdown.Items.Add("Electricity bill");
            _expenseTypeDropdown.Items.Add("Medical");
            _expenseTypeDropdown.Items.Add("Gas");
            _expenseTypeDropdown.Items.Add("Party");

            _sourceTypeList = ExpenseDataModel.GetMenuNamesfromDb(_sqlConnection, "SourceType");
            if (_sourceTypeList.Count == 0)
            {
                _expenseTypeDropdown.Items.AddRange(_sourceTypeList.ToArray());
                _expenseTypeDropdown.Items.Remove("Other");
                _expenseTypeDropdown.Items.Add("Other");
            }
            else
            {
                _expenseTypeDropdown.Items.Add("Other");
            }

            _expenseTypeDropdown.SelectedItem = null;
            _expenseTypeDropdown.SelectedText = "--Select--";

        }

        private void ExpenseTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isIncomeType = true;
            if (_expenseTypeDropdown.SelectedItem?.ToString() == "Other")
            {
                ToggleOptonUI(true);
            }
        }
        private void ToggleOptonUI(bool isHide)
        {
            addNewOption.Visible = isHide;
            addNewOptionButton.Visible = isHide;
            addNewOptionCancel.Visible = isHide;
            addNewOptionTextBox.Visible = isHide;
        }

        private void AddNewOptionButton_Click(object sender, EventArgs e)
        {
            if(addNewOptionTextBox.Text.Equals(string.Empty))
            {
                this.Alert("Wrong input ", Form_Alert.AlertType.Error);
                return;
            }
            bool isAdded = false;
            if (_isIncomeType)
            {
                _expenseTypeDropdown.Items.Add(addNewOptionTextBox.Text);
                BeginInvoke(new Action(() => _expenseTypeDropdown.Text = addNewOptionTextBox.Text));
                isAdded= ExpenseDataModel.AddMenutoDb(_sqlConnection, "Other", addNewOptionTextBox.Text);
            }
     
            if(!isAdded)
            {
                this.Alert("Insert Failed", Form_Alert.AlertType.Error);
            }
            ToggleOptonUI(false);
        }

        private void SubmitExpenseButton_Click(object sender, EventArgs e)
        {

            var typeIndex = _expenseTypeDropdown.SelectedIndex;
            string selectedIncomeType = (string)_expenseTypeDropdown.Items[typeIndex];
            if (expenseName.Text == string.Empty || typeIndex == -1||expenseValueNumbox.Value<=0)
            {
                this.Alert("Wrong input ", Form_Alert.AlertType.Error);
                return;
            }

            bool isSuccess = ExpenseDataModel.InsertExpenseDetailsToDb(_sqlConnection, expenseName.Text,
               selectedIncomeType, incomeDateTimePicker.Value, expenseValueNumbox.Text);
            if(isSuccess)
            {
                this.Alert("Insert Success", Form_Alert.AlertType.Success);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            _expenseTypeDropdown.SelectedItem = null;
            _expenseTypeDropdown.SelectedText = "--Select--";
            expenseValueNumbox.Value = 0;
        }

        private void AddNewOptionCancel_Click(object sender, EventArgs e)
        {
            ToggleOptonUI(false);
        }

        private void ShowExpenseButton_Click(object sender, EventArgs e)
        {
            _parentForm.OpenChildForm(new ExpenseBoard(_sqlConnection, _parentForm));
        }
    }
}
