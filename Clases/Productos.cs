using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EF_FP_G12.Clases
{
    public class Productos
    {
        public string G12_codigo { get; set; }
        public string G12_nombre { get; set; }
        public string G12_categoria { get; set; }
        public double G12_precio { get; set; }

        public Productos()
        {
            this.G12_codigo = G12_codigo;
            this.G12_nombre = G12_nombre;
            this.G12_categoria = G12_categoria;
            this.G12_precio = G12_precio;
        }     

        // Lista de productos
        public static List<Productos> G12_listaProductos = new List<Productos>();

        // Método para agregar un producto a la lista
        public static void AgregarProducto(Productos producto)
        {
            G12_listaProductos.Add(producto);            
        }

        // Método para listar todos los productos
        public static List<Productos> ObtenerListaProductos()
        {
            return G12_listaProductos;
        }
        //Método para crear archivo productos.txt
        public static void GuardarProductosEnArchivo(List<Productos> G12_listaProducto, string G12_rutaArchivo)
        {
            try
            {
                using (StreamWriter G12_escritor = new StreamWriter(G12_rutaArchivo))
                {
                    //Cabezera del archivo
                    G12_escritor.WriteLine("Código|Nombres|Categoría|Precio");

                    foreach (var G12_productos in G12_listaProducto)
                    {
                        // Guardar los datos separados por "|"
                        G12_escritor.WriteLine($"{G12_productos.G12_codigo}|{G12_productos.G12_nombre}|{G12_productos.G12_categoria}|{G12_productos.G12_precio}");
                    }
                }

                MessageBox.Show("Productos guardados correctamente en el archivo.\nValidar en la siguiente ruta: C:\\Archivos\\productos.txt", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
    }
}
