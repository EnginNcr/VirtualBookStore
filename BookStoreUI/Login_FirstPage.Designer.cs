namespace BookStoreUI
{
    partial class Login_FirstPage
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
            this.lblUserNameLogin = new System.Windows.Forms.Label();
            this.lblUserPasswordLogin = new System.Windows.Forms.Label();
            this.tbxUserNameLogin = new System.Windows.Forms.TextBox();
            this.tbxPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnSignInLogin = new System.Windows.Forms.Button();
            this.lblSignUpLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserNameLogin
            // 
            this.lblUserNameLogin.AutoSize = true;
            this.lblUserNameLogin.Location = new System.Drawing.Point(228, 142);
            this.lblUserNameLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserNameLogin.Name = "lblUserNameLogin";
            this.lblUserNameLogin.Size = new System.Drawing.Size(99, 22);
            this.lblUserNameLogin.TabIndex = 0;
            this.lblUserNameLogin.Text = "UserName:";
            // 
            // lblUserPasswordLogin
            // 
            this.lblUserPasswordLogin.AutoSize = true;
            this.lblUserPasswordLogin.Location = new System.Drawing.Point(228, 213);
            this.lblUserPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPasswordLogin.Name = "lblUserPasswordLogin";
            this.lblUserPasswordLogin.Size = new System.Drawing.Size(92, 22);
            this.lblUserPasswordLogin.TabIndex = 0;
            this.lblUserPasswordLogin.Text = "Password:";
            // 
            // tbxUserNameLogin
            // 
            this.tbxUserNameLogin.Location = new System.Drawing.Point(374, 138);
            this.tbxUserNameLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxUserNameLogin.Name = "tbxUserNameLogin";
            this.tbxUserNameLogin.Size = new System.Drawing.Size(189, 29);
            this.tbxUserNameLogin.TabIndex = 1;
            // 
            // tbxPasswordLogin
            // 
            this.tbxPasswordLogin.Location = new System.Drawing.Point(374, 209);
            this.tbxPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPasswordLogin.Name = "tbxPasswordLogin";
            this.tbxPasswordLogin.Size = new System.Drawing.Size(189, 29);
            this.tbxPasswordLogin.TabIndex = 1;
            // 
            // btnSignInLogin
            // 
            this.btnSignInLogin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignInLogin.Location = new System.Drawing.Point(429, 279);
            this.btnSignInLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignInLogin.Name = "btnSignInLogin";
            this.btnSignInLogin.Size = new System.Drawing.Size(134, 39);
            this.btnSignInLogin.TabIndex = 2;
            this.btnSignInLogin.Text = "SIGN IN";
            this.btnSignInLogin.UseVisualStyleBackColor = true;
            this.btnSignInLogin.Click += new System.EventHandler(this.btnSignInLogin_Click);
            // 
            // lblSignUpLogin
            // 
            this.lblSignUpLogin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUpLogin.Location = new System.Drawing.Point(232, 279);
            this.lblSignUpLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSignUpLogin.Name = "lblSignUpLogin";
            this.lblSignUpLogin.Size = new System.Drawing.Size(148, 39);
            this.lblSignUpLogin.TabIndex = 2;
            this.lblSignUpLogin.Text = "SIGN UP";
            this.lblSignUpLogin.UseVisualStyleBackColor = true;
            this.lblSignUpLogin.Click += new System.EventHandler(this.lblSignUpLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 405);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin User Name=Admin  Password=1234";
            // 
            // Login_FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSignUpLogin);
            this.Controls.Add(this.btnSignInLogin);
            this.Controls.Add(this.tbxPasswordLogin);
            this.Controls.Add(this.tbxUserNameLogin);
            this.Controls.Add(this.lblUserPasswordLogin);
            this.Controls.Add(this.lblUserNameLogin);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Login_FirstPage";
            this.Text = "Virtual Book Store";
            this.Load += new System.EventHandler(this.Login_FirstPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserNameLogin;
        private System.Windows.Forms.Label lblUserPasswordLogin;
        private System.Windows.Forms.TextBox tbxUserNameLogin;
        private System.Windows.Forms.TextBox tbxPasswordLogin;
        private System.Windows.Forms.Button btnSignInLogin;
        private System.Windows.Forms.Button lblSignUpLogin;
        private System.Windows.Forms.Label label1;
    }
}

