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
    public partial class Pistols : Form, IEnemy
    {
        public Pistols()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Pistols_KeyDown;
            picUsp.Visible = true;

        }


        bool didEnemyDied = false;
        int weaponNumber = 0;
        Pistol usps = new Pistol() { Ammo = 12, Damage = 35 };
        Pistol p250 = new Pistol() { Ammo = 13, Damage = 38 };
        Pistol glock = new Pistol() { Ammo = 20, Damage = 30 };
        Pistol deagle = new Pistol() { Ammo = 7, Damage = 63 };

        public int EnemyHealth { get; set; } = 100;

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
                    if (usps.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                    }
                    return;
                case 1:
                    if (p250.Ammo>0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                    }
                    return;
                case 2:
                    if (glock.Ammo>0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                    }
                    return;
                case 3:
                    if (deagle.Ammo>0)
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
                            lblHealth.Text = (int.Parse(lblHealth.Text) - usps.GiveDamage(EnemyHealth)).ToString();
                        usps.Voice("Original USP-S Firing Sound effect.wav");
                        lblAmmo.Text = usps.Ammo.ToString();
                            DeathActions(usps);

                     
                            return;
                        case 1:
                            lblHealth.Text = (int.Parse(lblHealth.Text) - p250.GiveDamage(EnemyHealth)).ToString();                       
                        p250.Voice("Csgo-P250-Firing-sound-effect.wav");
                        lblAmmo.Text = p250.Ammo.ToString();
                            DeathActions(p250);
                      
                        return;
                        case 2:
                            lblHealth.Text = (int.Parse(lblHealth.Text) - glock.GiveDamage(EnemyHealth)).ToString();
                        glock.Voice("Csgo-Glock-Firing-Sound-effect.wav");
                        lblAmmo.Text = glock.Ammo.ToString();

                            DeathActions(glock);


                        return;
                        case 3:
                            lblHealth.Text = (int.Parse(lblHealth.Text) - deagle.GiveDamage(EnemyHealth)).ToString();
                        deagle.Voice("Csgo-Desert-Eagle-Firing-sound-effect.wav");
                        lblAmmo.Text = deagle.Ammo.ToString();

                            DeathActions(deagle);
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
        void DeathActions(Pistol silah)
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
                    usps.Ammo = 12;
                    lblAmmo.Text = usps.Ammo.ToString();
                    return;
                case 1:
                    p250.Ammo =13;
                    lblAmmo.Text = p250.Ammo.ToString();
                    return;
                case 2:
                    glock.Ammo = 20;
                    lblAmmo.Text = glock.Ammo.ToString();
                    return;
                case 3:
                    deagle.Ammo = 7;
                    lblAmmo.Text = deagle.Ammo.ToString();
                    return;

            }
        }
        #endregion
        private void Pistols_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.D0)
            {
                picUsp.Visible = true;
                picP250.Visible = false;
                picGlock.Visible = false;
                picDeagle.Visible = false;
                weaponNumber = 0;
                lblAmmo.Text = usps.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "USP-S";
            }
            if (e.KeyCode==Keys.D1)
            {
                picUsp.Visible = false;
                picP250.Visible = true;
                picGlock.Visible = false;
                picDeagle.Visible = false;
                weaponNumber = 1;
                lblAmmo.Text = p250.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "p250";
            }
            if (e.KeyCode==Keys.D2)
            {
                picUsp.Visible = false;
                picP250.Visible = false;
                picGlock.Visible = true;
                picDeagle.Visible = false;
                weaponNumber = 2;
                lblAmmo.Text = glock.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "GLOCK";
            }
            if (e.KeyCode==Keys.D3)
            {
                picUsp.Visible = false;
                picP250.Visible = false;
                picGlock.Visible = false;
                picDeagle.Visible = true;
                weaponNumber = 3;
                lblAmmo.Text = deagle.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "DEAGLE";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shotguns f1 = new Shotguns();
            f1.Show();
        }
    }
}
