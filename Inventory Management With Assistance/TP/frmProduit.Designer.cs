namespace TP
{
    partial class frmProduit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_produitLabel;
            System.Windows.Forms.Label designation_produitLabel;
            System.Windows.Forms.Label image_produitLabel;
            System.Windows.Forms.Label qtestockLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduit));
            this.gestionCommercialHamzaDataSet = new TP.GestionCommercialHamzaDataSet();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new TP.GestionCommercialHamzaDataSetTableAdapters.ProduitTableAdapter();
            this.tableAdapterManager = new TP.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager();
            this.categorieTableAdapter = new TP.GestionCommercialHamzaDataSetTableAdapters.CategorieTableAdapter();
            this.produitListBox = new System.Windows.Forms.ListBox();
            this.iD_produitTextBox = new System.Windows.Forms.TextBox();
            this.designation_produitTextBox = new System.Windows.Forms.TextBox();
            this.image_produitTextBox = new System.Windows.Forms.TextBox();
            this.qtestockTextBox = new System.Windows.Forms.TextBox();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categorieComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Voice = new System.Windows.Forms.Button();
            iD_produitLabel = new System.Windows.Forms.Label();
            designation_produitLabel = new System.Windows.Forms.Label();
            image_produitLabel = new System.Windows.Forms.Label();
            qtestockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_produitLabel
            // 
            iD_produitLabel.AutoSize = true;
            iD_produitLabel.Location = new System.Drawing.Point(242, 292);
            iD_produitLabel.Name = "iD_produitLabel";
            iD_produitLabel.Size = new System.Drawing.Size(56, 13);
            iD_produitLabel.TabIndex = 2;
            iD_produitLabel.Text = "ID produit:";
            // 
            // designation_produitLabel
            // 
            designation_produitLabel.AutoSize = true;
            designation_produitLabel.Location = new System.Drawing.Point(242, 318);
            designation_produitLabel.Name = "designation_produitLabel";
            designation_produitLabel.Size = new System.Drawing.Size(101, 13);
            designation_produitLabel.TabIndex = 4;
            designation_produitLabel.Text = "Designation produit:";
            // 
            // image_produitLabel
            // 
            image_produitLabel.AutoSize = true;
            image_produitLabel.Location = new System.Drawing.Point(242, 344);
            image_produitLabel.Name = "image_produitLabel";
            image_produitLabel.Size = new System.Drawing.Size(74, 13);
            image_produitLabel.TabIndex = 6;
            image_produitLabel.Text = "Image produit:";
            // 
            // qtestockLabel
            // 
            qtestockLabel.AutoSize = true;
            qtestockLabel.Location = new System.Drawing.Point(242, 370);
            qtestockLabel.Name = "qtestockLabel";
            qtestockLabel.Size = new System.Drawing.Size(51, 13);
            qtestockLabel.TabIndex = 10;
            qtestockLabel.Text = "qtestock:";
            // 
            // gestionCommercialHamzaDataSet
            // 
            this.gestionCommercialHamzaDataSet.DataSetName = "GestionCommercialHamzaDataSet";
            this.gestionCommercialHamzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.gestionCommercialHamzaDataSet;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = this.categorieTableAdapter;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CommandeTableAdapter = null;
            this.tableAdapterManager.LigneTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = this.produitTableAdapter;
            this.tableAdapterManager.UpdateOrder = TP.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // produitListBox
            // 
            this.produitListBox.DataSource = this.produitBindingSource;
            this.produitListBox.DisplayMember = "Designation_produit";
            this.produitListBox.FormattingEnabled = true;
            this.produitListBox.Location = new System.Drawing.Point(23, 269);
            this.produitListBox.Name = "produitListBox";
            this.produitListBox.Size = new System.Drawing.Size(174, 264);
            this.produitListBox.TabIndex = 1;
            this.produitListBox.ValueMember = "ID_produit";
            // 
            // iD_produitTextBox
            // 
            this.iD_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "ID_produit", true));
            this.iD_produitTextBox.Location = new System.Drawing.Point(349, 289);
            this.iD_produitTextBox.Name = "iD_produitTextBox";
            this.iD_produitTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_produitTextBox.TabIndex = 3;
            // 
            // designation_produitTextBox
            // 
            this.designation_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "Designation_produit", true));
            this.designation_produitTextBox.Location = new System.Drawing.Point(349, 315);
            this.designation_produitTextBox.Name = "designation_produitTextBox";
            this.designation_produitTextBox.Size = new System.Drawing.Size(100, 20);
            this.designation_produitTextBox.TabIndex = 5;
            // 
            // image_produitTextBox
            // 
            this.image_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "Image_produit", true));
            this.image_produitTextBox.Location = new System.Drawing.Point(349, 341);
            this.image_produitTextBox.Name = "image_produitTextBox";
            this.image_produitTextBox.Size = new System.Drawing.Size(100, 20);
            this.image_produitTextBox.TabIndex = 7;
            this.image_produitTextBox.TextChanged += new System.EventHandler(this.image_produitTextBox_TextChanged);
            // 
            // qtestockTextBox
            // 
            this.qtestockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "qtestock", true));
            this.qtestockTextBox.Location = new System.Drawing.Point(349, 367);
            this.qtestockTextBox.Name = "qtestockTextBox";
            this.qtestockTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtestockTextBox.TabIndex = 11;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.gestionCommercialHamzaDataSet;
            // 
            // categorieBindingSource1
            // 
            this.categorieBindingSource1.DataMember = "Categorie";
            this.categorieBindingSource1.DataSource = this.gestionCommercialHamzaDataSet;
            // 
            // categorieComboBox
            // 
            this.categorieComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produitBindingSource, "ID_categorie", true));
            this.categorieComboBox.DataSource = this.categorieBindingSource1;
            this.categorieComboBox.DisplayMember = "Nom_cat";
            this.categorieComboBox.FormattingEnabled = true;
            this.categorieComboBox.Location = new System.Drawing.Point(23, 231);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(174, 21);
            this.categorieComboBox.TabIndex = 12;
            this.categorieComboBox.ValueMember = "ID_categorie";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(213, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 19);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(522, 502);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 46);
            this.button6.TabIndex = 25;
            this.button6.Text = "Annuler";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(307, 502);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 46);
            this.button5.TabIndex = 24;
            this.button5.Text = "valider";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(615, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 46);
            this.button4.TabIndex = 23;
            this.button4.Text = "supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.Location = new System.Drawing.Point(236, 450);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(121, 46);
            this.btn_ajouter.TabIndex = 22;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(535, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(743, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(422, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 46);
            this.button3.TabIndex = 28;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(809, 210);
            this.bunifuGradientPanel1.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(252, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(671, 564);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(53, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 31;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btn_Voice
            // 
            this.btn_Voice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voice.Location = new System.Drawing.Point(349, 564);
            this.btn_Voice.Name = "btn_Voice";
            this.btn_Voice.Size = new System.Drawing.Size(264, 32);
            this.btn_Voice.TabIndex = 30;
            this.btn_Voice.Text = " Assistant";
            this.btn_Voice.UseVisualStyleBackColor = true;
            this.btn_Voice.Click += new System.EventHandler(this.btn_Voice_Click);
            // 
            // frmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(808, 608);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btn_Voice);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.categorieComboBox);
            this.Controls.Add(iD_produitLabel);
            this.Controls.Add(this.iD_produitTextBox);
            this.Controls.Add(designation_produitLabel);
            this.Controls.Add(this.designation_produitTextBox);
            this.Controls.Add(image_produitLabel);
            this.Controls.Add(this.image_produitTextBox);
            this.Controls.Add(qtestockLabel);
            this.Controls.Add(this.qtestockTextBox);
            this.Controls.Add(this.produitListBox);
            this.Name = "frmProduit";
            this.Text = "frmProduit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProduit_FormClosing);
            this.Load += new System.EventHandler(this.frmProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestionCommercialHamzaDataSet gestionCommercialHamzaDataSet;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox produitListBox;
        private System.Windows.Forms.TextBox iD_produitTextBox;
        private System.Windows.Forms.TextBox designation_produitTextBox;
        private System.Windows.Forms.TextBox image_produitTextBox;
        private System.Windows.Forms.TextBox qtestockTextBox;
        private GestionCommercialHamzaDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.BindingSource categorieBindingSource1;
        private System.Windows.Forms.ComboBox categorieComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button btn_Voice;
    }
}