using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProduto
{
    public partial class Form2 : Form
    {



        private List<Produto> produtos; // Lista para armazenar os produtos em memória
        private DataGridView dataGridViewForm1; // Referência ao DataGridView da tela Form1
        private Produto produtoSelecionado;
        public Form2(List<Produto> produtos, DataGridView dataGridViewForm1, Produto produtoSelecionado = null)
        {
            InitializeComponent();
            this.produtos = produtos;
            this.dataGridViewForm1 = dataGridViewForm1;
            this.produtoSelecionado = produtoSelecionado;

            // Se houver um produto selecionado, atualiza os campos do formulário
            if (produtoSelecionado != null)
            {
                AtualizarCamposProduto();
            }
        }

        // Método para atualizar os campos do formulário com os dados do produto selecionado
        private void AtualizarCamposProduto()
        {
            codigo.Text = produtoSelecionado.Codigo;
            descricao.Text = produtoSelecionado.Descricao;
            fornecedor.Text = produtoSelecionado.Fornecedor;
            valor.Text = produtoSelecionado.Valor.ToString();
            estoque.Text = produtoSelecionado.Estoque.ToString();

            if (produtoSelecionado.Disponivel)
            {
                sim.Checked = true;
            }
            else
            {
                nao.Checked = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {
        }


        private void fornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void sim_CheckedChanged(object sender, EventArgs e)
        {
                
        }

        private void nao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void estoque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string varcodigo = codigo.Text;
            string vardescricao = descricao.Text;
            string varfornecedor = fornecedor.Text;
            decimal varvalor = 0;
            string varestoque = estoque.Text;
            bool vardisponivel = false;

            decimal.TryParse(valor.Text, out varvalor);

            if (sim.Checked)
            {
                vardisponivel = true;
            }

            // Verifica se o código já existe na lista de produtos
            if (produtoSelecionado == null && produtos.Any(p => p.Codigo == varcodigo))
            {
                MessageBox.Show("Este código já existe. Escolha outro código para o produto.");
                return;
            }

            if (produtoSelecionado != null)
            {
                produtoSelecionado.Codigo = varcodigo;
                produtoSelecionado.Descricao = vardescricao;
                produtoSelecionado.Fornecedor = varfornecedor;
                produtoSelecionado.Valor = varvalor;
                produtoSelecionado.Estoque = varestoque;
                produtoSelecionado.Disponivel = vardisponivel;

                MessageBox.Show("Produto alterado com sucesso!");
            }
            else
            {
                Produto novoProduto = new Produto(varcodigo, vardescricao, varfornecedor, varvalor, varestoque, vardisponivel);
                produtos.Add(novoProduto);

                MessageBox.Show("Produto cadastrado com sucesso!");
            }

            AtualizarDataGridViewForm1();
            this.Close();
        }
        private void AtualizarDataGridViewForm1()
        {
            // Atualiza o DataGridView na tela Form1 com a lista atualizada de produtos
            dataGridViewForm1.DataSource = null;
            dataGridViewForm1.DataSource = produtos;
        }

        private void descricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
