using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_FP_G12.Clases
{
    public class Clientes
    {
        public string G12_nombres { get; set; }
        public string G12_apellidos { get; set; }
        public int G12_dni { get; set; }
        public int G12_celular { get; set; }

        public Clientes()
        {
            this.G12_nombres = G12_nombres;
            this.G12_apellidos = G12_apellidos;
            this.G12_dni = G12_dni;
            this.G12_celular = G12_celular;
        }

        // Lista estática para almacenar los clientes
        public static List<Clientes> G12_ListaClientes = new List<Clientes>();
        // Método para agregar un cliente a la lista
        public static void AgregarCliente(Clientes G12_nuevoCliente)
        {
            G12_ListaClientes.Add(G12_nuevoCliente);            
        }
        // Método para listar todos los clientes
        public static List<Clientes> ObtenerListaClientes()
        {
            return G12_ListaClientes;
        }

        public bool ValidarDNIRecursivo(TextBox G12_txtdni)
        {
            string G12_dniTexto = G12_txtdni.Text.Trim();

            if (G12_dniTexto.Length == 8 && int.TryParse(G12_dniTexto, out int G12_nuevoDNI))
            {
                G12_dni = G12_nuevoDNI;
                return true; // Validación exitosa
            }
            else
            {
                MessageBox.Show("El DNI debe tener exactamente 8 números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                G12_dni = Validaciones.SolicitarNuevoDNI(G12_txtdni);

                // Se detiene la recursión si G12_celular es igual a 0 y esperamos el nuevo valor
                if (G12_dni == 0)
                {
                    return false; // Se detiene aquí y espera nueva entrada antes de repetir la validación
                }
                else
                {
                    return ValidarDNIRecursivo(G12_txtdni); // Llamada recursiva si aún es incorrecto
                }
            }
        }

        public bool ValidarCelularRecursivo(TextBox G12_txtCelular)
        {
            string G12_celularTexto = G12_txtCelular.Text.Trim();

            if (G12_celularTexto.Length == 9 && int.TryParse(G12_celularTexto, out int G12_nuevoCelular))
            {
                G12_celular = G12_nuevoCelular;
                return true; // La validación es exitosa
            }
            else
            {
                MessageBox.Show("El número de celular debe tener exactamente 9 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                G12_celular = Validaciones.SolicitarNuevoCelular(G12_txtCelular);

                // Se detiene la recursión si G12_celular es igual a 0 y esperamos el nuevo valor
                if (G12_celular == 0)
                {
                    return false; // Se detiene aquí y espera nueva entrada antes de repetir la validación
                }
                else
                {
                    return ValidarCelularRecursivo(G12_txtCelular); // Llamada recursiva si sigue siendo incorrecto
                }
            }
        }
        //Método para generar archivo clientes.txt
        public static void GuardarClientesEnArchivo(List<Clientes> G12_listaClientes, string G12_rutaArchivo)
        {
            try
            {
                using (StreamWriter G12_escritor = new StreamWriter(G12_rutaArchivo))
                {
                    //Cabezera del archivo
                    G12_escritor.WriteLine("Nombres|Apellidos|DNI|Celular");

                    foreach (var G12_cliente in G12_listaClientes)
                    {
                        // Guardar los datos separados por "|"
                        G12_escritor.WriteLine($"{G12_cliente.G12_nombres}|{G12_cliente.G12_apellidos}|{G12_cliente.G12_dni}|{G12_cliente.G12_celular}");
                    }
                }

                MessageBox.Show("Clientes guardados correctamente en el archivo.\nValidar la siguiente ruta: C:\\Archivos\\clientes.txt", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
    }
}
