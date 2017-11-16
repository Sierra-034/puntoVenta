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
            this.Height = Screen.PrimaryScreen.Bounds.Height - 40;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
                



        }

        int indexC = 0;
        //instancias de los controles de Usuario para las opciones del menú
        Ventas ventas = new Ventas();
        AddUser usuarios = new AddUser();
        Apartado apartado = new Apartado();

        //Método que remueve los controles dependiendo del control actual
    

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrHora.Start();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = Convert.ToString(DateTime.Now.Date.ToShortDateString());
            lbMin.Text =  Convert.ToString(DateTime.Now.Minute);
            lbHora.Text = Convert.ToString(DateTime.Now.Hour);
            if (panelMenu.Focused) { panelMenu.Width = 150; }
            
        }

        #region Botones del menú lateral

        public void rControl(int index)
        {
            switch (index)
            {
                case 1:
                    eliminarLb();
                     Controls.Remove(ventas); 
                    break;

                case 3:
                    eliminarLb();
                    Controls.Remove(apartado);
                    break;

                case 5:
                    eliminarLb();
                    Controls.Remove(usuarios);
                    break;
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            if (indexC != 5)
            {
                rControl(indexC);
                usuarios.Location = new System.Drawing.Point(580, 12);
                usuarios.Name = "cUser";
                usuarios.Size = new System.Drawing.Size(828, 681);
                usuarios.BackColor = Color.Transparent;
                indexC = 5;
                Controls.Add(usuarios);
                usuarios.BringToFront();
              

            }

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {  if (indexC != 1)
            {
                rControl(indexC);
                ventas.Location = new System.Drawing.Point(580, 12);
                ventas.Name = "cVenta";
                ventas.Size = new System.Drawing.Size(828, 681);
                ventas.BackColor = Color.Transparent;
                indexC = 1;
                Controls.Add(ventas);
                ventas.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (indexC != 4)
            {
                rControl(indexC);
                indexC = 4;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (indexC != 2)
            {
                rControl(indexC);
                indexC = 2;
            }
        }

   private void button3_Click(object sender, EventArgs e)
        {
            if(indexC!=3)
            {
                rControl(indexC);
                apartado.Location = new System.Drawing.Point(580, 12);
                apartado.Name = "cApartado";
                apartado.Size = new System.Drawing.Size(828, 681);
                apartado.BackColor = Color.Transparent;
                indexC = 3;
                Controls.Add(apartado);
                ventas.BringToFront();
            }
        }

        #endregion


        #region Movimiento del menú

        private void tmrMenu_Tick(object sender, EventArgs e)
        {

           panelMenu.Width = 0;
            panelScroll.Visible = true;
            panelScrollUp.Visible = true;
            panelScrollDown.Visible = true;
            tmrMenu.Stop();

        }        

        private void panelMenu_Leave(object sender, EventArgs e)
        {
            tmrMenu.Start();
          
        }

        private void panelScroll_MouseEnter(object sender, EventArgs e)
        {
            mostrarMenu();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            tmrMenu.Start();
            txtBuscar.Focus();
            txtBuscar.Text = "";
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            tmrMenu.Start();
            txtBuscar.Focus();
        }

        public void mostrarMenu() {

            tmrMenu.Stop();
            panelMenu.Width = 150;
            panelScroll.Visible = false;
            panelScrollUp.Visible = false;
            panelScrollDown.Visible = false;
            panelMenu.Focus();
        }    

        private void panelScrollDown_MouseEnter(object sender, EventArgs e)
        {
            mostrarMenu();
        }

        private void panelScrollUp_MouseEnter(object sender, EventArgs e)
        {
            mostrarMenu();
        }

        public void eliminarLb()
        {
            lbBien.Visible = false; lbUser.Visible = false;
        }

        #endregion


  
        
    }
}
