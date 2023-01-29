namespace WindowsFormsApplication3
{
    partial class gamescreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamescreen));
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.scoretext1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Label();
            this.scoretext = new System.Windows.Forms.Label();
            this.pipetop2 = new System.Windows.Forms.PictureBox();
            this.pipetop1 = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.fllapybird = new System.Windows.Forms.PictureBox();
            this.pipebottem = new System.Windows.Forms.PictureBox();
            this.clouds = new System.Windows.Forms.PictureBox();
            this.clouds1 = new System.Windows.Forms.PictureBox();
            this.pipebottem1 = new System.Windows.Forms.PictureBox();
            this.pipebottem2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fllapybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // scoretext1
            // 
            this.scoretext1.AutoSize = true;
            this.scoretext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext1.Location = new System.Drawing.Point(233, 198);
            this.scoretext1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoretext1.Name = "scoretext1";
            this.scoretext1.Size = new System.Drawing.Size(203, 44);
            this.scoretext1.TabIndex = 12;
            this.scoretext1.Text = "SCORE: 0";
            this.scoretext1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoretext1.Click += new System.EventHandler(this.scoretext1_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(237, 265);
            this.info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(302, 20);
            this.info.TabIndex = 14;
            this.info.Text = "Tap Close Windows (x) for back to \"Home\"";
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.BackColor = System.Drawing.Color.Transparent;
            this.gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gameOver.Image = global::WindowsFormsApplication3.Properties.Resources.game_over_PNG28;
            this.gameOver.Location = new System.Drawing.Point(199, 125);
            this.gameOver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(356, 73);
            this.gameOver.TabIndex = 13;
            this.gameOver.Text = "                  ";
            this.gameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOver.Click += new System.EventHandler(this.gameOver_Click);
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.BackColor = System.Drawing.Color.Transparent;
            this.scoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Image = global::WindowsFormsApplication3.Properties.Resources.ground1;
            this.scoretext.Location = new System.Drawing.Point(9, 422);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(131, 29);
            this.scoretext.TabIndex = 5;
            this.scoretext.Text = "SCORE: 0";
            // 
            // pipetop2
            // 
            this.pipetop2.Image = global::WindowsFormsApplication3.Properties.Resources.pipeTop;
            this.pipetop2.Location = new System.Drawing.Point(921, -125);
            this.pipetop2.Name = "pipetop2";
            this.pipetop2.Size = new System.Drawing.Size(100, 163);
            this.pipetop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop2.TabIndex = 9;
            this.pipetop2.TabStop = false;
            // 
            // pipetop1
            // 
            this.pipetop1.Image = global::WindowsFormsApplication3.Properties.Resources.pipeTop;
            this.pipetop1.Location = new System.Drawing.Point(633, -237);
            this.pipetop1.Name = "pipetop1";
            this.pipetop1.Size = new System.Drawing.Size(100, 361);
            this.pipetop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop1.TabIndex = 7;
            this.pipetop1.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = global::WindowsFormsApplication3.Properties.Resources.pipeTop;
            this.pipetop.Location = new System.Drawing.Point(300, -109);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(100, 174);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 4;
            this.pipetop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::WindowsFormsApplication3.Properties.Resources.ground1;
            this.ground.Location = new System.Drawing.Point(-30, 391);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1342, 181);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // fllapybird
            // 
            this.fllapybird.Image = global::WindowsFormsApplication3.Properties.Resources.bird3;
            this.fllapybird.Location = new System.Drawing.Point(2, 171);
            this.fllapybird.Name = "fllapybird";
            this.fllapybird.Size = new System.Drawing.Size(76, 50);
            this.fllapybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fllapybird.TabIndex = 0;
            this.fllapybird.TabStop = false;
            // 
            // pipebottem
            // 
            this.pipebottem.Image = global::WindowsFormsApplication3.Properties.Resources.pipeBottom;
            this.pipebottem.Location = new System.Drawing.Point(300, 333);
            this.pipebottem.Name = "pipebottem";
            this.pipebottem.Size = new System.Drawing.Size(100, 204);
            this.pipebottem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottem.TabIndex = 6;
            this.pipebottem.TabStop = false;
            // 
            // clouds
            // 
            this.clouds.Image = global::WindowsFormsApplication3.Properties.Resources.clouds;
            this.clouds.Location = new System.Drawing.Point(379, 3);
            this.clouds.Name = "clouds";
            this.clouds.Size = new System.Drawing.Size(124, 81);
            this.clouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clouds.TabIndex = 1;
            this.clouds.TabStop = false;
            // 
            // clouds1
            // 
            this.clouds1.Image = global::WindowsFormsApplication3.Properties.Resources.clouds2;
            this.clouds1.Location = new System.Drawing.Point(749, 3);
            this.clouds1.Name = "clouds1";
            this.clouds1.Size = new System.Drawing.Size(124, 73);
            this.clouds1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clouds1.TabIndex = 3;
            this.clouds1.TabStop = false;
            // 
            // pipebottem1
            // 
            this.pipebottem1.Image = global::WindowsFormsApplication3.Properties.Resources.pipeBottom;
            this.pipebottem1.Location = new System.Drawing.Point(633, 354);
            this.pipebottem1.Name = "pipebottem1";
            this.pipebottem1.Size = new System.Drawing.Size(100, 183);
            this.pipebottem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottem1.TabIndex = 8;
            this.pipebottem1.TabStop = false;
            // 
            // pipebottem2
            // 
            this.pipebottem2.Image = global::WindowsFormsApplication3.Properties.Resources.pipeBottom;
            this.pipebottem2.Location = new System.Drawing.Point(921, 304);
            this.pipebottem2.Name = "pipebottem2";
            this.pipebottem2.Size = new System.Drawing.Size(100, 185);
            this.pipebottem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottem2.TabIndex = 10;
            this.pipebottem2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication3.Properties.Resources.kisspng_pixel_art_drawing_halloween_ghost_pixel_5abd97ae5ef745_451554441522374574389;
            this.pictureBox1.Location = new System.Drawing.Point(793, 159);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gamescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(900, 573);
            this.Controls.Add(this.info);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.scoretext1);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.pipetop2);
            this.Controls.Add(this.pipetop1);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.fllapybird);
            this.Controls.Add(this.pipebottem);
            this.Controls.Add(this.clouds);
            this.Controls.Add(this.clouds1);
            this.Controls.Add(this.pipebottem1);
            this.Controls.Add(this.pipebottem2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gamescreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "s";
            this.Load += new System.EventHandler(this.gamescreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pipetop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fllapybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fllapybird;
        private System.Windows.Forms.PictureBox clouds;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox clouds1;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.PictureBox pipebottem;
        private System.Windows.Forms.PictureBox pipetop1;
        private System.Windows.Forms.PictureBox pipebottem1;
        private System.Windows.Forms.PictureBox pipetop2;
        private System.Windows.Forms.PictureBox pipebottem2;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label scoretext1;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.Label info;
    }
}