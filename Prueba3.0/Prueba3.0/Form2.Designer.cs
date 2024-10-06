namespace Prueba3._0
{
    partial class Form2
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            subtotal = new Label();
            descuento = new Label();
            impuesto = new Label();
            totalPagar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 60);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del cliente:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 54);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 129);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 2;
            label2.Text = "Cantidad de producto:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 125);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 208);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Precio:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 270);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 5;
            label4.Text = "Tipo de cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 376);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 6;
            label5.Text = "Subtotal:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(324, 204);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 27);
            textBox3.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(341, 268);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Tipo A";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(425, 269);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(74, 24);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Tipo B";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(617, 137);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(166, 49);
            button1.TabIndex = 10;
            button1.Text = "Calcular Descuento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 376);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 11;
            label6.Text = "Descuento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(667, 376);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 12;
            label7.Text = "Impuesto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(328, 475);
            label8.Name = "label8";
            label8.Size = new Size(113, 23);
            label8.TabIndex = 13;
            label8.Text = "Total a pagar:";
            // 
            // subtotal
            // 
            subtotal.AutoSize = true;
            subtotal.Location = new Point(152, 377);
            subtotal.Name = "subtotal";
            subtotal.Size = new Size(50, 20);
            subtotal.TabIndex = 14;
            subtotal.Text = "label9";
            // 
            // descuento
            // 
            descuento.AutoSize = true;
            descuento.Location = new Point(460, 377);
            descuento.Name = "descuento";
            descuento.Size = new Size(50, 20);
            descuento.TabIndex = 15;
            descuento.Text = "label9";
            // 
            // impuesto
            // 
            impuesto.AutoSize = true;
            impuesto.Location = new Point(762, 377);
            impuesto.Name = "impuesto";
            impuesto.Size = new Size(50, 20);
            impuesto.TabIndex = 16;
            impuesto.Text = "label9";
            // 
            // totalPagar
            // 
            totalPagar.AutoSize = true;
            totalPagar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            totalPagar.Location = new Point(462, 477);
            totalPagar.Name = "totalPagar";
            totalPagar.Size = new Size(55, 23);
            totalPagar.TabIndex = 17;
            totalPagar.Text = "label9";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(914, 600);
            Controls.Add(totalPagar);
            Controls.Add(impuesto);
            Controls.Add(descuento);
            Controls.Add(subtotal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Descuento al cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label subtotal;
        private Label descuento;
        private Label impuesto;
        private Label totalPagar;
    }
}