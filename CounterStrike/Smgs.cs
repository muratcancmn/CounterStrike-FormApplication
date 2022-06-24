using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CounterStrike
{
    public partial class Smgs : Form,IEnemy
    {
        public Smgs()
        {
            InitializeComponent();
            this.KeyPreview=true;

            this.KeyDown += Smgs_KeyDown;
        }
        public int EnemyHealth { get; set; } = 100;
        bool didEnemyDied = false;
        int weaponNumber = 0;
        SMG mp7 = new SMG() { Ammo = 30, Damage = 29 };
        SMG mp9 = new SMG() { Ammo = 30, Damage = 26 };
        SMG ump45 = new SMG() { Ammo = 25, Damage = 35 };
        SMG p90 = new SMG() { Ammo = 50, Damage = 26 };
     
        private void btnFire_Click(object sender, EventArgs e)
        {
            FireWithReload();
        }

        #region FireWithReload
        /// <summary>
        /// Burada  hem ateş edilip hem de mermi kontrolü yapılıyor.
        /// </summary>
        void FireWithReload()
        {
            switch (weaponNumber)
            {
                case 0:
                    if (mp7.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                        mp7.Ammo = 5;
                    }
                    return;
                case 1:
                    if (mp9.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                       mp9.Ammo = 8;
                    }
                    return;
                case 2:
                    if (ump45.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                        ump45.Ammo = 7;
                    }
                    return;
                case 3:
                    if (p90.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                       p90.Ammo = 7;
                    }
                    return;
            }
        }
        #endregion

        #region Fire
        /// <summary>
        /// Burada ateş edilirken gerçekleşecek olaylar bulunuyor.
        /// </summary>
        void Fire()
        {
            if (didEnemyDied)
            {
                lblHealth.Text = 100.ToString();
                didEnemyDied = false;

            }
            if (int.Parse(lblHealth.Text) > 0)
            {
                switch (weaponNumber)
                {
                    case 0:
                        lblHealth.Text = (int.Parse(lblHealth.Text) - mp7.GiveDamage(EnemyHealth)).ToString();
                        mp7.Voice("MP7-_SMG_-Sound-Effect-_CSGO-Game-SFX__Trim.wav");
                        lblAmmo.Text = mp7.Ammo.ToString();
                        DeathActions(mp7);
                      
                        return;
                    case 1:
                        lblHealth.Text = (int.Parse(lblHealth.Text) - mp9.GiveDamage(EnemyHealth)).ToString();
                        mp9.Voice("CS_GO MP9 Green Screen overlay + Sound Effect [High Quality]_Trim.wav");
                        lblAmmo.Text = mp9.Ammo.ToString();
                        DeathActions(mp9);
                        return;
                    case 2:
                        lblHealth.Text = (int.Parse(lblHealth.Text) - ump45.GiveDamage(EnemyHealth)).ToString();
                        ump45.Voice("UMP-45 (SMG) - Sound Effect (CSGO Game SFX)_Trim.wav");
                        lblAmmo.Text = ump45.Ammo.ToString();
                        DeathActions(ump45);

                        return;
                    case 3:
                        lblHealth.Text = (int.Parse(lblHealth.Text) - p90.GiveDamage(EnemyHealth)).ToString();
                        p90.Voice("P90 Shooting Sound Effect CS_GO.wav");
                        lblAmmo.Text = p90.Ammo.ToString();
                        DeathActions(p90);
                        return;
                }
            }
          
        }
        #endregion

        #region DeahtActions
        /// <summary>
        /// Burada ateş edilirken düşman öldürülürse neler oalcağı gösteriliyor
        /// </summary>
        /// <param name="silah"></param>
        void DeathActions(SMG silah)
        {
            if (int.Parse(lblHealth.Text) <= 0)
            {
              
                silah.KillCount += 1;
                lblKillCount.Text = " U KILLED  :" + silah.KillCount + "  ENEMIES";
                
                lblHealth.Text = "ENEMY DIED";
                silah.deathSound();
                lblNewEnemies.Text = "NEW ENEMIES ARE COMING";
                didEnemyDied = true;

            }
           
        }
        #endregion

        private void Smgs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.D0)
            {
                weaponNumber = 0;
                picMp7.Visible = true;
                picMp9.Visible = false;
                picUmp.Visible = false;
                picP90.Visible = false;
                lblAmmo.Text = mp7.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "MP7";
            }
            if (e.KeyCode==Keys.D1)
            {
                weaponNumber = 1;
                picMp7.Visible = false;
                picMp9.Visible = true;
                picUmp.Visible = false;
                picP90.Visible = false;
                lblKillCount.Text = "";
                lblAmmo.Text = mp9.Ammo.ToString();              
                lblWeaponName.Text = "MP9";
            }
            if (e.KeyCode==Keys.D2)
            {
                weaponNumber = 2;
                picMp7.Visible = false;
                picMp9.Visible = false;
                picUmp.Visible = true;
                picP90.Visible = false;
                lblKillCount.Text = "";
                lblAmmo.Text = ump45.Ammo.ToString();
                lblWeaponName.Text = "UMP-45";
            }
            if (e.KeyCode==Keys.D3)
            {
                weaponNumber = 3;

                picMp7.Visible = false;
                picMp9.Visible = false;
                picUmp.Visible = false;
                picP90.Visible = true;
                lblKillCount.Text = "";
                lblAmmo.Text = p90.Ammo.ToString();
                lblWeaponName.Text = "P90";
            }
          
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        #region Reload
        /// <summary>
        /// Burada mermi değiştiriliyor.
        /// </summary>
        void Reload()
        {
            switch (weaponNumber)
            {
                case 0:
                    mp7.Ammo = 30;
                    return;
                case 1:
                    mp9.Ammo = 30;
                    return;
                case 2:
                    ump45.Ammo = 25;
                    return;
                case 3:
                    p90.Ammo = 50;
                    return;
            }
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rifles f1 = new Rifles();
            f1.Show();
        }
    }
}
