using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    partial class ProfileFeed
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
            System.Windows.Forms.Label websiteLabel;
            System.Windows.Forms.Label uRLLabel;
            System.Windows.Forms.Label talkingAboutCountLabel;
            System.Windows.Forms.Label pictureURLLabel1;
            System.Windows.Forms.Label pictureSqaureURLLabel1;
            System.Windows.Forms.Label pictureSmallURLLabel2;
            System.Windows.Forms.Label pictureNormalURLLabel1;
            System.Windows.Forms.Label pictureLargeURLLabel1;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label nameLabel4;
            System.Windows.Forms.Label loggedInUserCanPostLabel;
            System.Windows.Forms.Label likesCountLabel;
            System.Windows.Forms.Label isPublishedLabel;
            System.Windows.Forms.Label isCommunityPageLabel;
            System.Windows.Forms.Label websiteLabel1;
            System.Windows.Forms.Label uRLLabel1;
            System.Windows.Forms.Label talkingAboutCountLabel1;
            System.Windows.Forms.Label pictureURLLabel2;
            System.Windows.Forms.Label pictureSqaureURLLabel3;
            System.Windows.Forms.Label pictureSmallURLLabel3;
            System.Windows.Forms.Label pictureNormalURLLabel3;
            System.Windows.Forms.Label pictureLargeURLLabel3;
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label loggedInUserCanPostLabel1;
            System.Windows.Forms.Label likesCountLabel1;
            System.Windows.Forms.Label isPublishedLabel1;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label localeLabel;
            System.Windows.Forms.Label nameLabel3;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label idLabel2;
            System.Windows.Forms.Label nameLabel7;
            System.Windows.Forms.Label updateTimeLabel1;
            System.Windows.Forms.Label captionLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label pictureURLLabel;
            System.Windows.Forms.Label updateTimeLabel;
            System.Windows.Forms.Label createdTimeLabel2;
            System.Windows.Forms.Label messageLabel2;
            System.Windows.Forms.Label pageNameLabel;
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.buttonFetchAbout = new System.Windows.Forms.Button();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.buttonFetchPages = new System.Windows.Forms.Button();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.buttonFetchSaved = new System.Windows.Forms.Button();
            this.mainListBox = new System.Windows.Forms.ListBox();
            this.pagePanel = new System.Windows.Forms.Panel();
            this.nameLabel6 = new System.Windows.Forms.Label();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureSmallURLPictureBox = new System.Windows.Forms.PictureBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.uRLTextBox = new System.Windows.Forms.TextBox();
            this.talkingAboutCountTextBox = new System.Windows.Forms.TextBox();
            this.pictureURLTextBox1 = new System.Windows.Forms.TextBox();
            this.pictureSqaureURLTextBox1 = new System.Windows.Forms.TextBox();
            this.pictureSmallURLTextBox1 = new System.Windows.Forms.TextBox();
            this.pictureNormalURLTextBox1 = new System.Windows.Forms.TextBox();
            this.pictureLargeURLTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.loggedInUserCanPostCheckBox = new System.Windows.Forms.CheckBox();
            this.likesCountTextBox = new System.Windows.Forms.TextBox();
            this.isPublishedCheckBox = new System.Windows.Forms.CheckBox();
            this.websiteTextBox1 = new System.Windows.Forms.TextBox();
            this.uRLTextBox1 = new System.Windows.Forms.TextBox();
            this.talkingAboutCountTextBox1 = new System.Windows.Forms.TextBox();
            this.pictureURLTextBox2 = new System.Windows.Forms.TextBox();
            this.pictureSqaureURLTextBox3 = new System.Windows.Forms.TextBox();
            this.pictureSmallURLTextBox3 = new System.Windows.Forms.TextBox();
            this.pictureNormalURLTextBox3 = new System.Windows.Forms.TextBox();
            this.pictureLargeURLTextBox3 = new System.Windows.Forms.TextBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox4 = new System.Windows.Forms.TextBox();
            this.loggedInUserCanPostCheckBox1 = new System.Windows.Forms.CheckBox();
            this.likesCountTextBox1 = new System.Windows.Forms.TextBox();
            this.isPublishedCheckBox1 = new System.Windows.Forms.CheckBox();
            this.postPanel = new System.Windows.Forms.Panel();
            this.createdTimeDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.friendPanel = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.localeTextBox1 = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox3 = new System.Windows.Forms.TextBox();
            this.groupPanel = new System.Windows.Forms.Panel();
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox2 = new System.Windows.Forms.TextBox();
            this.nameTextBox5 = new System.Windows.Forms.TextBox();
            this.updateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.captionTextBox = new System.Windows.Forms.TextBox();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.updateTimeTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelSavedPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.albumPanel = new System.Windows.Forms.Panel();
            this.stopLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.buttonStopSlide = new System.Windows.Forms.Button();
            this.buttonPlaySlide = new System.Windows.Forms.Button();
            this.albumPictureBox = new System.Windows.Forms.PictureBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.savedPostIcon = new System.Windows.Forms.PictureBox();
            this.pagesIcon = new System.Windows.Forms.PictureBox();
            this.groupsIcon = new System.Windows.Forms.PictureBox();
            this.albumsIcon = new System.Windows.Forms.PictureBox();
            this.friendsIcon = new System.Windows.Forms.PictureBox();
            this.aboutIcon = new System.Windows.Forms.PictureBox();
            this.postsIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureURLPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            websiteLabel = new System.Windows.Forms.Label();
            uRLLabel = new System.Windows.Forms.Label();
            talkingAboutCountLabel = new System.Windows.Forms.Label();
            pictureURLLabel1 = new System.Windows.Forms.Label();
            pictureSqaureURLLabel1 = new System.Windows.Forms.Label();
            pictureSmallURLLabel2 = new System.Windows.Forms.Label();
            pictureNormalURLLabel1 = new System.Windows.Forms.Label();
            pictureLargeURLLabel1 = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            nameLabel4 = new System.Windows.Forms.Label();
            loggedInUserCanPostLabel = new System.Windows.Forms.Label();
            likesCountLabel = new System.Windows.Forms.Label();
            isPublishedLabel = new System.Windows.Forms.Label();
            isCommunityPageLabel = new System.Windows.Forms.Label();
            websiteLabel1 = new System.Windows.Forms.Label();
            uRLLabel1 = new System.Windows.Forms.Label();
            talkingAboutCountLabel1 = new System.Windows.Forms.Label();
            pictureURLLabel2 = new System.Windows.Forms.Label();
            pictureSqaureURLLabel3 = new System.Windows.Forms.Label();
            pictureSmallURLLabel3 = new System.Windows.Forms.Label();
            pictureNormalURLLabel3 = new System.Windows.Forms.Label();
            pictureLargeURLLabel3 = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            loggedInUserCanPostLabel1 = new System.Windows.Forms.Label();
            likesCountLabel1 = new System.Windows.Forms.Label();
            isPublishedLabel1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            localeLabel = new System.Windows.Forms.Label();
            nameLabel3 = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            idLabel2 = new System.Windows.Forms.Label();
            nameLabel7 = new System.Windows.Forms.Label();
            updateTimeLabel1 = new System.Windows.Forms.Label();
            captionLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            pictureURLLabel = new System.Windows.Forms.Label();
            updateTimeLabel = new System.Windows.Forms.Label();
            createdTimeLabel2 = new System.Windows.Forms.Label();
            messageLabel2 = new System.Windows.Forms.Label();
            pageNameLabel = new System.Windows.Forms.Label();
            this.pagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSmallURLPictureBox)).BeginInit();
            this.postPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.friendPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
            this.aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.albumPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savedPostIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(161, 2291);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(71, 20);
            websiteLabel.TabIndex = 118;
            websiteLabel.Text = "Website:";
            // 
            // uRLLabel
            // 
            uRLLabel.AutoSize = true;
            uRLLabel.Location = new System.Drawing.Point(161, 2259);
            uRLLabel.Name = "uRLLabel";
            uRLLabel.Size = new System.Drawing.Size(46, 20);
            uRLLabel.TabIndex = 116;
            uRLLabel.Text = "URL:";
            // 
            // talkingAboutCountLabel
            // 
            talkingAboutCountLabel.AutoSize = true;
            talkingAboutCountLabel.Location = new System.Drawing.Point(161, 2227);
            talkingAboutCountLabel.Name = "talkingAboutCountLabel";
            talkingAboutCountLabel.Size = new System.Drawing.Size(157, 20);
            talkingAboutCountLabel.TabIndex = 114;
            talkingAboutCountLabel.Text = "Talking About Count:";
            // 
            // pictureURLLabel1
            // 
            pictureURLLabel1.AutoSize = true;
            pictureURLLabel1.Location = new System.Drawing.Point(161, 2195);
            pictureURLLabel1.Name = "pictureURLLabel1";
            pictureURLLabel1.Size = new System.Drawing.Size(99, 20);
            pictureURLLabel1.TabIndex = 112;
            pictureURLLabel1.Text = "Picture URL:";
            // 
            // pictureSqaureURLLabel1
            // 
            pictureSqaureURLLabel1.AutoSize = true;
            pictureSqaureURLLabel1.Location = new System.Drawing.Point(161, 2163);
            pictureSqaureURLLabel1.Name = "pictureSqaureURLLabel1";
            pictureSqaureURLLabel1.Size = new System.Drawing.Size(155, 20);
            pictureSqaureURLLabel1.TabIndex = 110;
            pictureSqaureURLLabel1.Text = "Picture Sqaure URL:";
            // 
            // pictureSmallURLLabel2
            // 
            pictureSmallURLLabel2.AutoSize = true;
            pictureSmallURLLabel2.Location = new System.Drawing.Point(161, 2131);
            pictureSmallURLLabel2.Name = "pictureSmallURLLabel2";
            pictureSmallURLLabel2.Size = new System.Drawing.Size(142, 20);
            pictureSmallURLLabel2.TabIndex = 108;
            pictureSmallURLLabel2.Text = "Picture Small URL:";
            // 
            // pictureNormalURLLabel1
            // 
            pictureNormalURLLabel1.AutoSize = true;
            pictureNormalURLLabel1.Location = new System.Drawing.Point(161, 2099);
            pictureNormalURLLabel1.Name = "pictureNormalURLLabel1";
            pictureNormalURLLabel1.Size = new System.Drawing.Size(153, 20);
            pictureNormalURLLabel1.TabIndex = 106;
            pictureNormalURLLabel1.Text = "Picture Normal URL:";
            // 
            // pictureLargeURLLabel1
            // 
            pictureLargeURLLabel1.AutoSize = true;
            pictureLargeURLLabel1.Location = new System.Drawing.Point(161, 2067);
            pictureLargeURLLabel1.Name = "pictureLargeURLLabel1";
            pictureLargeURLLabel1.Size = new System.Drawing.Size(144, 20);
            pictureLargeURLLabel1.TabIndex = 104;
            pictureLargeURLLabel1.Text = "Picture Large URL:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(161, 2035);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(59, 20);
            phoneLabel.TabIndex = 102;
            phoneLabel.Text = "Phone:";
            // 
            // nameLabel4
            // 
            nameLabel4.AutoSize = true;
            nameLabel4.Location = new System.Drawing.Point(161, 2003);
            nameLabel4.Name = "nameLabel4";
            nameLabel4.Size = new System.Drawing.Size(55, 20);
            nameLabel4.TabIndex = 100;
            nameLabel4.Text = "Name:";
            // 
            // loggedInUserCanPostLabel
            // 
            loggedInUserCanPostLabel.AutoSize = true;
            loggedInUserCanPostLabel.Location = new System.Drawing.Point(161, 1974);
            loggedInUserCanPostLabel.Name = "loggedInUserCanPostLabel";
            loggedInUserCanPostLabel.Size = new System.Drawing.Size(192, 20);
            loggedInUserCanPostLabel.TabIndex = 98;
            loggedInUserCanPostLabel.Text = "Logged In User Can Post:";
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Location = new System.Drawing.Point(161, 1940);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(97, 20);
            likesCountLabel.TabIndex = 96;
            likesCountLabel.Text = "Likes Count:";
            // 
            // isPublishedLabel
            // 
            isPublishedLabel.AutoSize = true;
            isPublishedLabel.Location = new System.Drawing.Point(161, 1911);
            isPublishedLabel.Name = "isPublishedLabel";
            isPublishedLabel.Size = new System.Drawing.Size(99, 20);
            isPublishedLabel.TabIndex = 94;
            isPublishedLabel.Text = "Is Published:";
            // 
            // isCommunityPageLabel
            // 
            isCommunityPageLabel.AutoSize = true;
            isCommunityPageLabel.Location = new System.Drawing.Point(161, 1880);
            isCommunityPageLabel.Name = "isCommunityPageLabel";
            isCommunityPageLabel.Size = new System.Drawing.Size(150, 20);
            isCommunityPageLabel.TabIndex = 92;
            isCommunityPageLabel.Text = "Is Community Page:";
            // 
            // websiteLabel1
            // 
            websiteLabel1.AutoSize = true;
            websiteLabel1.Location = new System.Drawing.Point(246, 2281);
            websiteLabel1.Name = "websiteLabel1";
            websiteLabel1.Size = new System.Drawing.Size(71, 20);
            websiteLabel1.TabIndex = 231;
            websiteLabel1.Text = "Website:";
            // 
            // uRLLabel1
            // 
            uRLLabel1.AutoSize = true;
            uRLLabel1.Location = new System.Drawing.Point(246, 2249);
            uRLLabel1.Name = "uRLLabel1";
            uRLLabel1.Size = new System.Drawing.Size(46, 20);
            uRLLabel1.TabIndex = 229;
            uRLLabel1.Text = "URL:";
            // 
            // talkingAboutCountLabel1
            // 
            talkingAboutCountLabel1.AutoSize = true;
            talkingAboutCountLabel1.Location = new System.Drawing.Point(246, 2217);
            talkingAboutCountLabel1.Name = "talkingAboutCountLabel1";
            talkingAboutCountLabel1.Size = new System.Drawing.Size(157, 20);
            talkingAboutCountLabel1.TabIndex = 227;
            talkingAboutCountLabel1.Text = "Talking About Count:";
            // 
            // pictureURLLabel2
            // 
            pictureURLLabel2.AutoSize = true;
            pictureURLLabel2.Location = new System.Drawing.Point(246, 2185);
            pictureURLLabel2.Name = "pictureURLLabel2";
            pictureURLLabel2.Size = new System.Drawing.Size(99, 20);
            pictureURLLabel2.TabIndex = 225;
            pictureURLLabel2.Text = "Picture URL:";
            // 
            // pictureSqaureURLLabel3
            // 
            pictureSqaureURLLabel3.AutoSize = true;
            pictureSqaureURLLabel3.Location = new System.Drawing.Point(246, 2153);
            pictureSqaureURLLabel3.Name = "pictureSqaureURLLabel3";
            pictureSqaureURLLabel3.Size = new System.Drawing.Size(155, 20);
            pictureSqaureURLLabel3.TabIndex = 223;
            pictureSqaureURLLabel3.Text = "Picture Sqaure URL:";
            // 
            // pictureSmallURLLabel3
            // 
            pictureSmallURLLabel3.AutoSize = true;
            pictureSmallURLLabel3.Location = new System.Drawing.Point(246, 2121);
            pictureSmallURLLabel3.Name = "pictureSmallURLLabel3";
            pictureSmallURLLabel3.Size = new System.Drawing.Size(142, 20);
            pictureSmallURLLabel3.TabIndex = 221;
            pictureSmallURLLabel3.Text = "Picture Small URL:";
            // 
            // pictureNormalURLLabel3
            // 
            pictureNormalURLLabel3.AutoSize = true;
            pictureNormalURLLabel3.Location = new System.Drawing.Point(246, 2089);
            pictureNormalURLLabel3.Name = "pictureNormalURLLabel3";
            pictureNormalURLLabel3.Size = new System.Drawing.Size(153, 20);
            pictureNormalURLLabel3.TabIndex = 219;
            pictureNormalURLLabel3.Text = "Picture Normal URL:";
            // 
            // pictureLargeURLLabel3
            // 
            pictureLargeURLLabel3.AutoSize = true;
            pictureLargeURLLabel3.Location = new System.Drawing.Point(246, 2057);
            pictureLargeURLLabel3.Name = "pictureLargeURLLabel3";
            pictureLargeURLLabel3.Size = new System.Drawing.Size(144, 20);
            pictureLargeURLLabel3.TabIndex = 217;
            pictureLargeURLLabel3.Text = "Picture Large URL:";
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(246, 2025);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(59, 20);
            phoneLabel1.TabIndex = 215;
            phoneLabel1.Text = "Phone:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(246, 1993);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(55, 20);
            nameLabel2.TabIndex = 213;
            nameLabel2.Text = "Name:";
            // 
            // loggedInUserCanPostLabel1
            // 
            loggedInUserCanPostLabel1.AutoSize = true;
            loggedInUserCanPostLabel1.Location = new System.Drawing.Point(246, 1964);
            loggedInUserCanPostLabel1.Name = "loggedInUserCanPostLabel1";
            loggedInUserCanPostLabel1.Size = new System.Drawing.Size(192, 20);
            loggedInUserCanPostLabel1.TabIndex = 211;
            loggedInUserCanPostLabel1.Text = "Logged In User Can Post:";
            // 
            // likesCountLabel1
            // 
            likesCountLabel1.AutoSize = true;
            likesCountLabel1.Location = new System.Drawing.Point(246, 1930);
            likesCountLabel1.Name = "likesCountLabel1";
            likesCountLabel1.Size = new System.Drawing.Size(97, 20);
            likesCountLabel1.TabIndex = 209;
            likesCountLabel1.Text = "Likes Count:";
            // 
            // isPublishedLabel1
            // 
            isPublishedLabel1.AutoSize = true;
            isPublishedLabel1.Location = new System.Drawing.Point(246, 1901);
            isPublishedLabel1.Name = "isPublishedLabel1";
            isPublishedLabel1.Size = new System.Drawing.Size(99, 20);
            isPublishedLabel1.TabIndex = 207;
            isPublishedLabel1.Text = "Is Published:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            idLabel.Location = new System.Drawing.Point(13, 16);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            nameLabel1.Location = new System.Drawing.Point(13, 58);
            nameLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(55, 20);
            nameLabel1.TabIndex = 2;
            nameLabel1.Text = "Name:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            birthdayLabel.Location = new System.Drawing.Point(19, 14);
            birthdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(71, 20);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            emailLabel.Location = new System.Drawing.Point(19, 66);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            localeLabel.Location = new System.Drawing.Point(19, 112);
            localeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(60, 20);
            localeLabel.TabIndex = 10;
            localeLabel.Text = "Locale:";
            // 
            // nameLabel3
            // 
            nameLabel3.AutoSize = true;
            nameLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            nameLabel3.Location = new System.Drawing.Point(19, 159);
            nameLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel3.Name = "nameLabel3";
            nameLabel3.Size = new System.Drawing.Size(55, 20);
            nameLabel3.TabIndex = 12;
            nameLabel3.Text = "Name:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            descriptionLabel1.Location = new System.Drawing.Point(21, 14);
            descriptionLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(93, 20);
            descriptionLabel1.TabIndex = 0;
            descriptionLabel1.Text = "Description:";
            // 
            // idLabel2
            // 
            idLabel2.AutoSize = true;
            idLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            idLabel2.Location = new System.Drawing.Point(21, 50);
            idLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel2.Name = "idLabel2";
            idLabel2.Size = new System.Drawing.Size(27, 20);
            idLabel2.TabIndex = 2;
            idLabel2.Text = "Id:";
            // 
            // nameLabel7
            // 
            nameLabel7.AutoSize = true;
            nameLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            nameLabel7.Location = new System.Drawing.Point(21, 86);
            nameLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel7.Name = "nameLabel7";
            nameLabel7.Size = new System.Drawing.Size(55, 20);
            nameLabel7.TabIndex = 4;
            nameLabel7.Text = "Name:";
            // 
            // updateTimeLabel1
            // 
            updateTimeLabel1.AutoSize = true;
            updateTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            updateTimeLabel1.Location = new System.Drawing.Point(21, 121);
            updateTimeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            updateTimeLabel1.Name = "updateTimeLabel1";
            updateTimeLabel1.Size = new System.Drawing.Size(104, 20);
            updateTimeLabel1.TabIndex = 6;
            updateTimeLabel1.Text = "Update Time:";
            // 
            // captionLabel
            // 
            captionLabel.AutoSize = true;
            captionLabel.Location = new System.Drawing.Point(18, 32);
            captionLabel.Name = "captionLabel";
            captionLabel.Size = new System.Drawing.Size(68, 20);
            captionLabel.TabIndex = 232;
            captionLabel.Text = "Caption:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(18, 65);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(108, 20);
            createdTimeLabel.TabIndex = 234;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(18, 96);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 236;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(18, 128);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 238;
            nameLabel.Text = "Name:";
            // 
            // pictureURLLabel
            // 
            pictureURLLabel.AutoSize = true;
            pictureURLLabel.Location = new System.Drawing.Point(18, 157);
            pictureURLLabel.Name = "pictureURLLabel";
            pictureURLLabel.Size = new System.Drawing.Size(99, 20);
            pictureURLLabel.TabIndex = 240;
            pictureURLLabel.Text = "Picture URL:";
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.AutoSize = true;
            updateTimeLabel.Location = new System.Drawing.Point(18, 216);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(104, 20);
            updateTimeLabel.TabIndex = 242;
            updateTimeLabel.Text = "Update Time:";
            // 
            // createdTimeLabel2
            // 
            createdTimeLabel2.AutoSize = true;
            createdTimeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            createdTimeLabel2.Location = new System.Drawing.Point(20, 31);
            createdTimeLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            createdTimeLabel2.Name = "createdTimeLabel2";
            createdTimeLabel2.Size = new System.Drawing.Size(108, 20);
            createdTimeLabel2.TabIndex = 5;
            createdTimeLabel2.Text = "Created Time:";
            // 
            // messageLabel2
            // 
            messageLabel2.AutoSize = true;
            messageLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            messageLabel2.Location = new System.Drawing.Point(20, 70);
            messageLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            messageLabel2.Name = "messageLabel2";
            messageLabel2.Size = new System.Drawing.Size(78, 20);
            messageLabel2.TabIndex = 7;
            messageLabel2.Text = "Message:";
            // 
            // pageNameLabel
            // 
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            pageNameLabel.Location = new System.Drawing.Point(13, 150);
            pageNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new System.Drawing.Size(107, 20);
            pageNameLabel.TabIndex = 0;
            pageNameLabel.Text = "Page\'s Name:";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLogout.Location = new System.Drawing.Point(29, 48);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(83, 29);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLogin.Location = new System.Drawing.Point(29, 18);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(83, 29);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "switch user";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchPosts.Location = new System.Drawing.Point(71, 211);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(97, 36);
            this.buttonFetchPosts.TabIndex = 5;
            this.buttonFetchPosts.Text = "Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // buttonFetchAbout
            // 
            this.buttonFetchAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchAbout.Location = new System.Drawing.Point(70, 162);
            this.buttonFetchAbout.Name = "buttonFetchAbout";
            this.buttonFetchAbout.Size = new System.Drawing.Size(97, 36);
            this.buttonFetchAbout.TabIndex = 6;
            this.buttonFetchAbout.Text = "About";
            this.buttonFetchAbout.UseVisualStyleBackColor = true;
            this.buttonFetchAbout.Click += new System.EventHandler(this.buttonFetchAbout_Click);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchGroups.Location = new System.Drawing.Point(71, 358);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(97, 36);
            this.buttonFetchGroups.TabIndex = 7;
            this.buttonFetchGroups.Text = "Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchAlbums.Location = new System.Drawing.Point(71, 309);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(97, 36);
            this.buttonFetchAlbums.TabIndex = 8;
            this.buttonFetchAlbums.Text = "Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // buttonFetchPages
            // 
            this.buttonFetchPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchPages.Location = new System.Drawing.Point(71, 406);
            this.buttonFetchPages.Name = "buttonFetchPages";
            this.buttonFetchPages.Size = new System.Drawing.Size(97, 36);
            this.buttonFetchPages.TabIndex = 11;
            this.buttonFetchPages.Text = "Pages";
            this.buttonFetchPages.UseVisualStyleBackColor = true;
            this.buttonFetchPages.Click += new System.EventHandler(this.buttonFetchPages_Click);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchFriends.Location = new System.Drawing.Point(71, 260);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(97, 36);
            this.buttonFetchFriends.TabIndex = 9;
            this.buttonFetchFriends.Text = "Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelProfileName.Location = new System.Drawing.Point(412, 114);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(125, 25);
            this.labelProfileName.TabIndex = 10;
            this.labelProfileName.Text = "profile name";
            this.labelProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFetchSaved
            // 
            this.buttonFetchSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchSaved.Location = new System.Drawing.Point(71, 455);
            this.buttonFetchSaved.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchSaved.Name = "buttonFetchSaved";
            this.buttonFetchSaved.Size = new System.Drawing.Size(97, 36);
            this.buttonFetchSaved.TabIndex = 12;
            this.buttonFetchSaved.Text = "Saved Posts";
            this.buttonFetchSaved.UseVisualStyleBackColor = true;
            this.buttonFetchSaved.Click += new System.EventHandler(this.buttonFetchSavedPosts_Click);
            // 
            // mainListBox
            // 
            this.mainListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.Location = new System.Drawing.Point(210, 166);
            this.mainListBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(278, 316);
            this.mainListBox.TabIndex = 14;
            // 
            // pagePanel
            // 
            this.pagePanel.Controls.Add(pageNameLabel);
            this.pagePanel.Controls.Add(this.nameLabel6);
            this.pagePanel.Controls.Add(this.pictureSmallURLPictureBox);
            this.pagePanel.Location = new System.Drawing.Point(507, 166);
            this.pagePanel.Margin = new System.Windows.Forms.Padding(2);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(375, 315);
            this.pagePanel.TabIndex = 15;
            // 
            // nameLabel6
            // 
            this.nameLabel6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.nameLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel6.Location = new System.Drawing.Point(137, 151);
            this.nameLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel6.Name = "nameLabel6";
            this.nameLabel6.Size = new System.Drawing.Size(160, 104);
            this.nameLabel6.TabIndex = 1;
            this.nameLabel6.Text = "name";
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // pictureSmallURLPictureBox
            // 
            this.pictureSmallURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.pageBindingSource, "PictureSmallURL", true));
            this.pictureSmallURLPictureBox.Location = new System.Drawing.Point(103, 17);
            this.pictureSmallURLPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureSmallURLPictureBox.Name = "pictureSmallURLPictureBox";
            this.pictureSmallURLPictureBox.Size = new System.Drawing.Size(151, 118);
            this.pictureSmallURLPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSmallURLPictureBox.TabIndex = 3;
            this.pictureSmallURLPictureBox.TabStop = false;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.Location = new System.Drawing.Point(359, 2288);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(104, 20);
            this.websiteTextBox.TabIndex = 119;
            // 
            // uRLTextBox
            // 
            this.uRLTextBox.Location = new System.Drawing.Point(359, 2256);
            this.uRLTextBox.Name = "uRLTextBox";
            this.uRLTextBox.Size = new System.Drawing.Size(104, 20);
            this.uRLTextBox.TabIndex = 117;
            // 
            // talkingAboutCountTextBox
            // 
            this.talkingAboutCountTextBox.Location = new System.Drawing.Point(359, 2224);
            this.talkingAboutCountTextBox.Name = "talkingAboutCountTextBox";
            this.talkingAboutCountTextBox.Size = new System.Drawing.Size(104, 20);
            this.talkingAboutCountTextBox.TabIndex = 115;
            // 
            // pictureURLTextBox1
            // 
            this.pictureURLTextBox1.Location = new System.Drawing.Point(359, 2192);
            this.pictureURLTextBox1.Name = "pictureURLTextBox1";
            this.pictureURLTextBox1.Size = new System.Drawing.Size(104, 20);
            this.pictureURLTextBox1.TabIndex = 113;
            // 
            // pictureSqaureURLTextBox1
            // 
            this.pictureSqaureURLTextBox1.Location = new System.Drawing.Point(359, 2160);
            this.pictureSqaureURLTextBox1.Name = "pictureSqaureURLTextBox1";
            this.pictureSqaureURLTextBox1.Size = new System.Drawing.Size(104, 20);
            this.pictureSqaureURLTextBox1.TabIndex = 111;
            // 
            // pictureSmallURLTextBox1
            // 
            this.pictureSmallURLTextBox1.Location = new System.Drawing.Point(359, 2128);
            this.pictureSmallURLTextBox1.Name = "pictureSmallURLTextBox1";
            this.pictureSmallURLTextBox1.Size = new System.Drawing.Size(104, 20);
            this.pictureSmallURLTextBox1.TabIndex = 109;
            // 
            // pictureNormalURLTextBox1
            // 
            this.pictureNormalURLTextBox1.Location = new System.Drawing.Point(359, 2096);
            this.pictureNormalURLTextBox1.Name = "pictureNormalURLTextBox1";
            this.pictureNormalURLTextBox1.Size = new System.Drawing.Size(104, 20);
            this.pictureNormalURLTextBox1.TabIndex = 107;
            // 
            // pictureLargeURLTextBox1
            // 
            this.pictureLargeURLTextBox1.Location = new System.Drawing.Point(359, 2064);
            this.pictureLargeURLTextBox1.Name = "pictureLargeURLTextBox1";
            this.pictureLargeURLTextBox1.Size = new System.Drawing.Size(104, 20);
            this.pictureLargeURLTextBox1.TabIndex = 105;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(359, 2032);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(104, 20);
            this.phoneTextBox.TabIndex = 103;
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Location = new System.Drawing.Point(359, 2000);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(104, 20);
            this.nameTextBox2.TabIndex = 101;
            // 
            // loggedInUserCanPostCheckBox
            // 
            this.loggedInUserCanPostCheckBox.Location = new System.Drawing.Point(359, 1969);
            this.loggedInUserCanPostCheckBox.Name = "loggedInUserCanPostCheckBox";
            this.loggedInUserCanPostCheckBox.Size = new System.Drawing.Size(104, 24);
            this.loggedInUserCanPostCheckBox.TabIndex = 99;
            this.loggedInUserCanPostCheckBox.Text = "checkBox1";
            this.loggedInUserCanPostCheckBox.UseVisualStyleBackColor = true;
            // 
            // likesCountTextBox
            // 
            this.likesCountTextBox.Location = new System.Drawing.Point(359, 1937);
            this.likesCountTextBox.Name = "likesCountTextBox";
            this.likesCountTextBox.Size = new System.Drawing.Size(104, 20);
            this.likesCountTextBox.TabIndex = 97;
            // 
            // isPublishedCheckBox
            // 
            this.isPublishedCheckBox.Location = new System.Drawing.Point(359, 1906);
            this.isPublishedCheckBox.Name = "isPublishedCheckBox";
            this.isPublishedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isPublishedCheckBox.TabIndex = 95;
            this.isPublishedCheckBox.Text = "checkBox1";
            this.isPublishedCheckBox.UseVisualStyleBackColor = true;
            // 
            // websiteTextBox1
            // 
            this.websiteTextBox1.Location = new System.Drawing.Point(444, 2278);
            this.websiteTextBox1.Name = "websiteTextBox1";
            this.websiteTextBox1.Size = new System.Drawing.Size(104, 20);
            this.websiteTextBox1.TabIndex = 232;
            // 
            // uRLTextBox1
            // 
            this.uRLTextBox1.Location = new System.Drawing.Point(444, 2246);
            this.uRLTextBox1.Name = "uRLTextBox1";
            this.uRLTextBox1.Size = new System.Drawing.Size(104, 20);
            this.uRLTextBox1.TabIndex = 230;
            // 
            // talkingAboutCountTextBox1
            // 
            this.talkingAboutCountTextBox1.Location = new System.Drawing.Point(444, 2214);
            this.talkingAboutCountTextBox1.Name = "talkingAboutCountTextBox1";
            this.talkingAboutCountTextBox1.Size = new System.Drawing.Size(104, 20);
            this.talkingAboutCountTextBox1.TabIndex = 228;
            // 
            // pictureURLTextBox2
            // 
            this.pictureURLTextBox2.Location = new System.Drawing.Point(444, 2182);
            this.pictureURLTextBox2.Name = "pictureURLTextBox2";
            this.pictureURLTextBox2.Size = new System.Drawing.Size(104, 20);
            this.pictureURLTextBox2.TabIndex = 226;
            // 
            // pictureSqaureURLTextBox3
            // 
            this.pictureSqaureURLTextBox3.Location = new System.Drawing.Point(444, 2150);
            this.pictureSqaureURLTextBox3.Name = "pictureSqaureURLTextBox3";
            this.pictureSqaureURLTextBox3.Size = new System.Drawing.Size(104, 20);
            this.pictureSqaureURLTextBox3.TabIndex = 224;
            // 
            // pictureSmallURLTextBox3
            // 
            this.pictureSmallURLTextBox3.Location = new System.Drawing.Point(444, 2118);
            this.pictureSmallURLTextBox3.Name = "pictureSmallURLTextBox3";
            this.pictureSmallURLTextBox3.Size = new System.Drawing.Size(104, 20);
            this.pictureSmallURLTextBox3.TabIndex = 222;
            // 
            // pictureNormalURLTextBox3
            // 
            this.pictureNormalURLTextBox3.Location = new System.Drawing.Point(444, 2086);
            this.pictureNormalURLTextBox3.Name = "pictureNormalURLTextBox3";
            this.pictureNormalURLTextBox3.Size = new System.Drawing.Size(104, 20);
            this.pictureNormalURLTextBox3.TabIndex = 220;
            // 
            // pictureLargeURLTextBox3
            // 
            this.pictureLargeURLTextBox3.Location = new System.Drawing.Point(444, 2054);
            this.pictureLargeURLTextBox3.Name = "pictureLargeURLTextBox3";
            this.pictureLargeURLTextBox3.Size = new System.Drawing.Size(104, 20);
            this.pictureLargeURLTextBox3.TabIndex = 218;
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.Location = new System.Drawing.Point(444, 2022);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(104, 20);
            this.phoneTextBox1.TabIndex = 216;
            // 
            // nameTextBox4
            // 
            this.nameTextBox4.Location = new System.Drawing.Point(444, 1990);
            this.nameTextBox4.Name = "nameTextBox4";
            this.nameTextBox4.Size = new System.Drawing.Size(104, 20);
            this.nameTextBox4.TabIndex = 214;
            // 
            // loggedInUserCanPostCheckBox1
            // 
            this.loggedInUserCanPostCheckBox1.Location = new System.Drawing.Point(444, 1959);
            this.loggedInUserCanPostCheckBox1.Name = "loggedInUserCanPostCheckBox1";
            this.loggedInUserCanPostCheckBox1.Size = new System.Drawing.Size(104, 24);
            this.loggedInUserCanPostCheckBox1.TabIndex = 212;
            this.loggedInUserCanPostCheckBox1.Text = "checkBox1";
            this.loggedInUserCanPostCheckBox1.UseVisualStyleBackColor = true;
            // 
            // likesCountTextBox1
            // 
            this.likesCountTextBox1.Location = new System.Drawing.Point(444, 1927);
            this.likesCountTextBox1.Name = "likesCountTextBox1";
            this.likesCountTextBox1.Size = new System.Drawing.Size(104, 20);
            this.likesCountTextBox1.TabIndex = 210;
            // 
            // isPublishedCheckBox1
            // 
            this.isPublishedCheckBox1.Location = new System.Drawing.Point(444, 1896);
            this.isPublishedCheckBox1.Name = "isPublishedCheckBox1";
            this.isPublishedCheckBox1.Size = new System.Drawing.Size(104, 24);
            this.isPublishedCheckBox1.TabIndex = 208;
            this.isPublishedCheckBox1.Text = "checkBox1";
            this.isPublishedCheckBox1.UseVisualStyleBackColor = true;
            // 
            // postPanel
            // 
            this.postPanel.AutoSize = true;
            this.postPanel.Controls.Add(createdTimeLabel2);
            this.postPanel.Controls.Add(this.createdTimeDateTimePicker2);
            this.postPanel.Controls.Add(messageLabel2);
            this.postPanel.Controls.Add(this.messageTextBox);
            this.postPanel.Controls.Add(this.saveButton);
            this.postPanel.Location = new System.Drawing.Point(507, 166);
            this.postPanel.Margin = new System.Windows.Forms.Padding(2);
            this.postPanel.Name = "postPanel";
            this.postPanel.Size = new System.Drawing.Size(375, 315);
            this.postPanel.TabIndex = 19;
            // 
            // createdTimeDateTimePicker2
            // 
            this.createdTimeDateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker2.Location = new System.Drawing.Point(141, 32);
            this.createdTimeDateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.createdTimeDateTimePicker2.Name = "createdTimeDateTimePicker2";
            this.createdTimeDateTimePicker2.Size = new System.Drawing.Size(135, 20);
            this.createdTimeDateTimePicker2.TabIndex = 6;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.White;
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.ForeColor = System.Drawing.Color.Black;
            this.messageTextBox.Location = new System.Drawing.Point(108, 68);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(220, 131);
            this.messageTextBox.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(184, 202);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 36);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "save post";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // friendPanel
            // 
            this.friendPanel.Controls.Add(idLabel);
            this.friendPanel.Controls.Add(this.idTextBox);
            this.friendPanel.Controls.Add(nameLabel1);
            this.friendPanel.Controls.Add(this.nameTextBox1);
            this.friendPanel.Location = new System.Drawing.Point(507, 166);
            this.friendPanel.Margin = new System.Windows.Forms.Padding(2);
            this.friendPanel.Name = "friendPanel";
            this.friendPanel.Size = new System.Drawing.Size(375, 315);
            this.friendPanel.TabIndex = 16;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendListBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(73, 17);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(148, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // friendListBindingSource
            // 
            this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.FriendList);
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendListBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(73, 58);
            this.nameTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(148, 20);
            this.nameTextBox1.TabIndex = 3;
            // 
            // aboutPanel
            // 
            this.aboutPanel.AutoSize = true;
            this.aboutPanel.Controls.Add(this.localeTextBox1);
            this.aboutPanel.Controls.Add(birthdayLabel);
            this.aboutPanel.Controls.Add(this.birthdayTextBox);
            this.aboutPanel.Controls.Add(emailLabel);
            this.aboutPanel.Controls.Add(this.emailTextBox);
            this.aboutPanel.Controls.Add(localeLabel);
            this.aboutPanel.Controls.Add(nameLabel3);
            this.aboutPanel.Controls.Add(this.nameTextBox3);
            this.aboutPanel.Location = new System.Drawing.Point(507, 166);
            this.aboutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(375, 315);
            this.aboutPanel.TabIndex = 17;
            // 
            // localeTextBox1
            // 
            this.localeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Locale", true));
            this.localeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.localeTextBox1.Location = new System.Drawing.Point(105, 114);
            this.localeTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.localeTextBox1.Name = "localeTextBox1";
            this.localeTextBox1.Size = new System.Drawing.Size(213, 26);
            this.localeTextBox1.TabIndex = 14;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.birthdayTextBox.Location = new System.Drawing.Point(105, 12);
            this.birthdayTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(213, 26);
            this.birthdayTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.emailTextBox.Location = new System.Drawing.Point(105, 64);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(213, 26);
            this.emailTextBox.TabIndex = 3;
            // 
            // nameTextBox3
            // 
            this.nameTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameTextBox3.Location = new System.Drawing.Point(105, 159);
            this.nameTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox3.Name = "nameTextBox3";
            this.nameTextBox3.Size = new System.Drawing.Size(213, 26);
            this.nameTextBox3.TabIndex = 13;
            // 
            // groupPanel
            // 
            this.groupPanel.Controls.Add(descriptionLabel1);
            this.groupPanel.Controls.Add(this.descriptionTextBox1);
            this.groupPanel.Controls.Add(idLabel2);
            this.groupPanel.Controls.Add(this.idTextBox2);
            this.groupPanel.Controls.Add(nameLabel7);
            this.groupPanel.Controls.Add(this.nameTextBox5);
            this.groupPanel.Controls.Add(updateTimeLabel1);
            this.groupPanel.Controls.Add(this.updateTimeDateTimePicker);
            this.groupPanel.Location = new System.Drawing.Point(507, 166);
            this.groupPanel.Margin = new System.Windows.Forms.Padding(2);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(375, 315);
            this.groupPanel.TabIndex = 18;
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Description", true));
            this.descriptionTextBox1.Location = new System.Drawing.Point(144, 14);
            this.descriptionTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.Size = new System.Drawing.Size(135, 20);
            this.descriptionTextBox1.TabIndex = 1;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // idTextBox2
            // 
            this.idTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Id", true));
            this.idTextBox2.Location = new System.Drawing.Point(144, 49);
            this.idTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox2.Name = "idTextBox2";
            this.idTextBox2.Size = new System.Drawing.Size(135, 20);
            this.idTextBox2.TabIndex = 3;
            // 
            // nameTextBox5
            // 
            this.nameTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Name", true));
            this.nameTextBox5.Location = new System.Drawing.Point(144, 85);
            this.nameTextBox5.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox5.Name = "nameTextBox5";
            this.nameTextBox5.Size = new System.Drawing.Size(135, 20);
            this.nameTextBox5.TabIndex = 5;
            // 
            // updateTimeDateTimePicker
            // 
            this.updateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.groupBindingSource, "UpdateTime", true));
            this.updateTimeDateTimePicker.Location = new System.Drawing.Point(144, 120);
            this.updateTimeDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.updateTimeDateTimePicker.Name = "updateTimeDateTimePicker";
            this.updateTimeDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.updateTimeDateTimePicker.TabIndex = 7;
            // 
            // captionTextBox
            // 
            this.captionTextBox.Location = new System.Drawing.Point(132, 29);
            this.captionTextBox.Name = "captionTextBox";
            this.captionTextBox.Size = new System.Drawing.Size(200, 20);
            this.captionTextBox.TabIndex = 233;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(132, 61);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.createdTimeDateTimePicker.TabIndex = 235;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(132, 93);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 237;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(132, 125);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 239;
            // 
            // updateTimeTextBox
            // 
            this.updateTimeTextBox.Location = new System.Drawing.Point(132, 213);
            this.updateTimeTextBox.Name = "updateTimeTextBox";
            this.updateTimeTextBox.Size = new System.Drawing.Size(200, 20);
            this.updateTimeTextBox.TabIndex = 243;
            // 
            // flowLayoutPanelSavedPosts
            // 
            this.flowLayoutPanelSavedPosts.AutoScroll = true;
            this.flowLayoutPanelSavedPosts.Location = new System.Drawing.Point(210, 164);
            this.flowLayoutPanelSavedPosts.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelSavedPosts.Name = "flowLayoutPanelSavedPosts";
            this.flowLayoutPanelSavedPosts.Size = new System.Drawing.Size(670, 317);
            this.flowLayoutPanelSavedPosts.TabIndex = 20;
            // 
            // albumPanel
            // 
            this.albumPanel.Controls.Add(this.stopLabel);
            this.albumPanel.Controls.Add(this.startLabel);
            this.albumPanel.Controls.Add(this.buttonStopSlide);
            this.albumPanel.Controls.Add(this.buttonPlaySlide);
            this.albumPanel.Controls.Add(this.albumPictureBox);
            this.albumPanel.Location = new System.Drawing.Point(507, 166);
            this.albumPanel.Margin = new System.Windows.Forms.Padding(2);
            this.albumPanel.Name = "albumPanel";
            this.albumPanel.Size = new System.Drawing.Size(375, 315);
            this.albumPanel.TabIndex = 21;
            // 
            // stopLabel
            // 
            this.stopLabel.AutoSize = true;
            this.stopLabel.Location = new System.Drawing.Point(203, 268);
            this.stopLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stopLabel.Name = "stopLabel";
            this.stopLabel.Size = new System.Drawing.Size(29, 13);
            this.stopLabel.TabIndex = 5;
            this.stopLabel.Text = "Stop";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(137, 269);
            this.startLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(29, 13);
            this.startLabel.TabIndex = 4;
            this.startLabel.Text = "Start";
            // 
            // buttonStopSlide
            // 
            this.buttonStopSlide.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.stopIcon;
            this.buttonStopSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStopSlide.Location = new System.Drawing.Point(192, 236);
            this.buttonStopSlide.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStopSlide.Name = "buttonStopSlide";
            this.buttonStopSlide.Size = new System.Drawing.Size(51, 31);
            this.buttonStopSlide.TabIndex = 3;
            this.buttonStopSlide.UseVisualStyleBackColor = true;
            this.buttonStopSlide.Click += new System.EventHandler(this.buttonStopSlide_Click);
            // 
            // buttonPlaySlide
            // 
            this.buttonPlaySlide.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.playIcon;
            this.buttonPlaySlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlaySlide.Location = new System.Drawing.Point(127, 236);
            this.buttonPlaySlide.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlaySlide.Name = "buttonPlaySlide";
            this.buttonPlaySlide.Size = new System.Drawing.Size(51, 31);
            this.buttonPlaySlide.TabIndex = 2;
            this.buttonPlaySlide.UseVisualStyleBackColor = true;
            this.buttonPlaySlide.Click += new System.EventHandler(this.buttonPlaySlide_Click);
            // 
            // albumPictureBox
            // 
            this.albumPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.albumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "PictureSmallURL", true));
            this.albumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.albumBindingSource, "PictureSmallURL", true));
            this.albumPictureBox.Location = new System.Drawing.Point(51, 10);
            this.albumPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.albumPictureBox.Name = "albumPictureBox";
            this.albumPictureBox.Size = new System.Drawing.Size(279, 219);
            this.albumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumPictureBox.TabIndex = 1;
            this.albumPictureBox.TabStop = false;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // savedPostIcon
            // 
            this.savedPostIcon.BackColor = System.Drawing.Color.Transparent;
            this.savedPostIcon.Image = global::BasicFacebookFeatures.Properties.Resources.savedPostIcon;
            this.savedPostIcon.Location = new System.Drawing.Point(29, 455);
            this.savedPostIcon.Margin = new System.Windows.Forms.Padding(2);
            this.savedPostIcon.Name = "savedPostIcon";
            this.savedPostIcon.Size = new System.Drawing.Size(37, 36);
            this.savedPostIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.savedPostIcon.TabIndex = 28;
            this.savedPostIcon.TabStop = false;
            // 
            // pagesIcon
            // 
            this.pagesIcon.BackColor = System.Drawing.Color.Transparent;
            this.pagesIcon.Image = global::BasicFacebookFeatures.Properties.Resources.pagesIcon;
            this.pagesIcon.Location = new System.Drawing.Point(29, 406);
            this.pagesIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pagesIcon.Name = "pagesIcon";
            this.pagesIcon.Size = new System.Drawing.Size(37, 36);
            this.pagesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pagesIcon.TabIndex = 27;
            this.pagesIcon.TabStop = false;
            // 
            // groupsIcon
            // 
            this.groupsIcon.BackColor = System.Drawing.Color.Transparent;
            this.groupsIcon.Image = global::BasicFacebookFeatures.Properties.Resources.groupsIcon;
            this.groupsIcon.Location = new System.Drawing.Point(29, 358);
            this.groupsIcon.Margin = new System.Windows.Forms.Padding(2);
            this.groupsIcon.Name = "groupsIcon";
            this.groupsIcon.Size = new System.Drawing.Size(37, 36);
            this.groupsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.groupsIcon.TabIndex = 26;
            this.groupsIcon.TabStop = false;
            // 
            // albumsIcon
            // 
            this.albumsIcon.BackColor = System.Drawing.Color.Transparent;
            this.albumsIcon.Image = global::BasicFacebookFeatures.Properties.Resources.albumsIcon;
            this.albumsIcon.Location = new System.Drawing.Point(29, 309);
            this.albumsIcon.Margin = new System.Windows.Forms.Padding(2);
            this.albumsIcon.Name = "albumsIcon";
            this.albumsIcon.Size = new System.Drawing.Size(37, 36);
            this.albumsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumsIcon.TabIndex = 25;
            this.albumsIcon.TabStop = false;
            // 
            // friendsIcon
            // 
            this.friendsIcon.BackColor = System.Drawing.Color.Transparent;
            this.friendsIcon.Image = global::BasicFacebookFeatures.Properties.Resources.friendsIcon;
            this.friendsIcon.Location = new System.Drawing.Point(29, 260);
            this.friendsIcon.Margin = new System.Windows.Forms.Padding(2);
            this.friendsIcon.Name = "friendsIcon";
            this.friendsIcon.Size = new System.Drawing.Size(37, 36);
            this.friendsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.friendsIcon.TabIndex = 24;
            this.friendsIcon.TabStop = false;
            // 
            // aboutIcon
            // 
            this.aboutIcon.BackColor = System.Drawing.Color.Transparent;
            this.aboutIcon.Image = global::BasicFacebookFeatures.Properties.Resources.aboutIcon;
            this.aboutIcon.Location = new System.Drawing.Point(29, 162);
            this.aboutIcon.Margin = new System.Windows.Forms.Padding(2);
            this.aboutIcon.Name = "aboutIcon";
            this.aboutIcon.Size = new System.Drawing.Size(37, 36);
            this.aboutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutIcon.TabIndex = 23;
            this.aboutIcon.TabStop = false;
            // 
            // postsIcon
            // 
            this.postsIcon.BackColor = System.Drawing.Color.Transparent;
            this.postsIcon.Image = global::BasicFacebookFeatures.Properties.Resources.postIcon;
            this.postsIcon.Location = new System.Drawing.Point(29, 211);
            this.postsIcon.Margin = new System.Windows.Forms.Padding(2);
            this.postsIcon.Name = "postsIcon";
            this.postsIcon.Size = new System.Drawing.Size(37, 36);
            this.postsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.postsIcon.TabIndex = 22;
            this.postsIcon.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(411, 7);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(125, 104);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureURLPictureBox
            // 
            this.pictureURLPictureBox.Location = new System.Drawing.Point(132, 157);
            this.pictureURLPictureBox.Name = "pictureURLPictureBox";
            this.pictureURLPictureBox.Size = new System.Drawing.Size(200, 50);
            this.pictureURLPictureBox.TabIndex = 241;
            this.pictureURLPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.labelProfileName);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.pictureBoxProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 149);
            this.panel1.TabIndex = 29;
            // 
            // ProfileFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(918, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.savedPostIcon);
            this.Controls.Add(this.pagesIcon);
            this.Controls.Add(this.groupsIcon);
            this.Controls.Add(this.albumsIcon);
            this.Controls.Add(this.friendsIcon);
            this.Controls.Add(this.aboutIcon);
            this.Controls.Add(this.postsIcon);
            this.Controls.Add(this.mainListBox);
            this.Controls.Add(this.buttonFetchSaved);
            this.Controls.Add(this.buttonFetchPages);
            this.Controls.Add(this.buttonFetchFriends);
            this.Controls.Add(this.buttonFetchAlbums);
            this.Controls.Add(this.buttonFetchGroups);
            this.Controls.Add(this.buttonFetchAbout);
            this.Controls.Add(this.buttonFetchPosts);
            this.Controls.Add(this.pagePanel);
            this.Controls.Add(this.flowLayoutPanelSavedPosts);
            this.Controls.Add(this.groupPanel);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(this.postPanel);
            this.Controls.Add(this.friendPanel);
            this.Controls.Add(this.albumPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileFeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileFeed";
            this.pagePanel.ResumeLayout(false);
            this.pagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSmallURLPictureBox)).EndInit();
            this.postPanel.ResumeLayout(false);
            this.postPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.friendPanel.ResumeLayout(false);
            this.friendPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupPanel.ResumeLayout(false);
            this.groupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.albumPanel.ResumeLayout(false);
            this.albumPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savedPostIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.Button buttonFetchAbout;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.Label labelProfileName;
        private Button buttonFetchPages;
        private Button buttonFetchSaved;
        private ListBox mainListBox;
        private Panel pagePanel;
        private Label nameLabel6;
        private BindingSource pageBindingSource;
        private PictureBox pictureSmallURLPictureBox;
        private TextBox websiteTextBox;
        private TextBox uRLTextBox;
        private TextBox talkingAboutCountTextBox;
        private TextBox pictureURLTextBox1;
        private TextBox pictureSqaureURLTextBox1;
        private TextBox pictureSmallURLTextBox1;
        private TextBox pictureNormalURLTextBox1;
        private TextBox pictureLargeURLTextBox1;
        private TextBox phoneTextBox;
        private TextBox nameTextBox2;
        private CheckBox loggedInUserCanPostCheckBox;
        private TextBox likesCountTextBox;
        private CheckBox isPublishedCheckBox;
        private TextBox websiteTextBox1;
        private TextBox uRLTextBox1;
        private TextBox talkingAboutCountTextBox1;
        private TextBox pictureURLTextBox2;
        private TextBox pictureSqaureURLTextBox3;
        private TextBox pictureSmallURLTextBox3;
        private TextBox pictureNormalURLTextBox3;
        private TextBox pictureLargeURLTextBox3;
        private TextBox phoneTextBox1;
        private TextBox nameTextBox4;
        private CheckBox loggedInUserCanPostCheckBox1;
        private TextBox likesCountTextBox1;
        private CheckBox isPublishedCheckBox1;
        private Panel postPanel;
        private Panel friendPanel;
        private TextBox idTextBox;
        private BindingSource friendListBindingSource;
        private TextBox nameTextBox1;
        private Panel aboutPanel;
        private TextBox birthdayTextBox;
        private BindingSource userBindingSource;
        private TextBox emailTextBox;
        private TextBox nameTextBox3;
        private Panel groupPanel;
        private TextBox descriptionTextBox1;
        private BindingSource groupBindingSource;
        private TextBox idTextBox2;
        private TextBox nameTextBox5;
        private DateTimePicker updateTimeDateTimePicker;
        private TextBox captionTextBox;
        private DateTimePicker createdTimeDateTimePicker;
        private TextBox descriptionTextBox;
        private TextBox nameTextBox;
        private PictureBox pictureURLPictureBox;
        private TextBox updateTimeTextBox;
        private BindingSource postBindingSource;
        private Button saveButton;
        private FlowLayoutPanel flowLayoutPanelSavedPosts;
        private Panel albumPanel;
        private Button buttonPlaySlide;
        private PictureBox albumPictureBox;
        private BindingSource albumBindingSource;
        private Button buttonStopSlide;
        private DateTimePicker createdTimeDateTimePicker2;
        private TextBox messageTextBox;
        private PictureBox postsIcon;
        private PictureBox aboutIcon;
        private PictureBox friendsIcon;
        private PictureBox albumsIcon;
        private PictureBox groupsIcon;
        private PictureBox pagesIcon;
        private PictureBox savedPostIcon;
        private TextBox localeTextBox1;
        private Label stopLabel;
        private Label startLabel;
        private Panel panel1;
    }
}
