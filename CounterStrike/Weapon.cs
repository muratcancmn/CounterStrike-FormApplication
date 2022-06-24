using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace CounterStrike
{
  abstract  class Weapon
    {
     
        public string Brand { get; set; }
        public int Weight { get; set; }
        public bool IsWeaponWithFire { get; set; }
        public int Damage { get; set; }
        public int KillCount { get; set; }
      
     public   abstract int GiveDamage(int enemyHealth);
        public abstract void Voice(string voice);
        public void deathSound() {
            SoundPlayer death = new SoundPlayer("Counter-Strike-1.6-Ölme-Sesi.wav");
            death.Play();
        }
    
    }
}