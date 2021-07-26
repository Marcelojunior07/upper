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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form1 form1 = new Form1(this);
            form1.ShowDialog();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void logofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeusuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.Cute_Ball_Stop_icon;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestãToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if(Globais.nivel >= 3)
                {

                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_novocolaborador f_novocolaborador = new F_novocolaborador();
                    f_novocolaborador.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_Gestaousuarios f_Gestaousuarios = new F_Gestaousuarios();
                    f_Gestaousuarios.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void limpar()
        {
            tb_obs.Clear();
            tb_placa.Clear();
            tb_resp.Clear();
            tb_prev.Clear();
            tb_placa.Focus();
        }


        private void Adicionar_Click(object sender, EventArgs e)
        {
            if (tb_placa .Text== "")
            {
                MessageBox.Show("Placa não pode ser vazio!");
                tb_placa.Focus();
                return;
                
            }
            if (tb_obs.Text == "")
            {
                MessageBox.Show("Observação não pode ser vazio!");
                tb_placa.Focus();
                return;
            }
            if (tb_resp.Text == "")
            {
                MessageBox.Show("Responsável não pode ser vazio!");
                tb_placa.Focus();
                return;
            }
            if(tb_prev.Text == "")
            {
                MessageBox.Show("Previsão não pode ser vazio!");
                tb_placa.Focus();
                return;
            }


                string[] pr = new string[4];
            pr[0] = tb_placa.Text;
            pr[1] = tb_obs.Text;
            pr[2] = tb_resp.Text;
            pr[3] = tb_prev.Text;

            ListViewItem l = new ListViewItem(pr);
            lv_geral.Items.Add(l);
            limpar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            lv_geral.Items.RemoveAt(lv_geral.SelectedIndices[0]);
        }

        private void btn_obt_Click(object sender, EventArgs e)
        {
            tb_placa.Text = lv_geral.SelectedItems[0].SubItems[0].Text;
            tb_obs.Text = lv_geral.SelectedItems[0].SubItems[1].Text;
            tb_prev.Text = lv_geral.SelectedItems[0].SubItems[2].Text;
            tb_resp.Text = lv_geral.SelectedItems[0].SubItems[3].Text;

        }

        private void lb_nomeusuario_Click(object sender, EventArgs e)
        {

        }
    }
}

