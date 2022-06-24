
namespace CounterStrike
{
    partial class Rifles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rifles));
            this.btnFire = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblWeaponName = new System.Windows.Forms.Label();
            this.picFamas = new System.Windows.Forms.PictureBox();
            this.picAk47 = new System.Windows.Forms.PictureBox();
            this.picM4a1 = new System.Windows.Forms.PictureBox();
            this.picAug = new System.Windows.Forms.PictureBox();
            this.lblKillCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNewEnemies = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFamas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAk47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM4a1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAug)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(242, 131);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "FIRE";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(242, 198);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(70, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 83);
            this.button3.TabIndex = 2;
            this.button3.Text = "SWITCH TO SNIPERS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ENEMY HEALTH :";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(115, 165);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(25, 13);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = "100";
            // 
            // lblWeaponName
            // 
            this.lblWeaponName.AutoSize = true;
            this.lblWeaponName.Location = new System.Drawing.Point(558, 37);
            this.lblWeaponName.Name = "lblWeaponName";
            this.lblWeaponName.Size = new System.Drawing.Size(43, 13);
            this.lblWeaponName.TabIndex = 5;
            this.lblWeaponName.Text = "FAMAS";
            // 
            // picFamas
            // 
            this.picFamas.Image = ((System.Drawing.Image)(resources.GetObject("picFamas.Image")));
            this.picFamas.Location = new System.Drawing.Point(438, 107);
            this.picFamas.Name = "picFamas";
            this.picFamas.Size = new System.Drawing.Size(314, 267);
            this.picFamas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFamas.TabIndex = 6;
            this.picFamas.TabStop = false;
            // 
            // picAk47
            // 
            this.picAk47.Image = ((System.Drawing.Image)(resources.GetObject("picAk47.Image")));
            this.picAk47.Location = new System.Drawing.Point(438, 107);
            this.picAk47.Name = "picAk47";
            this.picAk47.Size = new System.Drawing.Size(314, 267);
            this.picAk47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAk47.TabIndex = 7;
            this.picAk47.TabStop = false;
            this.picAk47.Visible = false;
            // 
            // picM4a1
            // 
            this.picM4a1.Image = ((System.Drawing.Image)(resources.GetObject("picM4a1.Image")));
            this.picM4a1.Location = new System.Drawing.Point(438, 107);
            this.picM4a1.Name = "picM4a1";
            this.picM4a1.Size = new System.Drawing.Size(314, 267);
            this.picM4a1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picM4a1.TabIndex = 8;
            this.picM4a1.TabStop = false;
            this.picM4a1.Visible = false;
            // 
            // picAug
            // 
            this.picAug.Image = ((System.Drawing.Image)(resources.GetObject("picAug.Image")));
            this.picAug.Location = new System.Drawing.Point(438, 107);
            this.picAug.Name = "picAug";
            this.picAug.Size = new System.Drawing.Size(314, 267);
            this.picAug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAug.TabIndex = 9;
            this.picAug.TabStop = false;
            this.picAug.Visible = false;
            // 
            // lblKillCount
            // 
            this.lblKillCount.AutoSize = true;
            this.lblKillCount.Location = new System.Drawing.Point(105, 85);
            this.lblKillCount.Name = "lblKillCount";
            this.lblKillCount.Size = new System.Drawing.Size(0, 13);
            this.lblKillCount.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "REMAINING AMMO :";
            // 
            // lblNewEnemies
            // 
            this.lblNewEnemies.AutoSize = true;
            this.lblNewEnemies.Location = new System.Drawing.Point(38, 248);
            this.lblNewEnemies.Name = "lblNewEnemies";
            this.lblNewEnemies.Size = new System.Drawing.Size(35, 13);
            this.lblNewEnemies.TabIndex = 13;
            this.lblNewEnemies.Text = "label4";
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Location = new System.Drawing.Point(577, 397);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(0, 13);
            this.lblAmmo.TabIndex = 14;
            // 
            // Rifles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.lblNewEnemies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKillCount);
            this.Controls.Add(this.picAug);
            this.Controls.Add(this.picM4a1);
            this.Controls.Add(this.picAk47);
            this.Controls.Add(this.picFamas);
            this.Controls.Add(this.lblWeaponName);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnFire);
            this.Name = "Rifles";
            this.Text = "Rifles";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rifles_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picFamas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAk47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM4a1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblWeaponName;
        private System.Windows.Forms.PictureBox picFamas;
        private System.Windows.Forms.PictureBox picAk47;
        private System.Windows.Forms.PictureBox picM4a1;
        private System.Windows.Forms.PictureBox picAug;
        private System.Windows.Forms.Label lblKillCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNewEnemies;
        private System.Windows.Forms.Label lblAmmo;
    }
}