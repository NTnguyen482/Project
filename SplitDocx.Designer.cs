namespace project2
{
    partial class SplitDocx
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Meger = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "Link Word";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(654, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Split Docx";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(207, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(927, 59);
            this.textBox1.TabIndex = 13;
            // 
            // Meger
            // 
            this.Meger.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Meger.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meger.Location = new System.Drawing.Point(1150, 236);
            this.Meger.Name = "Meger";
            this.Meger.Size = new System.Drawing.Size(263, 48);
            this.Meger.TabIndex = 12;
            this.Meger.Text = "Split";
            this.Meger.UseVisualStyleBackColor = false;
            this.Meger.Click += new System.EventHandler(this.Meger_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(1150, 150);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(263, 59);
            this.Add.TabIndex = 11;
            this.Add.Text = "Browser";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // SplitDocx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Meger);
            this.Controls.Add(this.Add);
            this.Name = "SplitDocx";
            this.Text = "SplitDocx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Meger;
        private System.Windows.Forms.Button Add;
    }
}