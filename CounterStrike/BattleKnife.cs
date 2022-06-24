using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace CounterStrike
{
    class BattleKnife : Weapon,IKnifeProperty
    {
   
       
    
        public int StabCount { get; set; } 

        public override int GiveDamage(int enemyHealth)
        {
         
            enemyHealth = 45;

            return enemyHealth;
        }

        public void Stab()
        {
          
            StabCount -= 1;
           
          
        }
        public override void Voice(string voice)
        {
            SoundPlayer sound = new SoundPlayer(voice);
            sound.Play();        }
    }
}
