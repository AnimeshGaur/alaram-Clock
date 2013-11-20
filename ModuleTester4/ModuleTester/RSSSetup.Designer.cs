namespace ModuleTester
{
    partial class RSSSetup
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
            this.Title = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(41, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(225, 20);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(41, 68);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(225, 20);
            this.URL.TabIndex = 2;
            this.URL.Text = "URI";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RSSSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.Title);
            this.Name = "RSSSetup";
            this.Text = "RSSSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button button1;
    }
}