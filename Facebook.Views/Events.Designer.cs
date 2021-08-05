
namespace Facebook.Views
{
    partial class Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            this.eventsListView = new System.Windows.Forms.ListView();
            this.friendsButton = new System.Windows.Forms.Button();
            this.friendsIconImage = new System.Windows.Forms.PictureBox();
            this.profileButton = new System.Windows.Forms.Button();
            this.profileIconImage = new System.Windows.Forms.PictureBox();
            this.homePageButton = new System.Windows.Forms.Button();
            this.homePageIconImage = new System.Windows.Forms.PictureBox();
            this.findButton = new System.Windows.Forms.Button();
            this.searchBoxHomePage = new System.Windows.Forms.TextBox();
            this.facebookHomePageLogo = new System.Windows.Forms.PictureBox();
            this.groupsIconImage = new System.Windows.Forms.PictureBox();
            this.groupsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.friendsIconImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileIconImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePageIconImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookHomePageLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsIconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsListView
            // 
            this.eventsListView.HideSelection = false;
            this.eventsListView.Location = new System.Drawing.Point(38, 111);
            this.eventsListView.Name = "eventsListView";
            this.eventsListView.Size = new System.Drawing.Size(719, 388);
            this.eventsListView.TabIndex = 35;
            this.eventsListView.UseCompatibleStateImageBehavior = false;
            // 
            // friendsButton
            // 
            this.friendsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.friendsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.friendsButton.ForeColor = System.Drawing.Color.White;
            this.friendsButton.Location = new System.Drawing.Point(705, 65);
            this.friendsButton.Name = "friendsButton";
            this.friendsButton.Size = new System.Drawing.Size(65, 25);
            this.friendsButton.TabIndex = 34;
            this.friendsButton.Text = "Friends";
            this.friendsButton.UseVisualStyleBackColor = false;
            this.friendsButton.Click += new System.EventHandler(this.friendsButton_Click);
            // 
            // friendsIconImage
            // 
            this.friendsIconImage.Image = ((System.Drawing.Image)(resources.GetObject("friendsIconImage.Image")));
            this.friendsIconImage.Location = new System.Drawing.Point(717, 20);
            this.friendsIconImage.Name = "friendsIconImage";
            this.friendsIconImage.Size = new System.Drawing.Size(40, 40);
            this.friendsIconImage.TabIndex = 33;
            this.friendsIconImage.TabStop = false;
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.profileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.Location = new System.Drawing.Point(499, 65);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(65, 25);
            this.profileButton.TabIndex = 30;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // profileIconImage
            // 
            this.profileIconImage.Image = ((System.Drawing.Image)(resources.GetObject("profileIconImage.Image")));
            this.profileIconImage.Location = new System.Drawing.Point(511, 20);
            this.profileIconImage.Name = "profileIconImage";
            this.profileIconImage.Size = new System.Drawing.Size(40, 40);
            this.profileIconImage.TabIndex = 29;
            this.profileIconImage.TabStop = false;
            this.profileIconImage.Click += new System.EventHandler(this.profileIconImage_Click);
            // 
            // homePageButton
            // 
            this.homePageButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.homePageButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.000003F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homePageButton.ForeColor = System.Drawing.Color.White;
            this.homePageButton.Location = new System.Drawing.Point(388, 66);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Size = new System.Drawing.Size(89, 25);
            this.homePageButton.TabIndex = 28;
            this.homePageButton.Text = "Home Page";
            this.homePageButton.UseVisualStyleBackColor = false;
            this.homePageButton.Click += new System.EventHandler(this.homePageButton_Click);
            // 
            // homePageIconImage
            // 
            this.homePageIconImage.Image = ((System.Drawing.Image)(resources.GetObject("homePageIconImage.Image")));
            this.homePageIconImage.Location = new System.Drawing.Point(412, 20);
            this.homePageIconImage.Name = "homePageIconImage";
            this.homePageIconImage.Size = new System.Drawing.Size(40, 40);
            this.homePageIconImage.TabIndex = 27;
            this.homePageIconImage.TabStop = false;
            this.homePageIconImage.Click += new System.EventHandler(this.homePageIconImage_Click);
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.findButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findButton.ForeColor = System.Drawing.Color.White;
            this.findButton.Location = new System.Drawing.Point(216, 40);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(64, 27);
            this.findButton.TabIndex = 26;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = false;
            // 
            // searchBoxHomePage
            // 
            this.searchBoxHomePage.Location = new System.Drawing.Point(68, 40);
            this.searchBoxHomePage.Name = "searchBoxHomePage";
            this.searchBoxHomePage.PlaceholderText = "Search in Facebook";
            this.searchBoxHomePage.Size = new System.Drawing.Size(148, 27);
            this.searchBoxHomePage.TabIndex = 25;
            // 
            // facebookHomePageLogo
            // 
            this.facebookHomePageLogo.Image = ((System.Drawing.Image)(resources.GetObject("facebookHomePageLogo.Image")));
            this.facebookHomePageLogo.Location = new System.Drawing.Point(22, 27);
            this.facebookHomePageLogo.Name = "facebookHomePageLogo";
            this.facebookHomePageLogo.Size = new System.Drawing.Size(40, 40);
            this.facebookHomePageLogo.TabIndex = 24;
            this.facebookHomePageLogo.TabStop = false;
            // 
            // groupsIconImage
            // 
            this.groupsIconImage.Image = ((System.Drawing.Image)(resources.GetObject("groupsIconImage.Image")));
            this.groupsIconImage.Location = new System.Drawing.Point(614, 20);
            this.groupsIconImage.Name = "groupsIconImage";
            this.groupsIconImage.Size = new System.Drawing.Size(40, 40);
            this.groupsIconImage.TabIndex = 36;
            this.groupsIconImage.TabStop = false;
            // 
            // groupsButton
            // 
            this.groupsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupsButton.ForeColor = System.Drawing.Color.White;
            this.groupsButton.Location = new System.Drawing.Point(601, 65);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(65, 25);
            this.groupsButton.TabIndex = 37;
            this.groupsButton.Text = "Groups";
            this.groupsButton.UseVisualStyleBackColor = false;
            this.groupsButton.Click += new System.EventHandler(this.groupsButton_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.groupsButton);
            this.Controls.Add(this.groupsIconImage);
            this.Controls.Add(this.eventsListView);
            this.Controls.Add(this.friendsButton);
            this.Controls.Add(this.friendsIconImage);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.profileIconImage);
            this.Controls.Add(this.homePageButton);
            this.Controls.Add(this.homePageIconImage);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.searchBoxHomePage);
            this.Controls.Add(this.facebookHomePageLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 558);
            this.MinimumSize = new System.Drawing.Size(818, 558);
            this.Name = "Events";
            this.Text = "Events";
            ((System.ComponentModel.ISupportInitialize)(this.friendsIconImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileIconImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePageIconImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookHomePageLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsIconImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView eventsListView;
        private System.Windows.Forms.Button friendsButton;
        private System.Windows.Forms.PictureBox friendsIconImage;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.PictureBox profileIconImage;
        private System.Windows.Forms.Button homePageButton;
        private System.Windows.Forms.PictureBox homePageIconImage;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox searchBoxHomePage;
        private System.Windows.Forms.PictureBox facebookHomePageLogo;
        private System.Windows.Forms.PictureBox groupsIconImage;
        private System.Windows.Forms.Button groupsButton;
    }
}