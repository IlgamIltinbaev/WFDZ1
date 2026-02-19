using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WFDZ1.Классы;

namespace WFDZ1
{
    partial class FormShop
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.splitPanel = new System.Windows.Forms.SplitContainer();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.FilterGenre = new System.Windows.Forms.ComboBox();
            this.FilterAuthor = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.groupSale = new System.Windows.Forms.GroupBox();
            this.radioSaleNo = new System.Windows.Forms.RadioButton();
            this.radioSaleYes = new System.Windows.Forms.RadioButton();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelCard = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel)).BeginInit();
            this.splitPanel.Panel1.SuspendLayout();
            this.splitPanel.Panel2.SuspendLayout();
            this.splitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.groupSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuEdit,
            this.menuDelete,
            this.menuExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(90, 24);
            this.menuAdd.Text = "Добавить";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(92, 24);
            this.menuEdit.Text = "Изменить";
            this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(79, 24);
            this.menuDelete.Text = "Удалить";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(67, 24);
            this.menuExit.Text = "Выйти";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // splitPanel
            // 
            this.splitPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPanel.Location = new System.Drawing.Point(0, 28);
            this.splitPanel.Name = "splitPanel";
            // 
            // splitPanel.Panel1
            // 
            this.splitPanel.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitPanel.Panel1.Controls.Add(this.dataGridViewBooks);
            this.splitPanel.Panel1.Controls.Add(this.FilterGenre);
            this.splitPanel.Panel1.Controls.Add(this.FilterAuthor);
            this.splitPanel.Panel1.Controls.Add(this.labelFilter);
            this.splitPanel.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // splitPanel.Panel2
            // 
            this.splitPanel.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitPanel.Panel2.Controls.Add(this.groupSale);
            this.splitPanel.Panel2.Controls.Add(this.textGenre);
            this.splitPanel.Panel2.Controls.Add(this.textAuthor);
            this.splitPanel.Panel2.Controls.Add(this.textName);
            this.splitPanel.Panel2.Controls.Add(this.labelGenre);
            this.splitPanel.Panel2.Controls.Add(this.labelName);
            this.splitPanel.Panel2.Controls.Add(this.labelAuthor);
            this.splitPanel.Panel2.Controls.Add(this.labelCard);
            this.splitPanel.Size = new System.Drawing.Size(800, 422);
            this.splitPanel.SplitterDistance = 400;
            this.splitPanel.SplitterWidth = 1;
            this.splitPanel.TabIndex = 1;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(3, 34);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(394, 390);
            this.dataGridViewBooks.TabIndex = 2;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewBooks_SelectionChanged);
            // 
            // FilterGenre
            // 
            this.FilterGenre.FormattingEnabled = true;
            this.FilterGenre.Location = new System.Drawing.Point(236, 3);
            this.FilterGenre.Name = "FilterGenre";
            this.FilterGenre.Size = new System.Drawing.Size(121, 25);
            this.FilterGenre.TabIndex = 1;
            this.FilterGenre.SelectedIndexChanged += new System.EventHandler(this.FilterGenre_SelectedIndexChanged);
            // 
            // FilterAuthor
            // 
            this.FilterAuthor.FormattingEnabled = true;
            this.FilterAuthor.Location = new System.Drawing.Point(109, 3);
            this.FilterAuthor.Name = "FilterAuthor";
            this.FilterAuthor.Size = new System.Drawing.Size(121, 25);
            this.FilterAuthor.TabIndex = 0;
            this.FilterAuthor.SelectedIndexChanged += new System.EventHandler(this.FilterAuthor_SelectedIndexChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(3, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(100, 23);
            this.labelFilter.TabIndex = 0;
            this.labelFilter.Text = "Фильтры:";
            // 
            // groupSale
            // 
            this.groupSale.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupSale.Controls.Add(this.radioSaleNo);
            this.groupSale.Controls.Add(this.radioSaleYes);
            this.groupSale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupSale.Location = new System.Drawing.Point(32, 194);
            this.groupSale.Name = "groupSale";
            this.groupSale.Size = new System.Drawing.Size(340, 214);
            this.groupSale.TabIndex = 7;
            this.groupSale.TabStop = false;
            this.groupSale.Text = "Скидка:";
            // 
            // radioSaleNo
            // 
            this.radioSaleNo.AutoSize = true;
            this.radioSaleNo.Location = new System.Drawing.Point(6, 59);
            this.radioSaleNo.Name = "radioSaleNo";
            this.radioSaleNo.Size = new System.Drawing.Size(117, 27);
            this.radioSaleNo.TabIndex = 1;
            this.radioSaleNo.TabStop = true;
            this.radioSaleNo.Text = "Нет скидки";
            this.radioSaleNo.UseVisualStyleBackColor = true;
            // 
            // radioSaleYes
            // 
            this.radioSaleYes.AutoSize = true;
            this.radioSaleYes.Location = new System.Drawing.Point(6, 26);
            this.radioSaleYes.Name = "radioSaleYes";
            this.radioSaleYes.Size = new System.Drawing.Size(190, 27);
            this.radioSaleYes.TabIndex = 0;
            this.radioSaleYes.TabStop = true;
            this.radioSaleYes.Text = "Скидка для студента";
            this.radioSaleYes.UseVisualStyleBackColor = true;
            // 
            // textGenre
            // 
            this.textGenre.Location = new System.Drawing.Point(127, 154);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(245, 22);
            this.textGenre.TabIndex = 6;
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(127, 63);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(245, 22);
            this.textAuthor.TabIndex = 5;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(127, 105);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(245, 22);
            this.textName.TabIndex = 4;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(29, 154);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(47, 16);
            this.labelGenre.TabIndex = 3;
            this.labelGenre.Text = "Жанр:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(29, 111);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(29, 63);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(50, 16);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Автор:";
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCard.Location = new System.Drawing.Point(141, 3);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(114, 28);
            this.labelCard.TabIndex = 0;
            this.labelCard.Text = "Карточка";
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormShop";
            this.Text = "Книжная лавка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitPanel.Panel1.ResumeLayout(false);
            this.splitPanel.Panel1.PerformLayout();
            this.splitPanel.Panel2.ResumeLayout(false);
            this.splitPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel)).EndInit();
            this.splitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.groupSale.ResumeLayout(false);
            this.groupSale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void LoadData()
        {
            // Загрузка авторов
            var authorsDict = new Dictionary<int, string>();
            var authorLines = File.ReadAllLines("Authors.txt");
            foreach (var line in authorLines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(new[] { '.' }, 2);
                int id = int.Parse(parts[0].Trim());
                string name = parts[1].Trim();
                authorsDict[id] = name;
                authorNames.Add(name);
            }

            // Загрузка жанров
            var genresDict = new Dictionary<int, string>();
            var genreLines = File.ReadAllLines("Genres.txt");
            foreach (var line in genreLines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(new[] { '.' }, 2);
                int id = int.Parse(parts[0].Trim());
                string name = parts[1].Trim();
                genresDict[id] = name;
                genreNames.Add(name);
            }

            // Загрузка книг
            var bookLines = File.ReadAllLines("Books.txt");
            foreach (var line in bookLines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var dotSplit = line.Split(new[] { '.' }, 2);
                int id = int.Parse(dotSplit[0].Trim());
                string rest = dotSplit[1].Trim();
                var commaParts = rest.Split(',').Select(p => p.Trim()).ToList();
                string title = commaParts[0];
                int authorId = int.Parse(commaParts[1]);
                int genreId = int.Parse(commaParts[2]);
                bool discount = bool.Parse(commaParts[3]);

                books.Add(new Book
                {
                    Id = id,
                    Title = title,
                    Author = authorsDict[authorId],
                    Genre = genresDict[genreId],
                    Discount = discount
                });
            }

            // Заполнение ComboBox фильтров
            FilterAuthor.Items.Clear();
            FilterAuthor.Items.Add("Все");
            FilterAuthor.Items.AddRange(authorNames.ToArray());
            FilterAuthor.SelectedIndex = 0;

            FilterGenre.Items.Clear();
            FilterGenre.Items.Add("Все");
            FilterGenre.Items.AddRange(genreNames.ToArray());
            FilterGenre.SelectedIndex = 0;

            // Отображение книг
            filteredBooks = new List<Book>(books);
            dataGridViewBooks.DataSource = filteredBooks;
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.SplitContainer splitPanel;
        private System.Windows.Forms.ComboBox FilterAuthor;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ComboBox FilterGenre;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.GroupBox groupSale;
        private System.Windows.Forms.RadioButton radioSaleNo;
        private System.Windows.Forms.RadioButton radioSaleYes;
    }
}

