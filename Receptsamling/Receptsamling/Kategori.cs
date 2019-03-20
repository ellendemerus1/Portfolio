using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Receptsamling
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriNamn { get; set; }

        public List<Kategori> GetAllCategories()
        {
            List<Kategori> kategoriLista = new List<Kategori>();

            DbManager dbManager = new DbManager("SELECT KategoriID, " +
                                                "KategoriNamn FROM Kategori ORDER BY KategoriNamn");

            DataTable table = dbManager.ExecuteSQL();

            foreach (DataRow row in table.Rows)
            {
                Kategori kategori = new Kategori();
                kategori.KategoriID = (int)row.ItemArray[0];
                kategori.KategoriNamn = row.ItemArray[1].ToString();

                kategoriLista.Add(kategori);
            }

            return kategoriLista;
        }
    }
}
