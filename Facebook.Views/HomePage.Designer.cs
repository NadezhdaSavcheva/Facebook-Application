
namespace Facebook.Views
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.facebookHomePageLogo = new System.Windows.Forms.PictureBox();
            this.searchBoxHomePage = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.profileIconImage = new System.Windows.Forms.PictureBox();
            this.groupsIconImage = new System.Windows.Forms.PictureBox();
            this.eventsIconImage = new System.Windows.Forms.PictureBox();
            this.friendsIconImage = new System.Windows.Forms.PictureBox();
            this.profileButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.eventsButton = new System.Windows.Forms.Button();
            this.friendsButton = new System.Windows.Forms.Button();
            this.postsListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.facebookHomePageLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileIconImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsIconImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsIconImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsIconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // facebookHomePageLogo
            // 
            this.facebookHomePageLogo.Image = ((System.Drawing.Image)(resources.GetObject("facebookHomePageLogo.Image")));
            this.facebookHomePageLogo.Location = new System.Drawing.Point(12, 24);
            this.facebookHomePageLogo.Name = "facebookHomePageLogo";
            this.facebookHomePageLogo.Size = new System.Drawing.Size(40, 40);
            this.facebookHomePageLogo.TabIndex = 0;
            this.facebookHomePageLogo.TabStop = false;
            // 
            // searchBoxHomePage
            // 
            this.searchBoxHomePage.Location = new System.Drawing.Point(58, 37);
            this.searchBoxHomePage.Name = "searchBoxHomePage";
            this.searchBoxHomePage.PlaceholderText = "Search in Facebook";
            this.searchBoxHomePage.Size = new System.Drawing.Size(148, 27);
            this.searchBoxHomePage.TabIndex = 1;
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.findButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findButton.ForeColor = System.Drawing.Color.White;
            this.findButton.Location = new System.Drawing.Point(206, 37);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(64, 27);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = false;
            // 
            // profileIconImage
            // 
            this.profileIconImage.Image = ((System.Drawing.Image)(resources.GetObject("profileIconImage.Image")));
            this.profileIconImage.Location = new System.Drawing.Point(394, 12);
            this.profileIconImage.Name = "profileIconImage";
            this.profileIconImage.Size = new System.Drawing.Size(40, 40);
            this.profileIconImage.TabIndex = 3;
            this.profileIconImage.TabStop = false;
            // 
            // groupsIconImage
            // 
            this.groupsIconImage.Image = ((System.Drawing.Image)(resources.GetObject("groupsIconImage.Image")));
            this.groupsIconImage.Location = new System.Drawing.Point(503, 12);
            this.groupsIconImage.Name = "groupsIconImage";
            this.groupsIconImage.Size = new System.Drawing.Size(40, 40);
            this.groupsIconImage.TabIndex = 4;
            this.groupsIconImage.TabStop = false;
            // 
            // eventsIconImage
            // 
            this.eventsIconImage.Image = ((System.Drawing.Image)(resources.GetObject("eventsIconImage.Image")));
            this.eventsIconImage.Location = new System.Drawing.Point(607, 12);
            this.eventsIconImage.Name = "eventsIconImage";
            this.eventsIconImage.Size = new System.Drawing.Size(40, 40);
            this.eventsIconImage.TabIndex = 5;
            this.eventsIconImage.TabStop = false;
            // 
            // friendsIconImage
            // 
            this.friendsIconImage.Image = ((System.Drawing.Image)(resources.GetObject("friendsIconImage.Image")));
            this.friendsIconImage.Location = new System.Drawing.Point(718, 12);
            this.friendsIconImage.Name = "friendsIconImage";
            this.friendsIconImage.Size = new System.Drawing.Size(40, 40);
            this.friendsIconImage.TabIndex = 6;
            this.friendsIconImage.TabStop = false;
            this.friendsIconImage.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.profileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.Location = new System.Drawing.Point(381, 58);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(65, 25);
            this.profileButton.TabIndex = 7;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupsButton
            // 
            this.groupsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupsButton.ForeColor = System.Drawing.Color.White;
            this.groupsButton.Location = new System.Drawing.Point(491, 58);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(65, 25);
            this.groupsButton.TabIndex = 8;
            this.groupsButton.Text = "Groups";
            this.groupsButton.UseVisualStyleBackColor = false;
            this.groupsButton.Click += new System.EventHandler(this.groupsButton_Click);
            // 
            // eventsButton
            // 
            this.eventsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.eventsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventsButton.ForeColor = System.Drawing.Color.White;
            this.eventsButton.Location = new System.Drawing.Point(595, 58);
            this.eventsButton.Name = "eventsButton";
            this.eventsButton.Size = new System.Drawing.Size(65, 25);
            this.eventsButton.TabIndex = 9;
            this.eventsButton.Text = "Events";
            this.eventsButton.UseVisualStyleBackColor = false;
            this.eventsButton.Click += new System.EventHandler(this.eventsButton_Click);
            // 
            // friendsButton
            // 
            this.friendsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.friendsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.friendsButton.ForeColor = System.Drawing.Color.White;
            this.friendsButton.Location = new System.Drawing.Point(706, 58);
            this.friendsButton.Name = "friendsButton";
            this.friendsButton.Size = new System.Drawing.Size(65, 25);
            this.friendsButton.TabIndex = 10;
            this.friendsButton.Text = "Friends";
            this.friendsButton.UseVisualStyleBackColor = false;
            this.friendsButton.Click += new System.EventHandler(this.friendsButton_Click);
            // 
            // postsListView
            // 
            this.postsListView.HideSelection = false;
            this.postsListView.Location = new System.Drawing.Point(24, 101);
            this.postsListView.Name = "postsListView";
            this.postsListView.Size = new System.Drawing.Size(746, 403);
            this.postsListView.TabIndex = 11;
            this.postsListView.UseCompatibleStateImageBehavior = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.postsListView);
            this.Controls.Add(this.friendsButton);
            this.Controls.Add(this.eventsButton);
            this.Controls.Add(this.groupsButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.friendsIconImage);
            this.Controls.Add(this.eventsIconImage);
            this.Controls.Add(this.groupsIconImage);
            this.Controls.Add(this.profileIconImage);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.searchBoxHomePage);
            this.Controls.Add(this.facebookHomePageLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 563);
            this.MinimumSize = new System.Drawing.Size(818, 563);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.facebookHomePageLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileIconImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsIconImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsIconImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsIconImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox facebookHomePageLogo;
        private System.Windows.Forms.TextBox searchBoxHomePage;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.PictureBox profileIconImage;
        private System.Windows.Forms.PictureBox groupsIconImage;
        private System.Windows.Forms.PictureBox eventsIconImage;
        private System.Windows.Forms.PictureBox friendsIconImage;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.Button eventsButton;
        private System.Windows.Forms.Button friendsButton;
        private System.Windows.Forms.ListView postsListView;
    }
}