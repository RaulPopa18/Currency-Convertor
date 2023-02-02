namespace Convertor_Valutar_Generic
{
    partial class Convertor
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.listboxFirstCurrency = new System.Windows.Forms.ListBox();
            this.listboxSecondCurrency = new System.Windows.Forms.ListBox();
            this.txtFirstCurrency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Switch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnConvert.Location = new System.Drawing.Point(464, 399);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(257, 93);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // listboxFirstCurrency
            // 
            this.listboxFirstCurrency.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listboxFirstCurrency.FormattingEnabled = true;
            this.listboxFirstCurrency.ItemHeight = 23;
            this.listboxFirstCurrency.Location = new System.Drawing.Point(657, 72);
            this.listboxFirstCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.listboxFirstCurrency.Name = "listboxFirstCurrency";
            this.listboxFirstCurrency.Size = new System.Drawing.Size(162, 211);
            this.listboxFirstCurrency.TabIndex = 1;
            this.listboxFirstCurrency.SelectedIndexChanged += new System.EventHandler(this.listboxFirstCurrency_SelectedIndexChanged);
            // 
            // listboxSecondCurrency
            // 
            this.listboxSecondCurrency.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listboxSecondCurrency.FormattingEnabled = true;
            this.listboxSecondCurrency.ItemHeight = 23;
            this.listboxSecondCurrency.Location = new System.Drawing.Point(1005, 72);
            this.listboxSecondCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.listboxSecondCurrency.Name = "listboxSecondCurrency";
            this.listboxSecondCurrency.Size = new System.Drawing.Size(162, 211);
            this.listboxSecondCurrency.TabIndex = 2;
            this.listboxSecondCurrency.SelectedIndexChanged += new System.EventHandler(this.listboxSecondCurrency_SelectedIndexChanged);
            // 
            // txtFirstCurrency
            // 
            this.txtFirstCurrency.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFirstCurrency.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFirstCurrency.Location = new System.Drawing.Point(245, 125);
            this.txtFirstCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstCurrency.Name = "txtFirstCurrency";
            this.txtFirstCurrency.Size = new System.Drawing.Size(198, 31);
            this.txtFirstCurrency.TabIndex = 5;
            this.txtFirstCurrency.TextChanged += new System.EventHandler(this.txtFirstCurrency_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "From:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(871, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Insert the value \r\nyou want to convert:";
            // 
            // Switch
            // 
            this.Switch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Switch.Location = new System.Drawing.Point(864, 199);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(90, 41);
            this.Switch.TabIndex = 9;
            this.Switch.Text = "Switch";
            this.Switch.UseVisualStyleBackColor = false;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // Convertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1223, 566);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstCurrency);
            this.Controls.Add(this.listboxSecondCurrency);
            this.Controls.Add(this.listboxFirstCurrency);
            this.Controls.Add(this.btnConvert);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Convertor";
            this.Text = "Convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ListBox listboxSecondCurrency;
        private System.Windows.Forms.TextBox txtFirstCurrency;
        private System.Windows.Forms.ListBox listboxFirstCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Switch;
    }
}

