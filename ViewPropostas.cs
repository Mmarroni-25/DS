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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ESTATO_ofc.Forms
{
    public partial class ViewPropostas : Form
    {
        public ViewPropostas()
        {
            InitializeComponent();
            exibir();
        }

        private void exibir()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            SqlDataAdapter adapt;

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas", con);
            adapt.Fill(dt);
            dataGrid.DataSource = dt;
        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = Status.SelectedItem.ToString();

            // Verifique se a opção selecionada é "Visível"


            if (selectedItem == "Proposta ganha (PG)")
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

                SqlDataAdapter adapt;

                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'Proposta ganha (PG)'", con);
                adapt.Fill(dt);
                dataGrid.DataSource = dt;
            }
            else if (selectedItem == "Proposta perdida (PP)")
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

                SqlDataAdapter adapt;

                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'Proposta perdida (PP)'", con);
                adapt.Fill(dt);
                dataGrid.DataSource = dt;
            }
            else if (selectedItem == "Proposta Indefinida (IND)")
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

                SqlDataAdapter adapt;

                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'Proposta Indefinida (IND)'", con);
                adapt.Fill(dt);
                dataGrid.DataSource = dt;
            }
        }

        private void Situation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedItem = Situation.SelectedItem.ToString();


            //if (selectedItem == "Não iniciado")
            //{
            //    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            //    SqlDataAdapter adapt;

            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'Não iniciado'", con);
            //    adapt.Fill(dt);
            //    dataGrid.DataSource = dt;
            //}
            //else if (selectedItem == "Iniciado")
            //{
            //    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            //    SqlDataAdapter adapt;

            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'Iniciado'", con);
            //    adapt.Fill(dt);
            //    dataGrid.DataSource = dt;
            //}
            //else if (selectedItem == "Concluído")
            //{
            //    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            //    SqlDataAdapter adapt;

            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'Concluído'", con);
            //    adapt.Fill(dt);
            //    dataGrid.DataSource = dt;
            //}
        }

        private void Servico_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedItem = Servico.SelectedItem.ToString();


            //if (selectedItem == "LEP")
            //{
            //    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            //    SqlDataAdapter adapt;

            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'LEP'", con);
            //    adapt.Fill(dt);
            //    dataGrid.DataSource = dt;
            //}
            //else if (selectedItem == "LEPA")
            //{
            //    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            //    SqlDataAdapter adapt;

            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'LEPA'", con);
            //    adapt.Fill(dt);
            //    dataGrid.DataSource = dt;
            //}
            //else if (selectedItem == "LEPAC")
            //{
            //    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            //    SqlDataAdapter adapt;

            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'LEPAC'", con);
            //    adapt.Fill(dt);
            //    dataGrid.DataSource = dt;
            //}
            //else if (selectedItem == "GEO")
            //{
            //    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            //    SqlDataAdapter adapt;

            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'GEO'", con);
            //    adapt.Fill(dt);
            //    dataGrid.DataSource = dt;
            //}
            //else if (selectedItem == "OBRA")
            //{
            //    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            //    SqlDataAdapter adapt;

            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'OBRA'", con);
            //    adapt.Fill(dt);
            //    dataGrid.DataSource = dt;
            //}
            //else if (selectedItem == "LOC")
            //{
            //    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            //    SqlDataAdapter adapt;

            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'LOC'", con);
            //    adapt.Fill(dt);
            //    dataGrid.DataSource = dt;
            //}
            //else if (selectedItem == "AS BUILT")
            //{
            //    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ESTATO_BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            //    SqlDataAdapter adapt;

            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adapt = new SqlDataAdapter("SELECT Id, data_proposta, logradouro, bairro, numero, complemento, valor_apresentado, valor_negociado, observacao, complemento, contato, servico, status, situacao FROM Propostas WHERE status = 'AS BUILT'", con);
            //    adapt.Fill(dt);
            //    dataGrid.DataSource = dt;
            //}
        }
    }
}
