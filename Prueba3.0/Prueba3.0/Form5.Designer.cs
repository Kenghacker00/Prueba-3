namespace Prueba3._0
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            Calcular = new Button();
            label6 = new Label();
            total = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 47);
            label1.Name = "label1";
            label1.Size = new Size(270, 20);
            label1.TabIndex = 0;
            label1.Text = "Calculo de la Nomina de un trabajador:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 106);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 168);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Identificacion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 228);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 3;
            label4.Text = "Asignacion Salario Dia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 288);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 4;
            label5.Text = "Dias Laborados:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(351, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(351, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(351, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(351, 285);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(225, 27);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(334, 346);
            button1.Name = "button1";
            button1.Size = new Size(261, 44);
            button1.TabIndex = 9;
            button1.Text = "Guardar Registro de Empleado:";
            button1.UseVisualStyleBackColor = true;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(393, 404);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(138, 35);
            Calcular.TabIndex = 10;
            Calcular.Text = "Calcular Salario";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 481);
            label6.Name = "label6";
            label6.Size = new Size(164, 20);
            label6.TabIndex = 11;
            label6.Text = "Valor Total Devengado:";
            // 
            // total
            // 
            total.Location = new Point(351, 478);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(225, 27);
            total.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(325, 541);
            button2.Name = "button2";
            button2.Size = new Size(86, 30);
            button2.TabIndex = 13;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(500, 541);
            button3.Name = "button3";
            button3.Size = new Size(86, 30);
            button3.TabIndex = 14;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(914, 600);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(total);
            Controls.Add(label6);
            Controls.Add(Calcular);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            Text = "Calcular Salario";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button Calcular;
        private Label label6;
        private TextBox total;
        private Button button2;
        private Button button3;
    }
}