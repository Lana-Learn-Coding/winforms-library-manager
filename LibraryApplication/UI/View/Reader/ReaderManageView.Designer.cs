
namespace LibraryApplication.UI.View.Reader
{
    partial class ReaderManageView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderManageView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBorrow = new MaterialSkin.Controls.MaterialButton();
            this.txtLimit = new LibraryApplication.UI.Component.TextboxControl();
            this.imgPicker = new LibraryApplication.UI.Component.ImagePickerControl();
            this.dateBirthdate = new LibraryApplication.UI.Component.DatePickerControl();
            this.selectGender = new LibraryApplication.UI.Component.Combobox.GenderCombobox();
            this.txtAddress = new LibraryApplication.UI.Component.TextboxControl();
            this.txtPhone = new LibraryApplication.UI.Component.TextboxControl();
            this.txtEmail = new LibraryApplication.UI.Component.TextboxControl();
            this.txtName = new LibraryApplication.UI.Component.TextboxControl();
            this.txtID = new LibraryApplication.UI.Component.TextboxControl();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.heading = new MaterialSkin.Controls.MaterialLabel();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnBorrow);
            this.splitContainer1.Panel1.Controls.Add(this.txtLimit);
            this.splitContainer1.Panel1.Controls.Add(this.imgPicker);
            this.splitContainer1.Panel1.Controls.Add(this.dateBirthdate);
            this.splitContainer1.Panel1.Controls.Add(this.selectGender);
            this.splitContainer1.Panel1.Controls.Add(this.txtAddress);
            this.splitContainer1.Panel1.Controls.Add(this.txtPhone);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.heading);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.table);
            this.splitContainer1.Size = new System.Drawing.Size(876, 776);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 41;
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
            this.btnBorrow.Location = new System.Drawing.Point(747, 231);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBorrow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBorrow.Size = new System.Drawing.Size(129, 36);
            this.btnBorrow.TabIndex = 51;
            this.btnBorrow.Text = "Borrowing";
            this.btnBorrow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBorrow.UseAccentColor = false;
            this.btnBorrow.UseVisualStyleBackColor = true;
            // 
            // txtLimit
            // 
            this.txtLimit.Error = "";
            this.txtLimit.Hint = "Borrow Limit";
            this.txtLimit.Label = "Limit";
            this.txtLimit.Location = new System.Drawing.Point(394, 58);
            this.txtLimit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(138, 72);
            this.txtLimit.TabIndex = 49;
            this.txtLimit.Value = "";
            // 
            // imgPicker
            // 
            this.imgPicker.Location = new System.Drawing.Point(572, 58);
            this.imgPicker.Name = "imgPicker";
            this.imgPicker.Padding = new System.Windows.Forms.Padding(1, 1, 1, 10);
            this.imgPicker.Size = new System.Drawing.Size(150, 219);
            this.imgPicker.TabIndex = 48;
            this.imgPicker.Tag = "image";
            this.imgPicker.Value = "none";
            // 
            // dateBirthdate
            // 
            this.dateBirthdate.Error = "";
            this.dateBirthdate.Hint = "Reader Birthdate";
            this.dateBirthdate.Label = "Birthdate";
            this.dateBirthdate.Location = new System.Drawing.Point(350, 214);
            this.dateBirthdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateBirthdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateBirthdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateBirthdate.Name = "dateBirthdate";
            this.dateBirthdate.Size = new System.Drawing.Size(182, 72);
            this.dateBirthdate.TabIndex = 47;
            this.dateBirthdate.Value = new System.DateTime(2021, 4, 15, 22, 19, 21, 549);
            // 
            // selectGender
            // 
            this.selectGender.Error = "";
            this.selectGender.Hint = "Select Gender";
            this.selectGender.Label = "Gender";
            this.selectGender.Location = new System.Drawing.Point(394, 136);
            this.selectGender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectGender.Name = "selectGender";
            this.selectGender.Size = new System.Drawing.Size(138, 72);
            this.selectGender.TabIndex = 46;
            // 
            // txtAddress
            // 
            this.txtAddress.Error = "";
            this.txtAddress.Hint = "Reader Address";
            this.txtAddress.Label = "Address";
            this.txtAddress.Location = new System.Drawing.Point(0, 214);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(332, 72);
            this.txtAddress.TabIndex = 45;
            this.txtAddress.Value = "";
            // 
            // txtPhone
            // 
            this.txtPhone.Error = "";
            this.txtPhone.Hint = "Reader Phone";
            this.txtPhone.Label = "Phone Number";
            this.txtPhone.Location = new System.Drawing.Point(205, 136);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(171, 72);
            this.txtPhone.TabIndex = 43;
            this.txtPhone.Value = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Error = "";
            this.txtEmail.Hint = "Reader Email";
            this.txtEmail.Label = "Email";
            this.txtEmail.Location = new System.Drawing.Point(0, 136);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 72);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.Value = "";
            // 
            // txtName
            // 
            this.txtName.Error = "";
            this.txtName.Hint = "Reader Name";
            this.txtName.Label = "Name";
            this.txtName.Location = new System.Drawing.Point(129, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 72);
            this.txtName.TabIndex = 41;
            this.txtName.Value = "";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Error = "";
            this.txtID.Hint = "Reader ID";
            this.txtID.Label = "ID";
            this.txtID.Location = new System.Drawing.Point(0, 58);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(110, 72);
            this.txtID.TabIndex = 40;
            this.txtID.Value = "";
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
            this.btnClear.Location = new System.Drawing.Point(747, 106);
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
            this.btnDelete.Location = new System.Drawing.Point(747, 154);
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
            this.btnSave.Location = new System.Drawing.Point(747, 58);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 36);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
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
            this.heading.Size = new System.Drawing.Size(240, 41);
            this.heading.TabIndex = 3;
            this.heading.Text = "Reader Manage";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 25;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(876, 422);
            this.table.TabIndex = 0;
            // 
            // ReaderManageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReaderManageView";
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
        private MaterialSkin.Controls.MaterialLabel heading;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView table;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private Component.TextboxControl txtID;
        private Component.TextboxControl txtName;
        private Component.TextboxControl textboxControl3;
        private Component.TextboxControl txtPhone;
        private Component.TextboxControl txtEmail;
        private Component.Combobox.GenderCombobox genderCombobox1;
        private Component.DatePickerControl dateBirthdate;
        private Component.Combobox.GenderCombobox selectGender;
        private Component.TextboxControl txtAddress;
        private Component.ImagePickerControl imgPicker;
        private Component.TextboxControl txtLimit;
        private MaterialSkin.Controls.MaterialButton btnBorrow;
    }
}
