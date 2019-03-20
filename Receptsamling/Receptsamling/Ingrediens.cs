using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Receptsamling
{
    public class Ingrediens
    {
        public int IngrediensID { get; set; }
        public string IngrediensNamn { get; set; }


        public List<Ingrediens> GetAllIngredients()
        {
            List<Ingrediens> allaIngredienser = new List<Ingrediens>();

            DbManager dbManager = new DbManager("SELECT IngrediensID, IngrediensNamn FROM Ingrediens");

            DataTable table = dbManager.ExecuteSQL();

            foreach (DataRow row in table.Rows)
            {
                Ingrediens ingrediens = new Ingrediens();
                ingrediens.IngrediensID = (int)row.ItemArray[0];
                ingrediens.IngrediensNamn = row.ItemArray[1].ToString();


                allaIngredienser.Add(ingrediens);
            }

            return allaIngredienser;
        }

        public List<string> GetIngredientName()
        {
            List<string> ingrediensNamn = new List<string>();

            DbManager dbManager = new DbManager("SELECT DISTINCT IngrediensNamn FROM Ingrediens WHERE "+ this.IngrediensID +" = IngrediensID");

            DataTable table = dbManager.ExecuteSQL();

            foreach (DataRow row in table.Rows)
            {
                string ingrediensName = row.ItemArray[0].ToString();

                ingrediensNamn.Add(ingrediensName);
            }

            return ingrediensNamn;
        }


        public List<Ingrediens> GetIngredients(int id)
        {
            List<Ingrediens> ingrediensLista = new List<Ingrediens>();

            DbManager dbManager = new DbManager("SELECT i.IngrediensNamn " +
                "FROM ReceptIngrediens ri " +
                "Inner join Ingrediens i ON i.IngrediensID = ri.IngrediensID " +
                                                "WHERE ri.ReceptID = '" + id + "'");

            DataTable table = dbManager.ExecuteSQL();

            foreach (DataRow row in table.Rows)
            {
                Ingrediens ingrediens = new Ingrediens();
                ingrediens.IngrediensNamn = row.ItemArray[0].ToString();

                ingrediensLista.Add(ingrediens);
            }

            return ingrediensLista;
        }

    }

}
