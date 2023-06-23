using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTOSHOP_Grupo8
{
    public partial class Venta_de_producto : Form
    {
        public Venta_de_producto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mante_fPago da = new Mante_fPago();
            da.Show();
        }
    }
}
