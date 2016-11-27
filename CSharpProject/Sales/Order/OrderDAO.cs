using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3;

namespace CSharpProject.Sales.Order
{
    enum DateCategory
    {
        Order,
        Required,
        Shipped
        //todo can search empty shipped date
    }

    class OrderDAO
    {
        private string _connectionString;
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        private SqlDataReader _sqlDataReader;

        public OrderDAO()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString;
            _sqlConnection = new SqlConnection();
            _sqlConnection.ConnectionString = _connectionString;
        }

        public List<Order> LoadAll()
        {
            List<Order> orders = new List<Order>();
            try
            {
                _sqlConnection.Open();
                
                _sqlCommand = _sqlConnection.CreateCommand();

                _sqlCommand.CommandText = "[SelectAllOrder]";
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlDataReader = _sqlCommand.ExecuteReader();

                while (_sqlDataReader.Read())
                {
                    orders.Add(new Order(_sqlDataReader));
                }
            }
            finally
            {
                _sqlDataReader?.Close();
                _sqlConnection?.Close();
            }
            return orders;
        }

        public List<Order> SearchName(string searchValue)
        {
            List<Order> orders = new List<Order>();
            try
            {
                _sqlConnection.Open();
                _sqlCommand = _sqlConnection.CreateCommand();
                _sqlCommand.CommandText = "[SearchOrderByCustomerName]";
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                //                @SearchValue nvarchar(30)
                _sqlCommand.Parameters.Add("@SearchValue", SqlDbType.NVarChar, 30).Value = searchValue;

                _sqlDataReader = _sqlCommand.ExecuteReader();

                while (_sqlDataReader.Read())
                {
                    orders.Add(new Order(_sqlDataReader));
                }
            }
            finally
            {
                _sqlDataReader?.Close();
                _sqlConnection?.Close();
            }
            return orders;
        }

        public void AddOrder(Order order)
        {
            try
            {
                _sqlConnection.Open();
                _sqlCommand = _sqlConnection.CreateCommand();

                _sqlCommand.CommandText = "[dbo].[InsertOrder]";
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameterCollection paramCollection = _sqlCommand.Parameters;

                //@custid int

                if (order.Custid != null)
                {
                    paramCollection.Add("@custid", SqlDbType.Int).Value = order.Custid.Value;
                }
                else
                {
                    paramCollection.Add("@custid", SqlDbType.Int).Value = DBNull.Value;

                }

                //@empid int,
                paramCollection.Add("@empid", SqlDbType.Int).Value = order.Empid;

                //@orderdate dateTime,
                paramCollection.Add("@orderdate", SqlDbType.DateTime).Value = order.Orderdate;

                //@requireddate dateTime,
                paramCollection.Add("@requireddate", SqlDbType.DateTime).Value = order.Requireddate;

                //@shippeddate dateTime,
                if (order.Shippeddate != null)
                {
                    paramCollection.Add("@shippeddate", SqlDbType.DateTime).Value = order.Shippeddate.Value;
                }
                else
                {
                    paramCollection.Add("@shippeddate", SqlDbType.DateTime).Value = DBNull.Value;
                }

                //@shipperid int,
                paramCollection.Add("@shipperid", SqlDbType.Int).Value = order.Shipperid;

                //@freight money,
                paramCollection.Add("@freight", SqlDbType.Money).Value = order.Freight;

                //@shipname nvarchar(40),
                paramCollection.Add("@shipname", SqlDbType.NVarChar, 40).Value = order.Shipname;

                //@shipaddress nvarchar(60),
                paramCollection.Add("@shipaddress", SqlDbType.NVarChar, 60).Value = order.Shipaddress;

                //@shipcity nvarchar(15),
                paramCollection.Add("@shipcity", SqlDbType.NVarChar, 15).Value = order.Shipcity;

                //@shipregion nvarchar(15),
                if (String.IsNullOrWhiteSpace(order.Shipregion) == false)
                {
                    paramCollection.Add("@shipregion", SqlDbType.NVarChar, 15).Value = order.Shipregion;
                }
                else
                {
                    paramCollection.Add("@shipregion", SqlDbType.NVarChar, 15).Value = DBNull.Value;

                }

                //@shippostalcode nvarchar(10),
                if (String.IsNullOrWhiteSpace(order.Shippostalcode) == false)
                {
                    paramCollection.Add("@shippostalcode", SqlDbType.NVarChar, 10).Value = order.Shippostalcode;
                }
                else
                {
                    paramCollection.Add("@shippostalcode", SqlDbType.NVarChar, 10).Value = DBNull.Value;

                }


                //@shipcountry nvarchar(15)
                paramCollection.Add("@shipcountry", SqlDbType.NVarChar, 15).Value = order.Shipcountry;

                _sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                _sqlConnection?.Close();
            }
        }

