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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Knife f1 = new Knife();
            f1.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Play butonuna bastıktan sonra bıçaktan snipera kadar formlar arasındaki butonlar ile geçiş yapabilirsiniz. Ayrıca silahlar arasında numlock üzerindeki tuşlar  aracılığıyla geçiş yapabilirsiniz. İyi Oyunlaar ");
        }
    }
}
