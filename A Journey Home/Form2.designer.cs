namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.MainButton = new System.Windows.Forms.Button();
            this.enemyshiptimer = new System.Windows.Forms.Timer(this.components);
            this.heroship1 = new System.Windows.Forms.PictureBox();
            this.enemyship1 = new System.Windows.Forms.PictureBox();
            this.enemyship2 = new System.Windows.Forms.PictureBox();
            this.enemyship3 = new System.Windows.Forms.PictureBox();
            this.enemyship4 = new System.Windows.Forms.PictureBox();
            this.laser = new System.Windows.Forms.PictureBox();
            this.bulletTimer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayTimer = new System.Windows.Forms.Timer(this.components);
            this.gameoverlabel = new System.Windows.Forms.Label();
            this.enemybullet1 = new System.Windows.Forms.PictureBox();
            this.randint = new System.Windows.Forms.Timer(this.components);
            this.enem1laser = new System.Windows.Forms.Timer(this.components);
            this.enemybullet2 = new System.Windows.Forms.PictureBox();
            this.enemybullet3 = new System.Windows.Forms.PictureBox();
            this.enemybullet4 = new System.Windows.Forms.PictureBox();
            this.enem2laser = new System.Windows.Forms.Timer(this.components);
            this.enem3laser = new System.Windows.Forms.Timer(this.components);
            this.enem4laser = new System.Windows.Forms.Timer(this.components);
            this.healthcounter = new System.Windows.Forms.TextBox();
            this.enemyship5 = new System.Windows.Forms.PictureBox();
            this.enemybullet5 = new System.Windows.Forms.PictureBox();
            this.enemyship6 = new System.Windows.Forms.PictureBox();
            this.enemybullet6 = new System.Windows.Forms.PictureBox();
            this.enem5laser = new System.Windows.Forms.Timer(this.components);
            this.enem6laser = new System.Windows.Forms.Timer(this.components);
            this.levelcounterlabel = new System.Windows.Forms.Label();
            this.levelcounter = new System.Windows.Forms.TextBox();
            this.scorecounter = new System.Windows.Forms.TextBox();
            this.scorelabel = new System.Windows.Forms.Label();
            this.boss1 = new System.Windows.Forms.PictureBox();
            this.boss2 = new System.Windows.Forms.PictureBox();
            this.boss3 = new System.Windows.Forms.PictureBox();
            this.boss1bullet1 = new System.Windows.Forms.PictureBox();
            this.boss1bullet2 = new System.Windows.Forms.PictureBox();
            this.boss1bullet3 = new System.Windows.Forms.PictureBox();
            this.boss2bullet1 = new System.Windows.Forms.PictureBox();
            this.boss2bullet3 = new System.Windows.Forms.PictureBox();
            this.boss2bullet2 = new System.Windows.Forms.PictureBox();
            this.boss3bullet1 = new System.Windows.Forms.PictureBox();
            this.boss3bullet2 = new System.Windows.Forms.PictureBox();
            this.boss3bullet3 = new System.Windows.Forms.PictureBox();
            this.bosstimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heroship1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyship1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyship2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyship3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyship4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemybullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemybullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemybullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemybullet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyship5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemybullet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyship6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemybullet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss1bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss1bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss1bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss2bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss2bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss2bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss3bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss3bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss3bullet3)).BeginInit();
            this.SuspendLayout();
            // 
            // MainButton
            // 
            this.MainButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainButton.Location = new System.Drawing.Point(693, 373);
            this.MainButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(107, 74);
            this.MainButton.TabIndex = 2;
            this.MainButton.Text = "START";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // enemyshiptimer
            // 
            this.enemyshiptimer.Tick += new System.EventHandler(this.enemyshipTimer_Tick);
            // 
            // heroship1
            // 
            this.heroship1.BackColor = System.Drawing.Color.Transparent;
            this.heroship1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heroship1.Image = ((System.Drawing.Image)(resources.GetObject("heroship1.Image")));
            this.heroship1.Location = new System.Drawing.Point(371, 319);
            this.heroship1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heroship1.Name = "heroship1";
            this.heroship1.Size = new System.Drawing.Size(79, 98);
            this.heroship1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heroship1.TabIndex = 0;
            this.heroship1.TabStop = false;
            this.heroship1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.heroship1_PreviewKeyDown_1);
            // 
            // enemyship1
            // 
            this.enemyship1.BackColor = System.Drawing.Color.Transparent;
            this.enemyship1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyship1.Image = ((System.Drawing.Image)(resources.GetObject("enemyship1.Image")));
            this.enemyship1.Location = new System.Drawing.Point(21, 14);
            this.enemyship1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyship1.Name = "enemyship1";
            this.enemyship1.Size = new System.Drawing.Size(69, 50);
            this.enemyship1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyship1.TabIndex = 1;
            this.enemyship1.TabStop = false;
            this.enemyship1.Visible = false;
            // 
            // enemyship2
            // 
            this.enemyship2.BackColor = System.Drawing.Color.Transparent;
            this.enemyship2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyship2.Image = ((System.Drawing.Image)(resources.GetObject("enemyship2.Image")));
            this.enemyship2.Location = new System.Drawing.Point(132, 12);
            this.enemyship2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyship2.Name = "enemyship2";
            this.enemyship2.Size = new System.Drawing.Size(69, 50);
            this.enemyship2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyship2.TabIndex = 3;
            this.enemyship2.TabStop = false;
            this.enemyship2.Visible = false;
            // 
            // enemyship3
            // 
            this.enemyship3.BackColor = System.Drawing.Color.Transparent;
            this.enemyship3.Image = ((System.Drawing.Image)(resources.GetObject("enemyship3.Image")));
            this.enemyship3.Location = new System.Drawing.Point(257, 12);
            this.enemyship3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyship3.Name = "enemyship3";
            this.enemyship3.Size = new System.Drawing.Size(69, 50);
            this.enemyship3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyship3.TabIndex = 4;
            this.enemyship3.TabStop = false;
            this.enemyship3.Visible = false;
            // 
            // enemyship4
            // 
            this.enemyship4.BackColor = System.Drawing.Color.Transparent;
            this.enemyship4.Image = ((System.Drawing.Image)(resources.GetObject("enemyship4.Image")));
            this.enemyship4.Location = new System.Drawing.Point(380, 12);
            this.enemyship4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyship4.Name = "enemyship4";
            this.enemyship4.Size = new System.Drawing.Size(69, 50);
            this.enemyship4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyship4.TabIndex = 5;
            this.enemyship4.TabStop = false;
            this.enemyship4.Visible = false;
            // 
            // laser
            // 
            this.laser.BackColor = System.Drawing.Color.Transparent;
            this.laser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.laser.Image = ((System.Drawing.Image)(resources.GetObject("laser.Image")));
            this.laser.Location = new System.Drawing.Point(420, 405);
            this.laser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(11, 10);
            this.laser.TabIndex = 6;
            this.laser.TabStop = false;
            // 
            // bulletTimer1
            // 
            this.bulletTimer1.Interval = 1;
            this.bulletTimer1.Tick += new System.EventHandler(this.bulletTimer1_Tick);
            // 
            // PlayTimer
            // 
            this.PlayTimer.Interval = 10;
            this.PlayTimer.Tick += new System.EventHandler(this.PlayTimer_tick);
            // 
            // gameoverlabel
            // 
            this.gameoverlabel.BackColor = System.Drawing.Color.Transparent;
            this.gameoverlabel.Font = new System.Drawing.Font("Calibri", 32F);
            this.gameoverlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameoverlabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gameoverlabel.Location = new System.Drawing.Point(96, 33);
            this.gameoverlabel.Name = "gameoverlabel";
            this.gameoverlabel.Size = new System.Drawing.Size(644, 170);
            this.gameoverlabel.TabIndex = 7;
            this.gameoverlabel.Text = "Game Over";
            this.gameoverlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gameoverlabel.Visible = false;
            // 
            // enemybullet1
            // 
            this.enemybullet1.BackColor = System.Drawing.Color.Transparent;
            this.enemybullet1.Image = ((System.Drawing.Image)(resources.GetObject("enemybullet1.Image")));
            this.enemybullet1.Location = new System.Drawing.Point(52, 33);
            this.enemybullet1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemybullet1.Name = "enemybullet1";
            this.enemybullet1.Size = new System.Drawing.Size(11, 16);
            this.enemybullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemybullet1.TabIndex = 8;
            this.enemybullet1.TabStop = false;
            this.enemybullet1.Visible = false;
            // 
            // randint
            // 
            this.randint.Interval = 200;
            this.randint.Tick += new System.EventHandler(this.randint_Tick);
            // 
            // enem1laser
            // 
            this.enem1laser.Tick += new System.EventHandler(this.enem1laser_Tick);
            // 
            // enemybullet2
            // 
            this.enemybullet2.BackColor = System.Drawing.Color.Transparent;
            this.enemybullet2.Image = ((System.Drawing.Image)(resources.GetObject("enemybullet2.Image")));
            this.enemybullet2.Location = new System.Drawing.Point(163, 33);
            this.enemybullet2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemybullet2.Name = "enemybullet2";
            this.enemybullet2.Size = new System.Drawing.Size(11, 16);
            this.enemybullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemybullet2.TabIndex = 10;
            this.enemybullet2.TabStop = false;
            this.enemybullet2.Visible = false;
            // 
            // enemybullet3
            // 
            this.enemybullet3.BackColor = System.Drawing.Color.Transparent;
            this.enemybullet3.Image = ((System.Drawing.Image)(resources.GetObject("enemybullet3.Image")));
            this.enemybullet3.Location = new System.Drawing.Point(292, 33);
            this.enemybullet3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemybullet3.Name = "enemybullet3";
            this.enemybullet3.Size = new System.Drawing.Size(11, 16);
            this.enemybullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemybullet3.TabIndex = 11;
            this.enemybullet3.TabStop = false;
            this.enemybullet3.Visible = false;
            // 
            // enemybullet4
            // 
            this.enemybullet4.BackColor = System.Drawing.Color.Transparent;
            this.enemybullet4.Image = ((System.Drawing.Image)(resources.GetObject("enemybullet4.Image")));
            this.enemybullet4.Location = new System.Drawing.Point(412, 33);
            this.enemybullet4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemybullet4.Name = "enemybullet4";
            this.enemybullet4.Size = new System.Drawing.Size(11, 16);
            this.enemybullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemybullet4.TabIndex = 12;
            this.enemybullet4.TabStop = false;
            this.enemybullet4.Visible = false;
            // 
            // enem2laser
            // 
            this.enem2laser.Tick += new System.EventHandler(this.enem2laser_Tick);
            // 
            // enem3laser
            // 
            this.enem3laser.Tick += new System.EventHandler(this.enem3laser_Tick);
            // 
            // enem4laser
            // 
            this.enem4laser.Tick += new System.EventHandler(this.enem4laser_Tick);
            // 
            // healthcounter
            // 
            this.healthcounter.BackColor = System.Drawing.Color.Black;
            this.healthcounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.healthcounter.Font = new System.Drawing.Font("Calibri", 18.8F);
            this.healthcounter.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.healthcounter.Location = new System.Drawing.Point(297, 426);
            this.healthcounter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.healthcounter.Name = "healthcounter";
            this.healthcounter.ReadOnly = true;
            this.healthcounter.Size = new System.Drawing.Size(40, 39);
            this.healthcounter.TabIndex = 14;
            // 
            // enemyship5
            // 
            this.enemyship5.BackColor = System.Drawing.Color.Transparent;
            this.enemyship5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyship5.Image = ((System.Drawing.Image)(resources.GetObject("enemyship5.Image")));
            this.enemyship5.Location = new System.Drawing.Point(465, 100);
            this.enemyship5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyship5.Name = "enemyship5";
            this.enemyship5.Size = new System.Drawing.Size(69, 50);
            this.enemyship5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyship5.TabIndex = 15;
            this.enemyship5.TabStop = false;
            // 
            // enemybullet5
            // 
            this.enemybullet5.BackColor = System.Drawing.Color.Transparent;
            this.enemybullet5.Image = ((System.Drawing.Image)(resources.GetObject("enemybullet5.Image")));
            this.enemybullet5.Location = new System.Drawing.Point(491, 124);
            this.enemybullet5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemybullet5.Name = "enemybullet5";
            this.enemybullet5.Size = new System.Drawing.Size(11, 16);
            this.enemybullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemybullet5.TabIndex = 16;
            this.enemybullet5.TabStop = false;
            // 
            // enemyship6
            // 
            this.enemyship6.BackColor = System.Drawing.Color.Transparent;
            this.enemyship6.Image = ((System.Drawing.Image)(resources.GetObject("enemyship6.Image")));
            this.enemyship6.Location = new System.Drawing.Point(597, 100);
            this.enemyship6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyship6.Name = "enemyship6";
            this.enemyship6.Size = new System.Drawing.Size(69, 50);
            this.enemyship6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyship6.TabIndex = 17;
            this.enemyship6.TabStop = false;
            // 
            // enemybullet6
            // 
            this.enemybullet6.BackColor = System.Drawing.Color.Transparent;
            this.enemybullet6.Image = ((System.Drawing.Image)(resources.GetObject("enemybullet6.Image")));
            this.enemybullet6.Location = new System.Drawing.Point(623, 124);
            this.enemybullet6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemybullet6.Name = "enemybullet6";
            this.enemybullet6.Size = new System.Drawing.Size(11, 16);
            this.enemybullet6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemybullet6.TabIndex = 18;
            this.enemybullet6.TabStop = false;
            // 
            // enem5laser
            // 
            this.enem5laser.Tick += new System.EventHandler(this.enem5laser_Tick);
            // 
            // enem6laser
            // 
            this.enem6laser.Tick += new System.EventHandler(this.enem6laser_Tick);
            // 
            // levelcounterlabel
            // 
            this.levelcounterlabel.BackColor = System.Drawing.Color.Transparent;
            this.levelcounterlabel.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelcounterlabel.ForeColor = System.Drawing.Color.Transparent;
            this.levelcounterlabel.Location = new System.Drawing.Point(15, 426);
            this.levelcounterlabel.Name = "levelcounterlabel";
            this.levelcounterlabel.Size = new System.Drawing.Size(100, 37);
            this.levelcounterlabel.TabIndex = 19;
            this.levelcounterlabel.Text = "Level:";
            // 
            // levelcounter
            // 
            this.levelcounter.BackColor = System.Drawing.Color.Black;
            this.levelcounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.levelcounter.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelcounter.ForeColor = System.Drawing.Color.White;
            this.levelcounter.Location = new System.Drawing.Point(120, 426);
            this.levelcounter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.levelcounter.Name = "levelcounter";
            this.levelcounter.ReadOnly = true;
            this.levelcounter.Size = new System.Drawing.Size(40, 39);
            this.levelcounter.TabIndex = 20;
            // 
            // scorecounter
            // 
            this.scorecounter.BackColor = System.Drawing.Color.Black;
            this.scorecounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scorecounter.Font = new System.Drawing.Font("Calibri", 18.8F);
            this.scorecounter.ForeColor = System.Drawing.Color.White;
            this.scorecounter.Location = new System.Drawing.Point(528, 426);
            this.scorecounter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scorecounter.Name = "scorecounter";
            this.scorecounter.ReadOnly = true;
            this.scorecounter.Size = new System.Drawing.Size(113, 39);
            this.scorecounter.TabIndex = 21;
            this.scorecounter.Visible = false;
            // 
            // scorelabel
            // 
            this.scorelabel.BackColor = System.Drawing.Color.Transparent;
            this.scorelabel.Font = new System.Drawing.Font("Calibri", 18.8F);
            this.scorelabel.Location = new System.Drawing.Point(404, 426);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(113, 37);
            this.scorelabel.TabIndex = 22;
            this.scorelabel.Text = "Score:";
            this.scorelabel.Visible = false;
            // 
            // boss1
            // 
            this.boss1.BackColor = System.Drawing.Color.Transparent;
            this.boss1.Image = ((System.Drawing.Image)(resources.GetObject("boss1.Image")));
            this.boss1.Location = new System.Drawing.Point(101, 68);
            this.boss1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boss1.Name = "boss1";
            this.boss1.Size = new System.Drawing.Size(100, 60);
            this.boss1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss1.TabIndex = 24;
            this.boss1.TabStop = false;
            // 
            // boss2
            // 
            this.boss2.BackColor = System.Drawing.Color.Transparent;
            this.boss2.Image = ((System.Drawing.Image)(resources.GetObject("boss2.Image")));
            this.boss2.Location = new System.Drawing.Point(332, 68);
            this.boss2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boss2.Name = "boss2";
            this.boss2.Size = new System.Drawing.Size(100, 60);
            this.boss2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss2.TabIndex = 25;
            this.boss2.TabStop = false;
            // 
            // boss3
            // 
            this.boss3.BackColor = System.Drawing.Color.Transparent;
            this.boss3.Image = ((System.Drawing.Image)(resources.GetObject("boss3.Image")));
            this.boss3.Location = new System.Drawing.Point(567, 68);
            this.boss3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boss3.Name = "boss3";
            this.boss3.Size = new System.Drawing.Size(100, 60);
            this.boss3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss3.TabIndex = 26;
            this.boss3.TabStop = false;
            // 
            // boss1bullet1
            // 
            this.boss1bullet1.BackColor = System.Drawing.Color.Transparent;
            this.boss1bullet1.Image = ((System.Drawing.Image)(resources.GetObject("boss1bullet1.Image")));
            this.boss1bullet1.Location = new System.Drawing.Point(115, 601);
            this.boss1bullet1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boss1bullet1.Name = "boss1bullet1";
            this.boss1bullet1.Size = new System.Drawing.Size(11, 16);
            this.boss1bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss1bullet1.TabIndex = 27;
            this.boss1bullet1.TabStop = false;
            // 
            // boss1bullet2
            // 
            this.boss1bullet2.BackColor = System.Drawing.Color.Transparent;
            this.boss1bullet2.Image = ((System.Drawing.Image)(resources.GetObject("boss1bullet2.Image")));
            this.boss1bullet2.Location = new System.Drawing.Point(147, 601);
            this.boss1bullet2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boss1bullet2.Name = "boss1bullet2";
            this.boss1bullet2.Size = new System.Drawing.Size(11, 16);
            this.boss1bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss1bullet2.TabIndex = 28;
            this.boss1bullet2.TabStop = false;
            // 
            // boss1bullet3
            // 
            this.boss1bullet3.BackColor = System.Drawing.Color.Transparent;
            this.boss1bullet3.Image = ((System.Drawing.Image)(resources.GetObject("boss1bullet3.Image")));
            this.boss1bullet3.Location = new System.Drawing.Point(176, 601);
            this.boss1bullet3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boss1bullet3.Name = "boss1bullet3";
            this.boss1bullet3.Size = new System.Drawing.Size(11, 16);
            this.boss1bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss1bullet3.TabIndex = 29;
            this.boss1bullet3.TabStop = false;
            // 
            // boss2bullet1
            // 
            this.boss2bullet1.BackColor = System.Drawing.Color.Transparent;
            this.boss2bullet1.Image = ((System.Drawing.Image)(resources.GetObject("boss2bullet1.Image")));
            this.boss2bullet1.Location = new System.Drawing.Point(237, 601);
            this.boss2bullet1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boss2bullet1.Name = "boss2bullet1";
            this.boss2bullet1.Size = new System.Drawing.Size(11, 16);
            this.boss2bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss2bullet1.TabIndex = 30;
            this.boss2bullet1.TabStop = false;
            // 
            // boss2bullet3
            // 
            this.boss2bullet3.BackColor = System.Drawing.Color.Transparent;
            this.boss2bullet3.Image = ((System.Drawing.Image)(resources.GetObject("boss2bullet3.Image")));
            this.boss2bullet3.Location = new System.Drawing.Point(292, 601);
            this.boss2bullet3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boss2bullet3.Name = "boss2bullet3";
            this.boss2bullet3.Size = new System.Drawing.Size(11, 16);
            this.boss2bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss2bullet3.TabIndex = 31;
            this.boss2bullet3.TabStop = false;
            // 
            // boss2bullet2
            // 
            this.boss2bullet2.BackColor = System.Drawing.Color.Transparent;
            this.boss2bullet2.Image = ((System.Drawing.Image)(resources.GetObject("boss2bullet2.Image")));
            this.boss2bullet2.Location = new System.Drawing.Point(267, 601);
            this.boss2bullet2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boss2bullet2.Name = "boss2bullet2";
            this.boss2bullet2.Size = new System.Drawing.Size(11, 16);
            this.boss2bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss2bullet2.TabIndex = 32;
            this.boss2bullet2.TabStop = false;
            // 
            // boss3bullet1
            // 
            this.boss3bullet1.BackColor = System.Drawing.Color.Transparent;
            this.boss3bullet1.Image = ((System.Drawing.Image)(resources.GetObject("boss3bullet1.Image")));
            this.boss3bullet1.Location = new System.Drawing.Point(371, 601);
            this.boss3bullet1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boss3bullet1.Name = "boss3bullet1";
            this.boss3bullet1.Size = new System.Drawing.Size(11, 16);
            this.boss3bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss3bullet1.TabIndex = 33;
            this.boss3bullet1.TabStop = false;
            // 
            // boss3bullet2
            // 
            this.boss3bullet2.BackColor = System.Drawing.Color.Transparent;
            this.boss3bullet2.Image = ((System.Drawing.Image)(resources.GetObject("boss3bullet2.Image")));
            this.boss3bullet2.Location = new System.Drawing.Point(396, 601);
            this.boss3bullet2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boss3bullet2.Name = "boss3bullet2";
            this.boss3bullet2.Size = new System.Drawing.Size(11, 16);
            this.boss3bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss3bullet2.TabIndex = 34;
            this.boss3bullet2.TabStop = false;
            // 
            // boss3bullet3
            // 
            this.boss3bullet3.BackColor = System.Drawing.Color.Transparent;
            this.boss3bullet3.Image = ((System.Drawing.Image)(resources.GetObject("boss3bullet3.Image")));
            this.boss3bullet3.Location = new System.Drawing.Point(421, 601);
            this.boss3bullet3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boss3bullet3.Name = "boss3bullet3";
            this.boss3bullet3.Size = new System.Drawing.Size(11, 16);
            this.boss3bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss3bullet3.TabIndex = 35;
            this.boss3bullet3.TabStop = false;
            // 
            // bosstimer
            // 
            this.bosstimer.Tick += new System.EventHandler(this.bosstimer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(693, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 74);
            this.button1.TabIndex = 36;
            this.button1.Text = "RETURN TO MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 18.8F);
            this.label2.Location = new System.Drawing.Point(165, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 37);
            this.label2.TabIndex = 38;
            this.label2.Text = "Health:";
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.Color.Transparent;
            this.instructions.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(124, 33);
            this.instructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(581, 222);
            this.instructions.TabIndex = 39;
            this.instructions.Text = resources.GetString("instructions.Text");
            this.instructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 474);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boss3);
            this.Controls.Add(this.boss2);
            this.Controls.Add(this.boss1);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.scorecounter);
            this.Controls.Add(this.levelcounter);
            this.Controls.Add(this.levelcounterlabel);
            this.Controls.Add(this.enemyship6);
            this.Controls.Add(this.healthcounter);
            this.Controls.Add(this.enemyship4);
            this.Controls.Add(this.enemyship3);
            this.Controls.Add(this.enemyship2);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.enemyship1);
            this.Controls.Add(this.heroship1);
            this.Controls.Add(this.laser);
            this.Controls.Add(this.enemybullet1);
            this.Controls.Add(this.enemybullet2);
            this.Controls.Add(this.enemybullet3);
            this.Controls.Add(this.enemybullet4);
            this.Controls.Add(this.enemyship5);
            this.Controls.Add(this.enemybullet5);
            this.Controls.Add(this.enemybullet6);
            this.Controls.Add(this.boss1bullet1);
            this.Controls.Add(this.boss1bullet2);
            this.Controls.Add(this.boss1bullet3);
            this.Controls.Add(this.boss2bullet1);
            this.Controls.Add(this.boss2bullet2);
            this.Controls.Add(this.boss2bullet3);
            this.Controls.Add(this.boss3bullet1);
            this.Controls.Add(this.boss3bullet2);
            this.Controls.Add(this.boss3bullet3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gameoverlabel);
            this.Controls.Add(this.instructions);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "A JOURNEY HOME";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.heroship1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyship1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyship2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyship3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyship4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemybullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemybullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemybullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemybullet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyship5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemybullet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyship6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemybullet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss1bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss1bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss1bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss2bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss2bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss2bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss3bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss3bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss3bullet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Timer enemyshiptimer;
        private System.Windows.Forms.PictureBox heroship1;
        private System.Windows.Forms.PictureBox enemyship1;
        private System.Windows.Forms.PictureBox enemyship2;
        private System.Windows.Forms.PictureBox enemyship3;
        private System.Windows.Forms.PictureBox enemyship4;
        private System.Windows.Forms.PictureBox laser;
        private System.Windows.Forms.Timer bulletTimer1;
        private System.Windows.Forms.Timer PlayTimer;
        private System.Windows.Forms.Label gameoverlabel;
        private System.Windows.Forms.PictureBox enemybullet1;
        private System.Windows.Forms.Timer randint;
        private System.Windows.Forms.Timer enem1laser;
        private System.Windows.Forms.PictureBox enemybullet2;
        private System.Windows.Forms.PictureBox enemybullet3;
        private System.Windows.Forms.PictureBox enemybullet4;
        private System.Windows.Forms.Timer enem2laser;
        private System.Windows.Forms.Timer enem3laser;
        private System.Windows.Forms.Timer enem4laser;
        private System.Windows.Forms.TextBox healthcounter;
        private System.Windows.Forms.PictureBox enemyship5;
        private System.Windows.Forms.PictureBox enemybullet5;
        private System.Windows.Forms.PictureBox enemyship6;
        private System.Windows.Forms.PictureBox enemybullet6;
        private System.Windows.Forms.Timer enem5laser;
        private System.Windows.Forms.Timer enem6laser;
        private System.Windows.Forms.Label levelcounterlabel;
        private System.Windows.Forms.TextBox levelcounter;
        private System.Windows.Forms.TextBox scorecounter;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.PictureBox boss1;
        private System.Windows.Forms.PictureBox boss2;
        private System.Windows.Forms.PictureBox boss3;
        private System.Windows.Forms.PictureBox boss1bullet1;
        private System.Windows.Forms.PictureBox boss1bullet2;
        private System.Windows.Forms.PictureBox boss1bullet3;
        private System.Windows.Forms.PictureBox boss2bullet1;
        private System.Windows.Forms.PictureBox boss2bullet3;
        private System.Windows.Forms.PictureBox boss2bullet2;
        private System.Windows.Forms.PictureBox boss3bullet1;
        private System.Windows.Forms.PictureBox boss3bullet2;
        private System.Windows.Forms.PictureBox boss3bullet3;
        private System.Windows.Forms.Timer bosstimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label instructions;
    }
}

