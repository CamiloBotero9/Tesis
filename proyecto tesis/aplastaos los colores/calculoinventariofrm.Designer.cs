namespace aplastaos_los_colores
{
    partial class calculoinventariofrm
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
            this.calculolst = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.caltopelist = new System.Windows.Forms.ListBox();
            this.resultadocalculo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemsvendidoslist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // calculolst
            // 
            this.calculolst.FormattingEnabled = true;
            this.calculolst.Location = new System.Drawing.Point(24, 34);
            this.calculolst.Name = "calculolst";
            this.calculolst.Size = new System.Drawing.Size(153, 225);
            this.calculolst.TabIndex = 0;
            this.calculolst.SelectedIndexChanged += new System.EventHandler(this.calculolst_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // caltopelist
            // 
            this.caltopelist.FormattingEnabled = true;
            this.caltopelist.Location = new System.Drawing.Point(198, 34);
            this.caltopelist.Name = "caltopelist";
            this.caltopelist.Size = new System.Drawing.Size(162, 225);
            this.caltopelist.TabIndex = 2;
            // 
            // resultadocalculo
            // 
            this.resultadocalculo.FormattingEnabled = true;
            this.resultadocalculo.Location = new System.Drawing.Point(636, 34);
            this.resultadocalculo.Name = "resultadocalculo";
            this.resultadocalculo.Size = new System.Drawing.Size(152, 225);
            this.resultadocalculo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vendidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "topes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Productos vendidos (items)";
            // 
            // itemsvendidoslist
            // 
            this.itemsvendidoslist.FormattingEnabled = true;
            this.itemsvendidoslist.Location = new System.Drawing.Point(392, 34);
            this.itemsvendidoslist.Name = "itemsvendidoslist";
            this.itemsvendidoslist.Size = new System.Drawing.Size(151, 225);
            this.itemsvendidoslist.TabIndex = 8;
            // 
            // calculoinventariofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemsvendidoslist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultadocalculo);
            this.Controls.Add(this.caltopelist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calculolst);
            this.Name = "calculoinventariofrm";
            this.Text = "calculoinventariofrm";
            this.Load += new System.EventHandler(this.calculoinventariofrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox calculolst;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox caltopelist;
        private System.Windows.Forms.ListBox resultadocalculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox itemsvendidoslist;
    }
}