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

namespace WindowsFormsApplication3
{
    public partial class High_score : Form
    {
        public High_score()
        {
            InitializeComponent();
        }

        private void High_score_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'names1DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.names1DataSet.Table1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table1BindingSource.AddNew();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            table1BindingSource.EndEdit();
            table1TableAdapter.Update(names1DataSet.Table1);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-C6B1GJG\\SQLEXPRESS;Initial Catalog=names1;Integrated Security=True");
            con.Open();
            MessageBox.Show("Connection open");
            SqlCommand cm;
            string nm = textBox1.Text;
            string hs = textBox2.Text;
            int hss = Convert.ToInt32(hs);
            string query = "insert into Table1 (Highscore , name1) values ("+hss+" , '"+nm+"')";
            cm = new SqlCommand(query, con);
            cm.Dispose();
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            table1BindingSource.RemoveCurrent();

        }
    }
}
