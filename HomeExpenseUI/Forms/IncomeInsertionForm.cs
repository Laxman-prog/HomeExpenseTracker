using HomeExpenseUI.Datbase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        private void IncomeInsertionForm_Load(object sender, EventArgs e)
        {
            addNewOption.Visible = false;
            addNewOptionButton.Visible = false;
            addNewOptionCancel.Visible = false;
            addNewOptionTextBox.Visible = false;
            IncomeDataModel incomeDataModel = new IncomeDataModel();
            var menuList = incomeDataModel.GetDropdownsMenusfromDb(conn);
            if (sourceNameDropdown.Items.Count == 0)
            {
                sourceNameDropdown.Items.Add(LoginInfo.UserName);
                sourceNameDropdown.SelectedItem = null;
                sourceNameDropdown.SelectedText = "--Select--";
                sourceNameDropdown.Items.Add("Other");
            }
            else
            {
                sourceNameDropdown.Items.AddRange(menuList.ToArray());
            }
        }


        private void sourceNameDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sourceNameDropdown.SelectedItem.ToString() == "Other")
            {
                addNewOption.Visible = true;
                addNewOptionButton.Visible = true;
                addNewOptionCancel.Visible = true;
                addNewOptionTextBox.Visible = true;
            }
        }

        private void addNewOptionButton_Click(object sender, EventArgs e)
        {
            sourceNameDropdown.Items.Add(addNewOptionTextBox.Text);
            IncomeDataModel incomeDataModel = new IncomeDataModel();
            List<string> menus=new List<string>();
            foreach (var item in sourceNameDropdown.Items)
            {
                menus.Add(item.ToString());
            }
            incomeDataModel.AddIncomeSourceNamestoDb(menus, conn);
        }
    }
}
