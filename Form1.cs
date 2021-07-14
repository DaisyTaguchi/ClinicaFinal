using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Médico_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Deseja finalizar a aplicação?");
           

           if (mensagem == System.Windows.Forms.DialogResult.Yes)

            {
                Close();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtPaciente.Text;
            string nascimento = dateTimePicker2.Text;
            string profissao = txtProfissao.Text;

            if (nome.Length > 0 && nascimento.Length > 0 && profissao.Length > 0)

            {
                string mensagem = string.Format("Agendamento concluído", nome, nascimento,profissao);

                MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
        }

       

        
        }
}

