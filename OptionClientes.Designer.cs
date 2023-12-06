namespace ESTATO_ofc.Forms
{
    partial class OptionClientes
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
            this.detail = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // Base
            // 
            this.Base.BackColor = System.Drawing.Color.White;
            this.Base.Controls.Add(this.detail);
            this.Base.Controls.Add(this.label12);
            this.Base.Controls.Add(this.button2);
            this.Base.Controls.Add(this.button1);
            this.Base.Location = new System.Drawing.Point(-2, -1);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(809, 455);
            this.Base.TabIndex = 0;
            // 
            // detail
            // 
            this.detail.BackColor = System.Drawing.Color.Orange;
            this.detail.Location = new System.Drawing.Point(323, 86);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(141, 5);
            this.detail.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(319, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 45);
            this.label12.TabIndex = 40;
            this.label12.Text = "Clientes";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(233, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(320, 52);
            this.button2.TabIndex = 39;
            this.button2.Text = "Ver meus clientes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(233, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 52);
            this.button1.TabIndex = 38;
            this.button1.Text = "Cadastrar um cliente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OptionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Base);
            this.Name = "OptionClientes";
            this.Text = "OptionClientes";
            this.Base.ResumeLayout(false);
            this.Base.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Base;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel detail;
    }
}