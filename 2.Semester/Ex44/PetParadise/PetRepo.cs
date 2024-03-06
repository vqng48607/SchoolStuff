using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetParadise
{
    public class PetRepo
    {
        private List<Pet> pets = new List<Pet>();
        string connectionString = "Server = 10.56.8.36; database = DB_2023_88; user id = STUDENT_88; password = OPENDB_88; TrustServerCertificate=true";

        public PetRepo()
        {
            // Load all pet data from database via SQL statements and populate pet repository

            // IMPLEMENT THIS!
        }

        public int Add(Pet pet)
        {
            // Add new pet to database and to repository
            // Return the database id of the pet

            int result = -1;

            // IMPLEMENT THIS!

            return result;
        }
        public List<Pet> GetAll()
        {
            // Retrieve all pets from database

            List<Pet> result = new List<Pet>();

            // IMPLEMENT THIS!
            using(SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT PetId, PetName, PetType, PetBreed, PetDOB, PetWeight FROM Pet", conn);
                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Pet pet;
                        if (dr["PetDOB"] == DBNull.Value)
                        {
                            pet = new Pet
                            {
                                PetId = int.Parse(dr["PetId"].ToString()),
                                Name = dr["PetName"].ToString(),
                                PetType = (PetTypes)Enum.Parse(typeof(PetTypes), dr["PetType"].ToString()),
                                Breed = dr["PetBreed"].ToString(),
                                DOB = DateTime.MinValue,
                                Weight = double.Parse(dr["PetWeight"].ToString())
                            };
                        }
                        else
                        {
                            pet = new Pet
                            {
                                PetId = int.Parse(dr["PetId"].ToString()),
                                Name = dr["PetName"].ToString(),
                                PetType = (PetTypes)Enum.Parse(typeof(PetTypes), dr["PetType"].ToString()),
                                Breed = dr["PetBreed"].ToString(),
                                DOB = DateTime.Parse(dr["PetDOB"].ToString()),
                                Weight = double.Parse(dr["PetWeight"].ToString())
                            };
                        }
                        result.Add(pet);

                    }
                }
            }

            return result;
        }
        public Pet GetById(int id)
        {
            // Get pet by id from database

            Pet result = null;

            // IMPLEMENT THIS!
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = $"SELECT PetId, PetName as name, PetType, PetBreed as breed, PetDOB as dob, PetWeight as weight FROM Pet WHERE PetId = {id}";
                result = conn.QuerySingle<Pet>(query);

                //SqlCommand cmd = new SqlCommand("SELECT PetId, PetName, PetType, PetBreed, PetDOB, PetWeight FROM Pet WHERE PetId =" + id, conn);
                //using (SqlDataReader dr = cmd.ExecuteReader())
                //{
                //    while (dr.Read())
                //    {

                //        Pet pet;
                //        if (dr["PetDOB"] == DBNull.Value)
                //        {
                //            result = new Pet
                //            {
                //                PetId = int.Parse(dr["PetId"].ToString()),
                //                Name = dr["PetName"].ToString(),
                //                PetType = (PetTypes)Enum.Parse(typeof(PetTypes), dr["PetType"].ToString()),
                //                Breed = dr["PetBreed"].ToString(),
                //                DOB = DateTime.MinValue,
                //                Weight = double.Parse(dr["PetWeight"].ToString())
                //            };
                //        }
                //        else
                //        {
                //            result = new Pet
                //            {
                //                PetId = int.Parse(dr["PetId"].ToString()),
                //                Name = dr["PetName"].ToString(),
                //                PetType = (PetTypes)Enum.Parse(typeof(PetTypes), dr["PetType"].ToString()),
                //                Breed = dr["PetBreed"].ToString(),
                //                DOB = DateTime.Parse(dr["PetDOB"].ToString()),
                //                Weight = double.Parse(dr["PetWeight"].ToString())
                //            };
                //        }
                //    }
                //}
            }

            return result;
        }
        public void Update(Pet pet)
        {
            // Update existing pet on database

            // IMPLEMENT THIS!
        }
        public void Remove(Pet pet)
        {
            // Delete existing pet in database

            // IMPLEMENT THIS!
        }
    }
}
