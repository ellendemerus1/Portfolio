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
    public partial class frmStart : Form
    {
        Recept myRecipe = new Recept();

        public frmStart()
        {
            InitializeComponent();
            Receptsamling minReceptSamling = new Receptsamling();
            LoadRecipes();
            LoadCategories();
        }

        private void LoadRecipes()
        {
            Recept recept = new Recept();
            lstRecept.DisplayMember = "Titel";
            lstRecept.ValueMember = "ReceptID";
            lstRecept.DataSource = recept.GetAllRecipes();
        }

        private void LoadCategories()
        {
            Kategori kategori = new Kategori();
            cbKategorier.DisplayMember = "KategoriNamn";
            cbKategorier.ValueMember = "KategoriID";
            cbKategorier.DataSource = kategori.GetAllCategories();
        }

        private void cmdCreateNewRecipe_Click(object sender, EventArgs e)
        {
            frmSkapaRecept skapaRecept = new frmSkapaRecept();
            skapaRecept.Show();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            string input = txtSearchTitle.Text;
            int inputCategory = (int)cbKategorier.SelectedValue;
            Recept recept = new Recept();
            lstRecept.DisplayMember = "Titel";
            lstRecept.ValueMember = "ReceptID";

            if (inputCategory == 10)
            {
                lstRecept.DataSource = recept.SearchRecipes(input);
            }
            else
            {
                lstRecept.DataSource = recept.SearchRecipes(input, inputCategory);
            }
        }

        private void cmdShowRecipe_Click(object sender, EventArgs e)
        {
            int id = (int)lstRecept.SelectedValue;
            frmReceptVy receptVy = new frmReceptVy(id);
            receptVy.Show();
        }
    }
}