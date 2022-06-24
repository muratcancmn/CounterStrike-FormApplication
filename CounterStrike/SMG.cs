using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace CounterStrike
{
    class SMG:Weapon,IFireArm
    {
        public double Ammo { get ; set; }

        public override int GiveDamage(int enemyHealth)
        {
            enemyHealth = Damage;
            Ammo -= 1;
            return enemyHealth;
        }
        public override void Voice(string voice)
        {
            SoundPlayer sound = new SoundPlayer(voice);
            sound.Play();
        }

    }
}
