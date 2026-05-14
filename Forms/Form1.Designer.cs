namespace PRG262_Bob_s_Gym
{
    partial class Form1
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(613, 665);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(261, 72);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(560, 326);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(386, 38);
            this.loginUsername.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(560, 483);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 38);
            this.textBox1.TabIndex = 2;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(404, 145);
            this.loginLbl.MaximumSize = new System.Drawing.Size(800, 900);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Padding = new System.Windows.Forms.Padding(10);
            this.loginLbl.Size = new System.Drawing.Size(772, 52);
            this.loginLbl.TabIndex = 3;
            this.loginLbl.Text = "Welcome to Bob\'s Gym Membership Management platform";
            // 
            // DOBPicker
            // 
            this.DOBPicker.Location = new System.Drawing.Point(1087, 373);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(463, 38);
            this.DOBPicker.TabIndex = 4;
            this.DOBPicker.ValueChanged += new System.EventHandler(this.DOBPicker_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 1069);
            this.Controls.Add(this.DOBPicker);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loginUsername);
            this.Controls.Add(this.loginBtn);
            this.Name = "Form1";
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.DateTimePicker DOBPicker;
    }
}

