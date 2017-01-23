namespace MasterApp
{
    partial class UserManagementView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementView));
            this.tboxUsernameSearch = new System.Windows.Forms.TextBox();
            this.lblUserNameSearch = new System.Windows.Forms.Label();
            this.btnSubmitSearch = new System.Windows.Forms.Button();
            this.tboxFirstNameResults = new System.Windows.Forms.TextBox();
            this.lblResultsFirstName = new System.Windows.Forms.Label();
            this.tboxLastNameResults = new System.Windows.Forms.TextBox();
            this.lblResultsLastName = new System.Windows.Forms.Label();
            this.tboxMessage = new System.Windows.Forms.TextBox();
            this.tboxUserNameResults = new System.Windows.Forms.TextBox();
            this.lblResultsUsername = new System.Windows.Forms.Label();
            this.lblFirstNameSearch = new System.Windows.Forms.Label();
            this.tboxFirstNameSearch = new System.Windows.Forms.TextBox();
            this.tboxLastNameSearch = new System.Windows.Forms.TextBox();
            this.lblLastNameSearch = new System.Windows.Forms.Label();
            this.lblResultsFullName = new System.Windows.Forms.Label();
            this.tboxFullNameResults = new System.Windows.Forms.TextBox();
            this.chkboxError = new System.Windows.Forms.CheckBox();
            this.chkBoxLockedOut = new System.Windows.Forms.CheckBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tboxNewPassword = new System.Windows.Forms.TextBox();
            this.lblLastLogin = new System.Windows.Forms.Label();
            this.lblLastFailedLogin = new System.Windows.Forms.Label();
            this.lblLockOutTime = new System.Windows.Forms.Label();
            this.lblFailedLogins = new System.Windows.Forms.Label();
            this.tboxLastFailedLogin = new System.Windows.Forms.TextBox();
            this.tboxLastLogin = new System.Windows.Forms.TextBox();
            this.tBoxFailedLogins = new System.Windows.Forms.TextBox();
            this.tboxLockOutTime = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.chkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.chkBoxDisabled = new System.Windows.Forms.CheckBox();
            this.UnlockToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EnableToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DisableToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ChangePasswordToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NewPasswordToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cBoxGroupSearch = new System.Windows.Forms.ComboBox();
            this.lblGroupSearch = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.chkBoxChangePassNextLogon = new System.Windows.Forms.CheckBox();
            this.pnlLogins = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlNames = new System.Windows.Forms.Panel();
            this.pnlChkBox = new System.Windows.Forms.Panel();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.lblGroupUser = new System.Windows.Forms.Label();
            this.pnlUserGroups = new System.Windows.Forms.Panel();
            this.richTboxGroups = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDisabledUsers = new System.Windows.Forms.Panel();
            this.richTboxDisabledUsers = new System.Windows.Forms.RichTextBox();
            this.pnlEnabledUsers = new System.Windows.Forms.Panel();
            this.richTboxEnabledUsers = new System.Windows.Forms.RichTextBox();
            this.lblEnabledUsers = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlLogins.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlNames.SuspendLayout();
            this.pnlChkBox.SuspendLayout();
            this.pnlMessage.SuspendLayout();
            this.pnlUserGroups.SuspendLayout();
            this.pnlDisabledUsers.SuspendLayout();
            this.pnlEnabledUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxUsernameSearch
            // 
            this.tboxUsernameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxUsernameSearch.Location = new System.Drawing.Point(83, 95);
            this.tboxUsernameSearch.MaxLength = 20;
            this.tboxUsernameSearch.Name = "tboxUsernameSearch";
            this.tboxUsernameSearch.Size = new System.Drawing.Size(116, 20);
            this.tboxUsernameSearch.TabIndex = 1;
            this.tboxUsernameSearch.TextChanged += new System.EventHandler(this.tboxUsernameSearch_txtChange);
            // 
            // lblUserNameSearch
            // 
            this.lblUserNameSearch.AutoSize = true;
            this.lblUserNameSearch.Location = new System.Drawing.Point(27, 97);
            this.lblUserNameSearch.Name = "lblUserNameSearch";
            this.lblUserNameSearch.Size = new System.Drawing.Size(55, 13);
            this.lblUserNameSearch.TabIndex = 2;
            this.lblUserNameSearch.Text = "Username";
            // 
            // btnSubmitSearch
            // 
            this.btnSubmitSearch.Enabled = false;
            this.btnSubmitSearch.Location = new System.Drawing.Point(83, 172);
            this.btnSubmitSearch.Name = "btnSubmitSearch";
            this.btnSubmitSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitSearch.TabIndex = 3;
            this.btnSubmitSearch.Text = "Search";
            this.SearchToolTip.SetToolTip(this.btnSubmitSearch, "Search for user\'s information.");
            this.btnSubmitSearch.UseVisualStyleBackColor = true;
            this.btnSubmitSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tboxFirstNameResults
            // 
            this.tboxFirstNameResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxFirstNameResults.Location = new System.Drawing.Point(80, 11);
            this.tboxFirstNameResults.Name = "tboxFirstNameResults";
            this.tboxFirstNameResults.ReadOnly = true;
            this.tboxFirstNameResults.Size = new System.Drawing.Size(106, 20);
            this.tboxFirstNameResults.TabIndex = 6;
            this.tboxFirstNameResults.TabStop = false;
            // 
            // lblResultsFirstName
            // 
            this.lblResultsFirstName.AutoSize = true;
            this.lblResultsFirstName.Location = new System.Drawing.Point(12, 15);
            this.lblResultsFirstName.Name = "lblResultsFirstName";
            this.lblResultsFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblResultsFirstName.TabIndex = 7;
            this.lblResultsFirstName.Text = "First Name";
            // 
            // tboxLastNameResults
            // 
            this.tboxLastNameResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxLastNameResults.Location = new System.Drawing.Point(80, 40);
            this.tboxLastNameResults.Name = "tboxLastNameResults";
            this.tboxLastNameResults.ReadOnly = true;
            this.tboxLastNameResults.Size = new System.Drawing.Size(106, 20);
            this.tboxLastNameResults.TabIndex = 8;
            this.tboxLastNameResults.TabStop = false;
            // 
            // lblResultsLastName
            // 
            this.lblResultsLastName.AutoSize = true;
            this.lblResultsLastName.Location = new System.Drawing.Point(11, 44);
            this.lblResultsLastName.Name = "lblResultsLastName";
            this.lblResultsLastName.Size = new System.Drawing.Size(58, 13);
            this.lblResultsLastName.TabIndex = 9;
            this.lblResultsLastName.Text = "Last Name";
            // 
            // tboxMessage
            // 
            this.tboxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxMessage.Location = new System.Drawing.Point(10, 29);
            this.tboxMessage.Name = "tboxMessage";
            this.tboxMessage.ReadOnly = true;
            this.tboxMessage.Size = new System.Drawing.Size(204, 20);
            this.tboxMessage.TabIndex = 11;
            this.tboxMessage.TabStop = false;
            this.tboxMessage.Visible = false;
            // 
            // tboxUserNameResults
            // 
            this.tboxUserNameResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxUserNameResults.Location = new System.Drawing.Point(80, 104);
            this.tboxUserNameResults.Name = "tboxUserNameResults";
            this.tboxUserNameResults.ReadOnly = true;
            this.tboxUserNameResults.Size = new System.Drawing.Size(106, 20);
            this.tboxUserNameResults.TabIndex = 12;
            this.tboxUserNameResults.TabStop = false;
            // 
            // lblResultsUsername
            // 
            this.lblResultsUsername.AutoSize = true;
            this.lblResultsUsername.Location = new System.Drawing.Point(13, 108);
            this.lblResultsUsername.Name = "lblResultsUsername";
            this.lblResultsUsername.Size = new System.Drawing.Size(55, 13);
            this.lblResultsUsername.TabIndex = 13;
            this.lblResultsUsername.Text = "Username";
            // 
            // lblFirstNameSearch
            // 
            this.lblFirstNameSearch.AutoSize = true;
            this.lblFirstNameSearch.Location = new System.Drawing.Point(25, 29);
            this.lblFirstNameSearch.Name = "lblFirstNameSearch";
            this.lblFirstNameSearch.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameSearch.TabIndex = 14;
            this.lblFirstNameSearch.Text = "First Name";
            // 
            // tboxFirstNameSearch
            // 
            this.tboxFirstNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxFirstNameSearch.Location = new System.Drawing.Point(83, 25);
            this.tboxFirstNameSearch.MaxLength = 20;
            this.tboxFirstNameSearch.Name = "tboxFirstNameSearch";
            this.tboxFirstNameSearch.Size = new System.Drawing.Size(116, 20);
            this.tboxFirstNameSearch.TabIndex = 15;
            this.tboxFirstNameSearch.TextChanged += new System.EventHandler(this.tboxFirstNameSearch_txtChange);
            // 
            // tboxLastNameSearch
            // 
            this.tboxLastNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxLastNameSearch.Location = new System.Drawing.Point(83, 61);
            this.tboxLastNameSearch.MaxLength = 20;
            this.tboxLastNameSearch.Name = "tboxLastNameSearch";
            this.tboxLastNameSearch.Size = new System.Drawing.Size(116, 20);
            this.tboxLastNameSearch.TabIndex = 16;
            this.tboxLastNameSearch.TextChanged += new System.EventHandler(this.tboxLastNameSearch_txtChange);
            // 
            // lblLastNameSearch
            // 
            this.lblLastNameSearch.AutoSize = true;
            this.lblLastNameSearch.Location = new System.Drawing.Point(25, 65);
            this.lblLastNameSearch.Name = "lblLastNameSearch";
            this.lblLastNameSearch.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameSearch.TabIndex = 17;
            this.lblLastNameSearch.Text = "Last Name";
            // 
            // lblResultsFullName
            // 
            this.lblResultsFullName.AutoSize = true;
            this.lblResultsFullName.Location = new System.Drawing.Point(13, 75);
            this.lblResultsFullName.Name = "lblResultsFullName";
            this.lblResultsFullName.Size = new System.Drawing.Size(54, 13);
            this.lblResultsFullName.TabIndex = 18;
            this.lblResultsFullName.Text = "Full Name";
            // 
            // tboxFullNameResults
            // 
            this.tboxFullNameResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxFullNameResults.Location = new System.Drawing.Point(80, 71);
            this.tboxFullNameResults.Name = "tboxFullNameResults";
            this.tboxFullNameResults.ReadOnly = true;
            this.tboxFullNameResults.Size = new System.Drawing.Size(106, 20);
            this.tboxFullNameResults.TabIndex = 19;
            this.tboxFullNameResults.TabStop = false;
            // 
            // chkboxError
            // 
            this.chkboxError.AutoSize = true;
            this.chkboxError.Location = new System.Drawing.Point(91, 6);
            this.chkboxError.Name = "chkboxError";
            this.chkboxError.Size = new System.Drawing.Size(48, 17);
            this.chkboxError.TabIndex = 20;
            this.chkboxError.TabStop = false;
            this.chkboxError.Text = "Error";
            this.chkboxError.UseVisualStyleBackColor = true;
            this.chkboxError.Visible = false;
            // 
            // chkBoxLockedOut
            // 
            this.chkBoxLockedOut.AutoCheck = false;
            this.chkBoxLockedOut.AutoSize = true;
            this.chkBoxLockedOut.Location = new System.Drawing.Point(30, 21);
            this.chkBoxLockedOut.Name = "chkBoxLockedOut";
            this.chkBoxLockedOut.Size = new System.Drawing.Size(82, 17);
            this.chkBoxLockedOut.TabIndex = 26;
            this.chkBoxLockedOut.TabStop = false;
            this.chkBoxLockedOut.Text = "Locked Out";
            this.chkBoxLockedOut.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(56, 61);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(121, 23);
            this.btnChangePassword.TabIndex = 28;
            this.btnChangePassword.TabStop = false;
            this.btnChangePassword.Text = "Change Password";
            this.ChangePasswordToolTip.SetToolTip(this.btnChangePassword, "Changes the user\'s password.");
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tboxNewPassword
            // 
            this.tboxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxNewPassword.Location = new System.Drawing.Point(91, 33);
            this.tboxNewPassword.Name = "tboxNewPassword";
            this.tboxNewPassword.Size = new System.Drawing.Size(123, 20);
            this.tboxNewPassword.TabIndex = 29;
            this.tboxNewPassword.TabStop = false;
            this.NewPasswordToolTip.SetToolTip(this.tboxNewPassword, "Must include atleast 7 characters, capital letter and a number or symbol");
            // 
            // lblLastLogin
            // 
            this.lblLastLogin.AutoSize = true;
            this.lblLastLogin.Location = new System.Drawing.Point(28, 44);
            this.lblLastLogin.Name = "lblLastLogin";
            this.lblLastLogin.Size = new System.Drawing.Size(56, 13);
            this.lblLastLogin.TabIndex = 30;
            this.lblLastLogin.Text = "Last Login";
            // 
            // lblLastFailedLogin
            // 
            this.lblLastFailedLogin.AutoSize = true;
            this.lblLastFailedLogin.Location = new System.Drawing.Point(13, 75);
            this.lblLastFailedLogin.Name = "lblLastFailedLogin";
            this.lblLastFailedLogin.Size = new System.Drawing.Size(87, 13);
            this.lblLastFailedLogin.TabIndex = 31;
            this.lblLastFailedLogin.Text = "Last Failed Login";
            // 
            // lblLockOutTime
            // 
            this.lblLockOutTime.AutoSize = true;
            this.lblLockOutTime.Location = new System.Drawing.Point(18, 108);
            this.lblLockOutTime.Name = "lblLockOutTime";
            this.lblLockOutTime.Size = new System.Drawing.Size(77, 13);
            this.lblLockOutTime.TabIndex = 32;
            this.lblLockOutTime.Text = "Lock Out Time";
            // 
            // lblFailedLogins
            // 
            this.lblFailedLogins.AutoSize = true;
            this.lblFailedLogins.Location = new System.Drawing.Point(22, 15);
            this.lblFailedLogins.Name = "lblFailedLogins";
            this.lblFailedLogins.Size = new System.Drawing.Size(69, 13);
            this.lblFailedLogins.TabIndex = 33;
            this.lblFailedLogins.Text = "Failed Logins";
            // 
            // tboxLastFailedLogin
            // 
            this.tboxLastFailedLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxLastFailedLogin.Location = new System.Drawing.Point(107, 71);
            this.tboxLastFailedLogin.Name = "tboxLastFailedLogin";
            this.tboxLastFailedLogin.ReadOnly = true;
            this.tboxLastFailedLogin.Size = new System.Drawing.Size(136, 20);
            this.tboxLastFailedLogin.TabIndex = 34;
            this.tboxLastFailedLogin.TabStop = false;
            // 
            // tboxLastLogin
            // 
            this.tboxLastLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxLastLogin.Location = new System.Drawing.Point(107, 40);
            this.tboxLastLogin.Name = "tboxLastLogin";
            this.tboxLastLogin.ReadOnly = true;
            this.tboxLastLogin.Size = new System.Drawing.Size(136, 20);
            this.tboxLastLogin.TabIndex = 35;
            this.tboxLastLogin.TabStop = false;
            // 
            // tBoxFailedLogins
            // 
            this.tBoxFailedLogins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxFailedLogins.Location = new System.Drawing.Point(107, 11);
            this.tBoxFailedLogins.Name = "tBoxFailedLogins";
            this.tBoxFailedLogins.ReadOnly = true;
            this.tBoxFailedLogins.Size = new System.Drawing.Size(136, 20);
            this.tBoxFailedLogins.TabIndex = 36;
            this.tBoxFailedLogins.TabStop = false;
            // 
            // tboxLockOutTime
            // 
            this.tboxLockOutTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxLockOutTime.Location = new System.Drawing.Point(107, 104);
            this.tboxLockOutTime.Name = "tboxLockOutTime";
            this.tboxLockOutTime.ReadOnly = true;
            this.tboxLockOutTime.Size = new System.Drawing.Size(136, 20);
            this.tboxLockOutTime.TabIndex = 37;
            this.tboxLockOutTime.TabStop = false;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(8, 37);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lblNewPassword.TabIndex = 39;
            this.lblNewPassword.Text = "New Password";
            // 
            // chkBoxEnabled
            // 
            this.chkBoxEnabled.AutoCheck = false;
            this.chkBoxEnabled.AutoSize = true;
            this.chkBoxEnabled.Location = new System.Drawing.Point(39, 50);
            this.chkBoxEnabled.Name = "chkBoxEnabled";
            this.chkBoxEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkBoxEnabled.TabIndex = 40;
            this.chkBoxEnabled.TabStop = false;
            this.chkBoxEnabled.Text = "Enabled";
            this.chkBoxEnabled.UseVisualStyleBackColor = true;
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(32, 44);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(78, 23);
            this.btnDisable.TabIndex = 41;
            this.btnDisable.TabStop = false;
            this.btnDisable.Text = "Disable";
            this.DisableToolTip.SetToolTip(this.btnDisable, "Disables the user\'s account.");
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(32, 73);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(78, 23);
            this.btnEnable.TabIndex = 42;
            this.btnEnable.TabStop = false;
            this.btnEnable.Text = "Enable";
            this.EnableToolTip.SetToolTip(this.btnEnable, "Enables the user\'s account.");
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(32, 15);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(78, 23);
            this.btnUnlock.TabIndex = 43;
            this.btnUnlock.TabStop = false;
            this.btnUnlock.Text = "Unlock";
            this.UnlockToolTip.SetToolTip(this.btnUnlock, "Unlocks the user\'s account.");
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // chkBoxDisabled
            // 
            this.chkBoxDisabled.AutoCheck = false;
            this.chkBoxDisabled.AutoSize = true;
            this.chkBoxDisabled.Location = new System.Drawing.Point(38, 79);
            this.chkBoxDisabled.Name = "chkBoxDisabled";
            this.chkBoxDisabled.Size = new System.Drawing.Size(67, 17);
            this.chkBoxDisabled.TabIndex = 44;
            this.chkBoxDisabled.TabStop = false;
            this.chkBoxDisabled.Text = "Disabled";
            this.chkBoxDisabled.UseVisualStyleBackColor = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.cBoxGroupSearch);
            this.pnlSearch.Controls.Add(this.lblGroupSearch);
            this.pnlSearch.Controls.Add(this.tboxFirstNameSearch);
            this.pnlSearch.Controls.Add(this.tboxUsernameSearch);
            this.pnlSearch.Controls.Add(this.lblUserNameSearch);
            this.pnlSearch.Controls.Add(this.lblFirstNameSearch);
            this.pnlSearch.Controls.Add(this.tboxLastNameSearch);
            this.pnlSearch.Controls.Add(this.lblLastNameSearch);
            this.pnlSearch.Controls.Add(this.btnSubmitSearch);
            this.pnlSearch.Location = new System.Drawing.Point(589, 187);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(235, 208);
            this.pnlSearch.TabIndex = 45;
            // 
            // cBoxGroupSearch
            // 
            this.cBoxGroupSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGroupSearch.FormattingEnabled = true;
            this.cBoxGroupSearch.Location = new System.Drawing.Point(83, 128);
            this.cBoxGroupSearch.Name = "cBoxGroupSearch";
            this.cBoxGroupSearch.Size = new System.Drawing.Size(116, 21);
            this.cBoxGroupSearch.TabIndex = 61;
            this.cBoxGroupSearch.SelectedIndexChanged += new System.EventHandler(this.cBoxGroupSearch_SelectedIndexChanged);
            // 
            // lblGroupSearch
            // 
            this.lblGroupSearch.AutoSize = true;
            this.lblGroupSearch.Location = new System.Drawing.Point(36, 128);
            this.lblGroupSearch.Name = "lblGroupSearch";
            this.lblGroupSearch.Size = new System.Drawing.Size(36, 13);
            this.lblGroupSearch.TabIndex = 19;
            this.lblGroupSearch.Text = "Group";
            // 
            // PanelMenu
            // 
            this.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMenu.Controls.Add(this.pnlPassword);
            this.PanelMenu.Controls.Add(this.pnlLogins);
            this.PanelMenu.Controls.Add(this.pnlButtons);
            this.PanelMenu.Controls.Add(this.pnlNames);
            this.PanelMenu.Controls.Add(this.pnlChkBox);
            this.PanelMenu.Location = new System.Drawing.Point(12, 5);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(571, 641);
            this.PanelMenu.TabIndex = 49;
            this.PanelMenu.Visible = false;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPassword.Controls.Add(this.chkBoxChangePassNextLogon);
            this.pnlPassword.Controls.Add(this.btnChangePassword);
            this.pnlPassword.Controls.Add(this.lblNewPassword);
            this.pnlPassword.Controls.Add(this.tboxNewPassword);
            this.pnlPassword.Location = new System.Drawing.Point(157, 263);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(224, 89);
            this.pnlPassword.TabIndex = 46;
            // 
            // chkBoxChangePassNextLogon
            // 
            this.chkBoxChangePassNextLogon.AutoSize = true;
            this.chkBoxChangePassNextLogon.Location = new System.Drawing.Point(31, 10);
            this.chkBoxChangePassNextLogon.Name = "chkBoxChangePassNextLogon";
            this.chkBoxChangePassNextLogon.Size = new System.Drawing.Size(170, 17);
            this.chkBoxChangePassNextLogon.TabIndex = 40;
            this.chkBoxChangePassNextLogon.Text = "Change Password Next Logon";
            this.chkBoxChangePassNextLogon.UseVisualStyleBackColor = true;
            // 
            // pnlLogins
            // 
            this.pnlLogins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogins.Controls.Add(this.lblFailedLogins);
            this.pnlLogins.Controls.Add(this.tBoxFailedLogins);
            this.pnlLogins.Controls.Add(this.tboxLastFailedLogin);
            this.pnlLogins.Controls.Add(this.tboxLockOutTime);
            this.pnlLogins.Controls.Add(this.lblLockOutTime);
            this.pnlLogins.Controls.Add(this.lblLastFailedLogin);
            this.pnlLogins.Controls.Add(this.lblLastLogin);
            this.pnlLogins.Controls.Add(this.tboxLastLogin);
            this.pnlLogins.Location = new System.Drawing.Point(302, -1);
            this.pnlLogins.Name = "pnlLogins";
            this.pnlLogins.Size = new System.Drawing.Size(268, 151);
            this.pnlLogins.TabIndex = 49;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.btnUnlock);
            this.pnlButtons.Controls.Add(this.btnEnable);
            this.pnlButtons.Controls.Add(this.btnDisable);
            this.pnlButtons.Location = new System.Drawing.Point(268, 149);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(146, 115);
            this.pnlButtons.TabIndex = 47;
            // 
            // pnlNames
            // 
            this.pnlNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNames.Controls.Add(this.tboxLastNameResults);
            this.pnlNames.Controls.Add(this.tboxFullNameResults);
            this.pnlNames.Controls.Add(this.lblResultsFullName);
            this.pnlNames.Controls.Add(this.lblResultsUsername);
            this.pnlNames.Controls.Add(this.tboxUserNameResults);
            this.pnlNames.Controls.Add(this.lblResultsLastName);
            this.pnlNames.Controls.Add(this.lblResultsFirstName);
            this.pnlNames.Controls.Add(this.tboxFirstNameResults);
            this.pnlNames.Location = new System.Drawing.Point(-1, -1);
            this.pnlNames.Name = "pnlNames";
            this.pnlNames.Size = new System.Drawing.Size(200, 151);
            this.pnlNames.TabIndex = 50;
            // 
            // pnlChkBox
            // 
            this.pnlChkBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChkBox.Controls.Add(this.chkBoxLockedOut);
            this.pnlChkBox.Controls.Add(this.chkBoxDisabled);
            this.pnlChkBox.Controls.Add(this.chkBoxEnabled);
            this.pnlChkBox.Location = new System.Drawing.Point(123, 149);
            this.pnlChkBox.Name = "pnlChkBox";
            this.pnlChkBox.Size = new System.Drawing.Size(146, 115);
            this.pnlChkBox.TabIndex = 48;
            // 
            // pnlMessage
            // 
            this.pnlMessage.Controls.Add(this.chkboxError);
            this.pnlMessage.Controls.Add(this.tboxMessage);
            this.pnlMessage.Location = new System.Drawing.Point(590, 452);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(235, 59);
            this.pnlMessage.TabIndex = 51;
            this.pnlMessage.Visible = false;
            // 
            // lblGroupUser
            // 
            this.lblGroupUser.AutoSize = true;
            this.lblGroupUser.Location = new System.Drawing.Point(72, 15);
            this.lblGroupUser.Name = "lblGroupUser";
            this.lblGroupUser.Size = new System.Drawing.Size(41, 13);
            this.lblGroupUser.TabIndex = 53;
            this.lblGroupUser.Text = "Groups";
            // 
            // pnlUserGroups
            // 
            this.pnlUserGroups.Controls.Add(this.richTboxGroups);
            this.pnlUserGroups.Controls.Add(this.lblGroupUser);
            this.pnlUserGroups.Location = new System.Drawing.Point(18, 363);
            this.pnlUserGroups.Name = "pnlUserGroups";
            this.pnlUserGroups.Size = new System.Drawing.Size(191, 280);
            this.pnlUserGroups.TabIndex = 62;
            this.pnlUserGroups.Visible = false;
            // 
            // richTboxGroups
            // 
            this.richTboxGroups.Location = new System.Drawing.Point(3, 41);
            this.richTboxGroups.Name = "richTboxGroups";
            this.richTboxGroups.Size = new System.Drawing.Size(185, 239);
            this.richTboxGroups.TabIndex = 52;
            this.richTboxGroups.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Disabled Users";
            // 
            // pnlDisabledUsers
            // 
            this.pnlDisabledUsers.Controls.Add(this.richTboxDisabledUsers);
            this.pnlDisabledUsers.Controls.Add(this.label1);
            this.pnlDisabledUsers.Location = new System.Drawing.Point(386, 363);
            this.pnlDisabledUsers.Name = "pnlDisabledUsers";
            this.pnlDisabledUsers.Size = new System.Drawing.Size(191, 280);
            this.pnlDisabledUsers.TabIndex = 65;
            this.pnlDisabledUsers.Visible = false;
            // 
            // richTboxDisabledUsers
            // 
            this.richTboxDisabledUsers.Location = new System.Drawing.Point(3, 41);
            this.richTboxDisabledUsers.Name = "richTboxDisabledUsers";
            this.richTboxDisabledUsers.Size = new System.Drawing.Size(183, 239);
            this.richTboxDisabledUsers.TabIndex = 52;
            this.richTboxDisabledUsers.Text = "";
            // 
            // pnlEnabledUsers
            // 
            this.pnlEnabledUsers.Controls.Add(this.richTboxEnabledUsers);
            this.pnlEnabledUsers.Controls.Add(this.lblEnabledUsers);
            this.pnlEnabledUsers.Location = new System.Drawing.Point(196, 363);
            this.pnlEnabledUsers.Name = "pnlEnabledUsers";
            this.pnlEnabledUsers.Size = new System.Drawing.Size(191, 280);
            this.pnlEnabledUsers.TabIndex = 67;
            this.pnlEnabledUsers.Visible = false;
            // 
            // richTboxEnabledUsers
            // 
            this.richTboxEnabledUsers.Location = new System.Drawing.Point(3, 40);
            this.richTboxEnabledUsers.Name = "richTboxEnabledUsers";
            this.richTboxEnabledUsers.Size = new System.Drawing.Size(184, 243);
            this.richTboxEnabledUsers.TabIndex = 68;
            this.richTboxEnabledUsers.Text = "";
            // 
            // lblEnabledUsers
            // 
            this.lblEnabledUsers.AutoSize = true;
            this.lblEnabledUsers.Location = new System.Drawing.Point(53, 15);
            this.lblEnabledUsers.Name = "lblEnabledUsers";
            this.lblEnabledUsers.Size = new System.Drawing.Size(76, 13);
            this.lblEnabledUsers.TabIndex = 67;
            this.lblEnabledUsers.Text = "Enabled Users";
            // 
            // UserManagement
            // 
            this.AcceptButton = this.btnSubmitSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 649);
            this.Controls.Add(this.pnlEnabledUsers);
            this.Controls.Add(this.pnlUserGroups);
            this.Controls.Add(this.pnlDisabledUsers);
            this.Controls.Add(this.pnlMessage);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManagement";
            this.Text = "User Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed_Click);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlLogins.ResumeLayout(false);
            this.pnlLogins.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlNames.ResumeLayout(false);
            this.pnlNames.PerformLayout();
            this.pnlChkBox.ResumeLayout(false);
            this.pnlChkBox.PerformLayout();
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            this.pnlUserGroups.ResumeLayout(false);
            this.pnlUserGroups.PerformLayout();
            this.pnlDisabledUsers.ResumeLayout(false);
            this.pnlDisabledUsers.PerformLayout();
            this.pnlEnabledUsers.ResumeLayout(false);
            this.pnlEnabledUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.TextBox tboxUsernameSearch;
        private System.Windows.Forms.Label lblUserNameSearch;
        private System.Windows.Forms.Button btnSubmitSearch;
        private System.Windows.Forms.TextBox tboxFirstNameResults;
        private System.Windows.Forms.Label lblResultsFirstName;
        private System.Windows.Forms.TextBox tboxLastNameResults;
        private System.Windows.Forms.Label lblResultsLastName;
        private System.Windows.Forms.TextBox tboxMessage;
        private System.Windows.Forms.TextBox tboxUserNameResults;
        private System.Windows.Forms.Label lblResultsUsername;
        private System.Windows.Forms.Label lblFirstNameSearch;
        private System.Windows.Forms.TextBox tboxFirstNameSearch;
        private System.Windows.Forms.TextBox tboxLastNameSearch;
        private System.Windows.Forms.Label lblLastNameSearch;
        private System.Windows.Forms.Label lblResultsFullName;
        private System.Windows.Forms.TextBox tboxFullNameResults;
        private System.Windows.Forms.CheckBox chkboxError;
        private System.Windows.Forms.CheckBox chkBoxLockedOut;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox tboxNewPassword;
        private System.Windows.Forms.Label lblLastLogin;
        private System.Windows.Forms.Label lblLastFailedLogin;
        private System.Windows.Forms.Label lblLockOutTime;
        private System.Windows.Forms.Label lblFailedLogins;
        private System.Windows.Forms.TextBox tboxLastFailedLogin;
        private System.Windows.Forms.TextBox tboxLastLogin;
        private System.Windows.Forms.TextBox tBoxFailedLogins;
        private System.Windows.Forms.TextBox tboxLockOutTime;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.CheckBox chkBoxEnabled;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.CheckBox chkBoxDisabled;
        private System.Windows.Forms.ToolTip UnlockToolTip;
        private System.Windows.Forms.ToolTip ChangePasswordToolTip;
        private System.Windows.Forms.ToolTip DisableToolTip;
        private System.Windows.Forms.ToolTip EnableToolTip;
        private System.Windows.Forms.ToolTip SearchToolTip;
        private System.Windows.Forms.ToolTip NewPasswordToolTip;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel pnlChkBox;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Panel pnlNames;
        private System.Windows.Forms.Panel pnlLogins;
        private System.Windows.Forms.CheckBox chkBoxChangePassNextLogon;
        private System.Windows.Forms.Label lblGroupUser;
        private System.Windows.Forms.Label lblGroupSearch;
        private System.Windows.Forms.ComboBox cBoxGroupSearch;
        private System.Windows.Forms.Panel pnlUserGroups;
        private System.Windows.Forms.Panel pnlDisabledUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEnabledUsers;
        private System.Windows.Forms.Label lblEnabledUsers;
        private System.Windows.Forms.RichTextBox richTboxEnabledUsers;
        private System.Windows.Forms.RichTextBox richTboxGroups;
        private System.Windows.Forms.RichTextBox richTboxDisabledUsers;
    }
}

