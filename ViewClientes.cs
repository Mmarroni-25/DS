using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTATO_ofc.Forms
{
    public partial class ViewClientes : Form
    {
        public ViewClientes()
        {
            InitializeComponent();
            exibir2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exibir2()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            SqlDataAdapter adapt;

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT Id, nome, sobrenome, cpf, telefone, email, bairro, logradouro, numero, complemento FROM Clientes WHERE cpf != ''", con);
            adapt.Fill(dt);
            dataGrid2.DataSource = dt;
        }

        private void filtro_juridico_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            SqlDataAdapter adapt;

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT Id, razao_social, cnpj, telefone, email, bairro, logradouro, numero, complemento FROM Clientes WHERE cnpj != '' ", con);
            adapt.Fill(dt);
            dataGrid2.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            SqlDataAdapter adapt;

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT Id, nome, sobrenome, cpf, telefone, email, bairro, logradouro, numero, complemento FROM Clientes WHERE cpf != ''", con);
            adapt.Fill(dt);
            dataGrid2.DataSource = dt;
        }
    }
}
