namespace meuprimeiroprojeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            primeiroValor = new TextBox();
            segundoValor = new TextBox();
            resultado = new TextBox();
            somar = new Button();
            subtrair = new Button();
            multiplicar = new Button();
            dividir = new Button();
            campoResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 101);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Primeiro valor:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 101);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 1;
            label2.Text = "Segundo valor:";
            // 
            // primeiroValor
            // 
            primeiroValor.Location = new Point(208, 143);
            primeiroValor.Name = "primeiroValor";
            primeiroValor.Size = new Size(150, 31);
            primeiroValor.TabIndex = 2;
            primeiroValor.TextChanged += primeiroValor_TextChanged;
            // 
            // segundoValor
            // 
            segundoValor.Location = new Point(424, 143);
            segundoValor.Name = "segundoValor";
            segundoValor.Size = new Size(150, 31);
            segundoValor.TabIndex = 3;
            segundoValor.TextChanged += segundoValor_TextChanged;
            // 
            // resultado
            // 
            resultado.Enabled = false;
            resultado.Location = new Point(208, 293);
            resultado.Name = "resultado";
            resultado.Size = new Size(366, 31);
            resultado.TabIndex = 4;
            resultado.TextChanged += textBox3_Text;
            // 
            // somar
            // 
            somar.Location = new Point(208, 197);
            somar.Name = "somar";
            somar.Size = new Size(87, 60);
            somar.TabIndex = 5;
            somar.Text = "+";
            somar.UseVisualStyleBackColor = true;
            somar.Click += btn_calcular;
            // 
            // subtrair
            // 
            subtrair.Location = new Point(301, 197);
            subtrair.Name = "subtrair";
            subtrair.Size = new Size(87, 60);
            subtrair.TabIndex = 6;
            subtrair.Text = "-";
            subtrair.UseVisualStyleBackColor = true;
            subtrair.Click += btn_calcular;
            // 
            // multiplicar
            // 
            multiplicar.Location = new Point(394, 197);
            multiplicar.Name = "multiplicar";
            multiplicar.Size = new Size(87, 60);
            multiplicar.TabIndex = 7;
            multiplicar.Text = "x";
            multiplicar.UseVisualStyleBackColor = true;
            multiplicar.Click += btn_calcular;
            // 
            // dividir
            // 
            dividir.Location = new Point(487, 197);
            dividir.Name = "dividir";
            dividir.Size = new Size(87, 60);
            dividir.TabIndex = 8;
            dividir.Text = "÷";
            dividir.UseVisualStyleBackColor = true;
            dividir.Click += btn_calcular;
            // 
            // campoResultado
            // 
            campoResultado.AutoSize = true;
            campoResultado.Location = new Point(208, 265);
            campoResultado.Name = "campoResultado";
            campoResultado.Size = new Size(94, 25);
            campoResultado.TabIndex = 9;
            campoResultado.Text = "Resultado:";
            campoResultado.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(campoResultado);
            Controls.Add(dividir);
            Controls.Add(multiplicar);
            Controls.Add(subtrair);
            Controls.Add(somar);
            Controls.Add(resultado);
            Controls.Add(segundoValor);
            Controls.Add(primeiroValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao;
        private Label label1;
        private Label label2;
        private TextBox primeiroValor;
        private TextBox segundoValor;
        private TextBox resultado;
        private Button somar;
        private Button subtrair;
        private Button multiplicar;
        private Button dividir;
        private Label campoResultado;
    }
}
