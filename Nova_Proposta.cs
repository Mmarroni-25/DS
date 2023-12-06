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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ESTATO_ofc.Forms
{
    public partial class Nova_Proposta : Form
    {
        public Nova_Proposta()
        {
            InitializeComponent();
        }

        private void cadastrarProp_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                conn.Open();

                string data = Data.Text;
                string bairro = Bairro2.Text;
                string logradouro = Logradouro2.Text;
                string numero = Num.Text;
                string complemento = Complemento2.Text;
                string vlr_apresentado = vlr_aprese.Text;
                string vlr_negociado = vlor_negoc.Text;
                string observacao = Observacao.Text;
                string contato = Conatato.Text;
                string servico = Servico.Text;
                string status = Status.Text;
                string situacao = Situation.Text;

                SqlCommand insertCommand = new SqlCommand("INSERT INTO Propostas (data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, contato, servico, status, situacao) VALUES (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)", conn);

                insertCommand.Parameters.Add(new SqlParameter("0", data));
                insertCommand.Parameters.Add(new SqlParameter("1", logradouro));
                insertCommand.Parameters.Add(new SqlParameter("2", bairro));
                insertCommand.Parameters.Add(new SqlParameter("3", numero));
                insertCommand.Parameters.Add(new SqlParameter("4", complemento));
                insertCommand.Parameters.Add(new SqlParameter("5", vlr_apresentado));
                insertCommand.Parameters.Add(new SqlParameter("6", vlr_negociado));
                insertCommand.Parameters.Add(new SqlParameter("7", observacao));
                insertCommand.Parameters.Add(new SqlParameter("8", contato));
                insertCommand.Parameters.Add(new SqlParameter("9", servico));
                insertCommand.Parameters.Add(new SqlParameter("10", status));
                insertCommand.Parameters.Add(new SqlParameter("11", situacao));

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("deu certo rapa");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
