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
    public partial class F_Gestaousuarios : Form
    {
        public F_Gestaousuarios()
        {
            InitializeComponent();
        }

        private void F_Gestaousuarios_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.obterUsuariosidnome();
            dgv_usuarios.Columns[0].Width = 85;
            dgv_usuarios.Columns[1].Width = 190;
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if(contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt=Banco.obterdadosusuario(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO").ToString();
                n_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");
            }
          
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_novocolaborador f_Novocolaborador = new F_novocolaborador();
            f_Novocolaborador.ShowDialog();
            dgv_usuarios.DataSource = Banco.obterUsuariosidnome();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_usuarios.SelectedRows[0].Index;
            colaborador u = new colaborador();
            u.id = Convert.ToInt32(tb_id.Text);
            u.nome = tb_nome.Text;
            u.username = tb_username.Text;
            u.senha = tb_senha.Text;
            u.nivel =Convert.ToInt32( Math.Round( n_nivel.Value));
            Banco.AtualizarOperador(u);
            //dgv_usuarios.DataSource = Banco.obterUsuariosidnome();
            //dgv_usuarios.DataSource = dgv_usuarios [0, linha];
            dgv_usuarios[1, linha].Value = tb_nome.Text;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if(res== DialogResult.Yes)
            {
                Banco.DeletarUsuario(tb_id.Text);
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
            }
        }

        private void dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
