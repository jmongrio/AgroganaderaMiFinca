using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    class Validaciones
    {
        /*
  * Realiza la verificación de las entradas númericas
  */
        public void comprobarNumeros(MaskedTextBox nombre, Button boton, ErrorProvider error)
        {
            if (nombre.Text.Trim() != string.Empty && nombre.Text.All(Char.IsDigit))
            {
                error.SetError(nombre, "");
            }
            else
            {
                if (!(nombre.Text.All(Char.IsDigit)))
                {
                    error.SetError(nombre, "Este espacio sólo debe contener números.");
                }
                else
                {
                    error.SetError(nombre, "Debe introducir algún dato.");
                }
                nombre.Focus();
            }
        }

        /*
        * Se valida si el usuario esta dejando espacios vacios.         
        */
        public void comprobarEspaciosVacios(MaskedTextBox nombre, Button boton, ErrorProvider error)
        {
            if (nombre.Text.Trim() != string.Empty)
            {
                error.SetError(nombre, "");
            }
            else
            {
                error.SetError(nombre, "Debe introducir algún dato.");
                nombre.Focus();                
            }
        }
    }
}
