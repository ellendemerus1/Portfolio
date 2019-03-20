using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receptsamling
{
    public partial class frmReceptVy : Form
    {
        public int ReceptID { get; set; }
        Recept myReceipe = new Recept();

        public frmReceptVy(int id)
        {
            myReceipe.ReceptID = id;
            InitializeComponent();
            LoadSelectedRecipe(id);
            LoadRecipeIngredients(id);
        }

        private void LoadSelectedRecipe(int id)
        {
            Recept recept = new Recept();
            DataTable table = new DataTable();
            table = recept.GetSelectedRecipe(id);

            lstSelectedRecipeTitle.DisplayMember = "Titel";
            lstSelectedRecipeTitle.ValueMember = "ReceptID";
            lstKategoriNamn.DisplayMember = "KategoriNamn";
            lstSelectedRecipeInstr.DisplayMember = "Instruktion";

            lstSelectedRecipeInstr.DataSource = table;
            lstSelectedRecipeTitle.DataSource = table;
            lstKategoriNamn.DataSource = table;
        }

        private void LoadRecipeIngredients(int id)
        {
            Ingrediens ingrediens = new Ingrediens();

            lstSelectedRecipeIngredienser.DisplayMember = "IngrediensNamn";
            lstSelectedRecipeIngredienser.ValueMember = "IngrediensID";
            lstSelectedRecipeIngredienser.DataSource = ingrediens.GetIngredients(myReceipe.ReceptID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)lstSelectedRecipeTitle.SelectedValue;

            frmRedigeraRecept receptRedigering = new frmRedigeraRecept(id);
            receptRedigering.Show();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            myReceipe.DeleteRecipeIngredient(myReceipe.ReceptID);
            myReceipe.DeleteRecipe(myReceipe.ReceptID);
            MessageBox.Show("Receptet borttaget!");
        }
    }
}
