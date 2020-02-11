using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class Splash : Form
    {
        int id=0;
        public Splash(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value++;
            if (bunifuCircleProgressbar1.Value >= 100) {
                timer1.Stop();
                Menu f = new Notes.Menu(id);
                f.Show();
                this.Hide();
                
                
            }
               
        }
    }
}
