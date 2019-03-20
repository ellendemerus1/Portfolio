using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Receptsamling
{
    public class Recept
    {
        public int ReceptID { get; set; }
        public string Titel { get; set; }
        public int KategoriID { get; set; }
        public string Instruktion { get; set; }

        public List<Ingrediens> Ingredienser = new List<Ingrediens>();


        public List<Recept> GetAllRecipes()
        {
            List<Recept> receptlista = new List<Recept>();

            DbManager dbManager = new DbManager("SELECT Titel, ReceptID FROM Recept");

            DataTable table = dbManager.ExecuteSQL();

            //Loopar igenom alla rader i svaret
            foreach (DataRow row in table.Rows)
            {
                Recept recept = new Recept();
                recept.Titel = row.ItemArray[0].ToString();
                recept.ReceptID = (int)row.ItemArray[1];

                receptlista.Add(recept);
            }

            return receptlista;
        }

        public DataTable GetSelectedRecipe(int id)
        {
            DbManager dbManager = new DbManager("SELECT Titel, ReceptID, " +
                                                "KategoriNamn, Instruktion FROM Recept r " +
                                                "INNER JOIN Kategori k ON k.KategoriID = r.KategoriID " +
                                                "WHERE ReceptID = '" + id + "'");
            
            DataTable table = dbManager.ExecuteSQL();

            return table;
        }

        public string GetRecipeOpenForEditingTitle(int id)
        {
            List<string> receptInnehåll = new List<string>();
            string title = "";

            DbManager dbManager = new DbManager("SELECT Titel " +
                                                "FROM Recept " +
                                                "WHERE ReceptID = '" + id + "'");

            title = dbManager.ExecuteSQLReturnStringTitle(id);

            return title;
        }

        public string GetRecipeOpenForEditingInstr(int id)
        {
            List<string> receptInnehåll = new List<string>();
            string title = "";

            DbManager dbManager = new DbManager("SELECT Instruktion " +
                                                "FROM Recept " +
                                                "WHERE ReceptID = '" + id + "'");

            title = dbManager.ExecuteSQLReturnStringTitle(id);

            return title;
        }

        public List<Recept> SearchRecipes(string input, int inputCategory)
        {
            List<Recept> receptlista = new List<Recept>();

            DbManager dbManager = new DbManager("select Titel, ReceptID FROM Recept "+
             "WHERE Titel LIKE '%" + input + "%' AND KategoriID = '" + inputCategory + "'");

            DataTable table = dbManager.ExecuteSQL();

            //Loopar igenom alla rader i svaret
            foreach (DataRow row in table.Rows)
            {
                Recept recept = new Recept();
                recept.Titel = row.ItemArray[0].ToString();
                recept.ReceptID = (int)row.ItemArray[1];

                receptlista.Add(recept);
            }

            return receptlista;
        }

        public List<Recept> SearchRecipes(string input)
        {
            List<Recept> receptlista = new List<Recept>();

            DbManager dbManager = new DbManager("select Titel, ReceptID FROM Recept " +
             "WHERE Titel LIKE '%" + input + "%'");

            DataTable table = dbManager.ExecuteSQL();

            //Loopar igenom alla rader i svaret
            foreach (DataRow row in table.Rows)
            {
                Recept recept = new Recept();
                recept.Titel = row.ItemArray[0].ToString();
                recept.ReceptID = (int)row.ItemArray[1];

                receptlista.Add(recept);
            }

            return receptlista;
        }

        public void InsertRecipe()
        {
            string sql = "INSERT INTO Recept(Titel,KategoriID,Instruktion) " +
                         " VALUES ('" + this.Titel + "','" + this.KategoriID + 
                         "','" + this.Instruktion + "')";

            DbManager dbManager = new DbManager(sql);
            dbManager.ExecuteSQLNoReturn();
        }

        public void UpdateRecipe(int id)
        {
            string sql = "UPDATE Recept SET Titel = '" + this.Titel + "', " +
                "Instruktion = '" + this.Instruktion + "', " +
                "KategoriID = '" + this.KategoriID + "'" +
                " where ReceptID = " + id;

            DbManager dbManager = new DbManager(sql);
            dbManager.ExecuteSQLNoReturn();
        }

        public List<int> GetLatestCreatedReceipe()
        {
            List<int> receptlista = new List<int>();

            DbManager dbManager = new DbManager("SELECT TOP 1 ReceptID FROM Recept " +
                                                "ORDER BY ReceptID desc");

            DataTable table = dbManager.ExecuteSQL();

            //Loopar igenom alla rader i svaret
            foreach (DataRow row in table.Rows)
            {
                Recept recept = new Recept();

                recept.ReceptID = (int)row.ItemArray[0];

                receptlista.Add(recept.ReceptID);
            }

            return receptlista;
        }

        public void DeleteRecipe(int id)
        {
            string sql = "DELETE FROM Recept WHERE ReceptID = " + id;

            DbManager dbManager = new DbManager(sql);
            dbManager.ExecuteSQLNoReturn();
        }

        public void DeleteRecipeIngredient(int id)
        {
            string sql = "DELETE FROM ReceptIngrediens WHERE ReceptID = " + id;

            DbManager dbManager = new DbManager(sql);
            dbManager.ExecuteSQLNoReturn();
        }
    }
}
