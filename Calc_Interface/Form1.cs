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
    public partial class Form1 : Form
    {
        public int numeroDigitado;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // converter para binario
        {
            try
            {
                if (radioDecimal.Checked) // decimal para binario
                {
                    calcularHexaBin(2);
                }

                else if (radioHexadecimal.Checked)
                {
                    calcularHexToBinary();
                }

                else if (textButton.Checked)
                {
                    if (numeroBox.Text == "")
                    {
                        MessageBox.Show("Digite um texto", "Aviso Importante!");
                    }

                    else
                    {
                        caixaResultado.Text = textoToBinario(numeroBox.Text,2);
                    }  
                }
                
                else
                {
                    MessageBox.Show("Marque uma opção!","Aviso Importante!");
                }
                
            }

            catch(Exception)
            {
                avisoErros("Ocorreu um erro!");
            }

        }

        private void hexaButton_Click(object sender, EventArgs e) // converter para hexadecimal
        {
            try
            {
                if (radioDecimal.Checked)
                {
                    calcularHexaBin(16);   
                }

                else if (radioBinario.Checked)
                {
                    calcularHex();
                }

                else if (textButton.Checked)
                {
                    if (numeroBox.Text == "")
                    {
                        MessageBox.Show("Digite um texto", "Aviso Importante!");
                    }

                    else
                    {
                        caixaResultado.Text = paraHexa(numeroBox.Text);
                    }
                }

                else
                {
                    MessageBox.Show("Marque uma opção!", "Aviso Importante!");
                }
            }

            catch(Exception)
            {
                avisoErros("Ocorreu um erro!");
            }
        }

        private void button2_Click(object sender, EventArgs e) // converter para decimal
        {
            try
            {
                if (radioBinario.Checked)
                {
                    calcularDeci();
                }

                else if (textButton.Checked)
                {
                    int m = Int32.Parse("abc");
                    Console.WriteLine(m);
                }

                else if (radioHexadecimal.Checked)
                {
                    calcularHexaToDecimal();
                }

                else
                {
                    MessageBox.Show("Marque uma opção!", "Aviso Importante!");
                }
            }

            catch (Exception)
            {
                avisoErros("Ocorreu um erro!");
            }
        }

        public void calcularHexaBin(int numero)
        {
            if (numeroBox.Text == "")
            {
                avisoErros("Digite um número para ser convertido");
            }
            else
            {
                int numeroDigitado = Convert.ToInt32(numeroBox.Text);
                string resultadoFinal = Convert.ToString(numeroDigitado, numero);
                caixaResultado.Text = resultadoFinal;
            }
        }

        public void calcularDeci()
        {
            if (numeroBox.Text == "")
            {
                avisoErros("Digite um número para ser convertido");
            }
            else
            {
                int numeroDigitado = Convert.ToInt32(numeroBox.Text, 2);
                caixaResultado.Text = numeroDigitado.ToString();
            } 
        }

        public void calcularHex()
        {
            if (numeroBox.Text == "")
            {
                avisoErros("Digite um número para ser convertido");
            }
            else
            {
                string numeroDigitado = Convert.ToInt32(numeroBox.Text, 2).ToString("X");
                caixaResultado.Text = numeroDigitado;
            }  
        }

        public void calcularHexToBinary()
        {
            if (numeroBox.Text == "")
            {
                avisoErros("Digite um número para ser convertido");
            }

            else
            {
                string numeroDigitado = Convert.ToString(Convert.ToInt64(numeroBox.Text, 16), 2);
                caixaResultado.Text = numeroDigitado;
            }   
        }

        public void calcularHexaToDecimal()
        {
            if (numeroBox.Text == "")
            {
                avisoErros("Digite um número para ser convertido");
            }

            else
            {
                double numeroDigitado = Convert.ToInt64(numeroBox.Text, 16);
                caixaResultado.Text = numeroDigitado.ToString();
            }   
        }

        public string textoToBinario(string inp, int numero)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char L in inp.ToCharArray())
                {
                    sb.Append(Convert.ToString(L, numero).PadLeft(8, '0'));
                }

                return sb.ToString();
        }

        public string paraHexa(string inp)
        {
            string outpt = string.Empty;
            char[] value = inp.ToCharArray();
            foreach(Char L in value)
                {
                    int V = Convert.ToInt32(L);
                    outpt += string.Format("{0:x}", V);
                }

            return outpt;
        }

        public void avisoErros(string mensagem)
        {
            MessageBox.Show(mensagem, "Aviso Importante");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Usuário, seja bem vindo!", "Aviso Importante");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Criptografia novaForm = new Criptografia();
            novaForm.Show();
        }

        private void textButton_CheckedChanged(object sender, EventArgs e)
        {
            if (textButton.Checked)
            {
                converterParaDeci.Enabled = false;
            }

            else
            {
                converterParaDeci.Enabled = true;
            }
        }

        private void radioBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBinario.Checked)
            {
                converterParaBinario.Enabled = false;
            }
            else
            {
                converterParaBinario.Enabled = true;
            }
        }

        private void radioHexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHexadecimal.Checked)
            {
                converterParaHexa.Enabled = false;
            }
            else
            {
                converterParaHexa.Enabled = true;
            }
        }

        private void radioDecimal_CheckedChanged(object sender, EventArgs e)
        {

            if (radioDecimal.Checked)
            {
                converterParaDeci.Enabled = false;
            }
            else
            {
                converterParaDeci.Enabled = true;
            }
        }
    }
}
