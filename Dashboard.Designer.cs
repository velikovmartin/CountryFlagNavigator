namespace CountryFlagNavigator
{
    partial class Dashboard
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
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.flagBox = new System.Windows.Forms.PictureBox();
            this.countryNameBox = new System.Windows.Forms.TextBox();
            this.countryName = new System.Windows.Forms.Label();
            this.countryInfo = new System.Windows.Forms.Label();
            this.countryInfoBox = new System.Windows.Forms.RichTextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.capitalNameBox = new System.Windows.Forms.TextBox();
            this.countryCapital = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flagBox)).BeginInit();
            this.SuspendLayout();
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(15, 289);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 30);
            this.prevButton.TabIndex = 0;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(173, 289);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 30);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // flagBox
            // 
            this.flagBox.Location = new System.Drawing.Point(148, 27);
            this.flagBox.Name = "flagBox";
            this.flagBox.Size = new System.Drawing.Size(100, 50);
            this.flagBox.TabIndex = 2;
            this.flagBox.TabStop = false;
            // 
            // countryNameBox
            // 
            this.countryNameBox.Location = new System.Drawing.Point(15, 29);
            this.countryNameBox.Name = "countryNameBox";
            this.countryNameBox.Size = new System.Drawing.Size(100, 22);
            this.countryNameBox.TabIndex = 3;
            // 
            // countryName
            // 
            this.countryName.AutoSize = true;
            this.countryName.Location = new System.Drawing.Point(12, 9);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(57, 17);
            this.countryName.TabIndex = 5;
            this.countryName.Text = "Country";
            // 
            // countryInfo
            // 
            this.countryInfo.AutoSize = true;
            this.countryInfo.Location = new System.Drawing.Point(12, 124);
            this.countryInfo.Name = "countryInfo";
            this.countryInfo.Size = new System.Drawing.Size(31, 17);
            this.countryInfo.TabIndex = 6;
            this.countryInfo.Text = "Info";
            // 
            // countryInfoBox
            // 
            this.countryInfoBox.Location = new System.Drawing.Point(15, 144);
            this.countryInfoBox.Name = "countryInfoBox";
            this.countryInfoBox.Size = new System.Drawing.Size(233, 139);
            this.countryInfoBox.TabIndex = 7;
            this.countryInfoBox.Text = "";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Location = new System.Drawing.Point(173, 108);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 30);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(78, 108);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(75, 30);
            this.undoButton.TabIndex = 9;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // capitalNameBox
            // 
            this.capitalNameBox.Location = new System.Drawing.Point(15, 80);
            this.capitalNameBox.Name = "capitalNameBox";
            this.capitalNameBox.Size = new System.Drawing.Size(100, 22);
            this.capitalNameBox.TabIndex = 10;
            // 
            // countryCapital
            // 
            this.countryCapital.AutoSize = true;
            this.countryCapital.Location = new System.Drawing.Point(12, 60);
            this.countryCapital.Name = "countryCapital";
            this.countryCapital.Size = new System.Drawing.Size(51, 17);
            this.countryCapital.TabIndex = 11;
            this.countryCapital.Text = "Capital";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 331);
            this.Controls.Add(this.countryCapital);
            this.Controls.Add(this.capitalNameBox);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.countryInfoBox);
            this.Controls.Add(this.countryInfo);
            this.Controls.Add(this.countryName);
            this.Controls.Add(this.countryNameBox);
            this.Controls.Add(this.flagBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Name = "Dashboard";
            this.Text = "Country Flag Navigator";
            ((System.ComponentModel.ISupportInitialize)(this.flagBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox flagBox;
        private System.Windows.Forms.TextBox countryNameBox;
        private System.Windows.Forms.Label countryName;
        private System.Windows.Forms.Label countryInfo;
        private System.Windows.Forms.RichTextBox countryInfoBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.TextBox capitalNameBox;
        private System.Windows.Forms.Label countryCapital;
    }
}

