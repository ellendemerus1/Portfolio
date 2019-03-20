namespace Receptsamling
{
    partial class frmSkapaRecept
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.RichTextBox();
            this.cbKategoriVal = new System.Windows.Forms.ComboBox();
            this.cbIngrediens = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSelectedIngredients = new System.Windows.Forms.ListBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(144, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(388, 26);
            this.txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategorinamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Instruktion";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(144, 131);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(388, 301);
            this.txtInstructions.TabIndex = 7;
            this.txtInstructions.Text = "";
            // 
            // cbKategoriVal
            // 
            this.cbKategoriVal.AllowDrop = true;
            this.cbKategoriVal.DisplayMember = "Namn";
            this.cbKategoriVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriVal.FormattingEnabled = true;
            this.cbKategoriVal.Location = new System.Drawing.Point(144, 73);
            this.cbKategoriVal.Name = "cbKategoriVal";
            this.cbKategoriVal.Size = new System.Drawing.Size(388, 28);
            this.cbKategoriVal.TabIndex = 9;
            this.cbKategoriVal.ValueMember = "ID";
            // 
            // cbIngrediens
            // 
            this.cbIngrediens.AllowDrop = true;
            this.cbIngrediens.DisplayMember = "Namn";
            this.cbIngrediens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIngrediens.FormattingEnabled = true;
            this.cbIngrediens.Location = new System.Drawing.Point(693, 27);
            this.cbIngrediens.Name = "cbIngrediens";
            this.cbIngrediens.Size = new System.Drawing.Size(277, 28);
            this.cbIngrediens.TabIndex = 10;
            this.cbIngrediens.ValueMember = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ingredienser";
            // 
            // lstSelectedIngredients
            // 
            this.lstSelectedIngredients.FormattingEnabled = true;
            this.lstSelectedIngredients.ItemHeight = 20;
            this.lstSelectedIngredients.Location = new System.Drawing.Point(696, 138);
            this.lstSelectedIngredients.Name = "lstSelectedIngredients";
            this.lstSelectedIngredients.Size = new System.Drawing.Size(277, 304);
            this.lstSelectedIngredients.TabIndex = 12;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(873, 66);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(96, 35);
            this.cmdAdd.TabIndex = 13;
            this.cmdAdd.Text = "Lägg till";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Valda ingredienser";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(839, 475);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(134, 42);
            this.cmdSave.TabIndex = 15;
            this.cmdSave.Text = "Spara";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // frmSkapaRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 574);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.lstSelectedIngredients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbIngrediens);
            this.Controls.Add(this.cbKategoriVal);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmSkapaRecept";
            this.Text = "Skapa recept";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtInstructions;
        private System.Windows.Forms.ComboBox cbKategoriVal;
        private System.Windows.Forms.ComboBox cbIngrediens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSelectedIngredients;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdSave;
    }
}