﻿using System.Data;
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
            string updateQuery = "UPDATE dbo.crud SET fornecedor = '" + comboBoxSupplier.SelectedItem + "', quantidade = '" + textBoxQtd.Text + "', marca = '" + comboBoxBrand.SelectedItem + "', operador = '" + textBoxOperator.Text + "' WHERE id = '" + textBoxID.Text + "'";
            SqlCommand cmd = new SqlCommand(updateQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Dados Atualizados com Sucesso!");

            ClearFields();
            FillDataGrid();
        }

        private void DeleteBtn_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo Apagar os Dados?", "Apagar Dados", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Open();
                string deleteQuery = "DELETE FROM dbo.crud WHERE id = '" + textBoxID.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Dados Apagados.");

                FillDataGrid();
            }



        }

        private void FillDataGrid()
        {
            string selectQuery = "SELECT * FROM dbo.crud";
            conn.Open();
            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dataGridView.DataSource = datatable;
            conn.Close();
        }
    }
}
