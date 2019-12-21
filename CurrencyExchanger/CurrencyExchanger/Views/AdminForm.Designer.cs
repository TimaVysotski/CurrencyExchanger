namespace CurrencyExchanger
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.sellTextBox = new System.Windows.Forms.TextBox();
            this.maxSellLimit = new System.Windows.Forms.Label();
            this.buyTextBox = new System.Windows.Forms.TextBox();
            this.maxBuyLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.sellTextBox);
            this.panel1.Controls.Add(this.maxSellLimit);
            this.panel1.Controls.Add(this.buyTextBox);
            this.panel1.Controls.Add(this.maxBuyLabel);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 187);
            this.panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(70, 104);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(153, 40);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // sellTextBox
            // 
            this.sellTextBox.Location = new System.Drawing.Point(175, 78);
            this.sellTextBox.Name = "sellTextBox";
            this.sellTextBox.Size = new System.Drawing.Size(100, 20);
            this.sellTextBox.TabIndex = 19;
            // 
            // maxSellLimit
            // 
            this.maxSellLimit.AutoSize = true;
            this.maxSellLimit.Location = new System.Drawing.Point(205, 52);
            this.maxSellLimit.Name = "maxSellLimit";
            this.maxSellLimit.Size = new System.Drawing.Size(48, 13);
            this.maxSellLimit.TabIndex = 18;
            this.maxSellLimit.Text = "Sell Limit";
            // 
            // buyTextBox
            // 
            this.buyTextBox.Location = new System.Drawing.Point(16, 78);
            this.buyTextBox.Name = "buyTextBox";
            this.buyTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyTextBox.TabIndex = 17;
            // 
            // maxBuyLabel
            // 
            this.maxBuyLabel.AutoSize = true;
            this.maxBuyLabel.Location = new System.Drawing.Point(42, 52);
            this.maxBuyLabel.Name = "maxBuyLabel";
            this.maxBuyLabel.Size = new System.Drawing.Size(45, 13);
            this.maxBuyLabel.TabIndex = 16;
            this.maxBuyLabel.Text = "Buy limit";
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Location = new System.Drawing.Point(0, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "Chech History";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Back";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 187);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "Admin Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox sellTextBox;
        private System.Windows.Forms.Label maxSellLimit;
        private System.Windows.Forms.TextBox buyTextBox;
        private System.Windows.Forms.Label maxBuyLabel;
        private System.Windows.Forms.Button saveButton;
    }
}