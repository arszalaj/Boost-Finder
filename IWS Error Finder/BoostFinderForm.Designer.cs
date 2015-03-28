namespace BoostFinder
{
    partial class BoostFinderForm
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
            this.loadUrlButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.key1TextBox = new System.Windows.Forms.TextBox();
            this.chooseSoundButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.soundTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.key4TextBox = new System.Windows.Forms.TextBox();
            this.key3TextBox = new System.Windows.Forms.TextBox();
            this.key2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loadUrlButton
            // 
            this.loadUrlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadUrlButton.Location = new System.Drawing.Point(353, 24);
            this.loadUrlButton.Name = "loadUrlButton";
            this.loadUrlButton.Size = new System.Drawing.Size(75, 23);
            this.loadUrlButton.TabIndex = 2;
            this.loadUrlButton.Text = "Load";
            this.loadUrlButton.UseVisualStyleBackColor = true;
            this.loadUrlButton.Click += new System.EventHandler(this.loadUrlButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(12, 26);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(335, 20);
            this.urlTextBox.TabIndex = 2;
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(12, 10);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(35, 15);
            this.UrlLabel.TabIndex = 1;
            this.UrlLabel.Text = "URL:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // key1TextBox
            // 
            this.key1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.key1TextBox.Location = new System.Drawing.Point(12, 118);
            this.key1TextBox.Name = "key1TextBox";
            this.key1TextBox.Size = new System.Drawing.Size(335, 20);
            this.key1TextBox.TabIndex = 3;
            this.key1TextBox.Text = "Boost";
            // 
            // chooseSoundButton
            // 
            this.chooseSoundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseSoundButton.Location = new System.Drawing.Point(353, 69);
            this.chooseSoundButton.Name = "chooseSoundButton";
            this.chooseSoundButton.Size = new System.Drawing.Size(75, 22);
            this.chooseSoundButton.TabIndex = 4;
            this.chooseSoundButton.Text = "Choose sound";
            this.chooseSoundButton.UseVisualStyleBackColor = true;
            this.chooseSoundButton.Click += new System.EventHandler(this.soundPathButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // soundTextBox
            // 
            this.soundTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soundTextBox.Location = new System.Drawing.Point(12, 69);
            this.soundTextBox.Name = "soundTextBox";
            this.soundTextBox.Size = new System.Drawing.Size(335, 20);
            this.soundTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sound:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Key words:";
            // 
            // key4TextBox
            // 
            this.key4TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.key4TextBox.Location = new System.Drawing.Point(12, 196);
            this.key4TextBox.Name = "key4TextBox";
            this.key4TextBox.Size = new System.Drawing.Size(335, 20);
            this.key4TextBox.TabIndex = 8;
            this.key4TextBox.Text = "p1";
            // 
            // key3TextBox
            // 
            this.key3TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.key3TextBox.Location = new System.Drawing.Point(12, 170);
            this.key3TextBox.Name = "key3TextBox";
            this.key3TextBox.Size = new System.Drawing.Size(335, 20);
            this.key3TextBox.TabIndex = 9;
            // 
            // key2TextBox
            // 
            this.key2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.key2TextBox.Location = new System.Drawing.Point(12, 144);
            this.key2TextBox.Name = "key2TextBox";
            this.key2TextBox.Size = new System.Drawing.Size(335, 20);
            this.key2TextBox.TabIndex = 10;
            // 
            // BoostFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 243);
            this.Controls.Add(this.key2TextBox);
            this.Controls.Add(this.key3TextBox);
            this.Controls.Add(this.key4TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soundTextBox);
            this.Controls.Add(this.chooseSoundButton);
            this.Controls.Add(this.key1TextBox);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.loadUrlButton);
            this.Name = "BoostFinderForm";
            this.Text = "Boost Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadUrlButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label UrlLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox key1TextBox;
        private System.Windows.Forms.Button chooseSoundButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox soundTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox key4TextBox;
        private System.Windows.Forms.TextBox key3TextBox;
        private System.Windows.Forms.TextBox key2TextBox;
    }
}

