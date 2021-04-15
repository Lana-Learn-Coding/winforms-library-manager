
namespace LibraryApplication.UI.View.Reader
{
    partial class TicketManageView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketManageView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bookListControl1 = new LibraryApplication.UI.Component.BookListControl();
            this.datePickerReturn = new LibraryApplication.UI.Component.DatePickerControl();
            this.datePickerBorrow = new LibraryApplication.UI.Component.DatePickerControl();
            this.btnReturn = new MaterialSkin.Controls.MaterialButton();
            this.btnBorrow = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.txtNote = new LibraryApplication.UI.Component.TextboxControl();
            this.datePickerDueDate = new LibraryApplication.UI.Component.DatePickerControl();
            this.txtID = new LibraryApplication.UI.Component.TextboxControl();
            this.txtReader = new LibraryApplication.UI.Component.TextboxControl();
            this.headingNewTicket = new MaterialSkin.Controls.MaterialLabel();
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
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bookListControl1);
            this.splitContainer1.Panel1.Controls.Add(this.datePickerReturn);
            this.splitContainer1.Panel1.Controls.Add(this.datePickerBorrow);
            this.splitContainer1.Panel1.Controls.Add(this.btnReturn);
            this.splitContainer1.Panel1.Controls.Add(this.btnBorrow);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.txtNote);
            this.splitContainer1.Panel1.Controls.Add(this.datePickerDueDate);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.txtReader);
            this.splitContainer1.Panel1.Controls.Add(this.headingNewTicket);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.table);
            this.splitContainer1.Size = new System.Drawing.Size(876, 776);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            // 
            // bookListControl1
            // 
            this.bookListControl1.Location = new System.Drawing.Point(445, 58);
            this.bookListControl1.MaximumSize = new System.Drawing.Size(275, 500);
            this.bookListControl1.Name = "bookListControl1";
            this.bookListControl1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bookListControl1.Size = new System.Drawing.Size(275, 215);
            this.bookListControl1.TabIndex = 59;
            // 
            // datePickerReturn
            // 
            this.datePickerReturn.Enabled = false;
            this.datePickerReturn.Error = "";
            this.datePickerReturn.Hint = "Book Return Date";
            this.datePickerReturn.Label = "Returned Date";
            this.datePickerReturn.Location = new System.Drawing.Point(210, 136);
            this.datePickerReturn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datePickerReturn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickerReturn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickerReturn.Name = "datePickerReturn";
            this.datePickerReturn.Size = new System.Drawing.Size(206, 72);
            this.datePickerReturn.TabIndex = 58;
            this.datePickerReturn.Value = new System.DateTime(2021, 4, 16, 1, 38, 26, 714);
            // 
            // datePickerBorrow
            // 
            this.datePickerBorrow.Enabled = false;
            this.datePickerBorrow.Error = "";
            this.datePickerBorrow.Hint = "Borrow date";
            this.datePickerBorrow.Label = "Borrow Date";
            this.datePickerBorrow.Location = new System.Drawing.Point(287, 58);
            this.datePickerBorrow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datePickerBorrow.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickerBorrow.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickerBorrow.Name = "datePickerBorrow";
            this.datePickerBorrow.Size = new System.Drawing.Size(129, 72);
            this.datePickerBorrow.TabIndex = 57;
            this.datePickerBorrow.Value = new System.DateTime(2021, 4, 16, 1, 38, 26, 714);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.AutoSize = false;
            this.btnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReturn.Depth = 0;
            this.btnReturn.DrawShadows = true;
            this.btnReturn.HighEmphasis = false;
            this.btnReturn.Icon = ((System.Drawing.Image)(resources.GetObject("btnReturn.Icon")));
            this.btnReturn.Location = new System.Drawing.Point(747, 189);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReturn.Size = new System.Drawing.Size(129, 36);
            this.btnReturn.TabIndex = 56;
            this.btnReturn.Text = "Return";
            this.btnReturn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReturn.UseAccentColor = false;
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrow.AutoSize = false;
            this.btnBorrow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBorrow.Depth = 0;
            this.btnBorrow.DrawShadows = true;
            this.btnBorrow.HighEmphasis = false;
            this.btnBorrow.Icon = ((System.Drawing.Image)(resources.GetObject("btnBorrow.Icon")));
            this.btnBorrow.Location = new System.Drawing.Point(747, 237);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBorrow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBorrow.Size = new System.Drawing.Size(129, 36);
            this.btnBorrow.TabIndex = 55;
            this.btnBorrow.Text = "Borrowing";
            this.btnBorrow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBorrow.UseAccentColor = false;
            this.btnBorrow.UseVisualStyleBackColor = true;
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
            this.btnDelete.Location = new System.Drawing.Point(747, 106);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 36);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = true;
            this.btnDelete.UseVisualStyleBackColor = true;
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
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Error = "";
            this.txtNote.Hint = "Note of the librarian";
            this.txtNote.Label = "Note";
            this.txtNote.Location = new System.Drawing.Point(-1, 214);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(416, 72);
            this.txtNote.TabIndex = 49;
            this.txtNote.Value = "";
            // 
            // datePickerDueDate
            // 
            this.datePickerDueDate.Error = "";
            this.datePickerDueDate.Hint = "Ticket due date";
            this.datePickerDueDate.Label = "Due Date";
            this.datePickerDueDate.Location = new System.Drawing.Point(-1, 136);
            this.datePickerDueDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datePickerDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickerDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickerDueDate.Name = "datePickerDueDate";
            this.datePickerDueDate.Size = new System.Drawing.Size(191, 72);
            this.datePickerDueDate.TabIndex = 48;
            this.datePickerDueDate.Value = new System.DateTime(2021, 4, 16, 1, 38, 26, 714);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Error = "";
            this.txtID.Hint = "Ticket ID";
            this.txtID.Label = "ID";
            this.txtID.Location = new System.Drawing.Point(0, 58);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(88, 72);
            this.txtID.TabIndex = 47;
            this.txtID.Value = "";
            // 
            // txtReader
            // 
            this.txtReader.Enabled = false;
            this.txtReader.Error = "";
            this.txtReader.Hint = "Borrower";
            this.txtReader.Label = "Reader";
            this.txtReader.Location = new System.Drawing.Point(105, 58);
            this.txtReader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReader.Name = "txtReader";
            this.txtReader.Size = new System.Drawing.Size(165, 72);
            this.txtReader.TabIndex = 45;
            this.txtReader.Value = "";
            // 
            // headingNewTicket
            // 
            this.headingNewTicket.AutoSize = true;
            this.headingNewTicket.Depth = 0;
            this.headingNewTicket.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.headingNewTicket.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.headingNewTicket.Location = new System.Drawing.Point(0, 0);
            this.headingNewTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headingNewTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.headingNewTicket.Name = "headingNewTicket";
            this.headingNewTicket.Size = new System.Drawing.Size(169, 41);
            this.headingNewTicket.TabIndex = 5;
            this.headingNewTicket.Text = "New Ticket";
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 25;
            this.table.Size = new System.Drawing.Size(876, 422);
            this.table.TabIndex = 0;
            // 
            // TicketManageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TicketManageView";
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
        private System.Windows.Forms.DataGridView table;
        private MaterialSkin.Controls.MaterialLabel headingNewTicket;
        private Component.TextboxControl txtNote;
        private Component.DatePickerControl datePickerDueDate;
        private Component.TextboxControl txtID;
        private Component.TextboxControl txtReader;
        private MaterialSkin.Controls.MaterialButton btnBorrow;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private Component.DatePickerControl datePickerBorrow;
        private MaterialSkin.Controls.MaterialButton btnReturn;
        private Component.DatePickerControl datePickerReturn;
        private Component.BookListControl bookListControl1;
    }
}
