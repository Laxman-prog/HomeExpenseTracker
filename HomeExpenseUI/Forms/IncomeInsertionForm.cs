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
using ExpenseUtils;

namespace HomeExpenseUI.Forms
{
    public partial class IncomeInsertionForm : Form
    {
        SqlConnection conn;
        public IncomeInsertionForm(SqlConnection sqlConnection)
        {
            conn = sqlConnection;
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
            IncomeDataModel incomeDataModel = new IncomeDataModel();
            _sourceNameDropdown.Items.Add(LoginInfo.UserName);
            _sourceNameList = incomeDataModel.GetMenuNamesfromDb(conn, "SourceName");
            if (_sourceNameList.Count != 0)
            {
                _sourceNameDropdown.Items.AddRange(items: _sourceNameList.ToArray());
                _sourceNameDropdown.Items.Remove("Other");
                _sourceNameDropdown.Items.Add("Other");
            }
            else
            {
                _sourceNameDropdown.Items.Add("Other");
            }
      
            _sourceNameDropdown.SelectedItem = null;
            _sourceNameDropdown.SelectedText = "--Select--";

            //Source Type
            _sourceTypeDropdown.Items.Add("Salary");
            _sourceTypeDropdown.Items.Add("Commission");
            _sourceTypeDropdown.Items.Add("Selling ");
            _sourceTypeDropdown.Items.Add("Gifts");
            _sourceTypeDropdown.Items.Add("Investments");
            _sourceTypeList = incomeDataModel.GetMenuNamesfromDb(conn, "SourceType");
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


        private void SourceNameDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isIncomeType = false;
            if (_sourceNameDropdown.SelectedItem?.ToString() == "Other")
            {
                ToggleOptonUI(true);
            }
        }

        private void AddNewOptionButton_Click(object sender, EventArgs e)
        {
            if (addNewOptionTextBox.Text.Equals(string.Empty))
            {
                this.Alert("Wrong input ", Form_Alert.AlertType.Error);
                return;
            }
            bool isAdded;
            if (_isIncomeType)
            {
               _sourceTypeDropdown.Items.Add(addNewOptionTextBox.Text);
                BeginInvoke(new Action(() => _sourceTypeDropdown.Text = addNewOptionTextBox.Text));
                isAdded= IncomeDataModel.AddMenutoDb(conn, "Other", addNewOptionTextBox.Text);
            }
            else
            {
                _sourceNameDropdown.Items.Add(addNewOptionTextBox.Text);
                BeginInvoke(new Action(() => _sourceNameDropdown.Text = addNewOptionTextBox.Text));
                isAdded= IncomeDataModel.AddMenutoDb(conn, addNewOptionTextBox.Text, "Other");
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
            var nameIndex = _sourceNameDropdown.SelectedIndex;
            string selectedIncomeName = (string)_sourceNameDropdown.Items[nameIndex];

            var typeIndex = _sourceTypeDropdown.SelectedIndex;
            string selectedIncomeType = (string)_sourceTypeDropdown.Items[typeIndex];
            if (nameIndex == -1 || typeIndex == -1|| incomeValueNumbox.Value==0)
            {
                this.Alert("Wrong Input", Form_Alert.AlertType.Error);
                return;
            }

            bool isSuccess = IncomeDataModel.InsertIncomeDetailsToDb(conn, selectedIncomeName,
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
            _sourceNameDropdown.SelectedItem = null;
            _sourceNameDropdown.SelectedText = "--Select--";
            incomeValueNumbox.Value = 0;
        }

        private void AddNewOptionCancel_Click(object sender, EventArgs e)
        {
            ToggleOptonUI(false);
        }
    }
}
