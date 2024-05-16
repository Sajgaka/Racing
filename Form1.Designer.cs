namespace SchoolProjectC_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.LabelLose = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.labelCoins = new System.Windows.Forms.Label();
            this.labelChoose = new System.Windows.Forms.Label();
            this.Easy = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.DimGray;
            this.enemy1.BackgroundImage = global::SchoolProjectC_.Properties.Resources.Carrenemy;
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy1.Image = global::SchoolProjectC_.Properties.Resources.Carrenemy;
            this.enemy1.Location = new System.Drawing.Point(300, -132);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(128, 128);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.DimGray;
            this.car.BackgroundImage = global::SchoolProjectC_.Properties.Resources.Car;
            this.car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car.Location = new System.Drawing.Point(366, 522);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(128, 128);
            this.car.TabIndex = 1;
            this.car.TabStop = false;
            // 
            // bg1
            // 
            this.bg1.BackgroundImage = global::SchoolProjectC_.Properties.Resources.BackGround;
            this.bg1.Location = new System.Drawing.Point(0, 0);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(800, 650);
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = false;
            // 
            // bg2
            // 
            this.bg2.BackgroundImage = global::SchoolProjectC_.Properties.Resources.BackGround;
            this.bg2.Location = new System.Drawing.Point(0, -650);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(800, 650);
            this.bg2.TabIndex = 2;
            this.bg2.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.DimGray;
            this.enemy2.BackgroundImage = global::SchoolProjectC_.Properties.Resources.Carrenemy;
            this.enemy2.Image = global::SchoolProjectC_.Properties.Resources.Carrenemy;
            this.enemy2.Location = new System.Drawing.Point(582, -400);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(128, 128);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 4;
            this.enemy2.TabStop = false;
            // 
            // LabelLose
            // 
            this.LabelLose.AutoSize = true;
            this.LabelLose.BackColor = System.Drawing.Color.Snow;
            this.LabelLose.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLose.ForeColor = System.Drawing.Color.Red;
            this.LabelLose.Location = new System.Drawing.Point(345, 198);
            this.LabelLose.Name = "LabelLose";
            this.LabelLose.Size = new System.Drawing.Size(168, 39);
            this.LabelLose.TabIndex = 5;
            this.LabelLose.Text = "You Loose";
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.White;
            this.Restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Restart.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Restart.ForeColor = System.Drawing.Color.Red;
            this.Restart.Location = new System.Drawing.Point(582, 356);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(197, 51);
            this.Restart.TabIndex = 6;
            this.Restart.Text = "Play Again";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.Image = global::SchoolProjectC_.Properties.Resources.coin;
            this.coin.Location = new System.Drawing.Point(611, -600);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(32, 32);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 7;
            this.coin.TabStop = false;
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.Snow;
            this.labelCoins.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelCoins.Location = new System.Drawing.Point(35, 29);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(101, 28);
            this.labelCoins.TabIndex = 8;
            this.labelCoins.Text = "Coins : 0";
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.BackColor = System.Drawing.Color.Snow;
            this.labelChoose.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChoose.ForeColor = System.Drawing.Color.Red;
            this.labelChoose.Location = new System.Drawing.Point(268, 237);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(341, 39);
            this.labelChoose.TabIndex = 9;
            this.labelChoose.Text = "Choose the difficulty :";
            // 
            // Easy
            // 
            this.Easy.BackColor = System.Drawing.Color.White;
            this.Easy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Easy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Easy.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Easy.ForeColor = System.Drawing.Color.Red;
            this.Easy.Location = new System.Drawing.Point(615, 237);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(76, 39);
            this.Easy.TabIndex = 12;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = false;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Hard
            // 
            this.Hard.BackColor = System.Drawing.Color.White;
            this.Hard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Hard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hard.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hard.ForeColor = System.Drawing.Color.Red;
            this.Hard.Location = new System.Drawing.Point(615, 282);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(76, 39);
            this.Hard.TabIndex = 13;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = false;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SchoolProjectC_.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.LabelLose);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.bg2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg1;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox bg2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label LabelLose;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button Hard;
    }
}

