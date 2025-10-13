using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    internal class Ordenado
    {
        public List<decimal> importes = new List<decimal>();
        public List<decimal> importesFiltrados = new List<decimal>();
        private decimal min = 75m;
        private decimal max = 215m;
        public void AgregarImporte(string textoImporte)
        {
            if (decimal.TryParse(textoImporte, out decimal valor) && valor > 0)
            {
                importes.Add(valor);
            }

            else
            {
                MessageBox.Show("Ingrese un importe válido (mayor que 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FiltrarImportes()
        {
            importesFiltrados= importes.Where(i => i >= min && i <= max).OrderBy(i => i).ToList();
        }

        public void ImprimirImportes(DataGridView dataGrid)
        {
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            dataGrid.ColumnCount = 1;
            dataGrid.Columns[0].Name = "Importes";

            foreach (var importe in importes)
            {
                dataGrid.Rows.Add(importe.ToString("C"));
            }
        }

        public void ImprimirImportesFiltrados(DataGridView dataGrid)
        {
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            dataGrid.ColumnCount = 1;
            dataGrid.Columns[0].Name = "Importes entre B/.75 y B/.215";

            if (importesFiltrados.Count == 0)
            {
                MessageBox.Show("No hay importes filtrados a mostrar.");
            }

            foreach (var importe in importesFiltrados)
            {
                dataGrid.Rows.Add(importe.ToString("C"));
            }
        }
    }
}
