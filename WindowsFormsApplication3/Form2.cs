using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int second = 0;


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            panel3.Left += 2;
            if (panel3.Left + panel3.Width > panel1.Width + 10)
                panel3.Left = 0;
            if (second == 300)
            {
                Form1 fm1 = new Form1();
                timer1.Stop();
                this.Hide();
                fm1.Show();
            }
        }
    
    }
}
