using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_VentaTiendaComics
{
    public partial class SplashScreen : Form
    {
        Form1 form = new Form1();
        
        int x = 0;
        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();
           
        }

        private void picSplash_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = x + 1;
            if (x > 5) { timer1.Stop();   this.Hide(); form.Show(this); }

        }
    }
}
