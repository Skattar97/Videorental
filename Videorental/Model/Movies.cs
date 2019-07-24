using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videorental.Model
{
    class Movies
    {
        int mid;
        String rating;
        String title;
        String year;
        Double r_cost;
        String copies;
        String plot;
        String genre;


        public void set_Movie_ID(int val)
        {
            mid = val;
        }
        public int get_Movie_ID()
        {
            return mid;
        }

        public void set_Rating(String val)
        {
            rating = val;
        }
        public String get_Rating()
        {
            return rating;
        }

        public void set_Title(String val)
        {
            title = val;
        }
        public String get_Title()
        {
            return title;
        }

        public void set_Year(String val)
        {
            year = val;
        }
        public String get_Year()
        {
            return year;
        }

        public void set_R_Cost(Double val)
        {
            r_cost = val;
        }
        public Double get_R_Cost()
        {
            return r_cost;
        }

        public void set_Plot(String val)
        {
            plot = val;
        }
        public String get_Plot()
        {
            return plot;
        }

        public void set_Genre(String val)
        {
            genre = val;
        }
        public String get_Genre()
        {
            return genre;
        }

        public void set_Copies(String val)
        {
            copies = val;
        }
        public String get_Copies()
        {
            return copies;
        }

        public void insert()
        {
            DBVideoRental obj = new DBVideoRental();
            obj.execteProce(this);

        }

        public void update()
        {
            String query = "update Movies set Rating = '" + get_Rating() 
                + "', Title = " + "'" + get_Title() 
                + "', Year = '" + get_Year() 
                + "', Rental_cost = '" + get_R_Cost()
                + "', Copies = '" + get_Copies()
                + "', Plot = '" + get_Plot()
                + "', Genre = '" + get_Genre()
                + "' where MovieID = " + get_Movie_ID();
            DBVideoRental obj = new DBVideoRental();
            obj.executeData(query);

        }

        public void delete()
        {
            String query = "delete from Movies where MovieID = " + get_Movie_ID();
            DBVideoRental obj = new DBVideoRental();
            obj.executeData(query);

        }
      
        public void getMovies(DataGridView view)
        {
            String query = "select * from Movies";
            DBVideoRental obj = new DBVideoRental();
            System.Data.DataSet ds = obj.getMovies(query);
            view.DataSource = ds.Tables["Movies"].DefaultView;
        }

        public void bind(ComboBox cmov)
        {
            String query = "select MovieID,Title from Movies";
            DBVideoRental obj = new DBVideoRental();
            System.Data.DataTable dt = obj.getMovie(query);
            System.Data.DataRow dr = dt.NewRow();

            dr.ItemArray = new object[] { 0, "-Select Movies-" };
            dt.Rows.InsertAt(dr,0);
            cmov.ValueMember = "MovieID";
            cmov.DisplayMember = "Title";
            cmov.DataSource = dt;
        }
        public void getAllMovies(DataGridView view)
        {
            String query = "select * from Movies where Copies != '0'";
            DBVideoRental obj = new DBVideoRental();
            System.Data.DataSet ds = obj.getMovies(query);
            view.DataSource = ds.Tables["Movies"].DefaultView;
        }
        public void getOutMovies(DataGridView view)
        {
            String query = "select * from Movies where Copies = '0'";
            DBVideoRental obj = new DBVideoRental();
            System.Data.DataSet ds = obj.getMovies(query);
            view.DataSource = ds.Tables["Movies"].DefaultView;
        }
    }
}
