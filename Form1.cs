using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UpperInfo
{
    public partial class Form1 : Form
    {
        Form2 form2;
        DataTable dt = new DataTable();

        public Form1(Form2 f)
        {
            InitializeComponent();
            form2 = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string senha = textBox2.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário ou senha invalidos!");
                textBox1.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME='"+username+"' AND T_SENHAUSUARIO='"+senha+"'";
            dt = Banco.consulta(sql);
            if (dt.Rows.Count == 1)
            {
                form2.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form2.lb_nomeusuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                form2.pb_ledLogado.Image = Properties.Resources.Cute_Ball_Go_icon;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {            
                MessageBox.Show("Usuário não encontrado!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
