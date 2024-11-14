namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxPhoto = new System.Windows.Forms.TextBox();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dgsageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgbookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdescriptionBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.textBoxBookDescription = new System.Windows.Forms.TextBox();
            this.buttonSaveBook = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonCreateSageBook = new System.Windows.Forms.Button();
            this.comboBoxSage = new System.Windows.Forms.ComboBox();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(615, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(677, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(154, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(677, 113);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(154, 20);
            this.textBoxAge.TabIndex = 3;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(615, 115);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(37, 13);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age :";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(677, 185);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(154, 20);
            this.textBoxCity.TabIndex = 7;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(616, 188);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(36, 13);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "City :";
            // 
            // textBoxPhoto
            // 
            this.textBoxPhoto.Location = new System.Drawing.Point(677, 149);
            this.textBoxPhoto.Name = "textBoxPhoto";
            this.textBoxPhoto.Size = new System.Drawing.Size(154, 20);
            this.textBoxPhoto.TabIndex = 5;
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(615, 152);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(48, 13);
            this.labelPhoto.TabIndex = 4;
            this.labelPhoto.Text = "Photo :";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(598, 253);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Create";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(688, 253);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(782, 253);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgsageId,
            this.dgname,
            this.dgAge,
            this.dgPhoto,
            this.dgCity});
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(552, 484);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // dgsageId
            // 
            this.dgsageId.DataPropertyName = "sageId";
            this.dgsageId.HeaderText = "SageID";
            this.dgsageId.Name = "dgsageId";
            this.dgsageId.ReadOnly = true;
            this.dgsageId.Visible = false;
            // 
            // dgname
            // 
            this.dgname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgname.DataPropertyName = "name";
            this.dgname.HeaderText = "Name";
            this.dgname.Name = "dgname";
            this.dgname.ReadOnly = true;
            // 
            // dgAge
            // 
            this.dgAge.DataPropertyName = "age";
            this.dgAge.HeaderText = "Age";
            this.dgAge.Name = "dgAge";
            this.dgAge.ReadOnly = true;
            // 
            // dgPhoto
            // 
            this.dgPhoto.DataPropertyName = "photo";
            this.dgPhoto.HeaderText = "Photo";
            this.dgPhoto.Name = "dgPhoto";
            this.dgPhoto.ReadOnly = true;
            // 
            // dgCity
            // 
            this.dgCity.DataPropertyName = "city";
            this.dgCity.HeaderText = "City";
            this.dgCity.Name = "dgCity";
            this.dgCity.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 506);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Controls.Add(this.buttonCancel);
            this.tabPage1.Controls.Add(this.labelAge);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.textBoxAge);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.labelPhoto);
            this.tabPage1.Controls.Add(this.textBoxCity);
            this.tabPage1.Controls.Add(this.textBoxPhoto);
            this.tabPage1.Controls.Add(this.labelCity);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.textBoxBookName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonCancelBook);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.buttonDeleteBook);
            this.tabPage2.Controls.Add(this.textBoxBookDescription);
            this.tabPage2.Controls.Add(this.buttonSaveBook);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgbookId,
            this.dgnameBook,
            this.dgdescriptionBook});
            this.dataGridView1.Location = new System.Drawing.Point(-4, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(533, 481);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // dgbookId
            // 
            this.dgbookId.DataPropertyName = "bookId";
            this.dgbookId.HeaderText = "BookId";
            this.dgbookId.Name = "dgbookId";
            this.dgbookId.ReadOnly = true;
            this.dgbookId.Visible = false;
            // 
            // dgnameBook
            // 
            this.dgnameBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgnameBook.DataPropertyName = "name";
            this.dgnameBook.HeaderText = "Name";
            this.dgnameBook.Name = "dgnameBook";
            this.dgnameBook.ReadOnly = true;
            // 
            // dgdescriptionBook
            // 
            this.dgdescriptionBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgdescriptionBook.DataPropertyName = "description";
            this.dgdescriptionBook.HeaderText = "Description";
            this.dgdescriptionBook.Name = "dgdescriptionBook";
            this.dgdescriptionBook.ReadOnly = true;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(686, 144);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(154, 20);
            this.textBoxBookName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name :";
            // 
            // buttonCancelBook
            // 
            this.buttonCancelBook.Location = new System.Drawing.Point(765, 230);
            this.buttonCancelBook.Name = "buttonCancelBook";
            this.buttonCancelBook.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelBook.TabIndex = 21;
            this.buttonCancelBook.Text = "Cancel";
            this.buttonCancelBook.UseVisualStyleBackColor = true;
            this.buttonCancelBook.Click += new System.EventHandler(this.buttonCancelBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description :";
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(671, 230);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteBook.TabIndex = 20;
            this.buttonDeleteBook.Text = "Delete";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // textBoxBookDescription
            // 
            this.textBoxBookDescription.Location = new System.Drawing.Point(686, 180);
            this.textBoxBookDescription.Name = "textBoxBookDescription";
            this.textBoxBookDescription.Size = new System.Drawing.Size(154, 20);
            this.textBoxBookDescription.TabIndex = 14;
            // 
            // buttonSaveBook
            // 
            this.buttonSaveBook.Location = new System.Drawing.Point(581, 230);
            this.buttonSaveBook.Name = "buttonSaveBook";
            this.buttonSaveBook.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveBook.TabIndex = 19;
            this.buttonSaveBook.Text = "Create";
            this.buttonSaveBook.UseVisualStyleBackColor = true;
            this.buttonSaveBook.Click += new System.EventHandler(this.buttonSaveBook_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.buttonCreateSageBook);
            this.tabPage3.Controls.Add(this.comboBoxSage);
            this.tabPage3.Controls.Add(this.comboBoxBook);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(886, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(491, 480);
            this.dataGridView2.TabIndex = 7;
            // 
            // buttonCreateSageBook
            // 
            this.buttonCreateSageBook.Location = new System.Drawing.Point(662, 209);
            this.buttonCreateSageBook.Name = "buttonCreateSageBook";
            this.buttonCreateSageBook.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateSageBook.TabIndex = 6;
            this.buttonCreateSageBook.Text = "Create";
            this.buttonCreateSageBook.UseVisualStyleBackColor = true;
            this.buttonCreateSageBook.Click += new System.EventHandler(this.buttonCreateSageBook_Click);
            // 
            // comboBoxSage
            // 
            this.comboBoxSage.FormattingEnabled = true;
            this.comboBoxSage.Location = new System.Drawing.Point(558, 154);
            this.comboBoxSage.Name = "comboBoxSage";
            this.comboBoxSage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSage.TabIndex = 5;
            this.comboBoxSage.DropDown += new System.EventHandler(this.comboBoxSage_DropDown);
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(724, 154);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBook.TabIndex = 4;
            this.comboBoxBook.DropDown += new System.EventHandler(this.comboBoxBook_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Book:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxPhoto;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.TextBox textBoxBookDescription;
        private System.Windows.Forms.Button buttonSaveBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSage;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.Button buttonCreateSageBook;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdescriptionBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCity;
    }
}

