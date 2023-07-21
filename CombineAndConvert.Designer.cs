namespace project2
{
    partial class CombineAndConvert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Combine2 = new System.Windows.Forms.Button();
            this.Combine1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Combine PDF Convert Word AND Combine ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Link PDF OR Word";
            // 
            // but1
            // 
            this.but1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.but1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.Location = new System.Drawing.Point(297, 238);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(328, 48);
            this.but1.TabIndex = 9;
            this.but1.Text = "Browser";
            this.but1.UseVisualStyleBackColor = false;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(297, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(851, 128);
            this.listBox1.TabIndex = 8;
            // 
            // Combine2
            // 
            this.Combine2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Combine2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combine2.Location = new System.Drawing.Point(733, 311);
            this.Combine2.Name = "Combine2";
            this.Combine2.Size = new System.Drawing.Size(415, 48);
            this.Combine2.TabIndex = 15;
            this.Combine2.Text = "Combine Word Convert PDF";
            this.Combine2.UseVisualStyleBackColor = false;
            this.Combine2.Click += new System.EventHandler(this.Combine2_Click);
            // 
            // Combine1
            // 
            this.Combine1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Combine1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combine1.Location = new System.Drawing.Point(733, 241);
            this.Combine1.Name = "Combine1";
            this.Combine1.Size = new System.Drawing.Size(415, 48);
            this.Combine1.TabIndex = 10;
            this.Combine1.Text = "Combine PDF Convert Word";
            this.Combine1.UseVisualStyleBackColor = false;
            this.Combine1.Click += new System.EventHandler(this.Combine1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(297, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reset Browser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CombineAndConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Combine2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Combine1);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "CombineAndConvert";
            this.Text = "CombineAndConvert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Combine2;
        private System.Windows.Forms.Button Combine1;
        private System.Windows.Forms.Button button1;
    }
}