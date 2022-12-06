
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraApp
{
    public partial class frmCalcula : Form
    {
        //Criando variáveis globais
        bool flag = false;
        const string nome = "Senac Largo Treze";


        //este é um método construtor
        public frmCalcula()
        {
            //carrega todos os componentes da janela
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Você clicou no botão calcular", "Mensagem do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

            //Declarar as variáveis que irão receber o texto digitado
            double num1, num2, resp = 0;

            //criando uma variável constante
            const double pi= 3.14151624397865171625;

            //inicializando as variaveis
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            //realizar o calculo
            resp = num1 + (num2 * pi);


            lblResultado.Text = resp.ToString();
            flag = true;




        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Flag - antes: " + flag);
            
            flag = true;

            
            MessageBox.Show("Flag - antes: " + flag + " - Nome: "+nome);

        }

        
    }
}
