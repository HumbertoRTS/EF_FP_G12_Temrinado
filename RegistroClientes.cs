using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_FP_G12.Clases;

namespace EF_FP_G12
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
            //Generación de columna del datagridview
            dgvregclie.AutoGenerateColumns = false;
            dgvregclie.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombres", DataPropertyName = "G12_nombres" });
            dgvregclie.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Apellidos", DataPropertyName = "G12_apellidos" });
            dgvregclie.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI", DataPropertyName = "G12_dni" });
            dgvregclie.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Celular", DataPropertyName = "G12_celular" });

            //Elimina el botón de cerrar, minimizar y maximizar.
            this.ControlBox = false;
        }
        private void btnregcli_Click(object sender, EventArgs e)
        {            
            try
            {
                // Validar que todos los campos estén llenos
                if (!ValidarCampos()) return;

                // Crear instancia del cliente con los valores del formulario
                Clientes G12_nuevoCliente = new Clientes
                {
                    G12_nombres = txtnomcli.Text.Trim(),
                    G12_apellidos = txtapeclie.Text.Trim(),
                    G12_dni = Validaciones.SolicitarNuevoDNI(txtdni),
                    G12_celular = Validaciones.SolicitarNuevoCelular(txtcelular)
                };

                // **Si alguno de los valores sigue siendo `0`, detener el proceso**
                if (G12_nuevoCliente.G12_dni == 0 || G12_nuevoCliente.G12_celular == 0)
                {
                    MessageBox.Show("No se pudo registrar el cliente porque los datos ingresados son incorrectos.", "Error en Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir sin registrar al cliente
                }

                // Registrar cliente si las validaciones son correctas
                Clientes.AgregarCliente(G12_nuevoCliente);
                MessageBox.Show("Cliente registrado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos después de registrar
                txtnomcli.Clear();
                txtapeclie.Clear();
                txtdni.Clear();
                txtcelular.Clear();
                txtnomcli.Focus();

                // Actualizar el DataGridView con la lista de clientes
                ActualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDataGridView()
        {
            dgvregclie.DataSource = null;
            dgvregclie.DataSource = Clientes.ObtenerListaClientes();
            dgvregclie.Refresh();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtnomcli.Text) ||
                string.IsNullOrWhiteSpace(txtapeclie.Text) ||
                string.IsNullOrWhiteSpace(txtdni.Text) ||
                string.IsNullOrWhiteSpace(txtcelular.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Ruta donde se guardará el archivo
            string G12_rutaArchivo = @"C:\Archivos\clientes.txt";

            // Obtener la lista de clientes
            List<Clientes> G12_listaClientes = Clientes.ObtenerListaClientes();

            // Verifica que la carpeta exista antes de guardar el archivo
            if (!Directory.Exists(@"C:\Archivos"))
            {
                Directory.CreateDirectory(@"C:\Archivos");
            }

            Clientes.GuardarClientesEnArchivo(G12_listaClientes, G12_rutaArchivo);
        }

        private void btncancelarcli_Click(object sender, EventArgs e)
        {
            DialogResult G12_cancelar = MessageBox.Show("¿Desea cancelar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (G12_cancelar == DialogResult.Yes)
            {
                txtnomcli.Clear();
                txtapeclie.Clear();
                txtdni.Clear();
                txtcelular.Clear();
                txtnomcli.Focus();
            }
        }

        private void btnsalirclie_Click(object sender, EventArgs e)
        {
            DialogResult G12_cerrar = MessageBox.Show("¿Desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (G12_cerrar == DialogResult.Yes)
            {
                this.Close();
            }
        }        
    }
}
