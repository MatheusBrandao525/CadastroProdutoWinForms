namespace CadastroProduto
{
    public partial class Form1 : Form
    {

        private List<Produto> listaProdutos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void novo_Click(object sender, EventArgs e)
        {
            // Ao clicar no botão "Novo", exibe o formulário de cadastro (Form2)
            Form2 formCadastro = new Form2(listaProdutos, dataGridView1);
            formCadastro.Show();
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string codigoProduto = selectedRow.Cells[0].Value.ToString();

                Produto produtoSelecionado = listaProdutos.FirstOrDefault(p => p.Codigo == codigoProduto);

                if (produtoSelecionado != null)
                {
                    Form2 formAlterar = new Form2(listaProdutos, dataGridView1, produtoSelecionado);
                    formAlterar.ShowDialog();

                    // Atualiza o DataGridView após a edição no Form2 (se necessário)
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listaProdutos;
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para alterar.");
            }
        }





        private void excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Verifica se alguma linha está selecionada
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; // Obtém a primeira linha selecionada

               
                string codigoProdutoASerRemovido = selectedRow.Cells[0].Value.ToString();

                // Encontrar o produto na lista com base no código
                Produto produtoASerRemovido = listaProdutos.FirstOrDefault(p => p.Codigo == codigoProdutoASerRemovido);

                if (produtoASerRemovido != null)
                {
                    // Remover o produto da lista
                    listaProdutos.Remove(produtoASerRemovido);

                    // Atualiza o DataGridView após a remoção
                    dataGridView1.DataSource = null; // Limpa o DataSource
                    dataGridView1.DataSource = listaProdutos; // Reatribui a lista de produtos como nova fonte de dados

                    MessageBox.Show("Produto excluído com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.");
            }
        }
    }
}