namespace Aplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.Central = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnMaximi = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SubMenu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnGanaciaDia = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            this.Central.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.Black;
            this.BarraTitulo.Controls.Add(this.pictureBox1);
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.BtnMaximi);
            this.BarraTitulo.Controls.Add(this.BtnMinimizar);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 35);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.Gold;
            this.MenuVertical.Controls.Add(this.SubMenu);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.BtnVentas);
            this.MenuVertical.Controls.Add(this.BtnProductos);
            this.MenuVertical.Controls.Add(this.LblNombre);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 35);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 615);
            this.MenuVertical.TabIndex = 1;
            // 
            // Central
            // 
            this.Central.BackColor = System.Drawing.Color.Goldenrod;
            this.Central.Controls.Add(this.panel3);
            this.Central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Central.Location = new System.Drawing.Point(220, 35);
            this.Central.Name = "Central";
            this.Central.Size = new System.Drawing.Size(1080, 615);
            this.Central.TabIndex = 2;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1263, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(1201, 4);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 1;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnMaximi
            // 
            this.BtnMaximi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximi.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximi.Image")));
            this.BtnMaximi.Location = new System.Drawing.Point(1232, 3);
            this.BtnMaximi.Name = "BtnMaximi";
            this.BtnMaximi.Size = new System.Drawing.Size(25, 25);
            this.BtnMaximi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximi.TabIndex = 2;
            this.BtnMaximi.TabStop = false;
            this.BtnMaximi.Click += new System.EventHandler(this.BtnMaximi_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1232, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1232, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(12, 16);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(180, 25);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "EXOTIC FOOD";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblNombre.Click += new System.EventHandler(this.LblNombre_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.BackColor = System.Drawing.Color.Gold;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.Color.White;
            this.BtnProductos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductos.Image")));
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(3, 55);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(214, 35);
            this.BtnProductos.TabIndex = 1;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 35);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 35);
            this.panel2.TabIndex = 4;
            // 
            // BtnVentas
            // 
            this.BtnVentas.BackColor = System.Drawing.Color.Gold;
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.White;
            this.BtnVentas.Image = ((System.Drawing.Image)(resources.GetObject("BtnVentas.Image")));
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(3, 111);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(214, 35);
            this.BtnVentas.TabIndex = 3;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = false;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 615);
            this.panel3.TabIndex = 5;
            // 
            // SubMenu
            // 
            this.SubMenu.Controls.Add(this.panel5);
            this.SubMenu.Controls.Add(this.BtnGanaciaDia);
            this.SubMenu.Location = new System.Drawing.Point(66, 152);
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(151, 91);
            this.SubMenu.TabIndex = 5;
            this.SubMenu.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 28);
            this.panel5.TabIndex = 6;
            // 
            // BtnGanaciaDia
            // 
            this.BtnGanaciaDia.BackColor = System.Drawing.Color.Gold;
            this.BtnGanaciaDia.FlatAppearance.BorderSize = 0;
            this.BtnGanaciaDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnGanaciaDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGanaciaDia.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGanaciaDia.ForeColor = System.Drawing.Color.White;
            this.BtnGanaciaDia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGanaciaDia.Location = new System.Drawing.Point(3, 3);
            this.BtnGanaciaDia.Name = "BtnGanaciaDia";
            this.BtnGanaciaDia.Size = new System.Drawing.Size(148, 28);
            this.BtnGanaciaDia.TabIndex = 5;
            this.BtnGanaciaDia.Text = "Ganancia día";
            this.BtnGanaciaDia.UseVisualStyleBackColor = false;
            this.BtnGanaciaDia.Click += new System.EventHandler(this.BtnGanaciaDia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.Central);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.Central.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel Central;
        private System.Windows.Forms.PictureBox BtnMaximi;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SubMenu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnGanaciaDia;
    }
}

