
namespace LibraryApplication.UI.Component
{
    partial class ComboboxControl
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
            this.lblError = new MaterialSkin.Controls.MaterialLabel();
            this.lbl = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Depth = 0;
            this.lblError.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblError.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblError.HighEmphasis = true;
            this.lblError.Location = new System.Drawing.Point(0, 53);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.MaximumSize = new System.Drawing.Size(0, 14);
            this.lblError.MinimumSize = new System.Drawing.Size(0, 14);
            this.lblError.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(1, 0);
            this.lblError.TabIndex = 1;
            this.lblError.UseAccent = true;
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
            this.lbl.MaximumSize = new System.Drawing.Size(0, 20);
            this.lbl.MinimumSize = new System.Drawing.Size(0, 20);
            this.lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 19);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "label";
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.AutoResize = false;
            this.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox.Depth = 0;
            this.comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox.DropDownHeight = 118;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.DropDownWidth = 121;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.IntegralHeight = false;
            this.comboBox.ItemHeight = 29;
            this.comboBox.Location = new System.Drawing.Point(0, 23);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox.MaxDropDownItems = 4;
            this.comboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(233, 35);
            this.comboBox.StartIndex = 0;
            this.comboBox.TabIndex = 3;
            this.comboBox.UseTallSize = false;
            // 
            // ComboboxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.lblError);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ComboboxControl";
            this.Size = new System.Drawing.Size(233, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblError;
        private MaterialSkin.Controls.MaterialLabel lbl;
        private MaterialSkin.Controls.MaterialComboBox comboBox;
    }
}
