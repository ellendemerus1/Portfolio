namespace Receptsamling
{
    partial class frmStart
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
            this.lstRecept = new System.Windows.Forms.ListBox();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdCreateNewRecipe = new System.Windows.Forms.Button();
            this.cmdShowRecipe = new System.Windows.Forms.Button();
            this.cbKategorier = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstRecept
            // 
            this.lstRecept.FormattingEnabled = true;
            this.lstRecept.ItemHeight = 20;
            this.lstRecept.Location = new System.Drawing.Point(37, 47);
            this.lstRecept.Name = "lstRecept";
            this.lstRecept.Size = new System.Drawing.Size(394, 324);
            this.lstRecept.TabIndex = 0;
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(460, 116);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(224, 26);
            this.txtSearchTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(456, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Titel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sök recept på:";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(718, 149);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(145, 52);
            this.cmdSearch.TabIndex = 6;
            this.cmdSearch.Text = "Sök";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cmdCreateNewRecipe
            // 
            this.cmdCreateNewRecipe.Location = new System.Drawing.Point(718, 430);
            this.cmdCreateNewRecipe.Name = "cmdCreateNewRecipe";
            this.cmdCreateNewRecipe.Size = new System.Drawing.Size(145, 52);
            this.cmdCreateNewRecipe.TabIndex = 7;
            this.cmdCreateNewRecipe.Text = "Skapa nytt recept";
            this.cmdCreateNewRecipe.UseVisualStyleBackColor = true;
            this.cmdCreateNewRecipe.Click += new System.EventHandler(this.cmdCreateNewRecipe_Click);
            // 
            // cmdShowRecipe
            // 
            this.cmdShowRecipe.Location = new System.Drawing.Point(460, 317);
            this.cmdShowRecipe.Name = "cmdShowRecipe";
            this.cmdShowRecipe.Size = new System.Drawing.Size(147, 54);
            this.cmdShowRecipe.TabIndex = 8;
            this.cmdShowRecipe.Text = "Visa valt recept";
            this.cmdShowRecipe.UseVisualStyleBackColor = true;
            this.cmdShowRecipe.Click += new System.EventHandler(this.cmdShowRecipe_Click);
            // 
            // cbKategorier
            // 
            this.cbKategorier.AllowDrop = true;
            this.cbKategorier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorier.FormattingEnabled = true;
            this.cbKategorier.Location = new System.Drawing.Point(460, 173);
            this.cbKategorier.Name = "cbKategorier";
            this.cbKategorier.Size = new System.Drawing.Size(224, 28);
            this.cbKategorier.TabIndex = 9;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 521);
            this.Controls.Add(this.cbKategorier);
            this.Controls.Add(this.cmdShowRecipe);
            this.Controls.Add(this.cmdCreateNewRecipe);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.lstRecept);
            this.Name = "frmStart";
            this.Text = "Start Receptsamling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRecept;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdCreateNewRecipe;
        private System.Windows.Forms.Button cmdShowRecipe;
        private System.Windows.Forms.ComboBox cbKategorier;
    }
}

