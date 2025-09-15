using System.Data;
using DataAccessLayer;


namespace BusinessLayer
{
    public class Customer
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int CustomerID { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string DLN { set; get; } 
        public string Address { set; get; }
        public string PhoneNumber { set; get; } 
        public Customer()
        {
            this.CustomerID = -1;
            this.Name = "";
            this.Email = "";
            this.DLN = "";
            this.Address = "";
            this.PhoneNumber = "";  
            Mode = enMode.AddNew;
        }

        private Customer(int CustomerID, string Name, string Email,
                        string DLN, string Address, string PhoneNumber)
        {
            this.CustomerID = CustomerID;
            this.Name = Name;
            this.Email = Email;
            this.DLN = DLN;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;  
            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.CustomerID = CustomerDataAccess.AddNew(
                this.Name,
                this.Email,
                this.DLN,
                this.Address,
                this.PhoneNumber 
            );
            return (this.CustomerID != -1);
        }

        private bool _Update()
        {
            return CustomerDataAccess.Update(
                this.CustomerID,
                this.Name,
                this.Email,
                this.DLN,
                this.Address,
                this.PhoneNumber 
            );
        }

        public static Customer Find(int ID)
        {
            string Name = "", Email = "", DLN = "", Address = "", PhoneNumber = "";
            bool isFound = CustomerDataAccess.FindByID(ID, ref Name, ref Email,ref DLN, ref Address, ref PhoneNumber);

            if (isFound)
            {
                return new Customer(ID, Name, Email, DLN, Address, PhoneNumber);
            }
            else
            {
                return null;
            }
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
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
                default:
                    return false;
            } 
        }

        public static DataTable GetAll()
        {
            return CustomerDataAccess.GetAll();
        }

        public static bool Delete(int ID)
        {
            return CustomerDataAccess.Delete(ID);
        }

        public static bool IsCustomerExist(int ID)
        {
            return CustomerDataAccess.IsCustomerExist(ID);
        }
    }
}