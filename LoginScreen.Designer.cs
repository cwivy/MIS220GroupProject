namespace MIS220GroupProject
{
    partial class LoginScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.loginUserBox = new System.Windows.Forms.TextBox();
            this.loginPassBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createAccount_BTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.login_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // loginUserBox
            // 

            this.loginUserBox.Location = new System.Drawing.Point(155, 95);
            this.loginUserBox.Name = "loginUserBox";
            this.loginUserBox.Size = new System.Drawing.Size(100, 20);
            this.loginUserBox.TabIndex = 1;

            this.loginUser_TXT.Location = new System.Drawing.Point(207, 117);
            this.loginUser_TXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginUser_TXT.Name = "loginUser_TXT";
            this.loginUser_TXT.Size = new System.Drawing.Size(132, 22);
            this.loginUser_TXT.TabIndex = 1;
            // 
            // loginPassBox
            // 

            this.loginPassBox.Location = new System.Drawing.Point(155, 121);
            this.loginPassBox.Name = "loginPassBox";
            this.loginPassBox.Size = new System.Drawing.Size(100, 20);
            this.loginPassBox.TabIndex = 2;

            this.loginPass_TXT.Location = new System.Drawing.Point(207, 149);
            this.loginPass_TXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginPass_TXT.Name = "loginPass_TXT";
            this.loginPass_TXT.Size = new System.Drawing.Size(132, 22);
            this.loginPass_TXT.TabIndex = 2;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Don\'t have an account? -->";
            // 
            // createAccount_BTN
            // 
            this.createAccount_BTN.Location = new System.Drawing.Point(367, 292);
            this.createAccount_BTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createAccount_BTN.Name = "createAccount_BTN";
            this.createAccount_BTN.Size = new System.Drawing.Size(144, 28);
            this.createAccount_BTN.TabIndex = 4;
            this.createAccount_BTN.Text = "Create Account";
            this.createAccount_BTN.UseVisualStyleBackColor = true;
            this.createAccount_BTN.Click += new System.EventHandler(this.createAccount_BTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Welcome to DVD Express!";
            // 
            // login_BTN
            // 
            this.login_BTN.Location = new System.Drawing.Point(240, 181);
            this.login_BTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_BTN.Name = "login_BTN";
            this.login_BTN.Size = new System.Drawing.Size(100, 28);
            this.login_BTN.TabIndex = 3;
            this.login_BTN.Text = "Login";
            this.login_BTN.UseVisualStyleBackColor = true;
            this.login_BTN.Click += new System.EventHandler(this.login_BTN_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 338);
            this.Controls.Add(this.login_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createAccount_BTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginPassBox);
            this.Controls.Add(this.loginUserBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginUserBox;
        private System.Windows.Forms.TextBox loginPassBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createAccount_BTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button login_BTN;
    }
}