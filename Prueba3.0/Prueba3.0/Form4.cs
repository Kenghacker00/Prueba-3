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
    public abstract class Moneda
    {
        public abstract double Convertir(double amount, Moneda toCurrency);
    }

    public class Cordoba : Moneda
    {
        public override double Convertir(double amount, Moneda toCurrency)
        {
            if (toCurrency is Dolar)
                return amount * 0.027;
            if (toCurrency is Euro)
                return amount * 0.025;
            return amount;
        }
    }

    public class Dolar : Moneda
    {
        public override double Convertir(double amount, Moneda toCurrency)
        {
            if (toCurrency is Cordoba)
                return amount * 37.0;
            if (toCurrency is Euro)
                return amount * 0.91;
            return amount;
        }
    }

    public class Euro : Moneda
    {
        public override double Convertir(double amount, Moneda toCurrency)
        {
            if (toCurrency is Cordoba)
                return amount * 40.0;
            if (toCurrency is Dolar)
                return amount * 1.10;
            return amount;
        }
    }

    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            labelResult.Visible = false;
        }

        private void InitializeCustomComponents()
        {
            comboBoxFrom.Items.AddRange(new string[] { "Cordobas", "Dolares", "Euros" });
            comboBoxTo.Items.AddRange(new string[] { "Cordobas", "Dolares", "Euros" });

            comboBoxFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTo.DropDownStyle = ComboBoxStyle.DropDownList;

            buttonConvert.Click += new EventHandler(buttonConvert_Click);
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAmount.Text) || comboBoxFrom.SelectedItem == null || comboBoxTo.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(textBoxAmount.Text, out double amount))
            {
                MessageBox.Show("Por favor, ingrese un valor numerico valido", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAmount.Clear();
                textBoxAmount.Focus();
                return;
            }

            Moneda fromCurrency = ObtenerMoneda(comboBoxFrom.SelectedItem.ToString());
            Moneda toCurrency = ObtenerMoneda(comboBoxTo.SelectedItem.ToString());

            double result = fromCurrency.Convertir(amount, toCurrency);

            labelResult.Text = $"{amount:N2} {comboBoxFrom.SelectedItem} = {result:N2} {comboBoxTo.SelectedItem}";
            labelResult.Visible = true;
        }

        private Moneda ObtenerMoneda(string currency)
        {
            return currency switch
            {
                "Cordobas" => new Cordoba(),
                "Dolares" => new Dolar(),
                "Euros" => new Euro(),
                _ => throw new ArgumentException("Moneda no válida")
            };
        }
    }
}