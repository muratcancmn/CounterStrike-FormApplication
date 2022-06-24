
namespace CounterStrike
{
    partial class Pistols
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pistols));
            this.btnFire = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.picUsp = new System.Windows.Forms.PictureBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.picP250 = new System.Windows.Forms.PictureBox();
            this.picGlock = new System.Windows.Forms.PictureBox();
            this.picDeagle = new System.Windows.Forms.PictureBox();
            this.lblWeaponName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKillCount = new System.Windows.Forms.Label();
            this.lblNewEnemies = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP250)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeagle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(259, 100);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(93, 39);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "FIRE";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(259, 163);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(93, 39);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // picUsp
            // 
            this.picUsp.Image = ((System.Drawing.Image)(resources.GetObject("picUsp.Image")));
            this.picUsp.Location = new System.Drawing.Point(441, 56);
            this.picUsp.Name = "picUsp";
            this.picUsp.Size = new System.Drawing.Size(249, 253);
            this.picUsp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsp.TabIndex = 2;
            this.picUsp.TabStop = false;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(103, 113);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(25, 13);
            this.lblHealth.TabIndex = 3;
            this.lblHealth.Text = "100";
            // 
            // picP250
            // 
            this.picP250.Image = ((System.Drawing.Image)(resources.GetObject("picP250.Image")));
            this.picP250.Location = new System.Drawing.Point(441, 56);
            this.picP250.Name = "picP250";
            this.picP250.Size = new System.Drawing.Size(249, 253);
            this.picP250.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP250.TabIndex = 4;
            this.picP250.TabStop = false;
            this.picP250.Visible = false;
            // 
            // picGlock
            // 
            this.picGlock.Image = ((System.Drawing.Image)(resources.GetObject("picGlock.Image")));
            this.picGlock.Location = new System.Drawing.Point(441, 56);
            this.picGlock.Name = "picGlock";
            this.picGlock.Size = new System.Drawing.Size(249, 253);
            this.picGlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGlock.TabIndex = 5;
            this.picGlock.TabStop = false;
            this.picGlock.Visible = false;
            // 
            // picDeagle
            // 
            this.picDeagle.Image = ((System.Drawing.Image)(resources.GetObject("picDeagle.Image")));
            this.picDeagle.Location = new System.Drawing.Point(441, 56);
            this.picDeagle.Name = "picDeagle";
            this.picDeagle.Size = new System.Drawing.Size(249, 253);
            this.picDeagle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeagle.TabIndex = 6;
            this.picDeagle.TabStop = false;
            this.picDeagle.Visible = false;
            // 
            // lblWeaponName
            // 
            this.lblWeaponName.AutoSize = true;
            this.lblWeaponName.Location = new System.Drawing.Point(473, 13);
            this.lblWeaponName.Name = "lblWeaponName";
            this.lblWeaponName.Size = new System.Drawing.Size(39, 13);
            this.lblWeaponName.TabIndex = 7;
            this.lblWeaponName.Text = "USP-S";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ENEMY HEALTH :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 82);
            this.button1.TabIndex = 9;
            this.button1.Text = "SWITCH TO SHOTGUNS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKillCount
            // 
            this.lblKillCount.AutoSize = true;
            this.lblKillCount.Location = new System.Drawing.Point(67, 65);
            this.lblKillCount.Name = "lblKillCount";
            this.lblKillCount.Size = new System.Drawing.Size(0, 13);
            this.lblKillCount.TabIndex = 10;
            // 
            // lblNewEnemies
            // 
            this.lblNewEnemies.AutoSize = true;
            this.lblNewEnemies.Location = new System.Drawing.Point(70, 163);
            this.lblNewEnemies.Name = "lblNewEnemies";
            this.lblNewEnemies.Size = new System.Drawing.Size(0, 13);
            this.lblNewEnemies.TabIndex = 11;
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Location = new System.Drawing.Point(531, 338);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(0, 13);
            this.lblAmmo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "REMAINING AMMO :";
            // 
            // Pistols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.lblNewEnemies);
            this.Controls.Add(this.lblKillCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeaponName);
            this.Controls.Add(this.picDeagle);
            this.Controls.Add(this.picGlock);
            this.Controls.Add(this.picP250);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.picUsp);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnFire);
            this.Name = "Pistols";
            this.Text = "Pistols";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pistols_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picUsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP250)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeagle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.PictureBox picUsp;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.PictureBox picP250;
        private System.Windows.Forms.PictureBox picGlock;
        private System.Windows.Forms.PictureBox picDeagle;
        private System.Windows.Forms.Label lblWeaponName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKillCount;
        private System.Windows.Forms.Label lblNewEnemies;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Label label2;
    }
}