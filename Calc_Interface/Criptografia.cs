using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Interface
{
    public partial class Criptografia : Form
    {

       gerarCripto g = new gerarCripto();

        public Criptografia()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    if (txtSenhaOriginal.Text == "")
                    {
                        MessageBox.Show("Digite alguma coisa!", "Aviso Importante");
                    }

                    else
                    {
                        txtSenhaConvertida.Text = (g.criptografar(txtSenhaOriginal.Text));
                    }
                    
                }

                else if (radioButton2.Checked)
                {
                    if (txtSenhaOriginal.Text == "")
                    {
                        MessageBox.Show("Digite alguma coisa!", "Aviso Importante");
                    }

                    else
                    {
                        txtSenhaConvertida.Text = (g.criptografarDiferente(txtSenhaOriginal.Text));
                    }       
                }

                else if (radioButton3.Checked)
                {
                    if (txtSenhaOriginal.Text == "")
                    {
                        MessageBox.Show("Digite alguma coisa!", "Aviso Importante");
                    }

                    else
                    {
                        txtSenhaConvertida.Text = (g._criptografarDiferente(txtSenhaOriginal.Text));
                    }     
                }

                else
                {
                    MessageBox.Show("Escolha uma opção!", "Aviso Importante");
                }
            }

            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Aviso Importante");
            }
            
            
        }

        
    }
}
