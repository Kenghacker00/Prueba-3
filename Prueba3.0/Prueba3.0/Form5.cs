using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba3._0
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Hay un campo vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            try
            {
                string Nombre = textBox1.Text.Trim();
                string Identificacion = textBox2.Text.Trim();

                if (!double.TryParse(textBox3.Text.Trim(), out double SalarioDia))
                {
                    MessageBox.Show("La cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Focus();
                    return;
                }

                if (!int.TryParse(textBox4.Text.Trim(), out int DiasLaborados))
                {
                    MessageBox.Show("Los dias laborados no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Focus();
                    return;
                }
                Trabajador trabajador = new Trabajador(Nombre, Identificacion, SalarioDia, DiasLaborados);
                double Total = trabajador.CalcularSalario();
                total.Text = Total.ToString("N2");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            total.Text = "";
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class Trabajador
    {
        string Nombre;
        string Identificacion;
        double SalarioDia;
        int DiasLaborados;

        public Trabajador(string nombre, string identificacion, double salarioDia, int diasLaborados)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            SalarioDia = salarioDia;
            DiasLaborados = diasLaborados;
        }

        public double CalcularSalario()
        {
            return SalarioDia * DiasLaborados;
        }
    }
}
