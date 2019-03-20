namespace Receptsamling
{
    partial class frmRedigeraRecept
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
            this.cmdSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lstSelectedIngredients = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIngrediens = new System.Windows.Forms.ComboBox();
            this.cbKategoriVal = new System.Windows.Forms.ComboBox();
            this.txtInstructions = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(865, 502);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(134, 42);
            this.cmdSave.TabIndex = 28;
            this.cmdSave.Text = "Spara";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Valda ingredienser";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(873, 58);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(96, 35);
            this.cmdAdd.TabIndex = 26;
            this.cmdAdd.Text = "Lägg till";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click_1);
            // 
            // lstSelectedIngredients
            // 
            this.lstSelectedIngredients.FormattingEnabled = true;
            this.lstSelectedIngredients.ItemHeight = 20;
            this.lstSelectedIngredients.Location = new System.Drawing.Point(696, 130);
            this.lstSelectedIngredients.Name = "lstSelectedIngredients";
            this.lstSelectedIngredients.Size = new System.Drawing.Size(277, 284);
            this.lstSelectedIngredients.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ingredienser";
            // 
            // cbIngrediens
            // 
            this.cbIngrediens.AllowDrop = true;
            this.cbIngrediens.DisplayMember = "Namn";
            this.cbIngrediens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIngrediens.FormattingEnabled = true;
            this.cbIngrediens.Location = new System.Drawing.Point(693, 19);
            this.cbIngrediens.Name = "cbIngrediens";
            this.cbIngrediens.Size = new System.Drawing.Size(277, 28);
            this.cbIngrediens.TabIndex = 23;
            this.cbIngrediens.ValueMember = "ID";
            // 
            // cbKategoriVal
            // 
            this.cbKategoriVal.AllowDrop = true;
            this.cbKategoriVal.DisplayMember = "Namn";
            this.cbKategoriVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriVal.FormattingEnabled = true;
            this.cbKategoriVal.Location = new System.Drawing.Point(144, 65);
            this.cbKategoriVal.Name = "cbKategoriVal";
            this.cbKategoriVal.Size = new System.Drawing.Size(388, 28);
            this.cbKategoriVal.TabIndex = 22;
            this.cbKategoriVal.ValueMember = "ID";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(144, 123);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(388, 301);
            this.txtInstructions.TabIndex = 20;
            this.txtInstructions.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Instruktion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kategorinamn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Titel";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(144, 19);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(388, 26);
            this.txtTitle.TabIndex = 16;
            // 
            // frmRedigeraRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 562);
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
            this.Name = "frmRedigeraRecept";
            this.Text = "frmRedigeraRecept";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ListBox lstSelectedIngredients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIngrediens;
        private System.Windows.Forms.ComboBox cbKategoriVal;
        private System.Windows.Forms.RichTextBox txtInstructions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
    }
}