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
    public partial class iniciofrm : Form
    {
        public iniciofrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void inventariobtm_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventario_vendidofrm llamar = new inventario_vendidofrm();
            llamar.Show();

        }

        private void topesbtm_Click(object sender, EventArgs e)
        {
            this.Hide();
            topesfrm llamar = new topesfrm();
            llamar.Show();
        }

        private void configbtm_Click(object sender, EventArgs e)
        {
            this.Hide();
            calculoinventariofrm llamar = new calculoinventariofrm();
            llamar.Show();
        }
    }
}
