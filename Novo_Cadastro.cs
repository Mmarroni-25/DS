using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESTATO_ofc.Model;

namespace ESTATO_ofc.Forms
{
    public partial class Novo_Cadastro : Form
    {
        //var nome = new NovoCadastro();

        public Novo_Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fisicPanel.Visible = true;
            juridicPanel.Visible = false;
            detail.BackColor = Color.IndianRed;
            button1.BackColor = Color.IndianRed;
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fisicPanel.Visible = false;
            juridicPanel.Visible = true;
            detail.BackColor = Color.YellowGreen;
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.YellowGreen;
        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                conn.Open();

                string nome = Nome.Text;
                string sobrenome = Sobrenome.Text;
                string cpf = CPF.Text;
                string telefone = Telefone.Text;
                string email = Email.Text;
                string bairro = Bairro.Text;
                string logradouro = Logradouro.Text;
                string numero = Num.Text;
                string complemento = Complemento.Text;

                SqlCommand insertCommand = new SqlCommand("INSERT INTO Clientes (nome, sobrenome, cpf, telefone, email, bairro, logradouro, numero, complemento) VALUES (@0, @1, @2, @3, @4, @5, @6, @7, @8)", conn);

                insertCommand.Parameters.Add(new SqlParameter("0", nome));
                insertCommand.Parameters.Add(new SqlParameter("1", sobrenome));
                insertCommand.Parameters.Add(new SqlParameter("2", cpf));
                insertCommand.Parameters.Add(new SqlParameter("3", telefone));
                insertCommand.Parameters.Add(new SqlParameter("4", email));
                insertCommand.Parameters.Add(new SqlParameter("5", bairro));
                insertCommand.Parameters.Add(new SqlParameter("6", logradouro));
                insertCommand.Parameters.Add(new SqlParameter("7", numero));
                insertCommand.Parameters.Add(new SqlParameter("8", complemento));
                // insertCommand.Parameters.Add(new SqlParameter("4", endereco));

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("deu certo rapa");
            }
        }

        private void fisicPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cadastrarJurudic_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                conn.Open();

                string razao = razao_social.Text;
                string cnpj = CNPJ.Text;
                string telefone = Telefone2.Text;
                string email = Email2.Text;
                string bairro = Bairro2.Text;
                string logradouro = Logradouro2.Text;
                string numero = Num2.Text;
                string complemento = Complemento2.Text;

                SqlCommand insertCommand = new SqlCommand("INSERT INTO Clientes (razao_social, cnpj, telefone, email, bairro, logradouro, numero, complemento) VALUES (@0, @1, @2, @3, @4, @5, @6, @7)", conn);

                insertCommand.Parameters.Add(new SqlParameter("0", razao));
                insertCommand.Parameters.Add(new SqlParameter("1", cnpj));
                insertCommand.Parameters.Add(new SqlParameter("2", telefone));
                insertCommand.Parameters.Add(new SqlParameter("3", email));
                insertCommand.Parameters.Add(new SqlParameter("4", bairro));
                insertCommand.Parameters.Add(new SqlParameter("5", logradouro));
                insertCommand.Parameters.Add(new SqlParameter("6", numero));
                insertCommand.Parameters.Add(new SqlParameter("7", complemento));
                // insertCommand.Parameters.Add(new SqlParameter("4", endereco));

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("também deu certo rapa");
            }
        }
    }
}
