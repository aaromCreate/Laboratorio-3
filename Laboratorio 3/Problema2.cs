using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class Problema2 : Form
    {
        private Numero manejador = new Numero();
        private List<int> numeros = new List<int>();

        public Problema2()
        {
            InitializeComponent();
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numCantidad.Text, out int cantidad) && cantidad > 0)
            {
                numeros = manejador.GenerarManual(cantidad);
                lstNumeros.Items.Clear();
                foreach (int n in numeros)
                    lstNumeros.Items.Add(n);
            }
        }

        private void btnAzar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numCantidad.Text, out int cantidad) && cantidad > 0)
            {
                numeros = manejador.GenerarAzar(cantidad);
                lstNumeros.Items.Clear();
                foreach (int n in numeros)
                    lstNumeros.Items.Add(n);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (numeros.Count == 0)
            {
                MessageBox.Show("No hay números en la lista para mostrar.");
                return;
            }
            manejador.LlenarTabla(dgvTabla, numeros);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEliminar.Text, out int numero))
            {
                MessageBox.Show("Ingrese un número válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            numeros = manejador.EliminarNumero(dgvTabla, numero);
            manejador.LlenarTabla(dgvTabla, numeros);
        }

    }
}

