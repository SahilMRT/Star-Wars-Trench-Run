// Created by: Sahil Patel on Nov/23/2016
//The objective to create a program that shows the death star being blown up
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Wars_Trench_Run
{
    public partial class form1 : Form
    {
        //
        int x;
        int y;
        int drop;
        int lineUp;
        int lineDown;
        int lineLeft;
        int lineRight;

        //Adds sounds in program 
        SoundPlayer themeSong = new SoundPlayer(Properties.Resources.startheme);
        SoundPlayer starSong = new SoundPlayer(Properties.Resources.Death_Star_Sound);
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Click(object sender, EventArgs e)
        {
            // Declares Fonts and brushs 
            Graphics g = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.White);
            SolidBrush brush2 = new SolidBrush(Color.OrangeRed);
            Pen pen = new Pen(Color.White);
            Font title = new Font("Times New Roman", 20);

            //Declaring the plan to destroy the Death Star
            BackgroundImage.Dispose();
            g.Clear(Color.Black);
            this.BackgroundImage = null;
            Refresh(); 
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            Font drawFont = new Font("Arial", 16, FontStyle.Regular);
            themeSong.Play();
            formGraphics.DrawString("Death Star Attack Plan", drawFont, drawBrush, 125, 30);
            Thread.Sleep(2000);
            formGraphics.DrawString(" During the battle, Rebel spies managed to steal", drawFont, drawBrush, 30, 100);
            Thread.Sleep(2000);
            formGraphics.DrawString(" secret plans to the Empire's ultimate weapon, the ", drawFont, drawBrush, 30, 130);
            Thread.Sleep(2000);
            formGraphics.DrawString(" Death Star, an armored space station with enough", drawFont, drawBrush, 30, 160);
            Thread.Sleep(2000);
            formGraphics.DrawString("power to destroy an entire planet!", drawFont, drawBrush, 30, 190);
            Thread.Sleep(2000);
            formGraphics.DrawString(" Princess Leia races home, with the stolen plans", drawFont, drawBrush, 30, 220);
            Thread.Sleep(2000);
            formGraphics.DrawString("that can save her people and restore", drawFont, drawBrush, 30, 250);
            Thread.Sleep(2000);
            formGraphics.DrawString("FREEDOM TO THE GALAXY...", drawFont, drawBrush, 30, 280);
            Thread.Sleep(2000);
            themeSong.Stop();

            //Creating the Death Star and the bomb dropping into it
            lineUp = 283;
            lineDown = 283;
            lineRight = 330;
            lineLeft = 330;
            x = 675;
            y = 50;
            drop = 125;

            for (int i = 0; i <= 304; i++)
            {
                if (i >= 0 && i <= 60)
                {
                    g.Clear(Color.Black);
                    g.DrawEllipse(pen, 180, 130, 300, 300);
                    g.DrawEllipse(pen, 322, 275, 16, 16);
                    g.DrawLine(pen, 330, 153, 330, 275);
                    g.DrawRectangle(pen, 305, 132, 50, 20);

                    g.FillRectangle(brush, x, y, 30, 10);

                    Thread.Sleep(10);
                    x -= 5;
                    y = y + 1;
                }
                else if (i >= 60 && i <= 106)
                {
                    g.Clear(Color.Black);
                    g.DrawEllipse(pen, 180, 130, 300, 300);
                    g.DrawEllipse(pen, 322, 275, 16, 16);
                    g.DrawLine(pen, 330, 153, 330, 275);
                    g.DrawRectangle(pen, 305, 132, 50, 20);
                    g.FillRectangle(brush, x, 110, 30, 10);

                    Thread.Sleep(10);
                    x--;
                }
                else if (i >= 106 && i < 189)
                {
                    g.Clear(Color.Black);
                    g.DrawEllipse(pen, 180, 130, 300, 300);
                    g.DrawEllipse(pen, 322, 275, 16, 16);
                    g.DrawLine(pen, 330, 153, 330, 275);
                    g.DrawRectangle(pen, 305, 132, 50, 20);

                    g.FillRectangle(brush, x, 110, 30, 10);
                    g.FillRectangle(brush, 327, drop, 7, 7);

                    Thread.Sleep(10);
                    x--;
                    drop += 2;
                }
                else if (i == 189)
                {
                    starSong.Play();
                }
                else if (i > 189 && i <= 301)
                {
                    g.Clear(Color.Black);
                    g.DrawEllipse(pen, 180, 130, 300, 300);
                    g.DrawEllipse(pen, 322, 275, 16, 16);
                    g.DrawLine(pen, 330, 153, 330, 275);
                    g.DrawRectangle(pen, 305, 132, 50, 20);
                    Thread.Sleep(10);
                    lineUp--;
                    lineRight++;
                    lineLeft--;
                    lineDown++;
                    x -= 3;
                    y--;

                    // Declaring parts of the bomb after and during its explosion 
                    g.FillEllipse(brush2, 180 - i / 2, 130 - i / 2, 300 + i, 300 + i);
                    Thread.Sleep(10);

                    //Ending Screen for the Soldier 
                    formGraphics.DrawString("Good Job Soldier!", drawFont, drawBrush, 30, 60);

                }
                
            }
        }
    }
}