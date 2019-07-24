using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Videorental.Model;

namespace Videorental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCustomers();
            //DBVideoRental obj = new DBVideoRental();
            //obj.connection();
        }

      
        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tab.SelectedIndex)
            {
                case 0: 
                    LoadCustomers();
                    break;
                case 1: 
                    LoadMovies();
                    break;
                case 2: 
                    LoadRental();
                    break;
            }
        }

        private void LoadRental()
        {
            BindRetnal();
        }

        private void LoadMovies()
        {
            BindMovies();
        }

        private void LoadCustomers()
        {
            //label3.Text = "Customer";
            BindCustomer();
        }

        public void BindCustomer()
        {
            Customer obj = new Customer();
            obj.getCustomer(dataGridView1);
            

        }
        public void BindMovies()
        {
            Movies obj = new Movies();
            obj.getMovies(dataGridView2);

        }
        public void BindRetnal()
        {
            RentedMovies obj = new RentedMovies();
            obj.getRentedMovies(dataGridView3);
            bindcmov();
            bindcust();
        }
        public void bindcust()
        {
            Customer obj = new Customer();
            obj.bind(ddcust);
        }
        public void bindcmov()
        {
            Movies obj = new Movies();
            obj.bind(ddmov);
        }
        private void btnaddcust_Click(object sender, EventArgs e)
        {
            if (checkCustVariable())
            {
                Customer cust = new Customer();
                cust.set_FName(textFname.Text);
                cust.set_LName(textLname.Text);
                cust.set_Phone(textPhone.Text);
                cust.set_Address(textAddress.Text);
                cust.insert();
                BindCustomer();
                clear();
            }
        }
        public void clear()
        {
            textFname.Text = "";
            textLname.Text = "";
            textAddress.Text = "";
            textPhone.Text = "";
            label12.Text = "";
            textMyear.Text = "";
            textMcopies.Text = "";
            //textMcost.Text = "";
            textMgenre.Text = "";
            textMplot.Text = "";
            textMrating.Text = "";
            textMtitle.Text = "";
            //textcid.Text = "";
            //textmid.Text = "";

        }
        private bool checkCustVariable()
        {
            if(textFname.Text == "" )
            {
                MessageBox.Show("Enter Firstname");
                return false;
            }
            else if(textLname.Text == "")
            {
                MessageBox.Show("Enter Lasttname");
                return false;
            }
            else if (textAddress.Text=="")
            {
                MessageBox.Show("Enter Address");
                return false;
            }
            else if(textPhone.Text=="")
            {
                MessageBox.Show("Enter Phone");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label12.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textFname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textLname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }

        private void btnupdatecust_Click(object sender, EventArgs e)
        {
            if (checkCustVariable())
            {
                Customer cust = new Customer();
                cust.set_Cust_ID(int.Parse(label12.Text));
                cust.set_FName(textFname.Text);
                cust.set_LName(textLname.Text);
                cust.set_Phone(textPhone.Text);
                cust.set_Address(textAddress.Text);
                cust.update();
                clear();
                BindCustomer();
            }
        }

        private void btndelcust_Click(object sender, EventArgs e)
        {
            if (checkCustVariable())
            {
                Customer cust = new Customer();
                cust.set_Cust_ID(int.Parse(label12.Text));
                cust.delete();
                BindCustomer();
                clear();
            }
        }



        //Movies


        private bool checkMVariable()
        {
            if (textMtitle.Text == "")
            {
                MessageBox.Show("Enter Title");
                return false;
            }
            else if (textMrating.Text == "")
            {
                MessageBox.Show("Enter Rating");
                return false;
            }
            else if (textMyear.Text == "")
            {
                MessageBox.Show("Enter Year");
                return false;
            }
            else if (textMplot.Text == "")
            {
                MessageBox.Show("Enter Plot");
                return false;
            }
            else if (textMgenre.Text == "")
            {
                MessageBox.Show("Enter Genre");
                return false;
            }
            else if (textMcopies.Text == "")
            {
                MessageBox.Show("Enter Copies");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnaddmov_Click(object sender, EventArgs e)
        {
            if (checkMVariable())
            {
                Movies mov = new Movies();
                mov.set_Title(textMtitle.Text);
                mov.set_Rating(textMrating.Text);
                mov.set_Year(textMyear.Text);
                //mov.set_R_Cost(Double.Parse(textMcost.Text));
                mov.set_Plot(textMplot.Text);
                mov.set_Copies(textMcopies.Text);
                mov.set_Genre(textMgenre.Text);
                mov.insert();
                BindMovies();
                clear();
            }
        }

        private void btnupdatemov_Click(object sender, EventArgs e)
        {
            if (checkMVariable())
            {
                Movies mov = new Movies();
                mov.set_Movie_ID(int.Parse(label13.Text));
                mov.set_Title(textMtitle.Text);
                mov.set_Rating(textMrating.Text);
                mov.set_Year(textMyear.Text);
                //mov.set_R_Cost(Double.Parse(textMcost.Text));
                mov.set_Plot(textMplot.Text);
                mov.set_Copies(textMcopies.Text);
                mov.set_Genre(textMgenre.Text);
                mov.update();
                BindMovies();
                clear();
            }
        }

        private void btndelmov_Click(object sender, EventArgs e)
        {
            if (checkMVariable())
            {
                Movies mov = new Movies();
                mov.set_Movie_ID(int.Parse(label13.Text));
                mov.delete();
                BindMovies();
                clear();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label13.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textMrating.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textMtitle.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textMyear.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            //textMcost.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            textMcopies.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            textMplot.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            textMgenre.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
        }


        //Rented Movie

       
        private void btnissumov_Click(object sender, EventArgs e)
        {
                RentedMovies rmov = new RentedMovies();
                int index = ddcust.SelectedIndex;
                if (index != 0)
                {
                    int val = (int)ddcust.SelectedValue;
                    rmov.set_CID(val);
                }
                else
                {
                    MessageBox.Show("Select Customer");
                }
                index = ddmov.SelectedIndex;
                if (index != 0)
                {
                    int val = (int)ddmov.SelectedValue;
                    rmov.set_MID(val);
                }
            else
            {
                MessageBox.Show("Select Customer");
            }
            if (rmov.get_CID()!= 0 && rmov.get_MID()!=0)
                rmov.insert();
                BindRetnal();
        }

        private void btnretmov_Click(object sender, EventArgs e)
        {
            RentedMovies rmov = new RentedMovies();
            int index = ddcust.SelectedIndex;
            if (index != 0)
            {
                int val = (int)ddcust.SelectedValue;
                rmov.set_CID(val);
            }
            else
            {
                MessageBox.Show("Select Customer");
            }
            index = ddmov.SelectedIndex;
            if (index != 0)
            {
                int val = (int)ddmov.SelectedValue;
                rmov.set_MID(val);
            }
            else
            {
                MessageBox.Show("Select Customer");
            }
            if (rmov.get_CID() != 0 && rmov.get_MID() != 0)

            //rmov.set_RMID(int.Parse(textrmid.Text));
            //rmov.set_CID(int.Parse(lblcidfk.Text));
            //rmov.set_MID(int.Parse(lblmidfk.Text));
            rmov.returned();
            BindRetnal();
        }

        private void ddcust_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int index = comboBox.SelectedIndex;
            
            if(index != 0) {
                int val = (int)comboBox.SelectedValue;
            }

        }

        private void ddmov_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int index = comboBox.SelectedIndex;

            if (index != 0)
            {
                int val = (int)comboBox.SelectedValue;
            }
        }

        private void radioall_Click(object sender, EventArgs e)
        {
            RentedMovies mov = new RentedMovies();
            mov.getRentedMovies(dataGridView3);
        }

        private void radioout_Click(object sender, EventArgs e)
        {
            RentedMovies mov = new RentedMovies();
            mov.getoutRentedMovies(dataGridView3);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textrmid.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblcidfk.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            lblmidfk.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
