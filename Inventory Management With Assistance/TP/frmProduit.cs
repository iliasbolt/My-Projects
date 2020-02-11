using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace TP
{
    public partial class frmProduit : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();


        public frmProduit()
        {
            InitializeComponent();
        }

        private void produitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

        }

        private void frmProduit_Load(object sender, EventArgs e)
        {
            bunifuImageButton1.Visible = false;

            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.categorieTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Categorie);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.produitTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Produit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmcategorie f = new frmcategorie();
                f.ShowDialog();
                this.categorieTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Categorie);
            }
            catch {
                MessageBox.Show("Un Champs est vide !!!");
                return;
            }
        }

        private void frmProduit_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Validate();
                this.produitBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

            }
            catch {
                MessageBox.Show("Error dans Le Enregistrement !!");
                return;
            }
         
            
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (iD_produitTextBox.Text == "")
            {
                MessageBox.Show("Remplire le ID");
                return;
            }

            try
            {
                blocking(false);
                produitBindingSource.AddNew();
            }
            catch {
                MessageBox.Show("Error Dans Ajouter");
                return;
            }
           
           

        }
        public void blocking(bool v)
        {

            btn_ajouter.Visible = v;
            button4.Visible = v;
            button5.Visible = !v;
            button3.Visible = v;
            button6.Visible = !v;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                blocking(false);

                DialogResult d = MessageBox.Show("You wanna delete ?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (d == DialogResult.Yes)
                {
                    produitBindingSource.RemoveCurrent();


                }
                else
                    this.produitBindingSource.EndEdit();
            }
            catch {
                MessageBox.Show("Error In Suppression");
                return;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                blocking(true);
                produitBindingSource.EndEdit();
            }
            catch {
                MessageBox.Show("Error In Validation");
                return;

            }
            
            //this.categorieTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Categorie);
            //this.produitTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Produit);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                blocking(true);
                produitBindingSource.CancelEdit();
                this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
            }
            catch {
                MessageBox.Show("Error In Canceling");
                return;

            }
           
        }

        private void image_produitTextBox_TextChanged(object sender, EventArgs e)
        {
            string photo = "";

            if(image_produitTextBox.Text == "")
                pictureBox1.Load("Images/vide.jpg");

            try
            {
                photo = image_produitTextBox.Text == "" ? "vide.jpg" : image_produitTextBox.Text;
                pictureBox1.Load("Images/" + photo);

            }
            catch
            {
                try
                {
                    
                    pictureBox1.Load("Images/" + photo + ".jpg");
                }
                catch {
                    pictureBox1.Load("Images/vide.jpg");
                }
                //pictureBox1.Load("Images/" + photo + ".jpg");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "JPEG|*.jpg|PNG|*.png";

            DateTime d = new DateTime();
            Random r = new Random();
            if (o.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(o.FileName);
                int i = r.Next();
                d = DateTime.Now;
                string dt = d.ToString().Replace("/", "").Replace(" ", "").Replace(":", "");

                File.Copy(o.FileName, "Images/" + dt + i + ext);

                image_produitTextBox.Text = dt + i + ext;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                blocking(false);
                produitBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
            }
            catch
            {
                MessageBox.Show("Error In Modifier");
                return;

            }

        }

        private void btn_Voice_Click(object sender, EventArgs e)
        {
            bunifuImageButton1.Visible = true;
            btn_Voice.Visible = false;
            Choices ch = new Choices(new string[] { "ajouter", "modifier", "supprimer", "Valider", "Anuller "});
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
                        produitBindingSource.AddNew();

                    }
                    catch
                    {
                        robot.Speak("Error in Adding");

                    }

                    break;
                case "modifier":

                    robot.Speak("not Programmable yet");

                    break;
                case "supprimer":
                    try
                    {
                        produitBindingSource.RemoveCurrent();
                    }
                    catch
                    {
                        robot.Speak("Error in Removing");

                    }
                    break;
                case "Valider":
                    try
                    {
                        produitBindingSource.EndEdit();
                        robot.Speak("Validated");
                    }
                    catch
                    {
                        robot.Speak("Error in Validating");
                    }

                    break;
                case "Anuller":

                    produitBindingSource.CancelEdit();
                    robot.Speak(" , ,canceled");
                    break;
             

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();

            btn_Voice.Visible = true;
            bunifuImageButton1.Visible = false;
        }
    }
}
