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
using System.Threading;

namespace Notes
{
    public partial class Login_Form : Form
    {
        int Id;

        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        SqlConnection cn = new SqlConnection();
        SqlDataAdapter da;



        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {


            //empty les zone de text
            login.Text = "";
            password.Text = "";

            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["Login"].ToString();
                cn.Open();

            }
            da = new SqlDataAdapter("Select * from Admins",cn);
            da.Fill(ds,"Admins");

            bs.DataSource = ds;
            bs.DataMember = "Admins";
            

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //    MessageBox.Show(MY_DB_ENCR.Encrypt("a"));
            //login wajed a
            //pass        a

            SqlDataReader data;

            string loginENC = "", passwordENC = "";

           
            string PlainText = "";
            string PlainText2 = "";



            string c1="", c2="";

            string a1 = "", a2 = "";

            string key = "";
            ///////////test encryption///////
            SqlCommand com = new SqlCommand("Select username,Password_admin,key_encryption from Admins ", cn);

            data = com.ExecuteReader();

            while (data.Read())
            {
                PlainText = data["username"].ToString();
                PlainText2 = data["Password_admin"].ToString();
                key = data["key_encryption"].ToString();
                
                loginENC = MY_DB_ENCR.Decrypt(PlainText,key);
                //MessageBox.Show("pass   "+loginENC);
                passwordENC = MY_DB_ENCR.Decrypt(PlainText2,key);

                //\\
                if (loginENC.ToString() == login.Text && password.Text == passwordENC.ToString())
                {
                    //MessageBox.Show(key);

                    login.Text = loginENC.ToString();
                    password.Text = passwordENC.ToString();
                    c1 = login.Text;
                    c2 = password.Text;
                    a1 = PlainText;
                    a2 = PlainText2;

                    string sql = "username like '%" + a1 + "%' and Password_admin like '%" + a2 + "%'";
                    bs.Filter = sql;
                    listBox1.DataSource = bs;
                    listBox1.DisplayMember = "id_admin";
                    listBox1.ValueMember = "id_admin";



                    if (bs.Count != 0 && listBox1.Items.Count != 0 && c1 == loginENC && passwordENC == password.Text)
                    {
                        Id = int.Parse(listBox1.SelectedValue.ToString());
                        //Thread.Sleep(1700);

                        Splash s = new Splash(Id);

                        s.ShowDialog();
                        this.Hide();

                    }

                }
            }
            data.Close();


            ////////// nice code

          
        }
    }
}
