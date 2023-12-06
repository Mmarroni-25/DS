namespace ESTATO_ofc.Forms
{
    partial class Nova_Proposta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Base = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Situation = new System.Windows.Forms.ComboBox();
            this.Conatato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Complemento2 = new System.Windows.Forms.TextBox();
            this.Logradouro2 = new System.Windows.Forms.TextBox();
            this.Num = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Bairro2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vlor_negoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vlr_aprese = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Observacao = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Servico = new System.Windows.Forms.ComboBox();
            this.cadastrarProp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Quant = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.TextBox();
            this.Base.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Base
            // 
            this.Base.BackColor = System.Drawing.SystemColors.Control;
            this.Base.Controls.Add(this.panel3);
            this.Base.Location = new System.Drawing.Point(-1, -1);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(807, 358);
            this.Base.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.Situation);
            this.panel3.Controls.Add(this.Conatato);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.Complemento2);
            this.panel3.Controls.Add(this.Logradouro2);
            this.panel3.Controls.Add(this.Num);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.Bairro2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.vlor_negoc);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.vlr_aprese);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Observacao);
            this.panel3.Controls.Add(this.Status);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Servico);
            this.panel3.Controls.Add(this.cadastrarProp);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.Quant);
            this.panel3.Controls.Add(this.Data);
            this.panel3.Location = new System.Drawing.Point(13, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 306);
            this.panel3.TabIndex = 15;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(339, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 76;
            this.label7.Text = "Situação:";
            // 
            // Situation
            // 
            this.Situation.FormattingEnabled = true;
            this.Situation.Items.AddRange(new object[] {
            "Não iniciado ",
            "Iniciado",
            "Concluído"});
            this.Situation.Location = new System.Drawing.Point(339, 173);
            this.Situation.Name = "Situation";
            this.Situation.Size = new System.Drawing.Size(116, 21);
            this.Situation.TabIndex = 77;
            this.Situation.Text = "Selecionar";
            // 
            // Conatato
            // 
            this.Conatato.Location = new System.Drawing.Point(24, 119);
            this.Conatato.Name = "Conatato";
            this.Conatato.Size = new System.Drawing.Size(105, 20);
            this.Conatato.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(494, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "Número:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(339, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 19);
            this.label13.TabIndex = 72;
            this.label13.Text = "Complemento:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label14.Location = new System.Drawing.Point(167, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 19);
            this.label14.TabIndex = 71;
            this.label14.Text = "Logradouro:";
            // 
            // Complemento2
            // 
            this.Complemento2.Location = new System.Drawing.Point(343, 119);
            this.Complemento2.Name = "Complemento2";
            this.Complemento2.Size = new System.Drawing.Size(121, 20);
            this.Complemento2.TabIndex = 70;
            // 
            // Logradouro2
            // 
            this.Logradouro2.Location = new System.Drawing.Point(167, 238);
            this.Logradouro2.Name = "Logradouro2";
            this.Logradouro2.Size = new System.Drawing.Size(118, 20);
            this.Logradouro2.TabIndex = 68;
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(498, 57);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(118, 20);
            this.Num.TabIndex = 66;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label18.Location = new System.Drawing.Point(337, 212);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 19);
            this.label18.TabIndex = 67;
            this.label18.Text = "Bairro:";
            // 
            // Bairro2
            // 
            this.Bairro2.Location = new System.Drawing.Point(337, 234);
            this.Bairro2.Name = "Bairro2";
            this.Bairro2.Size = new System.Drawing.Size(118, 20);
            this.Bairro2.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(167, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Valor negociado:";
            // 
            // vlor_negoc
            // 
            this.vlor_negoc.Location = new System.Drawing.Point(171, 119);
            this.vlor_negoc.Name = "vlor_negoc";
            this.vlor_negoc.Size = new System.Drawing.Size(124, 20);
            this.vlor_negoc.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(167, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Valor apresentado:";
            // 
            // vlr_aprese
            // 
            this.vlr_aprese.Location = new System.Drawing.Point(171, 57);
            this.vlr_aprese.Name = "vlr_aprese";
            this.vlr_aprese.Size = new System.Drawing.Size(124, 20);
            this.vlr_aprese.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(20, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Observação:";
            // 
            // Observacao
            // 
            this.Observacao.Location = new System.Drawing.Point(24, 241);
            this.Observacao.Name = "Observacao";
            this.Observacao.Size = new System.Drawing.Size(105, 20);
            this.Observacao.TabIndex = 16;
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Proposta ganha (PG)",
            "Proposta perdida (PP)",
            "Proposta Indefinida (IND)"});
            this.Status.Location = new System.Drawing.Point(171, 173);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(116, 21);
            this.Status.TabIndex = 15;
            this.Status.Text = "Selecionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(167, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Status:";
            // 
            // Servico
            // 
            this.Servico.FormattingEnabled = true;
            this.Servico.Items.AddRange(new object[] {
            "LEP",
            "LEPA",
            "LEPAC",
            "GEO",
            "OBRA",
            "LOC",
            "AS BUILT"});
            this.Servico.Location = new System.Drawing.Point(24, 173);
            this.Servico.Name = "Servico";
            this.Servico.Size = new System.Drawing.Size(105, 21);
            this.Servico.TabIndex = 13;
            this.Servico.Text = "Selecionar";
            // 
            // cadastrarProp
            // 
            this.cadastrarProp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cadastrarProp.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarProp.ForeColor = System.Drawing.Color.PapayaWhip;
            this.cadastrarProp.Location = new System.Drawing.Point(575, 223);
            this.cadastrarProp.Name = "cadastrarProp";
            this.cadastrarProp.Size = new System.Drawing.Size(116, 44);
            this.cadastrarProp.TabIndex = 11;
            this.cadastrarProp.Text = "Cadastrar";
            this.cadastrarProp.UseVisualStyleBackColor = false;
            this.cadastrarProp.Click += new System.EventHandler(this.cadastrarProp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(340, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Quantidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(20, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Serviço:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(20, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "Contato:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(20, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Data:";
            // 
            // Quant
            // 
            this.Quant.Location = new System.Drawing.Point(344, 57);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(116, 20);
            this.Quant.TabIndex = 6;
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(24, 57);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(105, 20);
            this.Data.TabIndex = 0;
            // 
            // Nova_Proposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.Base);
            this.Name = "Nova_Proposta";
            this.Text = "Nova_Proposta";
            this.Base.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Base;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Observacao;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Servico;
        private System.Windows.Forms.Button cadastrarProp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Quant;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vlor_negoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vlr_aprese;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Complemento2;
        private System.Windows.Forms.TextBox Logradouro2;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Bairro2;
        private System.Windows.Forms.TextBox Conatato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Situation;
    }
}