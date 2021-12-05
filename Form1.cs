using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_DE_CANTINA
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        decimal[] valor = new decimal[10];
        decimal somaM;
        private int indice;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 3)

            {
                int indice = 0;
                for (int prod = 1; prod < codigo.Length; prod++)
                {
                    if (txtCodigo.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }
                if (indice == 0)
                {
                    MessageBox.Show("Produto não encontrado");
                }
                else
                {
                    lstCaixa.Items.Add(txtCodigo.Text + "--" + produtos[indice] +
                        " --R$ " + valor[indice]);
                    somaM = somaM + valor[indice];
                    label3.Text = ("Valor Total R$ =" + somaM);
                    picImagem.ImageLocation = "C:/Users/Darlane/Pictures" + codigo[indice] +
                        ".jpg";
                    txtCodigo.Text = "";
                    txtCodigo.Focus();

                }
            }

            {
                carregarArray();
                somaM = somaM + valor[indice];
            }
            void carregarArray()

            {
                codigo[1] = "001";
                codigo[2] = "002";
                codigo[3] = "003";
                codigo[4] = "004";
                codigo[5] = "005";

                produtos[1] = "Pastel";
                produtos[2] = "Coxinha";
                produtos[3] = "Hot-Dog";
                produtos[4] = "Misto";
                produtos[5] = "Suco";

                valor[1] = 3.00M;
                valor[2] = 4.00M;
                valor[3] = 3.00M;
                valor[4] = 2.50M;
                valor[5] = 2.00M;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pagamento j2 = new pagamento();
            j2.Show();
        }


    }
}
