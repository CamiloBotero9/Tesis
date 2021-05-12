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
    public partial class calculoinventariofrm : Form
    {

       


        public calculoinventariofrm()
        {
            InitializeComponent();
        }

        private void calculoinventariofrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            inventario_vendidofrm llamar = new inventario_vendidofrm();
            llamar.Show();
            this.Close();
        }

     private void  calculolst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
