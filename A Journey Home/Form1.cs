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
using WMPLib;
using WindowsFormsApp1;

namespace A_Journey_Home
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer bg_music = new WindowsMediaPlayer();
        // Default Arrays to store data from text file in
        string[] name = new string[] { "Sergio", "Alex", "Loay", "Yoshi", "Bastian", "Empty"};
        int[] points = new int[] { 348, 917, 127, 468, 378, 000 };

        public Form1()
        {
            InitializeComponent();
            bg_music.URL = "bg_music.wav";
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            bg_music.controls.play();
        }

        // Button to start the game (hides Form 1 - creates new Form 2)
        private void button_start_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 frm2 = new Form2();
            frm2.FormToShowOnClosing = this;
            frm2.ReferenceToFirstForm = this;
            frm2.Show();
        }


        // Button to operate the Leaderboard + Leaderboard Methods
        public void button_leaderboard_Click(object sender, EventArgs e)
        {
            button_start.Visible = false;
            button_leaderboard.Visible = false;
            button_sound.Visible = false;
            button_exit.Visible = false;
            button_return.Visible = true;

            // Get Data + Display (Sort in between to make sure the ranking is in order)
            if (!Variables.DataInArray)
                Leaderboard_GetData();
            if (Variables.GameFinished)
            {
                points[5] = Variables.aggregatescore;
                Variables.GameFinished = false;
                Leaderboard_NewScore();
            }
            else
            {
                ld_title.Visible = true;
                Leaderboard_Sort();
                Leaderboard_Display();
                Leaderboard_Update();
            }

            // Check whether the Leaderboard File exits, if not create one and fill it with basic values from array
            void Leaderboard_GetData()
            {
                if (!File.Exists("Leaderboard.txt"))
                {
                    TextWriter twr = new StreamWriter("Leaderboard.txt");
                    for (int x = 0; x < 6; x++)
                    {
                        twr.Write(name[x] + ',' + points[x].ToString() + ',');
                    }
                    twr.Close();
                }
                else
                {
                    // For loop to store data from text file in arrays
                    int i = 0; // seperate counter for 'parts' array
                    for (int x = 0; x < 6; x++)
                    {
                        foreach (string line in File.ReadAllLines("Leaderboard.txt"))
                        {
                            string[] parts = line.Split(',');
                            name[x] = parts[i];
                            points[x] = Int32.Parse(parts[i + 1]);
                            i = i + 2; ;
                        };
                    }
                    Variables.DataInArray = true;
                }
            }//End Leaderboard_GetData()

            // Function to put updated Leaderboard values back into Textfile
            void Leaderboard_Update()
            {
                string line = "";
                for (int l = 0; l < 6; l++)
                {
                    line += name[l] + ',' + points[l] + ',';
                }
                File.WriteAllText("Leaderboard.txt", line);

            }; // End Leaderboard_Update()

            // Function to sort the leaderboard for new entries (with bubblesort)
            void Leaderboard_Sort()
            {
                int temp_int = 0;
                string temp_string = "";

                for (int p = 0; p < 6; p++)
                {
                    for (int q = 0; q < 5; q++)
                    {
                        if (points[q] < points[q + 1])
                        {
                            temp_int = points[q + 1];
                            temp_string = name[q + 1];
                            points[q + 1] = points[q];
                            name[q + 1] = name[q];
                            points[q] = temp_int;
                            name[q] = temp_string;
                        }
                    }
                }
            }; // End Leaderboard_Sort()

            // Function to display Leaderboard
            void Leaderboard_Display()
            {
                textbox_scores.Visible = true;
                for (int x = 0; x < 5; x++)
                {
                    textbox_scores.Text += name[x] + '\t' + points[x].ToString() + "\r\n";
                }
            }; // End Leaderboard_Display()

            // Function to add a new score and checkl whether it is within the top 5
            void Leaderboard_NewScore()
            {
                if (points[5] > points[4])
                {
                    highscore_msg.Visible = true;
                    highscore_input.Focus();
                    highscore_input.Visible = true;
                    button_lb_accept.Visible = true;
                }
                else
                {
                    button_lb_accept_Click(sender, e);
                }
            }; // End Leaderboard_NewScore
        }


        // Button to turn music on and off
        private void button_sound_Click(object sender, EventArgs e)
        {
            if (button_sound.Text == "SOUND: OFF")
            {
                button_sound.Text = "SOUND: ON";
                Variables.SoundOn = true;
                bg_music.controls.play();
            }
            else
            {
                button_sound.Text = "SOUND: OFF";
                Variables.SoundOn = false;
                bg_music.controls.stop();
            }

        }

        // Button to Exit Game
        private void button_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Button to return to the menu
        private void button_return_Click(object sender, EventArgs e)
        {
            button_start.Visible = true;
            ld_title.Visible = false;
            button_leaderboard.Visible = true;
            button_lb_accept.Visible = false;
            textbox_scores.Clear();
            textbox_scores.Visible = false;
            button_sound.Visible = true;
            button_exit.Visible = true;
            button_return.Visible = false;
        }

        // Function that takes the Playername if a new highscore got reached
        void highscore_input_TextChanged(object sender2, EventArgs e2)
        {
            // Empty
        }

        // Button to Accept player's name and load leaderboard afterwards
        private void button_lb_accept_Click(object sender, EventArgs e)
        {
            name[5] = highscore_input.Text;
            highscore_input.Clear();
            button_lb_accept.Visible = false;
            highscore_msg.Visible = false;
            highscore_input.Visible = false;
            button_leaderboard_Click(sender, e);
        }
    }
}
