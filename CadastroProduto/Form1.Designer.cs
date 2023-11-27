namespace CadastroProduto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            excluir = new Button();
            novo = new Button();
            alterar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(794, 334);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // excluir
            // 
            excluir.Location = new Point(733, 78);
            excluir.Name = "excluir";
            excluir.Size = new Size(94, 29);
            excluir.TabIndex = 1;
            excluir.Text = "Excluir";
            excluir.UseVisualStyleBackColor = true;
            excluir.Click += excluir_Click;
            // 
            // novo
            // 
            novo.Location = new Point(489, 78);
            novo.Name = "novo";
            novo.Size = new Size(94, 29);
            novo.TabIndex = 3;
            novo.Text = "Novo";
            novo.UseVisualStyleBackColor = true;
            novo.Click += novo_Click;
            // 
            // alterar
            // 
            alterar.Location = new Point(612, 78);
            alterar.Name = "alterar";
            alterar.Size = new Size(94, 29);
            alterar.TabIndex = 4;
            alterar.Text = "Alterar";
            alterar.UseVisualStyleBackColor = true;
            alterar.Click += alterar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 478);
            Controls.Add(alterar);
            Controls.Add(novo);
            Controls.Add(excluir);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button excluir;
        private Button novo;
        private Button alterar;
    }
}