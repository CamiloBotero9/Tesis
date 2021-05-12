namespace aplastaos_los_colores
{
    partial class iniciofrm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inventariobtm = new System.Windows.Forms.Button();
            this.topesbtm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Mistral", 53.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(65, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyecto Tesis";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inventariobtm
            // 
            this.inventariobtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.inventariobtm.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventariobtm.Location = new System.Drawing.Point(98, 321);
            this.inventariobtm.Name = "inventariobtm";
            this.inventariobtm.Size = new System.Drawing.Size(118, 36);
            this.inventariobtm.TabIndex = 1;
            this.inventariobtm.Text = "Inventario";
            this.inventariobtm.UseVisualStyleBackColor = false;
            this.inventariobtm.Click += new System.EventHandler(this.inventariobtm_Click);
            // 
            // topesbtm
            // 
            this.topesbtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.topesbtm.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topesbtm.Location = new System.Drawing.Point(321, 321);
            this.topesbtm.Name = "topesbtm";
            this.topesbtm.Size = new System.Drawing.Size(118, 36);
            this.topesbtm.TabIndex = 2;
            this.topesbtm.Text = "Topes";
            this.topesbtm.UseVisualStyleBackColor = false;
            this.topesbtm.Click += new System.EventHandler(this.topesbtm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(534, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Finanzas";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // iniciofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topesbtm);
            this.Controls.Add(this.inventariobtm);
            this.Controls.Add(this.label1);
            this.Name = "iniciofrm";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inventariobtm;
        private System.Windows.Forms.Button topesbtm;
        private System.Windows.Forms.Button button1;
    }
}

