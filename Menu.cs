using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_FP_G12
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.ControlBox = false;
            
        }

        private void tsbtitulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbproductos_Click(object sender, EventArgs e)
        {
            RegistroProductos G12_registroProducto = new RegistroProductos();
            G12_registroProducto.Show();
        }

        private void tsbclientes_Click(object sender, EventArgs e)
        {
            RegistroClientes G12_registroCliente = new RegistroClientes();
            G12_registroCliente.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Venta G12_ventas = new Venta();
            G12_ventas.Show();
        }
    }
}
