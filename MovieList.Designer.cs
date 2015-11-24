namespace MIS220GroupProject
{
    partial class MovieList
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
            this.movieList_LIST = new System.Windows.Forms.ListBox();
            this.goTo_DropBox = new System.Windows.Forms.ComboBox();
            this.wishList_BTN = new System.Windows.Forms.Button();
            this.purchaseMovie_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movieList_LIST
            // 
            this.movieList_LIST.FormattingEnabled = true;
            this.movieList_LIST.ItemHeight = 16;
            this.movieList_LIST.Location = new System.Drawing.Point(52, 56);
            this.movieList_LIST.Name = "movieList_LIST";
            this.movieList_LIST.ScrollAlwaysVisible = true;
            this.movieList_LIST.Size = new System.Drawing.Size(664, 212);
            this.movieList_LIST.TabIndex = 0;
            // 
            // goTo_DropBox
            // 
            this.goTo_DropBox.FormattingEnabled = true;
            this.goTo_DropBox.Items.AddRange(new object[] {
            "Home",
            "Wish List",
            "Account Information",
            "Log Out"});
            this.goTo_DropBox.Location = new System.Drawing.Point(530, 0);
            this.goTo_DropBox.Name = "goTo_DropBox";
            this.goTo_DropBox.Size = new System.Drawing.Size(261, 24);
            this.goTo_DropBox.TabIndex = 34;
            this.goTo_DropBox.Text = "Go To:";
            // 
            // wishList_BTN
            // 
            this.wishList_BTN.Location = new System.Drawing.Point(173, 360);
            this.wishList_BTN.Name = "wishList_BTN";
            this.wishList_BTN.Size = new System.Drawing.Size(141, 79);
            this.wishList_BTN.TabIndex = 35;
            this.wishList_BTN.Text = "Add to Wish List";
            this.wishList_BTN.UseVisualStyleBackColor = true;
            this.wishList_BTN.Click += new System.EventHandler(this.wishList_BTN_Click);
            // 
            // purchaseMovie_BTN
            // 
            this.purchaseMovie_BTN.Location = new System.Drawing.Point(431, 360);
            this.purchaseMovie_BTN.Name = "purchaseMovie_BTN";
            this.purchaseMovie_BTN.Size = new System.Drawing.Size(141, 79);
            this.purchaseMovie_BTN.TabIndex = 36;
            this.purchaseMovie_BTN.Text = "Rent or Buy Movie";
            this.purchaseMovie_BTN.UseVisualStyleBackColor = true;
            // 
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 515);
            this.Controls.Add(this.purchaseMovie_BTN);
            this.Controls.Add(this.wishList_BTN);
            this.Controls.Add(this.goTo_DropBox);
            this.Controls.Add(this.movieList_LIST);
            this.Name = "MovieList";
            this.Text = "MovieList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox movieList_LIST;
        private System.Windows.Forms.ComboBox goTo_DropBox;
        private System.Windows.Forms.Button wishList_BTN;
        private System.Windows.Forms.Button purchaseMovie_BTN;
    }
}