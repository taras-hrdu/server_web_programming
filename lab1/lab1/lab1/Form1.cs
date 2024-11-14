using lab1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        table_sage model_sage = new table_sage();
        table_book model_book = new table_book();

        public Form1()
        {
            InitializeComponent();

            tabControl1.TabPages[0].Text = "Sage";
            tabControl1.TabPages[1].Text = "Book";
            tabControl1.TabPages[2].Text = "SageBook";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            textBoxName.Text = textBoxAge.Text = textBoxCity.Text = textBoxPhoto.Text = "";
            buttonSave.Text = "Create";
            buttonDelete.Enabled = false;
            model_sage.sageId = 0;

            textBoxBookName.Text = textBoxBookDescription.Text = "";
            buttonSaveBook.Text = "Create";
            buttonDeleteBook.Enabled = false;
            model_book.bookId = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = textBoxName;
            loadData();
            loadDataBook();
            LoadDataSageBook();
            LoadSagesComboBox();
            LoadBooksComboBox();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            model_sage.name = textBoxName.Text.Trim();
            model_sage.age = textBoxAge.Text.Trim();
            model_sage.photo = textBoxPhoto.Text.Trim();
            model_sage.city = textBoxCity.Text.Trim();

            using (mydbEntities1 db = new mydbEntities1())
            {
                if (model_sage.sageId == 0)
                {
                    db.table_sage.Add(model_sage);
                }
                else
                {
                    db.Entry(model_sage).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }

            Clear();
            loadData();

            MessageBox.Show("Submitted successfully!");
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Index != -1)
            {
                model_sage.sageId = Convert.ToInt32(dataGridView.CurrentRow.Cells["dgsageId"].Value);

                using (mydbEntities1 db = new mydbEntities1())
                {
                    model_sage = db.table_sage.Where(x => x.sageId == model_sage.sageId).FirstOrDefault();
                    textBoxName.Text = model_sage.name;
                    textBoxAge.Text = model_sage.age;
                    textBoxCity.Text = model_sage.city;
                    textBoxPhoto.Text = model_sage.photo;
                }

                buttonSave.Text = "Update";
                buttonDelete.Enabled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete record?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (mydbEntities1 db = new mydbEntities1())
                {
                    var entry = db.Entry(model_sage);

                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.table_sage.Attach(model_sage);
                        db.table_sage.Remove(model_sage);
                        var sages = db.table_sage_book.Where(sb => sb.sageId == model_sage.sageId).ToList();
                        db.table_sage_book.RemoveRange(sages);
                        db.SaveChanges();
                        loadData();
                        LoadDataSageBook();
                        Clear();
                        MessageBox.Show("Deleted successfully!");
                    }
                }
            }
        }

        void loadData()
        {
            dataGridView.AutoGenerateColumns = false;

            using (mydbEntities1 db = new mydbEntities1())
            {
                dataGridView.DataSource = db.table_sage.ToList<table_sage>();
            }
        }


        //Book Entity

        void loadDataBook()
        {
            dataGridView1.AutoGenerateColumns = false;

            using (mydbEntities1 db = new mydbEntities1())
            {
                dataGridView1.DataSource = db.table_book.ToList<table_book>();
            }
        }

        private void buttonSaveBook_Click(object sender, EventArgs e)
        {
            model_book.name = textBoxBookName.Text.Trim();
            model_book.description = textBoxBookDescription.Text.Trim();

            using (mydbEntities1 db = new mydbEntities1())
            {
                if (model_book.bookId == 0)
                {
                    db.table_book.Add(model_book);
                }
                else
                {
                    db.Entry(model_book).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }

            Clear();
            loadDataBook();

            MessageBox.Show("Submitted successfully!");
        }

        private void buttonCancelBook_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                model_book.bookId = Convert.ToInt32(dataGridView1
                    .CurrentRow.Cells["dgbookId"].Value);

                using (mydbEntities1 db = new mydbEntities1())
                {
                    model_book = db.table_book.Where(x => x.bookId == model_book.bookId).FirstOrDefault();
                    textBoxBookName.Text = model_book.name;
                    textBoxBookDescription.Text = model_book.description;
                }

                buttonSaveBook.Text = "Update";
                buttonDeleteBook.Enabled = true;
            }
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete record?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (mydbEntities1 db = new mydbEntities1())
                {
                    var entry = db.Entry(model_book);

                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.table_book.Attach(model_book);
                        db.table_book.Remove(model_book);
                        var books = db.table_sage_book.Where(sb => sb.bookId == model_book.bookId).ToList();
                        db.table_sage_book.RemoveRange(books);
                        db.SaveChanges();
                        loadDataBook();
                        LoadDataSageBook();
                        Clear();
                        MessageBox.Show("Deleted successfully!");
                    }
                }
            }
        }
        private void LoadSagesComboBox()
        {
            using (mydbEntities1 db = new mydbEntities1())
            {
                var sages = db.table_sage.ToList();
                comboBoxSage.DataSource = sages;
                comboBoxSage.DisplayMember = "name";
                comboBoxSage.ValueMember = "sageId"; 
            }
        }

        private void comboBoxSage_DropDown(object sender, EventArgs e)
        {
            LoadSagesComboBox();
        }

        private void LoadBooksComboBox()
        {
            using (mydbEntities1 db = new mydbEntities1())
            {
                var books = db.table_book.ToList();
                comboBoxBook.DataSource = books;
                comboBoxBook.DisplayMember = "name";
                comboBoxBook.ValueMember = "bookId";
            }
        }

        private void comboBoxBook_DropDown(object sender, EventArgs e)
        {
            LoadBooksComboBox();
        }

        private void LoadDataSageBook()
        {
            using (mydbEntities1 db = new mydbEntities1())
            {
                var sageBooks = db.table_sage_book
                    .Select(sb => new
                    {
                        Sage = sb.table_sage.name,
                        Book = sb.table_book.name
                    })
                    .ToList();

                dataGridView2.DataSource = sageBooks;
            }
        }


        private void buttonCreateSageBook_Click(object sender, EventArgs e)
        {
            if (comboBoxSage.SelectedValue == null || comboBoxBook.SelectedValue == null)
            {
                MessageBox.Show("Please select both author and book.");
                return;
            }
            int selectedSageId = (int)comboBoxSage.SelectedValue;
            int selectedBookId = (int)comboBoxBook.SelectedValue;

            using (mydbEntities1 db = new mydbEntities1())
            {
                var existingEntry = db.table_sage_book
                    .FirstOrDefault(sb => sb.sageId == selectedSageId && sb.bookId == selectedBookId);

                if (existingEntry != null)
                {
                    MessageBox.Show("This author is already linked to this book.");
                    return;
                }

                var newSageBook = new table_sage_book
                {
                    sageId = selectedSageId,
                    bookId = selectedBookId
                };

                db.table_sage_book.Add(newSageBook);
                db.SaveChanges();

                MessageBox.Show("Author and Book linked successfully!");

                LoadDataSageBook();
            }
        }
    }
}
