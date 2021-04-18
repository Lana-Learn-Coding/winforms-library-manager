
namespace LibraryApplication.UI.Component.Table
{
    partial class TicketListControl
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
            this.lbl = new MaterialSkin.Controls.MaterialLabel();
            this.table = new MaterialSkin.Controls.MaterialListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.ColTitle = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Depth = 0;
            this.lbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Margin = new System.Windows.Forms.Padding(3, 0, 33, 10);
            this.lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(67, 19);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Ticket List";
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.AutoSizeTable = false;
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.Depth = 0;
            this.table.FullRowSelect = true;
            this.table.HideSelection = false;
            this.table.Location = new System.Drawing.Point(0, 23);
            this.table.MinimumSize = new System.Drawing.Size(200, 100);
            this.table.MouseLocation = new System.Drawing.Point(-1, -1);
            this.table.MouseState = MaterialSkin.MouseState.OUT;
            this.table.Name = "table";
            this.table.OwnerDraw = true;
            this.table.Size = new System.Drawing.Size(298, 177);
            this.table.TabIndex = 1;
            this.table.UseCompatibleStateImageBehavior = false;
            this.table.View = System.Windows.Forms.View.Details;
            // 
            // BookListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Controls.Add(this.lbl);
            this.MaximumSize = new System.Drawing.Size(320, 500);
            this.Name = "BookListControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Size = new System.Drawing.Size(300, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl;
        private MaterialSkin.Controls.MaterialListView table;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader ColTitle;
    }
}
