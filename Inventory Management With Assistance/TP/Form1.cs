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
    public partial class frmClient : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        Choices ch;
       
        
        public frmClient()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Client);
            bunifuImageButton1.Visible = false;

        }
        public void blocking(bool v)
        {
           
            button6.Visible = v;
            button5.Visible = v;
            btn_ajouter.Visible = !v;
            button4.Visible = !v;
            button2.Visible = !v;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                clientBindingSource.Filter = "Nom_client like '%" + textBox1.Text.ToString() + "%'";

            }
            catch {
                MessageBox.Show("You cant beat me with SQL Injection :)) !!");
                return;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
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

                photoTextBox.Text = dt + i + ext;
            }


        }

        private void photoTextBox_TextChanged(object sender, EventArgs e)
        {
            string photo = "";

            try
            {
                 photo = photoTextBox.Text == "" ? "vide.jpg" : photoTextBox.Text;
                pictureBox1.Load("Images/" + photo);

            }
            catch {
                pictureBox1.Load("Images/" + photo+".jpg");
            }
           
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                blocking(true);
                test();
                clientBindingSource.AddNew();

            }
            catch {
                MessageBox.Show("Error Dans Ajouter");
                return;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                blocking(true);
                DialogResult d = MessageBox.Show("You wanna delete ?", "deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (d == DialogResult.Yes)
                    clientBindingSource.RemoveCurrent();

            }
            catch {
                MessageBox.Show("Error in Supprime");
                return;
            }
           
        }
        public void test()
        {
            if (nom_clientTextBox.Text == "")
            {
                MessageBox.Show("remplire");
                return;
            }
            if (prenom_clientTextBox.Text == "")
            {
                MessageBox.Show("remplire");
                return;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                blocking(false);
                test();
                clientBindingSource.EndEdit();

            }
            catch {
                MessageBox.Show("Error in Supprime");
                return;
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                blocking(false);
                clientBindingSource.CancelEdit();
            }
            catch
            {
                MessageBox.Show("Error in Canceling");
                return;
            }
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
            }
            catch {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmProduit f = new frmProduit();
            //f.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                blocking(true);
                clientBindingSource.EndEdit();
            }
            catch
            {
                MessageBox.Show("Error in Modifier");
                return;
            }
        }

        private void btn_Voice_Click(object sender, EventArgs e)
        {
            

            bunifuImageButton1.Visible = true;
            btn_Voice.Visible = false;
             ch = new Choices(new string[] { "ajouter", "modifier", "supprimer", "Valider", "Anuller ", "close","id","Name","prenom","tel","adresse"});
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
                    try {

                        
                        clientBindingSource.AddNew();
                        
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
                    try { 
                    clientBindingSource.RemoveCurrent();
                        }
                        catch
                        {
                            robot.Speak("Error in Removing");

                            }
                     break;
                case "Valider":
                    try
                    {
                        
                        clientBindingSource.EndEdit();
                        robot.Speak("Validated");
                    }
                    catch {
                        robot.Speak("Error in Validating");
                    }
                   
                    break;
                case "Anuller":
                    
                    clientBindingSource.CancelEdit();

                    robot.Speak("canceled");
                    break;
          
                case "prenom":

                    nom_clientTextBox.Focus();
                    robot.Speak("Say Something");
                    
                    
                    nom_clientTextBox.Text = e.Result.Text.ToString();
                    
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
