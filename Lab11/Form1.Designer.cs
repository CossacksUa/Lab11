namespace Lab11
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonAddGame;
        private System.Windows.Forms.Button buttonAddGame2;
        private System.Windows.Forms.Button buttonLoadGames;
        private System.Windows.Forms.Button buttonDeleteGame;
        private System.Windows.Forms.Button buttonDeleteGame2;
        private System.Windows.Forms.DataGridView dataGridViewGames;
        private System.Windows.Forms.DataGridView dataGridViewGames2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.Button buttonSearch2;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.TextBox textBoxColumn;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.Label labelValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonAddGame = new System.Windows.Forms.Button();
            this.buttonAddGame2 = new System.Windows.Forms.Button();
            this.buttonLoadGames = new System.Windows.Forms.Button();
            this.buttonDeleteGame = new System.Windows.Forms.Button();
            this.buttonDeleteGame2 = new System.Windows.Forms.Button();
            this.dataGridViewGames = new System.Windows.Forms.DataGridView();
            this.dataGridViewGames2 = new System.Windows.Forms.DataGridView();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxSales = new System.Windows.Forms.TextBox();
            this.textBoxSeries = new System.Windows.Forms.TextBox();
            this.textBoxPlatforms = new System.Windows.Forms.TextBox();
            this.textBoxReleaseDate = new System.Windows.Forms.TextBox();
            this.textBoxDevelopers = new System.Windows.Forms.TextBox();
            this.textBoxPublishers = new System.Windows.Forms.TextBox();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.textBoxCurrentPlayers = new System.Windows.Forms.TextBox();
            this.textBoxPeakToday = new System.Windows.Forms.TextBox();
            this.textBoxAllTimePeak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.buttonSearch2 = new System.Windows.Forms.Button();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.textBoxColumn = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelColumn = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddGame
            // 
            this.buttonAddGame.Location = new System.Drawing.Point(12, 194);
            this.buttonAddGame.Name = "buttonAddGame";
            this.buttonAddGame.Size = new System.Drawing.Size(100, 23);
            this.buttonAddGame.TabIndex = 12;
            this.buttonAddGame.Text = "Додати гру";
            this.buttonAddGame.UseVisualStyleBackColor = true;
            this.buttonAddGame.Click += new System.EventHandler(this.buttonAddGame_Click);
            // 
            // buttonAddGame2
            // 
            this.buttonAddGame2.Location = new System.Drawing.Point(12, 544);
            this.buttonAddGame2.Name = "buttonAddGame2";
            this.buttonAddGame2.Size = new System.Drawing.Size(100, 23);
            this.buttonAddGame2.TabIndex = 13;
            this.buttonAddGame2.Text = "Додати гру (2)";
            this.buttonAddGame2.UseVisualStyleBackColor = true;
            this.buttonAddGame2.Click += new System.EventHandler(this.buttonAddGame2_Click);
            // 
            // buttonLoadGames
            // 
            this.buttonLoadGames.Location = new System.Drawing.Point(12, 307);
            this.buttonLoadGames.Name = "buttonLoadGames";
            this.buttonLoadGames.Size = new System.Drawing.Size(120, 48);
            this.buttonLoadGames.TabIndex = 14;
            this.buttonLoadGames.Text = "Завантажити ігри";
            this.buttonLoadGames.UseVisualStyleBackColor = true;
            this.buttonLoadGames.Click += new System.EventHandler(this.buttonLoadGames_Click);
            // 
            // buttonDeleteGame
            // 
            this.buttonDeleteGame.Location = new System.Drawing.Point(12, 236);
            this.buttonDeleteGame.Name = "buttonDeleteGame";
            this.buttonDeleteGame.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteGame.TabIndex = 15;
            this.buttonDeleteGame.Text = "Видалити гру";
            this.buttonDeleteGame.UseVisualStyleBackColor = true;
            this.buttonDeleteGame.Click += new System.EventHandler(this.buttonDeleteGame_Click);
            // 
            // buttonDeleteGame2
            // 
            this.buttonDeleteGame2.Location = new System.Drawing.Point(12, 586);
            this.buttonDeleteGame2.Name = "buttonDeleteGame2";
            this.buttonDeleteGame2.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteGame2.TabIndex = 16;
            this.buttonDeleteGame2.Text = "Видалити гру (2)";
            this.buttonDeleteGame2.UseVisualStyleBackColor = true;
            this.buttonDeleteGame2.Click += new System.EventHandler(this.buttonDeleteGame2_Click);
            // 
            // dataGridViewGames
            // 
            this.dataGridViewGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGames.Location = new System.Drawing.Point(344, 12);
            this.dataGridViewGames.Name = "dataGridViewGames";
            this.dataGridViewGames.Size = new System.Drawing.Size(783, 263);
            this.dataGridViewGames.TabIndex = 17;
            // 
            // dataGridViewGames2
            // 
            this.dataGridViewGames2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGames2.Location = new System.Drawing.Point(296, 352);
            this.dataGridViewGames2.Name = "dataGridViewGames2";
            this.dataGridViewGames2.Size = new System.Drawing.Size(497, 319);
            this.dataGridViewGames2.TabIndex = 18;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(12, 12);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxTitle.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxSales
            // 
            this.textBoxSales.Location = new System.Drawing.Point(12, 38);
            this.textBoxSales.Name = "textBoxSales";
            this.textBoxSales.Size = new System.Drawing.Size(100, 20);
            this.textBoxSales.TabIndex = 1;
            this.textBoxSales.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxSales.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxSeries
            // 
            this.textBoxSeries.Location = new System.Drawing.Point(12, 64);
            this.textBoxSeries.Name = "textBoxSeries";
            this.textBoxSeries.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeries.TabIndex = 2;
            this.textBoxSeries.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxSeries.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxPlatforms
            // 
            this.textBoxPlatforms.Location = new System.Drawing.Point(12, 90);
            this.textBoxPlatforms.Name = "textBoxPlatforms";
            this.textBoxPlatforms.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlatforms.TabIndex = 3;
            this.textBoxPlatforms.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxPlatforms.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxReleaseDate
            // 
            this.textBoxReleaseDate.Location = new System.Drawing.Point(12, 116);
            this.textBoxReleaseDate.Name = "textBoxReleaseDate";
            this.textBoxReleaseDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxReleaseDate.TabIndex = 4;
            this.textBoxReleaseDate.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxReleaseDate.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxDevelopers
            // 
            this.textBoxDevelopers.Location = new System.Drawing.Point(12, 142);
            this.textBoxDevelopers.Name = "textBoxDevelopers";
            this.textBoxDevelopers.Size = new System.Drawing.Size(100, 20);
            this.textBoxDevelopers.TabIndex = 5;
            this.textBoxDevelopers.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxDevelopers.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxPublishers
            // 
            this.textBoxPublishers.Location = new System.Drawing.Point(12, 168);
            this.textBoxPublishers.Name = "textBoxPublishers";
            this.textBoxPublishers.Size = new System.Drawing.Size(100, 20);
            this.textBoxPublishers.TabIndex = 6;
            this.textBoxPublishers.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxPublishers.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxRank
            // 
            this.textBoxRank.Location = new System.Drawing.Point(12, 387);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.Size = new System.Drawing.Size(100, 20);
            this.textBoxRank.TabIndex = 7;
            this.textBoxRank.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxRank.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Location = new System.Drawing.Point(12, 413);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(100, 20);
            this.textBoxGameName.TabIndex = 8;
            this.textBoxGameName.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxGameName.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxCurrentPlayers
            // 
            this.textBoxCurrentPlayers.Location = new System.Drawing.Point(12, 439);
            this.textBoxCurrentPlayers.Name = "textBoxCurrentPlayers";
            this.textBoxCurrentPlayers.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentPlayers.TabIndex = 9;
            this.textBoxCurrentPlayers.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxCurrentPlayers.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxPeakToday
            // 
            this.textBoxPeakToday.Location = new System.Drawing.Point(12, 465);
            this.textBoxPeakToday.Name = "textBoxPeakToday";
            this.textBoxPeakToday.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeakToday.TabIndex = 10;
            this.textBoxPeakToday.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxPeakToday.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxAllTimePeak
            // 
            this.textBoxAllTimePeak.Location = new System.Drawing.Point(12, 491);
            this.textBoxAllTimePeak.Name = "textBoxAllTimePeak";
            this.textBoxAllTimePeak.Size = new System.Drawing.Size(100, 20);
            this.textBoxAllTimePeak.TabIndex = 11;
            this.textBoxAllTimePeak.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxAllTimePeak.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 658);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "v 7.080624";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(175, 77);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(150, 20);
            this.textBoxSearch.TabIndex = 19;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(208, 103);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.Location = new System.Drawing.Point(133, 413);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(150, 20);
            this.textBoxSearch2.TabIndex = 19;
            // 
            // buttonSearch2
            // 
            this.buttonSearch2.Location = new System.Drawing.Point(166, 439);
            this.buttonSearch2.Name = "buttonSearch2";
            this.buttonSearch2.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch2.TabIndex = 20;
            this.buttonSearch2.Text = "Пошук";
            this.buttonSearch2.UseVisualStyleBackColor = true;
            this.buttonSearch2.Click += new System.EventHandler(this.buttonSearch2_Click);
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Items.AddRange(new object[] {
            "Games",
            "Games2"});
            this.comboBoxTables.Location = new System.Drawing.Point(815, 438);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTables.TabIndex = 21;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Location = new System.Drawing.Point(815, 552);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(121, 23);
            this.buttonGenerateReport.TabIndex = 26;
            this.buttonGenerateReport.Text = "Створити ЗВіт";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(965, 352);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(443, 308);
            this.dataGridViewReport.TabIndex = 27;
            // 
            // textBoxColumn
            // 
            this.textBoxColumn.Location = new System.Drawing.Point(815, 496);
            this.textBoxColumn.Name = "textBoxColumn";
            this.textBoxColumn.Size = new System.Drawing.Size(144, 20);
            this.textBoxColumn.TabIndex = 22;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(815, 522);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(144, 20);
            this.textBoxValue.TabIndex = 23;
            // 
            // labelColumn
            // 
            this.labelColumn.AutoSize = true;
            this.labelColumn.Location = new System.Drawing.Point(815, 426);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(58, 13);
            this.labelColumn.TabIndex = 24;
            this.labelColumn.Text = "Табличка:";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(815, 480);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(53, 13);
            this.labelValue.TabIndex = 25;
            this.labelValue.Text = "Колонка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(885, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "ЗВІТНІСТЬ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1420, 741);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewGames2);
            this.Controls.Add(this.dataGridViewGames);
            this.Controls.Add(this.buttonDeleteGame2);
            this.Controls.Add(this.buttonDeleteGame);
            this.Controls.Add(this.buttonLoadGames);
            this.Controls.Add(this.buttonAddGame2);
            this.Controls.Add(this.buttonAddGame);
            this.Controls.Add(this.textBoxAllTimePeak);
            this.Controls.Add(this.textBoxPeakToday);
            this.Controls.Add(this.textBoxCurrentPlayers);
            this.Controls.Add(this.textBoxGameName);
            this.Controls.Add(this.textBoxRank);
            this.Controls.Add(this.textBoxPublishers);
            this.Controls.Add(this.textBoxDevelopers);
            this.Controls.Add(this.textBoxReleaseDate);
            this.Controls.Add(this.textBoxPlatforms);
            this.Controls.Add(this.textBoxSeries);
            this.Controls.Add(this.textBoxSales);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch2);
            this.Controls.Add(this.buttonSearch2);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.textBoxColumn);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.labelColumn);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.dataGridViewReport);
            this.Name = "Form1";
            this.Text = "Games Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxSales;
        private System.Windows.Forms.TextBox textBoxSeries;
        private System.Windows.Forms.TextBox textBoxPlatforms;
        private System.Windows.Forms.TextBox textBoxReleaseDate;
        private System.Windows.Forms.TextBox textBoxDevelopers;
        private System.Windows.Forms.TextBox textBoxPublishers;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.TextBox textBoxCurrentPlayers;
        private System.Windows.Forms.TextBox textBoxPeakToday;
        private System.Windows.Forms.TextBox textBoxAllTimePeak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
