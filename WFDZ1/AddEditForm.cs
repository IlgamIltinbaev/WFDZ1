using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WFDZ1.Классы;

namespace WFDZ1
{
    public partial class AddEditForm : Form
    {
        public Book BookToEdit { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Genres { get; set; }
        public AddEditForm()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {

        }
        private void AddEditForm_Load(object sender, EventArgs e)
        {
            comboAuthor.Items.Clear();
            comboAuthor.Items.AddRange(Authors.ToArray());
            comboGenre.Items.Clear();
            comboGenre.Items.AddRange(Genres.ToArray());

            if (BookToEdit != null)
            {
                textName.Text = BookToEdit.Title;
                comboAuthor.SelectedItem = BookToEdit.Author;
                comboGenre.SelectedItem = BookToEdit.Genre;
                radioSaleYes.Checked = BookToEdit.Discount;
                radioSaleNo.Checked = !BookToEdit.Discount;
            }
            else
            {
                // По умолчанию ставим первую позицию в комбобоксах и "Нет скидки"
                if (comboAuthor.Items.Count > 0) comboAuthor.SelectedIndex = 0;
                if (comboGenre.Items.Count > 0) comboGenre.SelectedIndex = 0;
                radioSaleNo.Checked = true;
            }
        }
        private void buttonSafe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Введите название книги.");
                return;
            }
            if (comboAuthor.SelectedItem == null || comboGenre.SelectedItem == null)
            {
                MessageBox.Show("Выберите автора и жанр.");
                return;
            }

            if (BookToEdit == null)
            {
                // Создаем новую книгу (Id будет присвоен в главной форме)
                BookToEdit = new Book();
            }
            // Заполняем поля
            BookToEdit.Title = textName.Text.Trim();
            BookToEdit.Author = comboAuthor.SelectedItem.ToString();
            BookToEdit.Genre = comboGenre.SelectedItem.ToString();
            BookToEdit.Discount = radioSaleYes.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
