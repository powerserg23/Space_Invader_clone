using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{

    public partial class Form2 : Form
    {
        int Level;
        int fire;
        int levelscore;
        int aggregatescore = 0;
        int numshots = 0;
        private bool shoot;
        private bool enemfire1=false;
        private bool enemfire2 = false;
        private bool enemfire3 = false;
        private bool enemfire4 = false;
        private bool enemfire5 = false;
        private bool enemfire6 = false;
        bool finalgameover;
         int herohealth = 3;
        int boss1health = 3;
        int boss2health = 3;
        int boss3health = 3;
        Random rnd = new Random();
        
        public Form2()
        {


          
            InitializeComponent();
           
           
            PlayTimer.Start();
            healthcounter.Text = herohealth.ToString();
            this.ActiveControl = heroship1;
            bool shoot = false;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void enemyshipTimer_Tick(object sender, EventArgs e)
        {
           
            int width = this.Width; // get the width of Form.

            if (enemyship1.Location.X > width - enemyship1.Width) 
            {
                enemyship1.Location = new Point(1, enemyship1.Location.Y);
             if (!enemfire1) { 
                 enemybullet1.Top = enemyship1.Top + 20;
               enemybullet1.Left = enemyship1.Left + 35;
                    }
                   

            }
            else
            {
                enemyship1.Location = new Point(enemyship1.Location.X + 10, enemyship1.Location.Y);
                if (!enemfire1)
                {
                    enemybullet1.Top = enemyship1.Top + 20;
                    enemybullet1.Left = enemyship1.Left + 35;
                }


            }

            if (enemyship2.Location.X > width - enemyship2.Width) 
            {
                enemyship2.Location = new Point(1, enemyship2.Location.Y);
                if (!enemfire2)
                {
                    enemybullet2.Top = enemyship2.Top + 20;
                    enemybullet2.Left = enemyship2.Left + 35;
                }
            }
            else

            {
                enemyship2.Location = new Point(enemyship2.Location.X + 10, enemyship2.Location.Y);
                if (!enemfire2)
                {
                    enemybullet2.Top = enemyship2.Top + 20;
                    enemybullet2.Left = enemyship2.Left + 35;
                }
            }


            if (enemyship3.Location.X > width - enemyship3.Width) 
            {
                enemyship3.Location = new Point(1, enemyship3.Location.Y);
                if (!enemfire3)
                {
                    enemybullet3.Top = enemyship3.Top + 20;
                    enemybullet3.Left = enemyship3.Left + 35;
                }
            }
            else

            {
                enemyship3.Location = new Point(enemyship3.Location.X + 10, enemyship3.Location.Y);
                if (!enemfire3)
                {
                    enemybullet3.Top = enemyship3.Top + 20;
                    enemybullet3.Left = enemyship3.Left + 35;
                }
            }


            if (enemyship4.Location.X > width - enemyship4.Width)
            {
                enemyship4.Location = new Point(1, enemyship4.Location.Y);
                if (!enemfire4)
                {
                    enemybullet4.Top = enemyship4.Top + 20;
                    enemybullet4.Left = enemyship4.Left + 35;
                }
            }
            else
            {
                enemyship4.Location = new Point(enemyship4.Location.X + 10, enemyship4.Location.Y);
                if (!enemfire4)
                {
                    enemybullet4.Top = enemyship4.Top + 20;
                    enemybullet4.Left = enemyship4.Left + 35;
                }
            }


            if (Level > 1)
           
            
            
            {
                if (enemyship5.Location.X < 0 - enemyship5.Width)
                {
                    enemyship5.Location = new Point(700, enemyship5.Location.Y);
                    if (!enemfire5)
                    {
                        enemybullet5.Top = enemyship5.Top + 20;
                        enemybullet5.Left = enemyship5.Left + 35;
                    }
                }
                else
                {
                    enemyship5.Location = new Point(enemyship5.Location.X - 10, enemyship5.Location.Y);
                    if (!enemfire5)
                    {
                        enemybullet5.Top = enemyship5.Top + 20;
                        enemybullet5.Left = enemyship5.Left + 35;
                    }
                }

                if (enemyship6.Location.X < 0 - enemyship6.Width)
                {
                    enemyship6.Location = new Point(700, enemyship6.Location.Y);
                    if (!enemfire5)
                    {
                        enemybullet6.Top = enemyship6.Top + 20;
                        enemybullet6.Left = enemyship6.Left + 35;
                    }
                }
                else
                {
                    enemyship6.Location = new Point(enemyship6.Location.X - 10, enemyship6.Location.Y);
                    if (!enemfire6)
                    {
                        enemybullet6.Top = enemyship6.Top + 20;
                        enemybullet6.Left = enemyship6.Left + 35;
                    }
                }
            }
            

            heroship1.Focus();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            if (Level == 1 && herohealth==0)
            {
                aggregatescore = 0;

                restart();
               
            }
            else if (Level==1)
            {
                restart();
            }
           else if (Level==2&&herohealth==0)
            {
              
                
                
            }
            else if (Level==2)
            {
                restart();
            }
            else if (Level==3&&herohealth==0)
            {
                
            }
           else if (Level == 3)
            {
                restart();
                
            }
            else if (Level==4)
            {

            }


        }
        
       
        private void heroship1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {

            
            if (e.KeyCode == Keys.Left)
            {
                e.IsInputKey = true;
                if (heroship1.Left - 15 < 0)
                    heroship1.Left = 0;
                else
                    heroship1.Left -= 15;
                if (shoot == false)
                {
                    resetlaser();
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
             
                if (heroship1.Left+15>581)
                {
                    heroship1.Left=581;
                }
                else
                heroship1.Left += 15;
                if (shoot == false)
                {
                    resetlaser();
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                numshots += 1;
                if (shoot == false)
                {
                    bulletTimer1.Start();
                    shoot = true;
                }
              
             
            }   
        }

        private void resetlaser()
        {
            laser.Top = heroship1.Top;
            laser.Left = heroship1.Left + 26;
        }

        private void bulletTimer1_Tick(object sender, EventArgs e)
        {
            
           if (laser.Top<0)
            {
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
            }
           else
            laser.Top -= 10;


        }

        private void PlayTimer_tick(object sender, EventArgs e)
        {
            detectenemyhit();
            detectherohit();
            enemyfire();
            checkenemfire1();
            checkenemfire2();
            checkenemfire3();
            checkenemfire4();
            checkenemfire5();
            checkenemfire6();
            checkbossappear();
            checkplay();
        }


        private void checkplay()
        {
            if (Level == 1)
            {
                if (enemyship1.Top == 660 && enemyship2.Top == 660 && enemyship3.Top == 660 && enemyship4.Top == 660 || herohealth == 0)
                    GameOver();
            }
            else if (Level==2)
            {
                if (enemyship1.Top == 660 && enemyship2.Top == 660 && enemyship3.Top == 660 && enemyship4.Top == 660 && enemyship5.Top== 660  &&enemyship6.Top == 660 || herohealth == 0)
                    GameOver();

            }
            else if (Level==3)
            {
                if ( boss1.Top == 560 && boss2.Top == 560 && boss3.Top == 560 || herohealth == 0)

                    GameOver();

            }
        }
        private void detectherohit()
        {
            
            if (enemybullet1.Bounds.IntersectsWith(heroship1.Bounds))
            {
                enemybullet1.Top = enemyship1.Top + 20;
                enemybullet1.Left = enemyship1.Left + 35;
                enemfire1 = false;
                herohealth -= 1;
                
            }
            
            if (enemybullet2.Bounds.IntersectsWith(heroship1.Bounds))
            {
                enemybullet2.Top = enemyship2.Top + 20;
                enemybullet2.Left = enemyship2.Left + 35;
                enemfire2 = false;
                herohealth -= 1;
                
            }
            
            if (enemybullet3.Bounds.IntersectsWith(heroship1.Bounds))
            {
                enemybullet3.Top = enemyship3.Top + 20;
                enemybullet3.Left = enemyship3.Left + 35;
                enemfire3 = false;
                herohealth -= 1;
                
            }

            if (enemybullet4.Bounds.IntersectsWith(heroship1.Bounds))
            {
                enemybullet4.Top = enemyship4.Top + 20;
                enemybullet4.Left = enemyship4.Left + 35;
                enemfire4 = false;
                herohealth -= 1;

            }

            if (enemybullet5.Bounds.IntersectsWith(heroship1.Bounds))
            {
                enemybullet5.Top = enemyship5.Top + 20;
                enemybullet5.Left = enemyship5.Left + 35;
                enemfire5 = false;
                herohealth -= 1;

            }
            if (enemybullet6.Bounds.IntersectsWith(heroship1.Bounds))
            {
                enemybullet6.Top = enemyship6.Top + 20;
                enemybullet6.Left = enemyship6.Left + 35;
                enemfire6 = false;
                herohealth -= 1;

            }
            if (boss1bullet1.Bounds.IntersectsWith(heroship1.Bounds) || boss1bullet2.Bounds.IntersectsWith(heroship1.Bounds) || boss1bullet3.Bounds.IntersectsWith(heroship1.Bounds))
                herohealth -= 1;
            if (boss2bullet1.Bounds.IntersectsWith(heroship1.Bounds) || boss2bullet2.Bounds.IntersectsWith(heroship1.Bounds) || boss2bullet3.Bounds.IntersectsWith(heroship1.Bounds))
                herohealth -= 1;
            if (boss3bullet1.Bounds.IntersectsWith(heroship1.Bounds) || boss3bullet2.Bounds.IntersectsWith(heroship1.Bounds) || boss3bullet3.Bounds.IntersectsWith(heroship1.Bounds))
                herohealth -= 1;

            if (herohealth==0)
            {
                enemybullet1.Top = 500;
            }
            healthcounter.Text = herohealth.ToString();
        }
     
        private void detectenemyhit()
        {
            if (laser.Bounds.IntersectsWith(enemyship1.Bounds))
            {
                enemyship1.Top = 660;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;

            }
            else if (laser.Bounds.IntersectsWith(enemyship2.Bounds))
            {
                enemyship2.Top = 660;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;

            }
            else if (laser.Bounds.IntersectsWith(enemyship3.Bounds))
            {
                enemyship3.Top = 660;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;

            }
            else if (laser.Bounds.IntersectsWith(enemyship4.Bounds))
            {
                enemyship4.Top = 660;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;

            }
            else if (laser.Bounds.IntersectsWith(enemyship5.Bounds))
            {
                enemyship5.Top = 660;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;

            }
            else if (laser.Bounds.IntersectsWith(enemyship6.Bounds))
            {
                if (Level == 3)
                {
                    enemyship6.Top = 560;
                    resetlaser();
                    bulletTimer1.Stop();
                    shoot = false;
                }
                else
                {
                    enemyship6.Top = 660;
                    resetlaser();
                    bulletTimer1.Stop();
                    shoot = false;
                }

            }


        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void randint_Tick(object sender, EventArgs e)
        {
            if (Level == 1)
                fire = rnd.Next(1, 5);
            else
                fire = rnd.Next(1, 7);
        }
        private void enemyfire()
        {
  
            if (fire==1)
            {
                enemfire1 = true;
            }
            if (fire==2)
            {
                enemfire2 = true;
            }
            if (fire==3)
            {
                enemfire3 = true;

            }
            if (fire==4)
            {
                enemfire4 = true;
            }
            if (fire == 5)
            {
                enemfire5 = true;
            }
            if (fire==6)
            {
                enemfire6 = true;
            }
        }
        private void checkenemfire1()
        {
            if (enemfire1)
                enem1laser.Start();
            else
                enem1laser.Stop();
           
        }
        private void checkenemfire2()
        {
            if (enemfire2)
                enem2laser.Start();
            else
                enem2laser.Stop();
        }
        private void checkenemfire3()
        {
            if (enemfire3)
                enem3laser.Start();
            else
                enem3laser.Stop();
        }
        private void checkenemfire4()
        {
            if (enemfire4)
                enem4laser.Start();
            else
                enem4laser.Stop();
        }
        private void checkenemfire5()
        {
            if (enemfire5)
            {
                enem5laser.Start();
      
            }
            else
                enem5laser.Stop();
        }
        private void checkenemfire6()
        {
            if (enemfire6)
            {
                enem6laser.Start();

            }
            else
                enem6laser.Stop();

        }
        private void enem1laser_Tick(object sender, EventArgs e)
        {
            if (enemybullet1.Top > 521)
            {
                enemybullet1.Top = enemyship1.Top +20;
                enemybullet1.Left = enemyship1.Left+35;
                enemfire1 = false;
            }
            else if (enemfire1)
                enemybullet1.Top += 10;
         
                
        }

        private void enem2laser_Tick(object sender, EventArgs e)
        {
            if (enemybullet2.Top > 521)
            {
                enemybullet2.Top = enemyship2.Top + 20;
                enemybullet2.Left = enemyship2.Left + 35;
                enemfire2 = false;
            }
            else if (enemfire2)
            
                enemybullet2.Top += 10;
            
        }
        private void enem3laser_Tick(object sender, EventArgs e)
        {
            if (enemybullet3.Top > 521)
            {
                enemybullet3.Top = enemyship3.Top + 20;
                enemybullet3.Left = enemyship3.Left + 35;
                enemfire3 = false;
            }
            else if (enemfire3)

                enemybullet3.Top += 10;

        }
        private void enem4laser_Tick(object sender, EventArgs e)
        {
            if (enemybullet4.Top > 521)
            {
                enemybullet4.Top = enemyship4.Top + 20;
                enemybullet4.Left = enemyship4.Left + 35;
                enemfire4 = false;
            }
            else if (enemfire4)

                enemybullet4.Top += 10;

        }
        private void enem5laser_Tick(object sender, EventArgs e)
        {
            if (enemybullet5.Top > 521)
            {
                enemybullet5.Top = enemyship5.Top + 20;
                enemybullet5.Left = enemyship5.Left + 35;
                enemfire5 = false;
            }
            else if (enemfire5)

                enemybullet5.Top += 10;
        }
        private void enem6laser_Tick(object sender, EventArgs e)
        {
            if (enemybullet6.Top > 521)
            {
                enemybullet6.Top = enemyship6.Top + 20;
                enemybullet6.Left = enemyship6.Left + 35;
                enemfire6 = false;
            }
            else if (enemfire6)

                enemybullet6.Top += 10;

        }

        private void calcscore()
        {
            if (numshots==0)
            {
                levelscore = 0;
            }
            else
            levelscore = (herohealth * 10337) / numshots;

        }
        private void GameOver()
        {
            this.ActiveControl = null;
            heroship1.Visible = false;
                laser.Visible = false;
            scorelabel.Visible = true;
            scorecounter.Visible = true;
                gameoverlabel.Visible = true;
                enemybullet1.Visible = false;
                enemybullet2.Visible = false;
                enemybullet3.Visible = false;
                enemybullet4.Visible = false;
            enemybullet5.Visible = false;
            enemybullet6.Visible = false;


       

            calcscore();
            aggregatescore += levelscore;
            scorecounter.Text = aggregatescore.ToString();


            PlayTimer.Stop();
            bosstimer.Stop();

            enemyshiptimer.Stop();

            if (herohealth > 0&&Level==3)
                {
                gameoverlabel.Text = "Congrats! Welcome Back to Earth!";
                MainButton.Text = "Back To Menu";
            MainButton.Visible = true;


            }
            else if (herohealth == 0)
            {
               
               
                gameoverlabel.Text="Game Over";
                MainButton.Text = "Back to Menu";
                enemyship1.Visible = false;
                enemyship2.Visible = false;
                enemyship3.Visible = false;
                enemyship4.Visible = false;
                enemyship5.Visible = false;
                enemyship6.Visible = false;
            } else if (herohealth > 0)
            {
                gameoverlabel.Text = "Good Job!";
                Level++;
                MainButton.Text = "Next Level";
                levelcounter.Text = Level.ToString();
            }
            PlayTimer.Stop();
            randint.Stop();
        

            MainButton.Visible = true;
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Level = 1;
            levelcounter.Text = Level.ToString();


            if (Level==1)
            {
                enemyship5.Top = 660;
                enemyship6.Top = 660;
                enemybullet5.Top = enemyship5.Top;
                enemybullet6.Top = enemyship6.Top;
                boss1.Top = 550;
                boss2.Top = 550;
                boss3.Top = 550;

                boss1bullet1.Top = boss1.Top;
                boss1bullet2.Top = boss1.Top;
                boss1bullet2.Top = boss1.Top;

                boss2bullet1.Top = boss2.Top;
                boss2bullet1.Top = boss2.Top;
                boss2bullet1.Top = boss2.Top;

                boss3bullet1.Top = boss3.Top;
                boss3bullet1.Top = boss3.Top;
                boss3bullet1.Top = boss3.Top;


            }
            if (Level==2)
            {
                enemyship1.Top = 12;
                enemyship2.Top = 12;
                enemyship3.Top = 12;
                enemyship4.Top = 12;
                enemyship5.Top = 100;
                enemyship6.Top = 100;
                gameoverlabel.Visible = false;

            }
            if (Level == 3)
            {
                enemyship1.Top = 12;
                enemyship2.Top = 12;
                enemyship3.Top = 12;
                enemyship4.Top = 12;
                enemyship5.Top = 100;
                enemyship6.Top = 100;
             
                gameoverlabel.Visible = false;

            }
        }
        private void restart()
        {
            levelcounter.Text = Level.ToString();

            if (Level >= 1)
            {

                enemyship1.Location = new Point(21, 12);
                enemyship2.Location = new Point(131, 12);
                enemyship3.Location = new Point(257, 12);
                enemyship4.Location = new Point(380, 12);
                enemyship1.Visible = true;
                enemyship2.Visible = true;
                enemyship3.Visible = true;
                enemyship4.Visible = true;
                enemybullet1.Visible = true;
                enemybullet2.Visible = true;
                enemybullet3.Visible = true;
                enemybullet4.Visible = true;
                enemybullet1.Location = enemyship1.Location;
                enemybullet2.Location = enemyship2.Location;
                enemybullet3.Location = enemyship3.Location;
                enemybullet4.Location = enemyship4.Location;


                herohealth = 3;
            }
             if (Level>1)
            {
                enemyship5.Location =new Point(459, 100);  
                enemyship6.Location = new Point(597, 100);
                enemybullet5.Location = enemyship5.Location;
                enemybullet6.Location = enemyship6.Location;

                enemyship5.Visible = true;
                enemyship6.Visible = true;
                enemybullet5.Visible = true;
                enemybullet6.Visible = true;
                BackgroundImage = Properties.Resources.bg2;
            }



            scorecounter.Visible = false;
            scorelabel.Visible = false;
            gameoverlabel.Visible = false;
            heroship1.Visible = true;
            laser.Visible = true;
            randint.Start();
            enemyshiptimer.Start();
            MainButton.Visible = false;
            PlayTimer.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        private void checkbossappear()
        {
            if (Level == 3 && enemyship1.Top == 660 && enemyship2.Top == 660 && enemyship3.Top == 660 && enemyship4.Top == 660 &&
                    enemyship5.Top == 660 && enemyship6.Top == 560 )
            {
                bosstimer.Start();
                MainButton.Visible = false;
                if (boss1health == 3 && boss2health == 3 && boss3health == 3)
                {
                    boss1.Top = 68;
                    boss2.Top = 68;
                    boss3.Top = 68;
                }
            }
        }

        private void bosstimer_Tick(object sender, EventArgs e)
        {


            
            int width = this.Width;
            if (boss1.Location.X > width - boss1.Width)
            {
                boss1.Location = new Point(1, boss1.Location.Y);
           
            }
            else
            {
                boss1.Location = new Point(boss1.Location.X + 10, boss1.Location.Y);
          
            }


            if (boss2.Location.X > width - boss2.Width)
            {
                boss2.Location = new Point(1, boss2.Location.Y);
         
            }
            else
            {
                boss2.Location = new Point(boss2.Location.X + 10, boss2.Location.Y);
          
            }

            if (boss3.Location.X > width - boss3.Width)
            {
                boss3.Location = new Point(1, boss3.Location.Y);
           
            }
            else
            {
                boss3.Location = new Point(boss3.Location.X + 10, boss3.Location.Y);
              
            }
            checkboss1fire();
            checkboss2fire();
            checkboss3fire();
           checkbosshit();
            checkbosslife();
         


        }
        private void checkbosslife()
        {
            if (boss1health == 0)
            {
                boss1.Top = 560;
            }
            if (boss2health == 0)
            {
                boss2.Top = 560;
            }
            if (boss3health == 0)
            {
                boss3.Top = 560;
            }
        }
     
        private void checkbosshit()
        {
           
            if (laser.Bounds.IntersectsWith(boss1.Bounds))
            {
                boss1health -= 1;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
              
            }
            else if (laser.Bounds.IntersectsWith(boss2.Bounds))
            {
                boss2health -= 1;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
                
            }
            else if (laser.Bounds.IntersectsWith(boss3.Bounds))
            {
                boss3health -= 1;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
               
            }
            
        }
        private void checkboss1fire()
        {
            int formheight = this.Height;
            if (boss1bullet1.Location.Y>formheight)
            {

                boss1bullet1.Top = boss1.Top + 20;
                boss1bullet1.Left = boss1.Left + 35;
            }
            else
            {boss1bullet1.Top += 10;
            }

            if (boss1bullet2.Location.Y > formheight)
            {

                boss1bullet2.Top = boss1.Top + 20;
                boss1bullet2.Left = boss1.Left + 55;
            }
            else
            {
                boss1bullet2.Top += 10;
            }

            if (boss1bullet3.Location.Y > formheight)
            {

                boss1bullet3.Top = boss1.Top + 20;
                boss1bullet3.Left = boss1.Left + 75;
            }
            else
            {
                boss1bullet3.Top += 10;
            }
        }
        private void checkboss2fire()
        {
            int formheight = this.Height;
            if (boss2bullet1.Location.Y > formheight)
            {

                boss2bullet1.Top = boss2.Top + 20;
                boss2bullet1.Left = boss2.Left + 35;
            }
            else
            {
                boss2bullet1.Top += 10;
            }

            if (boss2bullet2.Location.Y > formheight)
            {

                boss2bullet2.Top = boss2.Top + 20;
                boss2bullet2.Left = boss2.Left + 55;
            }
            else
            {
                boss2bullet2.Top += 10;
            }

            if (boss2bullet3.Location.Y > formheight)
            {

                boss2bullet3.Top = boss2.Top + 20;
                boss2bullet3.Left = boss2.Left + 75;
            }
            else
            {
                boss2bullet3.Top += 10;
            }

        }
        private void checkboss3fire()
        {
            int formheight = this.Height;
            if (boss3bullet1.Location.Y > formheight)
            {

                boss3bullet1.Top = boss3.Top + 20;
                boss3bullet1.Left = boss3.Left + 35;
            }
            else
            {
                boss3bullet1.Top += 10;
            }

            if (boss3bullet2.Location.Y > formheight)
            {

                boss3bullet2.Top = boss3.Top + 20;
                boss3bullet2.Left = boss3.Left + 55;
            }
            else
            {
                boss3bullet2.Top += 10;
            }

            if (boss3bullet3.Location.Y > formheight)
            {

                boss3bullet3.Top = boss3.Top + 20;
                boss3bullet3.Left = boss3.Left + 75;
            }
            else
            {
                boss3bullet3.Top += 10;
            }

        }

     
    }


}
//class SelectablePictureBox : PictureBox
//{
//    public SelectablePictureBox()
//    {
//        SetStyle(ControlStyles.Selectable, true);
//        SetStyle(ControlStyles.UserMouse, true);
//        TabStop = true;
//    }

//    protected override void OnEnter(EventArgs e)
//    {
//        base.OnEnter(e);
//        this.Invalidate();
//    }
//    protected override void OnLeave(EventArgs e)
//    {
//        base.OnLeave(e);
//        this.Invalidate();
//    }
//    protected override void OnPaint(PaintEventArgs pe)
//    {
//        base.OnPaint(pe);
//        if (this.Focused)
//            ControlPaint.DrawFocusRectangle(pe.Graphics, ClientRectangle);
//    }

  
    
//}

