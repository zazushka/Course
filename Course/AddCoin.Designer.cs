namespace Course
{
    partial class AddCoin
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
            this.NominalBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.ProdQuanityBox = new System.Windows.Forms.TextBox();
            this.ProdYearBox = new System.Windows.Forms.TextBox();
            this.FeaturesBox = new System.Windows.Forms.TextBox();
            this.nomlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddEditAcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NominalBox
            // 
            this.NominalBox.Location = new System.Drawing.Point(138, 8);
            this.NominalBox.Name = "NominalBox";
            this.NominalBox.Size = new System.Drawing.Size(274, 20);
            this.NominalBox.TabIndex = 0;
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(138, 34);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(274, 20);
            this.CountryBox.TabIndex = 1;
            // 
            // ProdQuanityBox
            // 
            this.ProdQuanityBox.Location = new System.Drawing.Point(138, 61);
            this.ProdQuanityBox.Name = "ProdQuanityBox";
            this.ProdQuanityBox.Size = new System.Drawing.Size(274, 20);
            this.ProdQuanityBox.TabIndex = 2;
            // 
            // ProdYearBox
            // 
            this.ProdYearBox.Location = new System.Drawing.Point(138, 88);
            this.ProdYearBox.Name = "ProdYearBox";
            this.ProdYearBox.Size = new System.Drawing.Size(274, 20);
            this.ProdYearBox.TabIndex = 3;
            // 
            // FeaturesBox
            // 
            this.FeaturesBox.Location = new System.Drawing.Point(138, 115);
            this.FeaturesBox.Multiline = true;
            this.FeaturesBox.Name = "FeaturesBox";
            this.FeaturesBox.Size = new System.Drawing.Size(274, 184);
            this.FeaturesBox.TabIndex = 4;
            // 
            // nomlabel
            // 
            this.nomlabel.AutoSize = true;
            this.nomlabel.Location = new System.Drawing.Point(5, 7);
            this.nomlabel.Name = "nomlabel";
            this.nomlabel.Size = new System.Drawing.Size(53, 13);
            this.nomlabel.TabIndex = 5;
            this.nomlabel.Text = "Номинал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Страна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выпущеное количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Год выпуска";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Особенности";
            // 
            // AddEditAcceptButton
            // 
            this.AddEditAcceptButton.Location = new System.Drawing.Point(12, 310);
            this.AddEditAcceptButton.Name = "AddEditAcceptButton";
            this.AddEditAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AddEditAcceptButton.TabIndex = 10;
            this.AddEditAcceptButton.Text = "Принять";
            this.AddEditAcceptButton.UseVisualStyleBackColor = true;
            this.AddEditAcceptButton.Click += new System.EventHandler(this.AddEditAcceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(333, 310);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 339);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddEditAcceptButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomlabel);
            this.Controls.Add(this.FeaturesBox);
            this.Controls.Add(this.ProdYearBox);
            this.Controls.Add(this.ProdQuanityBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.NominalBox);
            this.Name = "AddCoin";
            this.Text = "Добавление монеты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NominalBox;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.TextBox ProdQuanityBox;
        private System.Windows.Forms.TextBox ProdYearBox;
        private System.Windows.Forms.TextBox FeaturesBox;
        private System.Windows.Forms.Label nomlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddEditAcceptButton;
        private System.Windows.Forms.Button CancelButton;
    }
}