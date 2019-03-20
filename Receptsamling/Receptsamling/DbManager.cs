using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Receptsamling
{
    // Generell klass som hanterar alla databasanrop

    public class DbManager
    {
        private string ConnectionString { get; set; }
        private SqlConnection conn = null;
        private SqlCommand command = null;
        private string SQL;


        public DbManager(string sql)
        {
            //Enda stället som connectionsträngen sätts. Oftast lagras 
            //den i en config fil och hämtas därifrån 
            ConnectionString = "Data Source=localhost;Initial Catalog=Receptsamling;Integrated Security=SSPI;";

            SQL = sql;
        }

        //Generell metod som hanterar alla typer av select-satser
        //Returnerar en datatable
        public DataTable ExecuteSQL()
        {
            DataTable table = new DataTable();

            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                //Skapa och kör anrop och ta emot i en datatable
                command = new SqlCommand(SQL, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(table);
            }

            return table;
        }

        //Generell metod som hanterar select-satser
        //Returnerar en sträng
        public string ExecuteSQLReturnStringTitle(int id)
        {
            string myString = "";
            
            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                command = new SqlCommand(SQL, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    myString = reader.GetString(0);
                }
            }
            return myString;
        }
    
        //Generell metod som hanterar alla delete, update, insert mot databasen
        public void ExecuteSQLNoReturn()
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                command = new SqlCommand(SQL, conn);
                command.ExecuteNonQuery();
            }
        }
    }
}
