using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WorkHive.Controller;
using WorkHive.Model;

namespace WorkHive.Data
{
    internal class SQLConnect
    {
        #region Global_Connection
        private const string ConnectionString = "Server=DESKTOP-PJ6MDQT;" +
            "Database=WORKHIVE;" +
            "USER ID=WorkHiveClient;" +
            "PASSWORD=Huskar@2002;";

        static MySqlConnection conn = new MySqlConnection(ConnectionString);

        #endregion 

        public static event Action RefreshLists;

        public static List<ProjectModel> GetProjectsFromDB(string query)
        {
            List<ProjectModel> results = new List<ProjectModel>();


            try
            {
                conn.Open();
                using (var reader = new MySqlCommand(query, conn).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new ProjectModel
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["Name"],
                            Description = (string)reader["Description"],
                            StartDate = (DateTime)reader["StartDate"],
                            DeadLine = (DateTime)reader["DeadLine"],
                            Progress = (int)reader["Progress"],
                            Archived = (bool)reader["Archived"]
                        });
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return results;
        }

        public static List<MemberModel> GetMembersFromDB(string query)
        {
            List<MemberModel> results = new List<MemberModel>();

            try
            {
                conn.Open();
                using (var reader = new MySqlCommand(query, conn).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new MemberModel
                        {
                            //Basic info
                            ID = (int)reader["ID"],
                            Email = (string)reader["Email"],
                            Password = (string)reader["Password"],
                            IsLeader = (bool)reader["IsLeader"],
                            Profile_Pic = (string)reader["ProfilePic"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            MiddleName = (string)reader["MiddleName"],
                            ExtensionName = (string)reader["Extension"],
                            ContactNumber = (int)reader["ContactNumber"],
                            Sex = (sex)Convert.ToInt32(reader["Sex"]),
                            BloodType = (bloodType)Convert.ToInt32(reader["BloodType"]),
                            Birthdate = (DateTime)reader["Birthdate"],


                            //Address
                            HouseNumber = (string)reader["HouseNummber"],
                            Street = (string)reader["Street"],
                            Barangay = (string)reader["Barangay"],
                            City_Municipality = (string)reader["City_Municipality"],
                            Province = (string)reader["Province"],
                            ZipCode = Convert.ToInt32(reader["ZipCode"])

                        });
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return results;
        }
        
        public static List<TaskModel> GetTasksFromDB(string query)
        {
            List<TaskModel> results = new List<TaskModel>();


            try
            {
                conn.Open();
                using (var reader = new MySqlCommand(query, conn).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new TaskModel
                        {
                            TaskID = (int)reader["TaskID"],
                            TaskName = (string)reader["TaskName"],
                            TaskDescription = (string)reader["TaskDescription"],
                            TaskStart = (DateTime)reader["TaskStartDate"],
                            TaskCompleted = (DateTime)reader["TaskCompleted"],
                            TaskStatus = (Status)Convert.ToInt32(reader["TaskStatus"]),
                            Deadline = (DateTime)reader["Deadline"],
                            ProjectAssigned = ProjectModelAccess.GetProjectDetails((int)reader["ProjectAssigned"])

                        }) ;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return results;
        }

        public static void ExecuteNonQuery(string query)
        {

            try
            {
                conn.Open();
                MySqlCommand com = new MySqlCommand(query, conn);
                com.ExecuteNonQuery();

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                
            }
            

        }
    }
}
