using AquiCovidAPI.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using AquiCovidAPI.Interface;

namespace AquiCovidAPI.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        public string _connectionString = "Server=DANILO\\SQLEXPRESS;Database=AquiCovid;Trusted_Connection=True;";

        public List<Pessoa> Listar()
        {
            string query = @"SELECT [Id]
                                  ,[Nome]
                                  ,[CPF]
                              FROM [dbo].[Pessoa]";

            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn.Query<Pessoa>(query).ToList();          
        }

        public Pessoa Obter(int Id)
        {
            string query = @"SELECT [Id]
                                  ,[Nome]
                                  ,[CPF]
                              FROM [dbo].[Pessoa]
                              WHERE [Id] = @Id";

            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn.QueryFirstOrDefault<Pessoa>(query, new { Id });
        }
    }
}
