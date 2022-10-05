using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// 
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// 
        /// </summary>
        private string _fullname;

        /// <summary>
        /// 
        /// </summary>
        private string _address;

        /// <summary>
        /// 
        /// </summary>
        private const int NameMaxLength = 200;

        /// <summary>
        /// 
        /// </summary>
        private const int AddressMaxLength = 500;

        public int ID 
        {
            get
            {
                return _id; 
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = Validator.AssertStringMaxLength(value, "Fullname", NameMaxLength);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            get 
            {
                return _address; 
            }
            set 
            {
                _address = Validator.AssertStringMaxLength(value, "Address", AddressMaxLength);
            }
        }

        public Customer(string fullname, string address)
        {
            _id++;
            Fullname = fullname;
            Address = address;
        }
    }
}
