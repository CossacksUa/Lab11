using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        private string dbPath = @"C:\Users\Monolit\Desktop\ООП\ЛР\Lab11\Lab11\database\games.db";

        public Form1()
        {
            InitializeComponent();
            CheckAndAlterTable();
        }

        private void buttonAddGame_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string sales = textBoxSales.Text;
            string series = textBoxSeries.Text;
            string platforms = textBoxPlatforms.Text;
            string releaseDate = textBoxReleaseDate.Text;
            string developers = textBoxDevelopers.Text;
            string publishers = textBoxPublishers.Text;

            AddGameToDatabase(title, sales, series, platforms, releaseDate, developers, publishers);
        }

        private void buttonAddGame2_Click(object sender, EventArgs e)
        {
            string rank = textBoxRank.Text;
            string gameName = textBoxGameName.Text;
            string currentPlayers = textBoxCurrentPlayers.Text;
            string peakToday = textBoxPeakToday.Text;
            string allTimePeak = textBoxAllTimePeak.Text;

            AddGameToDatabase2(rank, gameName, currentPlayers, peakToday, allTimePeak);
        }

        private void AddGameToDatabase(string title, string sales, string series, string platforms, string releaseDate, string developers, string publishers)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();
                    string sql = "INSERT INTO games (Название, Продажи, Серия, [Платформа(ы)], [Дата выхода], [Разработчик(и)], [Издатель(и)]) VALUES (@Title, @Sales, @Series, @Platforms, @ReleaseDate, @Developers, @Publishers)";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Sales", sales);
                        cmd.Parameters.AddWithValue("@Series", series);
                        cmd.Parameters.AddWithValue("@Platforms", platforms);
                        cmd.Parameters.AddWithValue("@ReleaseDate", releaseDate);
                        cmd.Parameters.AddWithValue("@Developers", developers);
                        cmd.Parameters.AddWithValue("@Publishers", publishers);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Game added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void AddGameToDatabase2(string rank, string gameName, string currentPlayers, string peakToday, string allTimePeak)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();
                    string sql = "INSERT INTO games2 (Rank, [Game Name], [Current Players], [Peak Today], [All Time Peak]) VALUES (@Rank, @GameName, @CurrentPlayers, @PeakToday, @AllTimePeak)";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Rank", rank);
                        cmd.Parameters.AddWithValue("@GameName", gameName);
                        cmd.Parameters.AddWithValue("@CurrentPlayers", currentPlayers);
                        cmd.Parameters.AddWithValue("@PeakToday", peakToday);
                        cmd.Parameters.AddWithValue("@AllTimePeak", allTimePeak);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Game added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void buttonLoadGames_Click(object sender, EventArgs e)
        {
            LoadGamesFromDatabase();
            LoadGamesFromDatabase2();
        }

        private void LoadGamesFromDatabase()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();
                    string sql = "SELECT * FROM games";
                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, conn))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridViewGames.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void LoadGamesFromDatabase2()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();
                    string sql = "SELECT * FROM games2";
                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, conn))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridViewGames2.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void buttonDeleteGame_Click(object sender, EventArgs e)
        {
            if (dataGridViewGames.SelectedRows.Count > 0)
            {
                string title = dataGridViewGames.SelectedRows[0].Cells["Название"].Value.ToString();
                DeleteGameFromDatabase(title);
            }
            else
            {
                MessageBox.Show("Виберіть гру для видалення.");
            }
        }

        private void buttonDeleteGame2_Click(object sender, EventArgs e)
        {
            if (dataGridViewGames2.SelectedRows.Count > 0)
            {
                string rank = dataGridViewGames2.SelectedRows[0].Cells["Rank"].Value.ToString();
                DeleteGameFromDatabase2(rank);
            }
            else
            {
                MessageBox.Show("Виберіть гру для видалення.");
            }
        }

        private void DeleteGameFromDatabase(string title)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();
                    string sql = "DELETE FROM games WHERE Название = @Title";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Game deleted successfully!");
                    LoadGamesFromDatabase(); // Refresh the data grid view
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void DeleteGameFromDatabase2(string rank)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();
                    string sql = "DELETE FROM games2 WHERE Rank = @Rank";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Rank", rank);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Game deleted successfully!");
                    LoadGamesFromDatabase2(); // Refresh the data grid view
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Name)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Name;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void CheckAndAlterTable()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();

                    // Check the structure of the first table
                   

                    // Check the structure of the second table
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();
                    string sql = "SELECT * FROM games WHERE Название LIKE @SearchTerm OR Продажи LIKE @SearchTerm OR Серия LIKE @SearchTerm OR [Платформа(ы)] LIKE @SearchTerm OR [Дата выхода] LIKE @SearchTerm OR [Разработчик(и)] LIKE @SearchTerm OR [Издатель(и)] LIKE @SearchTerm";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            dataGridViewGames.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void buttonSearch2_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch2.Text;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();
                    string sql = "SELECT * FROM games2 WHERE Rank LIKE @SearchTerm OR [Game Name] LIKE @SearchTerm OR [Current Players] LIKE @SearchTerm OR [Peak Today] LIKE @SearchTerm OR [All Time Peak] LIKE @SearchTerm";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            dataGridViewGames2.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBoxTables.SelectedItem.ToString();
            string selectedColumn = textBoxColumn.Text;
            string selectedValue = textBoxValue.Text;

            if (selectedTable == "Games")
            {
                GenerateReport("games", selectedColumn, selectedValue);
            }
            else if (selectedTable == "Games2")
            {
                GenerateReport("games2", selectedColumn, selectedValue);
            }
        }

        private void GenerateReport(string tableName, string columnName, string value)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM {tableName} WHERE [{columnName}] LIKE @Value";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Value", $"%{value}%");

                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            dataGridViewReport.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
