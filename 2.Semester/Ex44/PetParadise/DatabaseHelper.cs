using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetParadise
{
    public class DatabaseHelper
    {
        public static List<string> GetAllPetNamesOwnedByOwner(string firstName, string lastName)
        {
            string connectionString = "Server = 10.56.8.36; database = DB_2023_88; user id = STUDENT_88; password = OPENDB_88; TrustServerCertificate=true";
            List<string> result = new List<string>();

            // IMPLEMENT THIS!
            //  ... using SQL statement on the database
            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();
                var query = $"SELECT Pet.PetName FROM [dbo].[OWNER] inner join [dbo].[PET] on Owner.OwnerId = Pet.OwnerId Where Owner.OwnerFirstName = '{firstName}' and Owner.OwnerLastname = '{lastName}'";
                result = conn.Query<string>(query).ToList();

                //SqlCommand cmd = new SqlCommand("SELECT Pet.PetName FROM [dbo].[OWNER] inner join [dbo].[PET] on Owner.OwnerId = Pet.OwnerId Where Owner.OwnerFirstName =" + firstName + " and Owner.OwnerLastname =" + lastName, conn);
            }

            return result; 
        }
        public static List<Treatment> GetAllTreatmentsPaidByOwner(string firstName, string lastName)
        {
            string connectionString = "Server = 10.56.8.36; database = DB_2023_88; user id = STUDENT_88; password = OPENDB_88; TrustServerCertificate=true";
            List<Treatment> result = new List<Treatment>();

            // IMPLEMENT THIS!
            //  ... using SQL statement on the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = $"SELECT t.* FROM [dbo].[OWNER] inner join [dbo].[PET] on Owner.OwnerId = Pet.OwnerId inner join [dbo].Treatment t ON t.PetId = Pet.PetId Where Owner.OwnerFirstName = '{firstName}' and Owner.OwnerLastname = '{lastName}'";
                result = conn.Query<Treatment>(query).ToList();
                //SqlCommand cmd = new SqlCommand("SELECT Owner.OwnerFirstName, Owner.OwnerLastName, Pet.PetName FROM [dbo].[OWNER] inner join [dbo].[PET] on Owner.OwnerId = Pet.OwnerId Where Owner.OwnerFirstName =" + firstName + " and Owner.OwnerLastname =" + lastName, conn);
            }

            return result;
        }
    }
}
