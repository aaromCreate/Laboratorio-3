using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laboratorio_3
{
    internal class Numero
    {
        public List<int> GenerarManual(int cantidad)
        {
            List<int> numeros = new List<int>();
            int contador = 0;

            while (contador < cantidad)
            {
                string entrada = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Ingrese el valor de la posición #{contador + 1}",
                    "Entrada", "0");

                if (int.TryParse(entrada, out int numero))
                {
                    numeros.Add(numero);
                    contador++;
                }
                else
                {
                    MessageBox.Show("Debe ingresar un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return numeros;
        }

        public List<int> GenerarAzar(int cantidad)
        {
            List<int> numeros = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < cantidad; i++)
                numeros.Add(rnd.Next(0, 100));

            return numeros;
        }

        public void LlenarTabla(DataGridView dgv, List<int> numeros)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            if (numeros.Count == 0)
                return;

            int n = (int)Math.Ceiling(Math.Sqrt(numeros.Count));

            for (int c = 0; c < n; c++)
                dgv.Columns.Add($"Col{c + 1}", $"Columna {c + 1}");

            dgv.Rows.Add(n);

            int index = 0;
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (index < numeros.Count)
                        dgv.Rows[f].Cells[c].Value = numeros[index++];
                    else
                        dgv.Rows[f].Cells[c].Value = "";
                }
            }

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public List<int> EliminarNumero(DataGridView dgv, int numero)
        {
            List<int> nuevos = new List<int>();

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value != null && celda.Value.ToString() != "" &&
                        celda.Value.ToString() != numero.ToString())
                    {
                        nuevos.Add(int.Parse(celda.Value.ToString()));
                    }
                }
            }

            return nuevos;
        }
    }
}

