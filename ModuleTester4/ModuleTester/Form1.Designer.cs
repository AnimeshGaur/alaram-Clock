namespace ModuleTester
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_AddModule = new System.Windows.Forms.Button();
            this.btn_EditModule = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_MoveUp = new System.Windows.Forms.Button();
            this.btn_MoveDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChangeTime = new System.Windows.Forms.Button();
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_PlayModulesInSequence = new System.Windows.Forms.Button();
            this.picBox_ImgTest = new System.Windows.Forms.PictureBox();
            this.addDelayBtn = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveDelay = new System.Windows.Forms.Button();
            this.lbl_ticker = new System.Windows.Forms.Label();
            this.tickerTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ImgTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddModule
            // 
            this.btn_AddModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddModule.Location = new System.Drawing.Point(12, 143);
            this.btn_AddModule.Name = "btn_AddModule";
            this.btn_AddModule.Size = new System.Drawing.Size(229, 104);
            this.btn_AddModule.TabIndex = 0;
            this.btn_AddModule.Text = "Add Module";
            this.btn_AddModule.UseVisualStyleBackColor = true;
            this.btn_AddModule.Click += new System.EventHandler(this.btn_AddModule_Click);
            // 
            // btn_EditModule
            // 
            this.btn_EditModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditModule.Location = new System.Drawing.Point(11, 306);
            this.btn_EditModule.Name = "btn_EditModule";
            this.btn_EditModule.Size = new System.Drawing.Size(229, 38);
            this.btn_EditModule.TabIndex = 1;
            this.btn_EditModule.Text = "Edit Module";
            this.btn_EditModule.UseVisualStyleBackColor = true;
            this.btn_EditModule.Click += new System.EventHandler(this.btn_EditModule_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(253, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 104);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(12, 350);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(147, 124);
            this.listBox2.TabIndex = 3;
            // 
            // btn_MoveUp
            // 
            this.btn_MoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoveUp.Location = new System.Drawing.Point(165, 350);
            this.btn_MoveUp.Name = "btn_MoveUp";
            this.btn_MoveUp.Size = new System.Drawing.Size(75, 61);
            this.btn_MoveUp.TabIndex = 5;
            this.btn_MoveUp.Text = "Move Up";
            this.btn_MoveUp.UseVisualStyleBackColor = true;
            this.btn_MoveUp.Click += new System.EventHandler(this.btn_MoveUp_Click);
            // 
            // btn_MoveDown
            // 
            this.btn_MoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoveDown.Location = new System.Drawing.Point(165, 417);
            this.btn_MoveDown.Name = "btn_MoveDown";
            this.btn_MoveDown.Size = new System.Drawing.Size(75, 59);
            this.btn_MoveDown.TabIndex = 6;
            this.btn_MoveDown.Text = "Move Down";
            this.btn_MoveDown.UseVisualStyleBackColor = true;
            this.btn_MoveDown.Click += new System.EventHandler(this.btn_MoveDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 119);
            this.label1.TabIndex = 7;
            // 
            // btn_ChangeTime
            // 
            this.btn_ChangeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeTime.Location = new System.Drawing.Point(563, 3);
            this.btn_ChangeTime.Name = "btn_ChangeTime";
            this.btn_ChangeTime.Size = new System.Drawing.Size(220, 170);
            this.btn_ChangeTime.TabIndex = 8;
            this.btn_ChangeTime.Text = "Change Time";
            this.btn_ChangeTime.UseVisualStyleBackColor = true;
            this.btn_ChangeTime.Click += new System.EventHandler(this.btn_ChangeTime_Click);
            // 
            // alarmTimer
            // 
            this.alarmTimer.Interval = 1000;
            this.alarmTimer.Tick += new System.EventHandler(this.alarmTimer_Tick);
            // 
            // btn_PlayModulesInSequence
            // 
            this.btn_PlayModulesInSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayModulesInSequence.Location = new System.Drawing.Point(246, 395);
            this.btn_PlayModulesInSequence.Name = "btn_PlayModulesInSequence";
            this.btn_PlayModulesInSequence.Size = new System.Drawing.Size(382, 81);
            this.btn_PlayModulesInSequence.TabIndex = 4;
            this.btn_PlayModulesInSequence.Text = "Play Modules in Sequence";
            this.btn_PlayModulesInSequence.UseVisualStyleBackColor = true;
            this.btn_PlayModulesInSequence.Click += new System.EventHandler(this.btn_PlayModulesInSequence_Click);
            // 
            // picBox_ImgTest
            // 
            this.picBox_ImgTest.Location = new System.Drawing.Point(688, 370);
            this.picBox_ImgTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBox_ImgTest.Name = "picBox_ImgTest";
            this.picBox_ImgTest.Size = new System.Drawing.Size(96, 104);
            this.picBox_ImgTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_ImgTest.TabIndex = 10;
            this.picBox_ImgTest.TabStop = false;
            // 
            // addDelayBtn
            // 
            this.addDelayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDelayBtn.Location = new System.Drawing.Point(476, 213);
            this.addDelayBtn.Name = "addDelayBtn";
            this.addDelayBtn.Size = new System.Drawing.Size(134, 34);
            this.addDelayBtn.TabIndex = 11;
            this.addDelayBtn.Text = "Add Delay";
            this.addDelayBtn.UseVisualStyleBackColor = true;
            this.addDelayBtn.Click += new System.EventHandler(this.addDelayBtn_Click);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(616, 213);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(167, 129);
            this.listBox3.TabIndex = 12;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(476, 287);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Delays";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Amount (Milliseconds)";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Index to Delay After";
            this.label4.Visible = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(476, 329);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown2.TabIndex = 17;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Visible = false;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(11, 258);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(229, 42);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove Module";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveDelay
            // 
            this.btnRemoveDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDelay.Location = new System.Drawing.Point(371, 253);
            this.btnRemoveDelay.Name = "btnRemoveDelay";
            this.btnRemoveDelay.Size = new System.Drawing.Size(225, 28);
            this.btnRemoveDelay.TabIndex = 19;
            this.btnRemoveDelay.Text = "Remove Delay";
            this.btnRemoveDelay.UseVisualStyleBackColor = true;
            this.btnRemoveDelay.Click += new System.EventHandler(this.btnRemoveDelay_Click);
            // 
            // lbl_ticker
            // 
            this.lbl_ticker.BackColor = System.Drawing.Color.Black;
            this.lbl_ticker.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ticker.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_ticker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ticker.Location = new System.Drawing.Point(9, 479);
            this.lbl_ticker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ticker.Name = "lbl_ticker";
            this.lbl_ticker.Size = new System.Drawing.Size(775, 52);
            this.lbl_ticker.TabIndex = 20;
            this.lbl_ticker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tickerTimer
            // 
            this.tickerTimer.Interval = 45;
            this.tickerTimer.Tick += new System.EventHandler(this.tickerTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 540);
            this.Controls.Add(this.lbl_ticker);
            this.Controls.Add(this.btnRemoveDelay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.addDelayBtn);
            this.Controls.Add(this.picBox_ImgTest);
            this.Controls.Add(this.btn_ChangeTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MoveDown);
            this.Controls.Add(this.btn_MoveUp);
            this.Controls.Add(this.btn_PlayModulesInSequence);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_EditModule);
            this.Controls.Add(this.btn_AddModule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Module Test Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ImgTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddModule;
        private System.Windows.Forms.Button btn_EditModule;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_MoveUp;
        private System.Windows.Forms.Button btn_MoveDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChangeTime;
        private System.Windows.Forms.Timer alarmTimer;
        private System.Windows.Forms.Button btn_PlayModulesInSequence;
        private System.Windows.Forms.PictureBox picBox_ImgTest;
        private System.Windows.Forms.Button addDelayBtn;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveDelay;
        private System.Windows.Forms.Label lbl_ticker;
        private System.Windows.Forms.Timer tickerTimer;
    }
}

