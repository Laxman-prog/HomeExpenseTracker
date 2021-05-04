
namespace HomeExpenseUI
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideview = new System.Windows.Forms.Panel();
            this.exitApp = new FontAwesome.Sharp.IconButton();
            this.reportPnael = new System.Windows.Forms.Panel();
            this.yearlyReportSubmenuButton = new FontAwesome.Sharp.IconButton();
            this.montlyReportSubmenuButton = new FontAwesome.Sharp.IconButton();
            this.todaysReportSubmenuButton = new FontAwesome.Sharp.IconButton();
            this.reportMenuButton = new FontAwesome.Sharp.IconButton();
            this.expensePanel = new System.Windows.Forms.Panel();
            this.showExpenseSubmenuButton = new FontAwesome.Sharp.IconButton();
            this.addExpenseSubmenuButton = new FontAwesome.Sharp.IconButton();
            this.expenseMenuButton = new FontAwesome.Sharp.IconButton();
            this.incomePanel = new System.Windows.Forms.Panel();
            this.showIncomeSubMenuButton = new FontAwesome.Sharp.IconButton();
            this.addIncomeSubMenuButton = new FontAwesome.Sharp.IconButton();
            this.icomeMenuButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.appName = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.currentformButton = new FontAwesome.Sharp.IconButton();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.logOutButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDektop = new System.Windows.Forms.Panel();
            this.panelSideview.SuspendLayout();
            this.reportPnael.SuspendLayout();
            this.expensePanel.SuspendLayout();
            this.incomePanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelDektop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideview
            // 
            this.panelSideview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideview.Controls.Add(this.exitApp);
            this.panelSideview.Controls.Add(this.reportPnael);
            this.panelSideview.Controls.Add(this.reportMenuButton);
            this.panelSideview.Controls.Add(this.expensePanel);
            this.panelSideview.Controls.Add(this.expenseMenuButton);
            this.panelSideview.Controls.Add(this.incomePanel);
            this.panelSideview.Controls.Add(this.icomeMenuButton);
            this.panelSideview.Controls.Add(this.panelLogo);
            this.panelSideview.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideview.Location = new System.Drawing.Point(0, 0);
            this.panelSideview.Name = "panelSideview";
            this.panelSideview.Size = new System.Drawing.Size(250, 568);
            this.panelSideview.TabIndex = 0;
            // 
            // exitApp
            // 
            this.exitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitApp.FlatAppearance.BorderSize = 0;
            this.exitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitApp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exitApp.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.exitApp.IconColor = System.Drawing.Color.White;
            this.exitApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitApp.IconSize = 24;
            this.exitApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitApp.Location = new System.Drawing.Point(62, 524);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(99, 32);
            this.exitApp.TabIndex = 7;
            this.exitApp.Text = "Exit";
            this.exitApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitApp.UseVisualStyleBackColor = true;
            this.exitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // reportPnael
            // 
            this.reportPnael.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.reportPnael.Controls.Add(this.yearlyReportSubmenuButton);
            this.reportPnael.Controls.Add(this.montlyReportSubmenuButton);
            this.reportPnael.Controls.Add(this.todaysReportSubmenuButton);
            this.reportPnael.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportPnael.Location = new System.Drawing.Point(0, 388);
            this.reportPnael.Name = "reportPnael";
            this.reportPnael.Size = new System.Drawing.Size(250, 109);
            this.reportPnael.TabIndex = 6;
            // 
            // yearlyReportSubmenuButton
            // 
            this.yearlyReportSubmenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.yearlyReportSubmenuButton.FlatAppearance.BorderSize = 0;
            this.yearlyReportSubmenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearlyReportSubmenuButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.yearlyReportSubmenuButton.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.yearlyReportSubmenuButton.IconColor = System.Drawing.Color.Gainsboro;
            this.yearlyReportSubmenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.yearlyReportSubmenuButton.IconSize = 24;
            this.yearlyReportSubmenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yearlyReportSubmenuButton.Location = new System.Drawing.Point(0, 70);
            this.yearlyReportSubmenuButton.Name = "yearlyReportSubmenuButton";
            this.yearlyReportSubmenuButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.yearlyReportSubmenuButton.Size = new System.Drawing.Size(250, 35);
            this.yearlyReportSubmenuButton.TabIndex = 2;
            this.yearlyReportSubmenuButton.Text = "Yearly Report";
            this.yearlyReportSubmenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yearlyReportSubmenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.yearlyReportSubmenuButton.UseVisualStyleBackColor = true;
            // 
            // montlyReportSubmenuButton
            // 
            this.montlyReportSubmenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.montlyReportSubmenuButton.FlatAppearance.BorderSize = 0;
            this.montlyReportSubmenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.montlyReportSubmenuButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.montlyReportSubmenuButton.IconChar = FontAwesome.Sharp.IconChar.CalendarMinus;
            this.montlyReportSubmenuButton.IconColor = System.Drawing.Color.Gainsboro;
            this.montlyReportSubmenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.montlyReportSubmenuButton.IconSize = 24;
            this.montlyReportSubmenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.montlyReportSubmenuButton.Location = new System.Drawing.Point(0, 35);
            this.montlyReportSubmenuButton.Name = "montlyReportSubmenuButton";
            this.montlyReportSubmenuButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.montlyReportSubmenuButton.Size = new System.Drawing.Size(250, 35);
            this.montlyReportSubmenuButton.TabIndex = 1;
            this.montlyReportSubmenuButton.Text = "Monthly Report";
            this.montlyReportSubmenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.montlyReportSubmenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.montlyReportSubmenuButton.UseVisualStyleBackColor = true;
            this.montlyReportSubmenuButton.Click += new System.EventHandler(this.montlyReportSubmenuButton_Click);
            // 
            // todaysReportSubmenuButton
            // 
            this.todaysReportSubmenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.todaysReportSubmenuButton.FlatAppearance.BorderSize = 0;
            this.todaysReportSubmenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todaysReportSubmenuButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.todaysReportSubmenuButton.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.todaysReportSubmenuButton.IconColor = System.Drawing.Color.Gainsboro;
            this.todaysReportSubmenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.todaysReportSubmenuButton.IconSize = 24;
            this.todaysReportSubmenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.todaysReportSubmenuButton.Location = new System.Drawing.Point(0, 0);
            this.todaysReportSubmenuButton.Name = "todaysReportSubmenuButton";
            this.todaysReportSubmenuButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.todaysReportSubmenuButton.Size = new System.Drawing.Size(250, 35);
            this.todaysReportSubmenuButton.TabIndex = 0;
            this.todaysReportSubmenuButton.Text = "Todays Report";
            this.todaysReportSubmenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.todaysReportSubmenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.todaysReportSubmenuButton.UseVisualStyleBackColor = true;
            this.todaysReportSubmenuButton.Click += new System.EventHandler(this.todaysReportSubmenuButton_Click);
            // 
            // reportMenuButton
            // 
            this.reportMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportMenuButton.FlatAppearance.BorderSize = 0;
            this.reportMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportMenuButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.reportMenuButton.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.reportMenuButton.IconColor = System.Drawing.Color.White;
            this.reportMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportMenuButton.IconSize = 24;
            this.reportMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportMenuButton.Location = new System.Drawing.Point(0, 348);
            this.reportMenuButton.Name = "reportMenuButton";
            this.reportMenuButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.reportMenuButton.Size = new System.Drawing.Size(250, 40);
            this.reportMenuButton.TabIndex = 5;
            this.reportMenuButton.Text = "Report";
            this.reportMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportMenuButton.UseVisualStyleBackColor = true;
            this.reportMenuButton.Click += new System.EventHandler(this.reportMenuButton_Click);
            // 
            // expensePanel
            // 
            this.expensePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.expensePanel.Controls.Add(this.showExpenseSubmenuButton);
            this.expensePanel.Controls.Add(this.addExpenseSubmenuButton);
            this.expensePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.expensePanel.Location = new System.Drawing.Point(0, 271);
            this.expensePanel.Name = "expensePanel";
            this.expensePanel.Size = new System.Drawing.Size(250, 77);
            this.expensePanel.TabIndex = 4;
            // 
            // showExpenseSubmenuButton
            // 
            this.showExpenseSubmenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.showExpenseSubmenuButton.FlatAppearance.BorderSize = 0;
            this.showExpenseSubmenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showExpenseSubmenuButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.showExpenseSubmenuButton.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.showExpenseSubmenuButton.IconColor = System.Drawing.Color.Gainsboro;
            this.showExpenseSubmenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showExpenseSubmenuButton.IconSize = 24;
            this.showExpenseSubmenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showExpenseSubmenuButton.Location = new System.Drawing.Point(0, 35);
            this.showExpenseSubmenuButton.Name = "showExpenseSubmenuButton";
            this.showExpenseSubmenuButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.showExpenseSubmenuButton.Size = new System.Drawing.Size(250, 35);
            this.showExpenseSubmenuButton.TabIndex = 1;
            this.showExpenseSubmenuButton.Text = "Show Expense";
            this.showExpenseSubmenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showExpenseSubmenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showExpenseSubmenuButton.UseVisualStyleBackColor = true;
            // 
            // addExpenseSubmenuButton
            // 
            this.addExpenseSubmenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addExpenseSubmenuButton.FlatAppearance.BorderSize = 0;
            this.addExpenseSubmenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenseSubmenuButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.addExpenseSubmenuButton.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.addExpenseSubmenuButton.IconColor = System.Drawing.Color.Gainsboro;
            this.addExpenseSubmenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addExpenseSubmenuButton.IconSize = 24;
            this.addExpenseSubmenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addExpenseSubmenuButton.Location = new System.Drawing.Point(0, 0);
            this.addExpenseSubmenuButton.Name = "addExpenseSubmenuButton";
            this.addExpenseSubmenuButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addExpenseSubmenuButton.Size = new System.Drawing.Size(250, 35);
            this.addExpenseSubmenuButton.TabIndex = 0;
            this.addExpenseSubmenuButton.Text = "Add Expense";
            this.addExpenseSubmenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addExpenseSubmenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addExpenseSubmenuButton.UseVisualStyleBackColor = true;
            this.addExpenseSubmenuButton.Click += new System.EventHandler(this.AddExpenseSubmenuButton_Click);
            // 
            // expenseMenuButton
            // 
            this.expenseMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.expenseMenuButton.FlatAppearance.BorderSize = 0;
            this.expenseMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseMenuButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.expenseMenuButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.expenseMenuButton.IconColor = System.Drawing.Color.White;
            this.expenseMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.expenseMenuButton.IconSize = 24;
            this.expenseMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenseMenuButton.Location = new System.Drawing.Point(0, 231);
            this.expenseMenuButton.Name = "expenseMenuButton";
            this.expenseMenuButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.expenseMenuButton.Size = new System.Drawing.Size(250, 40);
            this.expenseMenuButton.TabIndex = 3;
            this.expenseMenuButton.Text = "Expense";
            this.expenseMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenseMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.expenseMenuButton.UseVisualStyleBackColor = true;
            this.expenseMenuButton.Click += new System.EventHandler(this.expenseMenuButton_Click);
            // 
            // incomePanel
            // 
            this.incomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.incomePanel.Controls.Add(this.showIncomeSubMenuButton);
            this.incomePanel.Controls.Add(this.addIncomeSubMenuButton);
            this.incomePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.incomePanel.Location = new System.Drawing.Point(0, 153);
            this.incomePanel.Name = "incomePanel";
            this.incomePanel.Size = new System.Drawing.Size(250, 78);
            this.incomePanel.TabIndex = 2;
            // 
            // showIncomeSubMenuButton
            // 
            this.showIncomeSubMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.showIncomeSubMenuButton.FlatAppearance.BorderSize = 0;
            this.showIncomeSubMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showIncomeSubMenuButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.showIncomeSubMenuButton.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.showIncomeSubMenuButton.IconColor = System.Drawing.Color.Gainsboro;
            this.showIncomeSubMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showIncomeSubMenuButton.IconSize = 24;
            this.showIncomeSubMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showIncomeSubMenuButton.Location = new System.Drawing.Point(0, 35);
            this.showIncomeSubMenuButton.Name = "showIncomeSubMenuButton";
            this.showIncomeSubMenuButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.showIncomeSubMenuButton.Size = new System.Drawing.Size(250, 53);
            this.showIncomeSubMenuButton.TabIndex = 1;
            this.showIncomeSubMenuButton.Text = "Show Income";
            this.showIncomeSubMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showIncomeSubMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showIncomeSubMenuButton.UseVisualStyleBackColor = true;
            // 
            // addIncomeSubMenuButton
            // 
            this.addIncomeSubMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addIncomeSubMenuButton.FlatAppearance.BorderSize = 0;
            this.addIncomeSubMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIncomeSubMenuButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.addIncomeSubMenuButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.addIncomeSubMenuButton.IconColor = System.Drawing.Color.Gainsboro;
            this.addIncomeSubMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addIncomeSubMenuButton.IconSize = 24;
            this.addIncomeSubMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addIncomeSubMenuButton.Location = new System.Drawing.Point(0, 0);
            this.addIncomeSubMenuButton.Name = "addIncomeSubMenuButton";
            this.addIncomeSubMenuButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addIncomeSubMenuButton.Size = new System.Drawing.Size(250, 35);
            this.addIncomeSubMenuButton.TabIndex = 0;
            this.addIncomeSubMenuButton.Text = "Add Income";
            this.addIncomeSubMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addIncomeSubMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addIncomeSubMenuButton.UseVisualStyleBackColor = true;
            this.addIncomeSubMenuButton.Click += new System.EventHandler(this.AddIncomeSubMenuButton_Click);
            // 
            // icomeMenuButton
            // 
            this.icomeMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.icomeMenuButton.FlatAppearance.BorderSize = 0;
            this.icomeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icomeMenuButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.icomeMenuButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.icomeMenuButton.IconColor = System.Drawing.Color.White;
            this.icomeMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icomeMenuButton.IconSize = 24;
            this.icomeMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icomeMenuButton.Location = new System.Drawing.Point(0, 113);
            this.icomeMenuButton.Name = "icomeMenuButton";
            this.icomeMenuButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icomeMenuButton.Size = new System.Drawing.Size(250, 40);
            this.icomeMenuButton.TabIndex = 1;
            this.icomeMenuButton.Text = "Income";
            this.icomeMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icomeMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icomeMenuButton.UseVisualStyleBackColor = true;
            this.icomeMenuButton.Click += new System.EventHandler(this.icomeMenuButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.iconPictureBox1);
            this.panelLogo.Controls.Add(this.appName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 113);
            this.panelLogo.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.RupeeSign;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 76;
            this.iconPictureBox1.Location = new System.Drawing.Point(62, 37);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(86, 76);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.AppIconPictureBox_Click);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Dock = System.Windows.Forms.DockStyle.Top;
            this.appName.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.appName.Location = new System.Drawing.Point(0, 0);
            this.appName.Name = "appName";
            this.appName.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.appName.Size = new System.Drawing.Size(202, 34);
            this.appName.TabIndex = 0;
            this.appName.Text = "Money Manager";
            this.appName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Menu;
            this.button4.Location = new System.Drawing.Point(0, 147);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(250, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add Income";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.currentformButton);
            this.panel3.Controls.Add(this.userNameLabel);
            this.panel3.Controls.Add(this.logOutButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(250, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(698, 40);
            this.panel3.TabIndex = 1;
            // 
            // currentformButton
            // 
            this.currentformButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentformButton.FlatAppearance.BorderSize = 0;
            this.currentformButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentformButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.currentformButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currentformButton.IconColor = System.Drawing.Color.White;
            this.currentformButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentformButton.IconSize = 24;
            this.currentformButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentformButton.Location = new System.Drawing.Point(0, 0);
            this.currentformButton.Name = "currentformButton";
            this.currentformButton.Size = new System.Drawing.Size(99, 40);
            this.currentformButton.TabIndex = 8;
            this.currentformButton.Text = "Home";
            this.currentformButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentformButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.currentformButton.UseVisualStyleBackColor = true;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.userNameLabel.Location = new System.Drawing.Point(503, 13);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(74, 17);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "User Name";
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logOutButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logOutButton.IconColor = System.Drawing.Color.White;
            this.logOutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logOutButton.IconSize = 24;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(599, 0);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(99, 40);
            this.logOutButton.TabIndex = 8;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 9);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel2.Size = new System.Drawing.Size(698, 519);
            this.panel2.TabIndex = 9;
            // 
            // panelDektop
            // 
            this.panelDektop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDektop.Controls.Add(this.panel2);
            this.panelDektop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDektop.Location = new System.Drawing.Point(250, 49);
            this.panelDektop.Name = "panelDektop";
            this.panelDektop.Size = new System.Drawing.Size(698, 519);
            this.panelDektop.TabIndex = 3;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 568);
            this.Controls.Add(this.panelDektop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSideview);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panelSideview.ResumeLayout(false);
            this.reportPnael.ResumeLayout(false);
            this.expensePanel.ResumeLayout(false);
            this.incomePanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelDektop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideview;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button4;
        private FontAwesome.Sharp.IconButton exitApp;
        private System.Windows.Forms.Panel reportPnael;
        private FontAwesome.Sharp.IconButton yearlyReportSubmenuButton;
        private FontAwesome.Sharp.IconButton montlyReportSubmenuButton;
        private FontAwesome.Sharp.IconButton todaysReportSubmenuButton;
        private FontAwesome.Sharp.IconButton reportMenuButton;
        private System.Windows.Forms.Panel expensePanel;
        private FontAwesome.Sharp.IconButton showExpenseSubmenuButton;
        private FontAwesome.Sharp.IconButton addExpenseSubmenuButton;
        private FontAwesome.Sharp.IconButton expenseMenuButton;
        private System.Windows.Forms.Panel incomePanel;
        private FontAwesome.Sharp.IconButton showIncomeSubMenuButton;
        private FontAwesome.Sharp.IconButton addIncomeSubMenuButton;
        private FontAwesome.Sharp.IconButton icomeMenuButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label appName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton logOutButton;
        private System.Windows.Forms.Label userNameLabel;
        private FontAwesome.Sharp.IconButton currentformButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDektop;
    }
}