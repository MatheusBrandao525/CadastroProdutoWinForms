namespace CadastroProduto
{
    partial class Form2
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
            codigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            fornecedor = new TextBox();
            label4 = new Label();
            valor = new TextBox();
            cancelar = new Button();
            groupBox1 = new GroupBox();
            nao = new CheckBox();
            sim = new CheckBox();
            label5 = new Label();
            estoque = new ComboBox();
            salvar = new Button();
            descricao = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // codigo
            // 
            codigo.Location = new Point(62, 100);
            codigo.Name = "codigo";
            codigo.Size = new Size(125, 27);
            codigo.TabIndex = 0;
            codigo.TextChanged += codigo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 68);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 166);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 233);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 5;
            label3.Text = "Fornecedor";
            // 
            // fornecedor
            // 
            fornecedor.Location = new Point(62, 256);
            fornecedor.Name = "fornecedor";
            fornecedor.Size = new Size(452, 27);
            fornecedor.TabIndex = 4;
            fornecedor.TextChanged += fornecedor_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 317);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 7;
            label4.Text = "Valor";
            // 
            // valor
            // 
            valor.Location = new Point(62, 345);
            valor.Name = "valor";
            valor.Size = new Size(125, 27);
            valor.TabIndex = 6;
            valor.TextChanged += valor_TextChanged;
            // 
            // cancelar
            // 
            cancelar.Location = new Point(286, 409);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(94, 29);
            cancelar.TabIndex = 10;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += cancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nao);
            groupBox1.Controls.Add(sim);
            groupBox1.Location = new Point(246, 317);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 65);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ativo";
            // 
            // nao
            // 
            nao.AutoSize = true;
            nao.Location = new Point(174, 31);
            nao.Name = "nao";
            nao.Size = new Size(59, 24);
            nao.TabIndex = 1;
            nao.Text = "Não";
            nao.UseVisualStyleBackColor = true;
            nao.CheckedChanged += nao_CheckedChanged;
            // 
            // sim
            // 
            sim.AutoSize = true;
            sim.Location = new Point(17, 34);
            sim.Name = "sim";
            sim.Size = new Size(56, 24);
            sim.TabIndex = 0;
            sim.Text = "Sim";
            sim.UseVisualStyleBackColor = true;
            sim.CheckedChanged += sim_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 68);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 13;
            label5.Text = "Estoque";
            // 
            // estoque
            // 
            estoque.FormattingEnabled = true;
            estoque.Items.AddRange(new object[] { "Loja 1", "Loja 2", "Loja 3", "Loja 4" });
            estoque.Location = new Point(246, 99);
            estoque.Name = "estoque";
            estoque.Size = new Size(268, 28);
            estoque.TabIndex = 14;
            estoque.SelectedIndexChanged += estoque_SelectedIndexChanged;
            // 
            // salvar
            // 
            salvar.Location = new Point(138, 409);
            salvar.Name = "salvar";
            salvar.Size = new Size(94, 29);
            salvar.TabIndex = 15;
            salvar.Text = "Salvar";
            salvar.UseVisualStyleBackColor = true;
            salvar.Click += salvar_Click;
            // 
            // descricao
            // 
            descricao.Location = new Point(64, 197);
            descricao.Name = "descricao";
            descricao.Size = new Size(450, 27);
            descricao.TabIndex = 16;
            descricao.TextChanged += descricao_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 455);
            Controls.Add(descricao);
            Controls.Add(salvar);
            Controls.Add(estoque);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(cancelar);
            Controls.Add(label4);
            Controls.Add(valor);
            Controls.Add(label3);
            Controls.Add(fornecedor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(codigo);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox codigo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox fornecedor;
        private Label label4;
        private TextBox valor;
        private Button cancelar;
        private GroupBox groupBox1;
        private CheckBox nao;
        private CheckBox sim;
        private Label label5;
        private ComboBox estoque;
        private Button salvar;
        private TextBox descricao;
    }
}