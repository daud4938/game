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
namespace WindowsFormsApplication3
{
    public partial class gamescreen : Form
    {
        WindowsMediaPlayer Player = new WindowsMediaPlayer();
        private SoundPlayer sound1;
       

        int pipespeed = 10;
        int gravity = 5;
        int score = 0;
        int cloudsSpeed = 4;
        int pictureBox1speed = 10;
        public gamescreen()
        {
            InitializeComponent();
            scoretext1.Hide();
            gameOver.Hide();
            info.Hide();
        }


        private void gametimerevent(object sender, EventArgs e)
        {
            fllapybird.Top += gravity;
            pipebottem.Left -= pipespeed;
            pipebottem1.Left -= pipespeed;
            pipebottem2.Left -= pipespeed;
            pipetop.Left -= pipespeed;
            pipetop1.Left -= pipespeed;
            pipetop2.Left -= pipespeed;
            clouds.Left -= cloudsSpeed;
            clouds1.Left -= cloudsSpeed;
            pictureBox1.Left -= pictureBox1speed;
            scoretext.Text = "SCORE:    " + score;
            scoretext1.Text = "YOUR SCORE:    " + score;


            if (pictureBox1.Left < -25)
            {
                pictureBox1.Left = 1500;
            }


            if (pipebottem.Left < -50)
            {
                pipebottem.Left = 800;
                score++;

                sound1 = new SoundPlayer("coin.wav");
                sound1.Play();
            }
            if (pipebottem1.Left < -50)
            {
                pipebottem1.Left = 800;
                score++;
                sound1 = new SoundPlayer("coin.wav");
                sound1.Play();
            }
            if (pipebottem2.Left < -50)
            {
                pipebottem2.Left = 800;
                score++;
                sound1 = new SoundPlayer("coin.wav");
                sound1.Play();
            }

            if (pipetop.Left < -50)
            {
                pipetop.Left = 800;
            }
            if (pipetop1.Left < -50)
            {
                pipetop1.Left = 800;
            }
            if (pipetop2.Left < -50)
            {
                pipetop2.Left = 800;
            }
            if (clouds.Left < -10)
            {
                clouds.Left = 900;
            }
            if (clouds1.Left < -10)
            {
                clouds1.Left = 900;
            }

        
            if (fllapybird.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                endgame();
               sound1 = new SoundPlayer("gmov.wav");
               sound1.Play();
            }
        
            if (fllapybird.Bounds.IntersectsWith(pipebottem.Bounds))
            {
                endgame();
                sound1 = new SoundPlayer("gmov.wav");
                sound1.Play();
            }
            if (fllapybird.Bounds.IntersectsWith(pipebottem1.Bounds))
            {
                endgame();
                sound1 = new SoundPlayer("gmov.wav");
                sound1.Play();
            }
            if (fllapybird.Bounds.IntersectsWith(pipebottem2.Bounds))
            {
                endgame();
                sound1 = new SoundPlayer("gmov.wav");
                sound1.Play();
            }
            if (fllapybird.Bounds.IntersectsWith(pipetop.Bounds))
            {
                endgame();
                sound1 = new SoundPlayer("gmov.wav");
                sound1.Play();
            }
            if (fllapybird.Bounds.IntersectsWith(pipetop1.Bounds))
            {
                endgame();
                sound1 = new SoundPlayer("gmov.wav");
                sound1.Play();
            }
            if (fllapybird.Bounds.IntersectsWith(pipetop2.Bounds))
            {
                endgame();
                sound1 = new SoundPlayer("gmov.wav");
                sound1.Play();
            }

        
            if (fllapybird.Bounds.IntersectsWith(ground.Bounds))
            {
                endgame();
                sound1 = new SoundPlayer("gmov.wav");
                sound1.Play();
            }

         
            if (fllapybird.Top < -30)
            {
                endgame();
                sound1 = new SoundPlayer("gmov.wav");
                sound1.Play();
            }
            
            if (score > 17)
            {
                pipespeed = 10;
                pictureBox1speed = 15;
            }

            if (score > 30)
            {
                pipespeed = 15;
                pictureBox1speed = 17;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 4;
            }
        }
        private void endgame()
        {
            gametimer.Stop();
            scoretext.Hide();
            scoretext1.Show();
            gameOver.Show();
            info.Show();
        

        }

        private void gamescreen_Load(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

        }

        private void gameOver_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void scoretext1_Click(object sender, EventArgs e)
        {

        }
    }
}
