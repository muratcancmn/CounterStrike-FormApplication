
namespace CounterStrike
{
    partial class Snipers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snipers));
            this.btnFire = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.picSsg = new System.Windows.Forms.PictureBox();
            this.lblWeaponName = new System.Windows.Forms.Label();
            this.picAwp = new System.Windows.Forms.PictureBox();
            this.lblKillCount = new System.Windows.Forms.Label();
            this.lblNewEnemies = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAwp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(240, 170);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 42);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "FIRE";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(240, 232);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 42);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ENEMY HEALTH";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(125, 185);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(25, 13);
            this.lblHealth.TabIndex = 3;
            this.lblHealth.Text = "100";
            // 
            // picSsg
            // 
            this.picSsg.Image = ((System.Drawing.Image)(resources.GetObject("picSsg.Image")));
            this.picSsg.Location = new System.Drawing.Point(534, 148);
            this.picSsg.Name = "picSsg";
            this.picSsg.Size = new System.Drawing.Size(217, 218);
            this.picSsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSsg.TabIndex = 4;
            this.picSsg.TabStop = false;
            // 
            // lblWeaponName
            // 
            this.lblWeaponName.AutoSize = true;
            this.lblWeaponName.Location = new System.Drawing.Point(549, 75);
            this.lblWeaponName.Name = "lblWeaponName";
            this.lblWeaponName.Size = new System.Drawing.Size(44, 13);
            this.lblWeaponName.TabIndex = 5;
            this.lblWeaponName.Text = "SSG 08";
            // 
            // picAwp
            // 
            this.picAwp.Image = ((System.Drawing.Image)(resources.GetObject("picAwp.Image")));
            this.picAwp.Location = new System.Drawing.Point(534, 148);
            this.picAwp.Name = "picAwp";
            this.picAwp.Size = new System.Drawing.Size(217, 218);
            this.picAwp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAwp.TabIndex = 6;
            this.picAwp.TabStop = false;
            this.picAwp.Visible = false;
            // 
            // lblKillCount
            // 
            this.lblKillCount.AutoSize = true;
            this.lblKillCount.Location = new System.Drawing.Point(128, 108);
            this.lblKillCount.Name = "lblKillCount";
            this.lblKillCount.Size = new System.Drawing.Size(0, 13);
            this.lblKillCount.TabIndex = 7;
            // 
            // lblNewEnemies
            // 
            this.lblNewEnemies.AutoSize = true;
            this.lblNewEnemies.Location = new System.Drawing.Point(23, 261);
            this.lblNewEnemies.Name = "lblNewEnemies";
            this.lblNewEnemies.Size = new System.Drawing.Size(0, 13);
            this.lblNewEnemies.TabIndex = 8;
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Location = new System.Drawing.Point(668, 394);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(0, 13);
            this.lblAmmo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "REMAINING AMMO :";
            // 
            // Snipers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.lblNewEnemies);
            this.Controls.Add(this.lblKillCount);
            this.Controls.Add(this.picAwp);
            this.Controls.Add(this.lblWeaponName);
            this.Controls.Add(this.picSsg);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnFire);
            this.Name = "Snipers";
            this.Text = "Snipers";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snipers_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picSsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAwp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.PictureBox picSsg;
        private System.Windows.Forms.Label lblWeaponName;
        private System.Windows.Forms.PictureBox picAwp;
        private System.Windows.Forms.Label lblKillCount;
        private System.Windows.Forms.Label lblNewEnemies;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Label label4;
    }
}