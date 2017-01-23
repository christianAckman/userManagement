using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.AccountManagement;
using ActiveDs;

namespace MasterApp{
    class DataAccess{

        private string connectionString = String.Empty;

        #region Objects
        private DirectoryEntry LDAPConn = null;
        private DirectorySearcher ADSearch = null;

        private PrincipalContext PContext = null;
        private UserPrincipal UPrince = null;
        private PrincipalSearcher PSearch = null;
        //private GroupPrincipal GPrince = null;

        #endregion


        #region Connection

        public Boolean createConnection(BusinessObject obj, string domain, string username, string password){
            connectionString = connectionStringBuilder(domain, username, password);
            try{
                LDAPConn = new DirectoryEntry(connectionString);
                LDAPConn.Path = "LDAP://" + domain;
                LDAPConn.Username = username;
                LDAPConn.Password = password;
                LDAPConn.AuthenticationType = AuthenticationTypes.Secure;
                obj._Error = false;
                return obj._Error;
            }
            catch{
                obj._Message = "Error creating connection";
                obj._Error = true;
                return obj._Error;
            }
        }
        #endregion


        #region Completed



        public Boolean changePassword(BusinessObject obj){
            try{
                PContext = new PrincipalContext(ContextType.Domain); // Connection

                UPrince = new UserPrincipal(PContext); // Search Criteria Filter

                UPrince.SamAccountName = obj._Username; // Search Conditions

                PSearch = new PrincipalSearcher(UPrince); // Set up Searcher


                UPrince = PSearch.FindOne() as UserPrincipal; // Find Result
                UPrince.SetPassword(obj._ChangedPassword);      // Set Password

                if (obj._ChangePassNextLogin){
                    UPrince.ExpirePasswordNow();
                    
                }

                UPrince.Save();                                 // Save Changes

            }
            catch{
                obj._Error = true;
                obj._Message = "Error - Can't change password.";
                return obj._Error;
            }
            obj._Message = "Password changed.";
            obj._Error = false;
            return obj._Error;
        }
        public Boolean findUserNameSearchByFirst(BusinessObject obj){
            try{
                PContext = new PrincipalContext(ContextType.Domain); // Connection

                UPrince = new UserPrincipal(PContext); // Search Criteria Filter

                UPrince.GivenName = obj._FirstName; // Search Conditions - Search by First

                PSearch = new PrincipalSearcher(UPrince); // Set up Searcher

                UPrince = PSearch.FindOne() as UserPrincipal; // Find Result
                obj._Username = UPrince.SamAccountName;
            }
            catch{
                obj._Error = true;
                return obj._Error;
            }
            obj._Error = false;

            return obj._Error;
        }
        public Boolean findUserNameSearchByLast(BusinessObject obj){
            try{
                PContext = new PrincipalContext(ContextType.Domain); // Connection

                UPrince = new UserPrincipal(PContext); // Search Criteria Filter

                UPrince.Surname = obj._LastName; // Search Conditions - Search by Last

                PSearch = new PrincipalSearcher(UPrince); // Set up Searcher

                UPrince = PSearch.FindOne() as UserPrincipal; // Find Result
                obj._Username = UPrince.SamAccountName;
            }
            catch{
                obj._Error = true;
                return obj._Error;
            }
            obj._Error = false;

            return obj._Error;
        }
        public Boolean getLastFailedLoginDate(BusinessObject obj){
            try{
                PContext = new PrincipalContext(ContextType.Domain); // Connection

                UPrince = new UserPrincipal(PContext); // Search Criteria Filter

                UPrince.SamAccountName = obj._Username; // Search Conditions - Search by First


                PSearch = new PrincipalSearcher(UPrince); // Set up Searcher

                UPrince = PSearch.FindOne() as UserPrincipal; // Find Result
                obj._LastFailedLoginDate = UPrince.LastBadPasswordAttempt;
            }
            catch{
                obj._Error = true;
                return obj._Error;
            }
            obj._Error = false;
            return obj._Error;
        }
        public Boolean getLockOutTime(BusinessObject obj){
            try{
                PContext = new PrincipalContext(ContextType.Domain); // Connection

                UPrince = new UserPrincipal(PContext); // Search Criteria Filter

                UPrince.SamAccountName = obj._Username; // Search Conditions - Search by First

                PSearch = new PrincipalSearcher(UPrince); // Set up Searcher

                UPrince = PSearch.FindOne() as UserPrincipal; // Find Result
                obj._LockOutTime = UPrince.AccountLockoutTime;
            }
            catch{
                obj._Error = true;
                return obj._Error;
            }
            obj._Error = false;
            return obj._Error;
        }
        public Boolean getFailedLoginCount(BusinessObject obj) {
            try{
                PContext = new PrincipalContext(ContextType.Domain); // Connection

                UPrince = new UserPrincipal(PContext); // Search Criteria Filter

                UPrince.SamAccountName = obj._Username; // Search Conditions - Search by First


                PSearch = new PrincipalSearcher(UPrince); // Set up Searcher

                UPrince = PSearch.FindOne() as UserPrincipal; // Find Result
                obj._FailedLoginCount = UPrince.BadLogonCount;
            }
            catch{
                obj._Error = true;
                return obj._Error;
            }
            obj._Error = false;
            return obj._Error;
            }
        public Boolean isAccountEnabled(BusinessObject obj){
            try{
                PContext = new PrincipalContext(ContextType.Domain); // Connection

                UPrince = new UserPrincipal(PContext); // Search Criteria Filter

                UPrince.SamAccountName = obj._Username; // Search Conditions - Search by UserName

                PSearch = new PrincipalSearcher(UPrince); // Set up Searcher

                UPrince = PSearch.FindOne() as UserPrincipal; // Find Result
                obj._AccountEnabled = UPrince.Enabled;
            }
            catch{
                obj._Error = true;
                return obj._Error;
            }
            obj._Error = false;

            return obj._Error;
        }
        public Boolean findLastLogin(BusinessObject obj)  // https://www.codeproject.com/kb/security/lastlogonacrossallwindows.aspx
        {
            try{
                LDAPConn = new DirectoryEntry("LDAP://RootDSE");// RootDSE is entire domain

                string configNamingContext = LDAPConn.Properties["configurationNamingContext"].Value.ToString();
                string defaultNamingContext = LDAPConn.Properties["defaultNamingContext"].Value.ToString();



                LDAPConn = new DirectoryEntry("LDAP://" + configNamingContext);
                ADSearch = new DirectorySearcher(LDAPConn);

                ADSearch.Filter = "objectClass=nTDSDSA"; // Targets all DC's
                try{
                    foreach (SearchResult domains in ADSearch.FindAll()){ // Loop through DCs
                        DirectoryEntry entry = domains.GetDirectoryEntry();
                        if (entry != null){
                            string dnsHostName = entry.Parent.Properties["DNSHostName"].Value.ToString(); // Get name of DC aka 'DNSHostName'
                            DirectoryEntry eUsers = new DirectoryEntry("LDAP://" + dnsHostName + "/" + defaultNamingContext); // Create connection with DC
                            DirectorySearcher sUsers = new DirectorySearcher(eUsers);                                           // Start up searcher

                            sUsers.Filter = objectStringCreator(obj);       // Search Filter String -- Generated by objectStringCreator

                            SearchResult uResult = sUsers.FindOne();        // Search - Store in SearchResult object
                            DirectoryEntry dUser = uResult.GetDirectoryEntry();     // Get Result from SearchResult and store in DirectoryEntry object
                            if (dUser != null){
                                Dictionary<string, Int64> lastLogons = new Dictionary<string, Int64>();
                                string distinguishedName = dUser.Properties["distinguishedName"].Value.ToString();
                                Int64 lastLogonThisServer = new Int64();
                                if (dUser.Properties["lastLogon"].Value != null){
                                    IADsLargeInteger largeInt = (IADsLargeInteger)dUser.Properties["lastLogon"].Value;
                                    lastLogonThisServer = ((long)largeInt.HighPart << 32) + largeInt.LowPart;
                                }
                                if (lastLogons.ContainsKey(distinguishedName)){
                                    if (lastLogons[distinguishedName] < lastLogonThisServer){
                                        lastLogons[distinguishedName] = lastLogonThisServer;
                                    }
                                }
                                else{
                                    lastLogons.Add(distinguishedName, lastLogonThisServer);
                                    obj._LastLoginDate = DateTime.FromFileTime(lastLogonThisServer).ToString();
                                }
                            }
                        }
                    }
                }
                catch{
                    obj._Error = true;
                    obj._Message = "Could not locate login time";
                }
                finally{
                    
                }

            }
            catch{
                obj._Error = true;
                obj._Message = "Could not locate login time";
            }
            finally{
                LDAPConn.Dispose();
                ADSearch.Dispose();
                LDAPConn = null;
                ADSearch = null;
            }
            return obj._Error;
        }
        public Boolean getDomainControllers(BusinessObject obj)
        {
            try
            {
                obj._DomainDCs = new List<string>();

                Domain domain = Domain.GetCurrentDomain();

                foreach (DomainController dc in domain.DomainControllers)
                {
                    obj._DomainDCs.Add(dc.Name);
                }
            }
            catch {
                obj._Message = "Cannot find DCs";
                obj._Error = true;
                return obj._Error;
            }

            return obj._Error;
        }
        public Boolean getGroups(BusinessObject obj)
        {

            obj._Groups = new List<string>();
            try
            {
                PContext = new PrincipalContext(ContextType.Domain);

                UPrince = UserPrincipal.FindByIdentity(PContext, obj._Username);

                if (UPrince != null)
                {
                    var groups = UPrince.GetGroups();

                    foreach (var x in groups)
                    {
                        obj._Groups.Add(x.ToString());
                    }

                }
            }
            catch
            {
                obj._Message = "Cannot find groups";
                obj._Error = true;
                return obj._Error;
            }
            finally {
                PContext.Dispose();
                UPrince.Dispose();
                PContext = null;
                UPrince = null;
            }
            obj._Error = false;
            return obj._Error;
        }
        public Boolean getUserData(BusinessObject obj)
        {
            try
            {
                PContext = new PrincipalContext(ContextType.Domain); // Connection

                UPrince = new UserPrincipal(PContext); // Search Criteria

                // Set Search Terms
                if (!String.IsNullOrEmpty(obj._Username))
                    UPrince.SamAccountName = obj._Username;

                if (!String.IsNullOrEmpty(obj._FirstName))
                    UPrince.GivenName = obj._FirstName;

                if (!String.IsNullOrEmpty(obj._LastName))
                    UPrince.Surname = obj._LastName;


                PSearch = new PrincipalSearcher(UPrince); // Set up Searcher

                UPrince = PSearch.FindOne() as UserPrincipal; // Find Result

                // Need to run this method while the BO variables are empty
                findLastLogin(obj); // Find UpToDate Last Logon Date on all domain controllers


                // Save Results in BO Variables, 
                //Check if they are NULL if bool?/DateTime?
                obj._IsAccountLockedOut = UPrince.IsAccountLockedOut();
                obj._FailedLoginCount = UPrince.BadLogonCount;

                if (UPrince.AccountLockoutTime != null)
                    obj._LockOutTime = UPrince.AccountLockoutTime;

                if (UPrince.LastBadPasswordAttempt != null)
                    obj._LastFailedLoginDate = UPrince.LastBadPasswordAttempt;

                if (UPrince.Enabled != null)
                    obj._AccountEnabled = UPrince.Enabled;

                obj._Username = UPrince.SamAccountName;
                obj._FirstName = UPrince.GivenName;
                obj._LastName = UPrince.Surname;
                obj._FullName = UPrince.DisplayName;

                

            }
            catch (Exception)
            {
                obj._Error = true;
                obj._Message = "Error - Could not find user";
                return obj._Error;
            }
            finally
            {
                PContext.Dispose();
                UPrince.Dispose();
                PSearch.Dispose();
                PSearch = null;
                PContext = null;
                UPrince = null;
            }
            obj._Error = false;
            obj._Message = "Data Retrieved";
            return obj._Error;
        }
        public Boolean unlockUser(BusinessObject obj)
        {
            try
            {
                PContext = new PrincipalContext(ContextType.Domain); // Connection

                UPrince = new UserPrincipal(PContext); // Search Criteria Filter

                UPrince.SamAccountName = obj._Username; // Search Conditions - Search by UserName

                PSearch = new PrincipalSearcher(UPrince); // Set up Searcher

                UPrince = PSearch.FindOne() as UserPrincipal; // Find Result

                if (UPrince.IsAccountLockedOut())
                {
                    UPrince.UnlockAccount();
                    UPrince.Save();
                }
                else if (UPrince.IsAccountLockedOut() == false)
                {
                    obj._Error = true;
                    obj._Message = "Error - User is already unlocked";
                    return obj._Error;
                }

            }
            catch
            {
                obj._Error = true;
                obj._Message = "Error - User not unlocked";
                return obj._Error;
            }
            finally
            {
                PContext.Dispose();
                UPrince.Dispose();
                PSearch.Dispose();
                PSearch = null;
                PContext = null;
                UPrince = null;
            }
            obj._Error = false;
            obj._Message = "Account Unlocked";
            return obj._Error;
        }
        public Boolean disableUser(BusinessObject obj){
            try{
                PContext = new PrincipalContext(ContextType.Domain); // Connection

                UPrince = new UserPrincipal(PContext); // Search Criteria Filter

                UPrince.SamAccountName = obj._Username; // Search Conditions - Search by UserName

                PSearch = new PrincipalSearcher(UPrince); // Set up Searcher

                UPrince = PSearch.FindOne() as UserPrincipal; // Find Result

                bool isNull = checkNull(UPrince.Enabled);

                if (!isNull){
                    if (Convert.ToBoolean(UPrince.Enabled)){
                        UPrince.Enabled = false;
                        UPrince.Save();
                    }
                    else if (Convert.ToBoolean(UPrince.Enabled) == false){
                        obj._Error = true;
                        obj._Message = "Error - User is already disabled.";
                        return obj._Error;
                    }
                }
            }

            catch{
                obj._Error = true;
                obj._Message = "Error - Cannot disable user";
                return obj._Error;
            }
            finally{
                PContext.Dispose();
                UPrince.Dispose();
                PSearch.Dispose();
                PSearch = null;
                PContext = null;
                UPrince = null;
            }
                obj._Error = false;
            obj._Message = "Account Disabled";
            return obj._Error;
        }
        public Boolean enableUser(BusinessObject obj){
            try{
                PContext = new PrincipalContext(ContextType.Domain); // Connection

                UPrince = new UserPrincipal(PContext); // Search Criteria Filter

                UPrince.SamAccountName = obj._Username; // Search Conditions - Search by UserName

                PSearch = new PrincipalSearcher(UPrince); // Set up Searcher

                UPrince = PSearch.FindOne() as UserPrincipal; // Find Result

                bool isNull = checkNull(UPrince.Enabled);

                if (!isNull){
                    if (!(Convert.ToBoolean(UPrince.Enabled))){
                        UPrince.Enabled = true;
                        UPrince.Save();
                    }
                    else if ((Convert.ToBoolean(UPrince.Enabled))){
                        obj._Error = true;
                        obj._Message = "Error - Account is already enabled.";
                        return obj._Error;
                    }
                }
            }
            catch{
                obj._Error = true;
                obj._Message = "Error - Can't Enable";
                return obj._Error;
            }
            finally {
                PContext.Dispose();
                UPrince.Dispose();
                PSearch.Dispose();
                PSearch = null;
                PContext = null;
                UPrince = null;
            }
            obj._Error = false;
            obj._Message = "Account Enabled";
            return obj._Error;
        }
        public Boolean isAccountLockedOut(BusinessObject obj){

            try{

                PContext = new PrincipalContext(ContextType.Domain); // Connection

                UPrince = new UserPrincipal(PContext); // Search Criteria Filter

                UPrince.SamAccountName = obj._Username; // Search Conditions - Search by user name

                PSearch = new PrincipalSearcher(UPrince); // Set up Searcher

                UPrince = PSearch.FindOne() as UserPrincipal; // Find Result
                obj._IsAccountLockedOut = UPrince.IsAccountLockedOut();
            }
            catch{
                PContext.Dispose();
                UPrince.Dispose();
                PContext = null;
                UPrince = null;
                obj._Error = true;
                return obj._Error;
            }
            finally {
                PContext.Dispose();
                UPrince.Dispose();
                PSearch.Dispose();
                PSearch = null;
                PContext = null;
                UPrince = null;
            }
            obj._Error = false;
            return obj._Error;
        }


