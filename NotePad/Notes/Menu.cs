using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Notes
{
    public partial class Menu : Form
    {
        int a = 1;
        int id = 0;
        //Point p = new Point();




        Information i ;
        MenuForm_Son m;


        public Menu(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Closing?!?","You Really Wanna Close?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
                Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            m = new MenuForm_Son(id);


            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            m.AutoScroll = true;
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(m);
            panel_Container.Tag = m;
            m.Show();

            
                
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {


            i = new Information(id);


            i.TopLevel = false;
            i.Dock = DockStyle.Fill;
            i.AutoScroll = true;
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(i);
            i.Show();
           
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            

            if (bunifuGradientPanel1.Width == 89)
            {
                bunifuGradientPanel1.Width = 178;
                bunifuImageButton1.Width = 178;
                Logout.Width = 178;
                Logout.Text = "Log Out";
                
               // bunifuImageButton2.Width = 178;
                
                //bunifuImageButton4.Width = 178;
                
                bunifuImageButton5.Width = 66;
                label2.Visible = true;
                label1.Visible = true;
               // Point p = new Point(bunifuImageButton2.Location.X, bunifuImageButton5.Location.Y);
                //bunifuImageButton5.Location = p;


            }
            else {
                bunifuGradientPanel1.Width = 89;
                bunifuImageButton1.Width = 89;
                Logout.Width = 89;
                Logout.Text = "";
                bunifuImageButton2.Width = 89;
                
                bunifuImageButton4.Width = 89;
                
                bunifuImageButton5.Width = 89;
                Point p = new Point(bunifuImageButton2.Location.X, bunifuImageButton5.Location.Y);
                bunifuImageButton5.Location = p;
                label1.Visible = false;
                label2.Visible = false;



            }
            
            
        }

        private void bunifuImageButton5_DoubleClick(object sender, EventArgs e)
        {

          
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            m = new MenuForm_Son(id);
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            m.AutoScroll = true;
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(m);
            panel_Container.Tag = m;
            m.Show();


            //if (cn.State != ConnectionState.Open)
            //{
            //    cn.ConnectionString = ConfigurationManager.ConnectionStrings["Login"].ToString();
            //    cn.Open();

            //}
            //da = new SqlDataAdapter("Select * from Notes where id_admin = "+id, cn);
            //da.Fill(ds, "Notes");

            //bs.DataSource = ds;
            //bs.DataMember = "Notes";

            //listBox1.DataSource = bs;
            //listBox1.DisplayMember = "nom_note";
            //listBox1.ValueMember = "id";



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nomNote.DataBindings.Clear();
            //nomNote.DataBindings.Add("Text",bs,"Nom_note");
            //contenu.DataBindings.Clear();
            //contenu.DataBindings.Add("Text", bs, "Contenu_note");
            //dateNote.DataBindings.Clear();
            //dateNote.DataBindings.Add("Text",bs,"Date_Creation");
            //txtid.DataBindings.Clear();
            //txtid.DataBindings.Add("Text",bs,"id_admin");


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            //bs.AddNew();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ////id = 2;
            //txtid.Text = id.ToString();
            //dateNote.Text = DateTime.Now.ToString();
            //bs.EndEdit();
          

        }

      

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter data = new SqlDataAdapter("Select * from Notes",cn);

            //SqlCommandBuilder com = new SqlCommandBuilder(data);

            //data.Update(ds.Tables["Notes"]);
            //da.Update(ds.Tables["Notes"]);

        }

        private void panel_Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            m = new MenuForm_Son(id);


            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            m.AutoScroll = true;
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(m);
            panel_Container.Tag = m;
            m.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            i = new Information(id);


            i.TopLevel = false;
            i.Dock = DockStyle.Fill;
            i.AutoScroll = true;
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(i);
            i.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form f = new Login_Form();
            f.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

            SqlConnection con = new SqlConnection();

            SqlCommand command = new SqlCommand();

            SqlDataReader data ;

            if (con.State != ConnectionState.Open)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Login"].ToString();
                con.Open();
            }
            command = new SqlCommand("Select username,Password_admin from Admins");










        }
    }
}
