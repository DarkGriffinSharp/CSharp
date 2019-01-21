using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQLConnections
{
    class Program
    {
        // Bağlantı konumunu almak için Server Explorer'dan bağlantı oluşturma gerekli.
        static string path = @"Data Source=302--12;Initial Catalog=demoDB;Persist Security Info=True;User ID=sa;Password=1234";

        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(path);
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("Bağlantı başarılı");
                }
                else
                {
                    Console.WriteLine("Bağlantı başarısız.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            Console.ReadKey();
        }
    }
}
