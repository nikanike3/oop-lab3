using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays1DWinForms
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n, k;
        string consoleRead;
        double result = 1;

        double[] array;
        double[] arraySort;

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            clearData();

            Random random = new Random();

            n = Convert.ToInt32(numericUpDownCount.Value);

            result = 1;

            array = new double[n];

            for (int value = 0; value < n; value++)
            {
                array[value] = Math.Round(random.NextDouble() * (12.951 - -28.305) + -28.305, 3);
                if (array[value] < 0)
                {
                    result *= array[value];
                }
            }

            arraySort = array;

            for (int i = 0; i < n; i++)
            {
                this.dataGridViewArray.Rows.Add(array[i]);
            }

            Array.Sort(arraySort);
            Array.Reverse(arraySort);

            for (int i = 0; i < n; i++)
            {
                this.dataGridViewSort.Rows.Add(arraySort[i]);
            }

            numericUpDownK.Enabled = true;
            numericUpDownK.Maximum = n;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void buttonUnleash_Click(object sender, EventArgs e)
        {
            this.dataGridViewSort.Rows.Clear();

            n = Convert.ToInt32(numericUpDownCount.Value);
            k = Convert.ToInt32(numericUpDownK.Value);

            for (int i = 0; i < k; i++)
            {
                this.dataGridViewSort.Rows.Add(arraySort[i]);
            }

            textBoxResult.Text = result.ToString();
        }

        private void clearData()
        {
            this.dataGridViewArray.Rows.Clear();
            this.dataGridViewSort.Rows.Clear();
        }
    }
}
