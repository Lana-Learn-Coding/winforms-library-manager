
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboboxControl4 = new LibraryApplication.UI.Component.ComboboxControl();
            this.selectAuthor = new LibraryApplication.UI.Component.ComboboxControl();
            this.comboboxControl2 = new LibraryApplication.UI.Component.ComboboxControl();
            this.comboboxControl1 = new LibraryApplication.UI.Component.ComboboxControl();
            this.txtYear = new LibraryApplication.UI.Component.NumericControl();
            this.txtTitle = new LibraryApplication.UI.Component.TextboxControl();
            this.txtID = new LibraryApplication.UI.Component.TextboxControl();
            this.heading = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.imagePickerControl1 = new LibraryApplication.UI.Component.ImagePickerControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.imagePickerControl1);
            this.splitContainer1.Panel1.Controls.Add(this.comboboxControl4);
            this.splitContainer1.Panel1.Controls.Add(this.selectAuthor);
            this.splitContainer1.Panel1.Controls.Add(this.comboboxControl2);
            this.splitContainer1.Panel1.Controls.Add(this.comboboxControl1);
            this.splitContainer1.Panel1.Controls.Add(this.txtYear);
            this.splitContainer1.Panel1.Controls.Add(this.txtTitle);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.heading);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.materialListView1);
            this.splitContainer1.Size = new System.Drawing.Size(1376, 899);
            this.splitContainer1.SplitterDistance = 437;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboboxControl4
            // 
            this.comboboxControl4.Error = "";
            this.comboboxControl4.Hint = "Select Publisher";
            this.comboboxControl4.Label = "Publisher";
            this.comboboxControl4.Location = new System.Drawing.Point(271, 133);
            this.comboboxControl4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboboxControl4.Name = "comboboxControl4";
            this.comboboxControl4.Size = new System.Drawing.Size(256, 69);
            this.comboboxControl4.TabIndex = 31;
            // 
            // selectAuthor
            // 
            this.selectAuthor.Error = "";
            this.selectAuthor.Hint = "Select Author";
            this.selectAuthor.Label = "Author";
            this.selectAuthor.Location = new System.Drawing.Point(0, 133);
            this.selectAuthor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectAuthor.Name = "selectAuthor";
            this.selectAuthor.Size = new System.Drawing.Size(244, 69);
            this.selectAuthor.TabIndex = 30;
            // 
            // comboboxControl2
            // 
            this.comboboxControl2.Error = "";
            this.comboboxControl2.Hint = "Select series";
            this.comboboxControl2.Label = "Series";
            this.comboboxControl2.Location = new System.Drawing.Point(271, 208);
            this.comboboxControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboboxControl2.Name = "comboboxControl2";
            this.comboboxControl2.Size = new System.Drawing.Size(256, 69);
            this.comboboxControl2.TabIndex = 29;
            // 
            // comboboxControl1
            // 
            this.comboboxControl1.Error = "";
            this.comboboxControl1.Hint = "Select category";
            this.comboboxControl1.Label = "Category";
            this.comboboxControl1.Location = new System.Drawing.Point(0, 208);
            this.comboboxControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboboxControl1.Name = "comboboxControl1";
            this.comboboxControl1.Size = new System.Drawing.Size(244, 69);
            this.comboboxControl1.TabIndex = 28;
            // 
            // txtYear
            // 
            this.txtYear.Error = "";
            this.txtYear.Hint = "Publish year";
            this.txtYear.Label = "Year";
            this.txtYear.Location = new System.Drawing.Point(400, 58);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(127, 69);
            this.txtYear.TabIndex = 27;
            // 
            // txtTitle
            // 
            this.txtTitle.Error = "";
            this.txtTitle.Hint = "Enter book title";
            this.txtTitle.Label = "Title";
            this.txtTitle.Location = new System.Drawing.Point(147, 58);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(233, 69);
            this.txtTitle.TabIndex = 24;
            // 
            // txtID
            // 
            this.txtID.Error = "";
            this.txtID.Hint = "Book ID";
            this.txtID.Label = "ID";
            this.txtID.Location = new System.Drawing.Point(0, 58);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(130, 69);
            this.txtID.TabIndex = 23;
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
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(0, 0);
            this.materialListView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialListView1.MinimumSize = new System.Drawing.Size(233, 115);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1376, 457);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // imagePickerControl1
            // 
            this.imagePickerControl1.Location = new System.Drawing.Point(567, 58);
            this.imagePickerControl1.Name = "imagePickerControl1";
            this.imagePickerControl1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 10);
            this.imagePickerControl1.Size = new System.Drawing.Size(135, 219);
            this.imagePickerControl1.TabIndex = 32;
            // 
            // BookManageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BookManageView";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(1400, 923);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialLabel heading;
        private Component.TextboxControl txtTitle;
        private Component.TextboxControl txtID;
        private Component.ComboboxControl comboboxControl2;
        private Component.ComboboxControl comboboxControl1;
        private Component.NumericControl txtYear;
        private Component.ComboboxControl comboboxControl4;
        private Component.ComboboxControl selectAuthor;
        private Component.ImagePickerControl imagePickerControl1;
    }
}
