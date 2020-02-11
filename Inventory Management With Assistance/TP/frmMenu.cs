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
using System.IO;
using System.Threading;
using System.Globalization;

using System.Diagnostics;

namespace TP
{
    public partial class frmMenu : Form
    {
        SpeechSynthesizer robot = new SpeechSynthesizer();
        //
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        
        //
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            try
            {
                frmClient f = new frmClient();

                f.ShowDialog();
            }
            catch {
                MessageBox.Show("Error Not Null Allowed in Client");
                return;

            }

        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                frmProduit f = new frmProduit();

                f.ShowDialog();
            }
            catch
            {

                MessageBox.Show("Error Not Null Allowed in produit");
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                frm_Commande f = new frm_Commande();

                f.ShowDialog();
            }
            catch
            {

                MessageBox.Show("Error Not Null Allowed  commande");
                return;
            }

           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string aboutme = "Hi ,This Programme is Devoloped By, ilias Balhi , This is The first Version 1.0,Maybe in the future there is an upgraded version  , thanks for using my Programme ";
            

            robot.SelectVoiceByHints(VoiceGender.Female);
            robot.Rate = -1;

            robot.Speak(aboutme);
            //Process.Start("chrome.exe");
            Process.Start("https://www.facebook.com/ilyas.mohamm");
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //start recognition

            recEngine.RecognizeAsync(RecognizeMode.Multiple);




            //
            bunifuImageButton2.Visible = true;
            bunifuFlatButton1.Enabled = false;
            //load the gif
            bunifuGradientPanel1.BackColor = Color.Black;
            bunifuGradientPanel1.GradientBottomLeft = Color.Black;
            bunifuGradientPanel1.GradientBottomRight = Color.Black;
            pictureBox1.Load("ai1.gif");



        

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //
            bunifuImageButton2.Visible = false;

            //rules
            Choices commansds = new Choices();
            commansds.Add(new string[] { "Clients", "produit", "Commands","hello" ,"close","focus on Client", "focus on produit", "focus on commande" });
            GrammarBuilder gbuilder = new GrammarBuilder();
            gbuilder.Append(commansds);
            Grammar gram = new Grammar(gbuilder);
            //start recognizing
            
            recEngine.LoadGrammarAsync(gram);
            recEngine.SetInputToDefaultAudioDevice();

            //
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;

            


             
        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "Clients":
                    frmClient f = new frmClient();
                    recEngine.RecognizeAsyncStop();

                    bunifuFlatButton1.Visible = true;
                    bunifuImageButton1.Visible = false;
                    f.ShowDialog();
                    
                    break;
                case "produit":
                    frmProduit p = new frmProduit();

                    recEngine.RecognizeAsyncStop();
                    bunifuFlatButton1.Visible = true;
                    
                    bunifuImageButton1.Visible = false;
                    p.ShowDialog();
                    break;
                case "Commands":
                    frm_Commande fr = new frm_Commande();
                    recEngine.RecognizeAsyncStop();
                    bunifuFlatButton1.Visible = true;
                    bunifuImageButton1.Visible = false;
                    fr.ShowDialog();
                    break;
                case "close":
                    this.Close();
                    break;
           
            }

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
            recEngine.RecognizeAsyncStop();
            bunifuFlatButton1.Enabled = true;
            bunifuImageButton2.Visible = false;
            pictureBox1.Load("house.png");
            bunifuGradientPanel1.GradientBottomLeft = Color.FromArgb(192, 0, 192);
            bunifuGradientPanel1.GradientBottomRight = Color.FromArgb(0, 0, 192);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
