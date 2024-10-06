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
    public partial class Form3 : Form
    {
        private int intentos = 0;
        private const string correctPassword = "eureka";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("El campo no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (texto == correctPassword)
            {
                MessageBox.Show("¡Clave correcta!", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                intentos++;
                if (intentos >= 3)
                {
                    MessageBox.Show("Has agotado los 3 intentos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Clave incorrecta. Te quedan {3 - intentos} intentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }
    }
}
