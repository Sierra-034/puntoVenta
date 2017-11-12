using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Punto_VentaTiendaComics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        int indexC = 0;
        Ventas v = new Ventas();

        //Método que remueve los controles dependiendo del control actual
        public void rControl(int index)
        {
            switch (index)
            {
                case 1:  Controls.Remove(v); 
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrHora.Start();
        }

        #region Botones del menú lateral
        // Este segmento  crea un control de  usuario en el panel2 

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            rControl(indexC);

            

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {  if (indexC != 1)
            {
                rControl(indexC);
                v.Location = new System.Drawing.Point(148, 93);
                v.Name = "cVenta";
                v.Size = new System.Drawing.Size(742, 414);
                v.BackColor = Color.Transparent;
                indexC = 1;
                Controls.Add(v);
                v.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rControl(indexC);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rControl(indexC);
            indexC = 2;

        }

        #endregion

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = Convert.ToString(DateTime.Now.Date.ToShortDateString());
            lbMin.Text = Convert.ToString( DateTime.Now.Minute);
            lbHora.Text = Convert.ToString(DateTime.Now.Hour);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