        #endregion


        #region Small Stuff
        private string connectionStringBuilder(string domain, string username, string password)
        {
            connectionString = "LDAP://" + domain + username + password;
            return connectionString;
        }
        private String objectStringCreator(BusinessObject obj){
            String objectFilter = String.Empty;


            // Username
            if (!String.IsNullOrEmpty(obj._Username))
                objectFilter = "(&(objectCategory=person)(objectClass=user)(samAccountName=" + obj._Username + "))";

            // First
            if (!String.IsNullOrEmpty(obj._FirstName))
                objectFilter = "(&(objectCategory=person)(objectClass=user)(givenname=" + obj._FirstName + "))";

            // Last
            if (!String.IsNullOrEmpty(obj._LastName))
                objectFilter = "(&(objectCategory=person)(objectClass=user)(sn=" + obj._LastName + "))";

            // First and Last
            if (!String.IsNullOrEmpty(obj._FirstName) && !String.IsNullOrEmpty(obj._LastName)){
                objectFilter = "(&(objectCategory=person)(objectClass=user)(givenname=" + obj._FirstName + ")" + "(sn=" + obj._LastName + "))";
            }

            // Last and User
            else if (!String.IsNullOrEmpty(obj._LastName) && !String.IsNullOrEmpty(obj._Username)){
                objectFilter = "(&(objectCategory=person)(objectClass=user)(sn=" + obj._LastName + ")" + "(samAccountName=" + obj._Username + "))";
            }

            // First and User
            else if (!String.IsNullOrEmpty(obj._FirstName) && !String.IsNullOrEmpty(obj._Username)){
                objectFilter = "(&(objectCategory=person)(objectClass=user)(givenname=" + obj._FirstName + ")" + "(samAccountName=" + obj._Username + "))";
            }




            return objectFilter;
        }
        private Boolean checkNull(bool? checkBool){
            if (checkBool == null){
                return true;
            }

            else{
                return false;
            }
        }

