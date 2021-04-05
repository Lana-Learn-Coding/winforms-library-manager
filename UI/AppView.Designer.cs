
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
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabUserManage = new System.Windows.Forms.TabPage();
            this.tabBookManage = new System.Windows.Forms.TabPage();
            this.bookManageView = new WinFormsLibraryManager.UI.View.BookManage.BookManageView();
            this.tabReaderManage = new System.Windows.Forms.TabPage();
            this.tabTicketManage = new System.Windows.Forms.TabPage();
            this.readerManageView = new WinFormsLibraryManager.UI.View.ReaderManage.ReaderManageView();
            this.ticketManageView = new WinFormsLibraryManager.UI.View.ReaderManage.TicketManageView();
            this.userManageView = new WinFormsLibraryManager.UI.View.UserManage.UserManageView();
            this.mainTabControl.SuspendLayout();
            this.tabUserManage.SuspendLayout();
            this.tabBookManage.SuspendLayout();
            this.tabReaderManage.SuspendLayout();
            this.tabTicketManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabBookManage);
            this.mainTabControl.Controls.Add(this.tabReaderManage);
            this.mainTabControl.Controls.Add(this.tabTicketManage);
            this.mainTabControl.Controls.Add(this.tabUserManage);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(900, 700);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabUserManage
            // 
            this.tabUserManage.Controls.Add(this.userManageView);
            this.tabUserManage.Location = new System.Drawing.Point(4, 22);
            this.tabUserManage.Name = "tabUserManage";
            this.tabUserManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserManage.Size = new System.Drawing.Size(892, 674);
            this.tabUserManage.TabIndex = 3;
            this.tabUserManage.Text = "User  Manage";
            this.tabUserManage.UseVisualStyleBackColor = true;
            // 
            // tabBookManage
            // 
            this.tabBookManage.Controls.Add(this.bookManageView);
            this.tabBookManage.Location = new System.Drawing.Point(4, 22);
            this.tabBookManage.Name = "tabBookManage";
            this.tabBookManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookManage.Size = new System.Drawing.Size(892, 674);
            this.tabBookManage.TabIndex = 0;
            this.tabBookManage.Text = "Book Manage";
            this.tabBookManage.UseVisualStyleBackColor = true;
            // 
            // bookManageView
            // 
            this.bookManageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookManageView.Location = new System.Drawing.Point(3, 3);
            this.bookManageView.Name = "bookManageView";
            this.bookManageView.Size = new System.Drawing.Size(886, 668);
            this.bookManageView.TabIndex = 0;
            this.bookManageView.ViewModel = null;
            // 
            // tabReaderManage
            // 
            this.tabReaderManage.Controls.Add(this.readerManageView);
            this.tabReaderManage.Location = new System.Drawing.Point(4, 22);
            this.tabReaderManage.Name = "tabReaderManage";
            this.tabReaderManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabReaderManage.Size = new System.Drawing.Size(892, 674);
            this.tabReaderManage.TabIndex = 1;
            this.tabReaderManage.Text = "Reader Manage";
            this.tabReaderManage.UseVisualStyleBackColor = true;
            // 
            // tabTicketManage
            // 
            this.tabTicketManage.Controls.Add(this.ticketManageView);
            this.tabTicketManage.Location = new System.Drawing.Point(4, 22);
            this.tabTicketManage.Name = "tabTicketManage";
            this.tabTicketManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTicketManage.Size = new System.Drawing.Size(892, 674);
            this.tabTicketManage.TabIndex = 2;
            this.tabTicketManage.Text = "Ticket Manage";
            this.tabTicketManage.UseVisualStyleBackColor = true;
            // 
            // readerManageView
            // 
            this.readerManageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readerManageView.Location = new System.Drawing.Point(3, 3);
            this.readerManageView.Name = "readerManageView";
            this.readerManageView.Size = new System.Drawing.Size(886, 668);
            this.readerManageView.TabIndex = 1;
            this.readerManageView.ViewModel = null;
            // 
            // ticketManageView
            // 
            this.ticketManageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketManageView.Location = new System.Drawing.Point(3, 3);
            this.ticketManageView.Name = "ticketManageView";
            this.ticketManageView.Size = new System.Drawing.Size(886, 668);
            this.ticketManageView.TabIndex = 2;
            this.ticketManageView.ViewModel = null;
            // 
            // userManageView
            // 
            this.userManageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userManageView.Location = new System.Drawing.Point(3, 3);
            this.userManageView.Name = "userManageView";
            this.userManageView.Size = new System.Drawing.Size(886, 668);
            this.userManageView.TabIndex = 3;
            this.userManageView.ViewModel = null;
            // 
            // AppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.mainTabControl);
            this.DrawerTabControl = this.mainTabControl;
            this.Name = "AppView";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "LibMan - Library Manage Application";
            this.mainTabControl.ResumeLayout(false);
            this.tabUserManage.ResumeLayout(false);
            this.tabBookManage.ResumeLayout(false);
            this.tabReaderManage.ResumeLayout(false);
            this.tabTicketManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage tabBookManage;
        private System.Windows.Forms.TabPage tabReaderManage;
        private System.Windows.Forms.TabPage tabTicketManage;
        private System.Windows.Forms.TabPage tabUserManage;
        private View.BookManage.BookManageView bookManageView;
        private View.ReaderManage.TicketManageView ticketManageView;
        private View.ReaderManage.ReaderManageView readerManageView;
        private View.UserManage.UserManageView userManageView;
    }
}