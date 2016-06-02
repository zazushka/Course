namespace Course
{
    partial class CoinAddIntoCollection
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
            this.CoinView = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoinView)).BeginInit();
            this.SuspendLayout();
            // 
            // CoinView
            // 
            this.CoinView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CoinView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoinView.Location = new System.Drawing.Point(12, 12);
            this.CoinView.Name = "CoinView";
            this.CoinView.ReadOnly = true;
            this.CoinView.Size = new System.Drawing.Size(702, 282);
            this.CoinView.TabIndex = 2;
            this.CoinView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoinView_CellContentDoubleClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(12, 301);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(702, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CoinAddIntoCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 338);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CoinView);
            this.Name = "CoinAddIntoCollection";
            this.Text = "CoinAddIntoCollection";
            ((System.ComponentModel.ISupportInitialize)(this.CoinView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CoinView;
        private System.Windows.Forms.Button CloseButton;
    }
}