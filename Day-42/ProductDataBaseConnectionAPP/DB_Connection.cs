using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDataBaseConnectionAPP
{
    public  class DB_Connection
    {
       public string CreateDBConnection()

        {
            var connectionString = "";
            try
            {

                 connectionString = ConfigurationManager.ConnectionStrings["SqlserverConnection_1"].ConnectionString;
                Console.WriteLine($"Connection String: {connectionString}");
               

            }
            catch( Exception ex ) 
            {
                Console.WriteLine("Exception Details :"+ex.Message);
            }
            return connectionString;

        }
        
    }
}
