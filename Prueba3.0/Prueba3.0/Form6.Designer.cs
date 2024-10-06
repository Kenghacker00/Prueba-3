namespace Prueba3._0
{
    partial class Form6
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
            textBoxNum1 = new TextBox();
            textBoxNum2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(225, 20);
            label1.Name = "label1";
            label1.Size = new Size(348, 41);
            label1.TabIndex = 0;
            label1.Text = "Calculadora Aritmetica";
            // 
            // textBoxNum1
            // 
            textBoxNum1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxNum1.Location = new Point(65, 99);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(208, 34);
            textBoxNum1.TabIndex = 1;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxNum2.Location = new Point(65, 171);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(208, 34);
            textBoxNum2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(85, 231);
            label2.Name = "label2";
            label2.Size = new Size(158, 41);
            label2.TabIndex = 3;
            label2.Text = "Resultado";
            // 
            // button1
            // 
            button1.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(491, 120);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(633, 120);
            button2.Name = "button2";
            button2.Size = new Size(94, 44);
            button2.TabIndex = 6;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(491, 197);
            button3.Name = "button3";
            button3.Size = new Size(94, 38);
            button3.TabIndex = 7;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(633, 197);
            button4.Name = "button4";
            button4.Size = new Size(94, 38);
            button4.TabIndex = 8;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(491, 273);
            button5.Name = "button5";
            button5.Size = new Size(94, 45);
            button5.TabIndex = 9;
            button5.Text = "Raiz";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(633, 273);
            button6.Name = "button6";
            button6.Size = new Size(94, 45);
            button6.TabIndex = 10;
            button6.Text = "Potencia";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(565, 349);
            button7.Name = "button7";
            button7.Size = new Size(94, 43);
            button7.TabIndex = 11;
            button7.Text = "Limpiar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.BackColor = Color.Lavender;
            labelResultado.BorderStyle = BorderStyle.FixedSingle;
            labelResultado.FlatStyle = FlatStyle.Popup;
            labelResultado.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelResultado.Location = new Point(117, 296);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(2, 33);
            labelResultado.TabIndex = 12;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResultado);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBoxNum2);
            Controls.Add(textBoxNum1);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Calculadora";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label labelResultado;
    }
}