namespace project2
{
    partial class CombineDocx
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Meger = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Combine Docx";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(187, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1178, 159);
            this.listBox1.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(187, 275);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(328, 48);
            this.Add.TabIndex = 3;
            this.Add.Text = "Browser";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Meger
            // 
            this.Meger.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Meger.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meger.Location = new System.Drawing.Point(1037, 275);
            this.Meger.Name = "Meger";
            this.Meger.Size = new System.Drawing.Size(328, 48);
            this.Meger.TabIndex = 4;
            this.Meger.Text = "Combine";
            this.Meger.UseVisualStyleBackColor = false;
            this.Meger.Click += new System.EventHandler(this.Meger_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Link Word";
            // 
            // CombineDocx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Meger);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "CombineDocx";
            this.Text = "CombineDocx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Meger;
        private System.Windows.Forms.Label label2;
    }
}