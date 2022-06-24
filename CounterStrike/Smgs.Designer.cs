
namespace CounterStrike
{
    partial class Smgs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Smgs));
            this.btnFire = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.picMp7 = new System.Windows.Forms.PictureBox();
            this.lblWeaponName = new System.Windows.Forms.Label();
            this.picMp9 = new System.Windows.Forms.PictureBox();
            this.picUmp = new System.Windows.Forms.PictureBox();
            this.picP90 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKillCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNewEnemies = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMp7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMp9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP90)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(230, 148);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "FIRE";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(230, 195);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ENEMY HEALTH :";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(99, 175);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(25, 13);
            this.lblHealth.TabIndex = 3;
            this.lblHealth.Text = "100";
            // 
            // picMp7
            // 
            this.picMp7.Image = ((System.Drawing.Image)(resources.GetObject("picMp7.Image")));
            this.picMp7.Location = new System.Drawing.Point(441, 121);
            this.picMp7.Name = "picMp7";
            this.picMp7.Size = new System.Drawing.Size(234, 200);
            this.picMp7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMp7.TabIndex = 4;
            this.picMp7.TabStop = false;
            // 
            // lblWeaponName
            // 
            this.lblWeaponName.AutoSize = true;
            this.lblWeaponName.Location = new System.Drawing.Point(438, 80);
            this.lblWeaponName.Name = "lblWeaponName";
            this.lblWeaponName.Size = new System.Drawing.Size(29, 13);
            this.lblWeaponName.TabIndex = 5;
            this.lblWeaponName.Text = "MP7";
            // 
            // picMp9
            // 
            this.picMp9.Image = ((System.Drawing.Image)(resources.GetObject("picMp9.Image")));
            this.picMp9.Location = new System.Drawing.Point(441, 121);
            this.picMp9.Name = "picMp9";
            this.picMp9.Size = new System.Drawing.Size(234, 200);
            this.picMp9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMp9.TabIndex = 6;
            this.picMp9.TabStop = false;
            this.picMp9.Visible = false;
            // 
            // picUmp
            // 
            this.picUmp.Image = ((System.Drawing.Image)(resources.GetObject("picUmp.Image")));
            this.picUmp.Location = new System.Drawing.Point(441, 121);
            this.picUmp.Name = "picUmp";
            this.picUmp.Size = new System.Drawing.Size(234, 200);
            this.picUmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUmp.TabIndex = 7;
            this.picUmp.TabStop = false;
            this.picUmp.Visible = false;
            // 
            // picP90
            // 
            this.picP90.Image = ((System.Drawing.Image)(resources.GetObject("picP90.Image")));
            this.picP90.Location = new System.Drawing.Point(441, 121);
            this.picP90.Name = "picP90";
            this.picP90.Size = new System.Drawing.Size(234, 200);
            this.picP90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP90.TabIndex = 8;
            this.picP90.TabStop = false;
            this.picP90.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 101);
            this.button1.TabIndex = 9;
            this.button1.Text = "SWITCH TO RIFLES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKillCount
            // 
            this.lblKillCount.AutoSize = true;
            this.lblKillCount.Location = new System.Drawing.Point(88, 80);
            this.lblKillCount.Name = "lblKillCount";
            this.lblKillCount.Size = new System.Drawing.Size(0, 13);
            this.lblKillCount.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "REMAINING AMMO :";
            // 
            // lblNewEnemies
            // 
            this.lblNewEnemies.AutoSize = true;
            this.lblNewEnemies.Location = new System.Drawing.Point(40, 239);
            this.lblNewEnemies.Name = "lblNewEnemies";
            this.lblNewEnemies.Size = new System.Drawing.Size(0, 13);
            this.lblNewEnemies.TabIndex = 12;
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Location = new System.Drawing.Point(587, 350);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(0, 13);
            this.lblAmmo.TabIndex = 13;
            // 
            // Smgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.lblNewEnemies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKillCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picP90);
            this.Controls.Add(this.picUmp);
            this.Controls.Add(this.picMp9);
            this.Controls.Add(this.lblWeaponName);
            this.Controls.Add(this.picMp7);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnFire);
            this.Name = "Smgs";
            this.Text = "Smgs";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Smgs_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMp7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMp9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP90)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.PictureBox picMp7;
        private System.Windows.Forms.Label lblWeaponName;
        private System.Windows.Forms.PictureBox picMp9;
        private System.Windows.Forms.PictureBox picUmp;
        private System.Windows.Forms.PictureBox picP90;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKillCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNewEnemies;
        private System.Windows.Forms.Label lblAmmo;
    }
}