        #endregion



        #region Future


        public Boolean findAllLastLogin(BusinessObject obj){// https://www.codeproject.com/kb/security/lastlogonacrossallwindows.aspx


            LDAPConn = new DirectoryEntry("LDAP://RootDSE"); // RootDSE is entire domain

            string configNamingContext = LDAPConn.Properties["configurationNamingContext"].Value.ToString();
            string defaultNamingContext = LDAPConn.Properties["defaultNamingContext"].Value.ToString();



            LDAPConn = new DirectoryEntry("LDAP://" + configNamingContext);
            ADSearch = new DirectorySearcher(LDAPConn);

            ADSearch.Filter = "objectClass=nTDSDSA"; // Targets all DC's
            try{
                foreach (SearchResult domains in ADSearch.FindAll()){
                    DirectoryEntry entry = domains.GetDirectoryEntry();
                    if (entry != null){

                        string dnsHostName = entry.Parent.Properties["DNSHostName"].Value.ToString(); // Get DNSHostName of Parent entry
                        DirectoryEntry eUsers = new DirectoryEntry("LDAP://" + dnsHostName + "/" + defaultNamingContext);
                        DirectorySearcher sUsers = new DirectorySearcher(eUsers);
                        sUsers.Filter = "(&(objectCategory=person)(objectClass=user))";

                        foreach (SearchResult uResult in sUsers.FindAll()){
                            DirectoryEntry dUser = uResult.GetDirectoryEntry();
                            if (dUser != null){
                                Dictionary<string, Int64> lastLogons = new Dictionary<string, Int64>();
                                string distinguishedName = dUser.Properties["distinguishedName"].Value.ToString();
                                Int64 lastLogonThisServer = new Int64();
                                if (dUser.Properties["lastLogon"].Value != null){
                                    IADsLargeInteger largeInt = (IADsLargeInteger)dUser.Properties["lastLogon"].Value;
                                    lastLogonThisServer = ((long)largeInt.HighPart << 32) + largeInt.LowPart;
                                }
                                if (lastLogons.ContainsKey(distinguishedName)){
                                    if (lastLogons[distinguishedName] < lastLogonThisServer){
                                        lastLogons[distinguishedName] = lastLogonThisServer;
                                        // string x = DateTime.FromFileTime(lastLogonThisServer).ToString();
                                    }
                                }
                                else{
                                    lastLogons.Add(distinguishedName, lastLogonThisServer);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception){
                obj._Error = true;
                obj._Message = "Could not locate login time";
            }

            return obj._Error;
        }
        public Boolean createUser(BusinessObject obj)
        {

            PContext = new PrincipalContext(ContextType.Domain);

            try
            {
                UPrince = new UserPrincipal(PContext);
                UPrince.SamAccountName = obj._NewUserName;
                UPrince.SetPassword(obj._NewPassword);
                UPrince.GivenName = obj._NewFirstName;
                UPrince.Surname = obj._NewLastName;

                UPrince.Enabled = true;
                UPrince.ExpirePasswordNow();
                UPrince.Save();
            }
            catch
            {
                obj._Error = true;
                obj._Message = "Error - Could not create account.";
                PContext = null;
                UPrince = null;
            }
            PContext = null;
            UPrince = null;
            return obj._Error;
        }
        public Boolean validateCredentials(BusinessObject obj)
        {




            return obj._Error;
        }

        #endregion




        #region Groups  // These depend on how your AD is set up
        // Example
        // 
        //  Active Directory Users and Computers
        //      Domain    
        //          Company
        //              Departments
        //                  IT
        //                  HR
        //                  etc.

        public string createLDAP(String OU, String Server, String DC){
            String ldapString = "LDAP://OU=" + OU;
            ldapString += ",DC=" + Server;
            ldapString += ",DC=" + DC;
            return ldapString;
        }

        public Boolean getAllGroups(BusinessObject obj){
            obj._Groups = new List<string>();

            LDAPConn = new DirectoryEntry(createLDAP(obj._OU, obj._Server, obj._DC));

            ADSearch = new DirectorySearcher(LDAPConn);

            ADSearch.Filter = "(objectClass=organizationalUnit)";
            ADSearch.SearchScope = SearchScope.OneLevel;

            SearchResultCollection results = ADSearch.FindAll(); // Get all OUs in 'Company'
            
            foreach(SearchResult result in results){ // Loop through OUs in 'Company'
            

                if (result.Properties["ou"][0].ToString() == "Departments"){ // Execute only in OU 'Departments'

                    DirectoryEntry currentOU = result.GetDirectoryEntry(); // Find current location

                    DirectorySearcher findDepartments = new DirectorySearcher(currentOU); // Start new search

                    findDepartments.SearchScope = SearchScope.OneLevel; // One level down
                    findDepartments.Filter = "(objectClass=organizationalUnit)";    // Search for OUs

                    SearchResultCollection departments1 = findDepartments.FindAll();    // Store results in a collection

                    foreach (SearchResult departments in departments1)  // Loop through departments{
                        obj._Groups.Add(departments.Properties["ou"][0].ToString());    // Store in list
                    }
                }
            return obj._Error;
        }

        public Boolean getEnabledUsersInGroup(BusinessObject obj){
            obj._Users = new List<string>();
            LDAPConn = new DirectoryEntry(createLDAP(obj._OU, obj._Server, obj._DC));

            ADSearch = new DirectorySearcher(LDAPConn);

            ADSearch.Filter = "(objectClass=organizationalUnit)";
            ADSearch.SearchScope = SearchScope.OneLevel;

            SearchResultCollection results = ADSearch.FindAll(); // Get all OUs in 'Company'

            foreach (SearchResult result in results){ // Loop through OUs in 'Company'


                if (result.Properties["ou"][0].ToString() == "Departments"){ // Execute only in OU 'Departments'
//////////////////////// Departments

                    DirectoryEntry currentOU = result.GetDirectoryEntry(); // Find current location

                    DirectorySearcher findDepartments = new DirectorySearcher(currentOU); // Start new search

                    findDepartments.SearchScope = SearchScope.OneLevel; // One level down
                    findDepartments.Filter = "(&(objectClass=organizationalUnit)(ou=" + obj._SpecifiedGroup + "))";    // Search for OUs

                    SearchResult SpecifiedDepartment = findDepartments.FindOne();    // Find the group

                    //////////////////////// Specific Group
                    try{
                        DirectoryEntry thisDepartment = SpecifiedDepartment.GetDirectoryEntry();

                        DirectorySearcher lookHere = new DirectorySearcher(thisDepartment);

                        lookHere.SearchScope = SearchScope.OneLevel;
                        lookHere.Filter = "(&(objectClass=organizationalUnit)(ou=Users))";

                        SearchResult users = lookHere.FindOne();

                        //////////////////////// Users
                        try{
                            DirectoryEntry findUsers = users.GetDirectoryEntry();

                            DirectorySearcher searchUsers = new DirectorySearcher(findUsers);

                            searchUsers.SearchScope = SearchScope.OneLevel;

                            //searchUsers.Filter = "(&(objectCategory=user)(!(userAccountControl:1.2.840.113556.1.4.803:=2)))"; // Don't want disabled accounts
                            searchUsers.Filter = "(&(objectCategory=user)(!(userAccountControl:1.2.840.113556.1.4.803:=2)))";


                            SearchResultCollection finalUsers = searchUsers.FindAll();


                            foreach (SearchResult user in finalUsers){  // Loop through 
                                obj._Users.Add(user.Properties["name"][0].ToString());
                            }
                            currentOU = null;
                            findDepartments = null;
                            SpecifiedDepartment = null;
                            findUsers = null;
                            searchUsers = null;
                            finalUsers = null;
                            LDAPConn = null;
                            ADSearch = null;
                            results = null;
                        }
                        catch{
                            obj._Message = "Cannot find any users";
                            return obj._Error;
                        }
                        currentOU = null;
                        findDepartments = null;
                        SpecifiedDepartment = null;
                        thisDepartment = null;
                        lookHere = null;
                        users = null;
                        LDAPConn = null;
                        ADSearch = null;
                        results = null;
                    }
                    catch {
                        obj._Message = "Cannot find departments";
                        return obj._Error;
                    }
                    currentOU = null;
                    findDepartments = null;
                    SpecifiedDepartment = null;
                    LDAPConn = null;
                    ADSearch = null;
                    results = null;
                }
            }

            LDAPConn = null;
            ADSearch = null;
            results = null;

            return obj._Error;
        }

        public Boolean getDisabledUsersInGroup(BusinessObject obj){
            obj._DisabledUsers = new List<string>();
            LDAPConn = new DirectoryEntry(createLDAP(obj._OU, obj._Server, obj._DC));

            ADSearch = new DirectorySearcher(LDAPConn);

            ADSearch.Filter = "(objectClass=organizationalUnit)";
            ADSearch.SearchScope = SearchScope.OneLevel;

            SearchResultCollection results = ADSearch.FindAll(); // Get all OUs in 'Company'

            foreach (SearchResult result in results){ // Loop through OUs in 'Company'

                if (result.Properties["ou"][0].ToString() == "Departments"){ // Execute only in OU 'Departments'
//////////////////////// Departments
                    DirectoryEntry currentOU = result.GetDirectoryEntry(); // Find current location

                    DirectorySearcher findDepartments = new DirectorySearcher(currentOU); // Start new search

                    findDepartments.SearchScope = SearchScope.OneLevel; // One level down
                    findDepartments.Filter = "(&(objectClass=organizationalUnit)(ou=" + obj._SpecifiedGroup + "))";    // Search for OUs

                    SearchResult SpecifiedDepartment = findDepartments.FindOne();    // Find the group

//////////////////////// Specific Group
                    DirectoryEntry thisDepartment = SpecifiedDepartment.GetDirectoryEntry();

                    DirectorySearcher lookHere = new DirectorySearcher(thisDepartment);

                    lookHere.SearchScope = SearchScope.OneLevel;
                    lookHere.Filter = "(&(objectClass=organizationalUnit)(ou=Users))";

                    SearchResult users = lookHere.FindOne();

//////////////////////// Users
                    DirectoryEntry findUsers = users.GetDirectoryEntry();

                    DirectorySearcher searchUsers = new DirectorySearcher(findUsers);

                    searchUsers.SearchScope = SearchScope.OneLevel;

                    //searchUsers.Filter = "(&(objectCategory=user)(!userAccountControl=512))";
                    searchUsers.Filter = "(&(objectCategory=user)(userAccountControl:1.2.840.113556.1.4.803:=2))";

                    SearchResultCollection finalUsers = searchUsers.FindAll();


                    foreach (SearchResult user in finalUsers){  // Loop through 
                        obj._DisabledUsers.Add(user.Properties["name"][0].ToString());
                    }

                    currentOU = null;
                    findDepartments = null;
                    SpecifiedDepartment = null;
                    thisDepartment = null;
                    lookHere = null;
                    users = null;
                    findUsers = null;
                    searchUsers = null;
                    finalUsers = null;
                }
            }

            LDAPConn = null;
            ADSearch = null;
            results = null;



            return obj._Error;
        }


        #endregion




        #region Replaced
        /* public Boolean scanDomain(BusinessObject obj)
         { // Loop through the domains and store them in something // Todo
             obj._DomainDCs = new List<string>();
             LDAPConn = new DirectoryEntry("LDAP://RootDSE"); // RootDSE is entire domain

             string configNamingContext = LDAPConn.Properties["configurationNamingContext"].Value.ToString();

             LDAPConn = new DirectoryEntry("LDAP://" + configNamingContext);
             ADSearch = new DirectorySearcher(LDAPConn);

             ADSearch.Filter = "objectClass=nTDSDSA"; // Targets all DC's
             try
             {
                 foreach (SearchResult domains in ADSearch.FindAll())
                 {
                     DirectoryEntry entry = domains.GetDirectoryEntry();
                     if (entry != null)
                     {
                         string dnsHostName = entry.Parent.Properties["DNSHostName"].Value.ToString(); // Get DNSHostName
                         obj._DomainDCs.Add(dnsHostName);
                     }
                 }
             }

             catch
             {
                 obj._Error = true;
                 obj._Message = "Could not identify DCs";
             }
             return obj._Error;
         }*/
        #endregion








    }
}