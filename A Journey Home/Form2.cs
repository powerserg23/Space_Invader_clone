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
using System.Threading;
using A_Journey_Home;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        // initializing variables used in the program

        int Level;
        int fire;
        int levelscore;
        int numshots = 0;
        private bool shoot;
        private bool enemfire1=false;
        private bool enemfire2 = false;
        private bool enemfire3 = false;
        private bool enemfire4 = false;
        private bool enemfire5 = false;
        private bool enemfire6 = false;
        int boss1health = 3;
        int boss2health = 3;
        int boss3health = 3;
        // creating the random number with the random class
        Random rnd = new Random();

        // using sound player in visual studio for various sounds
        System.Media.SoundPlayer laser_shot = new System.Media.SoundPlayer("laser.wav");
        System.Media.SoundPlayer enemy_hit = new System.Media.SoundPlayer("enemyhit.wav");
        System.Media.SoundPlayer hero_hit = new System.Media.SoundPlayer("herohit.wav");

        public Form2()
        {
            InitializeComponent();
            // these are global variables
            A_Journey_Home.Variables.aggregatescore = 0;
            A_Journey_Home.Variables.herohealth = 3;
            // this is the main timer for all of the bullets
            PlayTimer.Start();
            // gives the level counter the value of the health variables
            healthcounter.Text = A_Journey_Home.Variables.herohealth.ToString();
            // this gives the user activecontrol to the heroship
            this.ActiveControl = heroship1;
            bool shoot = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Level = 1;
            levelcounter.Text = Level.ToString();
            // sets all of the ships that are not in level one to an outside location
            if (Level == 1)
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
            // sets all of the level two ships to their respective position
            if (Level >= 2)
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
        // this timer moves the ships
        private void enemyshipTimer_Tick(object sender, EventArgs e)
        {
            int width = this.Width; // get the width of Form2.


            // following if statements will check if the ship has reached the end of the form
            // if it has reached the end of the form, it will reappear on the other side
            // if it is not at the edge of the form then the ship will move 10 pixels to the left or right
            if (enemyship1.Location.X > width - enemyship1.Width) 
            {
                enemyship1.Location = new Point(1, enemyship1.Location.Y);
                if (!enemfire1)
                { 
                enemybullet1.Top = enemyship1.Top + 20;
                enemybullet1.Left = enemyship1.Left + 35;
                }   
            }
            else
            {
                // enemyship.top is the y coordinate, and enemyship.left is the x coordinate
                // we use the Point class to create new point and set the ship to the values of the point object
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
            // thsi is for the 2nd and 3rd levels where there are two more enemy ships that move opposite to the 4 top ships and has the same function as the previous if statements
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

            // after all of these conditions have been tried, the focus will comoe back to the heroship so the player can continue to move 
            heroship1.Focus();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            instructions.Visible = false;
        
         
         
            // if the player has won the level, the restart function will get called and the enemies will come back into frame and start the second level
             if (Level==1)
            {
                restart();
            }
            else if (Level==2)
            {
                restart();
            }
       
            else if (Level == 3)
            {
                restart();
            }
            else 
            if (Level == 4)
            {
                if (null != FormToShowOnClosing)
                {
                    FormToShowOnClosing.Show();
                    this.Close();
                }
            }
        }
        // this will allow the hero ship to move back and forth
        private void heroship1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            // this is for the left arrow
            if (e.KeyCode == Keys.Left)
            {
                e.IsInputKey = true;
                // if the ship has reached the left edge of the form then it will stop moving
                if (heroship1.Left - 15 < 0)
                    heroship1.Left = 0;
                else
                    heroship1.Left -= 15;
                // this moves the hero laser along with the hero ship so it can stay with it
                if (shoot == false)
                {
                    resetlaser();
                }
            }
            // this if for the right arrow
            else if (e.KeyCode == Keys.Right)
            {
                // this checks for the right side of the form and if it is reached then the hero will stop moving
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
            // this will be for shooting using the space bar
            else if (e.KeyCode == Keys.Space)
            {
                // this adds one to the numshots variables to count the number of shots the player has take 
                numshots += 1;
                // 
                if (shoot == false)
                {
                    // this starts the timer for the laser to move up in the form
                    bulletTimer1.Start();
                    shoot = true;
                    // this plays the sound for the laser
                    if(A_Journey_Home.Variables.SoundOn)
                    laser_shot.Play();
                }
            }   
        }
        // resets laser to player location
        private void resetlaser()
        {
            laser.Top = heroship1.Top;
            laser.Left = heroship1.Left + 26;
        }

        private void bulletTimer1_Tick(object sender, EventArgs e)
        {
            // moves the laser 10 pixels every 10 milliseconds and when it reaches the top of the form it resets to the player location
            // also sets the shoot boolean to false so the player can shoot again
            if (laser.Top < 0)
            {
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
            }
            else
                laser.Top -= 10;
        }
        //this timer runs different condition functions to run the game
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
            // for each one, it checks the location of the ship
            // if the ship is at a certain location (determines whether it has been shot) it will trigger the game over function or not
            if (Level == 1)
            {
                if (enemyship1.Top == 660 && enemyship2.Top == 660 && enemyship3.Top == 660 && enemyship4.Top == 660 || A_Journey_Home.Variables.herohealth == 0)
                    GameOver();
            }
            else if (Level == 2)
            {
                if (enemyship1.Top == 660 && enemyship2.Top == 660 && enemyship3.Top == 660 && enemyship4.Top == 660 && enemyship5.Top == 660 && enemyship6.Top == 660 || A_Journey_Home.Variables.herohealth == 0)
                    GameOver();
            }
            else if (Level == 3)
            {
                if (boss1.Top == 560 && boss2.Top == 560 && boss3.Top == 561 || A_Journey_Home.Variables.herohealth == 0)
                    GameOver();
            }
        }

        private void detectherohit()
        {     // this detects the if the bounds of each enemylaser has hit the hero ship.
           
            if (enemybullet1.Bounds.IntersectsWith(heroship1.Bounds))
            {
                enemybullet1.Top = enemyship1.Top + 20;
                enemybullet1.Left = enemyship1.Left + 35;
                enemfire1 = false;
                // if the hero is hit then the health of the hero goes down by one point
                A_Journey_Home.Variables.herohealth -= 1;
                // this plays the sounds for the hero being hit if if the hero is hit
                if (A_Journey_Home.Variables.SoundOn)
                    hero_hit.Play();
            }
            // same situation for every single bullet in the game
            
            if (enemybullet2.Bounds.IntersectsWith(heroship1.Bounds))
            {
                enemybullet2.Top = enemyship2.Top + 20;
                enemybullet2.Left = enemyship2.Left + 35;
                enemfire2 = false;
                A_Journey_Home.Variables.herohealth -= 1;
                if (A_Journey_Home.Variables.SoundOn)
                    hero_hit.Play();
            }

            if (enemybullet3.Bounds.IntersectsWith(heroship1.Bounds))
            {
                enemybullet3.Top = enemyship3.Top + 20;
                enemybullet3.Left = enemyship3.Left + 35;
                enemfire3 = false;
                A_Journey_Home.Variables.herohealth -= 1;
                if (A_Journey_Home.Variables.SoundOn)
                    hero_hit.Play();
            }

            if (enemybullet4.Bounds.IntersectsWith(heroship1.Bounds))
            {
                enemybullet4.Top = enemyship4.Top + 20;
                enemybullet4.Left = enemyship4.Left + 35;
                enemfire4 = false;
                A_Journey_Home.Variables.herohealth -= 1;
                if (A_Journey_Home.Variables.SoundOn)
                    hero_hit.Play();
            }

            if (enemybullet5.Bounds.IntersectsWith(heroship1.Bounds))
            {
                enemybullet5.Top = enemyship5.Top + 20;
                enemybullet5.Left = enemyship5.Left + 35;
                enemfire5 = false;
                A_Journey_Home.Variables.herohealth -= 1;
                if (A_Journey_Home.Variables.SoundOn)
                    hero_hit.Play();
            }

            if (enemybullet6.Bounds.IntersectsWith(heroship1.Bounds))
            {
                enemybullet6.Top = enemyship6.Top + 20;
                enemybullet6.Left = enemyship6.Left + 35;
                enemfire6 = false;
                A_Journey_Home.Variables.herohealth -= 1;
                if (A_Journey_Home.Variables.SoundOn)
                    hero_hit.Play();
            }

            if (boss1bullet1.Bounds.IntersectsWith(heroship1.Bounds) || boss1bullet2.Bounds.IntersectsWith(heroship1.Bounds) || boss1bullet3.Bounds.IntersectsWith(heroship1.Bounds))
            {
                A_Journey_Home.Variables.herohealth -= 1;
                if (A_Journey_Home.Variables.SoundOn)
                    hero_hit.Play();
            }
            
            if (boss2bullet1.Bounds.IntersectsWith(heroship1.Bounds) || boss2bullet2.Bounds.IntersectsWith(heroship1.Bounds) || boss2bullet3.Bounds.IntersectsWith(heroship1.Bounds))
            {
                A_Journey_Home.Variables.herohealth -= 1;
                if (A_Journey_Home.Variables.SoundOn)
                    hero_hit.Play();
            }

            if (boss3bullet1.Bounds.IntersectsWith(heroship1.Bounds) || boss3bullet2.Bounds.IntersectsWith(heroship1.Bounds) || boss3bullet3.Bounds.IntersectsWith(heroship1.Bounds))
            {
                A_Journey_Home.Variables.herohealth -= 1;
                if (A_Journey_Home.Variables.SoundOn)
                    hero_hit.Play();
            }

            if (A_Journey_Home.Variables.herohealth ==0)
            {
                enemybullet1.Top = 500;
            }
            // sets health label to the hero health after each execution
            healthcounter.Text = A_Journey_Home.Variables.herohealth.ToString();
        }
     
        private void detectenemyhit()
            // this function detects if the hero's laser has hit any of the enemy ships and will send the enemy ship to a specific location
        {
            if (laser.Bounds.IntersectsWith(enemyship1.Bounds))
            {
                enemyship1.Top = 660;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
                if (A_Journey_Home.Variables.SoundOn)
                    enemy_hit.Play();
            }
            else if (laser.Bounds.IntersectsWith(enemyship2.Bounds))
            {
                enemyship2.Top = 660;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
                if (A_Journey_Home.Variables.SoundOn)
                    enemy_hit.Play();
            }
            else if (laser.Bounds.IntersectsWith(enemyship3.Bounds))
            {
                enemyship3.Top = 660;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
                if (A_Journey_Home.Variables.SoundOn)
                    enemy_hit.Play();
            }
            else if (laser.Bounds.IntersectsWith(enemyship4.Bounds))
            {
                enemyship4.Top = 660;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
                if (A_Journey_Home.Variables.SoundOn)
                    enemy_hit.Play();
            }
            else if (laser.Bounds.IntersectsWith(enemyship5.Bounds))
            {
                enemyship5.Top = 660;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
                if (A_Journey_Home.Variables.SoundOn)
                    enemy_hit.Play();
            }
            else if (laser.Bounds.IntersectsWith(enemyship6.Bounds))
            {
                if (Level == 3)
                {
                    enemyship6.Top = 560;
                    resetlaser();
                    bulletTimer1.Stop();
                    shoot = false;
                    if (A_Journey_Home.Variables.SoundOn)
                        enemy_hit.Play();
                }
                else
                {
                    enemyship6.Top = 660;
                    resetlaser();
                    bulletTimer1.Stop();
                    shoot = false;
                    if (A_Journey_Home.Variables.SoundOn)
                        enemy_hit.Play();
                }
            }
        }
   

        private void randint_Tick(object sender, EventArgs e)
        {
            // this timer creates a new random integer every tick to make the enemy ship's shots random
            if (Level == 1)
                fire = rnd.Next(1, 5);
            else
                fire = rnd.Next(1, 7);
        }
        private void enemyfire()
        {
            // this checks the random int and it will fire each ship that the number is set to
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
        // the following check enemy fire functions check if the enemy can fire then it will fire if condition is met
        // if the enemy laser has reached the end of the form or hit the hero then it will be able to fire again
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
                enem5laser.Start();
            else
                enem5laser.Stop();
        }
        private void checkenemfire6()
        {
            if (enemfire6)
                enem6laser.Start();
            else
                enem6laser.Stop();
        }
        // the following few timers are for the enemy bullets to fire a random times and intervals
        private void enem1laser_Tick(object sender, EventArgs e)
        {
            if (enemybullet1.Top > 521)
            {
                enemybullet1.Top = enemyship1.Top +20;
                enemybullet1.Left = enemyship1.Left+35;
                enemfire1 = false;
            }
            else if (enemfire1)
                // moves the bullet 10 pixels for every ticks
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
                levelscore = 0;

            if (Level == 1 && A_Journey_Home.Variables.herohealth != 0)
            {
                levelscore = 200 + (100 / (numshots - 3));
                numshots = 0;
            }
            if (Level == 2 && A_Journey_Home.Variables.herohealth != 0)
            {
                levelscore = 300 + (100 / (numshots - 5));
                numshots = 0;
            }
            if (Level == 3 && A_Journey_Home.Variables.herohealth != 0)
            {
                levelscore = 450 + (100 / (numshots - 14));
                numshots = 0;
            }
        }
        private void GameOver()
        {
            // this takes the activecontrol away from the hero ship
            this.ActiveControl = null;
            heroship1.Visible = false;
            laser.Visible = false;
            // allows the score and scorecounter as wel as the game over label to be displayed
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
            A_Journey_Home.Variables.aggregatescore += levelscore;
            scorecounter.Text = A_Journey_Home.Variables.aggregatescore.ToString();
            // stops all the timers in the game
            PlayTimer.Stop();
            bosstimer.Stop();
            enemyshiptimer.Stop();

            // puts the game over label for the final level completion
            if (A_Journey_Home.Variables.herohealth > 0 && Level==3)
            {
                gameoverlabel.Text = "Congratulations!\n Welcome Back to Earth!";
                button1.Visible = true;
            }
            // if the hero dies then this is displayed
            else if (A_Journey_Home.Variables.herohealth == 0)
            {   
                gameoverlabel.Text="Game Over";
              
                enemyship1.Visible = false;
                enemyship2.Visible = false;
                enemyship3.Visible = false;
                enemyship4.Visible = false;
                enemyship5.Visible = false;
                enemyship6.Visible = false;
                button1.Visible = true;
            }
            // if the hero completes a level and the level is not theh final one, it will display this
            else if (A_Journey_Home.Variables.herohealth > 0)
            {
                gameoverlabel.Text = "Good Job!";
                Level++;
                MainButton.Text = "Next Level";
                levelcounter.Text = Level.ToString();
                MainButton.Visible = true;
            }
            // the play timer and the random int timer are stopped for memory saving
            PlayTimer.Stop();
            randint.Stop();
        }
        private void restart()
        {
            levelcounter.Text = Level.ToString();

            if (Level >= 1)
            {
                //this sets the ships at level 1 and above to be at their default positions
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
            }
            if (Level>1)
            {
                // after level one, two more ships appear at their default positions
                enemyship5.Location = new Point(459, 100);  
                enemyship6.Location = new Point(597, 100);
                enemybullet5.Location = enemyship5.Location;
                enemybullet6.Location = enemyship6.Location;

                enemyship5.Visible = true;
                enemyship6.Visible = true;
                enemybullet5.Visible = true;
                enemybullet6.Visible = true;
                // this background image for level 2 is set in this conditon
                if (Level == 2)
                {
                    Image myimage = new Bitmap(@"bg2.png");
                    this.BackgroundImage = myimage;
                }
                // this background image for level 3 is set in this conditon
                
                if (Level == 3)
                {
                    Image myimage = new Bitmap(@"bg3.png");
                    this.BackgroundImage = myimage;
                }
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
    

        private void checkbossappear()
        {
            // if all of the normal ships on level 3 are killed the bosses will appear at their default y position
            if (Level == 3 && enemyship1.Top == 660 && enemyship2.Top == 660 && enemyship3.Top == 660 && enemyship4.Top == 660 && enemyship5.Top == 660 && enemyship6.Top == 560 )
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
            // this is the same funciton as the one for the other small ships but for the boss ships
            int width = this.Width;
            if (boss1.Location.X > width - boss1.Width)
                boss1.Location = new Point(1, boss1.Location.Y);      
            else
                boss1.Location = new Point(boss1.Location.X + 10, boss1.Location.Y);
          
            if (boss2.Location.X > width - boss2.Width)
                boss2.Location = new Point(1, boss2.Location.Y);
            else
                boss2.Location = new Point(boss2.Location.X + 10, boss2.Location.Y);

            if (boss3.Location.X > width - boss3.Width)
                boss3.Location = new Point(1, boss3.Location.Y);
            else
                boss3.Location = new Point(boss3.Location.X + 10, boss3.Location.Y);
            // these functions are exected every time the timer ticks
            checkboss1fire();
            checkboss2fire();
            checkboss3fire();
            checkbosshit();
            checkbosslife();
        }
        private void checkbosslife()
        {
            // checks if the bosses have 0 lives then sends them to a specified position
            if (boss1health == 0)
                boss1.Top = 560;
            
            if (boss2health == 0)
                boss2.Top = 560;
            
            if (boss3health == 0)
                boss3.Top = 561;
        }
     
        private void checkbosshit()
        {
            // checks if the hero's laser has intersected with the bounds of the bosses
            if (laser.Bounds.IntersectsWith(boss1.Bounds))
            {
                // the health of the boss decreased by 1 where it is initiated to 3 per boss
                boss1health -= 1;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
                // if a boss is hit the hit sounds will play
                if (A_Journey_Home.Variables.SoundOn)
                    enemy_hit.Play();
            }
            else if (laser.Bounds.IntersectsWith(boss2.Bounds))
            {
                boss2health -= 1;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
                if (A_Journey_Home.Variables.SoundOn)
                    enemy_hit.Play();
            }
            else if (laser.Bounds.IntersectsWith(boss3.Bounds))
            {
                boss3health -= 1;
                resetlaser();
                bulletTimer1.Stop();
                shoot = false;
                if (A_Journey_Home.Variables.SoundOn)
                    enemy_hit.Play();
            }
        }
        private void checkboss1fire()
        {
            // this will check if the boss can shoot and will reset the laser if the hero is hit or the bullets reach the end of the form
            int formheight = this.Height;
            if (boss1bullet1.Location.Y>formheight)
            {
                boss1bullet1.Top = boss1.Top + 20;
                boss1bullet1.Left = boss1.Left + 35;
            }
            else
            boss1bullet1.Top += 10;

            if (boss1bullet2.Location.Y > formheight)
            {
                boss1bullet2.Top = boss1.Top + 20;
                boss1bullet2.Left = boss1.Left + 55;
            }
            else
                boss1bullet2.Top += 10;

            if (boss1bullet3.Location.Y > formheight)
            {
                boss1bullet3.Top = boss1.Top + 20;
                boss1bullet3.Left = boss1.Left + 75;
            }
            else
                boss1bullet3.Top += 10;
        }
        private void checkboss2fire()
        // this will check if the boss can shoot and will reset the laser if the hero is hit or the bullets reach the end of the form
        {
            int formheight = this.Height;
            if (boss2bullet1.Location.Y > formheight)
            {
                boss2bullet1.Top = boss2.Top + 20;
                boss2bullet1.Left = boss2.Left + 35;
            }
            else
                boss2bullet1.Top += 10;

            if (boss2bullet2.Location.Y > formheight)
            {
                boss2bullet2.Top = boss2.Top + 20;
                boss2bullet2.Left = boss2.Left + 55;
            }
            else
                boss2bullet2.Top += 10;

            if (boss2bullet3.Location.Y > formheight)
            {
                boss2bullet3.Top = boss2.Top + 20;
                boss2bullet3.Left = boss2.Left + 75;
            }
            else
                boss2bullet3.Top += 10;
        }
        private void checkboss3fire()
        // this will check if the boss can shoot and will reset the laser if the hero is hit or the bullets reach the end of the form

        {
            int formheight = this.Height;
            if (boss3bullet1.Location.Y > formheight)
            {
                boss3bullet1.Top = boss3.Top + 20;
                boss3bullet1.Left = boss3.Left + 35;
            }
            else
                boss3bullet1.Top += 10;

            if (boss3bullet2.Location.Y > formheight)
            {
                boss3bullet2.Top = boss3.Top + 20;
                boss3bullet2.Left = boss3.Left + 55;
            }
            else
                boss3bullet2.Top += 10;

            if (boss3bullet3.Location.Y > formheight)
            {
                boss3bullet3.Top = boss3.Top + 20;
                boss3bullet3.Left = boss3.Left + 75;
            }
            else
                boss3bullet3.Top += 10;
        }

        // RETURN BUTTON -> closes current Form and makes Menu visible again. 
        public Form FormToShowOnClosing { get; set; }
        public Form1 ReferenceToFirstForm;
        private void button1_Click(object sender, EventArgs e)
        {
            if (null != FormToShowOnClosing)
            {
                FormToShowOnClosing.Show();
                A_Journey_Home.Variables.GameFinished = true;
                ReferenceToFirstForm.button_leaderboard_Click(sender, e);
                this.Close();
            }
        }

      
    }
}