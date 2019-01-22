namespace Browser
{
    partial class BookmarksForm
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
            this.link_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // link_label
            // 
            this.link_label.AutoSize = true;
            this.link_label.Location = new System.Drawing.Point(29, 36);
            this.link_label.Name = "link_label";
            this.link_label.Size = new System.Drawing.Size(114, 17);
            this.link_label.TabIndex = 0;
            this.link_label.Text = "Link do zakadki: ";
            // 
            // BookmarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 439);
            this.Controls.Add(this.link_label);
            this.Name = "BookmarksForm";
            this.Text = "BookmarksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label link_label;
    }
}