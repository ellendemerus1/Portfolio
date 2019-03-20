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
    public partial class frmRedigeraRecept : Form
    {
        public int ReceptID { get; set; }
        Recept myReceipe = new Recept();

        public frmRedigeraRecept(int id)
        {
            myReceipe.ReceptID = id;
            InitializeComponent();
            LoadIngredients();
            LoadCategories();
            LoadSelectedRecipeTitle(id);
            LoadSelectedRecipeInstr(id);
        }

        private void LoadIngredients()
        {
            Ingrediens ingrediens = new Ingrediens();
            cbIngrediens.DisplayMember = "IngrediensNamn";
            cbIngrediens.ValueMember = "IngrediensID";
            cbIngrediens.DataSource = ingrediens.GetAllIngredients();
        }

        private void LoadCategories()
        {
            Kategori kategori = new Kategori();
            cbKategoriVal.DisplayMember = "KategoriNamn";
            cbKategoriVal.ValueMember = "KategoriID";
            cbKategoriVal.DataSource = kategori.GetAllCategories();
        }

        private void LoadSelectedRecipeTitle(int id)
        {
            Recept recept = new Recept();
            txtTitle.Text = recept.GetRecipeOpenForEditingTitle(id);
        }

        private void LoadSelectedRecipeInstr(int id) //Denna borde gå att lösa 
        {                                           //tillsammans med ovan metod
            Recept recept = new Recept();
            txtInstructions.Text = recept.GetRecipeOpenForEditingInstr(id);
        }

        private void cmdAdd_Click_1(object sender, EventArgs e)
        {
            Ingrediens ingrediens = new Ingrediens();
            ingrediens.IngrediensID = (int)cbIngrediens.SelectedValue;

            List<string> ingrediensNamn = ingrediens.GetIngredientName();

            lstSelectedIngredients.Items.Add(new ListBoxItem(ingrediensNamn[0].ToString(),
                                                             ingrediens.IngrediensID));

            myReceipe.Ingredienser.Add(ingrediens);
        }

        private void button1_Click(object sender, EventArgs e) //"Uppdatera recept"
        {
            myReceipe.Titel = txtTitle.Text;
            myReceipe.Instruktion = txtInstructions.Text;
            myReceipe.KategoriID = (int)cbKategoriVal.SelectedValue;

            RemoveOldIngredients();

            myReceipe.UpdateRecipe(myReceipe.ReceptID);
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            myReceipe.Titel = txtTitle.Text;
            myReceipe.Instruktion = txtInstructions.Text;
            myReceipe.KategoriID = (int)cbKategoriVal.SelectedValue;

            RemoveOldIngredients();

            myReceipe.UpdateRecipe(myReceipe.ReceptID);

            foreach (Ingrediens i in myReceipe.Ingredienser)
            {
                //skapar upp receptingrediens
                ReceptIngrediens ri = new ReceptIngrediens();
                ri.IngrediensID = i.IngrediensID;
                ri.ReceptID = myReceipe.ReceptID;
                ri.InsertRecipeIngredient();
            }
            MessageBox.Show("Recept uppdaterat!");
        }

        private void RemoveOldIngredients()
        {
            //tar bort de gamla ingredienserna
            ReceptIngrediens ri = new ReceptIngrediens();
            ri.ReceptID = myReceipe.ReceptID;
            ri.DeleteRecipeIngredient();

        }

    }
}
