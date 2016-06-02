namespace Course
{
    partial class MainForm
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
            this.CoinView = new System.Windows.Forms.DataGridView();
            this.RightClickStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CoinSearchBox = new System.Windows.Forms.TextBox();
            this.CollectionersButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoinView)).BeginInit();
            this.RightClickStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoinView
            // 
            this.CoinView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CoinView.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.CoinView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoinView.ContextMenuStrip = this.RightClickStrip;
            this.CoinView.GridColor = System.Drawing.Color.Maroon;
            this.CoinView.Location = new System.Drawing.Point(12, 53);
            this.CoinView.Name = "CoinView";
            this.CoinView.ReadOnly = true;
            this.CoinView.Size = new System.Drawing.Size(875, 310);
            this.CoinView.TabIndex = 0;
            this.CoinView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoinView_CellDoubleClick);
            // 
            // RightClickStrip
            // 
            this.RightClickStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.RightClickStrip.Name = "RightClickStrip";
            this.RightClickStrip.Size = new System.Drawing.Size(155, 70);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.EditToolStripMenuItem.Text = "Редактировать";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Crimson;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // CoinSearchBox
            // 
            this.CoinSearchBox.BackColor = System.Drawing.Color.DarkSalmon;
            this.CoinSearchBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CoinSearchBox.Location = new System.Drawing.Point(12, 27);
            this.CoinSearchBox.Name = "CoinSearchBox";
            this.CoinSearchBox.Size = new System.Drawing.Size(875, 20);
            this.CoinSearchBox.TabIndex = 2;
            // 
            // CollectionersButton
            // 
            this.CollectionersButton.BackColor = System.Drawing.Color.DarkRed;
            this.CollectionersButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CollectionersButton.Location = new System.Drawing.Point(12, 369);
            this.CollectionersButton.Name = "CollectionersButton";
            this.CollectionersButton.Size = new System.Drawing.Size(433, 43);
            this.CollectionersButton.TabIndex = 3;
            this.CollectionersButton.Text = "Коллекционеры";
            this.CollectionersButton.UseVisualStyleBackColor = false;
            this.CollectionersButton.Click += new System.EventHandler(this.CollectionersButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(456, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(431, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Моя коллекция";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(899, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CollectionersButton);
            this.Controls.Add(this.CoinSearchBox);
            this.Controls.Add(this.CoinView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Справочник нумизамата";
            ((System.ComponentModel.ISupportInitialize)(this.CoinView)).EndInit();
            this.RightClickStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CoinView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TextBox CoinSearchBox;
        private System.Windows.Forms.Button CollectionersButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip RightClickStrip;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
    }
}

