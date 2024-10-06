namespace Prueba3._0
{
    partial class Form4
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
            textBoxAmount = new TextBox();
            comboBoxTo = new ComboBox();
            comboBoxFrom = new ComboBox();
            buttonConvert = new Button();
            labelResult = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(309, 9);
            label1.Name = "label1";
            label1.Size = new Size(325, 41);
            label1.TabIndex = 0;
            label1.Text = "Convertidor de dinero";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxAmount.Location = new Point(536, 128);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(125, 27);
            textBoxAmount.TabIndex = 1;
            // 
            // comboBoxTo
            // 
            comboBoxTo.FlatStyle = FlatStyle.Popup;
            comboBoxTo.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Location = new Point(622, 297);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(151, 28);
            comboBoxTo.TabIndex = 2;
            comboBoxTo.Text = "Elige una opcion";
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.FlatStyle = FlatStyle.Popup;
            comboBoxFrom.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Location = new Point(549, 211);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(160, 28);
            comboBoxFrom.TabIndex = 3;
            comboBoxFrom.Text = "Elige una opcion";
            // 
            // buttonConvert
            // 
            buttonConvert.FlatStyle = FlatStyle.System;
            buttonConvert.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonConvert.Location = new Point(635, 386);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(117, 31);
            buttonConvert.TabIndex = 4;
            buttonConvert.Text = "Convertir";
            buttonConvert.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.LightCyan;
            labelResult.BorderStyle = BorderStyle.Fixed3D;
            labelResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelResult.Location = new Point(259, 418);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(2, 22);
            labelResult.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(181, 124);
            label2.Name = "label2";
            label2.Size = new Size(337, 31);
            label2.TabIndex = 6;
            label2.Text = "Ingresa la cantidad de dinero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(39, 205);
            label3.Name = "label3";
            label3.Size = new Size(504, 31);
            label3.TabIndex = 7;
            label3.Text = "Elige el tipo de moneda que deseas convertir: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(39, 291);
            label4.Name = "label4";
            label4.Size = new Size(577, 31);
            label4.TabIndex = 8;
            label4.Text = "Elige el tipo de moneda a la que lo deseas convertir: ";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(914, 600);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelResult);
            Controls.Add(buttonConvert);
            Controls.Add(comboBoxFrom);
            Controls.Add(comboBoxTo);
            Controls.Add(textBoxAmount);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            Text = "Convertir monetario";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAmount;
        private ComboBox comboBoxTo;
        private ComboBox comboBoxFrom;
        private Button buttonConvert;
        private Label labelResult;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}