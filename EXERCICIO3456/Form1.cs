using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCICIO3456
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNCONVERSAO_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            valor1 = Convert.ToDouble(textBox1.Text);
            valor2= Convert.ToDouble(textBox2.Text);

            label3.Text = Convert.ToString(valor1 * valor2, CultureInfo.InvariantCulture);
        }

        private void btntrocar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox3.Text);
            int num2 = int.Parse(textBox4.Text);

            int aux = num1;
            num1 = num2; 
            num2 = aux;

            label4.Text = "os valores trocados sao:" + num1 + "e " + num2 + ". ";
        }
    }
}
