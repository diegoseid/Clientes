namespace Clientes
{
    partial class Form_Detalhes
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
            this.maskedTextTelefone = new System.Windows.Forms.MaskedTextBox();
            this.butAdicionar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.textEmailProfissional = new System.Windows.Forms.TextBox();
            this.textEmailPessoal = new System.Windows.Forms.TextBox();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butEditPR = new System.Windows.Forms.Button();
            this.dgvTelefones = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.butRemoverTelefone = new System.Windows.Forms.Button();
            this.butEditPE = new System.Windows.Forms.Button();
            this.butRemovPR = new System.Windows.Forms.Button();
            this.butRemovPE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextTelefone
            // 
            this.maskedTextTelefone.Location = new System.Drawing.Point(78, 158);
            this.maskedTextTelefone.Mask = "00 00000-0000";
            this.maskedTextTelefone.Name = "maskedTextTelefone";
            this.maskedTextTelefone.Size = new System.Drawing.Size(96, 20);
            this.maskedTextTelefone.TabIndex = 29;
            // 
            // butAdicionar
            // 
            this.butAdicionar.Location = new System.Drawing.Point(357, 158);
            this.butAdicionar.Name = "butAdicionar";
            this.butAdicionar.Size = new System.Drawing.Size(61, 23);
            this.butAdicionar.TabIndex = 28;
            this.butAdicionar.Text = "Adicionar";
            this.butAdicionar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Celular",
            "Fax",
            "Outros"});
            this.cbTipo.Location = new System.Drawing.Point(230, 159);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Email Pessoal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email Profissional:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome Completo:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(103, 19);
            this.textNome.Name = "textNome";
            this.textNome.ReadOnly = true;
            this.textNome.Size = new System.Drawing.Size(190, 20);
            this.textNome.TabIndex = 30;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Enabled = false;
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(110, 45);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(97, 20);
            this.dtpNascimento.TabIndex = 31;
            // 
            // textEmailProfissional
            // 
            this.textEmailProfissional.Location = new System.Drawing.Point(123, 76);
            this.textEmailProfissional.Name = "textEmailProfissional";
            this.textEmailProfissional.ReadOnly = true;
            this.textEmailProfissional.Size = new System.Drawing.Size(100, 20);
            this.textEmailProfissional.TabIndex = 32;
            // 
            // textEmailPessoal
            // 
            this.textEmailPessoal.Location = new System.Drawing.Point(123, 112);
            this.textEmailPessoal.Name = "textEmailPessoal";
            this.textEmailPessoal.ReadOnly = true;
            this.textEmailPessoal.Size = new System.Drawing.Size(100, 20);
            this.textEmailPessoal.TabIndex = 33;
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(15, 261);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(75, 23);
            this.butCancelar.TabIndex = 34;
            this.butCancelar.Text = "Cacelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // butEditPR
            // 
            this.butEditPR.Location = new System.Drawing.Point(243, 68);
            this.butEditPR.Name = "butEditPR";
            this.butEditPR.Size = new System.Drawing.Size(50, 23);
            this.butEditPR.TabIndex = 35;
            this.butEditPR.Text = "Editar";
            this.butEditPR.UseVisualStyleBackColor = true;
            // 
            // dgvTelefones
            // 
            this.dgvTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefones.Location = new System.Drawing.Point(450, 26);
            this.dgvTelefones.Name = "dgvTelefones";
            this.dgvTelefones.Size = new System.Drawing.Size(194, 213);
            this.dgvTelefones.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Telefones Adicionados";
            // 
            // butRemoverTelefone
            // 
            this.butRemoverTelefone.Location = new System.Drawing.Point(450, 261);
            this.butRemoverTelefone.Name = "butRemoverTelefone";
            this.butRemoverTelefone.Size = new System.Drawing.Size(211, 23);
            this.butRemoverTelefone.TabIndex = 39;
            this.butRemoverTelefone.Text = "Remover Telefone Selecionado";
            this.butRemoverTelefone.UseVisualStyleBackColor = true;
            this.butRemoverTelefone.Click += new System.EventHandler(this.butRemoverTelefone_Click);
            // 
            // butEditPE
            // 
            this.butEditPE.Location = new System.Drawing.Point(243, 110);
            this.butEditPE.Name = "butEditPE";
            this.butEditPE.Size = new System.Drawing.Size(50, 23);
            this.butEditPE.TabIndex = 40;
            this.butEditPE.Text = "Editar";
            this.butEditPE.UseVisualStyleBackColor = true;
            // 
            // butRemovPR
            // 
            this.butRemovPR.Location = new System.Drawing.Point(299, 68);
            this.butRemovPR.Name = "butRemovPR";
            this.butRemovPR.Size = new System.Drawing.Size(65, 23);
            this.butRemovPR.TabIndex = 42;
            this.butRemovPR.Text = "Remover";
            this.butRemovPR.UseVisualStyleBackColor = true;
            this.butRemovPR.Click += new System.EventHandler(this.butRemovPR_Click);
            // 
            // butRemovPE
            // 
            this.butRemovPE.Location = new System.Drawing.Point(299, 110);
            this.butRemovPE.Name = "butRemovPE";
            this.butRemovPE.Size = new System.Drawing.Size(65, 23);
            this.butRemovPE.TabIndex = 43;
            this.butRemovPE.Text = "Remover";
            this.butRemovPE.UseVisualStyleBackColor = true;
            this.butRemovPE.Click += new System.EventHandler(this.butRemovPE_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Excluir Contato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butRemovPE);
            this.Controls.Add(this.butRemovPR);
            this.Controls.Add(this.butEditPE);
            this.Controls.Add(this.butRemoverTelefone);
            this.Controls.Add(this.dgvTelefones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butEditPR);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.textEmailPessoal);
            this.Controls.Add(this.textEmailProfissional);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.maskedTextTelefone);
            this.Controls.Add(this.butAdicionar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_Detalhes";
            this.Text = "Detalhes";
            this.Load += new System.EventHandler(this.Form_Detalhes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextTelefone;
        private System.Windows.Forms.Button butAdicionar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox textEmailProfissional;
        private System.Windows.Forms.TextBox textEmailPessoal;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butEditPR;
        private System.Windows.Forms.DataGridView dgvTelefones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butRemoverTelefone;
        private System.Windows.Forms.Button butEditPE;
        private System.Windows.Forms.Button butRemovPR;
        private System.Windows.Forms.Button butRemovPE;
        private System.Windows.Forms.Button button1;
    }
}