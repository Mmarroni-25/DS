namespace ESTATO_ofc.Forms
{
    partial class ViewPropostas
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.detail = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.Base = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(39, 27);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(341, 289);
            this.dataGrid.TabIndex = 0;
            // 
            // detail
            // 
            this.detail.BackColor = System.Drawing.Color.Orange;
            this.detail.Location = new System.Drawing.Point(420, 45);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(5, 247);
            this.detail.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(570, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 26);
            this.label12.TabIndex = 43;
            this.label12.Text = "Filtros";
            // 
            // Base
            // 
            this.Base.Controls.Add(this.Status);
            this.Base.Controls.Add(this.label2);
            this.Base.Controls.Add(this.dataGrid);
            this.Base.Controls.Add(this.label12);
            this.Base.Controls.Add(this.detail);
            this.Base.Location = new System.Drawing.Point(-2, -3);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(804, 350);
            this.Base.TabIndex = 44;
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Proposta ganha (PG)",
            "Proposta perdida (PP)",
            "Proposta Indefinida (IND)"});
            this.Status.Location = new System.Drawing.Point(450, 100);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(116, 21);
            this.Status.TabIndex = 50;
            this.Status.Text = "Selecionar";
            this.Status.SelectedIndexChanged += new System.EventHandler(this.Status_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(446, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Status:";
            // 
            // ViewPropostas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.Base);
            this.Name = "ViewPropostas";
            this.Text = "ViewPropostas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.Base.ResumeLayout(false);
            this.Base.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel detail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel Base;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label2;
    }
}