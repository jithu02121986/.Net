
using Microsoft.Data.SqlClient;


namespace ProductDataBaseConnectionAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
             caseStudy_1();

            //caseStudy_2();

            caseStudy_3();
            caseStudy_2();

            // var connection_1 = new DB_Connection();
            // connection_1.CreateDBConnection();


        }

        public static void caseStudy_3()
        {
        

            var connection_1 = new DB_Connection();
            var con_string = connection_1.CreateDBConnection();
           // var connectionString = "server = .\\SQLEXPRESS;database = RRD_db1;Integrated Security=True;Trust Server Certificate=True";
            var con = new SqlConnection(con_string);


            string query = "INSERT INTO product (name, quantity, price) VALUES ('Keyboard', 15, 1300)";
            var cmd = new SqlCommand(query, con);
            con.Open();
           var rows_Insert = cmd.ExecuteNonQuery();
            Console.WriteLine("no.of rows inserted : "+ rows_Insert);
            con.Close();

        }
        

        private static void caseStudy_2()
        {
            //connection parameter  details = Data Source=CHLAPDTHOTAJI\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

            var connectionString = "server = .\\SQLEXPRESS;database = RRD_db1;Integrated Security=True;Trust Server Certificate=True";
            var con = new SqlConnection(connectionString);
            con.Open();
            var cmd = new SqlCommand("select * from product",con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine(reader.GetString(0));
                Console.WriteLine(reader["name"]+"\n");
                //Console.WriteLine("\n");
                Console.WriteLine(reader["quantity"]+ "\n");
             //   Console.WriteLine("\n");
                Console.WriteLine(reader["price"]+ "\n");
              //  Console.WriteLine("\n");
            }
            con.Close();
                   
        }

        private static void caseStudy_1()
        {
            var connectionString = "server = .\\SQLEXPRESS;database = RRD_db1;Integrated Security=True;Trust Server Certificate=True";
            var con = new SqlConnection(connectionString);
            con.Open();
            Console.WriteLine("Connection Opened :"+con.DataSource);
            con.Close(); ;
            Console.WriteLine("connection State is "+con.State);
        }

    }
}
