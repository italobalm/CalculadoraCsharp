namespace meuprimeiroprojeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void primeiroValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void segundoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular(object sender, EventArgs e)

        {
           
            
            int valor1 = Convert.ToInt32(primeiroValor.Text);
            int valor2 = Convert.ToInt32(segundoValor.Text);
            int resultadoConta = 0;

            Button botao = (Button)sender;
            
            if (botao.Name == "somar")
            { 
                resultadoConta = valor1 + valor2;
            }
            else if (botao.Name == "subtrair")
            {
                resultadoConta = valor1 - valor2;
            }
            else if (botao.Name == "multiplicar")
            {
                resultadoConta = valor1 * valor2;
            }
            else if (botao.Name == "dividir")
            {
                resultadoConta = valor1 / valor2;
            }



            resultado.Text = resultadoConta.ToString();

        }

        private void textBox3_Text(object sender, EventArgs e)
        {
       
            
            string resultadoConta = this.resultado.Text;
        }

    

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
