
namespace HomeExpenseUI.Forms
{
    partial class ExpenseInsertion
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this._expenseTypeDropdown = new System.Windows.Forms.ComboBox();
            this.incomeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelIncomeButton = new System.Windows.Forms.Button();
            this.submitIncomeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._sourceNameDropdown = new System.Windows.Forms.ComboBox();
            this.expenseValueTextbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addNewOptionCancel = new System.Windows.Forms.Button();
            this.addNewOptionButton = new System.Windows.Forms.Button();
            this.addNewOption = new System.Windows.Forms.Label();
            this.addNewOptionTextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this._expenseTypeDropdown);
            this.panel2.Controls.Add(this.incomeDateTimePicker);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cancelIncomeButton);
            this.panel2.Controls.Add(this.submitIncomeButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this._sourceNameDropdown);
            this.panel2.Controls.Add(this.expenseValueTextbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 405);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(33, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Expense Type";
            // 
            // _expenseTypeDropdown
            // 
            this._expenseTypeDropdown.FormattingEnabled = true;
            this._expenseTypeDropdown.Location = new System.Drawing.Point(132, 139);
            this._expenseTypeDropdown.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this._expenseTypeDropdown.Name = "_expenseTypeDropdown";
            this._expenseTypeDropdown.Size = new System.Drawing.Size(182, 23);
            this._expenseTypeDropdown.TabIndex = 8;
            // 
            // incomeDateTimePicker
            // 
            this.incomeDateTimePicker.Location = new System.Drawing.Point(132, 31);
            this.incomeDateTimePicker.Name = "incomeDateTimePicker";
            this.incomeDateTimePicker.Size = new System.Drawing.Size(182, 23);
            this.incomeDateTimePicker.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(33, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Date";
            // 
            // cancelIncomeButton
            // 
            this.cancelIncomeButton.Location = new System.Drawing.Point(232, 259);
            this.cancelIncomeButton.Name = "cancelIncomeButton";
            this.cancelIncomeButton.Size = new System.Drawing.Size(100, 32);
            this.cancelIncomeButton.TabIndex = 5;
            this.cancelIncomeButton.Text = "Cancel";
            this.cancelIncomeButton.UseVisualStyleBackColor = true;
            // 
            // submitIncomeButton
            // 
            this.submitIncomeButton.Location = new System.Drawing.Point(84, 259);
            this.submitIncomeButton.Name = "submitIncomeButton";
            this.submitIncomeButton.Size = new System.Drawing.Size(100, 32);
            this.submitIncomeButton.TabIndex = 4;
            this.submitIncomeButton.Text = "Submit";
            this.submitIncomeButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(33, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Money";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(31, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expense Source";
            // 
            // _sourceNameDropdown
            // 
            this._sourceNameDropdown.FormattingEnabled = true;
            this._sourceNameDropdown.Location = new System.Drawing.Point(132, 83);
            this._sourceNameDropdown.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this._sourceNameDropdown.Name = "_sourceNameDropdown";
            this._sourceNameDropdown.Size = new System.Drawing.Size(182, 23);
            this._sourceNameDropdown.TabIndex = 1;
            // 
            // expenseValueTextbox
            // 
            this.expenseValueTextbox.Location = new System.Drawing.Point(132, 197);
            this.expenseValueTextbox.Name = "expenseValueTextbox";
            this.expenseValueTextbox.Size = new System.Drawing.Size(182, 23);
            this.expenseValueTextbox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addNewOptionCancel);
            this.panel3.Controls.Add(this.addNewOptionButton);
            this.panel3.Controls.Add(this.addNewOption);
            this.panel3.Controls.Add(this.addNewOptionTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(375, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 405);
            this.panel3.TabIndex = 4;
            // 
            // addNewOptionCancel
            // 
            this.addNewOptionCancel.Location = new System.Drawing.Point(179, 153);
            this.addNewOptionCancel.Name = "addNewOptionCancel";
            this.addNewOptionCancel.Size = new System.Drawing.Size(100, 32);
            this.addNewOptionCancel.TabIndex = 9;
            this.addNewOptionCancel.Text = "Cancel";
            this.addNewOptionCancel.UseVisualStyleBackColor = true;
            // 
            // addNewOptionButton
            // 
            this.addNewOptionButton.Location = new System.Drawing.Point(42, 153);
            this.addNewOptionButton.Name = "addNewOptionButton";
            this.addNewOptionButton.Size = new System.Drawing.Size(100, 32);
            this.addNewOptionButton.TabIndex = 8;
            this.addNewOptionButton.Text = "Add";
            this.addNewOptionButton.UseVisualStyleBackColor = true;
            // 
            // addNewOption
            // 
            this.addNewOption.AutoSize = true;
            this.addNewOption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewOption.ForeColor = System.Drawing.SystemColors.Menu;
            this.addNewOption.Location = new System.Drawing.Point(10, 91);
            this.addNewOption.Name = "addNewOption";
            this.addNewOption.Size = new System.Drawing.Size(43, 17);
            this.addNewOption.TabIndex = 8;
            this.addNewOption.Text = "Name";
            // 
            // addNewOptionTextBox
            // 
            this.addNewOptionTextBox.Location = new System.Drawing.Point(74, 91);
            this.addNewOptionTextBox.Name = "addNewOptionTextBox";
            this.addNewOptionTextBox.Size = new System.Drawing.Size(182, 23);
            this.addNewOptionTextBox.TabIndex = 8;
            // 
            // ExpenseInsertion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExpenseInsertion";
            this.Text = "ExpenseInsertion";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _expenseTypeDropdown;
        private System.Windows.Forms.DateTimePicker incomeDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelIncomeButton;
        private System.Windows.Forms.Button submitIncomeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _sourceNameDropdown;
        private System.Windows.Forms.TextBox expenseValueTextbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addNewOptionCancel;
        private System.Windows.Forms.Button addNewOptionButton;
        private System.Windows.Forms.Label addNewOption;
        private System.Windows.Forms.TextBox addNewOptionTextBox;
    }
}