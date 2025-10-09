using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class Problema4 : Form
    {
        public Problema4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool resultado = Verficacion.ValidarTodo(ref txtNombre, ref txtApellido, ref txtCorreo, ref txtContraseña, ref erpErrorNom, ref erpErrorApe, ref erpErrorCorreo, ref erpError);

            if (resultado)
                MessageBox.Show($"Bienvenido {txtNombre.Text} {txtApellido.Text}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Por favor, corrija los errores en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            bool esValido = Verficacion.ValidarTexto(txtNombre, erpErrorNom, "El nombre es obligatorio");
            e.Cancel = !esValido; 
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            bool esValido = Verficacion.ValidarTexto(txtApellido, erpErrorApe, "El apellido es obligatorio");
            e.Cancel = !esValido;
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            bool esValido = Verficacion.ValidarCorreo(txtCorreo, erpErrorCorreo);
            e.Cancel = !esValido;
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            bool esValido = Verficacion.ValidarContraseña(txtContraseña, erpError);
            e.Cancel = !esValido;
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                MessageBox.Show("Profe Juegue Marvel Rivals", "Secreto");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            Verficacion.ValidarContraseña(txtContraseña, erpError); 
        }

        private void txtCorreo_KeyUp(object sender, KeyEventArgs e)
        {
            Verficacion.ValidarCorreo(txtCorreo, erpErrorCorreo);
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            Verficacion.ValidarTexto(txtNombre, erpErrorNom, "El nombre es obligatorio"); 
        }

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            Verficacion.ValidarTexto(txtNombre, erpErrorNom, "El apellido es obligatorio"); 
        }
    }
}
