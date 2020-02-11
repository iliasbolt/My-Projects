using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace TP
{
    public partial class frm_Commande : Form
    {
        
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        

        public frm_Commande()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

        }

        private void frm_Commande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.produitTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Produit);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Ligne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ligneTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Ligne);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Commande'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Client);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                clientBindingSource.Filter = "Nom_client like'%" + textBox1.Text + "%' ";
                
            }
            catch {

                MessageBox.Show("You cant beat me with SQL Injection :)) !!");
                return;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            blocking(false);
            if (radioButton1.Checked)
            {
                try
                {
                    Commande c = new Commande();

                    c.ShowDialog();
                    this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);
                }
                catch {
                    MessageBox.Show("Il ya un Valeur Null dans commande!!");

                    return;
                }
                
              
            }
            else
            {
                try
                {
                    Ligne l = new Ligne();
                    l.ShowDialog();
                    this.ligneTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Ligne);
                }
                catch
                {
                    MessageBox.Show("Il ya un Valeur Null dans ligne !!");

                    return;
                }

            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            blocking(true);
            try
            {
                this.Validate();
                this.clientBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
            }
            catch {

                MessageBox.Show(" Ne Pas Enregistrer");
                return;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            blocking(false);

            if (radioButton1.Checked)
            {
                try
                {
                    Commande c = new Commande();

                    c.ShowDialog();
                    this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);
                }
                catch
                {
                    MessageBox.Show("Il ya un Valeur Null dans commande!!");

                    return;
                }
            }
            else
            {
                try
                {
                    Ligne l = new Ligne();
                    l.ShowDialog();
                    this.ligneTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Ligne);
                }
                catch
                {
                    MessageBox.Show("Il ya un Valeur Null dans ligne !!");

                    return;
                }

            }
        }
        public void blocking(bool v)
        {

            bunifuImageButton1.Visible = v;
            bunifuImageButton4.Visible = v;
            bunifuImageButton2.Visible = v;
            bunifuImageButton5.Visible = !v;
            bunifuImageButton3.Visible = !v;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            blocking(false);
            if (radioButton1.Checked)
            {
                try
                {
                    Commande c = new Commande();

                    c.ShowDialog();
                    this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);
                }
                catch
                {
                    MessageBox.Show("ne pas Supprimer la commande!!");

                    return;
                }
            }
            else
            {
                try
                {
                    Ligne l = new Ligne();
                    l.ShowDialog();
                    this.ligneTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Ligne);
                }
                catch
                {
                    MessageBox.Show("ne pas Supprimer la ligne !!");

                    return;
                }

            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            blocking(true);

            try
            {
                if (radioButton1.Checked)
                    commandeBindingSource.CancelEdit();
                else
                    ligneBindingSource.CancelEdit();

                

            }
            catch
            {
                MessageBox.Show("ne pas Canceler !!");
                return;
            }
        }

        private void frm_Commande_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Validate();
                this.ligneBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
            }
            catch
            {
                MessageBox.Show("Error in Enregistrement ");

                return;

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Voice_Click(object sender, EventArgs e)
        {
            bunifuImageButton1.Visible = true;
            btn_Voice.Visible = false;
            Choices ch = new Choices(new string[] { "ajouter","nigga" ,"modifier", "supprimer","hello", "Valider", "Anuller ", "check radio button a", "check radio button b" ,"close"});
            GrammarBuilder g = new GrammarBuilder();
            g.Append(ch);

            Grammar grm = new Grammar(g);

            recEngine.LoadGrammarAsync(grm);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;


            recEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            SpeechSynthesizer robot = new SpeechSynthesizer();
            robot.SelectVoiceByHints(VoiceGender.Female);
            robot.Rate = -1;

            switch (e.Result.Text)
            {
                case "ajouter":
                    try
                    {
                        blocking(false);
                        if (radioButton1.Checked)
                        {
                            try
                            {
                                Commande c = new Commande();

                                c.ShowDialog();
                                this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);
                            }
                            catch
                            {
                                robot.Speak("there is a null place in commande");

                                return;
                            }


                        }
                        else
                        {
                            try
                            {
                                Ligne l = new Ligne();
                                l.ShowDialog();
                                this.ligneTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Ligne);
                            }
                            catch
                            {
                                MessageBox.Show("there is a null place in ligne");

                                return;
                            }

                        }

                    }
                    catch
                    {
                        robot.Speak("Error in Adding");

                    }

                    break;
                case "modifier":
                    blocking(false);

                    if (radioButton1.Checked)
                    {
                        try
                        {
                            Commande c = new Commande();

                            c.ShowDialog();
                            this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);
                        }
                        catch
                        {
                            robot.Speak("there is a null place in commande");

                            return;
                        }
                    }
                    else
                    {
                        try
                        {
                            Ligne l = new Ligne();
                            l.ShowDialog();
                            this.ligneTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Ligne);
                        }
                        catch
                        {
                            robot.Speak("Il ya un Valeur Null dans ligne ");

                            return;
                        }

                    }



                    //robot.Speak("not Programmable yet");

                    break;
                case "supprimer":
                    blocking(false);
                    if (radioButton1.Checked)
                    {
                        try
                        {
                            Commande c = new Commande();

                            c.ShowDialog();
                            this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);
                        }
                        catch
                        {
                           robot.Speak(" commande not deleted");

                            return;
                        }
                    }
                    else
                    {
                        try
                        {
                            Ligne l = new Ligne();
                            l.ShowDialog();
                            this.ligneTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Ligne);
                        }
                        catch
                        {
                            robot.Speak("ligne not deleted");

                            return;
                        }

                    }
                    break;
                case "Valider":
                    blocking(true);
                    try
                    {
                        this.Validate();
                        this.clientBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
                        robot.Speak(" validated ");
                    }
                    catch
                    {

                        robot.Speak(" Error in validating ");
                        return;
                    }

                    break;
                case "Anuller":
                    blocking(true);

                    try
                    {
                        if (radioButton1.Checked)
                            commandeBindingSource.CancelEdit();
                        else
                            ligneBindingSource.CancelEdit();
                        robot.Speak(" canceled ");


                    }
                    catch
                    {
                       robot.Speak(" not Canceled ");
                        return;
                    }
                    break;
                case "check radio button b":

                   // MessageBox.Show("lign");
                    radioButton2.Checked = true;
                    robot.Speak(" radio button b is checked");

                    break;
                case "check radio button a":

                   // MessageBox.Show("commande");
                    radioButton1.Checked = true;
                    robot.Speak(" radio button a is checked");

                    break;
              
            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btn_Voice.Visible = true;
            bunifuImageButton1.Visible = false;
        }
    }
   


}
