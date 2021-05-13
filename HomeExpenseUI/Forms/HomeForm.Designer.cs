
namespace HomeExpenseUI.Forms
{
    partial class HomeForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.TestButton = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.totalBalamceValue = new System.Windows.Forms.Label();
            this.totalExpenseValue = new System.Windows.Forms.Label();
            this.previousAmountValue = new System.Windows.Forms.Label();
            this.totalIncomeValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TestButton);
            this.panel1.Controls.Add(this.dateTimePickerDate);
            this.panel1.Controls.Add(this.totalBalamceValue);
            this.panel1.Controls.Add(this.totalExpenseValue);
            this.panel1.Controls.Add(this.previousAmountValue);
            this.panel1.Controls.Add(this.totalIncomeValue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.totalIncomeLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 231);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(444, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Select Month";
            // 
            // TestButton
            // 
            this.TestButton.BackColor = System.Drawing.Color.SeaGreen;
            this.TestButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TestButton.FlatAppearance.BorderSize = 0;
            this.TestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.TestButton.Location = new System.Drawing.Point(491, 132);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(109, 35);
            this.TestButton.TabIndex = 20;
            this.TestButton.Text = "Load Data";
            this.TestButton.UseVisualStyleBackColor = false;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(444, 79);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDate.TabIndex = 18;
            // 
            // totalBalamceValue
            // 
            this.totalBalamceValue.AutoSize = true;
            this.totalBalamceValue.ForeColor = System.Drawing.SystemColors.Menu;
            this.totalBalamceValue.Location = new System.Drawing.Point(262, 204);
            this.totalBalamceValue.Name = "totalBalamceValue";
            this.totalBalamceValue.Size = new System.Drawing.Size(25, 15);
            this.totalBalamceValue.TabIndex = 17;
            this.totalBalamceValue.Text = "000";
            // 
            // totalExpenseValue
            // 
            this.totalExpenseValue.AutoSize = true;
            this.totalExpenseValue.ForeColor = System.Drawing.SystemColors.Menu;
            this.totalExpenseValue.Location = new System.Drawing.Point(262, 168);
            this.totalExpenseValue.Name = "totalExpenseValue";
            this.totalExpenseValue.Size = new System.Drawing.Size(25, 15);
            this.totalExpenseValue.TabIndex = 16;
            this.totalExpenseValue.Text = "000";
            // 
            // previousAmountValue
            // 
            this.previousAmountValue.AutoSize = true;
            this.previousAmountValue.ForeColor = System.Drawing.SystemColors.Menu;
            this.previousAmountValue.Location = new System.Drawing.Point(262, 132);
            this.previousAmountValue.Name = "previousAmountValue";
            this.previousAmountValue.Size = new System.Drawing.Size(25, 15);
            this.previousAmountValue.TabIndex = 15;
            this.previousAmountValue.Text = "000";
            // 
            // totalIncomeValue
            // 
            this.totalIncomeValue.AutoSize = true;
            this.totalIncomeValue.ForeColor = System.Drawing.SystemColors.Menu;
            this.totalIncomeValue.Location = new System.Drawing.Point(262, 96);
            this.totalIncomeValue.Name = "totalIncomeValue";
            this.totalIncomeValue.Size = new System.Drawing.Size(25, 15);
            this.totalIncomeValue.TabIndex = 14;
            this.totalIncomeValue.Text = "000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(0, 183);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.label4.Size = new System.Drawing.Size(137, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(0, 147);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.label3.Size = new System.Drawing.Size(137, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Expense:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(0, 111);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.label2.Size = new System.Drawing.Size(162, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Previous Amount:";
            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.AutoSize = true;
            this.totalIncomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalIncomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.totalIncomeLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.totalIncomeLabel.Location = new System.Drawing.Point(0, 60);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Padding = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.totalIncomeLabel.Size = new System.Drawing.Size(133, 51);
            this.totalIncomeLabel.TabIndex = 10;
            this.totalIncomeLabel.Text = "Total Income:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label1.Size = new System.Drawing.Size(331, 60);
            this.label1.TabIndex = 9;
            this.label1.Text = "Monthly Balance + Remainings";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 278);
            this.panel2.TabIndex = 1;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalBalamceValue;
        private System.Windows.Forms.Label totalExpenseValue;
        private System.Windows.Forms.Label previousAmountValue;
        private System.Windows.Forms.Label totalIncomeValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label5;
    }
}