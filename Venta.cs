using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_FP_G12.Clases;

namespace EF_FP_G12
{
    public partial class Venta : Form
    {       
        public Venta()
        {
            InitializeComponent();
            
            //Elimina el botón de cerrar, minimizar y maximizar.
            this.ControlBox = false;
        }

        private void btnsalirvent_Click(object sender, EventArgs e)
        {
            DialogResult G12_cerrar = MessageBox.Show("¿Desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (G12_cerrar == DialogResult.Yes)
            {
                this.Close(); // Cierra la ventana si el usuario confirma la acción
            }
        }

        private void txtnomventa_Leave(object sender, EventArgs e)
        {
            try
            {
                string G12_nombreBuscado = txtnomventa.Text.Trim();

                if (Clientes.G12_ListaClientes == null || Clientes.G12_ListaClientes.Count == 0)
                {
                    throw new Exception("La lista de clientes está vacía o no ha sido inicializada.");
                }

                bool G12_clienteEncontrado = false;

                foreach (Clientes cliente in Clientes.G12_ListaClientes)
                {
                    if (cliente.G12_nombres.Equals(G12_nombreBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        txtapevent.Text = cliente.G12_apellidos;
                        G12_clienteEncontrado = true;
                        break;
                    }
                }

                // Mostrar el aviso solo cuando el usuario haya terminado de escribir
                if (!G12_clienteEncontrado)
                {
                    txtapevent.Text = "";
                    MessageBox.Show("El cliente no está registrado en la lista. \nPor favor, vuelva a ingresar el nombre del cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnomprod_Leave(object sender, EventArgs e)
        {
            try
            {
                // Obtiene el texto del TextBox
                string G12_nombreBuscado = txtnomprod.Text.Trim();

                // Valida que la lista de productos no sea nula
                if (Productos.G12_listaProductos == null || Productos.G12_listaProductos.Count == 0)
                {
                    throw new Exception("La lista de productos está vacía o no se ha inicializado.");
                }

                bool G12_productoEncontrado = false;

                // Recorrer la lista de productos manualmente
                foreach (Productos G12_producto in Productos.G12_listaProductos)
                {
                    if (G12_producto.G12_nombre.Equals(G12_nombreBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        txtpreciovent.Text = G12_producto.G12_precio.ToString("F2"); // Formato con 2 decimales
                        G12_productoEncontrado = true;
                        break;
                    }
                }

                // Validar si el producto no fue encontrado
                if (!G12_productoEncontrado)
                {
                    txtpreciovent.Text = "";
                    MessageBox.Show("El producto no está registrado en la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarVenta()
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtnomventa.Text) || string.IsNullOrWhiteSpace(txtapevent.Text) ||
                    string.IsNullOrWhiteSpace(txtnomprod.Text) || string.IsNullOrWhiteSpace(txtcantidad.Text) ||
                    string.IsNullOrWhiteSpace(txtpreciovent.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener los valores de los TextBox
                string G12_nombreCliente = txtnomventa.Text.Trim();
                string G12_apellidoCliente = txtapevent.Text.Trim();
                string G12_nombreProducto = txtnomprod.Text.Trim();
                int G12_cantidad = int.Parse(txtcantidad.Text.Trim());
                double G12_precio = double.Parse(txtpreciovent.Text.Trim());

               
                // Verificar que el DataGridView tiene columnas antes de agregar filas
                if (dgvventa.ColumnCount == 0)
                 {
                    dgvventa.AutoGenerateColumns = false; // Desactivar generación automática
                    dgvventa.AllowUserToAddRows = false;
                    dgvventa.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", Name = "Nombre", DataPropertyName = "G12_nombreCliente" });
                    dgvventa.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Apellidos", Name = "Apellidos", DataPropertyName = "G12_apellidoCliente" });
                    dgvventa.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Producto", Name = "Producto", DataPropertyName = "G12_nombreProducto" });
                    dgvventa.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cantidad", Name = "Cantidad", DataPropertyName = "G12_Cantidad" });
                    dgvventa.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", Name = "Precio", DataPropertyName = "G12_precio" });
                    dgvventa.Refresh();
                 }

                // Agregar una fila al DataGridView sin usar DataTable
                dgvventa.Rows.Add(G12_nombreCliente, G12_apellidoCliente, G12_nombreProducto, G12_cantidad, G12_precio.ToString("F2"));               

                // Limpiar los campos después de agregar la venta               
                txtnomprod.Clear();
                txtpreciovent.Clear();
                txtcantidad.Clear();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de entrada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {            
            dgvventa.AutoGenerateColumns = false; // Desactivar generación automática
            
            dgvventa.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", Name= "Nombre", DataPropertyName = "G12_nombreCliente" });
            dgvventa.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Apellidos", Name = "Apellidos", DataPropertyName = "G12_apellidoCliente" });
            dgvventa.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Producto", Name = "Producto", DataPropertyName = "G12_nombreProducto" });
            dgvventa.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cantidad", Name = "Cantidad", DataPropertyName = "G12_Cantidad" });
            dgvventa.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", Name = "Precio", DataPropertyName = "G12_precio" });       
        }

        private void btnregventa_Click(object sender, EventArgs e)
        {
            RegistrarVenta();
            // Actualizar el total
            CalcularTotalGeneral();

        }

        private void CalcularTotalGeneral()
        {      
            Dictionary<string, double> totalPorCliente = new Dictionary<string, double>();

            foreach (DataGridViewRow fila in dgvventa.Rows)
            {
                if (fila.Cells["Nombre"].Value != null && fila.Cells["Cantidad"].Value != null && fila.Cells["Precio"].Value != null)
                {
                    string nombreCliente = fila.Cells["Nombre"].Value.ToString();
                    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    double precio = Convert.ToDouble(fila.Cells["Precio"].Value);
                    double totalGastado = cantidad * precio;

                    // Sumar el total gastado por cada cliente
                    if (totalPorCliente.ContainsKey(nombreCliente))
                    {
                        totalPorCliente[nombreCliente] += totalGastado;
                    }
                    else
                    {
                        totalPorCliente[nombreCliente] = totalGastado;
                    }
                }
            }

            // Mostrar el total gastado por cliente en el Label
            lblTotalGastado.Text = "Total gastado por cliente:\n";
            foreach (var cliente in totalPorCliente)
            {
                lblTotalGastado.Text += $"{cliente.Key}: S/. {cliente.Value:F2}\n";
            }

        }
    }
}
