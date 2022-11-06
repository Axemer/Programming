using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Содержит информацию об месте проживания.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Возвращает и задаёт Почтовый индекс.
        /// </summary>
        public int Index 
        { 
            get 
            { 
                return _index; 
            } 
            set 
            {
                _index = Validator.AssertValueInRange("Index", value, 0, 999999);
            } 
        }

        /// <summary>
        /// Страна.
        /// </summary>
        private string _country;

        /// <summary>
        /// Возвращает и задаёт страну.
        /// </summary>
        public string Country 
        { 
            get 
            { 
                return _country;
            }
            set 
            { 
                _country = Validator.AssertStringMaxLength(value, "Country", 50);
            } 
        }

        /// <summary>
        /// Город.
        /// </summary>
        private string _city;

        /// <summary>
        /// Возвращает и задаёт город.
        /// </summary>
        public string City 
        { 
            get 
            {
                return _city; 
            } 
            set 
            { 
                _city = Validator.AssertStringMaxLength(value, "City", 50);
            } 
        }

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Возвращает и задаёт улицу.
        /// </summary>
        public string Street 
        { 
            get 
            {
                return _street; 
            } 
            set 
            {
                _street = Validator.AssertStringMaxLength(value, "Street", 100);
            } 
        }

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Возвращает и задаёт номер дома.
        /// </summary>
        public string Building 
        { 
            get 
            { 
                return _building;
            } 
            set 
            { 
                _building = Validator.AssertStringMaxLength(value, "Building", 10);
            } 
        }

        /// <summary>
        /// номер квартиры/помещения
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задаёт номер квартиры/помещения.
        /// </summary>
        public string Apartment
        {
            get 
            {
                return _apartment;
            }
            set 
            { 
                _apartment = Validator.AssertStringMaxLength(value, "Apartment", 10);
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>
        /// </summary>
        /// <param name="index">Почтовый индекс, целое шестизначное число.</param>
        /// <param name="county">Страна/регион, строка, не более 50 символов.</param>
        /// <param name="city">Город (населенный пункт), строка, не более 50 символов.</param>
        /// <param name="street">Улица, строка, не более 100 символов.</param>
        /// <param name="building">Номер дома, строка, не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения, не более 10 символов.</param>
        public Address(int index, string county, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = county;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address">
        /// </summary>
        public Address() 
        {
            Index = 0;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }
    }
}
