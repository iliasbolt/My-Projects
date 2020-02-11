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
    public partial class Commande : Form
    {
        public Commande()
        {
            InitializeComponent();
        }

        private void commandeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commandeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

        }

        private void Commande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Commande'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);

        }

        private void Commande_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                this.Validate();
                this.commandeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
            }
            catch {

                MessageBox.Show("Not Enregistrer Try Again !!");
            }
        }
    }
}
