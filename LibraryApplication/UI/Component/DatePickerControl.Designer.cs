
namespace LibraryApplication.UI.Component
{
    partial class DatePickerControl
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
            this.textBox = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl = new MaterialSkin.Controls.MaterialLabel();
            this.lblError = new MaterialSkin.Controls.MaterialLabel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Depth = 0;
            this.textBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(0, 23);
            this.textBox.Margin = new System.Windows.Forms.Padding(0);
            this.textBox.MaxLength = 50;
            this.textBox.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox.Multiline = false;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(233, 36);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            this.textBox.UseAccent = false;
            this.textBox.UseTallSize = false;
            this.textBox.Click += new System.EventHandler(this.textBox_Click);
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.AutoSize = true;
            this.lbl.Depth = 0;
            this.lbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl.Location = new System.Drawing.Point(4, 0);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 19);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "label";
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSize = true;
            this.lblError.Depth = 0;
            this.lblError.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblError.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblError.HighEmphasis = true;
            this.lblError.Location = new System.Drawing.Point(4, 58);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblError.MaximumSize = new System.Drawing.Size(0, 14);
            this.lblError.MinimumSize = new System.Drawing.Size(0, 14);
            this.lblError.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(1, 0);
            this.lblError.TabIndex = 2;
            this.lblError.UseAccent = true;
            // 
            // datePicker
            // 
            this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(0, 30);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(233, 23);
            this.datePicker.TabIndex = 4;
            // 
            // DatePickerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblError);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DatePickerControl";
            this.Size = new System.Drawing.Size(233, 72);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox textBox;
        private MaterialSkin.Controls.MaterialLabel lbl;
        private MaterialSkin.Controls.MaterialLabel lblError;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}
