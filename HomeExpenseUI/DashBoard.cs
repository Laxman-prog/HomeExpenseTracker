using HomeExpenseUI.Datbase;
using HomeExpenseUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeExpenseUI
{
    public partial class DashBoard : Form
    {
        readonly SqlConnection conn;
        readonly Form _parentForm;
        private Form currentChildForm; 
        public DashBoard(Form parentForm)
        {
            _parentForm = parentForm;
            conn = (parentForm as LoginForm).conn;
            InitializeComponent();
            HideSumMenus();
            userNameLabel.Text = LoginInfo.UserName;
            _parentForm.Visible = false;
            var incomeInsertion = new HomeForm(conn);
            OpenChildForm(incomeInsertion);
        }

        private void HideSumMenus()
        {
            incomePanel.Visible = false;
            expensePanel.Visible = false;
            reportPnael.Visible = false;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDektop.Controls.Add(childForm);
            panelDektop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ShowHideSubmenu(Panel panel)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
        }

        private void icomeMenuButton_Click(object sender, EventArgs e)
        {
            ShowHideSubmenu(incomePanel);
        }

        private void expenseMenuButton_Click(object sender, EventArgs e)
        {
            ShowHideSubmenu(expensePanel);
        }

        private void reportMenuButton_Click(object sender, EventArgs e)
        {
            ShowHideSubmenu(reportPnael);
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            LoginInfo.UserName = null;
            LoginInfo.Password= null;
            this.Close();
            _parentForm.Close();
            Application.Exit();
        }

        private void AddIncomeSubMenuButton_Click(object sender, EventArgs e)
        {
            var incomeInsertion = new IncomeInsertionForm(conn);
            OpenChildForm(incomeInsertion);
        }

        private void todaysReportSubmenuButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DailyReportForm());
        }

        private void montlyReportSubmenuButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MontlyReportForm());
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginInfo.UserName = null;
            LoginInfo.Password = null;
            _parentForm.Show();
            this.Close();
        }

        private void AddExpenseSubmenuButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ExpenseInsertion(conn));
        }

        private void AppIconPictureBox_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentformButton.Text = "Home";
            var incomeInsertion = new HomeForm(conn);
            OpenChildForm(incomeInsertion);
        }

    }
}
