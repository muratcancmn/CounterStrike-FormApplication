
namespace CounterStrike
{
    partial class Shotguns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shotguns));
            this.btnFire = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.picMag = new System.Windows.Forms.PictureBox();
            this.lblWeaponName = new System.Windows.Forms.Label();
            this.picNova = new System.Windows.Forms.PictureBox();
            this.picXm = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKillCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNewEnemies = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(295, 190);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "FIRE";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(295, 240);
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
            this.label1.Location = new System.Drawing.Point(13, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ENEMY HEALTH";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(123, 200);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(25, 13);
            this.lblHealth.TabIndex = 3;
            this.lblHealth.Text = "100";
            // 
            // picMag
            // 
            this.picMag.Image = ((System.Drawing.Image)(resources.GetObject("picMag.Image")));
            this.picMag.Location = new System.Drawing.Point(443, 98);
            this.picMag.Name = "picMag";
            this.picMag.Size = new System.Drawing.Size(325, 255);
            this.picMag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMag.TabIndex = 4;
            this.picMag.TabStop = false;
            // 
            // lblWeaponName
            // 
            this.lblWeaponName.AutoSize = true;
            this.lblWeaponName.Location = new System.Drawing.Point(479, 32);
            this.lblWeaponName.Name = "lblWeaponName";
            this.lblWeaponName.Size = new System.Drawing.Size(33, 13);
            this.lblWeaponName.TabIndex = 5;
            this.lblWeaponName.Text = "mag7";
            // 
            // picNova
            // 
            this.picNova.Image = ((System.Drawing.Image)(resources.GetObject("picNova.Image")));
            this.picNova.Location = new System.Drawing.Point(443, 98);
            this.picNova.Name = "picNova";
            this.picNova.Size = new System.Drawing.Size(325, 255);
            this.picNova.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNova.TabIndex = 6;
            this.picNova.TabStop = false;
            this.picNova.Visible = false;
            // 
            // picXm
            // 
            this.picXm.Image = ((System.Drawing.Image)(resources.GetObject("picXm.Image")));
            this.picXm.Location = new System.Drawing.Point(443, 98);
            this.picXm.Name = "picXm";
            this.picXm.Size = new System.Drawing.Size(325, 255);
            this.picXm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXm.TabIndex = 7;
            this.picXm.TabStop = false;
            this.picXm.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "SWITCH TO SMG\'S";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKillCount
            // 
            this.lblKillCount.AutoSize = true;
            this.lblKillCount.Location = new System.Drawing.Point(86, 122);
            this.lblKillCount.Name = "lblKillCount";
            this.lblKillCount.Size = new System.Drawing.Size(0, 13);
            this.lblKillCount.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "REMAINING AMMO";
            // 
            // lblNewEnemies
            // 
            this.lblNewEnemies.AutoSize = true;
            this.lblNewEnemies.Location = new System.Drawing.Point(35, 250);
            this.lblNewEnemies.Name = "lblNewEnemies";
            this.lblNewEnemies.Size = new System.Drawing.Size(0, 13);
            this.lblNewEnemies.TabIndex = 11;
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Location = new System.Drawing.Point(573, 376);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(0, 13);
            this.lblAmmo.TabIndex = 12;
            // 
            // Shotguns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.lblNewEnemies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKillCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picXm);
            this.Controls.Add(this.picNova);
            this.Controls.Add(this.lblWeaponName);
            this.Controls.Add(this.picMag);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnFire);
            this.Name = "Shotguns";
            this.Text = "Shotguns";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Shotguns_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.PictureBox picMag;
        private System.Windows.Forms.Label lblWeaponName;
        private System.Windows.Forms.PictureBox picNova;
        private System.Windows.Forms.PictureBox picXm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKillCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNewEnemies;
        private System.Windows.Forms.Label lblAmmo;
    }
}