
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.newTicketBookListTable = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.txtNote = new LibraryApplication.UI.Component.TextboxControl();
            this.datePickerDueDate = new LibraryApplication.UI.Component.DatePickerControl();
            this.txtID = new LibraryApplication.UI.Component.TextboxControl();
            this.btnClearNewTicket = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveNewTicket = new MaterialSkin.Controls.MaterialButton();
            this.txtReaderEmail = new LibraryApplication.UI.Component.TextboxControl();
            this.txtReader = new LibraryApplication.UI.Component.TextboxControl();
            this.headingNewTicket = new MaterialSkin.Controls.MaterialLabel();
            this.addedBookTable = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabNewTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addedBookTable)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
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
            this.splitContainer2.Panel2.Controls.Add(this.addedBookTable);
            this.splitContainer2.Size = new System.Drawing.Size(816, 587);
            this.splitContainer2.SplitterDistance = 298;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.newTicketBookListTable);
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
            this.panel1.Size = new System.Drawing.Size(816, 298);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(539, 44);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 46;
            this.materialLabel1.Text = "Books List";
            // 
            // newTicketBookListTable
            // 
            this.newTicketBookListTable.AutoSizeTable = false;
            this.newTicketBookListTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newTicketBookListTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newTicketBookListTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.newTicketBookListTable.Depth = 0;
            this.newTicketBookListTable.FullRowSelect = true;
            this.newTicketBookListTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.newTicketBookListTable.HideSelection = false;
            this.newTicketBookListTable.Location = new System.Drawing.Point(539, 66);
            this.newTicketBookListTable.MinimumSize = new System.Drawing.Size(200, 100);
            this.newTicketBookListTable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.newTicketBookListTable.MouseState = MaterialSkin.MouseState.OUT;
            this.newTicketBookListTable.Name = "newTicketBookListTable";
            this.newTicketBookListTable.OwnerDraw = true;
            this.newTicketBookListTable.Size = new System.Drawing.Size(277, 173);
            this.newTicketBookListTable.TabIndex = 45;
            this.newTicketBookListTable.UseCompatibleStateImageBehavior = false;
            this.newTicketBookListTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 100;
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
            // addedBookTable
            // 
            this.addedBookTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addedBookTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addedBookTable.Location = new System.Drawing.Point(0, 0);
            this.addedBookTable.Name = "addedBookTable";
            this.addedBookTable.RowTemplate.Height = 25;
            this.addedBookTable.Size = new System.Drawing.Size(816, 285);
            this.addedBookTable.TabIndex = 0;
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.ImageKey = "outline_style_black_24dp.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Borrowing Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(830, 601);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
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
            ((System.ComponentModel.ISupportInitialize)(this.addedBookTable)).EndInit();
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView addedBookTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
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
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView newTicketBookListTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialButton btnClearNewTicket;
    }
}