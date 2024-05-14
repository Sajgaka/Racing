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
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.BackgroundImage = global::SchoolProjectC_.Properties.Resources.car_enemy;
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy1.Image = global::SchoolProjectC_.Properties.Resources.car2;
            this.enemy1.Location = new System.Drawing.Point(163, -130);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(128, 128);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Transparent;
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
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.BackgroundImage = global::SchoolProjectC_.Properties.Resources.car_enemy;
            this.enemy2.Image = global::SchoolProjectC_.Properties.Resources.car2;
            this.enemy2.Location = new System.Drawing.Point(551, -400);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SchoolProjectC_.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(800, 650);
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
    }
}

