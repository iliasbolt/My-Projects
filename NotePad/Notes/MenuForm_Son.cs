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
    public partial class MenuForm_Son : Form
    {


       

        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        SqlConnection cn = new SqlConnection();
        SqlDataAdapter da;




        int id = 0;
        public MenuForm_Son(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void MenuForm_Son_Load(object sender, EventArgs e)
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["Login"].ToString();
                cn.Open();

            }
            da = new SqlDataAdapter("Select * from Notes where id_admin = " + id, cn);
            da.Fill(ds, "Notes");

            bs.DataSource = ds;
            bs.DataMember = "Notes";

            listBox2.DataSource = bs;
            listBox2.DisplayMember = "nom_note";
            listBox2.ValueMember = "id";

            



        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            //id = 2;
            txtid.Text = id.ToString();
            dateNote.Text = DateTime.Now.ToString();
            bs.EndEdit();

            Synchronizer();

        }
        public void Synchronizer()
        {

            SqlDataAdapter data = new SqlDataAdapter("Select * from Notes", cn);

            SqlCommandBuilder com = new SqlCommandBuilder(data);

            data.Update(ds.Tables["Notes"]);
            da.Update(ds.Tables["Notes"]);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomNote.DataBindings.Clear();
            nomNote.DataBindings.Add("Text", bs, "Nom_note");
            contenu.DataBindings.Clear();
            contenu.DataBindings.Add("Text", bs, "Contenu_note");
            dateNote.DataBindings.Clear();
            dateNote.DataBindings.Add("Text", bs, "Date_Creation");
            txtid.DataBindings.Clear();
            txtid.DataBindings.Add("Text", bs, "id_admin");

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            
            bs.EndEdit();
            Synchronizer();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
            Synchronizer();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
