using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Text;

namespace PetParadise
{
    public class OwnerRepo
    {
        private List<Owner> owners = new List<Owner>();
        string connectionString = "Server = 10.56.8.36; database = DB_2023_88; user id = STUDENT_88; password = OPENDB_88; TrustServerCertificate=true";

        public OwnerRepo()
        {
            // Load all owner data from database via SQL statements and populate owner repository

            // IMPLEMENT THIS!
            GetAll();
         
        }

        public int Add(Owner owner)
        {
            // Add new owner to database and to repository
            // Return the database id of the owner

            int result = -1;

            // IMPLEMENT THIS!

            return result;
        }
        public List<Owner> GetAll()
        {
            // Retrieve all owners from database

            List<Owner> result = new List<Owner>();

            // IMPLEMENT THIS!
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT OwnerId, OwnerFirstName, OwnerLastName, OwnerPhone, OwnerEmail FROM Owner", conn);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Owner owner = new Owner
                        {
                            OwnerId = int.Parse(dr["OwnerId"].ToString()),
                            FirstName = dr["OwnerFirstName"].ToString(),
                            LastName = dr["OwnerLastName"].ToString(),
                            Phone = dr["OwnerPhone"].ToString(),
                            Email = dr["OwnerEmail"].ToString()
                        };
                        result.Add(owner);

                    }
                }
            }
            return result;
        }
        public Owner GetById(int id)
        {
            // Get owner by id from database

            Owner result = null;

            // IMPLEMENT THIS!
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT OwnerId, OwnerFirstName, OwnerLastName, OwnerPhone, OwnerEmail FROM Owner WHERE OwnerId =" + id, conn);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result = new Owner
                        {
                            OwnerId = int.Parse(dr["OwnerId"].ToString()),
                            FirstName = dr["OwnerFirstName"].ToString(),
                            LastName = dr["OwnerLastName"].ToString(),
                            Phone = dr["OwnerPhone"].ToString(),
                            Email = dr["OwnerEmail"].ToString()
                        };
                    }
                }
            }
            return result;
        }
        public void Update(Owner owner)
        {
            // Update existing owner on database

            // IMPLEMENT THIS!
        }
        public void Remove(Owner owner)
        {
            // Delete existing owner in database

            // IMPLEMENT THIS!
        }


    }
}

