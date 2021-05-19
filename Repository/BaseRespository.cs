using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquiCovidAPI.Repository
{
    public class BaseRespository
    {
        //public string _connectionString = "Server=DANILO\\SQLEXPRESS;Database=AquiCovid;Trusted_Connection=True;";
        public string _connectionString;

        private IConfiguration _configuration;

        public BaseRespository(IConfiguration configuration)
        {
            _configuration = configuration;
            this._connectionString = _configuration.GetConnectionString("AquiCovid");
        }
    }
}
