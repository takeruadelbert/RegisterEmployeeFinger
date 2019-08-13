using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RegisterEmployeeFinger.src.Class.Forms;

namespace RegisterEmployeeFinger.src.Class.Database
{
    public class DB
    {
        private MySqlConnection connection;
        public string server { get; set; }
        public string database { get; set; }
        public string uid { get; set; }
        public string password { get; set; }

        public DB()
        {
            Initialize();
        }

        public DB(string server, string database, string uid, string password)
        {
            server = server;
            database = database;
            uid = uid;
            password = password;
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        private void Initialize()
        {
            server = Properties.Settings.Default.DBHost;
            database = Properties.Settings.Default.DBName;
            uid = Properties.Settings.Default.DBUsername;
            password = Properties.Settings.Default.DBPassword;
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
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
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string query_cmd)
        {
            string query = query_cmd;
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string query_cmd)
        {
            // for example
            string query = query_cmd;
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string query_cmd)
        {
            string query = query_cmd;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public IDictionary<string, Object> get_employee(string nik)
        {
            IDictionary<string, Object> employee = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(nik))
            {
                string query = "SELECT id, nik, emp_firstName as firstName, emp_lastName as lastName FROM `hr_employee` WHERE nik = " + nik;
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
                        employee["id"] = (int)dataReader["id"];
                        string fullname = dataReader["firstName"].ToString() + dataReader["lastName"].ToString();
                        employee["name"] = fullname;
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                }
            }
            return employee;
        }

        public List<IDictionary<string, Object>> get_template(int employee_id)
        {
            List<IDictionary<string, Object>> data = new List<IDictionary<string, object>>();
            string query = "SELECT id, template_index as finger, template_len as length FROM `hr_template` WHERE employee_id = " + employee_id;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    IDictionary<string, Object> temp = new Dictionary<string, Object>();
                    temp.Add("finger", dataReader["finger"]);
                    temp.Add("length", dataReader["length"]);
                    data.Add(temp);
                }
                dataReader.Close();
                this.CloseConnection();
            }
            return data;
        }

        //Count statement
        public int Count()
        {
            // for example
            string query = "SELECT Count(*) FROM settlements";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\MySqlBackup" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error , unable to backup!");
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine("Error , unable to Restore!");
            }
        }

        public bool CheckMySQLConnection()
        {
            bool successful = true;
            try
            {
                successful = this.OpenConnection();
                if (successful)
                {
                    this.CloseConnection();
                }
            }
            catch (MySqlException ex)
            {
                successful = false;
            }
            return successful;
        }

        public int CheckDataFingerExist(int EmployeeID, int indexFinger)
        {
            string query = "SELECT id FROM hr_template WHERE employee_id = '" + EmployeeID + "' AND template_index = '" + indexFinger + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                var reader = cmd.ExecuteReader();
                int template_id = -1;
                while (reader.Read())
                {
                    template_id = reader.GetInt32(0);
                }
                this.CloseConnection();
                ScanFinger.TemplateID = template_id;
                return template_id == -1 ? 0 : 1;
            }
            else
            {
                return -1;
            }
        }
    }
}