namespace aplastaos_los_colores
{
    partial class inventario_vendidofrm
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
            this.volver1btm = new System.Windows.Forms.Button();
            this.listavendidoscmb = new System.Windows.Forms.ComboBox();
            this.cantidadnwn = new System.Windows.Forms.NumericUpDown();
            this.agregarbtm = new System.Windows.Forms.Button();
            this.listainvlst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enviarbtm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listarestantes = new System.Windows.Forms.ListBox();
            this.cambiarvendidosbtm = new System.Windows.Forms.Button();
            this.eliminarvendidosbtm = new System.Windows.Forms.Button();
            this.cmbmodivendidos = new System.Windows.Forms.ComboBox();
            this.vendidoscambnwn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadnwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendidoscambnwn)).BeginInit();
            this.SuspendLayout();
            // 
            // volver1btm
            // 
            this.volver1btm.BackColor = System.Drawing.Color.Lime;
            this.volver1btm.Location = new System.Drawing.Point(594, 431);
            this.volver1btm.Name = "volver1btm";
            this.volver1btm.Size = new System.Drawing.Size(80, 39);
            this.volver1btm.TabIndex = 0;
            this.volver1btm.Text = "volver";
            this.volver1btm.UseVisualStyleBackColor = false;
            this.volver1btm.Click += new System.EventHandler(this.button1_Click);
            // 
            // listavendidoscmb
            // 
            this.listavendidoscmb.FormattingEnabled = true;
            this.listavendidoscmb.Items.AddRange(new object[] {
            "porcion de papas",
            "chuzo especial",
            "Chuzo sencillo",
            "combo 2",
            "combo 1",
            "picada",
            "salchipapas",
            "maicitos de pollo",
            "maicitos especiales",
            "maicitos sencillos",
            "wrap de carne ",
            "wrap de pollo",
            "hamburguesa mixta",
            "hamburguesa super especial ",
            "hamburguesa especial",
            "hamburguesa sencilla",
            "perro super especial",
            "perro especial",
            "perro sencillo",
            "aplastao mixto",
            "aplastao ropa vieja",
            "aplastao de pollo",
            "aplastao ranchero",
            "aplastao paisa",
            "aplastao salami",
            "aplastao hawaiano",
            "aplastao especial",
            "aplastao",
            "sencillo",
            "aplastao burguer",
            "gaseosas",
            "hits"});
            this.listavendidoscmb.Location = new System.Drawing.Point(12, 38);
            this.listavendidoscmb.Name = "listavendidoscmb";
            this.listavendidoscmb.Size = new System.Drawing.Size(288, 21);
            this.listavendidoscmb.TabIndex = 1;
            this.listavendidoscmb.Tag = "";
            this.listavendidoscmb.Text = "Seleccione el producto e ingrese cantidad vendida";
            // 
            // cantidadnwn
            // 
            this.cantidadnwn.Location = new System.Drawing.Point(327, 38);
            this.cantidadnwn.Name = "cantidadnwn";
            this.cantidadnwn.Size = new System.Drawing.Size(46, 20);
            this.cantidadnwn.TabIndex = 3;
            // 
            // agregarbtm
            // 
            this.agregarbtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.agregarbtm.Location = new System.Drawing.Point(63, 78);
            this.agregarbtm.Name = "agregarbtm";
            this.agregarbtm.Size = new System.Drawing.Size(66, 26);
            this.agregarbtm.TabIndex = 5;
            this.agregarbtm.Text = "Agregar";
            this.agregarbtm.UseVisualStyleBackColor = false;
            this.agregarbtm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listainvlst
            // 
            this.listainvlst.FormattingEnabled = true;
            this.listainvlst.Location = new System.Drawing.Point(12, 150);
            this.listainvlst.Name = "listainvlst";
            this.listainvlst.Size = new System.Drawing.Size(190, 251);
            this.listainvlst.TabIndex = 4;
            this.listainvlst.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Productos restantes";
            // 
            // enviarbtm
            // 
            this.enviarbtm.BackColor = System.Drawing.Color.Yellow;
            this.enviarbtm.Location = new System.Drawing.Point(249, 226);
            this.enviarbtm.Name = "enviarbtm";
            this.enviarbtm.Size = new System.Drawing.Size(64, 32);
            this.enviarbtm.TabIndex = 7;
            this.enviarbtm.Text = "calcular";
            this.enviarbtm.UseVisualStyleBackColor = false;
            this.enviarbtm.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Productos vendidos";
            // 
            // listarestantes
            // 
            this.listarestantes.FormattingEnabled = true;
            this.listarestantes.Location = new System.Drawing.Point(347, 150);
            this.listarestantes.Name = "listarestantes";
            this.listarestantes.Size = new System.Drawing.Size(190, 251);
            this.listarestantes.TabIndex = 9;
            // 
            // cambiarvendidosbtm
            // 
            this.cambiarvendidosbtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cambiarvendidosbtm.Location = new System.Drawing.Point(501, 78);
            this.cambiarvendidosbtm.Name = "cambiarvendidosbtm";
            this.cambiarvendidosbtm.Size = new System.Drawing.Size(70, 26);
            this.cambiarvendidosbtm.TabIndex = 10;
            this.cambiarvendidosbtm.Text = "Corregir";
            this.cambiarvendidosbtm.UseVisualStyleBackColor = false;
            this.cambiarvendidosbtm.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // eliminarvendidosbtm
            // 
            this.eliminarvendidosbtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eliminarvendidosbtm.Location = new System.Drawing.Point(158, 78);
            this.eliminarvendidosbtm.Name = "eliminarvendidosbtm";
            this.eliminarvendidosbtm.Size = new System.Drawing.Size(62, 26);
            this.eliminarvendidosbtm.TabIndex = 11;
            this.eliminarvendidosbtm.Text = "Eliminar";
            this.eliminarvendidosbtm.UseVisualStyleBackColor = false;
            this.eliminarvendidosbtm.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbmodivendidos
            // 
            this.cmbmodivendidos.FormattingEnabled = true;
            this.cmbmodivendidos.Items.AddRange(new object[] {
            "porcion de papas",
            "chuzo especial",
            "combo 2",
            "combo 1",
            "picada",
            "salchipapas",
            "maicitos de pollo",
            "maicitos especiales",
            "maicitos sencillos",
            "wrap de carne ",
            "wrap de pollo",
            "hamburguesa mixta",
            "hamburguesa super especial ",
            "hamburguesa especial",
            "hamburguesa sencilla",
            "perro super especial",
            "perro especial",
            "perro sencillo",
            "aplastao mixto",
            "aplastao ropa vieja",
            "aplastao de pollo",
            "aplastao ranchero",
            "aplastao paisa",
            "aplastao salami",
            "aplastao hawaiano",
            "aplastao especial",
            "aplastao",
            "sencillo",
            "aplastao burguer",
            "gaseosas",
            "hits"});
            this.cmbmodivendidos.Location = new System.Drawing.Point(437, 37);
            this.cmbmodivendidos.Name = "cmbmodivendidos";
            this.cmbmodivendidos.Size = new System.Drawing.Size(182, 21);
            this.cmbmodivendidos.TabIndex = 12;
            // 
            // vendidoscambnwn
            // 
            this.vendidoscambnwn.Location = new System.Drawing.Point(645, 37);
            this.vendidoscambnwn.Name = "vendidoscambnwn";
            this.vendidoscambnwn.Size = new System.Drawing.Size(40, 20);
            this.vendidoscambnwn.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Seleccionar item de la lista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cambiar por";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(226, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ver Stock";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // inventario_vendidofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vendidoscambnwn);
            this.Controls.Add(this.cmbmodivendidos);
            this.Controls.Add(this.eliminarvendidosbtm);
            this.Controls.Add(this.cambiarvendidosbtm);
            this.Controls.Add(this.listarestantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enviarbtm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agregarbtm);
            this.Controls.Add(this.listainvlst);
            this.Controls.Add(this.cantidadnwn);
            this.Controls.Add(this.listavendidoscmb);
            this.Controls.Add(this.volver1btm);
            this.Name = "inventario_vendidofrm";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.inventario_vendidofrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadnwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendidoscambnwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volver1btm;
        private System.Windows.Forms.ComboBox listavendidoscmb;
        private System.Windows.Forms.NumericUpDown cantidadnwn;
        private System.Windows.Forms.Button agregarbtm;
        private System.Windows.Forms.ListBox listainvlst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enviarbtm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cambiarvendidosbtm;
        private System.Windows.Forms.Button eliminarvendidosbtm;
        private System.Windows.Forms.ComboBox cmbmodivendidos;
        private System.Windows.Forms.NumericUpDown vendidoscambnwn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox listarestantes;
        private System.Windows.Forms.Button button1;
    }
}