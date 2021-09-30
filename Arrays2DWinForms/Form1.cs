using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2DWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n, m;
        double[,] array;

        double[] result;
        double[] arraySortedRows;

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            clear();
            n = Convert.ToInt32(numericUpDownN.Value);
            m = Convert.ToInt32(numericUpDownM.Value);

            array = new double[n, m];

            result = new double[n];

            for (int value = 0; value < n; value++)
            {
                result[value] = 1;
            }

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Math.Round(random.NextDouble() * (33.110 - -33.531) + -33.531, 3);
                }
            }

            dataGridViewMatrix.ColumnCount = m;
            dataGridViewMatrix.RowCount = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void buttonUnleash_Click(object sender, EventArgs e)
        {
            dataGridViewSum.Rows.Clear();

            result = new double[n];

            for (int value = 0; value < n; value++)
            {
                result[value] = 1;
            }

            for (int value = 0; value < n; value++)
            {
                for (int value2 = 0; value2 < m; value2++)
                {
                    result[value] += Math.Abs(array[value, value2]);
                }
            }

            for (int value = 0; value < n; value++)
            {
                result[value] -= 1;
            }

            for (int i = 0; i < n; i++)
            {
                this.dataGridViewSum.Rows.Add(result[i]);
            }

            Array.Sort(result);

            textBoxMinRow.Text = result[0].ToString();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix.ColumnCount = m;
            dataGridViewMatrix.RowCount = n;

            arraySortedRows = new double[m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arraySortedRows[j] = Math.Abs(array[i, j]);
                }

                Array.Sort(arraySortedRows);

                for (int j = 0; j < m; j++)
                {
                    array[i, j] = arraySortedRows[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }

        private void clear()
        {
            dataGridViewMatrix.Rows.Clear();
            dataGridViewMatrix.Columns.Clear();
            dataGridViewSum.Rows.Clear();
        }
    }
}
