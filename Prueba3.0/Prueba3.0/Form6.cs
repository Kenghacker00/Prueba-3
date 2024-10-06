using System;
using System.Windows.Forms;

namespace Prueba3._0
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            button1.Click += (s, ev) => RealizarOperacion("sumar");
            button2.Click += (s, ev) => RealizarOperacion("restar");
            button3.Click += (s, ev) => RealizarOperacion("dividir");
            button4.Click += (s, ev) => RealizarOperacion("multiplicar");
            button5.Click += (s, ev) => RealizarOperacion("raiz");
            button6.Click += (s, ev) => RealizarOperacion("potencia");
            labelResultado.Visible = false;
        }

        private void RealizarOperacion(string operacion)
        {
            if (string.IsNullOrWhiteSpace(textBoxNum1.Text) || (operacion != "raiz" && string.IsNullOrWhiteSpace(textBoxNum2.Text)))
            {
                MessageBox.Show("Por favor, ingrese ambos numeros.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(textBoxNum1.Text, out double numero1))
            {
                MessageBox.Show("Por favor, ingrese un valor numerico valido para el primer numero.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double numero2 = 0;
            if (operacion != "raiz" && !double.TryParse(textBoxNum2.Text, out numero2))
            {
                MessageBox.Show("Por favor, ingrese un valor numerico válido para el segundo numero.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = 0;
            switch (operacion)
            {
                case "sumar":
                    resultado = numero1 + numero2;
                    break;
                case "restar":
                    resultado = numero1 - numero2;
                    break;
                case "multiplicar":
                    resultado = numero1 * numero2;
                    break;
                case "dividir":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("No se puede dividir por cero", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    resultado = numero1 / numero2;
                    break;
                case "raiz":
                    if (numero1 < 0)
                    {
                        MessageBox.Show("No se puede calcular la raiz cuadrada de un numero negativo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    resultado = Math.Sqrt(numero1);
                    break;
                case "potencia":
                    resultado = Math.Pow(numero1, numero2);
                    break;
            }
            resultado = Math.Round(resultado, 2);
            string formateado = resultado.ToString("N2");

            labelResultado.Visible = true;
            labelResultado.Text = formateado;
            textBoxNum1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxNum1.Clear();
            textBoxNum2.Clear();
            textBoxNum1.Focus();
            labelResultado.Visible=false;
            labelResultado.Text = string.Empty;
        }
    }
}
