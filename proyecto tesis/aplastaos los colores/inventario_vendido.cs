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
    public partial class inventario_vendidofrm : Form

    {

       static List<string> listaitems = new List<string>();
        

        public inventario_vendidofrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            iniciofrm llamar = new iniciofrm();
            llamar.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         

            string nombre;
            nombre = listavendidoscmb.Text;
            int cantidad;
            cantidad = Convert.ToInt32(cantidadnwn.Value);
            listaitems.Add(nombre + " " + cantidad);

            listainvlst.DataSource = null;
            listainvlst.DataSource = listaitems;

           
            
        }

        private void inventario_vendidofrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            calculoinventariofrm llamar = new calculoinventariofrm();

            llamar.calculolst.Items.AddRange(listainvlst.Items);

            llamar.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = Convert.ToInt32(cantidadnwn.Value);
            listaitems.Remove(listavendidoscmb.Text + " " + cantidad);
            listainvlst.DataSource = null;
            listainvlst.DataSource = listaitems;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            int cantidadcambiar, cantidad;
            string nombre, nombrecambiar;
            nombre = listavendidoscmb.Text;
            nombrecambiar = cmbmodivendidos.Text;
            cantidad = Convert.ToInt32(cantidadnwn.Value);
            cantidadcambiar = Convert.ToInt32(vendidoscambnwn.Value);

            var indice = listaitems.IndexOf(nombre + " " + cantidad);
            listaitems.RemoveAt(indice);
            listaitems.Insert(indice,nombrecambiar + " " + cantidadcambiar);

            listainvlst.DataSource = null;
            listainvlst.DataSource = listaitems;
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            stockfrm llamar = new stockfrm();
            llamar.Show();
            this.Close();
        }
    }
}
