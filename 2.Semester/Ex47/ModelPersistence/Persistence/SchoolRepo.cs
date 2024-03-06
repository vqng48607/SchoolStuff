using Microsoft.Data.SqlClient;
using ModelPersistence.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ModelPersistence.Persistence
{
    public class SchoolRepo
    {
        private List<School> schools = new List<School>();
        string connectionString = "Server=10.56.8.36; database=P2_DB_2023_01; user id=P2_PROJECT_USER_01; password=OPENDB_01; TrustServerCertificate=true;";

        public List<School> Add(string SchoolName, string ContactPerson, long PhoneNumber, string Address, string Email, bool Active)
        {
            List<School> result = new List<School>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into School(SchoolName, ContactPerson, PhoneNumber, Address, Email, Active) Values(@SchoolName, @ContactPerson, @PhoneNumber, @Address, @Email, @Active)" ,conn);
                cmd.Parameters.Add("@SchoolName", SqlDbType.NVarChar).Value = SchoolName;
                cmd.Parameters.Add("@ContactPerson", SqlDbType.NVarChar).Value = ContactPerson;
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.BigInt).Value = PhoneNumber;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
                cmd.Parameters.Add("@Active", SqlDbType.Bit).Value = Active;
                cmd.ExecuteNonQuery();
                GetAll();
            }
            

            return result;
        }

        public List<School> GetAll()
        {
            List<School> result = new List<School>();

            using(SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM School", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        School school = new School
                        {
                            SchoolName = reader["SchoolName"].ToString(),
                            ContactPerson = reader["ContactPerson"].ToString(),
                            PhoneNumber = long.Parse(reader["PhoneNumber"].ToString()),
                            Address = reader["address"].ToString(),
                            Email = reader["email"].ToString(),
                            Active = bool.Parse(reader["active"].ToString()),
                        };
                        result.Add(school);
                    }   
                }
            }

            return result;
        }

        public School GetById(string SchoolName, string Address)
        {
            School result = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM School WHERE SchoolName = @SchoolName AND Address = @Address", conn);
                cmd.Parameters.Add("@SchoolName", SqlDbType.NVarChar).Value = SchoolName;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = new School
                        {
                            SchoolName = reader["SchoolName"].ToString(),
                            ContactPerson = reader["ContactPerson"].ToString(),
                            PhoneNumber = long.Parse(reader["PhoneNumber"].ToString()),
                            Address = reader["address"].ToString(),
                            Email = reader["email"].ToString(),
                            Active = bool.Parse(reader["active"].ToString()),
                        };
                       
                    }
                }
            }

            return result;
        }

        public List<School> Update(string SchoolName, string Address, long PhoneNumber)
        {
            List<School> result = new List<School>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE School SET PhoneNumber = @PhoneNumber WHERE SchoolName = @SchoolName and Address = @Address", conn);
                cmd.Parameters.Add("@SchoolName", SqlDbType.NVarChar).Value = SchoolName;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.BigInt).Value = PhoneNumber;

                cmd.ExecuteNonQuery();
                GetAll();
            }

            return result;
        }

        public List<School> Delete(string SchoolName, string Address)
        {
            List<School> result = new List<School>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE From School WHERE SchoolName = @SchoolName and Address = @Address", conn);
                cmd.Parameters.Add("@SchoolName", SqlDbType.NVarChar).Value = SchoolName;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
                
                cmd.ExecuteNonQuery();
                GetAll();
            }

            return result;
        }


    }
}
