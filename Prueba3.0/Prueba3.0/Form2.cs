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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            OcultarDatos();
        }

        public void OcultarDatos()
        {
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            subtotal.Visible = false;
            descuento.Visible = false;
            impuesto.Visible = false;
            totalPagar.Visible = false;
        }
        public void MostrarDatos()
        {
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            subtotal.Visible = true;
            descuento.Visible = true;
            impuesto.Visible = true;
            totalPagar.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre;
            int Cantidad;
            double Precio;
            string TipoCliente = "";

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Hay un campo vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            try
            {
                Nombre = textBox1.Text.Trim();

                if (!int.TryParse(textBox3.Text.Trim(), out Cantidad))
                {
                    MessageBox.Show("La cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Focus();
                    return;
                }

                if (!double.TryParse(textBox2.Text.Trim(), out Precio))
                {
                    MessageBox.Show("El precio ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                    return;
                }

                if (checkBox1.Checked && !checkBox2.Checked)
                {
                    TipoCliente = "A";
                }
                else if (checkBox2.Checked && !checkBox1.Checked)
                {
                    TipoCliente = "B";
                }
                else
                {
                    MessageBox.Show("Debes seleccionar al menos un tipo de cliente", "Selección de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Cliente cliente = new Cliente(Nombre, Cantidad, Precio, TipoCliente);
                double Subtotal = cliente.CalcularSubtotal();
                subtotal.Text = Subtotal.ToString("N2");
                double Descuento= cliente.CalcularDescuento(Subtotal);
                descuento.Text = Descuento.ToString("N2");
                double subtotalConDescuento = Subtotal - Descuento;
                double Impuesto = cliente.CalcularImpuesto(subtotalConDescuento);
                impuesto.Text = Impuesto.ToString("N2");
                double Total = cliente.CalcularTotal(subtotalConDescuento, Impuesto);
                totalPagar.Text = Total.ToString("N2");
                MostrarDatos();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }

    public class Cliente
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public string TipoCliente { get; set; }

        public Cliente(string nombre, int cantidad, double precio, string tipoCliente)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
            TipoCliente = tipoCliente;
        }

        public Cliente()
        {
        }

        public double CalcularSubtotal()
        {
            return Cantidad * Precio;
        }

        public double CalcularDescuento(double subtotal)
        {
            double porcDescuento;
            if (TipoCliente == "A" || Cantidad > 100)
            {
                porcDescuento = 0.10;
            }
            else
            {
                porcDescuento = 0.05;
            }
            return subtotal * porcDescuento;
        }

        public double CalcularImpuesto(double subtotalConImpesto)
        {
            return subtotalConImpesto * 0.15;
        }

        public double CalcularTotal(double subtotalConImpesto, double impuesto)
        {
            return subtotalConImpesto + impuesto;
        }

    }
}
