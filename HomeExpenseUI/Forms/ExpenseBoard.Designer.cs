
namespace HomeExpenseUI.Forms
{
    partial class ExpenseBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.showExpenseButton = new FontAwesome.Sharp.IconButton();
            this.showIncomeDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalExpleseLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showIncomeDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerDate);
            this.panel1.Controls.Add(this.showExpenseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 4;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(12, 11);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDate.TabIndex = 19;
            // 
            // showExpenseButton
            // 
            this.showExpenseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.showExpenseButton.FlatAppearance.BorderSize = 0;
            this.showExpenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showExpenseButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.showExpenseButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.showExpenseButton.IconColor = System.Drawing.Color.White;
            this.showExpenseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showExpenseButton.IconSize = 36;
            this.showExpenseButton.Location = new System.Drawing.Point(657, 0);
            this.showExpenseButton.Name = "showExpenseButton";
            this.showExpenseButton.Size = new System.Drawing.Size(143, 45);
            this.showExpenseButton.TabIndex = 11;
            this.showExpenseButton.Text = "Add Expense";
            this.showExpenseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showExpenseButton.UseVisualStyleBackColor = true;
            this.showExpenseButton.Click += new System.EventHandler(this.ShowExpeses);
            // 
            // showIncomeDataGrid
            // 
            this.showIncomeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showIncomeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Id,
            this.Edit,
            this.Delete});
            this.showIncomeDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showIncomeDataGrid.Location = new System.Drawing.Point(0, 45);
            this.showIncomeDataGrid.Name = "showIncomeDataGrid";
            this.showIncomeDataGrid.RowTemplate.Height = 25;
            this.showIncomeDataGrid.ShowEditingIcon = false;
            this.showIncomeDataGrid.Size = new System.Drawing.Size(800, 405);
            this.showIncomeDataGrid.TabIndex = 5;
            this.showIncomeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showIncomeDataGrid_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Expense Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Expense Type";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Amount";
            this.Column4.Name = "Column4";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 5;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit record";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete record";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalExpleseLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 44);
            this.panel2.TabIndex = 6;
            // 
            // totalExpleseLabel
            // 
            this.totalExpleseLabel.AutoSize = true;
            this.totalExpleseLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalExpleseLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.totalExpleseLabel.Location = new System.Drawing.Point(506, 15);
            this.totalExpleseLabel.Name = "totalExpleseLabel";
            this.totalExpleseLabel.Size = new System.Drawing.Size(51, 20);
            this.totalExpleseLabel.TabIndex = 0;
            this.totalExpleseLabel.Text = "label1";
            // 
            // ExpenseBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.showIncomeDataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "ExpenseBoard";
            this.Text = "ExpenseBoard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showIncomeDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private FontAwesome.Sharp.IconButton showExpenseButton;
        private System.Windows.Forms.DataGridView showIncomeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalExpleseLabel;
    }
}