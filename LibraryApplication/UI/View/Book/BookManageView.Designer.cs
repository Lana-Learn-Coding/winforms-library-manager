
namespace LibraryApplication.UI.View.Book
{
    partial class BookManageView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManageView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnViewBooks = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.imgPicker = new LibraryApplication.UI.Component.ImagePickerControl();
            this.selectPublisher = new LibraryApplication.UI.Component.Combobox.PublisherComboboxControl();
            this.selectAuthor = new LibraryApplication.UI.Component.Combobox.AuthorComboboxControl();
            this.selectSeries = new LibraryApplication.UI.Component.Combobox.SeriesComboboxControl();
            this.selectCategory = new LibraryApplication.UI.Component.Combobox.CategoryComboboxControl();
            this.txtYear = new LibraryApplication.UI.Component.NumericControl();
            this.txtTitle = new LibraryApplication.UI.Component.TextboxControl();
            this.txtID = new LibraryApplication.UI.Component.TextboxControl();
            this.heading = new MaterialSkin.Controls.MaterialLabel();
            this.table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnViewBooks);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.imgPicker);
            this.splitContainer1.Panel1.Controls.Add(this.selectPublisher);
            this.splitContainer1.Panel1.Controls.Add(this.selectAuthor);
            this.splitContainer1.Panel1.Controls.Add(this.selectSeries);
            this.splitContainer1.Panel1.Controls.Add(this.selectCategory);
            this.splitContainer1.Panel1.Controls.Add(this.txtYear);
            this.splitContainer1.Panel1.Controls.Add(this.txtTitle);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.heading);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.table);
            this.splitContainer1.Size = new System.Drawing.Size(876, 776);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSize = false;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.DrawShadows = true;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = ((System.Drawing.Image)(resources.GetObject("btnClear.Icon")));
            this.btnClear.Location = new System.Drawing.Point(747, 106);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 36);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.DrawShadows = true;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = ((System.Drawing.Image)(resources.GetObject("btnDelete.Icon")));
            this.btnDelete.Location = new System.Drawing.Point(747, 154);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 36);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnViewBooks
            // 
            this.btnViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewBooks.AutoSize = false;
            this.btnViewBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewBooks.Depth = 0;
            this.btnViewBooks.DrawShadows = true;
            this.btnViewBooks.HighEmphasis = false;
            this.btnViewBooks.Icon = ((System.Drawing.Image)(resources.GetObject("btnViewBooks.Icon")));
            this.btnViewBooks.Location = new System.Drawing.Point(747, 231);
            this.btnViewBooks.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewBooks.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewBooks.Name = "btnViewBooks";
            this.btnViewBooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnViewBooks.Size = new System.Drawing.Size(129, 36);
            this.btnViewBooks.TabIndex = 34;
            this.btnViewBooks.Text = "View Books";
            this.btnViewBooks.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnViewBooks.UseAccentColor = false;
            this.btnViewBooks.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.DrawShadows = true;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.Location = new System.Drawing.Point(747, 58);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 36);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // imgPicker
            // 
            this.imgPicker.Location = new System.Drawing.Point(572, 58);
            this.imgPicker.Name = "imgPicker";
            this.imgPicker.Padding = new System.Windows.Forms.Padding(1, 1, 1, 10);
            this.imgPicker.Size = new System.Drawing.Size(150, 219);
            this.imgPicker.TabIndex = 32;
            this.imgPicker.Tag = "image";
            // 
            // selectPublisher
            // 
            this.selectPublisher.Error = "";
            this.selectPublisher.Hint = "Select Publisher";
            this.selectPublisher.Label = "Publisher";
            this.selectPublisher.Location = new System.Drawing.Point(294, 133);
            this.selectPublisher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectPublisher.Name = "selectPublisher";
            this.selectPublisher.Size = new System.Drawing.Size(238, 69);
            this.selectPublisher.TabIndex = 31;
            // 
            // selectAuthor
            // 
            this.selectAuthor.Error = "";
            this.selectAuthor.Hint = "Select Author";
            this.selectAuthor.Label = "Author";
            this.selectAuthor.Location = new System.Drawing.Point(0, 133);
            this.selectAuthor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectAuthor.Name = "selectAuthor";
            this.selectAuthor.Size = new System.Drawing.Size(274, 69);
            this.selectAuthor.TabIndex = 30;
            // 
            // selectSeries
            // 
            this.selectSeries.Error = "";
            this.selectSeries.Hint = "Select Series";
            this.selectSeries.Label = "Series";
            this.selectSeries.Location = new System.Drawing.Point(294, 208);
            this.selectSeries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectSeries.Name = "selectSeries";
            this.selectSeries.Size = new System.Drawing.Size(238, 69);
            this.selectSeries.TabIndex = 29;
            // 
            // selectCategory
            // 
            this.selectCategory.Error = "";
            this.selectCategory.Hint = "Select Category";
            this.selectCategory.Label = "Category";
            this.selectCategory.Location = new System.Drawing.Point(0, 208);
            this.selectCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectCategory.Name = "selectCategory";
            this.selectCategory.Size = new System.Drawing.Size(274, 69);
            this.selectCategory.TabIndex = 28;
            // 
            // txtYear
            // 
            this.txtYear.Error = "";
            this.txtYear.Hint = "Publish year";
            this.txtYear.Label = "Year";
            this.txtYear.Location = new System.Drawing.Point(415, 58);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(117, 69);
            this.txtYear.TabIndex = 27;
            this.txtYear.Value = null;
            // 
            // txtTitle
            // 
            this.txtTitle.Error = "";
            this.txtTitle.Hint = "Enter book title";
            this.txtTitle.Label = "Title";
            this.txtTitle.Location = new System.Drawing.Point(123, 58);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(270, 69);
            this.txtTitle.TabIndex = 24;
            this.txtTitle.Value = "";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Error = "";
            this.txtID.Hint = "Book ID";
            this.txtID.Label = "ID";
            this.txtID.Location = new System.Drawing.Point(0, 58);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(106, 69);
            this.txtID.TabIndex = 23;
            this.txtID.Value = "";
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Depth = 0;
            this.heading.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.heading.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.heading.Location = new System.Drawing.Point(0, 0);
            this.heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heading.MouseState = MaterialSkin.MouseState.HOVER;
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(209, 41);
            this.heading.TabIndex = 1;
            this.heading.Text = "Book Manage";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowTemplate.Height = 25;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(876, 421);
            this.table.TabIndex = 0;
            // 
            // BookManageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BookManageView";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(900, 800);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialLabel heading;
        private Component.TextboxControl txtTitle;
        private Component.TextboxControl txtID;
        private Component.Combobox.SeriesComboboxControl selectSeries;
        private Component.Combobox.CategoryComboboxControl selectCategory;
        private Component.NumericControl txtYear;
        private Component.Combobox.PublisherComboboxControl selectPublisher;
        private Component.Combobox.AuthorComboboxControl selectAuthor;
        private Component.ImagePickerControl imgPicker;
        private System.Windows.Forms.DataGridView table;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnViewBooks;
    }
}
