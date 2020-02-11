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
    public partial class Information : Form
    {
        SqlCommand commande = new SqlCommand();
        SqlConnection cn = new SqlConnection();
        SqlDataReader dataReader;
        int id = 0;
        string c;
        string key = "";
        public Information(int _id)
        {
            InitializeComponent();
            id = _id;
         
        }
        private void ouverirconnection()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["Login"].ToString();
                cn.Open();
            }
        }
        private void Information_Load(object sender, EventArgs e)
        {
            ouverirconnection();

            commande = new SqlCommand("Select * from Admins where id_admin = "+id,cn);
            dataReader = commande.ExecuteReader();

            while (dataReader.Read())
            {
                key = dataReader[3].ToString();
                textBox1.Text = MY_DB_ENCR.Decrypt(dataReader[1].ToString(),key);
                textBox2.Text = MY_DB_ENCR.Decrypt(dataReader[2].ToString(),key);
                textBox3.Text = dataReader[0].ToString();
                textBox4.Text = dataReader[3].ToString();
                
                    

            }


            
          
            cn.Close();
             c = textBox4.Text; ;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {


                int a = 0;
                string KeyEncryption = textBox1.Text[0].ToString();
                key = KeyEncryption;
                commande = null;
                ouverirconnection();


                if (chk.Checked)
                    commande = new SqlCommand("update Admins set username = '" + MY_DB_ENCR.Encrypt(textBox1.Text, key) + "',Key_Encryption = '" + KeyEncryption + "' ,password_admin = '" + MY_DB_ENCR.Encrypt(textBox2.Text, key) + "' where id_admin = " + id.ToString() + " ", cn);
                else
                {
                    KeyEncryption = "";
                    commande = new SqlCommand("update Admins set username = '" + MY_DB_ENCR.Encrypt(textBox2.Text, "") + "',Key_Encryption = '" + KeyEncryption + "' ,password_admin = '" + MY_DB_ENCR.Encrypt(textBox2.Text, "") + "' where id_admin = " + id.ToString() + " ", cn);

                }


                
                a = commande.ExecuteNonQuery();
                if (a != 0)
                {
                    MessageBox.Show("Done");
                }

                dataReader = null;


                cn.Close();

            }
            catch {
                MessageBox.Show("Error");
                return;
            }


        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
            Ajouter_Admin a = new Ajouter_Admin(id);
            a.Show();
            
            
        }

        private void chk_OnChange(object sender, EventArgs e)
        {

        }
    }
}
