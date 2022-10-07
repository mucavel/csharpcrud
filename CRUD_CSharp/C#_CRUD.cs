using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CRUD_CSharp
{
    public partial class crud : Form
    {
        public crud()
        {
            InitializeComponent();
            FillDataGrid();
        }
        readonly MySqlConnection conn = new MySqlConnection("SERVER=remotemysql.com;DATABASE=XIr9HZ4b3d;UID=XIr9HZ4b3d;PASSWORD=h18Q8wmED3");
        //readonly MySqlConnection conn = new MySqlConnection("SERVER=127.0.0.1;DATABASE=cruddb;UID=root;PASSWORD=");

        private void ClearFields()
        {
            textBoxID.ResetText();
            comboBoxSupplier.SelectedIndex = -1;
            textBoxQtd.ResetText();
            comboBoxBrand.SelectedIndex = -1;
            textBoxOperator.ResetText();
        }

        private void ClearBtn_Click(object sender, System.EventArgs e)
        {
            textBoxID.ResetText();
            comboBoxSupplier.SelectedIndex = -1;
            textBoxQtd.ResetText();
            comboBoxBrand.SelectedIndex = -1;
            textBoxOperator.ResetText();
        }

        private void SendBtn_Click(object sender, System.EventArgs e)
        {
            if (comboBoxSupplier.SelectedItem == null || textBoxQtd.Text == null || textBoxQtd.Text == "" || comboBoxBrand.SelectedItem == null || textBoxOperator.Text == null || textBoxOperator.Text == "")
            {
                MessageBox.Show("Preencha todos Campos!");
            }
            else
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `crud`(`Fornecedor`, `Quantidade`, `Marca`, `Operador`) VALUES (@fornecedor, @quantidade, @marca, @operador)", conn);
                cmd.Parameters.AddWithValue("@fornecedor", comboBoxSupplier.SelectedItem);
                cmd.Parameters.AddWithValue("@quantidade", textBoxQtd.Text);
                cmd.Parameters.AddWithValue("@marca", comboBoxBrand.SelectedItem);
                cmd.Parameters.AddWithValue("@operador", textBoxOperator.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Dados Inseridos com Sucesso!");

                ClearFields();
                FillDataGrid();
            }

        }

        private void UpdateBtn_Click(object sender, System.EventArgs e)
        {
            if (textBoxID.Text == null || textBoxID.Text == "" || comboBoxSupplier.SelectedItem == null || textBoxQtd.Text == null || textBoxQtd.Text == "" || comboBoxBrand.SelectedItem == null)
            {
                MessageBox.Show("Preencha os Campos necessários!");
            }
            else
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE crud SET fornecedor = @fornecedor, quantidade = @quantidade, marca = @marca WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", textBoxID.Text);
                cmd.Parameters.AddWithValue("@fornecedor", comboBoxSupplier.SelectedItem);
                cmd.Parameters.AddWithValue("@quantidade", textBoxQtd.Text);
                cmd.Parameters.AddWithValue("@marca", comboBoxBrand.SelectedItem);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Dados Atualizados com Sucesso!");

                ClearFields();
                FillDataGrid();
            }
        }

        private void DeleteBtn_Click(object sender, System.EventArgs e)
        {
            if (textBoxID.Text == null || textBoxID.Text == "")
            {
                MessageBox.Show("Coloque o ID correspondente ao Dados a apagar");
            }
            else
            {
                if (MessageBox.Show("Deseja mesmo Apagar os Dados do ID '" + textBoxID.Text + "'?", "Apagar Dados", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM crud WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", textBoxID.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Dados Apagados.");

                    ClearFields();
                    FillDataGrid();
                }
            }
        }

        private void FillDataGrid()
        {
            conn.Open();
            dataGridView.DataSource = null;
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM crud", conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            conn.Close();
        }
    }
}
