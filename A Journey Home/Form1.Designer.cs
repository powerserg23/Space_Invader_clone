namespace A_Journey_Home
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_start = new System.Windows.Forms.Button();
            this.button_leaderboard = new System.Windows.Forms.Button();
            this.button_sound = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.textbox_scores = new System.Windows.Forms.TextBox();
            this.highscore_input = new System.Windows.Forms.TextBox();
            this.button_lb_accept = new System.Windows.Forms.Button();
            this.highscore_msg = new System.Windows.Forms.Label();
            this.menu_title = new System.Windows.Forms.Label();
            this.ld_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Calibri", 10F);
            this.button_start.Location = new System.Drawing.Point(500, 237);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(240, 40);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "START GAME";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_leaderboard
            // 
            this.button_leaderboard.Font = new System.Drawing.Font("Calibri", 10F);
            this.button_leaderboard.Location = new System.Drawing.Point(500, 283);
            this.button_leaderboard.Name = "button_leaderboard";
            this.button_leaderboard.Size = new System.Drawing.Size(240, 40);
            this.button_leaderboard.TabIndex = 1;
            this.button_leaderboard.Text = "LEADERBOARD";
            this.button_leaderboard.UseVisualStyleBackColor = true;
            this.button_leaderboard.Click += new System.EventHandler(this.button_leaderboard_Click);
            // 
            // button_sound
            // 
            this.button_sound.Font = new System.Drawing.Font("Calibri", 10F);
            this.button_sound.Location = new System.Drawing.Point(500, 329);
            this.button_sound.Name = "button_sound";
            this.button_sound.Size = new System.Drawing.Size(240, 40);
            this.button_sound.TabIndex = 2;
            this.button_sound.Text = "SOUND: ON";
            this.button_sound.UseVisualStyleBackColor = true;
            this.button_sound.Click += new System.EventHandler(this.button_sound_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Calibri", 10F);
            this.button_exit.Location = new System.Drawing.Point(500, 375);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(240, 40);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "EXIT GAME";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(500, 375);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(240, 40);
            this.button_return.TabIndex = 4;
            this.button_return.Text = "BACK TO MENU";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // textbox_scores
            // 
            this.textbox_scores.BackColor = System.Drawing.Color.Black;
            this.textbox_scores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_scores.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_scores.ForeColor = System.Drawing.Color.White;
            this.textbox_scores.Location = new System.Drawing.Point(12, 186);
            this.textbox_scores.Multiline = true;
            this.textbox_scores.Name = "textbox_scores";
            this.textbox_scores.ReadOnly = true;
            this.textbox_scores.Size = new System.Drawing.Size(525, 250);
            this.textbox_scores.TabIndex = 6;
            this.textbox_scores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_scores.Visible = false;
            // 
            // highscore_input
            // 
            this.highscore_input.BackColor = System.Drawing.Color.Black;
            this.highscore_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highscore_input.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore_input.ForeColor = System.Drawing.Color.White;
            this.highscore_input.Location = new System.Drawing.Point(95, 298);
            this.highscore_input.MaxLength = 9;
            this.highscore_input.Name = "highscore_input";
            this.highscore_input.Size = new System.Drawing.Size(341, 47);
            this.highscore_input.TabIndex = 8;
            this.highscore_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.highscore_input.Visible = false;
            this.highscore_input.TextChanged += new System.EventHandler(this.highscore_input_TextChanged);
            // 
            // button_lb_accept
            // 
            this.button_lb_accept.Location = new System.Drawing.Point(500, 375);
            this.button_lb_accept.Name = "button_lb_accept";
            this.button_lb_accept.Size = new System.Drawing.Size(240, 40);
            this.button_lb_accept.TabIndex = 10;
            this.button_lb_accept.Text = "ACCEPT";
            this.button_lb_accept.UseVisualStyleBackColor = true;
            this.button_lb_accept.Visible = false;
            this.button_lb_accept.Click += new System.EventHandler(this.button_lb_accept_Click);
            // 
            // highscore_msg
            // 
            this.highscore_msg.BackColor = System.Drawing.Color.Transparent;
            this.highscore_msg.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore_msg.ForeColor = System.Drawing.Color.White;
            this.highscore_msg.Location = new System.Drawing.Point(171, 154);
            this.highscore_msg.Name = "highscore_msg";
            this.highscore_msg.Size = new System.Drawing.Size(200, 100);
            this.highscore_msg.TabIndex = 11;
            this.highscore_msg.Text = "Congratulations! New Highscore Enter your name:";
            this.highscore_msg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.highscore_msg.Visible = false;
            // 
            // menu_title
            // 
            this.menu_title.AutoSize = true;
            this.menu_title.BackColor = System.Drawing.Color.Transparent;
            this.menu_title.Font = new System.Drawing.Font("Calibri", 62F);
            this.menu_title.ForeColor = System.Drawing.Color.White;
            this.menu_title.Location = new System.Drawing.Point(78, 26);
            this.menu_title.Name = "menu_title";
            this.menu_title.Size = new System.Drawing.Size(662, 101);
            this.menu_title.TabIndex = 12;
            this.menu_title.Text = "A JOURNEY HOME";
            // 
            // ld_title
            // 
            this.ld_title.AutoSize = true;
            this.ld_title.BackColor = System.Drawing.Color.Transparent;
            this.ld_title.Font = new System.Drawing.Font("Calibri", 40F);
            this.ld_title.ForeColor = System.Drawing.Color.White;
            this.ld_title.Location = new System.Drawing.Point(86, 127);
            this.ld_title.Name = "ld_title";
            this.ld_title.Size = new System.Drawing.Size(352, 66);
            this.ld_title.TabIndex = 13;
            this.ld_title.Text = "LEADERBOARD";
            this.ld_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ld_title.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(401, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sergio Dejo, Bastian Diskau, Yoshihiko Hirai and Alexandria Risley";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu_title);
            this.Controls.Add(this.highscore_msg);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_lb_accept);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.highscore_input);
            this.Controls.Add(this.button_sound);
            this.Controls.Add(this.button_leaderboard);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.ld_title);
            this.Controls.Add(this.textbox_scores);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "A JOURNEY HOME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_leaderboard;
        private System.Windows.Forms.Button button_sound;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.TextBox textbox_scores;
        private System.Windows.Forms.TextBox highscore_input;
        private System.Windows.Forms.Button button_lb_accept;
        private System.Windows.Forms.Label highscore_msg;
        private System.Windows.Forms.Label menu_title;
        private System.Windows.Forms.Label ld_title;
        private System.Windows.Forms.Label label1;
    }
}

