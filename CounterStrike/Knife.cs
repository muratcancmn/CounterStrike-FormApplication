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
    public partial class Knife : Form,IEnemy
    {
        public Knife()
        {
            InitializeComponent();
        

            pictureBox1.Visible = true;
            pictureBox2.Visible = false;

        }
        int killCount = 0;
        public int EnemyHealth { get; set; } = 100;
        BattleKnife knife = new BattleKnife() { StabCount = 5 };
        bool didEnemyDied = false;
        private void btnKes_Click(object sender, EventArgs e)
        {
             Stabbing();
             knife.Stab();
            ShowGif();
        }
        #region ShowGİf
        /// <summary>
        /// Burada bıçaklama animasyonu yapılıyor.
        /// </summary>
        void ShowGif()
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

        }
        #endregion
        

        #region Stabbing
        /// <summary>
        /// Burada bıçak kullandığımızda gerçekleşecek olaylar gösteriliyor.
        /// </summary>
        void Stabbing()
        {
        
            if (knife.StabCount>0)
            {
                if (didEnemyDied)
                {
                    lblHealth.Text = 100.ToString();
                    didEnemyDied = false;

                }
                if (int.Parse(lblHealth.Text) > 0)
                {
                    lblHealth.Text =( Convert.ToInt32( lblHealth.Text )- knife.GiveDamage(EnemyHealth)).ToString()  ;
                    knife.Voice("Cs-Go-Bıçak-Sesi.wav");
                    lblNewEnemies.Text = "";
                    if (int.Parse(lblHealth.Text)<0)
                    {
                        lblHealth.Text = "ENEMY DIED";
                        knife.deathSound();
                      
                        killCount++;
                        lblKillCount.Text = " U KILLED  :" + killCount + "  ENEMIES";
                        lblNewEnemies.Text = "NEW ENEMIES ARE COMING";
                        didEnemyDied = true;
                    }
                }
                
                //else if(didEnemyDied==false & int.Parse( lblHealth.Text) <= 10 )
                //{

                  

                //}
               
            }

            else if (knife.StabCount <=0)
            {
                MessageBox.Show("Bıçağınızı bileyleyiniz");
            }
           
        }
        #endregion

        private void btnBiley_Click(object sender, EventArgs e)
        {
            Bileyle();
        }
        void Bileyle()
        {
            knife.StabCount = 5;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pistols f2 = new Pistols();
            f2.Show();
        }
    }

 
}

