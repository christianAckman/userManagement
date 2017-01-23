using System;

namespace MasterApp{
     class DataObject : DataAccess{

        #region Completed
        public new Boolean changePassword(BusinessObject obj){

            base.changePassword(obj);
            return obj._Error;
        }
        public new Boolean unlockUser(BusinessObject obj){
            base.unlockUser(obj);
            return obj._Error;
        }
        public new Boolean disableUser(BusinessObject obj){
            base.disableUser(obj);
            return obj._Error;
        }
        public new Boolean enableUser(BusinessObject obj){
            base.enableUser(obj);
            return obj._Error;
        }
        public new Boolean findUserNameSearchByFirst(BusinessObject obj) {
            base.findUserNameSearchByFirst(obj);
            return obj._Error;
        }
        public new Boolean findUserNameSearchByLast(BusinessObject obj){
            base.findUserNameSearchByLast(obj);
            return obj._Error;
        }
        public new Boolean getLastFailedLoginDate(BusinessObject obj){
            base.getLastFailedLoginDate(obj);
            return obj._Error;
        }
        public new Boolean getLockOutTime(BusinessObject obj){
            base.findUserNameSearchByFirst(obj);
            return obj._Error;
        }
        public new Boolean getFailedLoginCount(BusinessObject obj){
            base.getFailedLoginCount(obj);
            return obj._Error;
        }
        public new Boolean isAccountEnabled(BusinessObject obj){
            base.isAccountEnabled(obj);
            return obj._Error;
        }
        public new Boolean isAccountLockedOut(BusinessObject obj){
            base.isAccountLockedOut(obj);
            return obj._Error;
        }
        public new Boolean getUserData(BusinessObject obj){
            base.getUserData(obj);


            return obj._Error;
        }
        public new Boolean getGroups(BusinessObject obj){
            base.getGroups(obj);
            return obj._Error;
        }
        public new Boolean getDomainControllers(BusinessObject obj)
        {
            base.getDomainControllers(obj);
            return obj._Error;
        }
        #endregion




        public new Boolean getEnabledUsersInGroup(BusinessObject obj){
            base.getEnabledUsersInGroup(obj);

            return obj._Error;
        }





        public new Boolean getAllGroups(BusinessObject obj){
            base.getAllGroups(obj);
            return obj._Error;
        }



        public new Boolean getDisabledUsersInGroup(BusinessObject obj){
            base.getDisabledUsersInGroup(obj);
            return obj._Error;
        }
    }
}
