namespace Punto_VentaTiendaComics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gridBuscador = new System.Windows.Forms.DataGridView();
            this.tmrMenu = new System.Windows.Forms.Timer(this.components);
            this.panelScroll = new System.Windows.Forms.Panel();
            this.panelScrollDown = new System.Windows.Forms.Panel();
            this.panelScrollUp = new System.Windows.Forms.Panel();
            this.lbBien = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscador)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnInv);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.btnRec);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Location = new System.Drawing.Point(1, 116);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 314);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Leave += new System.EventHandler(this.panelMenu_Leave);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackgroundImage = global::Punto_VentaTiendaComics.Properties.Resources.fondoB;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVentas.Image = global::Punto_VentaTiendaComics.Properties.Resources.Selpng;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(3, 10);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(145, 40);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnInv
            // 
            this.btnInv.BackColor = System.Drawing.Color.Transparent;
            this.btnInv.BackgroundImage = global::Punto_VentaTiendaComics.Properties.Resources.fondoB;
            this.btnInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInv.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnInv.FlatAppearance.BorderSize = 0;
            this.btnInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInv.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInv.Image = global::Punto_VentaTiendaComics.Properties.Resources.Selpng;
            this.btnInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInv.Location = new System.Drawing.Point(3, 70);
            this.btnInv.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(145, 40);
            this.btnInv.TabIndex = 2;
            this.btnInv.Text = "Inventario";
            this.btnInv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInv.UseVisualStyleBackColor = false;
            this.btnInv.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Punto_VentaTiendaComics.Properties.Resources.fondoB;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = global::Punto_VentaTiendaComics.Properties.Resources.Selpng;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 130);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Apartado";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRec
            // 
            this.btnRec.BackColor = System.Drawing.Color.Transparent;
            this.btnRec.BackgroundImage = global::Punto_VentaTiendaComics.Properties.Resources.fondoB;
            this.btnRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRec.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnRec.FlatAppearance.BorderSize = 0;
            this.btnRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRec.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRec.Image = global::Punto_VentaTiendaComics.Properties.Resources.Selpng;
            this.btnRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRec.Location = new System.Drawing.Point(3, 190);
            this.btnRec.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(145, 40);
            this.btnRec.TabIndex = 4;
            this.btnRec.Text = "Recordatorios";
            this.btnRec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRec.UseVisualStyleBackColor = false;
            this.btnRec.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImage = global::Punto_VentaTiendaComics.Properties.Resources.fondoB;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Image = global::Punto_VentaTiendaComics.Properties.Resources.Selpng;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 250);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(141, 49);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbMin);
            this.panel1.Controls.Add(this.lbHora);
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 94);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(291, 60);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(31, 26);
            this.lbMin.TabIndex = 5;
            this.lbMin.Text = "12";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(244, 60);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(31, 26);
            this.lbHora.TabIndex = 4;
            this.lbHora.Text = "12";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(146, 39);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(47, 20);
            this.lbFecha.TabIndex = 3;
            this.lbFecha.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "SilverFang Cosamaloapan, Ver";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(148, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 2;
            // 
            // tmrHora
            // 
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // gridDatos
            // 
            this.gridDatos.AllowUserToAddRows = false;
            this.gridDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDatos.BackgroundColor = System.Drawing.Color.White;
            this.gridDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridDatos.Location = new System.Drawing.Point(3, 32);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.Size = new System.Drawing.Size(320, 96);
            this.gridDatos.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(3, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 23);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "Busque un producto";
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::Punto_VentaTiendaComics.Properties.Resources.fondoB;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::Punto_VentaTiendaComics.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(188, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.txtBuscar);
            this.flowLayoutPanel2.Controls.Add(this.btnBuscar);
            this.flowLayoutPanel2.Controls.Add(this.gridDatos);
            this.flowLayoutPanel2.Controls.Add(this.gridBuscador);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(225, 109);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(323, 584);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // gridBuscador
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBuscador.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridBuscador.BackgroundColor = System.Drawing.Color.White;
            this.gridBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBuscador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridBuscador.Location = new System.Drawing.Point(3, 134);
            this.gridBuscador.Name = "gridBuscador";
            this.gridBuscador.Size = new System.Drawing.Size(320, 308);
            this.gridBuscador.TabIndex = 3;
            // 
            // tmrMenu
            // 
            this.tmrMenu.Interval = 300;
            this.tmrMenu.Tick += new System.EventHandler(this.tmrMenu_Tick);
            // 
            // panelScroll
            // 
            this.panelScroll.BackColor = System.Drawing.Color.Transparent;
            this.panelScroll.Location = new System.Drawing.Point(156, 116);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(10, 319);
            this.panelScroll.TabIndex = 7;
            this.panelScroll.Visible = false;
            this.panelScroll.MouseEnter += new System.EventHandler(this.panelScroll_MouseEnter);
            // 
            // panelScrollDown
            // 
            this.panelScrollDown.BackColor = System.Drawing.Color.Transparent;
            this.panelScrollDown.Location = new System.Drawing.Point(1, 438);
            this.panelScrollDown.Name = "panelScrollDown";
            this.panelScrollDown.Size = new System.Drawing.Size(164, 10);
            this.panelScrollDown.TabIndex = 8;
            this.panelScrollDown.Visible = false;
            this.panelScrollDown.MouseEnter += new System.EventHandler(this.panelScrollDown_MouseEnter);
            // 
            // panelScrollUp
            // 
            this.panelScrollUp.BackColor = System.Drawing.Color.Transparent;
            this.panelScrollUp.Location = new System.Drawing.Point(3, 103);
            this.panelScrollUp.Name = "panelScrollUp";
            this.panelScrollUp.Size = new System.Drawing.Size(162, 10);
            this.panelScrollUp.TabIndex = 9;
            this.panelScrollUp.Visible = false;
            this.panelScrollUp.MouseEnter += new System.EventHandler(this.panelScrollUp_MouseEnter);
            // 
            // lbBien
            // 
            this.lbBien.AutoSize = true;
            this.lbBien.BackColor = System.Drawing.Color.Transparent;
            this.lbBien.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBien.ForeColor = System.Drawing.Color.White;
            this.lbBien.Location = new System.Drawing.Point(685, 141);
            this.lbBien.Name = "lbBien";
            this.lbBien.Size = new System.Drawing.Size(520, 117);
            this.lbBien.TabIndex = 10;
            this.lbBien.Text = "¡Bienvenido";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.White;
            this.lbUser.Location = new System.Drawing.Point(834, 269);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(478, 117);
            this.lbUser.TabIndex = 11;
            this.lbUser.Text = "Username!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Punto_VentaTiendaComics.Properties.Resources.x2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1362, 705);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbBien);
            this.Controls.Add(this.panelScrollUp);
            this.Controls.Add(this.panelScrollDown);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelScroll);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(16, 39);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.DataGridView gridDatos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView gridBuscador;
        private System.Windows.Forms.Timer tmrMenu;
        private System.Windows.Forms.Panel panelScroll;
        private System.Windows.Forms.Panel panelScrollDown;
        private System.Windows.Forms.Panel panelScrollUp;
        private System.Windows.Forms.Label lbBien;
        private System.Windows.Forms.Label lbUser;
    }
}

