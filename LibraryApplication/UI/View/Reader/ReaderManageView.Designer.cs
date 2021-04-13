
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
            this.heading = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new LibraryApplication.UI.Component.TextboxControl();
            this.txtID = new LibraryApplication.UI.Component.NumericControl();
            this.txtLimit = new LibraryApplication.UI.Component.NumericControl();
            this.datePickerControl1 = new LibraryApplication.UI.Component.DatePickerControl();
            this.SuspendLayout();
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
            this.heading.TabIndex = 2;
            this.heading.Text = "Reader Manage";
            // 
            // txtName
            // 
            this.txtName.Error = "";
            this.txtName.Hint = "Reader Name";
            this.txtName.Label = "Name";
            this.txtName.Location = new System.Drawing.Point(125, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 69);
            this.txtName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Error = "";
            this.txtID.Hint = "Reader Id";
            this.txtID.Label = "ID";
            this.txtID.Location = new System.Drawing.Point(0, 44);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(101, 69);
            this.txtID.TabIndex = 4;
            // 
            // txtLimit
            // 
            this.txtLimit.Error = "";
            this.txtLimit.Hint = "Borrow Limit";
            this.txtLimit.Label = "Limit";
            this.txtLimit.Location = new System.Drawing.Point(379, 44);
            this.txtLimit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(118, 69);
            this.txtLimit.TabIndex = 5;
            // 
            // datePickerControl1
            // 
            this.datePickerControl1.Error = "";
            this.datePickerControl1.Hint = "";
            this.datePickerControl1.Label = "label";
            this.datePickerControl1.Location = new System.Drawing.Point(0, 119);
            this.datePickerControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datePickerControl1.Name = "datePickerControl1";
            this.datePickerControl1.Size = new System.Drawing.Size(233, 69);
            this.datePickerControl1.TabIndex = 6;
            this.datePickerControl1.Text = "datePickerControl1";
            // 
            // ReaderManageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datePickerControl1);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.heading);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReaderManageView";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(1050, 808);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel heading;
        private Component.TextboxControl txtName;
        private Component.NumericControl txtID;
        private Component.NumericControl txtLimit;
        private Component.DatePickerControl datePickerControl1;
    }
}
