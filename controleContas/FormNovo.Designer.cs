namespace controleContas
{
    partial class FormNovo
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.nomeNovo = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.Label();
            this.anoNascimento = new System.Windows.Forms.Label();
            this.cpfNovo = new System.Windows.Forms.TextBox();
            this.anoNascimentoNovo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(291, 224);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 34);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Nome
            // 
            this.Nome.AccessibleName = "";
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(101, 57);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(67, 24);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome:";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomeNovo
            // 
            this.nomeNovo.Location = new System.Drawing.Point(169, 61);
            this.nomeNovo.Name = "nomeNovo";
            this.nomeNovo.Size = new System.Drawing.Size(232, 20);
            this.nomeNovo.TabIndex = 2;
            this.nomeNovo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(101, 102);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(52, 24);
            this.cpf.TabIndex = 3;
            this.cpf.Text = "CPF:";
            // 
            // anoNascimento
            // 
            this.anoNascimento.AutoSize = true;
            this.anoNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoNascimento.Location = new System.Drawing.Point(102, 145);
            this.anoNascimento.Name = "anoNascimento";
            this.anoNascimento.Size = new System.Drawing.Size(182, 24);
            this.anoNascimento.TabIndex = 4;
            this.anoNascimento.Text = "Ano de Nascimento:";
            this.anoNascimento.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cpfNovo
            // 
            this.cpfNovo.Location = new System.Drawing.Point(169, 105);
            this.cpfNovo.Name = "cpfNovo";
            this.cpfNovo.Size = new System.Drawing.Size(232, 20);
            this.cpfNovo.TabIndex = 5;
            this.cpfNovo.TextChanged += new System.EventHandler(this.cpfNovo_TextChanged);
            // 
            // anoNascimentoNovo
            // 
            this.anoNascimentoNovo.Location = new System.Drawing.Point(291, 148);
            this.anoNascimentoNovo.Name = "anoNascimentoNovo";
            this.anoNascimentoNovo.Size = new System.Drawing.Size(110, 20);
            this.anoNascimentoNovo.TabIndex = 6;
            this.anoNascimentoNovo.TextChanged += new System.EventHandler(this.anoNascimentoNovo_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(140, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 342);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.anoNascimentoNovo);
            this.Controls.Add(this.cpfNovo);
            this.Controls.Add(this.anoNascimento);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.nomeNovo);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FormNovo";
            this.Text = "FormNovo";
            this.Load += new System.EventHandler(this.FormNovo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox nomeNovo;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label anoNascimento;
        private System.Windows.Forms.TextBox cpfNovo;
        private System.Windows.Forms.TextBox anoNascimentoNovo;
        private System.Windows.Forms.Button btnCancel;
    }
}