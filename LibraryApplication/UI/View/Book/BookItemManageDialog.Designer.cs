
namespace LibraryApplication.UI.View.Book
{
    partial class BookItemManageDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookItemManageDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtCondition = new LibraryApplication.UI.Component.TextboxControl();
            this.txtBorrower = new LibraryApplication.UI.Component.TextboxControl();
            this.imgPicker = new LibraryApplication.UI.Component.ImagePickerControl();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.selectPosition = new LibraryApplication.UI.Component.Combobox.PositionComboboxControl();
            this.selectStorage = new LibraryApplication.UI.Component.Combobox.StorageComboboxControl();
            this.heading = new MaterialSkin.Controls.MaterialLabel();
            this.txtMeta = new LibraryApplication.UI.Component.TextboxControl();
            this.txtID = new LibraryApplication.UI.Component.TextboxControl();
            this.table = new LibraryApplication.UI.Component.Table.SearchableDataGridViewControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(18);
            this.panel1.Size = new System.Drawing.Size(910, 685);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(18, 18);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtCondition);
            this.splitContainer1.Panel1.Controls.Add(this.txtBorrower);
            this.splitContainer1.Panel1.Controls.Add(this.imgPicker);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.selectPosition);
            this.splitContainer1.Panel1.Controls.Add(this.selectStorage);
            this.splitContainer1.Panel1.Controls.Add(this.heading);
            this.splitContainer1.Panel1.Controls.Add(this.txtMeta);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.table);
            this.splitContainer1.Size = new System.Drawing.Size(874, 649);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtCondition
            // 
            this.txtCondition.Error = "";
            this.txtCondition.Hint = "Enter condition";
            this.txtCondition.Label = "Condition";
            this.txtCondition.Location = new System.Drawing.Point(0, 194);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(285, 69);
            this.txtCondition.TabIndex = 42;
            this.txtCondition.Value = "";
            // 
            // txtBorrower
            // 
            this.txtBorrower.Enabled = false;
            this.txtBorrower.Error = "";
            this.txtBorrower.Hint = "Current Borrower";
            this.txtBorrower.Label = "Borrower";
            this.txtBorrower.Location = new System.Drawing.Point(307, 194);
            this.txtBorrower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBorrower.Name = "txtBorrower";
            this.txtBorrower.Size = new System.Drawing.Size(225, 69);
            this.txtBorrower.TabIndex = 41;
            this.txtBorrower.Value = "";
            // 
            // imgPicker
            // 
            this.imgPicker.Location = new System.Drawing.Point(564, 44);
            this.imgPicker.Name = "imgPicker";
            this.imgPicker.Padding = new System.Windows.Forms.Padding(1, 1, 1, 10);
            this.imgPicker.Size = new System.Drawing.Size(150, 219);
            this.imgPicker.TabIndex = 40;
            this.imgPicker.Tag = "image";
            this.imgPicker.Value = "none";
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
            this.btnClear.Location = new System.Drawing.Point(745, 92);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 36);
            this.btnClear.TabIndex = 39;
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
            this.btnDelete.Location = new System.Drawing.Point(745, 140);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 36);
            this.btnDelete.TabIndex = 38;
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
            this.btnSave.Location = new System.Drawing.Point(745, 44);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 36);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // selectPosition
            // 
            this.selectPosition.Error = "";
            this.selectPosition.Hint = "Select Position";
            this.selectPosition.Label = "Position";
            this.selectPosition.Location = new System.Drawing.Point(247, 119);
            this.selectPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectPosition.Name = "selectPosition";
            this.selectPosition.Size = new System.Drawing.Size(285, 69);
            this.selectPosition.TabIndex = 4;
            // 
            // selectStorage
            // 
            this.selectStorage.Error = "";
            this.selectStorage.Hint = "Select Storage";
            this.selectStorage.Label = "Storage";
            this.selectStorage.Location = new System.Drawing.Point(0, 119);
            this.selectStorage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectStorage.Name = "selectStorage";
            this.selectStorage.Size = new System.Drawing.Size(225, 69);
            this.selectStorage.TabIndex = 3;
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
            this.heading.Size = new System.Drawing.Size(303, 41);
            this.heading.TabIndex = 2;
            this.heading.Text = "Book Items Manage";
            // 
            // txtMeta
            // 
            this.txtMeta.Enabled = false;
            this.txtMeta.Error = "";
            this.txtMeta.Hint = "Parent book meta";
            this.txtMeta.Label = "Meta";
            this.txtMeta.Location = new System.Drawing.Point(163, 44);
            this.txtMeta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMeta.Name = "txtMeta";
            this.txtMeta.Size = new System.Drawing.Size(369, 69);
            this.txtMeta.TabIndex = 1;
            this.txtMeta.Value = "";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Error = "";
            this.txtID.Hint = "BookID";
            this.txtID.Label = "ID";
            this.txtID.Location = new System.Drawing.Point(0, 44);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(139, 69);
            this.txtID.TabIndex = 0;
            this.txtID.Value = "";
            // 
            // table
            // 
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(874, 325);
            this.table.TabIndex = 0;
            // 
            // BookItemManageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 710);
            this.Controls.Add(this.panel1);
            this.Name = "BookItemManageDialog";
            this.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Component.TextboxControl txtMeta;
        private Component.TextboxControl txtID;
        private MaterialSkin.Controls.MaterialLabel heading;
        private Component.Combobox.PositionComboboxControl selectPosition;
        private Component.Combobox.StorageComboboxControl selectStorage;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private Component.ImagePickerControl imgPicker;
        private Component.TextboxControl txtCondition;
        private Component.TextboxControl txtBorrower;
        private Component.Table.SearchableDataGridViewControl table;
    }
}