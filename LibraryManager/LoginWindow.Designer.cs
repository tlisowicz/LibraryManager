
namespace LibraryManager
{
    partial class LoginWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_login_name = new System.Windows.Forms.TextBox();
            this.tbx_login_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login_signin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.tbx_create_pwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_create_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_create_pwd2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_login_signup = new System.Windows.Forms.Button();
            this.btn_login_guest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbx_login_name
            // 
            this.tbx_login_name.Location = new System.Drawing.Point(108, 80);
            this.tbx_login_name.Name = "tbx_login_name";
            this.tbx_login_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_login_name.TabIndex = 1;
            // 
            // tbx_login_pwd
            // 
            this.tbx_login_pwd.Location = new System.Drawing.Point(108, 116);
            this.tbx_login_pwd.Name = "tbx_login_pwd";
            this.tbx_login_pwd.Size = new System.Drawing.Size(100, 20);
            this.tbx_login_pwd.TabIndex = 3;
            this.tbx_login_pwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // btn_login_signin
            // 
            this.btn_login_signin.Location = new System.Drawing.Point(144, 157);
            this.btn_login_signin.Name = "btn_login_signin";
            this.btn_login_signin.Size = new System.Drawing.Size(100, 23);
            this.btn_login_signin.TabIndex = 4;
            this.btn_login_signin.Text = "Sign in";
            this.btn_login_signin.UseVisualStyleBackColor = true;
            this.btn_login_signin.Click += new System.EventHandler(this.btn_login_signin_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(38, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sign In";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(38, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Create account";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(108, 423);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(100, 23);
            this.btn_create.TabIndex = 10;
            this.btn_create.Text = "Create account";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // tbx_create_pwd
            // 
            this.tbx_create_pwd.Location = new System.Drawing.Point(108, 344);
            this.tbx_create_pwd.Name = "tbx_create_pwd";
            this.tbx_create_pwd.Size = new System.Drawing.Size(100, 20);
            this.tbx_create_pwd.TabIndex = 9;
            this.tbx_create_pwd.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password:";
            // 
            // tbx_create_name
            // 
            this.tbx_create_name.Location = new System.Drawing.Point(108, 307);
            this.tbx_create_name.Name = "tbx_create_name";
            this.tbx_create_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_create_name.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name:";
            // 
            // tbx_create_pwd2
            // 
            this.tbx_create_pwd2.Location = new System.Drawing.Point(108, 382);
            this.tbx_create_pwd2.Name = "tbx_create_pwd2";
            this.tbx_create_pwd2.Size = new System.Drawing.Size(100, 20);
            this.tbx_create_pwd2.TabIndex = 13;
            this.tbx_create_pwd2.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(22, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "Confirm password:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_login_signup
            // 
            this.btn_login_signup.Location = new System.Drawing.Point(38, 157);
            this.btn_login_signup.Name = "btn_login_signup";
            this.btn_login_signup.Size = new System.Drawing.Size(100, 23);
            this.btn_login_signup.TabIndex = 14;
            this.btn_login_signup.Text = "Sign up";
            this.btn_login_signup.UseVisualStyleBackColor = true;
            this.btn_login_signup.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_login_guest
            // 
            this.btn_login_guest.Location = new System.Drawing.Point(83, 186);
            this.btn_login_guest.Name = "btn_login_guest";
            this.btn_login_guest.Size = new System.Drawing.Size(116, 23);
            this.btn_login_guest.TabIndex = 15;
            this.btn_login_guest.Text = "Continue as a Guest";
            this.btn_login_guest.UseVisualStyleBackColor = true;
            this.btn_login_guest.Click += new System.EventHandler(this.btn_login_guest_Click);
            // 
            // LoginWindow
            // 
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.btn_login_guest);
            this.Controls.Add(this.btn_login_signup);
            this.Controls.Add(this.tbx_create_pwd2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tbx_create_pwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_create_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_login_signin);
            this.Controls.Add(this.tbx_login_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_login_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_login_name;
        private System.Windows.Forms.TextBox tbx_login_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login_signin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox tbx_create_pwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_create_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_create_pwd2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_login_signup;
        private System.Windows.Forms.Button btn_login_guest;
    }
}