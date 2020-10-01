using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDeVerificação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Funcionalidades obj = new Funcionalidades();

            if (!obj.ValidaNome(textBoxName.Text))
            {
                textBoxName.Focus();
                MessageBox.Show("CAMPOS OBRIGATORIOS 'NOME' ", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!obj.ValidaVaga(comboBox1.SelectedIndex))
            {
                comboBox1.Focus();
                MessageBox.Show("CAMPOS OBRIGATORIOS 'VAGA' ", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NumeroRecado.MaskCompleted)
            {
                if (string.IsNullOrEmpty(NomeRecado.Text))
                {
                    MessageBox.Show("COLOQUE UM NOME PARA RECADO...", "Atenção",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("FORMULARIO PREENCHIDO COM SUCESSO", "Atenção",
              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("FORMULARIO PREENCHIDO COM SUCESSO", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NumeroRecado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
    
        }
    }
}
