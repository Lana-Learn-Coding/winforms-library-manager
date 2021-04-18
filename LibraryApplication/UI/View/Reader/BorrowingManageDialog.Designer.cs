
namespace LibraryApplication.UI.View.Reader
{
    partial class BorrowingManageDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowingManageDialog));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabNewTicket = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addedBBookList = new LibraryApplication.UI.Component.Table.BookListControl();
            this.txtNote = new LibraryApplication.UI.Component.TextboxControl();
            this.datePickerDueDate = new LibraryApplication.UI.Component.DatePickerControl();
            this.txtID = new LibraryApplication.UI.Component.TextboxControl();
            this.btnClearNewTicket = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveNewTicket = new MaterialSkin.Controls.MaterialButton();
            this.txtReaderEmail = new LibraryApplication.UI.Component.TextboxControl();
            this.txtReader = new LibraryApplication.UI.Component.TextboxControl();
            this.headingNewTicket = new MaterialSkin.Controls.MaterialLabel();
            this.availableBookTable = new LibraryApplication.UI.Component.Table.SearchableDataGridViewControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabBorrowManage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.checkSafe = new System.Windows.Forms.CheckBox();
            this.btnRemoveBook = new MaterialSkin.Controls.MaterialButton();
            this.btnExtendTicketDueDate = new MaterialSkin.Controls.MaterialButton();
            this.btnExtendDueDate = new MaterialSkin.Controls.MaterialButton();
            this.btnReturnTicket = new MaterialSkin.Controls.MaterialButton();
            this.btnReturnBook = new MaterialSkin.Controls.MaterialButton();
            this.borrowedBookTable = new LibraryApplication.UI.Component.Table.SearchableDataGridViewControl();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabNewTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabBorrowManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "baseline_history_black_24dp.png");
            this.imageList1.Images.SetKeyName(1, "outline_style_black_24dp.png");
            this.imageList1.Images.SetKeyName(2, "outline_confirmation_number_black_24dp.png");
            // 
            // tabNewTicket
            // 
            this.tabNewTicket.BackColor = System.Drawing.Color.White;
            this.tabNewTicket.Controls.Add(this.splitContainer2);
            this.tabNewTicket.ImageKey = "outline_confirmation_number_black_24dp.png";
            this.tabNewTicket.Location = new System.Drawing.Point(4, 24);
            this.tabNewTicket.Name = "tabNewTicket";
            this.tabNewTicket.Padding = new System.Windows.Forms.Padding(10);
            this.tabNewTicket.Size = new System.Drawing.Size(836, 607);
            this.tabNewTicket.TabIndex = 2;
            this.tabNewTicket.Text = "New Ticket";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(10, 10);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.availableBookTable);
            this.splitContainer2.Size = new System.Drawing.Size(816, 587);
            this.splitContainer2.SplitterDistance = 260;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addedBBookList);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.datePickerDueDate);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnClearNewTicket);
            this.panel1.Controls.Add(this.btnSaveNewTicket);
            this.panel1.Controls.Add(this.txtReaderEmail);
            this.panel1.Controls.Add(this.txtReader);
            this.panel1.Controls.Add(this.headingNewTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 260);
            this.panel1.TabIndex = 0;
            // 
            // addedBBookList
            // 
            this.addedBBookList.DataSource = null;
            this.addedBBookList.Location = new System.Drawing.Point(541, 44);
            this.addedBBookList.MaximumSize = new System.Drawing.Size(275, 500);
            this.addedBBookList.Name = "addedBBookList";
            this.addedBBookList.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.addedBBookList.Size = new System.Drawing.Size(275, 195);
            this.addedBBookList.TabIndex = 48;
            // 
            // txtNote
            // 
            this.txtNote.Error = "";
            this.txtNote.Hint = "Note of the librarian";
            this.txtNote.Label = "Note";
            this.txtNote.Location = new System.Drawing.Point(195, 122);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(312, 72);
            this.txtNote.TabIndex = 44;
            this.txtNote.Value = "";
            // 
            // datePickerDueDate
            // 
            this.datePickerDueDate.Error = "";
            this.datePickerDueDate.Hint = "Book due date";
            this.datePickerDueDate.Label = "Due Date";
            this.datePickerDueDate.Location = new System.Drawing.Point(0, 122);
            this.datePickerDueDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datePickerDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickerDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickerDueDate.Name = "datePickerDueDate";
            this.datePickerDueDate.Size = new System.Drawing.Size(170, 72);
            this.datePickerDueDate.TabIndex = 43;
            this.datePickerDueDate.Value = new System.DateTime(2021, 4, 16, 1, 38, 26, 714);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Error = "";
            this.txtID.Hint = "Ticket ID";
            this.txtID.Label = "ID";
            this.txtID.Location = new System.Drawing.Point(0, 44);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(102, 72);
            this.txtID.TabIndex = 42;
            this.txtID.Value = "";
            // 
            // btnClearNewTicket
            // 
            this.btnClearNewTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearNewTicket.AutoSize = false;
            this.btnClearNewTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearNewTicket.Depth = 0;
            this.btnClearNewTicket.DrawShadows = true;
            this.btnClearNewTicket.HighEmphasis = true;
            this.btnClearNewTicket.Icon = ((System.Drawing.Image)(resources.GetObject("btnClearNewTicket.Icon")));
            this.btnClearNewTicket.Location = new System.Drawing.Point(147, 203);
            this.btnClearNewTicket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearNewTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearNewTicket.Name = "btnClearNewTicket";
            this.btnClearNewTicket.Size = new System.Drawing.Size(129, 36);
            this.btnClearNewTicket.TabIndex = 41;
            this.btnClearNewTicket.Text = "Clear";
            this.btnClearNewTicket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearNewTicket.UseAccentColor = false;
            this.btnClearNewTicket.UseVisualStyleBackColor = true;
            // 
            // btnSaveNewTicket
            // 
            this.btnSaveNewTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNewTicket.AutoSize = false;
            this.btnSaveNewTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveNewTicket.Depth = 0;
            this.btnSaveNewTicket.DrawShadows = true;
            this.btnSaveNewTicket.HighEmphasis = true;
            this.btnSaveNewTicket.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveNewTicket.Icon")));
            this.btnSaveNewTicket.Location = new System.Drawing.Point(0, 203);
            this.btnSaveNewTicket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveNewTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveNewTicket.Name = "btnSaveNewTicket";
            this.btnSaveNewTicket.Size = new System.Drawing.Size(129, 36);
            this.btnSaveNewTicket.TabIndex = 40;
            this.btnSaveNewTicket.Text = "Save";
            this.btnSaveNewTicket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveNewTicket.UseAccentColor = false;
            this.btnSaveNewTicket.UseVisualStyleBackColor = true;
            // 
            // txtReaderEmail
            // 
            this.txtReaderEmail.Enabled = false;
            this.txtReaderEmail.Error = "";
            this.txtReaderEmail.Hint = "";
            this.txtReaderEmail.Label = "Email";
            this.txtReaderEmail.Location = new System.Drawing.Point(321, 44);
            this.txtReaderEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReaderEmail.Name = "txtReaderEmail";
            this.txtReaderEmail.Size = new System.Drawing.Size(186, 72);
            this.txtReaderEmail.TabIndex = 5;
            this.txtReaderEmail.Value = "";
            // 
            // txtReader
            // 
            this.txtReader.Enabled = false;
            this.txtReader.Error = "";
            this.txtReader.Hint = "";
            this.txtReader.Label = "Reader";
            this.txtReader.Location = new System.Drawing.Point(126, 44);
            this.txtReader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReader.Name = "txtReader";
            this.txtReader.Size = new System.Drawing.Size(174, 72);
            this.txtReader.TabIndex = 1;
            this.txtReader.Value = "";
            // 
            // headingNewTicket
            // 
            this.headingNewTicket.AutoSize = true;
            this.headingNewTicket.Depth = 0;
            this.headingNewTicket.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.headingNewTicket.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.headingNewTicket.Location = new System.Drawing.Point(0, 0);
            this.headingNewTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headingNewTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.headingNewTicket.Name = "headingNewTicket";
            this.headingNewTicket.Size = new System.Drawing.Size(121, 29);
            this.headingNewTicket.TabIndex = 4;
            this.headingNewTicket.Text = "New Ticket";
            // 
            // availableBookTable
            // 
            this.availableBookTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableBookTable.Location = new System.Drawing.Point(0, 0);
            this.availableBookTable.Name = "availableBookTable";
            this.availableBookTable.Size = new System.Drawing.Size(816, 323);
            this.availableBookTable.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "baseline_history_black_24dp.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrowing History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabBorrowManage
            // 
            this.tabBorrowManage.Controls.Add(this.splitContainer1);
            this.tabBorrowManage.ImageKey = "outline_style_black_24dp.png";
            this.tabBorrowManage.Location = new System.Drawing.Point(4, 24);
            this.tabBorrowManage.Name = "tabBorrowManage";
            this.tabBorrowManage.Padding = new System.Windows.Forms.Padding(10);
            this.tabBorrowManage.Size = new System.Drawing.Size(836, 607);
            this.tabBorrowManage.TabIndex = 0;
            this.tabBorrowManage.Text = "Borrowing Manage";
            this.tabBorrowManage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.materialLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.checkSafe);
            this.splitContainer1.Panel1.Controls.Add(this.btnRemoveBook);
            this.splitContainer1.Panel1.Controls.Add(this.btnExtendTicketDueDate);
            this.splitContainer1.Panel1.Controls.Add(this.btnExtendDueDate);
            this.splitContainer1.Panel1.Controls.Add(this.btnReturnTicket);
            this.splitContainer1.Panel1.Controls.Add(this.btnReturnBook);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.borrowedBookTable);
            this.splitContainer1.Size = new System.Drawing.Size(816, 587);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(0, 0);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(258, 29);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Manage Borrowed Book";
            // 
            // checkSafe
            // 
            this.checkSafe.AutoSize = true;
            this.checkSafe.Location = new System.Drawing.Point(699, 89);
            this.checkSafe.Name = "checkSafe";
            this.checkSafe.Size = new System.Drawing.Size(114, 19);
            this.checkSafe.TabIndex = 5;
            this.checkSafe.Text = "Safe Action Only";
            this.checkSafe.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveBook.Depth = 0;
            this.btnRemoveBook.DrawShadows = true;
            this.btnRemoveBook.HighEmphasis = true;
            this.btnRemoveBook.Icon = null;
            this.btnRemoveBook.Location = new System.Drawing.Point(266, 44);
            this.btnRemoveBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(122, 36);
            this.btnRemoveBook.TabIndex = 4;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemoveBook.UseAccentColor = true;
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            // 
            // btnExtendTicketDueDate
            // 
            this.btnExtendTicketDueDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExtendTicketDueDate.Depth = 0;
            this.btnExtendTicketDueDate.DrawShadows = true;
            this.btnExtendTicketDueDate.HighEmphasis = true;
            this.btnExtendTicketDueDate.Icon = null;
            this.btnExtendTicketDueDate.Location = new System.Drawing.Point(614, 44);
            this.btnExtendTicketDueDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExtendTicketDueDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExtendTicketDueDate.Name = "btnExtendTicketDueDate";
            this.btnExtendTicketDueDate.Size = new System.Drawing.Size(202, 36);
            this.btnExtendTicketDueDate.TabIndex = 3;
            this.btnExtendTicketDueDate.Text = "Extend Ticket Due Date";
            this.btnExtendTicketDueDate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExtendTicketDueDate.UseAccentColor = false;
            this.btnExtendTicketDueDate.UseVisualStyleBackColor = true;
            // 
            // btnExtendDueDate
            // 
            this.btnExtendDueDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExtendDueDate.Depth = 0;
            this.btnExtendDueDate.DrawShadows = true;
            this.btnExtendDueDate.HighEmphasis = true;
            this.btnExtendDueDate.Icon = null;
            this.btnExtendDueDate.Location = new System.Drawing.Point(458, 44);
            this.btnExtendDueDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExtendDueDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExtendDueDate.Name = "btnExtendDueDate";
            this.btnExtendDueDate.Size = new System.Drawing.Size(148, 36);
            this.btnExtendDueDate.TabIndex = 2;
            this.btnExtendDueDate.Text = "Extend Due Date";
            this.btnExtendDueDate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExtendDueDate.UseAccentColor = false;
            this.btnExtendDueDate.UseVisualStyleBackColor = true;
            // 
            // btnReturnTicket
            // 
            this.btnReturnTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReturnTicket.Depth = 0;
            this.btnReturnTicket.DrawShadows = true;
            this.btnReturnTicket.HighEmphasis = true;
            this.btnReturnTicket.Icon = null;
            this.btnReturnTicket.Location = new System.Drawing.Point(128, 44);
            this.btnReturnTicket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReturnTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReturnTicket.Name = "btnReturnTicket";
            this.btnReturnTicket.Size = new System.Drawing.Size(130, 36);
            this.btnReturnTicket.TabIndex = 1;
            this.btnReturnTicket.Text = "Return Ticket";
            this.btnReturnTicket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReturnTicket.UseAccentColor = false;
            this.btnReturnTicket.UseVisualStyleBackColor = true;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReturnBook.Depth = 0;
            this.btnReturnBook.DrawShadows = true;
            this.btnReturnBook.HighEmphasis = true;
            this.btnReturnBook.Icon = null;
            this.btnReturnBook.Location = new System.Drawing.Point(0, 44);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReturnBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(120, 36);
            this.btnReturnBook.TabIndex = 0;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReturnBook.UseAccentColor = false;
            this.btnReturnBook.UseVisualStyleBackColor = true;
            // 
            // borrowedBookTable
            // 
            this.borrowedBookTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowedBookTable.Location = new System.Drawing.Point(0, 0);
            this.borrowedBookTable.Name = "borrowedBookTable";
            this.borrowedBookTable.Size = new System.Drawing.Size(816, 453);
            this.borrowedBookTable.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBorrowManage);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabNewTicket);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(60, 64);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(844, 635);
            this.tabControl.TabIndex = 0;
            // 
            // BorrowingManageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 702);
            this.Controls.Add(this.tabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.Name = "BorrowingManageDialog";
            this.Padding = new System.Windows.Forms.Padding(60, 64, 4, 3);
            this.Text = "Borrowing Manage";
            this.tabNewTicket.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabBorrowManage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabNewTicket;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabBorrowManage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private MaterialSkin.Controls.MaterialLabel heading;
        private MaterialSkin.Controls.MaterialLabel headingNewTicket;
        private Component.TextboxControl txtReaderEmail;
        private Component.TextboxControl txtReader;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnSaveNewTicket;
        private Component.TextboxControl txtID;
        private Component.DatePickerControl datePickerDueDate;
        private Component.TextboxControl txtNote;
        private MaterialSkin.Controls.MaterialButton btnClearNewTicket;
        private Component.Table.BookListControl addedBBookList;
        private Component.Table.SearchableDataGridViewControl availableBookTable;
        private Component.Table.SearchableDataGridViewControl borrowedBookTable;
        private MaterialSkin.Controls.MaterialButton btnReturnBook;
        private MaterialSkin.Controls.MaterialButton btnReturnTicket;
        private MaterialSkin.Controls.MaterialButton btnExtendDueDate;
        private MaterialSkin.Controls.MaterialButton btnExtendTicketDueDate;
        private MaterialSkin.Controls.MaterialButton btnRemoveBook;
        private System.Windows.Forms.CheckBox checkSafe;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}