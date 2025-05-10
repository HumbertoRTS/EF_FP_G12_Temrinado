using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_FP_G12.Clases
{
    public class Validaciones
    {
        
        public static int SolicitarNuevoDNI(TextBox G12_txtdni)
        {
            int G12_nuevoDNI = 0;

            while (true) // Se repite hasta que el usuario ingrese un valor válido
            {
                string G12_nuevoDNITexto = G12_txtdni.Text.Trim(); // Obtiene el nuevo valor ingresado

                if (int.TryParse(G12_nuevoDNITexto, out G12_nuevoDNI) && G12_nuevoDNITexto.Length == 8)
                {
                    return G12_nuevoDNI; // Si es válido, sale del bucle y retorna que es correcto
                }
                else
                {
                    MessageBox.Show("Ingrese un DNI de 8 dígitos válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    G12_txtdni.Clear();
                    G12_txtdni.Focus();

                    return 0; // El usuario ingrese un nuevo valor antes de volver a ejecutar la validación
                }
            }
        }

        public static int SolicitarNuevoCelular(TextBox G12_txtCelular)
        {
            int G12_nuevoCelular = 0;

            while (true) // Se repite hasta que el usuario ingrese un valor válido
            {
                string G12_nuevoCelularTexto = G12_txtCelular.Text.Trim(); // Obtiene el nuevo valor ingresado

                if (int.TryParse(G12_nuevoCelularTexto, out G12_nuevoCelular) && G12_nuevoCelularTexto.Length == 9)
                {
                    return G12_nuevoCelular; // Si es válido, sale del bucle y retorna que es correcto
                }
                else
                {
                    MessageBox.Show("Ingrese un número de celular de 9 dígitos válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    G12_txtCelular.Clear();
                    G12_txtCelular.Focus();

                    return 0; // El usuario ingrese un nuevo valor antes de volver a ejecutar la validación
                }
            }
        }
    }
}
