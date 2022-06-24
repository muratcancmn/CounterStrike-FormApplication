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
    public partial class Rifles : Form,IEnemy
    {
        public Rifles()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Rifles_KeyDown;
        }
        public int EnemyHealth { get; set; } = 100;
        bool didEnemyDied = false;
        int weaponNumber = 0;
        Rifle famas = new Rifle() { Ammo = 25, Damage = 30 };
        Rifle ak47 = new Rifle() { Ammo = 30, Damage = 36 };
        Rifle m4a1s = new Rifle() { Ammo = 20, Damage = 33 };
        Rifle aug = new Rifle() { Ammo = 30, Damage = 28 };
        private void btnFire_Click(object sender, EventArgs e)
        {
            FireWithReaload();
        }

        #region FireWithReload
        /// <summary>
        /// Burada  hem ateş edilip hem de mermi kontrolü yapılıyor.
        /// </summary>
        void FireWithReaload() 
        {
            switch (weaponNumber)
            {
                case 0:
                    if (famas.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                       famas.Ammo = 5;
                    }
                    return;
                case 1:
                    if (ak47.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                        ak47.Ammo = 8;
                    }
                    return;
                case 2:
                    if (m4a1s.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                        m4a1s.Ammo = 7;
                    }
                    return;
                case 3:
                    if (aug.Ammo > 0)
                    {
                        Fire();
                    }
                    else
                    {

                        MessageBox.Show("Mermi değiştiriniz");
                        aug.Ammo = 7;
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
                        lblHealth.Text = (int.Parse(lblHealth.Text) - famas.GiveDamage(EnemyHealth)).ToString();
                        famas.Voice("Famas Sound Effect CS_GO (shoot).wav");
                        lblAmmo.Text = famas.Ammo.ToString();
                        DeathActions(famas);
                        return;
                    case 1:
                        lblHealth.Text = (int.Parse(lblHealth.Text) - ak47.GiveDamage(EnemyHealth)).ToString();
                        ak47.Voice("Csgo Ak-47 Firing Sound effect (Single Shot).wav");
                        lblAmmo.Text = ak47.Ammo.ToString();
                        DeathActions(ak47);
                        return;
                    case 2:
                        lblHealth.Text = (int.Parse(lblHealth.Text) - m4a1s.GiveDamage(EnemyHealth)).ToString();
                        m4a1s.Voice("Csgo M4A1-S Firing Sound effect.wav");
                        lblAmmo.Text = m4a1s.Ammo.ToString();
                        DeathActions(m4a1s);
                        return;
                    case 3:
                        lblHealth.Text = (int.Parse(lblHealth.Text) - aug.GiveDamage(EnemyHealth)).ToString();
                        aug.Voice("CS_GO AUG Green Screen overlay + Sound Effect [High Quality]_Trim.wav");
                        lblAmmo.Text = aug.Ammo.ToString();
                        DeathActions(aug);
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
        void DeathActions(Rifle silah)
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
        private void Rifles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.D0)
            {
                weaponNumber = 0;
                picFamas.Visible = true;
                picAk47.Visible =false;
                picAug.Visible = false;
                picM4a1.Visible = false;
                lblAmmo.Text = famas.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "FAMAS";
            }
            if (e.KeyCode == Keys.D1)
            {
                weaponNumber = 1;
                picFamas.Visible = false;
                picAk47.Visible = true;
                picAug.Visible = false;
                picM4a1.Visible = false;
                lblAmmo.Text = ak47.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "AK-47";
            }
            if (e.KeyCode == Keys.D2)
            {
                weaponNumber = 2;
                picAk47.Visible = false;
                picM4a1.Visible = true;
                picAug.Visible = false;
                picFamas.Visible = false;
                lblAmmo.Text = m4a1s.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "M4A1-S";
            }
            if (e.KeyCode == Keys.D3)
            {
                weaponNumber = 3;
                picM4a1.Visible = false;
                picAug.Visible = true;
                picFamas.Visible = false;
                picAk47.Visible = false;
                lblAmmo.Text = aug.Ammo.ToString();
                lblKillCount.Text = "";
                lblWeaponName.Text = "AUG";
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
                    famas.Ammo = 25;
                    lblAmmo.Text = famas.Ammo.ToString();
                    return;
                case 1:
                    ak47.Ammo = 30;
                    lblAmmo.Text = ak47.Ammo.ToString();
                    return;
                case 2:
                    m4a1s.Ammo = 20;
                    lblAmmo.Text = m4a1s.Ammo.ToString();
                    return;
                case 3:
                    aug.Ammo = 30;
                    lblAmmo.Text = aug.Ammo.ToString();
                    return;
            }
        }
        #endregion
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snipers f1 = new Snipers();
            f1.Show();
        }
    }
}
