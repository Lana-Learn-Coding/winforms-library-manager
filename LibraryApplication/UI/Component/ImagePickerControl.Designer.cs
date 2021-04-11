
namespace LibraryApplication.UI.Component
{
    partial class ImagePickerControl
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
            this.btnSelectImage = new MaterialSkin.Controls.MaterialButton();
            this.imgBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectImage.Depth = 0;
            this.btnSelectImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSelectImage.DrawShadows = true;
            this.btnSelectImage.HighEmphasis = true;
            this.btnSelectImage.Icon = null;
            this.btnSelectImage.Location = new System.Drawing.Point(1, 204);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(138, 36);
            this.btnSelectImage.TabIndex = 1;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectImage.UseAccentColor = false;
            this.btnSelectImage.UseVisualStyleBackColor = true;
            // 
            // imgBox
            // 
            this.imgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox.Location = new System.Drawing.Point(1, 1);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(138, 194);
            this.imgBox.TabIndex = 0;
            this.imgBox.TabStop = false;
            this.imgBox.Click += new System.EventHandler(this.imgBox_Click);
            // 
            // ImagePickerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.imgBox);
            this.Name = "ImagePickerControl";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 1, 10);
            this.Size = new System.Drawing.Size(140, 250);
            this.Tag = "image";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnSelectImage;
        private System.Windows.Forms.PictureBox imgBox;
    }
}
