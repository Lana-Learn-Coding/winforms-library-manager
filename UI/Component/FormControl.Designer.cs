
namespace WinFormsLibraryManager.UI.Component
{
    partial class FormControl
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
            this.lblTextBox = new MaterialSkin.Controls.MaterialLabel();
            this.lblError = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Depth = 0;
            this.textBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBox.Location = new System.Drawing.Point(0, 20);
            this.textBox.Margin = new System.Windows.Forms.Padding(0);
            this.textBox.MaxLength = 50;
            this.textBox.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox.Multiline = false;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(200, 36);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            this.textBox.UseAccent = false;
            this.textBox.UseTallSize = false;
            // 
            // lblTextBox
            // 
            this.lblTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextBox.AutoSize = true;
            this.lblTextBox.Depth = 0;
            this.lblTextBox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTextBox.Location = new System.Drawing.Point(3, 0);
            this.lblTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(35, 19);
            this.lblTextBox.TabIndex = 3;
            this.lblTextBox.Text = "label";
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSize = true;
            this.lblError.Depth = 0;
            this.lblError.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblError.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblError.HighEmphasis = true;
            this.lblError.Location = new System.Drawing.Point(3, 46);
            this.lblError.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblError.MaximumSize = new System.Drawing.Size(0, 12);
            this.lblError.MinimumSize = new System.Drawing.Size(0, 12);
            this.lblError.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(82, 12);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "materialLabel2";
            this.lblError.UseAccent = true;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTextBox);
            this.Controls.Add(this.textBox);
            this.Name = "FormControl";
            this.Size = new System.Drawing.Size(200, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox textBox;
        private MaterialSkin.Controls.MaterialLabel lblTextBox;
        private MaterialSkin.Controls.MaterialLabel lblError;
    }
}
