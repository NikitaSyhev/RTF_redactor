namespace RTF_redactor
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
            this.openBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.usualFont = new System.Windows.Forms.Button();
            this.boldFont = new System.Windows.Forms.Button();
            this.italicsFont = new System.Windows.Forms.Button();
            this.sizeBtn = new System.Windows.Forms.Button();
            this.textSize = new System.Windows.Forms.TextBox();
            this.colorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(12, 12);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(122, 35);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openBtn_MouseClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 71);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(122, 35);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(372, 20);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(416, 418);
            this.TextBox.TabIndex = 2;
            this.TextBox.Text = "";
            // 
            // usualFont
            // 
            this.usualFont.Location = new System.Drawing.Point(291, 24);
            this.usualFont.Name = "usualFont";
            this.usualFont.Size = new System.Drawing.Size(75, 23);
            this.usualFont.TabIndex = 3;
            this.usualFont.Text = "Обычный";
            this.usualFont.UseVisualStyleBackColor = true;
            this.usualFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeFont_MouseClick);
            // 
            // boldFont
            // 
            this.boldFont.Location = new System.Drawing.Point(291, 71);
            this.boldFont.Name = "boldFont";
            this.boldFont.Size = new System.Drawing.Size(75, 23);
            this.boldFont.TabIndex = 4;
            this.boldFont.Text = "Жирный";
            this.boldFont.UseVisualStyleBackColor = true;
            this.boldFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeFont_MouseClick);
            // 
            // italicsFont
            // 
            this.italicsFont.Location = new System.Drawing.Point(291, 123);
            this.italicsFont.Name = "italicsFont";
            this.italicsFont.Size = new System.Drawing.Size(75, 23);
            this.italicsFont.TabIndex = 5;
            this.italicsFont.Text = "Курсив";
            this.italicsFont.UseVisualStyleBackColor = true;
            this.italicsFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeFont_MouseClick);
            // 
            // sizeBtn
            // 
            this.sizeBtn.Location = new System.Drawing.Point(183, 24);
            this.sizeBtn.Name = "sizeBtn";
            this.sizeBtn.Size = new System.Drawing.Size(102, 23);
            this.sizeBtn.TabIndex = 6;
            this.sizeBtn.Text = "Размер шрифта";
            this.sizeBtn.UseVisualStyleBackColor = true;
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(183, 71);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(100, 20);
            this.textSize.TabIndex = 7;
            this.textSize.TextChanged += new System.EventHandler(this.textSize_TextChanged);
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(183, 123);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(102, 23);
            this.colorBtn.TabIndex = 8;
            this.colorBtn.Text = "Выбор цвета";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.textSize);
            this.Controls.Add(this.sizeBtn);
            this.Controls.Add(this.italicsFont);
            this.Controls.Add(this.boldFont);
            this.Controls.Add(this.usualFont);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTheme);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button usualFont;
        private System.Windows.Forms.Button boldFont;
        private System.Windows.Forms.Button italicsFont;
        private System.Windows.Forms.Button sizeBtn;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Button colorBtn;
    }
}

