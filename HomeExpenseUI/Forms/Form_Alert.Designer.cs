
namespace HomeExpenseUI.Forms
{
    partial class Form_Alert
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
            this.components = new System.ComponentModel.Container();
            this.alertImageBox = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alertImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // alertImageBox
            // 
            this.alertImageBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.alertImageBox.ForeColor = System.Drawing.Color.Green;
            this.alertImageBox.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.alertImageBox.IconColor = System.Drawing.Color.Green;
            this.alertImageBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.alertImageBox.IconSize = 45;
            this.alertImageBox.Location = new System.Drawing.Point(12, 12);
            this.alertImageBox.Name = "alertImageBox";
            this.alertImageBox.Size = new System.Drawing.Size(45, 45);
            this.alertImageBox.TabIndex = 0;
            this.alertImageBox.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 45;
            this.iconPictureBox2.Location = new System.Drawing.Point(288, 12);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(45, 45);
            this.iconPictureBox2.TabIndex = 1;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, -70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // displayMessage
            // 
            this.displayMessage.AutoSize = true;
            this.displayMessage.BackColor = System.Drawing.SystemColors.Highlight;
            this.displayMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayMessage.ForeColor = System.Drawing.Color.White;
            this.displayMessage.Location = new System.Drawing.Point(100, 21);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(126, 21);
            this.displayMessage.TabIndex = 3;
            this.displayMessage.Text = "Display Message";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form_Alert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(347, 74);
            this.Controls.Add(this.displayMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.alertImageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Alert";
            this.Text = "Form_Alert";
            ((System.ComponentModel.ISupportInitialize)(this.alertImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox alertImageBox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayMessage;
        private System.Windows.Forms.Timer timer1;
    }
}