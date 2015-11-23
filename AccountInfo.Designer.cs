namespace MIS220GroupProject
{
    partial class AccountInfo
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
            this.cardNum_TXT = new System.Windows.Forms.TextBox();
            this.memStatus_TXT = new System.Windows.Forms.TextBox();
            this.paymentType_TXT = new System.Windows.Forms.TextBox();
            this.carNum_LBL = new System.Windows.Forms.Label();
            this.memStatus_LBL = new System.Windows.Forms.Label();
            this.paymentType_LBL = new System.Windows.Forms.Label();
            this.activeOrders_BTN = new System.Windows.Forms.Button();
            this.save_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName_TXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName_TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.address1_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adress2_TXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.city_TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.state_TXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.zip_TXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phone_TXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateJoined_TXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.birthDate_TXT = new System.Windows.Forms.TextBox();
            this.billingHistory_BTN = new System.Windows.Forms.Button();
            this.goTo_MENU = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goTo_DropBox = new System.Windows.Forms.ComboBox();
            this.goTo_MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardNum_TXT
            // 
            this.cardNum_TXT.Location = new System.Drawing.Point(626, 69);
            this.cardNum_TXT.Name = "cardNum_TXT";
            this.cardNum_TXT.Size = new System.Drawing.Size(225, 22);
            this.cardNum_TXT.TabIndex = 0;
            this.cardNum_TXT.TextChanged += new System.EventHandler(this.cardNum_TXT_TextChanged);
            // 
            // memStatus_TXT
            // 
            this.memStatus_TXT.Location = new System.Drawing.Point(626, 97);
            this.memStatus_TXT.Name = "memStatus_TXT";
            this.memStatus_TXT.ReadOnly = true;
            this.memStatus_TXT.Size = new System.Drawing.Size(225, 22);
            this.memStatus_TXT.TabIndex = 2;
            // 
            // paymentType_TXT
            // 
            this.paymentType_TXT.Location = new System.Drawing.Point(626, 125);
            this.paymentType_TXT.Name = "paymentType_TXT";
            this.paymentType_TXT.Size = new System.Drawing.Size(225, 22);
            this.paymentType_TXT.TabIndex = 3;
            // 
            // carNum_LBL
            // 
            this.carNum_LBL.AutoSize = true;
            this.carNum_LBL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNum_LBL.Location = new System.Drawing.Point(473, 73);
            this.carNum_LBL.Name = "carNum_LBL";
            this.carNum_LBL.Size = new System.Drawing.Size(100, 17);
            this.carNum_LBL.TabIndex = 4;
            this.carNum_LBL.Text = "Card Number:";
            // 
            // memStatus_LBL
            // 
            this.memStatus_LBL.AutoSize = true;
            this.memStatus_LBL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memStatus_LBL.Location = new System.Drawing.Point(473, 97);
            this.memStatus_LBL.Name = "memStatus_LBL";
            this.memStatus_LBL.Size = new System.Drawing.Size(138, 17);
            this.memStatus_LBL.TabIndex = 6;
            this.memStatus_LBL.Text = "Membership Status:";
            // 
            // paymentType_LBL
            // 
            this.paymentType_LBL.AutoSize = true;
            this.paymentType_LBL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentType_LBL.Location = new System.Drawing.Point(473, 124);
            this.paymentType_LBL.Name = "paymentType_LBL";
            this.paymentType_LBL.Size = new System.Drawing.Size(105, 17);
            this.paymentType_LBL.TabIndex = 7;
            this.paymentType_LBL.Text = "Payment Type:";
            // 
            // activeOrders_BTN
            // 
            this.activeOrders_BTN.Location = new System.Drawing.Point(169, 343);
            this.activeOrders_BTN.Name = "activeOrders_BTN";
            this.activeOrders_BTN.Size = new System.Drawing.Size(164, 76);
            this.activeOrders_BTN.TabIndex = 8;
            this.activeOrders_BTN.Text = "Active Orders";
            this.activeOrders_BTN.UseVisualStyleBackColor = true;
            // 
            // save_BTN
            // 
            this.save_BTN.Location = new System.Drawing.Point(541, 343);
            this.save_BTN.Name = "save_BTN";
            this.save_BTN.Size = new System.Drawing.Size(164, 76);
            this.save_BTN.TabIndex = 10;
            this.save_BTN.Text = "Save";
            this.save_BTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name:";
            // 
            // firstName_TXT
            // 
            this.firstName_TXT.Location = new System.Drawing.Point(182, 42);
            this.firstName_TXT.Name = "firstName_TXT";
            this.firstName_TXT.Size = new System.Drawing.Size(225, 22);
            this.firstName_TXT.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last Name:";
            // 
            // lastName_TXT
            // 
            this.lastName_TXT.Location = new System.Drawing.Point(182, 70);
            this.lastName_TXT.Name = "lastName_TXT";
            this.lastName_TXT.Size = new System.Drawing.Size(225, 22);
            this.lastName_TXT.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Address 1:";
            // 
            // address1_TXT
            // 
            this.address1_TXT.Location = new System.Drawing.Point(182, 98);
            this.address1_TXT.Name = "address1_TXT";
            this.address1_TXT.Size = new System.Drawing.Size(225, 22);
            this.address1_TXT.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Address 2:";
            // 
            // adress2_TXT
            // 
            this.adress2_TXT.Location = new System.Drawing.Point(182, 126);
            this.adress2_TXT.Name = "adress2_TXT";
            this.adress2_TXT.Size = new System.Drawing.Size(225, 22);
            this.adress2_TXT.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "City:";
            // 
            // city_TXT
            // 
            this.city_TXT.Location = new System.Drawing.Point(182, 154);
            this.city_TXT.Name = "city_TXT";
            this.city_TXT.Size = new System.Drawing.Size(225, 22);
            this.city_TXT.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "State:";
            // 
            // state_TXT
            // 
            this.state_TXT.Location = new System.Drawing.Point(182, 182);
            this.state_TXT.Name = "state_TXT";
            this.state_TXT.Size = new System.Drawing.Size(225, 22);
            this.state_TXT.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Zipcode:";
            // 
            // zip_TXT
            // 
            this.zip_TXT.Location = new System.Drawing.Point(182, 210);
            this.zip_TXT.Name = "zip_TXT";
            this.zip_TXT.Size = new System.Drawing.Size(225, 22);
            this.zip_TXT.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Phone:";
            // 
            // phone_TXT
            // 
            this.phone_TXT.Location = new System.Drawing.Point(182, 238);
            this.phone_TXT.Name = "phone_TXT";
            this.phone_TXT.Size = new System.Drawing.Size(225, 22);
            this.phone_TXT.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(473, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Date Joined:";
            // 
            // dateJoined_TXT
            // 
            this.dateJoined_TXT.Location = new System.Drawing.Point(626, 153);
            this.dateJoined_TXT.Name = "dateJoined_TXT";
            this.dateJoined_TXT.ReadOnly = true;
            this.dateJoined_TXT.Size = new System.Drawing.Size(225, 22);
            this.dateJoined_TXT.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(473, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Birth Date:";
            // 
            // birthDate_TXT
            // 
            this.birthDate_TXT.Location = new System.Drawing.Point(626, 181);
            this.birthDate_TXT.Name = "birthDate_TXT";
            this.birthDate_TXT.Size = new System.Drawing.Size(225, 22);
            this.birthDate_TXT.TabIndex = 29;
            // 
            // billingHistory_BTN
            // 
            this.billingHistory_BTN.Location = new System.Drawing.Point(354, 343);
            this.billingHistory_BTN.Name = "billingHistory_BTN";
            this.billingHistory_BTN.Size = new System.Drawing.Size(164, 76);
            this.billingHistory_BTN.TabIndex = 31;
            this.billingHistory_BTN.Text = "Billing History";
            this.billingHistory_BTN.UseVisualStyleBackColor = true;
            // 
            // goTo_MENU
            // 
            this.goTo_MENU.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.goTo_MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.goTo_MENU.Name = "goTo_MENU";
            this.goTo_MENU.Size = new System.Drawing.Size(126, 30);
            this.goTo_MENU.Text = "Go To:";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // goTo_DropBox
            // 
            this.goTo_DropBox.FormattingEnabled = true;
            this.goTo_DropBox.Items.AddRange(new object[] {
            "Home",
            "Wish List",
            "Movie List",
            "Log Out"});
            this.goTo_DropBox.Location = new System.Drawing.Point(710, 13);
            this.goTo_DropBox.Name = "goTo_DropBox";
            this.goTo_DropBox.Size = new System.Drawing.Size(167, 24);
            this.goTo_DropBox.TabIndex = 33;
            this.goTo_DropBox.Text = "Go To:";
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 493);
            this.Controls.Add(this.goTo_DropBox);
            this.Controls.Add(this.billingHistory_BTN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.birthDate_TXT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateJoined_TXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phone_TXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zip_TXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.state_TXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.city_TXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adress2_TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address1_TXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstName_TXT);
            this.Controls.Add(this.save_BTN);
            this.Controls.Add(this.activeOrders_BTN);
            this.Controls.Add(this.paymentType_LBL);
            this.Controls.Add(this.memStatus_LBL);
            this.Controls.Add(this.carNum_LBL);
            this.Controls.Add(this.paymentType_TXT);
            this.Controls.Add(this.memStatus_TXT);
            this.Controls.Add(this.cardNum_TXT);
            this.Name = "AccountInfo";
            this.Text = "AccountInfo";
            this.goTo_MENU.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardNum_TXT;
        private System.Windows.Forms.TextBox memStatus_TXT;
        private System.Windows.Forms.TextBox paymentType_TXT;
        private System.Windows.Forms.Label carNum_LBL;
        private System.Windows.Forms.Label memStatus_LBL;
        private System.Windows.Forms.Label paymentType_LBL;
        private System.Windows.Forms.Button activeOrders_BTN;
        private System.Windows.Forms.Button save_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName_TXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName_TXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address1_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adress2_TXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox city_TXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox state_TXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox zip_TXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone_TXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dateJoined_TXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox birthDate_TXT;
        private System.Windows.Forms.Button billingHistory_BTN;
        private System.Windows.Forms.ContextMenuStrip goTo_MENU;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ComboBox goTo_DropBox;
    }
}