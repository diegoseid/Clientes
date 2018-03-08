namespace Clientes
{
    partial class Form_Cadastrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEmailProfissional = new System.Windows.Forms.TextBox();
            this.textEmailPessoal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.butAdicionar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTelefones = new System.Windows.Forms.DataGridView();
            this.maskedTextTelefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Profissional:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Pessoal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Nascimento:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(117, 16);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(158, 20);
            this.textNome.TabIndex = 4;
            // 
            // textEmailProfissional
            // 
            this.textEmailProfissional.Location = new System.Drawing.Point(117, 73);
            this.textEmailProfissional.Name = "textEmailProfissional";
            this.textEmailProfissional.Size = new System.Drawing.Size(158, 20);
            this.textEmailProfissional.TabIndex = 6;
            // 
            // textEmailPessoal
            // 
            this.textEmailPessoal.Location = new System.Drawing.Point(117, 106);
            this.textEmailPessoal.Name = "textEmailPessoal";
            this.textEmailPessoal.Size = new System.Drawing.Size(158, 20);
            this.textEmailPessoal.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone:";
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
            this.cbTipo.Location = new System.Drawing.Point(249, 143);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(117, 46);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(97, 20);
            this.dtpNascimento.TabIndex = 15;
            // 
            // butAdicionar
            // 
            this.butAdicionar.Location = new System.Drawing.Point(376, 142);
            this.butAdicionar.Name = "butAdicionar";
            this.butAdicionar.Size = new System.Drawing.Size(60, 23);
            this.butAdicionar.TabIndex = 16;
            this.butAdicionar.Text = "Adicionar";
            this.butAdicionar.UseVisualStyleBackColor = true;
            this.butAdicionar.Click += new System.EventHandler(this.butAdicionar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telefones Adicionados";
            // 
            // dgvTelefones
            // 
            this.dgvTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefones.Location = new System.Drawing.Point(453, 46);
            this.dgvTelefones.Name = "dgvTelefones";
            this.dgvTelefones.Size = new System.Drawing.Size(228, 213);
            this.dgvTelefones.TabIndex = 19;
            // 
            // maskedTextTelefone
            // 
            this.maskedTextTelefone.Location = new System.Drawing.Point(80, 143);
            this.maskedTextTelefone.Mask = "00 00000-0000";
            this.maskedTextTelefone.Name = "maskedTextTelefone";
            this.maskedTextTelefone.Size = new System.Drawing.Size(96, 20);
            this.maskedTextTelefone.TabIndex = 20;
            // 
            // Form_Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 286);
            this.Controls.Add(this.maskedTextTelefone);
            this.Controls.Add(this.dgvTelefones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butAdicionar);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEmailPessoal);
            this.Controls.Add(this.textEmailProfissional);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_Cadastrar";
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.Form_Cadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmailProfissional;
        private System.Windows.Forms.TextBox textEmailPessoal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Button butAdicionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvTelefones;
        private System.Windows.Forms.MaskedTextBox maskedTextTelefone;
    }
}

