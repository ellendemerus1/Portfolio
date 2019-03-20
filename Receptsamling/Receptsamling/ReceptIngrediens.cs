using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Receptsamling
{
    public class ReceptIngrediens
    {
        public int ReceptIngrediensID { get; set; }
        public int IngrediensID { get; set; }
        public int ReceptID { get; set; }

        public void InsertRecipeIngredient()
        {
            string sql = "INSERT INTO ReceptIngrediens(IngrediensID,ReceptID) " +
                         " VALUES ('" + this.IngrediensID + "','" + this.ReceptID + "')";

            DbManager dbManager = new DbManager(sql);
            dbManager.ExecuteSQLNoReturn();
        }

        public void DeleteRecipeIngredient()
        {
            string sql = "DELETE FROM ReceptIngrediens " +
                         "WHERE ReceptID = " + this.ReceptID;

            DbManager dbManager = new DbManager(sql);
            dbManager.ExecuteSQLNoReturn();
        }


    }

}
