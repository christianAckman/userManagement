using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MasterApp {
    public partial class UserManagementView : Form {


        public UserManagementView(string username, string password) {        // To enter credentials
            credentialsUsername = username;
            credentialsPassword = password;
            InitializeComponent();
        }


        public UserManagementView() {         // To log in with logged in user
            InitializeComponent();

            BusinessObject obj = new BusinessObject();
            obj.getAllGroups(obj);

            cBoxGroupSearch.Items.Add("");
            foreach (String group in obj._Groups) {
                cBoxGroupSearch.Items.Add(group);
            }
        }


        private string credentialsUsername = String.Empty;
        private string credentialsPassword = String.Empty;






        #region Search Button
        // Search Button
        private void btnSearch_Click(object sender, EventArgs e) {

            richTboxEnabledUsers.Clear();
            richTboxDisabledUsers.Clear();
            richTboxGroups.Clear();
            clearAllTextBox();
            clearAllChkBox();

            BusinessObject obj = new BusinessObject();

            #region Get Data
            // First and Last
            if (!String.IsNullOrEmpty(tboxFirstNameSearch.Text) && !String.IsNullOrEmpty(tboxLastNameSearch.Text)) {
                tboxUsernameSearch.Enabled = false;
                obj._FirstName = tboxFirstNameSearch.Text;
                obj._LastName = tboxLastNameSearch.Text;
                obj.getUserData(obj);
            }

            // Last and User
            else if (!String.IsNullOrEmpty(tboxLastNameSearch.Text) && !String.IsNullOrEmpty(tboxUsernameSearch.Text)) {
                tboxFirstNameSearch.Enabled = false;
                obj._LastName = tboxLastNameSearch.Text;
                obj._Username = tboxUsernameSearch.Text;
                obj.getUserData(obj);
            }

            // First and User
            else if (!String.IsNullOrEmpty(tboxFirstNameSearch.Text) && !String.IsNullOrEmpty(tboxUsernameSearch.Text)) {
                tboxLastNameSearch.Enabled = false;
                obj._FirstName = tboxFirstNameSearch.Text;
                obj._Username = tboxUsernameSearch.Text;
                obj.getUserData(obj);
            }

            // Username
            else if (tboxUsernameSearch.Text != String.Empty) {
                obj._Username = tboxUsernameSearch.Text;
                obj.getUserData(obj);
            }

            // LastName
            else if (tboxLastNameSearch.Text != String.Empty) {
                obj._LastName = tboxLastNameSearch.Text;
                obj.getUserData(obj);
            }

            // FirstName
            else if (tboxFirstNameSearch.Text != String.Empty) {
                obj._FirstName = tboxFirstNameSearch.Text;
                obj.getUserData(obj);
            }
            #endregion

            // Get User Groups
            if (tboxFirstNameSearch.Text != String.Empty || tboxLastNameSearch.Text != String.Empty || tboxUsernameSearch.Text != String.Empty) {
                obj.getGroups(obj);
                foreach (String group in obj._Groups) {
                    richTboxGroups.Text += group + System.Environment.NewLine;
                }
                pnlUserGroups.Location = new Point(196,363);
                PanelMenu.Visible = true;
            }
            else { // Group Search
                obj.getAllGroups(obj);
                foreach (String group in obj._Groups) {
                    richTboxGroups.Text += group + System.Environment.NewLine;
                }

                pnlUserGroups.Location = new Point(18, 187);
                pnlEnabledUsers.Location = new Point(196, 187);
                pnlDisabledUsers.Location = new Point(386, 187);

                pnlDisabledUsers.Visible = true;
                pnlEnabledUsers.Visible = true;
            }


            if (cBoxGroupSearch.Enabled == true) {
                obj._SpecifiedGroup = cBoxGroupSearch.SelectedItem.ToString();  // Get selected group

                obj.getEnabledUsersInGroup(obj);
                foreach (string user in obj._Users) {
                    richTboxEnabledUsers.Text += user + System.Environment.NewLine;
                }

                obj.getDisabledUsersInGroup(obj);
                foreach (String user in obj._DisabledUsers) {
                    richTboxDisabledUsers.Text += user + System.Environment.NewLine;
                }
            }

            #region Insert Results

            tboxFirstNameResults.Text = obj._FirstName;
            tboxLastNameResults.Text = obj._LastName;
            tboxUserNameResults.Text = obj._Username;
            tboxFullNameResults.Text = obj._FullName;

            tboxLastFailedLogin.Text = obj._LastFailedLoginDate.ToString();
            tboxLastLogin.Text = obj._LastLoginDate;

            #endregion

            #region Error checking
            if (obj._IsAccountLockedOut == true) chkBoxLockedOut.Checked = true;

            if (obj._AccountEnabled == true) chkBoxEnabled.Checked = true;

            if (obj._AccountEnabled == false) chkBoxEnabled.Checked = false;

            if (obj._Error == true) {
                clearAllTextBox();
                clearAllChkBox();
                chkboxError.Checked = true;
                tboxMessage.Text = obj._Message;
            }

            #endregion

            #region Align Textbox Text

            tboxUserNameResults.TextAlign = HorizontalAlignment.Center;
            tboxFirstNameResults.TextAlign = HorizontalAlignment.Center;
            tboxLastNameResults.TextAlign = HorizontalAlignment.Center;
            tboxFullNameResults.TextAlign = HorizontalAlignment.Center;
            tboxLockOutTime.TextAlign = HorizontalAlignment.Center;
            tboxLastLogin.TextAlign = HorizontalAlignment.Center;
            tboxLastFailedLogin.TextAlign = HorizontalAlignment.Center;
            tBoxFailedLogins.TextAlign = HorizontalAlignment.Center;
            tboxMessage.TextAlign = HorizontalAlignment.Center;





            richTboxGroups.SelectAll();
            richTboxGroups.SelectionAlignment = HorizontalAlignment.Center;

            richTboxEnabledUsers.SelectAll();
            richTboxEnabledUsers.SelectionAlignment = HorizontalAlignment.Center;

            richTboxDisabledUsers.SelectAll();
            richTboxDisabledUsers.SelectionAlignment = HorizontalAlignment.Center;
            
            #endregion





            pnlUserGroups.Visible = true;
            pnlMessage.Visible = true;




        }
        #endregion





        #region Controls
        private void clearAllTextBoxMenu() {
            foreach (Control c in PanelMenu.Controls) {
                foreach (Control ctrl in c.Controls)
                    if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(RichTextBox)) {
                        ctrl.Text = String.Empty;
                    }
            }
        }

        


        private void clearAllTextBox(){
            foreach (Control ctrl in this.Controls){
                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(RichTextBox)){
                    ctrl.Text = String.Empty;
                }
            }
            clearAllTextBoxMenu();
        }
    

        private void clearAllChkBox() {
            foreach (Control c in PanelMenu.Controls) {
                foreach (Control ctrl in c.Controls){
                    if (ctrl.GetType() == typeof(CheckBox)){
                        ((CheckBox)ctrl).Checked = false;
                    }
                }
            }
        }


        private void changeToReadOnly() {
            foreach (Control c in this.Controls) {
                if (c.GetType() == typeof(System.Windows.Forms.TextBox)) {
                    foreach (Control co in this.Controls) {
                        if (c.Text != null) {
                            c.Enabled = false;
                        }
                    }
                }
            }
        }
        #endregion


        #region Text Changed
        private void tboxUsernameSearch_txtChange(object sender, EventArgs e){
            btnSubmitSearch.Enabled = true;
            tboxUsernameSearch.Enabled = true;
            tboxFirstNameSearch.Enabled = true;
            tboxLastNameSearch.Enabled = true;
            cBoxGroupSearch.Enabled = false;
            cBoxGroupSearch.Text = "";

            // First and Last
            if (!String.IsNullOrEmpty(tboxFirstNameSearch.Text) && !String.IsNullOrEmpty(tboxLastNameSearch.Text)){
                tboxUsernameSearch.Enabled = false;
            }

            // Last and User
            if (!String.IsNullOrEmpty(tboxUsernameSearch.Text) && !String.IsNullOrEmpty(tboxLastNameSearch.Text)){
                tboxFirstNameSearch.Enabled = false;
            }

            // First and User
            if (!String.IsNullOrEmpty(tboxFirstNameSearch.Text) && !String.IsNullOrEmpty(tboxUsernameSearch.Text)){
                tboxLastNameSearch.Enabled = false;
            }

            // All empty
            if (String.IsNullOrEmpty(tboxFirstNameSearch.Text) && String.IsNullOrEmpty(tboxUsernameSearch.Text) && String.IsNullOrEmpty(tboxLastNameSearch.Text)){
                PanelMenu.Visible = false;
                pnlUserGroups.Visible = false;
                clearAllTextBox();
                clearAllChkBox();
                btnSubmitSearch.Enabled = false;
                tboxUsernameSearch.Enabled = true;
                tboxFirstNameSearch.Enabled = true;
                tboxLastNameSearch.Enabled = true;
                cBoxGroupSearch.Enabled = true;
            }
        }


        private void tboxLastNameSearch_txtChange(object sender, EventArgs e) {
            btnSubmitSearch.Enabled = true;
            tboxUsernameSearch.Enabled = true;
            tboxFirstNameSearch.Enabled = true;
            tboxLastNameSearch.Enabled = true;
            cBoxGroupSearch.Enabled = false;
            cBoxGroupSearch.Text = "";

            // First and Last
            if (!String.IsNullOrEmpty(tboxFirstNameSearch.Text) && !String.IsNullOrEmpty(tboxLastNameSearch.Text)){
                tboxUsernameSearch.Enabled = false;
            }

            // Last and User
            if (!String.IsNullOrEmpty(tboxUsernameSearch.Text) && !String.IsNullOrEmpty(tboxLastNameSearch.Text)){
                tboxFirstNameSearch.Enabled = false;
            }

            // First and User
            if (!String.IsNullOrEmpty(tboxFirstNameSearch.Text) && !String.IsNullOrEmpty(tboxUsernameSearch.Text)){
                tboxLastNameSearch.Enabled = false;
            }

            // All empty
            if (String.IsNullOrEmpty(tboxFirstNameSearch.Text) && String.IsNullOrEmpty(tboxUsernameSearch.Text) && String.IsNullOrEmpty(tboxLastNameSearch.Text)){
                PanelMenu.Visible = false;
                pnlUserGroups.Visible = false;
                clearAllTextBox();
                clearAllChkBox();
                btnSubmitSearch.Enabled = false;
                tboxUsernameSearch.Enabled = true;
                tboxFirstNameSearch.Enabled = true;
                tboxLastNameSearch.Enabled = true;
                cBoxGroupSearch.Enabled = true;
            }

        }



        private void tboxFirstNameSearch_txtChange(object sender, EventArgs e) {
            btnSubmitSearch.Enabled = true;
            tboxUsernameSearch.Enabled = true;
            tboxFirstNameSearch.Enabled = true;
            tboxLastNameSearch.Enabled = true;
            cBoxGroupSearch.Enabled = false;
            cBoxGroupSearch.Text = "";

            // First and Last
            if (!String.IsNullOrEmpty(tboxFirstNameSearch.Text) && !String.IsNullOrEmpty(tboxLastNameSearch.Text)){
                tboxUsernameSearch.Enabled = false;
            }

            // Last and User
            if (!String.IsNullOrEmpty(tboxUsernameSearch.Text) && !String.IsNullOrEmpty(tboxLastNameSearch.Text)){
                tboxFirstNameSearch.Enabled = false;
            }

            // First and User
            if (!String.IsNullOrEmpty(tboxFirstNameSearch.Text) && !String.IsNullOrEmpty(tboxUsernameSearch.Text)){
                tboxLastNameSearch.Enabled = false;
            }

            // All empty
            if (String.IsNullOrEmpty(tboxFirstNameSearch.Text) && String.IsNullOrEmpty(tboxUsernameSearch.Text) && String.IsNullOrEmpty(tboxLastNameSearch.Text)){
                PanelMenu.Visible = false;
                pnlUserGroups.Visible = false;
                clearAllTextBox();
                clearAllChkBox();
                btnSubmitSearch.Enabled = false;
                tboxUsernameSearch.Enabled = true;
                tboxFirstNameSearch.Enabled = true;
                tboxLastNameSearch.Enabled = true;
                cBoxGroupSearch.Enabled = true;
            }
        }

        #endregion



        #region Buttons

        private void btnUnlock_Click(object sender, EventArgs e) {

            BusinessObject obj = new BusinessObject();

            if (tboxUsernameSearch.Text != String.Empty) {
                obj._Username = tboxUsernameSearch.Text;
            }

            else if (tboxLastNameSearch.Text != String.Empty) {
                obj._LastName = tboxLastNameSearch.Text;
                obj.findUserNameSearchByLast(obj);
            }

            else if (tboxFirstNameSearch.Text != String.Empty) {
                obj._FirstName = tboxFirstNameSearch.Text;
                obj.findUserNameSearchByFirst(obj);
            }

            obj.unlockUser(obj);


            if (obj._Error == false) {
                chkBoxLockedOut.Checked = false;
                tboxMessage.Text = obj._Message;
                chkboxError.Checked = false;
            }

            if (obj._Error == true) {
                chkboxError.Checked = true;
                tboxMessage.Text = obj._Message;
            }
        }




        private void btnEnable_Click(object sender, EventArgs e) {
            BusinessObject obj = new BusinessObject();

            if (tboxUsernameSearch.Text != String.Empty) {
                obj._Username = tboxUsernameSearch.Text;
            }

            else if (tboxLastNameSearch.Text != String.Empty) {
                obj._LastName = tboxLastNameSearch.Text;
                obj.findUserNameSearchByLast(obj);
            }

            else if (tboxFirstNameSearch.Text != String.Empty) {
                obj._FirstName = tboxFirstNameSearch.Text;
                obj.findUserNameSearchByFirst(obj);
            }

            obj.enableUser(obj);


            if (obj._Error == false) {
                chkBoxEnabled.Checked = true;
                tboxMessage.Text = obj._Message;
                chkboxError.Checked = false;
                chkBoxDisabled.Checked = false;
            }

            if (obj._Error == true) {
                chkboxError.Checked = true;
                tboxMessage.Text = obj._Message;
            }
        }





        private void btnDisable_Click(object sender, EventArgs e) {
            BusinessObject obj = new BusinessObject();

            if (tboxUsernameSearch.Text != String.Empty) {
                obj._Username = tboxUsernameSearch.Text;
            }

            else if (tboxLastNameSearch.Text != String.Empty) {
                obj._LastName = tboxLastNameSearch.Text;
                obj.findUserNameSearchByLast(obj);
            }

            else if (tboxFirstNameSearch.Text != String.Empty) {
                obj._FirstName = tboxFirstNameSearch.Text;
                obj.findUserNameSearchByFirst(obj);
            }


            obj.disableUser(obj);


            if (obj._Error == false) {
                chkBoxEnabled.Checked = false;
                tboxMessage.Text = obj._Message;
                chkboxError.Checked = false;
                chkBoxDisabled.Checked = true;
            }

            if (obj._Error == true) {
                chkboxError.Checked = true;
                tboxMessage.Text = obj._Message;
            }
        }



        private void btnChangePassword_Click(object sender, EventArgs e) {
            BusinessObject obj = new BusinessObject();

            if (tboxUsernameSearch.Text != String.Empty) {
                obj._Username = tboxUsernameSearch.Text;
            }

            else if (tboxLastNameSearch.Text != String.Empty) {
                obj._LastName = tboxLastNameSearch.Text;
                obj.findUserNameSearchByLast(obj);
            }

            else if (tboxFirstNameSearch.Text != String.Empty) {
                obj._FirstName = tboxFirstNameSearch.Text;
                obj.findUserNameSearchByFirst(obj);
            }

            if (passwordChecker(tboxNewPassword.Text)){
                obj._ChangedPassword = tboxNewPassword.Text;

                if (chkBoxChangePassNextLogon.Checked){
                    obj._ChangePassNextLogin = true;
                }

                obj.changePassword(obj);

                if (obj._Error == false) {
                    chkboxError.Checked = false;
                    tboxMessage.Text = obj._Message;
                }

                if (obj._Error == true) {
                    chkboxError.Checked = true;
                    tboxMessage.Text = obj._Message;
                }

            }
            else {
                MessageBox.Show("Password does not meet requirements.\n\t Requirements: \n\t7 Characters\n\t1 Symbol or Number\n\t1 Capital Letter");
                tboxNewPassword.Text = String.Empty;
            }
        }


        private Boolean passwordChecker(string password) {
            Boolean goodPass;

            if (password.Any(char.IsDigit) &&
                password.Any(char.IsLower) &&
                password.Any(char.IsUpper) &&
                (password.Length > 6)) {
                goodPass = true;
            }
            else {
                goodPass = false;
            }

            return goodPass;
        }
        #endregion







        private void cBoxGroupSearch_SelectedIndexChanged(object sender, EventArgs e){
            if (tboxFirstNameSearch.Text == String.Empty && tboxLastNameSearch.Text == String.Empty && tboxUsernameSearch.Text == String.Empty && (cBoxGroupSearch.SelectedItem.ToString() == "")){
                btnSubmitSearch.Enabled = false;
            }


            if (!String.IsNullOrEmpty(cBoxGroupSearch.SelectedItem.ToString())){
                btnSearch_Click(sender, e);
                pnlUserGroups.Visible = true;
                //pnlUserGroups.Location = new Point(18, 363);
                //btnSubmitSearch.Enabled = true;
            }

            if(tboxFirstNameSearch.Text != String.Empty || tboxLastNameSearch.Text != String.Empty || tboxUsernameSearch.Text != String.Empty){
                cBoxGroupSearch.Enabled = false;
            }

            if(cBoxGroupSearch.SelectedItem.ToString() == ""){

                richTboxEnabledUsers.Clear();
                richTboxDisabledUsers.Clear();
                richTboxGroups.Clear();

                pnlDisabledUsers.Visible = false;
                pnlEnabledUsers.Visible = false;
                pnlUserGroups.Visible = false;
                

                clearAllTextBox();
                clearAllChkBox();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e){

        }

        private void formClosed_Click(object sender, FormClosedEventArgs e){
            Application.Exit();
        }
    }
}