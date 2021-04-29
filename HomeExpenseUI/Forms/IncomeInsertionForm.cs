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
        SqlConnection conn;
        public IncomeInsertionForm(SqlConnection sqlConnection)
        {
            conn = sqlConnection;
            InitializeComponent();
        }
        List<string> _sourceNameList = new();
        List<string> _sourceTypeList = new();
        bool _isIncomeType;
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
            if (_sourceNameDropdown.SelectedItem.ToString() == "Other")
            {
                ToggleOptonUI(true);
            }
        }

        private void AddNewOptionButton_Click(object sender, EventArgs e)
        {
            if (_isIncomeType)
            {
               _sourceTypeDropdown.Items.Add(addNewOptionTextBox.Text);
                BeginInvoke(new Action(() => _sourceTypeDropdown.Text = addNewOptionTextBox.Text));
                IncomeDataModel.AddMenutoDb(conn, "Other", addNewOptionTextBox.Text);
            }
            else
            {
                _sourceNameDropdown.Items.Add(addNewOptionTextBox.Text);
                BeginInvoke(new Action(() => _sourceNameDropdown.Text = addNewOptionTextBox.Text));
                IncomeDataModel.AddMenutoDb(conn, addNewOptionTextBox.Text, "Other");
            }
            ToggleOptonUI(false);
        }

        private void SourceTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isIncomeType = true;
            if (_sourceTypeDropdown.SelectedItem.ToString() == "Other")
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
            //var nameIndex = _sourceNameDropdown.SelectedIndex;
            //string selectedIncomeName = (string)_sourceNameDropdown.Items[nameIndex];

            //var typeIndex = _sourceTypeDropdown.SelectedIndex;
            //string selectedIncomeType = (string)_sourceTypeDropdown.Items[typeIndex];
            //if(nameIndex==-1||typeIndex==-1)
            //{
            //    MessageBox.Show("Please select Type or name");
            //    return;
            //}

            //bool isSuccess= IncomeDataModel.InsertIncomeDetailsToDb(conn, selectedIncomeName,
            //   selectedIncomeType, incomeDateTimePicker.Value,incomeValueTextbox.Text);
            bool isSuccess = IncomeDataModel.InsertIncomeDetailsToDb(conn, "GPay",
             "CashBack", incomeDateTimePicker.Value, incomeValueTextbox.Text);
        }
    }
}
