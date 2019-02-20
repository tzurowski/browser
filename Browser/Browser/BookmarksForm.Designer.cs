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
            this.url_label = new System.Windows.Forms.Label();
            this.url_txtb = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.name_txtb = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // url_label
            // 
            this.url_label.AutoSize = true;
            this.url_label.Location = new System.Drawing.Point(30, 70);
            this.url_label.Name = "url_label";
            this.url_label.Size = new System.Drawing.Size(36, 17);
            this.url_label.TabIndex = 5;
            this.url_label.Text = "URL";
            // 
            // url_txtb
            // 
            this.url_txtb.Location = new System.Drawing.Point(92, 67);
            this.url_txtb.Name = "url_txtb";
            this.url_txtb.Size = new System.Drawing.Size(333, 22);
            this.url_txtb.TabIndex = 1;
            this.url_txtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.url_txtb_KeyDown);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(30, 37);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(45, 17);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "Name";
            // 
            // name_txtb
            // 
            this.name_txtb.Location = new System.Drawing.Point(92, 34);
            this.name_txtb.Name = "name_txtb";
            this.name_txtb.Size = new System.Drawing.Size(166, 22);
            this.name_txtb.TabIndex = 0;
            this.name_txtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_txtb_KeyDown);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(92, 129);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(140, 44);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(285, 129);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(140, 44);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // BookmarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 223);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.name_txtb);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.url_txtb);
            this.Controls.Add(this.url_label);
            this.Name = "BookmarksForm";
            this.Text = "BookmarksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label url_label;
        private System.Windows.Forms.TextBox url_txtb;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_txtb;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}