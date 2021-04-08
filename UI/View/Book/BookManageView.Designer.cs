
namespace WinFormsLibraryManager.UI.View.Book
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox9 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.ID = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox8 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAuthor = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.heading = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.selectCategory = new WinFormsLibraryManager.UI.Component.NamedEntityCombobox(this.components);
            this.selectSeries = new WinFormsLibraryManager.UI.Component.NamedEntityCombobox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.selectSeries);
            this.splitContainer1.Panel1.Controls.Add(this.selectCategory);
            this.splitContainer1.Panel1.Controls.Add(this.materialLabel6);
            this.splitContainer1.Panel1.Controls.Add(this.materialLabel4);
            this.splitContainer1.Panel1.Controls.Add(this.materialLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.materialTextBox9);
            this.splitContainer1.Panel1.Controls.Add(this.materialLabel5);
            this.splitContainer1.Panel1.Controls.Add(this.ID);
            this.splitContainer1.Panel1.Controls.Add(this.materialLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.materialLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.materialTextBox8);
            this.splitContainer1.Panel1.Controls.Add(this.txtAuthor);
            this.splitContainer1.Panel1.Controls.Add(this.materialTextBox5);
            this.splitContainer1.Panel1.Controls.Add(this.materialTextBox4);
            this.splitContainer1.Panel1.Controls.Add(this.heading);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.materialListView1);
            this.splitContainer1.Size = new System.Drawing.Size(1180, 780);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 0;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(263, 176);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(44, 19);
            this.materialLabel6.TabIndex = 22;
            this.materialLabel6.Text = "Series";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(4, 176);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(64, 19);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Category";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(263, 111);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(58, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Pulisher";
            // 
            // materialTextBox9
            // 
            this.materialTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox9.Depth = 0;
            this.materialTextBox9.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox9.Hint = "Enter book title";
            this.materialTextBox9.Location = new System.Drawing.Point(118, 72);
            this.materialTextBox9.MaxLength = 50;
            this.materialTextBox9.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox9.Multiline = false;
            this.materialTextBox9.Name = "materialTextBox9";
            this.materialTextBox9.Size = new System.Drawing.Size(275, 36);
            this.materialTextBox9.TabIndex = 18;
            this.materialTextBox9.Text = "";
            this.materialTextBox9.UseAccent = false;
            this.materialTextBox9.UseTallSize = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(4, 111);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(48, 19);
            this.materialLabel5.TabIndex = 16;
            this.materialLabel5.Text = "Author";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Depth = 0;
            this.ID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ID.Location = new System.Drawing.Point(4, 50);
            this.ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 19);
            this.ID.TabIndex = 13;
            this.ID.Text = "ID";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(115, 50);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(32, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Tilte";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(405, 50);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(33, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Year";
            // 
            // materialTextBox8
            // 
            this.materialTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox8.Depth = 0;
            this.materialTextBox8.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox8.Hint = "Book ID";
            this.materialTextBox8.Location = new System.Drawing.Point(3, 72);
            this.materialTextBox8.MaxLength = 50;
            this.materialTextBox8.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox8.Multiline = false;
            this.materialTextBox8.Name = "materialTextBox8";
            this.materialTextBox8.Size = new System.Drawing.Size(100, 36);
            this.materialTextBox8.TabIndex = 10;
            this.materialTextBox8.Text = "";
            this.materialTextBox8.UseAccent = false;
            this.materialTextBox8.UseTallSize = false;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Depth = 0;
            this.txtAuthor.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtAuthor.Hint = "Enter Book Authors";
            this.txtAuthor.Location = new System.Drawing.Point(3, 133);
            this.txtAuthor.MaxLength = 50;
            this.txtAuthor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAuthor.Multiline = false;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(246, 36);
            this.txtAuthor.TabIndex = 9;
            this.txtAuthor.Text = "";
            this.txtAuthor.UseAccent = false;
            this.txtAuthor.UseTallSize = false;
            // 
            // materialTextBox5
            // 
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox5.Hint = "Enter Book Publisher";
            this.materialTextBox5.Location = new System.Drawing.Point(266, 133);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.Size = new System.Drawing.Size(252, 36);
            this.materialTextBox5.TabIndex = 7;
            this.materialTextBox5.Text = "";
            this.materialTextBox5.UseAccent = false;
            this.materialTextBox5.UseTallSize = false;
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox4.Hint = "Publish Year";
            this.materialTextBox4.Location = new System.Drawing.Point(408, 72);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(110, 36);
            this.materialTextBox4.TabIndex = 6;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.UseAccent = false;
            this.materialTextBox4.UseTallSize = false;
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Depth = 0;
            this.heading.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.heading.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.heading.Location = new System.Drawing.Point(0, 0);
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
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1180, 396);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // selectCategory
            // 
            this.selectCategory.AutoResize = false;
            this.selectCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectCategory.CreateSelectionText = "--- Create new item ---";
            this.selectCategory.DefaultSelectionText = "--- (None) ---";
            this.selectCategory.Depth = 0;
            this.selectCategory.DisplayMember = "Name";
            this.selectCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.selectCategory.DropDownHeight = 118;
            this.selectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCategory.DropDownWidth = 121;
            this.selectCategory.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.selectCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectCategory.FormattingEnabled = true;
            this.selectCategory.IntegralHeight = false;
            this.selectCategory.ItemHeight = 29;
            this.selectCategory.Location = new System.Drawing.Point(3, 198);
            this.selectCategory.MaxDropDownItems = 4;
            this.selectCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.selectCategory.Name = "selectCategory";
            this.selectCategory.Size = new System.Drawing.Size(246, 35);
            this.selectCategory.StartIndex = 0;
            this.selectCategory.TabIndex = 23;
            this.selectCategory.UseAccent = false;
            this.selectCategory.UseTallSize = false;
            // 
            // selectSeries
            // 
            this.selectSeries.AutoResize = false;
            this.selectSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectSeries.CreateSelectionText = "--- Create new item ---";
            this.selectSeries.DefaultSelectionText = "--- (None) ---";
            this.selectSeries.Depth = 0;
            this.selectSeries.DisplayMember = "Name";
            this.selectSeries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.selectSeries.DropDownHeight = 118;
            this.selectSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectSeries.DropDownWidth = 121;
            this.selectSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.selectSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectSeries.FormattingEnabled = true;
            this.selectSeries.IntegralHeight = false;
            this.selectSeries.ItemHeight = 29;
            this.selectSeries.Location = new System.Drawing.Point(266, 198);
            this.selectSeries.MaxDropDownItems = 4;
            this.selectSeries.MouseState = MaterialSkin.MouseState.OUT;
            this.selectSeries.Name = "selectSeries";
            this.selectSeries.Size = new System.Drawing.Size(252, 35);
            this.selectSeries.StartIndex = 0;
            this.selectSeries.TabIndex = 24;
            this.selectSeries.UseAccent = false;
            this.selectSeries.UseTallSize = false;
            // 
            // BookManageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "BookManageView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1200, 800);
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
        private MaterialSkin.Controls.MaterialLabel ID;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox8;
        private MaterialSkin.Controls.MaterialTextBox txtAuthor;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox9;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private Component.NamedEntityCombobox selectSeries;
        private Component.NamedEntityCombobox selectCategory;
    }
}
