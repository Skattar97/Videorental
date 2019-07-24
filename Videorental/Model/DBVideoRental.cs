using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Videorental.Model
{
    class DBVideoRental
    {
        SqlConnection con;
        public DBVideoRental()
        {
            try
            {
                string str  =ConfigurationManager.ConnectionStrings["connString"].ToString();
                con = new SqlConnection(str);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        public void execteProce(Movies obj)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PR_INSERT_MOVIE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IN_Rating", obj.get_Rating());
                cmd.Parameters.AddWithValue("@IN_Year",  obj.get_Year());
                cmd.Parameters.AddWithValue("@IN_Title",  obj.get_Title());
                cmd.Parameters.AddWithValue("@IN_Copies", obj.get_Copies());
                cmd.Parameters.AddWithValue("@IN_Genre",  obj.get_Genre());
                cmd.Parameters.AddWithValue("@IN_Plot", obj.get_Plot());
                int row = cmd.ExecuteNonQuery();
                if (row == 1)
                    MessageBox.Show("DB Updated");
                else
                    MessageBox.Show("DB Not Updated");
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        public void executeData(String query)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int row= cmd.ExecuteNonQuery();
                if(row == 1)
                MessageBox.Show("DB Updated");
                else
                    MessageBox.Show("DB Not Updated");
                con.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
        }

        public String getStock(String query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            string value = (string)cmd.ExecuteScalar();
            con.Close();
            return value;
        }
        public DataSet getRentedMovieData(String view)
        {
            con.Open();
            String query = "select * from " + view;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataSet ds = new DataSet();
            da.Fill(ds, "RentedMovies");
            con.Close();
            return ds;
        }

        public DataSet getCustomer(String query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customer");
            con.Close();
            return ds;

        }

        public DataSet getMovies (String query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Movies");
            con.Close();
            return ds;

        }

        public DataTable getMovie(String query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
    }
}
