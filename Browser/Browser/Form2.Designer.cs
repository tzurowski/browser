namespace Browser
{
    partial class Form2
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
            this.default_search_comboBox = new System.Windows.Forms.ComboBox();
            this.default_search_label = new System.Windows.Forms.Label();
            this.default_folder_label = new System.Windows.Forms.Label();
            this.default_foldertextBoxt = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // default_search_comboBox
            // 
            this.default_search_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.default_search_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.default_search_comboBox.FormattingEnabled = true;
            this.default_search_comboBox.Location = new System.Drawing.Point(243, 31);
            this.default_search_comboBox.Name = "default_search_comboBox";
            this.default_search_comboBox.Size = new System.Drawing.Size(196, 33);
            this.default_search_comboBox.TabIndex = 0;
            // 
            // default_search_label
            // 
            this.default_search_label.AutoSize = true;
            this.default_search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.default_search_label.Location = new System.Drawing.Point(76, 34);
            this.default_search_label.Name = "default_search_label";
            this.default_search_label.Size = new System.Drawing.Size(143, 25);
            this.default_search_label.TabIndex = 1;
            this.default_search_label.Text = "Default search:";
            // 
            // default_folder_label
            // 
            this.default_folder_label.AutoSize = true;
            this.default_folder_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.default_folder_label.Location = new System.Drawing.Point(12, 174);
            this.default_folder_label.Name = "default_folder_label";
            this.default_folder_label.Size = new System.Drawing.Size(215, 25);
            this.default_folder_label.TabIndex = 5;
            this.default_folder_label.Text = "Default download folder";
            // 
            // default_foldertextBoxt
            // 
            this.default_foldertextBoxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.default_foldertextBoxt.Location = new System.Drawing.Point(233, 171);
            this.default_foldertextBoxt.Name = "default_foldertextBoxt";
            this.default_foldertextBoxt.Size = new System.Drawing.Size(196, 30);
            this.default_foldertextBoxt.TabIndex = 6;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.save_btn.Location = new System.Drawing.Point(123, 247);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(248, 68);
            this.save_btn.TabIndex = 7;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 371);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.default_foldertextBoxt);
            this.Controls.Add(this.default_folder_label);
            this.Controls.Add(this.default_search_label);
            this.Controls.Add(this.default_search_comboBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox default_search_comboBox;
        private System.Windows.Forms.Label default_search_label;
        private System.Windows.Forms.Label default_folder_label;
        private System.Windows.Forms.TextBox default_foldertextBoxt;
        private System.Windows.Forms.Button save_btn;
    }
}