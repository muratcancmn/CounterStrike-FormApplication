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
    public partial class Shotguns : Form,IEnemy
    {
        public Shotguns()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Shotguns_KeyDown;
        }
        public int EnemyHealth { get; set; } = 100;
        bool didEnemyDied = false;
        int weaponNumber = 0;
        Heavy mag7 = new Heavy() {Ammo=5,Damage=30  };
        Heavy nova = new Heavy() { Ammo = 8, Damage = 26 };
        Heavy xm1014 = new Heavy() { Ammo = 7, Damage = 20 };
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
                    if (mag7.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                        mag7.Ammo = 5;
                    }
                    return;
                case 1:
                    if (nova.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                        nova.Ammo = 8;
                    }
                    return;
                case 2:
                    if (xm1014.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                        xm1014.Ammo = 7;
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
                        lblHealth.Text = (int.Parse(lblHealth.Text) - mag7.GiveDamage(EnemyHealth)).ToString();
                        mag7.Voice("CS-GO-Sound-Effects-_-MAG-7-Shotgun-Sound-Effect-_NEW_-__Trim.wav");
                        lblAmmo.Text = mag7.Ammo.ToString();                     
                            DeathActions(mag7);
                        return;
                    case 1:
                        lblHealth.Text = (int.Parse(lblHealth.Text) - nova.GiveDamage(EnemyHealth)).ToString();
                        nova.Voice("CS_GO-Nova-Green-Screen-overlay-Sound-Effect-_High-Quality__Trim.wav");
                        lblAmmo.Text = nova.Ammo.ToString();
                            DeathActions(nova);                      
                        return;
                    case 2:
                        lblHealth.Text = (int.Parse(lblHealth.Text) - xm1014.GiveDamage(EnemyHealth)).ToString();
                        xm1014.Voice("CS_GO-XM1014-Green-Screen-overlay-Sound-Effect-_High-Quality__Trim.wav");
                        lblAmmo.Text = xm1014.Ammo.ToString();             
                            DeathActions(xm1014);

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
        void DeathActions(Heavy silah)
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
        private void Shotguns_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.D0)
            {
                weaponNumber = 0;
                picMag.Visible = true;
                picNova.Visible = false;
                picXm.Visible = false;
                lblAmmo.Text = mag7.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "MAG7";
            }
            if (e.KeyCode==Keys.D1)
            {
                weaponNumber = 1;
                picMag.Visible = false;
                picNova.Visible = true;
                picXm.Visible = false;
                lblAmmo.Text = nova.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "Nova";
            }
            if (e.KeyCode==Keys.D2)
            {
                weaponNumber = 2;
                picMag.Visible = false;
                picNova.Visible = false;
                picXm.Visible = true;
                lblAmmo.Text = xm1014.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "XM1014";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Smgs f1 = new Smgs();
            f1.Show();
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
                    mag7.Ammo = 5;
                    lblAmmo.Text = mag7.Ammo.ToString();
                    return;
                case 1:
                    nova.Ammo = 8;
                    lblAmmo.Text = nova.Ammo.ToString();
                    return;
                case 2:
                   xm1014.Ammo = 7;
                    lblAmmo.Text = xm1014.Ammo.ToString();
                    return;
               
            }
        }
        #endregion
    }
}
