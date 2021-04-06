
namespace WinFormsLibraryManager.UI
{
    partial class AppView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppView));
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabBookManage = new System.Windows.Forms.TabPage();
            this.bookManageView = new WinFormsLibraryManager.UI.View.Book.BookManageView();
            this.tabBookItemManage = new System.Windows.Forms.TabPage();
            this.bookItemManageView = new WinFormsLibraryManager.UI.View.Book.BookItemManageView();
            this.tabReaderManage = new System.Windows.Forms.TabPage();
            this.readerManageView = new WinFormsLibraryManager.UI.View.Reader.ReaderManageView();
            this.tabTicketManage = new System.Windows.Forms.TabPage();
            this.ticketManageView = new WinFormsLibraryManager.UI.View.Reader.TicketManageView();
            this.tabUserManage = new System.Windows.Forms.TabPage();
            this.userManageView = new WinFormsLibraryManager.UI.View.User.UserManageView();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.drawerIconList = new System.Windows.Forms.ImageList(this.components);
            this.mainTabControl.SuspendLayout();
            this.tabBookManage.SuspendLayout();
            this.tabBookItemManage.SuspendLayout();
            this.tabReaderManage.SuspendLayout();
            this.tabTicketManage.SuspendLayout();
            this.tabUserManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabBookManage);
            this.mainTabControl.Controls.Add(this.tabBookItemManage);
            this.mainTabControl.Controls.Add(this.tabReaderManage);
            this.mainTabControl.Controls.Add(this.tabTicketManage);
            this.mainTabControl.Controls.Add(this.tabUserManage);
            this.mainTabControl.Controls.Add(this.tabSetting);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ImageList = this.drawerIconList;
            this.mainTabControl.Location = new System.Drawing.Point(60, 64);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(914, 733);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabBookManage
            // 
            this.tabBookManage.Controls.Add(this.bookManageView);
            this.tabBookManage.ImageKey = "baseline_auto_stories_black_24dp.png";
            this.tabBookManage.Location = new System.Drawing.Point(4, 23);
            this.tabBookManage.Name = "tabBookManage";
            this.tabBookManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookManage.Size = new System.Drawing.Size(906, 706);
            this.tabBookManage.TabIndex = 0;
            this.tabBookManage.Text = "Book Manage";
            this.tabBookManage.UseVisualStyleBackColor = true;
            // 
            // bookManageView
            // 
            this.bookManageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookManageView.Location = new System.Drawing.Point(3, 3);
            this.bookManageView.Margin = new System.Windows.Forms.Padding(0);
            this.bookManageView.Name = "bookManageView";
            this.bookManageView.Size = new System.Drawing.Size(900, 700);
            this.bookManageView.TabIndex = 0;
            this.bookManageView.ViewModel = null;
            // 
            // tabBookItemManage
            // 
            this.tabBookItemManage.Controls.Add(this.bookItemManageView);
            this.tabBookItemManage.ImageKey = "outline_library_books_black_24dp.png";
            this.tabBookItemManage.Location = new System.Drawing.Point(4, 23);
            this.tabBookItemManage.Name = "tabBookItemManage";
            this.tabBookItemManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookItemManage.Size = new System.Drawing.Size(886, 705);
            this.tabBookItemManage.TabIndex = 5;
            this.tabBookItemManage.Text = "Book Items";
            this.tabBookItemManage.UseVisualStyleBackColor = true;
            // 
            // bookItemManageView
            // 
            this.bookItemManageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookItemManageView.Location = new System.Drawing.Point(3, 3);
            this.bookItemManageView.Name = "bookItemManageView";
            this.bookItemManageView.Size = new System.Drawing.Size(880, 699);
            this.bookItemManageView.TabIndex = 0;
            this.bookItemManageView.ViewModel = null;
            // 
            // tabReaderManage
            // 
            this.tabReaderManage.Controls.Add(this.readerManageView);
            this.tabReaderManage.ImageKey = "baseline_person_black_24dp.png";
            this.tabReaderManage.Location = new System.Drawing.Point(4, 23);
            this.tabReaderManage.Name = "tabReaderManage";
            this.tabReaderManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabReaderManage.Size = new System.Drawing.Size(906, 806);
            this.tabReaderManage.TabIndex = 1;
            this.tabReaderManage.Text = "Reader Manage";
            this.tabReaderManage.UseVisualStyleBackColor = true;
            // 
            // readerManageView
            // 
            this.readerManageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readerManageView.Location = new System.Drawing.Point(3, 3);
            this.readerManageView.Name = "readerManageView";
            this.readerManageView.Size = new System.Drawing.Size(900, 800);
            this.readerManageView.TabIndex = 1;
            this.readerManageView.ViewModel = null;
            // 
            // tabTicketManage
            // 
            this.tabTicketManage.Controls.Add(this.ticketManageView);
            this.tabTicketManage.ImageKey = "outline_event_note_black_24dp.png";
            this.tabTicketManage.Location = new System.Drawing.Point(4, 23);
            this.tabTicketManage.Name = "tabTicketManage";
            this.tabTicketManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTicketManage.Size = new System.Drawing.Size(886, 705);
            this.tabTicketManage.TabIndex = 2;
            this.tabTicketManage.Text = "Ticket Manage";
            this.tabTicketManage.UseVisualStyleBackColor = true;
            // 
            // ticketManageView
            // 
            this.ticketManageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketManageView.Location = new System.Drawing.Point(3, 3);
            this.ticketManageView.Name = "ticketManageView";
            this.ticketManageView.Size = new System.Drawing.Size(880, 699);
            this.ticketManageView.TabIndex = 2;
            this.ticketManageView.ViewModel = null;
            // 
            // tabUserManage
            // 
            this.tabUserManage.Controls.Add(this.userManageView);
            this.tabUserManage.ImageKey = "baseline_account_circle_black_24dp.png";
            this.tabUserManage.Location = new System.Drawing.Point(4, 23);
            this.tabUserManage.Name = "tabUserManage";
            this.tabUserManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserManage.Size = new System.Drawing.Size(886, 705);
            this.tabUserManage.TabIndex = 3;
            this.tabUserManage.Text = "User  Manage";
            this.tabUserManage.UseVisualStyleBackColor = true;
            // 
            // userManageView
            // 
            this.userManageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userManageView.Location = new System.Drawing.Point(3, 3);
            this.userManageView.Name = "userManageView";
            this.userManageView.Size = new System.Drawing.Size(880, 699);
            this.userManageView.TabIndex = 3;
            this.userManageView.ViewModel = null;
            // 
            // tabSetting
            // 
            this.tabSetting.ImageKey = "baseline_settings_black_24dp.png";
            this.tabSetting.Location = new System.Drawing.Point(4, 23);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetting.Size = new System.Drawing.Size(886, 705);
            this.tabSetting.TabIndex = 4;
            this.tabSetting.Text = "Setting";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // drawerIconList
            // 
            this.drawerIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("drawerIconList.ImageStream")));
            this.drawerIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.drawerIconList.Images.SetKeyName(0, "baseline_account_circle_black_24dp.png");
            this.drawerIconList.Images.SetKeyName(1, "baseline_auto_stories_black_24dp.png");
            this.drawerIconList.Images.SetKeyName(2, "baseline_history_black_24dp.png");
            this.drawerIconList.Images.SetKeyName(3, "baseline_person_black_24dp.png");
            this.drawerIconList.Images.SetKeyName(4, "baseline_search_black_24dp.png");
            this.drawerIconList.Images.SetKeyName(5, "baseline_settings_black_24dp.png");
            this.drawerIconList.Images.SetKeyName(6, "outline_event_note_black_24dp.png");
            this.drawerIconList.Images.SetKeyName(7, "outline_library_books_black_24dp.png");
            // 
            // AppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 800);
            this.Controls.Add(this.mainTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mainTabControl;
            this.Name = "AppView";
            this.Padding = new System.Windows.Forms.Padding(60, 64, 3, 3);
            this.Text = "LibMan - Library Manage Application";
            this.mainTabControl.ResumeLayout(false);
            this.tabBookManage.ResumeLayout(false);
            this.tabBookItemManage.ResumeLayout(false);
            this.tabReaderManage.ResumeLayout(false);
            this.tabTicketManage.ResumeLayout(false);
            this.tabUserManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage tabBookManage;
        private System.Windows.Forms.TabPage tabReaderManage;
        private System.Windows.Forms.TabPage tabTicketManage;
        private System.Windows.Forms.TabPage tabUserManage;
        private View.Book.BookManageView bookManageView;
        private View.Book.BookItemManageView bookItemManageView;
        private View.Reader.ReaderManageView readerManageView;
        private View.Reader.TicketManageView ticketManageView;
        private View.User.UserManageView userManageView;
        private System.Windows.Forms.ImageList drawerIconList;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.TabPage tabBookItemManage;
    }
}