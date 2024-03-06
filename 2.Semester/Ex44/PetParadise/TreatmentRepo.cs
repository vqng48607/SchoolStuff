using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetParadise
{
    public class TreatmentRepo
    {
        private List<Treatment> treatments = new List<Treatment>();
        string connectionString = "Server = 10.56.8.36; database = DB_2023_88; user id = STUDENT_88; password = OPENDB_88; TrustServerCertificate=true";


        public TreatmentRepo()
        {
            // Load all treatment data from database via SQL statements and populate treatment repository

            // IMPLEMENT THIS!

            GetAll();
           
        }

        public int Add(Treatment treatment)
        {
            // Add new treatment to database and to repository
            // Return the database id of the treatment

            int result = -1;

            // IMPLEMENT THIS!

            return result;
        }
        public List<Treatment> GetAll()
        {
            // Retrieve all treatments from database

            List<Treatment> result = new List<Treatment>();

            // IMPLEMENT THIS!
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TreatId, TreatService, TreatDate, TreatCharge FROM TREATMENT", conn);
                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Treatment treatment = new Treatment
                        {
                            TreatId = int.Parse(dr["TreatId"].ToString()),
                            Service = dr["TreatService"].ToString(),
                            Date = DateTime.Parse(dr["TreatDate"].ToString()),
                            Charge = double.Parse(dr["TreatCharge"].ToString())
                        };
                        result.Add(treatment);
                    }
                }
            }

            return result;
        }
        public Treatment GetById(int id)
        {
            // Get treatment by id from database

            Treatment result = null;

            // IMPLEMENT THIS!
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TreatId, TreatService as Service, TreatDate as Date, TreatCharge as Charge FROM TREATMENT WHERE TreatId =" + id, conn);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result = new Treatment
                        {
                            TreatId = int.Parse(dr["TreatId"].ToString()),
                            Service = dr["Service"].ToString(),
                            Date = DateTime.Parse(dr["Date"].ToString()),
                            Charge = double.Parse(dr["Charge"].ToString())
                        };
                    }
                }
            }
            return result;
        }
        public void Update(Treatment treatment)
        {
            // Update existing treatment on database

            // IMPLEMENT THIS!
        }
        public void Remove(Treatment treatment)
        {
            // Delete existing treatment in database

            // IMPLEMENT THIS!
        }
    }
}
