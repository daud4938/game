using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer Player = new WindowsMediaPlayer(); 
        private SoundPlayer sound;


        public Form1()
        {
            InitializeComponent();
            Player.URL = "pixelOst.mp3";
            

                 
        }
        

        private void LoadGame(object sender, EventArgs e)
        {
          
            gamescreen gamewindow = new gamescreen();
            gamewindow.Show();
            
  
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Player.controls.play();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Player.controls.stop();
        }

        private void musicOn_Click(object sender, EventArgs e)
        {
            Player.controls.play();
        }

        private void musicOff_Click(object sender, EventArgs e)
        {
            Player.controls.pause();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            High_score hi= new High_score();
            hi.Show();
        }
    }
}
