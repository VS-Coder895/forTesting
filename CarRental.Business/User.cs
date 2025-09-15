using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class User
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.Update;
        public int userId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userRole { get; set; }

        public User()
        {
            userId = -1;
            userName = string.Empty;
            userPassword = string.Empty;
            userRole = string.Empty;
        }

        public User(int id, string name, string password, string role)
        {
            userId = id;
            userName = name;
            userPassword = password;
            userRole = role;
        }
        private static bool ValidateUserInfo(string userName, string password, string role)
        {
            if (string.IsNullOrEmpty(userName))
                throw new ArgumentException("User name must not be empty");

            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("User password must not be empty");

            if (string.IsNullOrEmpty(role))
                throw new ArgumentException("User role must not be empty");

            return true;
        }

        public static DataTable GetAll()
        {
            return UserDataAccess.GetAll();
        }

        public static User FindByUserID(int id)
        {
            if (id <= 0)
                throw new ArgumentException("User ID must be greater than zero");

            int userId = id;
            string userName = "";
            string password = "";
            string role = "";

            bool found = UserDataAccess.FindByUserID(ref userId, ref userName, ref password, ref role);

            return found ? new User(userId, userName, password, role) : null;
        }

        public static User FindByUserNameAndPassword(string userName, string password)
        {
            int userId = -1;
            string foundUserName = userName;
            string foundPassword = password;
            string role = "";

            bool isFound = UserDataAccess.FindByUserNameAndPassword(ref foundUserName, ref foundPassword, ref userId, ref role);

            if (isFound)
            {
                return new User(userId, foundUserName, foundPassword, role);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNew()
        {
            ValidateUserInfo(userName, userPassword, userRole);
            return UserDataAccess.AddNewUser(userName, userPassword, userRole);
        }

        private bool _Update()
        {
            if (userId <= 0)
                throw new ArgumentException("Invalid user ID");

            ValidateUserInfo(userName, userPassword, userRole);
            return UserDataAccess.UpdateUser(userId, userName, userPassword, userRole);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static bool DeleteByUserID(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid user ID");

            return UserDataAccess.DeleteByUserID(id) != -1;
        }

        public static bool IsExistsByUserID(int id)
        {
            return id > 0 && UserDataAccess.IsExistsByID(id);
        }
    }
}
