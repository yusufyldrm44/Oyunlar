namespace flappybird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picturebox_top = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bottom = new System.Windows.Forms.PictureBox();
            this.pictureBox_bird = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_GameControl = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox_top
            // 
            this.picturebox_top.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_top.Image")));
            this.picturebox_top.Location = new System.Drawing.Point(666, -110);
            this.picturebox_top.Name = "picturebox_top";
            this.picturebox_top.Size = new System.Drawing.Size(100, 249);
            this.picturebox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_top.TabIndex = 0;
            this.picturebox_top.TabStop = false;
            this.picturebox_top.Click += new System.EventHandler(this.xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx);
            // 
            // pictureBox_Bottom
            // 
            this.pictureBox_Bottom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Bottom.Image")));
            this.pictureBox_Bottom.Location = new System.Drawing.Point(525, 391);
            this.pictureBox_Bottom.Name = "pictureBox_Bottom";
            this.pictureBox_Bottom.Size = new System.Drawing.Size(100, 258);
            this.pictureBox_Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bottom.TabIndex = 1;
            this.pictureBox_Bottom.TabStop = false;
            // 
            // pictureBox_bird
            // 
            this.pictureBox_bird.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_bird.Image")));
            this.pictureBox_bird.Location = new System.Drawing.Point(117, 103);
            this.pictureBox_bird.Name = "pictureBox_bird";
            this.pictureBox_bird.Size = new System.Drawing.Size(100, 79);
            this.pictureBox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bird.TabIndex = 2;
            this.pictureBox_bird.TabStop = false;
            // 
            // pictureBox_Ground
            // 
            this.pictureBox_Ground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Ground.Image")));
            this.pictureBox_Ground.Location = new System.Drawing.Point(-5, 536);
            this.pictureBox_Ground.Name = "pictureBox_Ground";
            this.pictureBox_Ground.Size = new System.Drawing.Size(873, 113);
            this.pictureBox_Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ground.TabIndex = 3;
            this.pictureBox_Ground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE:";
            // 
            // timer_GameControl
            // 
            this.timer_GameControl.Enabled = true;
            this.timer_GameControl.Interval = 20;
            this.timer_GameControl.Tick += new System.EventHandler(this.gameTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(861, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Ground);
            this.Controls.Add(this.pictureBox_bird);
            this.Controls.Add(this.pictureBox_Bottom);
            this.Controls.Add(this.picturebox_top);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Up);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox_top;
        private System.Windows.Forms.PictureBox pictureBox_Bottom;
        private System.Windows.Forms.PictureBox pictureBox_bird;
        private System.Windows.Forms.PictureBox pictureBox_Ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_GameControl;
    }
}

