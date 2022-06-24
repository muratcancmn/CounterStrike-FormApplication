
namespace CounterStrike
{
    partial class Knife
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Knife));
            this.btnKes = new System.Windows.Forms.Button();
            this.btnBiley = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKillCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNewEnemies = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(229, 184);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(75, 23);
            this.btnKes.TabIndex = 0;
            this.btnKes.Text = "KES";
            this.btnKes.UseVisualStyleBackColor = true;
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // btnBiley
            // 
            this.btnBiley.Location = new System.Drawing.Point(229, 244);
            this.btnBiley.Name = "btnBiley";
            this.btnBiley.Size = new System.Drawing.Size(75, 23);
            this.btnBiley.TabIndex = 1;
            this.btnBiley.Text = "BİLEYLE";
            this.btnBiley.UseVisualStyleBackColor = true;
            this.btnBiley.Click += new System.EventHandler(this.btnBiley_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(106, 194);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(25, 13);
            this.lblHealth.TabIndex = 3;
            this.lblHealth.Text = "100";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(383, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(356, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "SWITCH TO PISTOLS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKillCount
            // 
            this.lblKillCount.AutoSize = true;
            this.lblKillCount.Location = new System.Drawing.Point(106, 132);
            this.lblKillCount.Name = "lblKillCount";
            this.lblKillCount.Size = new System.Drawing.Size(0, 13);
            this.lblKillCount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ENEMY HEALTH :";
            // 
            // lblNewEnemies
            // 
            this.lblNewEnemies.AutoSize = true;
            this.lblNewEnemies.Location = new System.Drawing.Point(71, 231);
            this.lblNewEnemies.Name = "lblNewEnemies";
            this.lblNewEnemies.Size = new System.Drawing.Size(0, 13);
            this.lblNewEnemies.TabIndex = 8;
            // 
            // Knife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNewEnemies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKillCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBiley);
            this.Controls.Add(this.btnKes);
            this.Name = "Knife";
            this.Text = "Knife";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKes;
        private System.Windows.Forms.Button btnBiley;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKillCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNewEnemies;
    }
}