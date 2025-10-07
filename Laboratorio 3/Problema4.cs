using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (!Verficacion.ValidarTexto(txtNombre, erpErrorNom, "El nombre es obligatorio"))
                e.Cancel = true;
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            if (!Verficacion.ValidarTexto(txtApellido, erpErrorApe, "El apellido es obligatorio"))
                e.Cancel = true;
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (!Verficacion.ValidarCorreo(txtCorreo, erpErrorCorreo))
                e.Cancel = true;
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (!Verficacion.ValidarContraseña(txtContraseña, erpError))
                e.Cancel = true;
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
    }
}
       
    
