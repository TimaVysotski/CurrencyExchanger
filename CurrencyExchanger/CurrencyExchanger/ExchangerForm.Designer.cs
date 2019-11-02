namespace CurrencyExchanger
{
    partial class ExchangerForm
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
            this.buyCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.buyLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sellLabel = new System.Windows.Forms.Label();
            this.sellCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.buyTextBox = new System.Windows.Forms.TextBox();
            this.buyAmountLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buyAmountLabel);
            this.panel1.Controls.Add(this.buyTextBox);
            this.panel1.Controls.Add(this.buyCheckedListBox);
            this.panel1.Controls.Add(this.buyLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 213);
            this.panel1.TabIndex = 0;
            // 
            // buyCheckedListBox
            // 
            this.buyCheckedListBox.FormattingEnabled = true;
            this.buyCheckedListBox.Items.AddRange(new object[] {
            "$",
            "€",
            "₽"});
            this.buyCheckedListBox.Location = new System.Drawing.Point(12, 53);
            this.buyCheckedListBox.Name = "buyCheckedListBox";
            this.buyCheckedListBox.Size = new System.Drawing.Size(48, 49);
            this.buyCheckedListBox.TabIndex = 2;
            this.buyCheckedListBox.Tag = "Ldfs";
            // 
            // buyLabel
            // 
            this.buyLabel.AutoSize = true;
            this.buyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyLabel.Location = new System.Drawing.Point(105, 9);
            this.buyLabel.Name = "buyLabel";
            this.buyLabel.Size = new System.Drawing.Size(56, 29);
            this.buyLabel.TabIndex = 0;
            this.buyLabel.Text = "Buy";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.sellCheckedListBox);
            this.panel2.Controls.Add(this.sellLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(307, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 213);
            this.panel2.TabIndex = 1;
            // 
            // sellLabel
            // 
            this.sellLabel.AutoSize = true;
            this.sellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sellLabel.Location = new System.Drawing.Point(113, 9);
            this.sellLabel.Name = "sellLabel";
            this.sellLabel.Size = new System.Drawing.Size(59, 29);
            this.sellLabel.TabIndex = 0;
            this.sellLabel.Text = "Sell";
            // 
            // sellCheckedListBox
            // 
            this.sellCheckedListBox.FormattingEnabled = true;
            this.sellCheckedListBox.Items.AddRange(new object[] {
            "$",
            "€",
            "₽"});
            this.sellCheckedListBox.Location = new System.Drawing.Point(18, 53);
            this.sellCheckedListBox.Name = "sellCheckedListBox";
            this.sellCheckedListBox.Size = new System.Drawing.Size(48, 49);
            this.sellCheckedListBox.TabIndex = 3;
            this.sellCheckedListBox.Tag = "Ldfs";
            // 
            // buyTextBox
            // 
            this.buyTextBox.Location = new System.Drawing.Point(135, 68);
            this.buyTextBox.Name = "buyTextBox";
            this.buyTextBox.Size = new System.Drawing.Size(106, 20);
            this.buyTextBox.TabIndex = 3;
            // 
            // buyAmountLabel
            // 
            this.buyAmountLabel.AutoSize = true;
            this.buyAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyAmountLabel.Location = new System.Drawing.Point(76, 69);
            this.buyAmountLabel.Name = "buyAmountLabel";
            this.buyAmountLabel.Size = new System.Drawing.Size(59, 16);
            this.buyAmountLabel.TabIndex = 4;
            this.buyAmountLabel.Text = "Amount :";
            // 
            // ExchangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(595, 213);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExchangerForm";
            this.Text = "Currency Exchanger";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label buyLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label sellLabel;
        private System.Windows.Forms.CheckedListBox buyCheckedListBox;
        private System.Windows.Forms.CheckedListBox sellCheckedListBox;
        private System.Windows.Forms.Label buyAmountLabel;
        private System.Windows.Forms.TextBox buyTextBox;
    }
}