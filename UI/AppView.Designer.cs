
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
            this.routedControlHost = new ReactiveUI.Winforms.RoutedControlHost();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnReaderManage = new System.Windows.Forms.Button();
            this.btnTicketManage = new System.Windows.Forms.Button();
            this.btnUserManage = new System.Windows.Forms.Button();
            this.btnBookManage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // routedControlHost
            // 
            this.routedControlHost.DefaultContent = null;
            this.routedControlHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routedControlHost.Location = new System.Drawing.Point(0, 0);
            this.routedControlHost.Name = "routedControlHost";
            this.routedControlHost.Router = null;
            this.routedControlHost.Size = new System.Drawing.Size(150, 781);
            this.routedControlHost.TabIndex = 0;
            this.routedControlHost.ViewLocator = null;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnReaderManage);
            this.splitContainer1.Panel1.Controls.Add(this.btnTicketManage);
            this.splitContainer1.Panel1.Controls.Add(this.btnUserManage);
            this.splitContainer1.Panel1.Controls.Add(this.btnBookManage);
            this.splitContainer1.Panel1.Controls.Add(this.routedControlHost);
            this.splitContainer1.Size = new System.Drawing.Size(954, 781);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnReaderManage
            // 
            this.btnReaderManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReaderManage.Location = new System.Drawing.Point(3, 71);
            this.btnReaderManage.Name = "btnReaderManage";
            this.btnReaderManage.Size = new System.Drawing.Size(147, 36);
            this.btnReaderManage.TabIndex = 4;
            this.btnReaderManage.Text = "Reader Manage";
            this.btnReaderManage.UseVisualStyleBackColor = true;
            // 
            // btnTicketManage
            // 
            this.btnTicketManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTicketManage.Location = new System.Drawing.Point(3, 131);
            this.btnTicketManage.Name = "btnTicketManage";
            this.btnTicketManage.Size = new System.Drawing.Size(147, 36);
            this.btnTicketManage.TabIndex = 3;
            this.btnTicketManage.Text = "Ticket Manage";
            this.btnTicketManage.UseVisualStyleBackColor = true;
            // 
            // btnUserManage
            // 
            this.btnUserManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserManage.Location = new System.Drawing.Point(3, 195);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Size = new System.Drawing.Size(147, 36);
            this.btnUserManage.TabIndex = 2;
            this.btnUserManage.Text = "User Manage";
            this.btnUserManage.UseVisualStyleBackColor = true;
            // 
            // btnBookManage
            // 
            this.btnBookManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookManage.Location = new System.Drawing.Point(3, 12);
            this.btnBookManage.Name = "btnBookManage";
            this.btnBookManage.Size = new System.Drawing.Size(147, 36);
            this.btnBookManage.TabIndex = 1;
            this.btnBookManage.Text = "Book Manage";
            this.btnBookManage.UseVisualStyleBackColor = true;
            // 
            // AppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 781);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AppView";
            this.Text = "LibMan - Library Manage Application";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReactiveUI.Winforms.RoutedControlHost routedControlHost;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnReaderManage;
        private System.Windows.Forms.Button btnTicketManage;
        private System.Windows.Forms.Button btnUserManage;
        private System.Windows.Forms.Button btnBookManage;
    }
}