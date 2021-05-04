
namespace HomeExpenseUI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addAcountButton = new System.Windows.Forms.Button();
            this.gmailTextBox = new System.Windows.Forms.TextBox();
            this.gmailLabel = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(150, 78);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(244, 23);
            this.userNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(35, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(35, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBox1.Controls.Add(this.addAcountButton);
            this.groupBox1.Controls.Add(this.gmailTextBox);
            this.groupBox1.Controls.Add(this.gmailLabel);
            this.groupBox1.Controls.Add(this.signInButton);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(159, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 290);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // addAcountButton
            // 
            this.addAcountButton.Location = new System.Drawing.Point(295, 250);
            this.addAcountButton.Name = "addAcountButton";
            this.addAcountButton.Size = new System.Drawing.Size(95, 34);
            this.addAcountButton.TabIndex = 11;
            this.addAcountButton.Text = "Add Account";
            this.addAcountButton.UseVisualStyleBackColor = true;
            this.addAcountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // gmailTextBox
            // 
            this.gmailTextBox.Location = new System.Drawing.Point(150, 156);
            this.gmailTextBox.Name = "gmailTextBox";
            this.gmailTextBox.Size = new System.Drawing.Size(244, 23);
            this.gmailTextBox.TabIndex = 10;
            // 
            // gmailLabel
            // 
            this.gmailLabel.AutoSize = true;
            this.gmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gmailLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.gmailLabel.Location = new System.Drawing.Point(41, 154);
            this.gmailLabel.Name = "gmailLabel";
            this.gmailLabel.Size = new System.Drawing.Size(51, 21);
            this.gmailLabel.TabIndex = 9;
            this.gmailLabel.Text = "Gmail";
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(150, 250);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(91, 34);
            this.signInButton.TabIndex = 8;
            this.signInButton.Text = "Sign-In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(295, 195);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 34);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(150, 195);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(91, 34);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(150, 118);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(244, 23);
            this.passwordTextBox.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeExpenseUI.Properties.Resources.login_icon2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 152);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 269);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(178, 23);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Welcome!!! Track Your Expenses";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 23);
            this.textBox4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(35, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "User Name";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(618, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label gmailLabel;
        private System.Windows.Forms.TextBox gmailTextBox;
        private System.Windows.Forms.Button addAcountButton;
    }
}

