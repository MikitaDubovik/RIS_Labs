namespace Second.Client
{
    partial class Client
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
            this.NameItem = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Taste = new System.Windows.Forms.TextBox();
            this.printRadioButton = new System.Windows.Forms.RadioButton();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.deleteRadioButton = new System.Windows.Forms.RadioButton();
            this.updateRadioButton = new System.Windows.Forms.RadioButton();
            this.searchRadioButton = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // NameItem
            // 
            this.NameItem.Location = new System.Drawing.Point(476, 36);
            this.NameItem.Name = "NameItem";
            this.NameItem.Size = new System.Drawing.Size(246, 22);
            this.NameItem.TabIndex = 0;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(476, 94);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(246, 22);
            this.Price.TabIndex = 1;
            // 
            // Taste
            // 
            this.Taste.Location = new System.Drawing.Point(476, 152);
            this.Taste.Name = "Taste";
            this.Taste.Size = new System.Drawing.Size(246, 22);
            this.Taste.TabIndex = 2;
            // 
            // printRadioButton
            // 
            this.printRadioButton.AutoSize = true;
            this.printRadioButton.Location = new System.Drawing.Point(278, 45);
            this.printRadioButton.Name = "printRadioButton";
            this.printRadioButton.Size = new System.Drawing.Size(58, 21);
            this.printRadioButton.TabIndex = 3;
            this.printRadioButton.TabStop = true;
            this.printRadioButton.Text = "Print";
            this.printRadioButton.UseVisualStyleBackColor = true;
            this.printRadioButton.CheckedChanged += new System.EventHandler(this.printRadioButton_CheckedChanged);
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Location = new System.Drawing.Point(278, 72);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(54, 21);
            this.addRadioButton.TabIndex = 4;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "Add";
            this.addRadioButton.UseVisualStyleBackColor = true;
            this.addRadioButton.CheckedChanged += new System.EventHandler(this.addRadioButton_CheckedChanged);
            // 
            // deleteRadioButton
            // 
            this.deleteRadioButton.AutoSize = true;
            this.deleteRadioButton.Location = new System.Drawing.Point(278, 99);
            this.deleteRadioButton.Name = "deleteRadioButton";
            this.deleteRadioButton.Size = new System.Drawing.Size(70, 21);
            this.deleteRadioButton.TabIndex = 5;
            this.deleteRadioButton.TabStop = true;
            this.deleteRadioButton.Text = "Delete";
            this.deleteRadioButton.UseVisualStyleBackColor = true;
            this.deleteRadioButton.CheckedChanged += new System.EventHandler(this.deleteRadioButton_CheckedChanged);
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.Location = new System.Drawing.Point(278, 126);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(75, 21);
            this.updateRadioButton.TabIndex = 6;
            this.updateRadioButton.TabStop = true;
            this.updateRadioButton.Text = "Update";
            this.updateRadioButton.UseVisualStyleBackColor = true;
            this.updateRadioButton.CheckedChanged += new System.EventHandler(this.updateRadioButton_CheckedChanged);
            // 
            // searchRadioButton
            // 
            this.searchRadioButton.AutoSize = true;
            this.searchRadioButton.Location = new System.Drawing.Point(278, 153);
            this.searchRadioButton.Name = "searchRadioButton";
            this.searchRadioButton.Size = new System.Drawing.Size(74, 21);
            this.searchRadioButton.TabIndex = 7;
            this.searchRadioButton.TabStop = true;
            this.searchRadioButton.Text = "Search";
            this.searchRadioButton.UseVisualStyleBackColor = true;
            this.searchRadioButton.CheckedChanged += new System.EventHandler(this.searchRadioButton_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(471, 208);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 116);
            this.listBox1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(359, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Show status";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Taste";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(232, 177);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 351);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchRadioButton);
            this.Controls.Add(this.updateRadioButton);
            this.Controls.Add(this.deleteRadioButton);
            this.Controls.Add(this.addRadioButton);
            this.Controls.Add(this.printRadioButton);
            this.Controls.Add(this.Taste);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.NameItem);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameItem;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Taste;
        private System.Windows.Forms.RadioButton printRadioButton;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.RadioButton deleteRadioButton;
        private System.Windows.Forms.RadioButton updateRadioButton;
        private System.Windows.Forms.RadioButton searchRadioButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

