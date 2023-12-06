namespace ESTATO_ofc.Forms
{
    partial class ViewClientes
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
            this.button1 = new System.Windows.Forms.Button();
            this.filtro_juridico = new System.Windows.Forms.Button();
            this.dataGrid2 = new System.Windows.Forms.DataGridView();
            this.detail = new System.Windows.Forms.Panel();
            this.Base.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // Base
            // 
            this.Base.Controls.Add(this.button1);
            this.Base.Controls.Add(this.filtro_juridico);
            this.Base.Controls.Add(this.dataGrid2);
            this.Base.Controls.Add(this.detail);
            this.Base.Location = new System.Drawing.Point(-2, -7);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(804, 350);
            this.Base.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(524, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 53);
            this.button1.TabIndex = 46;
            this.button1.Text = "Clientes físicos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filtro_juridico
            // 
            this.filtro_juridico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filtro_juridico.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro_juridico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filtro_juridico.Location = new System.Drawing.Point(524, 78);
            this.filtro_juridico.Name = "filtro_juridico";
            this.filtro_juridico.Size = new System.Drawing.Size(176, 53);
            this.filtro_juridico.TabIndex = 45;
            this.filtro_juridico.Text = "Clientes juridicos";
            this.filtro_juridico.UseVisualStyleBackColor = false;
            this.filtro_juridico.Click += new System.EventHandler(this.filtro_juridico_Click);
            // 
            // dataGrid2
            // 
            this.dataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid2.Location = new System.Drawing.Point(40, 36);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(295, 277);
            this.dataGrid2.TabIndex = 44;
            // 
            // detail
            // 
            this.detail.BackColor = System.Drawing.Color.Orange;
            this.detail.Location = new System.Drawing.Point(424, 48);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(5, 247);
            this.detail.TabIndex = 42;
            // 
            // ViewClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.Base);
            this.Name = "ViewClientes";
            this.Text = "ViewClientes";
            this.Base.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Base;
        private System.Windows.Forms.Panel detail;
        private System.Windows.Forms.DataGridView dataGrid2;
        private System.Windows.Forms.Button filtro_juridico;
        private System.Windows.Forms.Button button1;
    }
}