        public void UpdateOrder(Order order)
        {
            try
            {
                _sqlConnection.Open();
                _sqlCommand = _sqlConnection.CreateCommand();

                _sqlCommand.CommandText = "[dbo].[UpdateOrder]";
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameterCollection paramCollection = _sqlCommand.Parameters;

                //@orderid int,
                paramCollection.Add("@orderid", SqlDbType.Int).Value = order.Orderid;


                //@custid int
                if (order.Custid != null)
                {
                    paramCollection.Add("@custid", SqlDbType.Int).Value = order.Custid.Value;
                }
                else
                {
                    paramCollection.Add("@custid", SqlDbType.Int).Value = DBNull.Value;

                }

                //@empid int,
                paramCollection.Add("@empid", SqlDbType.Int).Value = order.Empid;

                //@orderdate dateTime,
                paramCollection.Add("@orderdate", SqlDbType.DateTime).Value = order.Orderdate;

                //@requireddate dateTime,
                paramCollection.Add("@requireddate", SqlDbType.DateTime).Value = order.Requireddate;

                //@shippeddate dateTime,
                if (order.Shippeddate != null)
                {
                    paramCollection.Add("@shippeddate", SqlDbType.DateTime).Value = order.Shippeddate.Value;
                }
                else
                {
                    paramCollection.Add("@shippeddate", SqlDbType.DateTime).Value = DBNull.Value;
                }

                //@shipperid int,
                paramCollection.Add("@shipperid", SqlDbType.Int).Value = order.Shipperid;

                //@freight money,
                paramCollection.Add("@freight", SqlDbType.Money).Value = order.Freight;

                //@shipname nvarchar(40),
                paramCollection.Add("@shipname", SqlDbType.NVarChar, 40).Value = order.Shipname;

                //@shipaddress nvarchar(60),
                paramCollection.Add("@shipaddress", SqlDbType.NVarChar, 60).Value = order.Shipaddress;

                //@shipcity nvarchar(15),
                paramCollection.Add("@shipcity", SqlDbType.NVarChar, 15).Value = order.Shipcity;

                //@shipregion nvarchar(15),
                if (String.IsNullOrWhiteSpace(order.Shipregion) == false)
                {
                    paramCollection.Add("@shipregion", SqlDbType.NVarChar, 15).Value = order.Shipregion;
                }
                else
                {
                    paramCollection.Add("@shipregion", SqlDbType.NVarChar, 15).Value = DBNull.Value;

                }

                //@shippostalcode nvarchar(10),
                if (String.IsNullOrWhiteSpace(order.Shippostalcode) == false)
                {
                    paramCollection.Add("@shippostalcode", SqlDbType.NVarChar, 10).Value = order.Shippostalcode;
                }
                else
                {
                    paramCollection.Add("@shippostalcode", SqlDbType.NVarChar, 10).Value = DBNull.Value;

                }


                //@shipcountry nvarchar(15)
                paramCollection.Add("@shipcountry", SqlDbType.NVarChar, 15).Value = order.Shipcountry;

                _sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                _sqlConnection?.Close();
            }
        }

        public void DeleteOrder(int orderId)
        {
            try
            {
                _sqlConnection.Open();
                _sqlCommand = _sqlConnection.CreateCommand();
                _sqlCommand.CommandText = "[DeleteOrder]";
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.Parameters.Add("@orderid", SqlDbType.Int).Value = orderId;

                _sqlCommand.ExecuteNonQuery();
                
            }
            finally
            {
                _sqlConnection?.Close();
            }
        }

        public bool HaveOrderDetail(int orderId)
        {
            try
            {
                _sqlConnection.Open();
                _sqlCommand = _sqlConnection.CreateCommand();
                _sqlCommand.CommandText = "[GetOrderDetail]";
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.Parameters.Add("@orderid", SqlDbType.Int).Value = orderId;

                _sqlDataReader =  _sqlCommand.ExecuteReader();

                if (_sqlDataReader.Read())
                {
                    return true;
                }
            }
            finally
            {
                _sqlDataReader?.Close();
                _sqlConnection?.Close();
            }
            return false;
        }

        public List<Order> SearchOrderByDate(DateCategory searchCategory, DateTime fromTime, DateTime toTime)
        {
            List<Order> orders = new List<Order>();
            try
            {
                _sqlConnection.Open();
                _sqlCommand = _sqlConnection.CreateCommand();
                switch (searchCategory)
                {
                    case DateCategory.Order:
                        _sqlCommand.CommandText = "[SearchOrderByOrderDateRange]";
                        break;
                    case DateCategory.Required:
                        _sqlCommand.CommandText = "[SearchOrderByRequiredDateRange]";
                        break;
                    case DateCategory.Shipped:
                        _sqlCommand.CommandText = "[SearchOrderByShippedDateRange]";
                        break;
                }


                _sqlCommand.CommandType = CommandType.StoredProcedure;
                // @FromDate DateTime,
                _sqlCommand.Parameters.Add("@FromDate", SqlDbType.Date).Value = fromTime;
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                //@ToDate DateTime
                _sqlCommand.Parameters.Add("@ToDate", SqlDbType.Date).Value = toTime;

                _sqlDataReader = _sqlCommand.ExecuteReader();

                while (_sqlDataReader.Read())
                {
                    orders.Add(new Order(_sqlDataReader));
                }
            }
            finally
            {
                _sqlDataReader?.Close();
                _sqlConnection?.Close();
            }
            return orders;
        }
    }
}