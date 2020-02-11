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
    public partial class Ligne : Form
    {
        public Ligne()
        {
            InitializeComponent();
        }

        private void ligneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ligneBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
            }
            catch {
                MessageBox.Show("Cant save");
                return;
            }
        }

        private void Ligne_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Ligne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ligneTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Ligne);

        }

        private void Ligne_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Validate();
                this.ligneBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
            }
            catch {
                MessageBox.Show("Error in Enregistrement");
                
                return;

            }
        }

        private void ligneDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            ligneBindingSource.RemoveCurrent();
            this.ligneTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Ligne);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void ligneBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
