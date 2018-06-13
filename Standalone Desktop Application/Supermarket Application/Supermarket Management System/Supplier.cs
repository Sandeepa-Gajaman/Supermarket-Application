using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System
{
    class Supplier
    {
        private int SupplierId;
        private String SupplierName;
        private String SupplierCity;
        private String SupplierAddress;
        private String PhoneNumber;

        public Supplier() { }

        public void AddSupplier(String SupplierName, String SupplierCity, String SupplierAddress, 
            String PhoneNumber) { }

        public void RemoveSupplier(int SupplierId) { }

        public void ChangeSupplierDetails(int SupplierId, String SupplierName, String SupplierCity, 
            String SupplierAddress, String PhoneNumber) { }
    }
}
