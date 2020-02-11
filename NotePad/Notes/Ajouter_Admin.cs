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
    public partial class Ajouter_Admin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand command ;
        SqlDataReader dataReader ;


        int id = 0;
        public Ajouter_Admin(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_Admin_Load(object sender, EventArgs e)
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["Login"].ToString();
                cn.Open();
            }
            command = new SqlCommand("Select * from Admins where reference = "+id,cn);
            dataReader= command.ExecuteReader();
            while (dataReader.Read())
            {
                listBox1.Items.Add(dataReader[0].ToString());
              

            }
           



        }
        string refe = "";
        int idRef = 0;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            command = null;
            int c = 0;
            dataReader.Close();
            try
            {

                command = new SqlCommand("Insert into Admins values ('" + MY_DB_ENCR.Encrypt(textBox1.Text) + "','" + MY_DB_ENCR.Encrypt(textBox2.Text) + "',' ','" + id + "')", cn);
                c = command.ExecuteNonQuery();
                if (c != 0)
                    MessageBox.Show("Added");
            }
            catch {

                MessageBox.Show("Change The UserName Its Already used");
            }
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int c = 0;
            dataReader.Close();
            command = new SqlCommand("delete from Admins where reference = "+id+" and id_admin = "+textBox3.Text+"",cn);
            c =command.ExecuteNonQuery();
            if (c != 0)
            {
                MessageBox.Show("Done");
            }
            else
                MessageBox.Show("You cant delete this User He's not countain your Reference :) ");


        }
    }
}
