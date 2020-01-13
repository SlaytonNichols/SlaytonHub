using System.Data;
using Microsoft.Extensions.Configuration;

namespace SlaytonHub.Data
{
    public class Repo : IRepo
    {
        private readonly IDbConnection _dbConnection;

        public Repo(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        
        

    }
}