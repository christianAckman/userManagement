using System;
using System.Collections.Generic;


namespace MasterApp{
    class BusinessObject : DataAccess{

        #region Private Variables
        private string OU = "Company";
        private string server = "DCServerName1";
        private string DC = "com";

        private Boolean Error = false;
        private string Message = String.Empty;
        private string Domain = String.Empty;
        private string CredentialsUserName = String.Empty;
        private string CredentialsPassword = String.Empty;
        private string FirstName = String.Empty;
        private string LastName = String.Empty;
        private string UserName = String.Empty;
        private string FullName = String.Empty;
        private int ResultCounter = 0;
        private int ResultAmount = 0;

        private string newFirstName = String.Empty;
        private string newLastName = String.Empty;
        private string newUserName = String.Empty;
        private string newPassword = String.Empty;
        private Boolean changePassNextLogin = false;
        private string specifiedGroup = String.Empty;
        private string SearchFilter = String.Empty;
        private string ChangedPassword = String.Empty;
        private bool IsAccountLockedOut = false;
        private bool? AccountEnabled = null;
        private int FailedLoginCount = 0;
        private string LastLoginDate = null;
        private DateTime? LastFailedLoginDate = null;
        private DateTime? LockOutTime = null;
        private List<string> domainDCs = null;
        private List<string> groups = null;
        private List<string> users = null;
        private List<string> disabledUsers = null;
        #endregion

