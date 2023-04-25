using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Ctepl.Anand.DTO;

namespace Ctepl.Anand
{
    public class ReopenLitigationClaimRepository
    {
        //Connection String
        private readonly string _connectionString;

        //Constructor
        public ReopenLitigationClaimRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        //Create
        public void Create(ReopenLitigationClaim reopenLitigationClaim)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO ReopenLitigationClaim (Id)
                                            VALUES (@Id)";

                    command.Parameters.AddWithValue("@Id", reopenLitigationClaim.Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        //Read
        public ReopenLitigationClaim Read(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT * 
                                            FROM ReopenLitigationClaim 
                                            WHERE Id = @Id";

                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    var reader = command.ExecuteReader();

                    if (!reader.Read())
                        return null;

                    return new ReopenLitigationClaim
                    {
                        Id = (int)reader["Id"],
                    };
                }
            }
        }

        //Update
        public void Update(ReopenLitigationClaim reopenLitigationClaim)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE ReopenLitigationClaim 
                                            SET 
                                                Id = @Id
                                            WHERE Id = @Id";

                    command.Parameters.AddWithValue("@Id", reopenLitigationClaim.Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        //Delete
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"DELETE FROM ReopenLitigationClaim 
                                            WHERE Id = @Id";

                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}