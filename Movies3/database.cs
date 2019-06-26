using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies3
{
    class database
    {//Create Connection and Command,and an Adapter
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();
        //THE CONSTRUCTOR SETS THE DEFAULTS UPON LOADING THE CLASS
        public database()
        {//change the connection string to run from your own music db
            string connectionString = @"Data Source=LAPTOP-Q2KFF8I0\sqlexpress; Initial Catalog=movies ; Integrated Security=True";
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
        }
        public DataTable FillDVCustomerWithCustomer()
        {
            //create a datatable as we only have one table, 
            DataTable dt = new DataTable(); using (da = new SqlDataAdapter("select * from Customer ", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                //fill the datatable from the SQL
                Connection.Close();
                //close the connection
            }

            return dt;
            //pass the datatable data to the DataGridView
        }


        public DataTable FillDVMoviesWithMovies()
        {
            string connectionString = @"Data Source=LAPTOP-Q2KFF8I0\sqlexpress; Initial Catalog=movies ; Integrated Security=True";
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
            //create a datatable as we only have one table, 
            DataTable dt = new DataTable(); using (da = new SqlDataAdapter("select * from Movies ", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                //fill the datatable from the SQL
                Connection.Close();
                //close the connection
            }
            return dt;
            //pass the datatable data to the DataGridView
        }
        public List<string> FillListBoxWithGenre()
        {
            var myCommand = new SqlCommand();
            myCommand = new SqlCommand("select Genre from Movies", Connection);
            //Create a list to hold all the genre,then pass it back to the list box on the form 
            List<string> newgenre = new List<string>();
            Connection.Open();
            SqlDataReader reader = myCommand.ExecuteReader();
            //loop through the genres and pass it to area der,that get sadded to the list 
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    newgenre.Add(reader["Genre"].ToString());
                }
            }
            reader.Close();
            Connection.Close();
            return newgenre;
            //sendthelistbacktothelistbox
        }
        public DataTable FillDVRentedMoviesWithRentedMovies()
        {
            //create a datatable as we only have one table, 
            DataTable dt = new DataTable(); using (da = new SqlDataAdapter("select * from RentedMovies ", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                //fill the datatable from the SQL
                Connection.Close();
                //close the connection
            }
            return dt;
            //pass the datatable data to the DataGridView
        }
        public DataTable FillDVMoviesWithRentedMoviesClick(string RentedMoviesvalue)
        {
            string SQL = "select Rating, Title, Genre, Year, Rental_Cost, Copies, Plot, MovieID  from Movies where MovieID = '" +
               RentedMoviesvalue + "' ";
            using (da = new SqlDataAdapter(SQL, Connection))
            {

                //connect in to the DB and get the SQL
                DataTable mydt = new DataTable();
                //create a datatable as we only have one table, the Owner
                Connection.Open();
                // open a connection to the DB
                da.Fill(mydt);
                // fill the datatable from the SQL 
                Connection.Close();

                //close the connection
                return mydt;
            }

        }
        
        public DataTable FillDVRentedMoviesWithCustomerClick(string RentedMoviesvalue)
        {
            string SQL = "select MovieIDFK, CustIDFK, DateRented, DateReturned, RMID  from RentedMovies where CustIDFK = '" +
                 RentedMoviesvalue + "' ";
            using (da = new SqlDataAdapter(SQL, Connection))
            {

                // connect in to the DB and get the SQL
                DataTable mydt = new DataTable();
                //create a datatable as we only have one table, the Owner
                Connection.Open();
                //open a connection to the DB
                da.Fill(mydt);
                // fill the datatable from the SQL 
                Connection.Close();

                // close the connection
                return mydt;
            }
        }
       
            }
    }

