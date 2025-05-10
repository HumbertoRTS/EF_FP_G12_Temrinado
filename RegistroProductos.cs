using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_FP_G12.Clases;

namespace EF_FP_G12
{
    public partial class RegistroProductos : Form
    {
        public RegistroProductos()
        {
            InitializeComponent();
            //Generación de columna del datagridview
            dgvprod.AutoGenerateColumns = false;
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Código", DataPropertyName = "G12_codigo" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "G12_nombre" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoría", DataPropertyName = "G12_categoria" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "G12_precio" });

            //Elimina el botón de cerrar, minimizar y maximizar.
            this.ControlBox = false;            
        }        

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Enfocar el campo de código para ingresar un nuevo producto
                txtcodigo.Focus();

                // Validar que todos los campos estén llenos
                if (!ValidarCampos()) return;

                // Crear un nuevo producto con los datos del formulario
                Productos nuevoProducto = new Productos()
                {
                    G12_codigo = txtcodigo.Text,
                    G12_nombre = txtnombre.Text,
                    G12_categoria = txtcategoria.Text,                    
                    G12_precio = Convert.ToDouble(txtprecio.Text)
                };

                // Agregar el producto a la lista
                Productos.AgregarProducto(nuevoProducto);
                MessageBox.Show("Producto registrado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos de texto
                txtcodigo.Clear();
                txtnombre.Clear();
                txtcategoria.Clear();
                txtprecio.Clear();

                // Actualizar DataGridView
                ActualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtcodigo.Text) || string.IsNullOrWhiteSpace(txtnombre.Text) ||
                string.IsNullOrWhiteSpace(txtcategoria.Text) || string.IsNullOrWhiteSpace(txtprecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult G12_cancelar = MessageBox.Show("¿Desea cancelar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (G12_cancelar == DialogResult.Yes)
            {
                txtcodigo.Clear();
                txtnombre.Clear();
                txtcategoria.Clear();
                txtprecio.Clear();
                txtcodigo.Focus();
            }
        }

        private void ActualizarDataGridView()
        {
            dgvprod.DataSource = null; // Limpiar el DataGridView
            dgvprod.DataSource = Productos.ObtenerListaProductos(); // Asignar la lista actualizada
            dgvprod.Refresh();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            List<Productos> G12_productosEnStock = Productos.ObtenerListaProductos(); // Filtra productos con stock

            if (G12_productosEnStock.Count > 0)
            {
                StockProductos formStock = new StockProductos(G12_productosEnStock);
                formStock.Show(); // Abre el formulario de stock
            }
            else
            {
                MessageBox.Show("No hay productos en stock.", "Stock Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Ruta donde se guardará el archivo
            string G12_rutaArchivo = @"C:\Archivos\productos.txt";

            // Obtener la lista de clientes
            List<Productos> G12_listaProductos = Productos.ObtenerListaProductos();

            // Verifica que la carpeta exista antes de guardar el archivo
            if (!Directory.Exists(@"C:\Archivos"))
            {
                Directory.CreateDirectory(@"C:\Archivos");
            }

            Productos.GuardarProductosEnArchivo(G12_listaProductos, G12_rutaArchivo);
        }

        private void btnsalirprod_Click(object sender, EventArgs e)
        {
            DialogResult G12_salir = MessageBox.Show("¿Desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (G12_salir == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}


