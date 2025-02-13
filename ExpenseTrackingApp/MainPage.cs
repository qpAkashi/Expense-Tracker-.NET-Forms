using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ExpenseTrackingApp
{
    public partial class MainPage : Form
    {
        private OleDbConnection connection;
        private double initialBudget = 0;
        private double budget;

        public MainPage()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Rares\Desktop\temacs\ExpenseAppDB.accdb;";
            connection = new OleDbConnection(connectionString);
            budget = initialBudget;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadProducts();
            UpdateBudgetLabel();
            DisplayTotalSpent();
        }

        private void LoadProducts()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT IdProdus, DenumireProdus, Pret, Cantitate, IdCategorie, DataCumparare FROM Produse";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                datagrid.DataSource = table;
                datagrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void adaugaprodbtn_Click(object sender, EventArgs e)
        {
            string denumireProdus = produsfield.Text.Trim();
            string pretText = pretfield.Text.Trim();
            string cantitateText = cantitatefield.Text.Trim();
            string idCategorieText = categoriefield.Text.Trim();

            if (string.IsNullOrWhiteSpace(denumireProdus) ||
                string.IsNullOrWhiteSpace(pretText) ||
                string.IsNullOrWhiteSpace(cantitateText) ||
                string.IsNullOrWhiteSpace(idCategorieText))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            if (!double.TryParse(pretText, out double pret) ||
                !int.TryParse(cantitateText, out int cantitate) ||
                !int.TryParse(idCategorieText, out int idCategorie))
            {
                MessageBox.Show("Please enter valid numeric values for Price, Quantity, and Category ID.");
                return;
            }

            double totalCost = pret * cantitate;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = connection;

                    // Begin Transaction
                    OleDbTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;

                    try
                    {
                        string query = "INSERT INTO Produse (DenumireProdus, Pret, Cantitate, IdCategorie) " +
                                       "VALUES (@DenumireProdus, @Pret, @Cantitate, @IdCategorie)";

                        command.CommandText = query;

                        command.Parameters.Clear();
                        command.Parameters.Add("@DenumireProdus", OleDbType.VarWChar).Value = denumireProdus;
                        command.Parameters.Add("@Pret", OleDbType.Double).Value = pret;
                        command.Parameters.Add("@Cantitate", OleDbType.Integer).Value = cantitate;
                        command.Parameters.Add("@IdCategorie", OleDbType.Integer).Value = idCategorie;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Commit transaction if everything is fine
                            transaction.Commit();
                            MessageBox.Show("Product added successfully!");
                            ClearFields();
                            LoadProducts();
                            DisplayTotalSpent();
                        }
                        else
                        {
                            transaction.Rollback();
                            MessageBox.Show("Failed to add product.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Rollback in case of any errors
                        transaction.Rollback();
                        MessageBox.Show("Error adding product: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void stergeprodbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = datagrid.SelectedRows[0];

                    if (int.TryParse(selectedRow.Cells["IdProdus"].Value?.ToString(), out int idProdus))
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        double productCost = CalculateProductCost(idProdus);

                        string query = "DELETE FROM Produse WHERE IdProdus = @IdProdus";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.Add("@IdProdus", OleDbType.Integer).Value = idProdus;

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product deleted successfully!");
                                budget += productCost;
                                UpdateBudgetLabel();
                                DisplayTotalSpent();
                                LoadProducts();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete product.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid product ID. Please select a valid product.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private double CalculateProductCost(int productId)
        {
            double productCost = 0;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT Pret * Cantitate AS ProductCost FROM Produse WHERE IdProdus = @IdProdus";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.Add("@IdProdus", OleDbType.Integer).Value = productId;

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        productCost = Convert.ToDouble(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating product cost: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return productCost;
        }

        private void adaugabugetbtn_Click(object sender, EventArgs e)
        {
            if (budget == initialBudget)
            {
                if (!double.TryParse(bugetfield.Text.Trim(), out double additionalBudget))
                {
                    MessageBox.Show("Please enter a valid numeric value for additional budget.");
                    return;
                }

                budget += additionalBudget;
                UpdateBudgetLabel();
                bugetfield.Text = string.Empty;
            }
            else
            {
                if (!double.TryParse(bugetfield.Text.Trim(), out double initialBudgetInput))
                {
                    MessageBox.Show("Please enter a valid numeric value for the initial budget.");
                    return;
                }

                initialBudget = initialBudgetInput;
                budget = initialBudget;
                UpdateBudgetLabel();
                bugetfield.Text = string.Empty;
            }
        }

        private void stergebugetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                budget = initialBudget;
                UpdateBudgetLabel();
                DisplayTotalSpent();
                MessageBox.Show("Budget reset to initial value.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting budget: " + ex.Message);
            }
        }

        private void closebtnmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearFields()
        {
            produsfield.Text = string.Empty;
            pretfield.Text = string.Empty;
            cantitatefield.Text = string.Empty;
            categoriefield.Text = string.Empty;
        }

        private void UpdateBudgetLabel()
        {
            nrchel.Text = budget.ToString("C2");
        }

        private double CalculateTotalSpent()
        {
            double totalSpent = 0;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT SUM(Pret * Cantitate) AS TotalCost FROM Produse";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        totalSpent = Convert.ToDouble(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total spent: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return totalSpent;
        }

        private void DisplayTotalSpent()
        {
            double totalSpent = CalculateTotalSpent();
            bugetlabel.Text = $"Total Spent: {totalSpent:C2}";
        }

        private void stergecategoriabtn_Click(object sender, EventArgs e)
        {
        }

        private void bugetlabel_Click(object sender, EventArgs e)
        {
        }

        private void CalculateRemainingBudget()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT SUM(Pret * Cantitate) AS TotalCost FROM Produse";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        double totalCost = Convert.ToDouble(result);
                        budget = initialBudget - totalCost;
                        UpdateBudgetLabel();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating remaining budget: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
