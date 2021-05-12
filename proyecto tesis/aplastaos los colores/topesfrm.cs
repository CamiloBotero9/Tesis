using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplastaos_los_colores
{
    public partial class topesfrm : Form
    {

        List<string> listatopes = new List<string>();


        public topesfrm()
        {
            InitializeComponent();
        }

        private void topesfrm_Load(object sender, EventArgs e)
        {

        }

        private void agregartopebtm_Click(object sender, EventArgs e)
        {
            string nombretope;
            nombretope = topescmb.Text;
            int cantidad;
            cantidad = Convert.ToInt32(topesnwn.Value);
            listatopes.Add(nombretope + " " + cantidad);


            topeslist.DataSource = null;
            topeslist.DataSource = listatopes;

         
            
        }

        private void volverdetopesbtm_Click(object sender, EventArgs e)
        {
            this.Hide();
            iniciofrm llamar = new iniciofrm();
            llamar.Show();
        }

        private void modificartopebtm_Click(object sender, EventArgs e)
        {

            int cantidadcambiar, cantidad;
            string nombre, nombrecambiar;
            nombre = topescmb.Text;
            nombrecambiar = cmbcambiarnombre.Text;
            cantidad = Convert.ToInt32(topesnwn.Value);
            cantidadcambiar = Convert.ToInt32(cambiarnwn.Value); 

            var indice = listatopes.IndexOf(nombre + " " + cantidad);
            listatopes.RemoveAt(indice);
            listatopes.Insert(indice,nombrecambiar + " " + cantidadcambiar);

            topeslist.DataSource = null;
            topeslist.DataSource = listatopes;
        }

        private void eliminartopebtm_Click(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = Convert.ToInt32(topesnwn.Value);
            listatopes.Remove(topescmb.Text + " " + cantidad );
            topeslist.DataSource = null; 
            topeslist.DataSource = listatopes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculoinventariofrm llama = new calculoinventariofrm();

            llama.caltopelist.Items.AddRange(topeslist.Items);

            llama.Show();

        }
    }
}
