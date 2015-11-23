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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.goTo_DropBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // movieList_LIST
            // 
            this.movieList_LIST.FormattingEnabled = true;
            this.movieList_LIST.ItemHeight = 16;
            this.movieList_LIST.Location = new System.Drawing.Point(52, 56);
            this.movieList_LIST.Name = "movieList_LIST";
            this.movieList_LIST.Size = new System.Drawing.Size(393, 196);
            this.movieList_LIST.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(412, 56);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(33, 196);
            this.vScrollBar1.TabIndex = 1;
            // 
            // goTo_DropBox
            // 
            this.goTo_DropBox.FormattingEnabled = true;
            this.goTo_DropBox.Items.AddRange(new object[] {
            "Home",
            "Wish List",
            "Account Information",
            "Log Out"});
            this.goTo_DropBox.Location = new System.Drawing.Point(556, 12);
            this.goTo_DropBox.Name = "goTo_DropBox";
            this.goTo_DropBox.Size = new System.Drawing.Size(167, 24);
            this.goTo_DropBox.TabIndex = 34;
            this.goTo_DropBox.Text = "Go To:";
            // 
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 515);
            this.Controls.Add(this.goTo_DropBox);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.movieList_LIST);
            this.Name = "MovieList";
            this.Text = "MovieList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox movieList_LIST;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ComboBox goTo_DropBox;
    }
}