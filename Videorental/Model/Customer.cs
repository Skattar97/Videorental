using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videorental.Model
{
    class Customer
    {
        int c_id;
        String fname;
        String lname;
        String address;
        String phone;

        public void set_Cust_ID(int val)
        {
            c_id = val;
        }
        public int get_Cust_ID()
        {
            return c_id;
        }
        public void set_FName(String val)
        {
            fname = val;
        }
        public String get_FName()
        {
            return fname;
        }
        public void set_LName(String val)
        {
            lname = val;
        }
        public String get_LName()
        {
            return lname;
        }
        public void set_Address(String val)
        {
            address = val;
        }
        public String get_Address()
        {
            return address;
        }
        public void set_Phone(String val)
        {
            phone = val;
        }
        public String get_Phone()
        {
            return phone;
        }

        public void insert()
        {
            String query = "insert into Customer(FirstName, LastName, Address, Phone) VALUES ('" + get_FName()+"', '"+get_LName()+"', '"+get_Address()+"', '"+ get_Phone()+"')";
            DBVideoRental obj = new DBVideoRental();
            obj.executeData(query);
            
        }

        public void update()
        {
            String query = "update Customer set FirstName = '" + get_FName() + "', LastName = " + "'" + get_LName() + "', Address = '" + get_Address() + "', Phone = '" + get_Phone() + "' where CustID = "+get_Cust_ID();
            DBVideoRental obj = new DBVideoRental();
            obj.executeData(query);

        }

        public void delete()
        {
            String query = "delete from Customer where CustID = " + get_Cust_ID();
            DBVideoRental obj = new DBVideoRental();
            obj.executeData(query);

        }
        public void getCustomer(DataGridView view)
        {
            String query = "select * from Customer";
            DBVideoRental obj = new DBVideoRental();
            DataSet ds = obj.getCustomer(query);
            view.DataSource = ds.Tables["Customer"].DefaultView;
        }

        public void bind(ComboBox ccust)
        {
            String query = "select CustID,FirstName from Customer";
            DBVideoRental obj = new DBVideoRental();
            System.Data.DataTable dt = obj.getMovie(query);
            System.Data.DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "-Select Customer-" };
            dt.Rows.InsertAt(dr, 0);
            ccust.ValueMember = "CustID";
            ccust.DisplayMember = "FirstName";
            ccust.DataSource = dt;
        }
    }
}
