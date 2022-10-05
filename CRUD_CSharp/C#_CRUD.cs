using System.Data;
using System.Data.SqlClient;
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
        readonly SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=csharpcrud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.crud VALUES (@fornecedor, @quantidade, @marca, @operador)", conn);
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

        private void UpdateBtn_Click(object sender, System.EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.crud SET fornecedor = @fornecedor, quantidade = @quantidade, marca = @marca WHERE id = @id", conn);
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

        private void DeleteBtn_Click(object sender, System.EventArgs e)
        {
            if (textBoxID.Text == null || textBoxID.Text == "")
            {
                MessageBox.Show("Coloque o ID correspondente ao Dados a apagar");
            }
            else
            {
                if (MessageBox.Show("Deseja mesmo Apagar os Dados?", "Apagar Dados", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM dbo.crud WHERE id = @id", conn);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.crud", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dataGridView.DataSource = datatable;
            conn.Close();
        }
    }
}