        #region Public Properties
        public bool _Error
        {
            get
            {
                return Error;
            }

            set
            {
                Error = value;
            }
        }
        public string _Message
        {
            get
            {
                return Message;
            }

            set
            {
                Message = value;
            }
        }
        public string _Domain
        {
            get
            {
                return Domain;
            }

            set
            {
                Domain = value;
            }
        }
        public string _Username
        {
            get
            {
                return UserName;
            }

            set
            {
                UserName = value;
            }
        }
        public string _CredentialsPassword
        {
            get
            {
                return CredentialsPassword;
            }

            set
            {
                CredentialsPassword = value;
            }
        }
        public string _CredentialsUsername
        {
            get
            {
                return CredentialsUserName;
            }

            set
            {
                CredentialsUserName = value;
            }
        }
        public string _FirstName
        {
            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }
        }
        public string _LastName
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }
        public string _FullName
        {
            get
            {
                return FullName;
            }

            set
            {
                FullName = value;
            }
        }
        public int _ResultCounter
        {
            get
            {
                return ResultCounter;
            }

            set
            {
                ResultCounter = value;
            }
        }
        public int _ResultAmount
        {
            get
            {
                return ResultAmount;
            }

            set
            {
                ResultAmount = value;
            }
        }

        public string _SearchFilter
        {
            get
            {
                return SearchFilter;
            }

            set
            {
                SearchFilter = value;
            }
        }
        public string _ChangedPassword
        {
            get
            {
                return ChangedPassword;
            }

            set
            {
                ChangedPassword = value;
            }
        }
        public bool _IsAccountLockedOut
        {
            get
            {
                return IsAccountLockedOut;
            }

            set
            {
                IsAccountLockedOut = value;
            }
        }
        public bool? _AccountEnabled
        {
            get
            {
                return AccountEnabled;
            }

            set
            {
                AccountEnabled = value;
            }
        }
        public int _FailedLoginCount
        {
            get
            {
                return FailedLoginCount;
            }

            set
            {
                FailedLoginCount = value;
            }
        }


        public string _LastLoginDate
        {
            get
            {
                return LastLoginDate;
            }

            set
            {
                LastLoginDate = value;
            }
        }
        public DateTime? _LastFailedLoginDate
        {
            get
            {
                return LastFailedLoginDate;
            }

            set
            {
                LastFailedLoginDate = value;
            }
        }
        public DateTime? _LockOutTime
        {
            get
            {
                return LockOutTime;
            }

            set
            {
                LockOutTime = value;
            }
        }

        public List<string> _DomainDCs
        {
            get
            {
                return domainDCs;
            }

            set
            {
                domainDCs = value;
            }
        }
        public List<string> _Groups
        {
            get
            {
                return groups;
            }

            set
            {
                groups = value;
            }
        }
        public List<string> _Users
        {
            get
            {
                return users;
            }

            set
            {
                users = value;
            }
        }

        public string _SpecifiedGroup
        {
            get
            {
                return specifiedGroup;
            }

            set
            {
                specifiedGroup = value;
            }
        }

        public bool _ChangePassNextLogin
        {
            get
            {
                return changePassNextLogin;
            }

            set
            {
                changePassNextLogin = value;
            }
        }

        public string _NewUserName
        {
            get
            {
                return newUserName;
            }

            set
            {
                newUserName = value;
            }
        }
        public string _NewPassword
        {
            get
            {
                return newPassword;
            }

            set
            {
                newPassword = value;
            }
        }
        public string _NewFirstName
        {
            get
            {
                return newFirstName;
            }

            set
            {
                newFirstName = value;
            }
        }
        public string _NewLastName
        {
            get
            {
                return newLastName;
            }

            set
            {
                newLastName = value;
            }
        }

        public List<string> _DisabledUsers
        {
            get
            {
                return disabledUsers;
            }

            set
            {
                disabledUsers = value;
            }
        }

        public string _OU
        {
            get
            {
                return OU;
            }

            set
            {
                OU = value;
            }
        }

        public string _Server
        {
            get
            {
                return server;
            }

            set
            {
                server = value;
            }
        }

        public string _DC
        {
            get
            {
                return DC;
            }

            set
            {
                DC = value;
            }
        }



        #endregion


        #region Completed

        public new Boolean enableUser(BusinessObject obj){
            base.enableUser(obj);
            return _Error;
        }
        public new Boolean disableUser(BusinessObject obj){
            base.disableUser(obj);
            return _Error;
        }
        public new Boolean unlockUser(BusinessObject obj){
            base.unlockUser(obj);
            return _Error;
        }
        public new Boolean getUserData(BusinessObject obj){
            base.getUserData(obj);
            return _Error;
        }
        public new Boolean changePassword(BusinessObject obj){
            base.changePassword(obj);
            return _Error;
        }
        public new Boolean findUserNameSearchByFirst(BusinessObject obj){
            base.findUserNameSearchByFirst(obj);
            return _Error;
        }
        public new Boolean findUserNameSearchByLast(BusinessObject obj){
            base.findUserNameSearchByLast(obj);
            return _Error;
        }
        public new Boolean getLastFailedLoginDate(BusinessObject obj){
            base.getLastFailedLoginDate(obj);
            return _Error;
        }
        public new Boolean getLockOutTime(BusinessObject obj){
            base.findUserNameSearchByFirst(obj);
            return _Error;
        }
        public new Boolean getFailedLoginCount(BusinessObject obj){
            base.getFailedLoginCount(obj);
            return _Error;
        }
        public new Boolean isAccountEnabled(BusinessObject obj){
            base.isAccountEnabled(obj);
            return _Error;
        }
        public new Boolean isAccountLockedOut(BusinessObject obj){
            base.isAccountLockedOut(obj);
            return _Error;
        }
        public new Boolean getGroups(BusinessObject obj){
            base.getGroups(obj);

            return obj._Error;
        }
        public new Boolean getDomainControllers(BusinessObject obj)
        {
            base.getDomainControllers(obj);
            return _Error;
        }

        #endregion





        public new Boolean getEnabledUsersInGroup(BusinessObject obj){
            base.getEnabledUsersInGroup(obj);
            return _Error;
        }



        public new Boolean getAllGroups(BusinessObject obj){
            base.getAllGroups(obj);
            return _Error;
        }


        public new Boolean getDisabledUsersInGroup(BusinessObject obj){
            base.getDisabledUsersInGroup(obj);
            return _Error;
        }




    }
}
