using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //WindowsMediaPLayer player = new WindowsMediaPlayer();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            //  player.URL = "music.mp3";
            player.SoundLocation = "example.wav";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //player.controls.play();


            // player.Play();


            //SoundPlayer splayer = new SoundPlayer (@"D:\repos\_GAME\Game\WindowsFormsApp1\bin\Debug\example.wav");
            // splayer.Play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode.ToString() == "X")
                this.Close();


            if (e.Control && e.KeyCode.ToString() == "F")
                Application.Restart();


           


            if (e.KeyCode == Keys.Left)
            {
                if (Player.Left > 0)
                    Player.Left += -30;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (Player.Right < 990)
                    Player.Left += 30;
            }
        }


        

        private void timer1_Tick(object sender, EventArgs e)
        {
            fall(Bone1, 5);
            fall(Bone2, 4);
            fall(Bone3, 2);
            fall(Bone4, 4);
            fall(Bone5, 3);
            fall(Bone6, 2);
            fall(Bone7, 4);
            fall(Bomb, 10);
            fall(Life, 8);
            //fall(Bomb2, 7);

            if (l == 0)
            {
                gameOver();
            }

        }


        Random rnd = new Random();

        int p = 0;  //Score
                    // int n = 0;  //nopoints
        int l = 3; // lifes


        void gameOver()
        {
            timer1.Enabled = false;
            gameover.Visible = true;
            button1.Visible = true;
            player.Play();


        }

        

        void fall(PictureBox Bone, int speed)
        {

            if (Bone.Top <= this.Height)
            {
                Lifes.Text = "Lifes: " + l.ToString();
                Bone.Top += speed;

            }

           

            if (Bomb.Bounds.IntersectsWith(Player.Bounds))

            {
                Bomb.Location = new Point((rnd.Next(100, 800)), 0);

                l--;
                Lifes.Text = "Lifes: " + l.ToString();

            }

          

            if (Life.Bounds.IntersectsWith(Player.Bounds))
            {
                Life.Location = new Point((rnd.Next(10, 1340)), 0);
                l++;
                Lifes.Text = "Lifes: " + l.ToString();
            }



          

            else if (Bone.Top > this.Height)
            {

                Bone.Location = new Point((rnd.Next(100, 900)), 0);
                //n++;
                //label1.Text = "Ups: " + n.ToString();                  

            }

           

            if (Bone.Bounds.IntersectsWith(Player.Bounds))
            {

                Bone.Location = new Point((rnd.Next(100, 1340)), 0);
                p += 2;
                Points.Text = "Score: " + p.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }




        private void Player_Click(object sender, EventArgs e)
        {
            //  this.Player.BackColor = Color.Transparent;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
