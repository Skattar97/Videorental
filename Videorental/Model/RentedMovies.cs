using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Videorental.Model
{
    class RentedMovies
    {
        int rmid;
        int cid;
        int mid;
        String date_rented;
        String date_returned;

        public RentedMovies()
        {

        }
        public int get_RMID()
        {
            return rmid;
        }
        public void set_RMID(int val)
        {
            rmid = val;
        }

        public int get_MID()
        {
            return mid;
        }
        public void set_MID(int val)
        {
            mid = val;
        }
        public int get_CID()
        {
            return cid;
        }
        public void set_CID(int val)
        {
            cid = val;
        }
        public String get_Rented_date()
        {
            return date_rented;
        }
        public void set_Rented_date(String val)
        {
            date_rented = val;
        }

        public String get_Returned_date()
        {
            return date_returned;
        }
        public void set_Returned_date(String val)
        {
            date_returned = val;
        }

        public bool checkStock()
        {
            String query = "select Copies from Movies where MovieID = " + get_MID();
            DBVideoRental obj = new DBVideoRental();
            string copies = obj.getStock(query);
            int cop = int.Parse(copies);
            if (cop <= 0) return false;
            return true;

        }

        public void insert()
        {
            if (checkStock())
            {
                String query = "insert into RentedMovies (CustIDFK, MovieIDFk, DateRented) VALUES (" + get_CID() + ", " + get_MID() + ", GETDATE())";
                //MessageBox.Show(query);
                DBVideoRental obj = new DBVideoRental();
                obj.executeData(query);
                query = "update Movies set Copies = (Convert(INT,Copies)-1) where MovieID = " + get_MID();
                obj.executeData(query);
            }
            else
            {
                MessageBox.Show("sorry movies is out of stock.");
            }
        }

        public void update()
        {
            //RMID,MovieIDFk,CustIDFK,DateRented,DateReturned
            //String query = "update RentedMovies set MovieIDFk = " + get_MID() + ", CustIDFK = "  + get_CID() + ", DateRented = " + get_Rented_date() + ", DateReturned = " + get_Returned_date() + " where RMID = " + get_RMID();
            //DBVideoRental obj = new DBVideoRental();
            //obj.executeData(query);

        }

        public void returned()
        {
            String query = "update RentedMovies set DateReturned= GETDATE()  where MovieIDFk = "+ get_MID() + "and CustIDFK = "  + get_CID();
            DBVideoRental obj = new DBVideoRental();
            obj.executeData(query);
            query = "update Movies set Copies = (Convert(INT,Copies)+1) where MovieID = " + get_MID();
            obj.executeData(query);
        }
        public void getRentedMovies(DataGridView view)
        {
            //String query = "select * from RentedMovies";vw_outrentedmovies
            DBVideoRental obj = new DBVideoRental();
            DataSet ds = obj.getRentedMovieData("vw_rentedmovies");
            view.DataSource = ds.Tables["RentedMovies"].DefaultView;
        }

        public void getoutRentedMovies(DataGridView view)
        {
            //String query = "select * from RentedMovies";
            DBVideoRental obj = new DBVideoRental();
            DataSet ds = obj.getRentedMovieData("vw_outrentedmovies");
            view.DataSource = ds.Tables["RentedMovies"].DefaultView;
        }
    }
}
