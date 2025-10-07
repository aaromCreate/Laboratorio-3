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
    public partial class Problema3 : Form
    {
        public Problema3()
        {
            InitializeComponent();
        }

        private List<decimal> importes = new List<decimal>();

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valor;

            if (decimal.TryParse(textBox1.Text, out valor))
            {
                importes.Add(valor);

                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 1;
                dataGridView1.Columns[0].Name = "Importe";

                foreach (var importe in importes)
                {
                    dataGridView1.Rows.Add(importe.ToString("C"));
                }

                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese un importe válido.", "Error");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal min = 75m;
            decimal max = 215m;

            // Filtrar y ordenar los importes
            var importesFiltrados = importes.Where(i => i >= min && i <= max).OrderBy(i => i).ToList();

            // Mostrar en el DataGridView derecho
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.ColumnCount = 1;
            dataGridView2.Columns[0].Name = "Importes entre $75 y $215";

            foreach (var importe in importesFiltrados)
            {
                dataGridView2.Rows.Add(importe.ToString("C"));
            }
        }
    }
}
