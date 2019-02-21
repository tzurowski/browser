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
            this.homeWebsite_textBox = new System.Windows.Forms.TextBox();
            this.homeWebsitelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // default_search_comboBox
            // 
            this.default_search_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.default_search_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.default_search_comboBox.FormattingEnabled = true;
            this.default_search_comboBox.Location = new System.Drawing.Point(182, 25);
            this.default_search_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.default_search_comboBox.Name = "default_search_comboBox";
            this.default_search_comboBox.Size = new System.Drawing.Size(148, 28);
            this.default_search_comboBox.TabIndex = 0;
            // 
            // default_search_label
            // 
            this.default_search_label.AutoSize = true;
            this.default_search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.default_search_label.Location = new System.Drawing.Point(57, 28);
            this.default_search_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.default_search_label.Name = "default_search_label";
            this.default_search_label.Size = new System.Drawing.Size(117, 20);
            this.default_search_label.TabIndex = 1;
            this.default_search_label.Text = "Default search:";
            // 
            // default_folder_label
            // 
            this.default_folder_label.AutoSize = true;
            this.default_folder_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.default_folder_label.Location = new System.Drawing.Point(-3, 99);
            this.default_folder_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.default_folder_label.Name = "default_folder_label";
            this.default_folder_label.Size = new System.Drawing.Size(181, 20);
            this.default_folder_label.TabIndex = 5;
            this.default_folder_label.Text = "Default download folder:";
            // 
            // default_foldertextBoxt
            // 
            this.default_foldertextBoxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.default_foldertextBoxt.Location = new System.Drawing.Point(216, 96);
            this.default_foldertextBoxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.default_foldertextBoxt.Name = "default_foldertextBoxt";
            this.default_foldertextBoxt.Size = new System.Drawing.Size(148, 26);
            this.default_foldertextBoxt.TabIndex = 6;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.save_btn.Location = new System.Drawing.Point(92, 201);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(186, 55);
            this.save_btn.TabIndex = 7;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // homeWebsite_textBox
            // 
            this.homeWebsite_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeWebsite_textBox.Location = new System.Drawing.Point(216, 148);
            this.homeWebsite_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.homeWebsite_textBox.Name = "homeWebsite_textBox";
            this.homeWebsite_textBox.Size = new System.Drawing.Size(148, 26);
            this.homeWebsite_textBox.TabIndex = 9;
            // 
            // homeWebsitelabel
            // 
            this.homeWebsitelabel.AutoSize = true;
            this.homeWebsitelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.homeWebsitelabel.Location = new System.Drawing.Point(-3, 151);
            this.homeWebsitelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.homeWebsitelabel.Name = "homeWebsitelabel";
            this.homeWebsitelabel.Size = new System.Drawing.Size(97, 20);
            this.homeWebsitelabel.TabIndex = 8;
            this.homeWebsitelabel.Text = "Home Page:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 301);
            this.Controls.Add(this.homeWebsite_textBox);
            this.Controls.Add(this.homeWebsitelabel);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.default_foldertextBoxt);
            this.Controls.Add(this.default_folder_label);
            this.Controls.Add(this.default_search_label);
            this.Controls.Add(this.default_search_comboBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox homeWebsite_textBox;
        private System.Windows.Forms.Label homeWebsitelabel;
    }
}