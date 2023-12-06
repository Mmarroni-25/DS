using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTATO_ofc.Forms
{
    public partial class OptionPropostas : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public OptionPropostas()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Base.Controls.Add(childForm);
            this.Base.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Novo_Cadastro(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ViewPropostas(), sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Nova_Proposta(), sender);
        }
    }
}
