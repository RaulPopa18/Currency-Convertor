namespace Convertor_Valutar_Generic
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox1Form2 = new System.Windows.Forms.TextBox();
            this.txtBox2Form2 = new System.Windows.Forms.TextBox();
            this.txtBoxResultForm2 = new System.Windows.Forms.TextBox();
            this.txtBoxCurrecy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "The value converte from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Equal:";
            // 
            // txtBox1Form2
            // 
            this.txtBox1Form2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBox1Form2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1Form2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBox1Form2.Location = new System.Drawing.Point(530, 85);
            this.txtBox1Form2.Name = "txtBox1Form2";
            this.txtBox1Form2.ReadOnly = true;
            this.txtBox1Form2.Size = new System.Drawing.Size(100, 22);
            this.txtBox1Form2.TabIndex = 3;
            this.txtBox1Form2.TabStop = false;
            // 
            // txtBox2Form2
            // 
            this.txtBox2Form2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBox2Form2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2Form2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBox2Form2.Location = new System.Drawing.Point(530, 152);
            this.txtBox2Form2.Name = "txtBox2Form2";
            this.txtBox2Form2.ReadOnly = true;
            this.txtBox2Form2.Size = new System.Drawing.Size(100, 22);
            this.txtBox2Form2.TabIndex = 4;
            this.txtBox2Form2.TabStop = false;
            // 
            // txtBoxResultForm2
            // 
            this.txtBoxResultForm2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxResultForm2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxResultForm2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxResultForm2.Location = new System.Drawing.Point(508, 282);
            this.txtBoxResultForm2.Name = "txtBoxResultForm2";
            this.txtBoxResultForm2.ReadOnly = true;
            this.txtBoxResultForm2.Size = new System.Drawing.Size(122, 31);
            this.txtBoxResultForm2.TabIndex = 5;
            this.txtBoxResultForm2.TabStop = false;
            // 
            // txtBoxCurrecy
            // 
            this.txtBoxCurrecy.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxCurrecy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCurrecy.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxCurrecy.Location = new System.Drawing.Point(649, 288);
            this.txtBoxCurrecy.Name = "txtBoxCurrecy";
            this.txtBoxCurrecy.ReadOnly = true;
            this.txtBoxCurrecy.Size = new System.Drawing.Size(46, 22);
            this.txtBoxCurrecy.TabIndex = 6;
            this.txtBoxCurrecy.TabStop = false;
            this.txtBoxCurrecy.TextChanged += new System.EventHandler(this.txtBoxCurrecy_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxCurrecy);
            this.Controls.Add(this.txtBoxResultForm2);
            this.Controls.Add(this.txtBox2Form2);
            this.Controls.Add(this.txtBox1Form2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox1Form2;
        private System.Windows.Forms.TextBox txtBox2Form2;
        private System.Windows.Forms.TextBox txtBoxResultForm2;
        private System.Windows.Forms.TextBox txtBoxCurrecy;
    }
}