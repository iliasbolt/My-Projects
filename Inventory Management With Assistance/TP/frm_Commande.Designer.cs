namespace TP
{
    partial class frm_Commande
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
            System.Windows.Forms.Label iD_commandeLabel;
            System.Windows.Forms.Label date_commandeLabel;
            System.Windows.Forms.Label designation_commandeLabel;
            System.Windows.Forms.Label iD_clientLabel;
            System.Windows.Forms.Label iD_clientLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Commande));
            this.gestionCommercialHamzaDataSet = new TP.GestionCommercialHamzaDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new TP.GestionCommercialHamzaDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new TP.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager();
            this.commandeTableAdapter = new TP.GestionCommercialHamzaDataSetTableAdapters.CommandeTableAdapter();
            this.ligneTableAdapter = new TP.GestionCommercialHamzaDataSetTableAdapters.LigneTableAdapter();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKLigneCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.commandeListBox = new System.Windows.Forms.ListBox();
            this.fKCommandeClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.commandeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.commandeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.iD_commandeTextBox = new System.Windows.Forms.TextBox();
            this.date_commandeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.designation_commandeTextBox = new System.Windows.Forms.TextBox();
            this.iD_clientTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iD_clientTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ligneDataGridView = new System.Windows.Forms.DataGridView();
            this.iDcommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKLigneCommandeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.fKLigneCommandeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKLigneCommandeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ligneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new TP.GestionCommercialHamzaDataSetTableAdapters.ProduitTableAdapter();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Voice = new System.Windows.Forms.Button();
            iD_commandeLabel = new System.Windows.Forms.Label();
            date_commandeLabel = new System.Windows.Forms.Label();
            designation_commandeLabel = new System.Windows.Forms.Label();
            iD_clientLabel = new System.Windows.Forms.Label();
            iD_clientLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLigneCommandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCommandeClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ligneDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLigneCommandeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLigneCommandeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLigneCommandeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_commandeLabel
            // 
            iD_commandeLabel.AutoSize = true;
            iD_commandeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_commandeLabel.Location = new System.Drawing.Point(196, 97);
            iD_commandeLabel.Name = "iD_commandeLabel";
            iD_commandeLabel.Size = new System.Drawing.Size(105, 18);
            iD_commandeLabel.TabIndex = 4;
            iD_commandeLabel.Text = "ID commande:";
            // 
            // date_commandeLabel
            // 
            date_commandeLabel.AutoSize = true;
            date_commandeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_commandeLabel.Location = new System.Drawing.Point(196, 126);
            date_commandeLabel.Name = "date_commandeLabel";
            date_commandeLabel.Size = new System.Drawing.Size(122, 18);
            date_commandeLabel.TabIndex = 6;
            date_commandeLabel.Text = "Date commande:";
            // 
            // designation_commandeLabel
            // 
            designation_commandeLabel.AutoSize = true;
            designation_commandeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            designation_commandeLabel.Location = new System.Drawing.Point(196, 151);
            designation_commandeLabel.Name = "designation_commandeLabel";
            designation_commandeLabel.Size = new System.Drawing.Size(169, 18);
            designation_commandeLabel.TabIndex = 8;
            designation_commandeLabel.Text = "Designation commande:";
            // 
            // iD_clientLabel
            // 
            iD_clientLabel.AutoSize = true;
            iD_clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_clientLabel.Location = new System.Drawing.Point(196, 177);
            iD_clientLabel.Name = "iD_clientLabel";
            iD_clientLabel.Size = new System.Drawing.Size(64, 18);
            iD_clientLabel.TabIndex = 10;
            iD_clientLabel.Text = "ID client:";
            // 
            // iD_clientLabel1
            // 
            iD_clientLabel1.AutoSize = true;
            iD_clientLabel1.Location = new System.Drawing.Point(11, 319);
            iD_clientLabel1.Name = "iD_clientLabel1";
            iD_clientLabel1.Size = new System.Drawing.Size(68, 16);
            iD_clientLabel1.TabIndex = 12;
            iD_clientLabel1.Text = "ID client:";
            // 
            // gestionCommercialHamzaDataSet
            // 
            this.gestionCommercialHamzaDataSet.DataSetName = "GestionCommercialHamzaDataSet";
            this.gestionCommercialHamzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.gestionCommercialHamzaDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.CommandeTableAdapter = this.commandeTableAdapter;
            this.tableAdapterManager.LigneTableAdapter = this.ligneTableAdapter;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TP.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
            // 
            // ligneTableAdapter
            // 
            this.ligneTableAdapter.ClearBeforeFill = true;
            // 
            // clientListBox
            // 
            this.clientListBox.DataSource = this.clientBindingSource;
            this.clientListBox.DisplayMember = "Nom_client";
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.ItemHeight = 16;
            this.clientListBox.Location = new System.Drawing.Point(13, 66);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(186, 244);
            this.clientListBox.TabIndex = 1;
            this.clientListBox.ValueMember = "ID_client";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "FK_Commande_Client";
            this.commandeBindingSource.DataSource = this.clientBindingSource;
            // 
            // ligneBindingSource
            // 
            this.ligneBindingSource.DataMember = "FK_Ligne_Commande";
            this.ligneBindingSource.DataSource = this.commandeBindingSource;
            // 
            // fKLigneCommandeBindingSource
            // 
            this.fKLigneCommandeBindingSource.DataMember = "FK_Ligne_Commande";
            this.fKLigneCommandeBindingSource.DataSource = this.commandeBindingSource;
            // 
            // commandeBindingSource1
            // 
            this.commandeBindingSource1.DataMember = "FK_Commande_Client";
            this.commandeBindingSource1.DataSource = this.clientBindingSource;
            // 
            // commandeListBox
            // 
            this.commandeListBox.DataSource = this.fKCommandeClientBindingSource;
            this.commandeListBox.DisplayMember = "Designation_commande";
            this.commandeListBox.FormattingEnabled = true;
            this.commandeListBox.ItemHeight = 18;
            this.commandeListBox.Location = new System.Drawing.Point(23, 66);
            this.commandeListBox.Name = "commandeListBox";
            this.commandeListBox.Size = new System.Drawing.Size(167, 238);
            this.commandeListBox.TabIndex = 2;
            this.commandeListBox.ValueMember = "ID_commande";
            // 
            // fKCommandeClientBindingSource
            // 
            this.fKCommandeClientBindingSource.DataMember = "FK_Commande_Client";
            this.fKCommandeClientBindingSource.DataSource = this.clientBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = ">>>";
            // 
            // commandeBindingSource2
            // 
            this.commandeBindingSource2.DataMember = "Commande";
            this.commandeBindingSource2.DataSource = this.gestionCommercialHamzaDataSet;
            // 
            // commandeBindingSource3
            // 
            this.commandeBindingSource3.DataMember = "Commande";
            this.commandeBindingSource3.DataSource = this.gestionCommercialHamzaDataSet;
            // 
            // iD_commandeTextBox
            // 
            this.iD_commandeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKCommandeClientBindingSource, "ID_commande", true));
            this.iD_commandeTextBox.Enabled = false;
            this.iD_commandeTextBox.Location = new System.Drawing.Point(345, 97);
            this.iD_commandeTextBox.Name = "iD_commandeTextBox";
            this.iD_commandeTextBox.Size = new System.Drawing.Size(200, 24);
            this.iD_commandeTextBox.TabIndex = 5;
            // 
            // date_commandeDateTimePicker
            // 
            this.date_commandeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fKCommandeClientBindingSource, "Date_commande", true));
            this.date_commandeDateTimePicker.Enabled = false;
            this.date_commandeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_commandeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_commandeDateTimePicker.Location = new System.Drawing.Point(345, 123);
            this.date_commandeDateTimePicker.Name = "date_commandeDateTimePicker";
            this.date_commandeDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.date_commandeDateTimePicker.TabIndex = 7;
            // 
            // designation_commandeTextBox
            // 
            this.designation_commandeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKCommandeClientBindingSource, "Designation_commande", true));
            this.designation_commandeTextBox.Enabled = false;
            this.designation_commandeTextBox.Location = new System.Drawing.Point(371, 149);
            this.designation_commandeTextBox.Name = "designation_commandeTextBox";
            this.designation_commandeTextBox.Size = new System.Drawing.Size(174, 24);
            this.designation_commandeTextBox.TabIndex = 9;
            // 
            // iD_clientTextBox
            // 
            this.iD_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKCommandeClientBindingSource, "ID_client", true));
            this.iD_clientTextBox.Enabled = false;
            this.iD_clientTextBox.Location = new System.Drawing.Point(345, 175);
            this.iD_clientTextBox.Name = "iD_clientTextBox";
            this.iD_clientTextBox.Size = new System.Drawing.Size(200, 24);
            this.iD_clientTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(iD_clientLabel1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.clientListBox);
            this.groupBox1.Controls.Add(this.iD_clientTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 357);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Client";
            // 
            // iD_clientTextBox1
            // 
            this.iD_clientTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ID_client", true));
            this.iD_clientTextBox1.Location = new System.Drawing.Point(99, 316);
            this.iD_clientTextBox1.Name = "iD_clientTextBox1";
            this.iD_clientTextBox1.Size = new System.Drawing.Size(100, 22);
            this.iD_clientTextBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = ">>>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = ">>>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = ">>>";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iD_commandeTextBox);
            this.groupBox2.Controls.Add(this.commandeListBox);
            this.groupBox2.Controls.Add(this.iD_clientTextBox);
            this.groupBox2.Controls.Add(iD_clientLabel);
            this.groupBox2.Controls.Add(this.designation_commandeTextBox);
            this.groupBox2.Controls.Add(iD_commandeLabel);
            this.groupBox2.Controls.Add(designation_commandeLabel);
            this.groupBox2.Controls.Add(this.date_commandeDateTimePicker);
            this.groupBox2.Controls.Add(date_commandeLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(283, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 329);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les Commande";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ligneDataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(854, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 329);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Les Ligne";
            // 
            // ligneDataGridView
            // 
            this.ligneDataGridView.AllowUserToAddRows = false;
            this.ligneDataGridView.AllowUserToDeleteRows = false;
            this.ligneDataGridView.AutoGenerateColumns = false;
            this.ligneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ligneDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcommandeDataGridViewTextBoxColumn,
            this.iDproduitDataGridViewTextBoxColumn,
            this.qteDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn});
            this.ligneDataGridView.DataSource = this.fKLigneCommandeBindingSource3;
            this.ligneDataGridView.Location = new System.Drawing.Point(15, 19);
            this.ligneDataGridView.Name = "ligneDataGridView";
            this.ligneDataGridView.ReadOnly = true;
            this.ligneDataGridView.Size = new System.Drawing.Size(436, 289);
            this.ligneDataGridView.TabIndex = 0;
            // 
            // iDcommandeDataGridViewTextBoxColumn
            // 
            this.iDcommandeDataGridViewTextBoxColumn.DataPropertyName = "ID_commande";
            this.iDcommandeDataGridViewTextBoxColumn.HeaderText = "ID_commande";
            this.iDcommandeDataGridViewTextBoxColumn.Name = "iDcommandeDataGridViewTextBoxColumn";
            this.iDcommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDproduitDataGridViewTextBoxColumn
            // 
            this.iDproduitDataGridViewTextBoxColumn.DataPropertyName = "ID_produit";
            this.iDproduitDataGridViewTextBoxColumn.HeaderText = "ID_produit";
            this.iDproduitDataGridViewTextBoxColumn.Name = "iDproduitDataGridViewTextBoxColumn";
            this.iDproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qteDataGridViewTextBoxColumn
            // 
            this.qteDataGridViewTextBoxColumn.DataPropertyName = "Qte";
            this.qteDataGridViewTextBoxColumn.HeaderText = "Qte";
            this.qteDataGridViewTextBoxColumn.Name = "qteDataGridViewTextBoxColumn";
            this.qteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKLigneCommandeBindingSource3
            // 
            this.fKLigneCommandeBindingSource3.DataMember = "FK_Ligne_Commande";
            this.fKLigneCommandeBindingSource3.DataSource = this.fKCommandeClientBindingSource;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = ">>>";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.LawnGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(51, 577);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(87, 49);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 19;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.LawnGreen;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(280, 577);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(87, 49);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 20;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.LawnGreen;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(557, 577);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(87, 49);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 21;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.LawnGreen;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(844, 577);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(87, 49);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 22;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(465, 523);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 22);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Commande(a)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(637, 523);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 22);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.Text = "Ligne(b)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // fKLigneCommandeBindingSource1
            // 
            this.fKLigneCommandeBindingSource1.DataMember = "FK_Ligne_Commande";
            this.fKLigneCommandeBindingSource1.DataSource = this.commandeBindingSource;
            // 
            // fKLigneCommandeBindingSource2
            // 
            this.fKLigneCommandeBindingSource2.DataMember = "FK_Ligne_Commande";
            this.fKLigneCommandeBindingSource2.DataSource = this.commandeBindingSource;
            // 
            // ligneBindingSource1
            // 
            this.ligneBindingSource1.DataMember = "Ligne";
            this.ligneBindingSource1.DataSource = this.gestionCommercialHamzaDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ajouter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Modifier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(562, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Valider";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(841, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Supprimer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1169, 545);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Anuller";
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.LawnGreen;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(1158, 577);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(87, 49);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 30;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
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
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-4, -2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1327, 193);
            this.bunifuGradientPanel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(731, 637);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(53, 30);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton6.TabIndex = 34;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // btn_Voice
            // 
            this.btn_Voice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voice.Location = new System.Drawing.Point(461, 635);
            this.btn_Voice.Name = "btn_Voice";
            this.btn_Voice.Size = new System.Drawing.Size(264, 32);
            this.btn_Voice.TabIndex = 33;
            this.btn_Voice.Text = " Assistant";
            this.btn_Voice.UseVisualStyleBackColor = true;
            this.btn_Voice.Click += new System.EventHandler(this.btn_Voice_Click);
            // 
            // frm_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1323, 682);
            this.Controls.Add(this.bunifuImageButton6);
            this.Controls.Add(this.btn_Voice);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bunifuImageButton5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_Commande";
            this.Text = "frm_Commande";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Commande_FormClosing);
            this.Load += new System.EventHandler(this.frm_Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLigneCommandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCommandeClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ligneDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLigneCommandeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLigneCommandeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLigneCommandeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestionCommercialHamzaDataSet gestionCommercialHamzaDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox clientListBox;
        private System.Windows.Forms.TextBox textBox1;
        private GestionCommercialHamzaDataSetTableAdapters.CommandeTableAdapter commandeTableAdapter;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.LigneTableAdapter ligneTableAdapter;
        private System.Windows.Forms.BindingSource ligneBindingSource;
        private System.Windows.Forms.BindingSource fKLigneCommandeBindingSource;
        private System.Windows.Forms.BindingSource commandeBindingSource1;
        private System.Windows.Forms.ListBox commandeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource commandeBindingSource2;
        private System.Windows.Forms.BindingSource commandeBindingSource3;
        private System.Windows.Forms.TextBox iD_commandeTextBox;
        private System.Windows.Forms.DateTimePicker date_commandeDateTimePicker;
        private System.Windows.Forms.TextBox designation_commandeTextBox;
        private System.Windows.Forms.TextBox iD_clientTextBox;
        private System.Windows.Forms.BindingSource fKCommandeClientBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView ligneDataGridView;
        private System.Windows.Forms.BindingSource fKLigneCommandeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKLigneCommandeBindingSource2;
        private System.Windows.Forms.BindingSource ligneBindingSource1;
        private System.Windows.Forms.BindingSource fKLigneCommandeBindingSource3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private System.Windows.Forms.TextBox iD_clientTextBox1;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private System.Windows.Forms.Button btn_Voice;
    }
}