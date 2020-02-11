using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class frmcategorie : Form
    {
        public frmcategorie()
        {
            InitializeComponent();
        }

        private void categorieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categorieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

        }

        private void frmcategorie_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.categorieTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Categorie);

        }

        private void frmcategorie_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.categorieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

        }
    }
}
