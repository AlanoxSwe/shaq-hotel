using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add MySql Library
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ShaqHotel
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string software;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        public string Server { get { return server; } }

        public string Software { get { return software; } }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            software = "phpmyadmin";
            database = "shaqhotel";
            uid = "test";
            password = "abc123";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            
            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Update(string query)
        {
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand
                {
                    //Assign the query using CommandText
                    CommandText = query,
                    //Assign the connection using Connection
                    Connection = connection
                };

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        
        public List<string>[] Select(string query, params string[] variables)
        {
            //Create a list to store the result

            List<string>[] list = new List<string>[variables.Length];
            for (int i = 0; i < variables.Length; i++)
            {
                list[i] = new List<string>();
            }
            
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    for (int i = 0; i < variables.Length; i++)
                    {
                        list[i].Add(dataReader[variables[i]] + "");
                    }
                    
                }
                
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        /// <summary>
        /// Simple Select from database. Returns string, one entity from database
        /// </summary>
        /// <param name="table">FROM table</param>
        /// <param name="selection">SELECT selection</param>
        /// <param name="selector">WHERE selector</param>
        /// <param name="selectorValue">= selectorValue</param>
        public string SS(string table, string selection, string selector, string selectorValue)
        {
            //Create a list to store the result

            List<string> list = new List<string>();
            //list[0] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT " + selection + " FROM " + table + " WHERE " + selector + "=" + selectorValue, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader[0] + "");

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                //List<String>[] outList = list;
                if(list.Count == 0)
                {
                    return "";
                }
                else
                {
                    return list.ElementAt(0);
                }
               
            }
            else
            {
                return "Cannot connect to database";
            }
        }

        public int Count(string table, string selection)
        {
            //Create a list to store the result

            List<string> list = new List<string>();
            //list[0] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(" + selection + ") FROM " + table, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader[0] + "");

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                //List<String>[] outList = list;
                if (list.Count == 0)
                {
                    return -1;
                }
                else
                {
                    return int.Parse(list.ElementAt(0));
                }

            }
            else
            {
                return -1;
            }
        }

        public string StringOut(List<String>[] select, int field)
        {
            return string.Join(", ", select[field].ToArray());
        }
    

    }
}
