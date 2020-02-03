namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player = new System.Windows.Forms.PictureBox();
            this.Bone1 = new System.Windows.Forms.PictureBox();
            this.Bone2 = new System.Windows.Forms.PictureBox();
            this.Bone3 = new System.Windows.Forms.PictureBox();
            this.Bone4 = new System.Windows.Forms.PictureBox();
            this.Bone5 = new System.Windows.Forms.PictureBox();
            this.Bone6 = new System.Windows.Forms.PictureBox();
            this.Bone7 = new System.Windows.Forms.PictureBox();
            this.Life = new System.Windows.Forms.PictureBox();
            this.Bomb = new System.Windows.Forms.PictureBox();
            this.Points = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lifes = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameover = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(619, 500);
            this.Player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(116, 101);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // Bone1
            // 
            this.Bone1.BackColor = System.Drawing.Color.Transparent;
            this.Bone1.Image = ((System.Drawing.Image)(resources.GetObject("Bone1.Image")));
            this.Bone1.Location = new System.Drawing.Point(918, 89);
            this.Bone1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bone1.Name = "Bone1";
            this.Bone1.Size = new System.Drawing.Size(43, 39);
            this.Bone1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bone1.TabIndex = 1;
            this.Bone1.TabStop = false;
            // 
            // Bone2
            // 
            this.Bone2.BackColor = System.Drawing.Color.Transparent;
            this.Bone2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bone2.Image = ((System.Drawing.Image)(resources.GetObject("Bone2.Image")));
            this.Bone2.Location = new System.Drawing.Point(187, 111);
            this.Bone2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bone2.Name = "Bone2";
            this.Bone2.Size = new System.Drawing.Size(43, 39);
            this.Bone2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bone2.TabIndex = 2;
            this.Bone2.TabStop = false;
            // 
            // Bone3
            // 
            this.Bone3.BackColor = System.Drawing.Color.Transparent;
            this.Bone3.Image = ((System.Drawing.Image)(resources.GetObject("Bone3.Image")));
            this.Bone3.Location = new System.Drawing.Point(1181, 111);
            this.Bone3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bone3.Name = "Bone3";
            this.Bone3.Size = new System.Drawing.Size(43, 39);
            this.Bone3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bone3.TabIndex = 3;
            this.Bone3.TabStop = false;
            // 
            // Bone4
            // 
            this.Bone4.BackColor = System.Drawing.Color.Transparent;
            this.Bone4.Image = ((System.Drawing.Image)(resources.GetObject("Bone4.Image")));
            this.Bone4.Location = new System.Drawing.Point(707, 89);
            this.Bone4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bone4.Name = "Bone4";
            this.Bone4.Size = new System.Drawing.Size(43, 39);
            this.Bone4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bone4.TabIndex = 4;
            this.Bone4.TabStop = false;
            // 
            // Bone5
            // 
            this.Bone5.BackColor = System.Drawing.Color.Transparent;
            this.Bone5.Image = ((System.Drawing.Image)(resources.GetObject("Bone5.Image")));
            this.Bone5.Location = new System.Drawing.Point(958, 377);
            this.Bone5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bone5.Name = "Bone5";
            this.Bone5.Size = new System.Drawing.Size(43, 39);
            this.Bone5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bone5.TabIndex = 5;
            this.Bone5.TabStop = false;
            // 
            // Bone6
            // 
            this.Bone6.BackColor = System.Drawing.Color.Transparent;
            this.Bone6.Image = ((System.Drawing.Image)(resources.GetObject("Bone6.Image")));
            this.Bone6.Location = new System.Drawing.Point(442, 355);
            this.Bone6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bone6.Name = "Bone6";
            this.Bone6.Size = new System.Drawing.Size(43, 39);
            this.Bone6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bone6.TabIndex = 6;
            this.Bone6.TabStop = false;
            // 
            // Bone7
            // 
            this.Bone7.BackColor = System.Drawing.Color.Transparent;
            this.Bone7.Image = ((System.Drawing.Image)(resources.GetObject("Bone7.Image")));
            this.Bone7.Location = new System.Drawing.Point(418, 154);
            this.Bone7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bone7.Name = "Bone7";
            this.Bone7.Size = new System.Drawing.Size(43, 39);
            this.Bone7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bone7.TabIndex = 7;
            this.Bone7.TabStop = false;
            // 
            // Life
            // 
            this.Life.BackColor = System.Drawing.Color.Transparent;
            this.Life.Image = ((System.Drawing.Image)(resources.GetObject("Life.Image")));
            this.Life.Location = new System.Drawing.Point(1053, 240);
            this.Life.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Life.Name = "Life";
            this.Life.Size = new System.Drawing.Size(52, 50);
            this.Life.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Life.TabIndex = 8;
            this.Life.TabStop = false;
            // 
            // Bomb
            // 
            this.Bomb.BackColor = System.Drawing.Color.Transparent;
            this.Bomb.Image = ((System.Drawing.Image)(resources.GetObject("Bomb.Image")));
            this.Bomb.Location = new System.Drawing.Point(160, 348);
            this.Bomb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bomb.Name = "Bomb";
            this.Bomb.Size = new System.Drawing.Size(48, 46);
            this.Bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bomb.TabIndex = 9;
            this.Bomb.TabStop = false;
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Points.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points.Location = new System.Drawing.Point(21, 21);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(94, 24);
            this.Points.TabIndex = 10;
            this.Points.Text = "Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1159, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ups!";
            this.label1.Visible = false;
            // 
            // Lifes
            // 
            this.Lifes.AutoSize = true;
            this.Lifes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Lifes.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lifes.Location = new System.Drawing.Point(21, 55);
            this.Lifes.Name = "Lifes";
            this.Lifes.Size = new System.Drawing.Size(94, 24);
            this.Lifes.TabIndex = 12;
            this.Lifes.Text = "Lifes:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.BackColor = System.Drawing.Color.White;
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.ForeColor = System.Drawing.Color.Black;
            this.gameover.Location = new System.Drawing.Point(533, 242);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(226, 38);
            this.gameover.TabIndex = 14;
            this.gameover.Text = "GAME OVER";
            this.gameover.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(587, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1329, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.Lifes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.Bomb);
            this.Controls.Add(this.Life);
            this.Controls.Add(this.Bone7);
            this.Controls.Add(this.Bone6);
            this.Controls.Add(this.Bone5);
            this.Controls.Add(this.Bone4);
            this.Controls.Add(this.Bone3);
            this.Controls.Add(this.Bone2);
            this.Controls.Add(this.Bone1);
            this.Controls.Add(this.Player);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Catch Game";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bone7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Bone1;
        private System.Windows.Forms.PictureBox Bone2;
        private System.Windows.Forms.PictureBox Bone3;
        private System.Windows.Forms.PictureBox Bone4;
        private System.Windows.Forms.PictureBox Bone5;
        private System.Windows.Forms.PictureBox Bone6;
        private System.Windows.Forms.PictureBox Bone7;
        private System.Windows.Forms.PictureBox Life;
        private System.Windows.Forms.PictureBox Bomb;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lifes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Button button1;
    }
}

