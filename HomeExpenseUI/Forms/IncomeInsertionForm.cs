using HomeExpenseUI.Datbase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HomeExpenseUI.Forms
{
    public partial class IncomeInsertionForm : Form
    {
        SqlConnection _sqlConnection;
        DashBoard _parentForm;
        public IncomeInsertionForm(SqlConnection sqlConnection, DashBoard parentForm)
        {
            _sqlConnection = sqlConnection;
            _parentForm = parentForm;
            InitializeComponent();
        }
        List<string> _sourceNameList = new();
        List<string> _sourceTypeList = new();
        bool _isIncomeType;
        public void Alert(string msg, Form_Alert.AlertType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void IncomeInsertionForm_Load(object sender, EventArgs e)
        {
            addNewOption.Visible = false;
            addNewOptionButton.Visible = false;
            addNewOptionCancel.Visible = false;
            addNewOptionTextBox.Visible = false;

            ToggglePreviousMonthUI(false);
            previousAmoutLabel.Visible = false;
            prevousAmountNumbox.Visible = false;
            previousMonthAdd.Visible = false;
            IncomeDataModel incomeDataModel = new IncomeDataModel();
            //Source Type
            _sourceTypeDropdown.Items.Add("Salary");
            _sourceTypeDropdown.Items.Add("Commission");
            _sourceTypeDropdown.Items.Add("Selling ");
            _sourceTypeDropdown.Items.Add("Gifts");
            _sourceTypeDropdown.Items.Add("Investments");
            _sourceTypeList = incomeDataModel.GetMenuNamesfromDb(_sqlConnection, "SourceType");
            if (_sourceTypeList.Count == 0)
            {
                _sourceTypeDropdown.Items.AddRange(_sourceTypeList.ToArray());
                _sourceTypeDropdown.Items.Remove("Other");
                _sourceTypeDropdown.Items.Add("Other");
            }
            else
            {
                _sourceTypeDropdown.Items.Add("Other");
            }

            _sourceTypeDropdown.SelectedItem = null;
            _sourceTypeDropdown.SelectedText = "--Select--";

        }

        private void AddNewOptionButton_Click(object sender, EventArgs e)
        {
            if (addNewOptionTextBox.Text.Equals(string.Empty))
            {
                this.Alert("Wrong input ", Form_Alert.AlertType.Error);
                return;
            }
            bool isAdded = false;
            if (_isIncomeType)
            {
                _sourceTypeDropdown.Items.Add(addNewOptionTextBox.Text);
                BeginInvoke(new Action(() => _sourceTypeDropdown.Text = addNewOptionTextBox.Text));
                isAdded = IncomeDataModel.AddMenutoDb(_sqlConnection, "Other", addNewOptionTextBox.Text);
            }

            if (!isAdded)
            {
                this.Alert("Insert Failed", Form_Alert.AlertType.Error);
            }
            ToggleOptonUI(false);
        }

        private void SourceTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isIncomeType = true;
            if (_sourceTypeDropdown.SelectedItem?.ToString() == "Other")
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

        private void SubmitIncomeButton_Click(object sender, EventArgs e)
        {
            var typeIndex = _sourceTypeDropdown.SelectedIndex;
            string selectedIncomeType = (string)_sourceTypeDropdown.Items[typeIndex];
            if (incomeName.Text == string.Empty || typeIndex == -1 || incomeValueNumbox.Value == 0)
            {
                this.Alert("Wrong Input", Form_Alert.AlertType.Error);
                return;
            }

            bool isSuccess = IncomeDataModel.InsertIncomeDetailsToDb(_sqlConnection, incomeName.Text,
               selectedIncomeType, incomeDateTimePicker.Value, incomeValueNumbox.Text);
            if (isSuccess)
            {
                this.Alert("Insert Success", Form_Alert.AlertType.Success);
            }
        }

        private void ResetIncomeButton_Click(object sender, EventArgs e)
        {
            _sourceTypeDropdown.SelectedItem = null;
            _sourceTypeDropdown.SelectedText = "--Select--";
            incomeValueNumbox.Value = 0;
        }

        private void AddNewOptionCancel_Click(object sender, EventArgs e)
        {
            ToggleOptonUI(false);
        }

        private void ShowIcomeButton_Click(object sender, EventArgs e)
        {
            _parentForm.OpenChildForm(new IncomesBoard(_sqlConnection, _parentForm));
        }

        private void PreviousAmountButton_Click(object sender, EventArgs e)
        {
            ToggglePreviousMonthUI(true);
        }
        private void ToggglePreviousMonthUI(bool isHide)

        {
            previousAmoutLabel.Visible = isHide;
            prevousAmountNumbox.Visible = isHide;
            previousMonthAdd.Visible = isHide;
            previousAmtDateLabel.Visible = isHide;
            previousAmountDate.Visible = isHide;
            previousAmountCancel.Visible = isHide;
        }

        private void PreviousMonthAdd_Click(object sender, EventArgs e)
        {
            if ( prevousAmountNumbox.Value == 0)
            {
                this.Alert("Wrong Input", Form_Alert.AlertType.Error);
                return;
            }

            bool isSuccess = IncomeDataModel.AddPreviousMonthAmountDetailToDb(_sqlConnection, previousAmountDate.Value, prevousAmountNumbox.Text);
            if (isSuccess)
            {
                this.Alert("Insert Success", Form_Alert.AlertType.Success);
            }
            ToggglePreviousMonthUI(false);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PreviousAmountCancel_Click(object sender, EventArgs e)
        {
            ToggglePreviousMonthUI(false);
        }
    }
}
