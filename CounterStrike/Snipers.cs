using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterStrike
{
    public partial class Snipers : Form,IEnemy
    {
        public Snipers()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Snipers_KeyDown;
        }
        public int EnemyHealth { get; set; } = 100;
        bool didEnemyDied = false;
        int weaponNumber = 0;
        Sniper ssg08 = new Sniper() { Ammo = 10, Damage = 88 };
        Sniper awp = new Sniper() { Ammo = 10, Damage = 115 };

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
                    if (ssg08.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                     
                    }
                    return;
                case 1:
                    if (awp.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                       
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
                        lblHealth.Text = (int.Parse(lblHealth.Text) - ssg08.GiveDamage(EnemyHealth)).ToString();
                        ssg08.Voice("SSG 08_SCOUT Shoot Sound Effect _ CSGO.wav");
                        lblAmmo.Text = ssg08.Ammo.ToString();
                        DeathActions(ssg08);
                        return;
                    case 1:
                        lblHealth.Text = (int.Parse(lblHealth.Text) - awp.GiveDamage(EnemyHealth)).ToString();
                        awp.Voice("AWP Shoot Sound Effect _ CSGO.wav");
                        lblAmmo.Text = awp.Ammo.ToString();
                        DeathActions(awp);
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
        void DeathActions(Sniper silah)
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
        private void Snipers_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D0)
            {
                weaponNumber = 0;
                picSsg.Visible = true;
                picAwp.Visible = false;
                lblAmmo.Text = ssg08.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "SSG08";
            }
            if (e.KeyCode == Keys.D1)
            {
                weaponNumber = 1;
                picSsg.Visible = false;
                picAwp.Visible = true;
                lblAmmo.Text = awp.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "AWP";
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
                   ssg08.Ammo = 10;
                    lblAmmo.Text = ssg08.Ammo.ToString();
                    
                    return;
                case 1:
                    awp.Ammo = 10;
                    lblAmmo.Text = awp.Ammo.ToString();
                    return;
                

            }
        }
        #endregion
    }
}
