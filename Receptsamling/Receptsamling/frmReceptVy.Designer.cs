namespace Receptsamling
{
    partial class frmReceptVy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstSelectedRecipeInstr = new System.Windows.Forms.ListBox();
            this.lstSelectedRecipeTitle = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSelectedRecipeIngredienser = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lstKategoriNamn = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSelectedRecipeInstr
            // 
            this.lstSelectedRecipeInstr.FormattingEnabled = true;
            this.lstSelectedRecipeInstr.ItemHeight = 20;
            this.lstSelectedRecipeInstr.Location = new System.Drawing.Point(55, 394);
            this.lstSelectedRecipeInstr.Name = "lstSelectedRecipeInstr";
            this.lstSelectedRecipeInstr.Size = new System.Drawing.Size(660, 124);
            this.lstSelectedRecipeInstr.TabIndex = 1;
            // 
            // lstSelectedRecipeTitle
            // 
            this.lstSelectedRecipeTitle.FormattingEnabled = true;
            this.lstSelectedRecipeTitle.ItemHeight = 20;
            this.lstSelectedRecipeTitle.Location = new System.Drawing.Point(55, 46);
            this.lstSelectedRecipeTitle.Name = "lstSelectedRecipeTitle";
            this.lstSelectedRecipeTitle.Size = new System.Drawing.Size(451, 44);
            this.lstSelectedRecipeTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Instruktion:";
            // 
            // lstSelectedRecipeIngredienser
            // 
            this.lstSelectedRecipeIngredienser.FormattingEnabled = true;
            this.lstSelectedRecipeIngredienser.ItemHeight = 20;
            this.lstSelectedRecipeIngredienser.Location = new System.Drawing.Point(55, 129);
            this.lstSelectedRecipeIngredienser.Name = "lstSelectedRecipeIngredienser";
            this.lstSelectedRecipeIngredienser.Size = new System.Drawing.Size(205, 204);
            this.lstSelectedRecipeIngredienser.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingredienser:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Redigera recept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(788, 462);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(145, 56);
            this.cmdDelete.TabIndex = 7;
            this.cmdDelete.Text = "Ta bort recept";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(647, 13);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(68, 20);
            this.lblKategori.TabIndex = 9;
            this.lblKategori.Text = "Kategori";
            // 
            // lstKategoriNamn
            // 
            this.lstKategoriNamn.FormattingEnabled = true;
            this.lstKategoriNamn.ItemHeight = 20;
            this.lstKategoriNamn.Location = new System.Drawing.Point(651, 45);
            this.lstKategoriNamn.Name = "lstKategoriNamn";
            this.lstKategoriNamn.Size = new System.Drawing.Size(234, 44);
            this.lstKategoriNamn.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Titel";
            // 
            // frmReceptVy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 581);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstKategoriNamn);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSelectedRecipeIngredienser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSelectedRecipeTitle);
            this.Controls.Add(this.lstSelectedRecipeInstr);
            this.Name = "frmReceptVy";
            this.Text = "ReceptVy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSelectedRecipeInstr;
        private System.Windows.Forms.ListBox lstSelectedRecipeTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSelectedRecipeIngredienser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ListBox lstKategoriNamn;
        private System.Windows.Forms.Label label3;
    }
}