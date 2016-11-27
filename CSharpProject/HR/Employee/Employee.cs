using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        #region feilds
        int id;
        string lastname;
        string firstname;
        string title;
        string titleOfCourtesy;
        DateTime birthdate;
        DateTime hiredate;
        string address;
        string city;
        string region;
        string postalcode;
        string country;
        string phone;
        int mgrid;
        string fullname;
        #endregion

        #region properties
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string TitleOfCourtesy
        {
            get
            {
                return titleOfCourtesy;
            }

            set
            {
                titleOfCourtesy = value;
            }
        }

        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }

            set
            {
                birthdate = value;
            }
        }

        public DateTime Hiredate
        {
            get
            {
                return hiredate;
            }

            set
            {
                hiredate = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }

        public string Postalcode
        {
            get
            {
                return postalcode;
            }

            set
            {
                postalcode = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public int Mgrid
        {
            get
            {
                return mgrid;
            }

            set
            {
                mgrid = value;
            }
        }

        public string Fullname
        {
            get
            {
                return id + "-" + firstname +" "+ lastname;
            }

            set
            {
                fullname = value;
            }
        }
        #endregion

        #region constructor
        public Employee()
        {
        }

        public Employee(int id, string lastname, string firstname, string title, string titleOfCourtesy, DateTime birthdate, DateTime hiredate, string address, string city, string region, string postalcode, string country, string phone, int mgrid)
        {
            this.Id = id;
            this.Lastname = lastname;
            this.Firstname = firstname;
            this.Title = title;
            this.TitleOfCourtesy = titleOfCourtesy;
            this.Birthdate = birthdate;
            this.Hiredate = hiredate;
            this.Address = address;
            this.City = city;
            this.Region = region;
            this.Postalcode = postalcode;
            this.Country = country;
            this.Phone = phone;
            this.Mgrid = mgrid;
        }
        #endregion


    }
}
