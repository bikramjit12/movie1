using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies3
{
    public partial class Form1 : Form

    {//create an instance of the Database class
        database myDatabase = new database();
        public Form1()
        {
            InitializeComponent();
            loadDB();

        }

        public void loadDB()
        {//load the Customer
            DisplayDataGridViewCustomers();
            DisplayListBox();
            DisplayDataGridViewMovies();
            DisplayDataGridViewRentedMovies();
        }
        //LOAD THE Customer DATAGRID
        private void DisplayDataGridViewCustomers()
        {
            //clear out the old data
            DVCustomer.DataSource = null;
            try
            {
                DVCustomer.DataSource = myDatabase.FillDVCustomerWithCustomer();
                //pass the datatable data to the DataGridView
                DVCustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void DisplayDataGridViewRentedMovies()
        {
            //clear out the old data
            DVRentedMovies.DataSource = null;
            try
            {
                DVRentedMovies.DataSource = myDatabase.FillDVRentedMoviesWithRentedMovies();
                //pass the datatable data to the DataGridView
                DVRentedMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        //LOAD THE OWNER DATAGRID
        private void DisplayDataGridViewMovies()
        {
            //clear out the old data
            DVMovies.DataSource = null;
            try
            {
                DVMovies.DataSource = myDatabase.FillDVMoviesWithMovies();
                //pass the datatable data to the DataGridView
                DVMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void DisplayListBox()
        {
            //clear old data out
            DVMovies.DataSource = null;
            lbGenre.DataSource = null;
            try
            {
                lbGenre.DataSource = myDatabase.FillListBoxWithGenre();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        

        private void DVCustomer_CellcontentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CustID = 0;
            //these are the cell clicks for the values in the row that you click on
            try
            {
                CustID = (int)DVCustomer.Rows[e.RowIndex].Cells[0].Value;
                txtFirstName.Text = DVCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = DVCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                //if you are clicking on a row and not outside it
                if (e.RowIndex >= 0)
                {
                    
                    DVRentedMovies.DataSource = myDatabase.FillDVRentedMoviesWithCustomerClick(CustID.ToString());
                    DVRentedMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    txtCustID.Text = CustID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DisplayDataGridViewCustomers();
        }
      

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DVRentedMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RMID = 0;
            //these are the cell clicks for the values in the row that you click on
            try
            {
                RMID = (int)DVRentedMovies.Rows[e.RowIndex].Cells[0].Value;
              
                txtMoviesFKID.Text = DVRentedMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCustFKID.Text = DVRentedMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                // if you are clicking on a row and not outside it
                if (e.RowIndex >= 0)
                {
                    
                    DVMovies.DataSource = myDatabase.FillDVMoviesWithRentedMoviesClick(RMID.ToString());
                    DVMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    txtRMID.Text = RMID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string NewEntry = "INSERT INTO Customer (FirstName, LastName, Address, Phone) VALUES(@FirstName, @LastName, @Address, @Phone)";
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=LAPTOP-Q2KFF8I0\SQLEXPRESS;Initial Catalog=movies;Integrated Security=True";
            Con.ConnectionString = connectionString;

            using (SqlCommand newdata = new SqlCommand(NewEntry, Con))
            {
                newdata.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                newdata.Parameters.AddWithValue("@LastName", txtLastName.Text);
                newdata.Parameters.AddWithValue("@Address", txtAddress.Text);
                newdata.Parameters.AddWithValue("@Phone", txtPhone.Text);
                Con.Open();
                //open a connection to the database
                // its a NONQuery as it doesn't return any data its only going up to the server 
                newdata.ExecuteNonQuery();
                //Run the Query 
                Con.Close();
                //Close a connection to the database//
                MessageBox.Show ("Data has been Inserted!!");
            }
            // Run the Load Data base method we made earler to see the newdata.
            loadDB();}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatestatement = "UPDATE Customer set FirstName=@FirstName, LastName=@LastName, Address=@Address, Phone=@phone where CustID=@CustID";
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=LAPTOP-Q2KFF8I0\SQLEXPRESS;Initial Catalog=movies ;Integrated Security=True";
            Con.ConnectionString = connectionString;

            using (SqlCommand update = new SqlCommand(updatestatement, Con))
            {
                update.Parameters.AddWithValue("CustID", txtCustID.Text);
                update.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                update.Parameters.AddWithValue("@LastName", txtLastName.Text);
                update.Parameters.AddWithValue("@Address", txtAddress.Text);
                update.Parameters.AddWithValue("@Phone", txtPhone.Text);
                Con.Open();
                //open a connection to the database
                // its a NONQuery as it doesn't return any data its only going up to the server 
               update.ExecuteNonQuery();
                //Run the Query 
                Con.Close();
                //Close a connection to the database//
                MessageBox.Show("Data has been Update!!");
            }
            // Run the Load Data base method we made earler to see the newdata.
            loadDB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string DeleteCommand = "Delete Customer where CustID=@CustID";
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=LAPTOP-Q2KFF8I0\SQLEXPRESS;Initial Catalog=movies ;Integrated Security=True";
            Con.ConnectionString = connectionString;

            using (SqlCommand DeleteData = new SqlCommand(DeleteCommand, Con)) 
            {
                DeleteData.Parameters.AddWithValue("@CustID", txtCustID.Text);
                Con.Open();
                DeleteData.ExecuteNonQuery();
                Con.Close();
            }
            loadDB();
        }

        private void lblMovies_Click(object sender, EventArgs e)
        {

        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            string NewEntry = "INSERT INTO Movies (Rating, Title, Year, Rental_cost, Copies, Plot, Genre) VALUES(@Rating, @Title, @Year, @Rental_cost, @Copies, @Plot, @Genre)";
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=LAPTOP-Q2KFF8I0\SQLEXPRESS;Initial Catalog=movies ;Integrated Security=True";
            Con.ConnectionString = connectionString;

            using (SqlCommand newdata = new SqlCommand(NewEntry, Con))
            {
                newdata.Parameters.AddWithValue("@Rating", txtRating.Text);
                newdata.Parameters.AddWithValue("@Title", txtTitle.Text);
                newdata.Parameters.AddWithValue("@Year", txtYear.Text);
                newdata.Parameters.AddWithValue("@Rental_cost", txtRental_Cost.Text);
                newdata.Parameters.AddWithValue("@Copies", txtCopies.Text);
                newdata.Parameters.AddWithValue("@Plot", txtPlot.Text);
                newdata.Parameters.AddWithValue("@Genre", txtGenre.Text);
                Con.Open();
                //open a connection to the database
                // its a NONQuery as it doesn't return any data its only going up to the server 
                newdata.ExecuteNonQuery();
                //Run the Query 
                Con.Close();
                //Close a connection to the database//
                MessageBox.Show("Data has been Inserted!!");
            }
            // Run the Load Data base method we made earler to see the newdata.
            loadDB();
        }

        private void btnDeleteM_Click(object sender, EventArgs e)
        {
            string DeleteCommand = "Delete Movies where MovieID=@MovieID";
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=LAPTOP-Q2KFF8I0\SQLEXPRESS;Initial Catalog=movies ;Integrated Security=True";
            Con.ConnectionString = connectionString;

            using (SqlCommand DeleteData = new SqlCommand(DeleteCommand, Con))
            {
                DeleteData.Parameters.AddWithValue("@MovieID", txtMovieID.Text);
                Con.Open();
                DeleteData.ExecuteNonQuery();
                Con.Close();
            }
            loadDB();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            string NewEntry = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented, DateReturned) VALUES(@MovieIDFK, @CustIDFK, @DateRented, @DateReturned)";
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=LAPTOP-Q2KFF8I0\SQLEXPRESS;Initial Catalog=movies;Integrated Security=True";
            Con.ConnectionString = connectionString;

            using (SqlCommand newdata = new SqlCommand(NewEntry, Con))
            {
                newdata.Parameters.AddWithValue("@MovieIDFK", txtMoviesFKID.Text);
                newdata.Parameters.AddWithValue("@CustIDFK", txtCustFKID.Text);
                newdata.Parameters.AddWithValue("@DateRented", txtDateRented.Text);
                newdata.Parameters.AddWithValue("@DateReturned", txtDateRetured.Text);
                Con.Open();
                //open a connection to the database
                // its a NONQuery as it doesn't return any data its only going up to the server 
                newdata.ExecuteNonQuery();
                //Run the Query 
                Con.Close();
                //Close a connection to the database//
                MessageBox.Show("Data has been Inserted!!");
            }
            // Run the Load Data base method we made earler to see the newdata.
            loadDB();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string updatestatement = "UPDATE RentedMovies set MovieIDFK=@MovieIDFK, CustIDFK=@CustIDFK, DateRented=@DateRented, DateReturned=@DateReturned where RMID=@RMID";
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=LAPTOP-Q2KFF8I0\SQLEXPRESS;Initial Catalog=movies ;Integrated Security=True";
            Con.ConnectionString = connectionString;

            using (SqlCommand update = new SqlCommand(updatestatement, Con))
            {
                update.Parameters.AddWithValue("RMID", txtRMID.Text);
                update.Parameters.AddWithValue("@MovieIDFK", txtMoviesFKID.Text);
                update.Parameters.AddWithValue("@CustIDFK", txtCustFKID.Text);
                update.Parameters.AddWithValue("@DateRented", txtDateRented.Text);
                update.Parameters.AddWithValue("@DateReturned", txtDateRetured.Text);
                Con.Open();
                //open a connection to the database
                // its a NONQuery as it doesn't return any data its only going up to the server 
                update.ExecuteNonQuery();
                //Run the Query 
                Con.Close();
                //Close a connection to the database//
                MessageBox.Show("Data has been Update!!");
            }
            // Run the Load Data base method we made earler to see the newdata.
            loadDB();
        }
    }
}
    
        
    


    