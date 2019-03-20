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
    public partial class frmSkapaRecept : Form
    {
        Recept myReceipe = new Recept();


        public frmSkapaRecept()
        {
            InitializeComponent();
            LoadIngredients();
            LoadCategories();
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

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Ingrediens ingrediens = new Ingrediens();
            ingrediens.IngrediensID = (int)cbIngrediens.SelectedValue;

            List<string> ingrediensNamn = ingrediens.GetIngredientName();

            lstSelectedIngredients.Items.Add(new ListBoxItem(ingrediensNamn[0].ToString(),
                                                             ingrediens.IngrediensID));

            myReceipe.Ingredienser.Add(ingrediens);  //lägger till i ingredienslistan
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            myReceipe.Titel = txtTitle.Text;
            myReceipe.Instruktion = txtInstructions.Text;
            myReceipe.KategoriID = (int)cbKategoriVal.SelectedValue;

            myReceipe.InsertRecipe();

            Recept recept = new Recept();
            List<int> mittNyaRecept = recept.GetLatestCreatedReceipe();
            int newestReceipeID = mittNyaRecept[0];
            foreach (Ingrediens i in myReceipe.Ingredienser)
            {
                //skapar upp receptingrediens
                ReceptIngrediens ri = new ReceptIngrediens();
                ri.IngrediensID = i.IngrediensID;
                ri.ReceptID = newestReceipeID;
                ri.InsertRecipeIngredient();
            }
            MessageBox.Show("Nytt recept sparat!");
        }
    }
}
