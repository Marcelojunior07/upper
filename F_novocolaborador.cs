using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpperInfo
{
    public partial class F_novocolaborador : Form
    {
        public F_novocolaborador()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            colaborador colaborador = new colaborador();
            colaborador.nome = tb_nome.Text;
            colaborador.username = tb_username.Text;
            colaborador.senha = tb_senha.Text;
            colaborador.nivel = Convert.ToInt32(Math.Round(n_nivel.Value,0));

            Banco.NovoColaborador(colaborador);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();         
            n_nivel.Value = 1;
            btn_novo.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();
            n_nivel.Value = 1;
            tb_nome.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F_novocolaborador_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void n_nivel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
