namespace aplastaos_los_colores
{
    partial class topesfrm
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
            this.topescmb = new System.Windows.Forms.ComboBox();
            this.topesnwn = new System.Windows.Forms.NumericUpDown();
            this.topeslist = new System.Windows.Forms.ListBox();
            this.agregartopebtm = new System.Windows.Forms.Button();
            this.modificartopebtm = new System.Windows.Forms.Button();
            this.eliminartopebtm = new System.Windows.Forms.Button();
            this.volverdetopesbtm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cambiarnwn = new System.Windows.Forms.NumericUpDown();
            this.cmbcambiarnombre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.topesnwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambiarnwn)).BeginInit();
            this.SuspendLayout();
            // 
            // topescmb
            // 
            this.topescmb.FormattingEnabled = true;
            this.topescmb.Items.AddRange(new object[] {
            "papas",
            "chuzos 250 gr",
            "arepas",
            "ensalada",
            "salchicha long zenu",
            "filete de pollo",
            "carne de hamburguesa 140 gr",
            "chorizo picado",
            "tocineta",
            "queso mozarella",
            "trozos de pollo",
            "tortilla bimbo",
            "jamon",
            "pan hamburguesa bimbo",
            "pan perro bimbo",
            "carne molida",
            "salchicha ranchera",
            "maicitos 200 gr",
            "pan de hamburguesa",
            "maicitos porciones",
            "salami",
            ""});
            this.topescmb.Location = new System.Drawing.Point(12, 42);
            this.topescmb.Name = "topescmb";
            this.topescmb.Size = new System.Drawing.Size(150, 21);
            this.topescmb.TabIndex = 0;
            this.topescmb.Text = "topes de items";
            // 
            // topesnwn
            // 
            this.topesnwn.Location = new System.Drawing.Point(177, 42);
            this.topesnwn.Name = "topesnwn";
            this.topesnwn.Size = new System.Drawing.Size(44, 20);
            this.topesnwn.TabIndex = 1;
            // 
            // topeslist
            // 
            this.topeslist.FormattingEnabled = true;
            this.topeslist.Location = new System.Drawing.Point(12, 135);
            this.topeslist.Name = "topeslist";
            this.topeslist.Size = new System.Drawing.Size(270, 303);
            this.topeslist.TabIndex = 2;
            // 
            // agregartopebtm
            // 
            this.agregartopebtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.agregartopebtm.Location = new System.Drawing.Point(47, 83);
            this.agregartopebtm.Name = "agregartopebtm";
            this.agregartopebtm.Size = new System.Drawing.Size(65, 30);
            this.agregartopebtm.TabIndex = 3;
            this.agregartopebtm.Text = "Agregar";
            this.agregartopebtm.UseVisualStyleBackColor = false;
            this.agregartopebtm.Click += new System.EventHandler(this.agregartopebtm_Click);
            // 
            // modificartopebtm
            // 
            this.modificartopebtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.modificartopebtm.Location = new System.Drawing.Point(335, 83);
            this.modificartopebtm.Name = "modificartopebtm";
            this.modificartopebtm.Size = new System.Drawing.Size(63, 35);
            this.modificartopebtm.TabIndex = 4;
            this.modificartopebtm.Text = "Corregir";
            this.modificartopebtm.UseVisualStyleBackColor = false;
            this.modificartopebtm.Click += new System.EventHandler(this.modificartopebtm_Click);
            // 
            // eliminartopebtm
            // 
            this.eliminartopebtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eliminartopebtm.Location = new System.Drawing.Point(135, 83);
            this.eliminartopebtm.Name = "eliminartopebtm";
            this.eliminartopebtm.Size = new System.Drawing.Size(63, 32);
            this.eliminartopebtm.TabIndex = 5;
            this.eliminartopebtm.Text = "Eliminar";
            this.eliminartopebtm.UseVisualStyleBackColor = false;
            this.eliminartopebtm.Click += new System.EventHandler(this.eliminartopebtm_Click);
            // 
            // volverdetopesbtm
            // 
            this.volverdetopesbtm.BackColor = System.Drawing.Color.Lime;
            this.volverdetopesbtm.Location = new System.Drawing.Point(619, 403);
            this.volverdetopesbtm.Name = "volverdetopesbtm";
            this.volverdetopesbtm.Size = new System.Drawing.Size(81, 35);
            this.volverdetopesbtm.TabIndex = 6;
            this.volverdetopesbtm.Text = "Volver";
            this.volverdetopesbtm.UseVisualStyleBackColor = false;
            this.volverdetopesbtm.Click += new System.EventHandler(this.volverdetopesbtm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cambiar por";
            // 
            // cambiarnwn
            // 
            this.cambiarnwn.Location = new System.Drawing.Point(506, 43);
            this.cambiarnwn.Name = "cambiarnwn";
            this.cambiarnwn.Size = new System.Drawing.Size(41, 20);
            this.cambiarnwn.TabIndex = 9;
            // 
            // cmbcambiarnombre
            // 
            this.cmbcambiarnombre.FormattingEnabled = true;
            this.cmbcambiarnombre.Items.AddRange(new object[] {
            "papas",
            "chuzos 250 gr",
            "arepas",
            "ensalada",
            "salchicha long zenu",
            "filete de pollo",
            "carne de hamburguesa 140 gr",
            "chorizo picado",
            "tocineta",
            "queso mozarella",
            "trozos de pollo",
            "tortilla bimbo",
            "jamon",
            "pan hamburguesa bimbo",
            "pan perro bimbo",
            "carne molida",
            "salchicha ranchera",
            "maicitos 200 gr",
            "pan de hamburguesa",
            "maicitos porciones",
            "salami"});
            this.cmbcambiarnombre.Location = new System.Drawing.Point(335, 42);
            this.cmbcambiarnombre.Name = "cmbcambiarnombre";
            this.cmbcambiarnombre.Size = new System.Drawing.Size(144, 21);
            this.cmbcambiarnombre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Seleccionar item de la lista";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(335, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // topesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbcambiarnombre);
            this.Controls.Add(this.cambiarnwn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volverdetopesbtm);
            this.Controls.Add(this.eliminartopebtm);
            this.Controls.Add(this.modificartopebtm);
            this.Controls.Add(this.agregartopebtm);
            this.Controls.Add(this.topeslist);
            this.Controls.Add(this.topesnwn);
            this.Controls.Add(this.topescmb);
            this.Name = "topesfrm";
            this.Text = "Topes";
            this.Load += new System.EventHandler(this.topesfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topesnwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambiarnwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox topescmb;
        private System.Windows.Forms.NumericUpDown topesnwn;
        private System.Windows.Forms.ListBox topeslist;
        private System.Windows.Forms.Button agregartopebtm;
        private System.Windows.Forms.Button modificartopebtm;
        private System.Windows.Forms.Button eliminartopebtm;
        private System.Windows.Forms.Button volverdetopesbtm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cambiarnwn;
        private System.Windows.Forms.ComboBox cmbcambiarnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}