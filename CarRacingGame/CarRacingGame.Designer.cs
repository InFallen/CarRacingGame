namespace CarRacingGame
{
    partial class CarRacingGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRacingGameForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.enemyCar = new System.Windows.Forms.PictureBox();
            this.PlayerCar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SolidLineLeft = new System.Windows.Forms.PictureBox();
            this.SolidLineRight = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.labelPlayerPoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolidLineLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolidLineRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CarRacingGame.Properties.Resources.EnemyCar;
            this.pictureBox6.Location = new System.Drawing.Point(625, 260);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(84, 146);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "EnemyCar";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CarRacingGame.Properties.Resources.EnemyCar;
            this.pictureBox5.Location = new System.Drawing.Point(463, 54);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(84, 146);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "EnemyCar";
            // 
            // enemyCar
            // 
            this.enemyCar.Image = global::CarRacingGame.Properties.Resources.EnemyCar;
            this.enemyCar.Location = new System.Drawing.Point(81, 118);
            this.enemyCar.Name = "enemyCar";
            this.enemyCar.Size = new System.Drawing.Size(84, 146);
            this.enemyCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyCar.TabIndex = 1;
            this.enemyCar.TabStop = false;
            this.enemyCar.Tag = "EnemyCar";
            // 
            // PlayerCar
            // 
            this.PlayerCar.Image = global::CarRacingGame.Properties.Resources.PlayerCar;
            this.PlayerCar.Location = new System.Drawing.Point(271, 724);
            this.PlayerCar.Name = "PlayerCar";
            this.PlayerCar.Size = new System.Drawing.Size(84, 146);
            this.PlayerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCar.TabIndex = 1;
            this.PlayerCar.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(394, 776);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(12, 200);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "BrokenLine";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(394, 524);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(12, 200);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "BrokenLine";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(394, 260);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 200);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "BrokenLine";
            // 
            // SolidLineLeft
            // 
            this.SolidLineLeft.BackColor = System.Drawing.Color.White;
            this.SolidLineLeft.Location = new System.Drawing.Point(12, -10);
            this.SolidLineLeft.Name = "SolidLineLeft";
            this.SolidLineLeft.Size = new System.Drawing.Size(12, 946);
            this.SolidLineLeft.TabIndex = 0;
            this.SolidLineLeft.TabStop = false;
            this.SolidLineLeft.Tag = "SolidLine";
            // 
            // SolidLineRight
            // 
            this.SolidLineRight.BackColor = System.Drawing.Color.White;
            this.SolidLineRight.Location = new System.Drawing.Point(750, 0);
            this.SolidLineRight.Name = "SolidLineRight";
            this.SolidLineRight.Size = new System.Drawing.Size(12, 946);
            this.SolidLineRight.TabIndex = 0;
            this.SolidLineRight.TabStop = false;
            this.SolidLineRight.Tag = "SolidLine";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(394, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "BrokenLine";
            // 
            // labelGameOver
            // 
            this.labelGameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGameOver.BackColor = System.Drawing.Color.Black;
            this.labelGameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameOver.ForeColor = System.Drawing.Color.Red;
            this.labelGameOver.Location = new System.Drawing.Point(266, 260);
            this.labelGameOver.Margin = new System.Windows.Forms.Padding(3);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(294, 101);
            this.labelGameOver.TabIndex = 2;
            this.labelGameOver.Text = "Game Over";
            this.labelGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CarRacingGame.Properties.Resources.Coin;
            this.pictureBox7.Location = new System.Drawing.Point(115, 438);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "Coin";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CarRacingGame.Properties.Resources.Coin;
            this.pictureBox8.Location = new System.Drawing.Point(271, 524);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(60, 60);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "Coin";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::CarRacingGame.Properties.Resources.Coin;
            this.pictureBox9.Location = new System.Drawing.Point(547, 452);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(60, 60);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "Coin";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::CarRacingGame.Properties.Resources.Coin;
            this.pictureBox10.Location = new System.Drawing.Point(317, 160);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(60, 60);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "Coin";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::CarRacingGame.Properties.Resources.Coin;
            this.pictureBox11.Location = new System.Drawing.Point(593, 88);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(60, 60);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 1;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "Coin";
            // 
            // labelPlayerPoint
            // 
            this.labelPlayerPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerPoint.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPlayerPoint.Location = new System.Drawing.Point(31, 13);
            this.labelPlayerPoint.Name = "labelPlayerPoint";
            this.labelPlayerPoint.Size = new System.Drawing.Size(134, 51);
            this.labelPlayerPoint.TabIndex = 3;
            this.labelPlayerPoint.Text = "100";
            // 
            // CarRacingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(774, 929);
            this.Controls.Add(this.labelPlayerPoint);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.enemyCar);
            this.Controls.Add(this.PlayerCar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SolidLineLeft);
            this.Controls.Add(this.SolidLineRight);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarRacingGameForm";
            this.Text = "CarRacingGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CarRacingGameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolidLineLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolidLineRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox SolidLineRight;
        private System.Windows.Forms.PictureBox SolidLineLeft;
        private System.Windows.Forms.PictureBox PlayerCar;
        private System.Windows.Forms.PictureBox enemyCar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label labelPlayerPoint;
    }
}

