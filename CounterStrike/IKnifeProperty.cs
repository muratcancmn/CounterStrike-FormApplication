using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    interface IKnifeProperty
    {
        int StabCount { get; set; }
        void Stab();
        
    }
}
