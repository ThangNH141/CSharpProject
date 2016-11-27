using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.Sales.Order
{
    public class Order : ICloneable
    {
        private int? orderid;
        private int? custid;
        private string contactname;
        private int empid;
        private string firstname;
        private string lastname;

        public string EmpName
        {
            get { return firstname + " " + lastname; }
        }

        private DateTime orderdate;
        private DateTime requireddate;
        private DateTime? shippeddate;
        private int shipperid;
        private string shipCompanyname;
        private Decimal freight;
        private string shipname;
        private string shipaddress;
        private string shipcity;
        private String shipregion;
        private String shippostalcode;
        private string shipcountry;

        public Order(SqlDataReader sqlDataReader)
        {
            this.orderid = sqlDataReader.GetInt32(0);
            if (sqlDataReader.IsDBNull(1))
            {
                this.custid = null;
            }
            else
            {
                this.custid = sqlDataReader.GetInt32(1);
            }
            if (!sqlDataReader.IsDBNull(2))
            {
                this.contactname = sqlDataReader.GetString(2);
            }
            else
            {
                this.contactname = null;
            }
            this.empid = sqlDataReader.GetInt32(3);
            this.firstname = sqlDataReader.GetString(4);
            this.lastname = sqlDataReader.GetString(5);
            this.orderdate = sqlDataReader.GetDateTime(6);
            this.requireddate = sqlDataReader.GetDateTime(7);
            if (sqlDataReader.IsDBNull(8))
            {
                this.shippeddate = null;
            }
            else
            {
                this.shippeddate = sqlDataReader.GetDateTime(8);
            }
            this.shipperid = sqlDataReader.GetInt32(9);
            this.shipCompanyname = sqlDataReader.GetString(10);
            this.freight = sqlDataReader.GetDecimal(11);
            this.shipname = sqlDataReader.GetString(12);
            this.shipaddress = sqlDataReader.GetString(13);
            this.shipcity = sqlDataReader.GetString(14);

            if (sqlDataReader.IsDBNull(15))
            {
                this.shipregion = "";
            }
            else
            {
                this.shipregion = sqlDataReader.GetString(15);
            }
            if (sqlDataReader.IsDBNull(16))
            {
                this.shippostalcode = "";
            }
            else
            {
                this.shippostalcode = sqlDataReader.GetString(16);
            }

            this.shipcountry = sqlDataReader.GetString(17);
        }

        public Order()
        {
        }

        public Order(string contactname, int? custid, int empid, string firstname, decimal freight, string lastname,
            DateTime orderdate, DateTime requireddate, string shipaddress, string shipcity, string shipCompanyname,
            string shipcountry, string shipname, DateTime? shippeddate, int shipperid, string shippostalcode,
            string shipregion)
        {
            this.contactname = contactname;
            this.custid = custid;
            this.empid = empid;
            this.firstname = firstname;
            this.freight = freight;
            this.lastname = lastname;
            this.orderdate = orderdate;
            this.requireddate = requireddate;
            this.shipaddress = shipaddress;
            this.shipcity = shipcity;
            this.shipCompanyname = shipCompanyname;
            this.shipcountry = shipcountry;
            this.shipname = shipname;
            this.shippeddate = shippeddate;
            this.shipperid = shipperid;
            this.shippostalcode = shippostalcode;
            this.shipregion = shipregion;
        }


        public int Orderid
        {
            get { return orderid.Value; }
            set { orderid = value; }
        }

        public int? Custid
        {
            get { return custid; }
            set { custid = value; }
        }

        public string Contactname
        {
            get { return contactname; }
            set { contactname = value; }
        }

        public int Empid
        {
            get { return empid; }
            set { empid = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public DateTime Orderdate
        {
            get { return orderdate; }
            set { orderdate = value; }
        }

        public DateTime Requireddate
        {
            get { return requireddate; }
            set { requireddate = value; }
        }

        public DateTime? Shippeddate
        {
            get { return shippeddate; }
            set { shippeddate = value; }
        }

        public int Shipperid
        {
            get { return shipperid; }
            set { shipperid = value; }
        }

        public string ShipCompanyname
        {
            get { return shipCompanyname; }
            set { shipCompanyname = value; }
        }

        public decimal Freight
        {
            get { return freight; }
            set { freight = value; }
        }

        public string Shipname
        {
            get { return shipname; }
            set { shipname = value; }
        }

        public string Shipaddress
        {
            get { return shipaddress; }
            set { shipaddress = value; }
        }

        public string Shipcity
        {
            get { return shipcity; }
            set { shipcity = value; }
        }

        public string Shipregion
        {
            get { return shipregion; }
            set { shipregion = value; }
        }

        public string Shippostalcode
        {
            get { return shippostalcode; }
            set { shippostalcode = value; }
        }

        public string Shipcountry
        {
            get { return shipcountry; }
            set { shipcountry = value; }
        }

        public object Clone()
        {
            Order order = new Order();

            order.Orderid = orderid.Value;
            order.Custid = custid;
            order.Contactname = contactname;
            order.Empid = empid;
            order.Firstname = firstname;
            order.Lastname = lastname;
            order.Orderdate = orderdate;
            order.Requireddate = requireddate;
            order.shippeddate = shippeddate;
            order.shipperid = shipperid;
            order.shipCompanyname = shipCompanyname;
            order.Freight = freight;
            order.Shipname = shipname;
            order.Shipaddress = shipaddress;
            order.Shipcity = Shipcity;
            order.Shipregion = shipregion;
            order.Shippostalcode = shippostalcode;
            order.shipcountry = shipcountry;

            return order;
        }
    }
}