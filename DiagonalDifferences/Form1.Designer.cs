namespace DiagonalDifferences
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
            this.lbl_Size = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.lblArray = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnDifference = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSumTLBR = new System.Windows.Forms.TextBox();
            this.txtSumTRBL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDifference = new System.Windows.Forms.TextBox();
            this.lblDifference = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Location = new System.Drawing.Point(16, 16);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(27, 13);
            this.lbl_Size.TabIndex = 0;
            this.lbl_Size.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(55, 13);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 1;
            // 
            // txtOut
            // 
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(192, 67);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(410, 313);
            this.txtOut.TabIndex = 2;
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArray.Location = new System.Drawing.Point(311, 39);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(170, 25);
            this.lblArray.TabIndex = 3;
            this.lblArray.Text = "Generated Array";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(361, 13);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate!";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnDifference
            // 
            this.btnDifference.Location = new System.Drawing.Point(316, 390);
            this.btnDifference.Name = "btnDifference";
            this.btnDifference.Size = new System.Drawing.Size(161, 23);
            this.btnDifference.TabIndex = 5;
            this.btnDifference.Text = "Calculate Diagonal Difference";
            this.btnDifference.UseVisualStyleBackColor = true;
            this.btnDifference.Click += new System.EventHandler(this.btnDifference_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Top Left to Bottom Right Sum";
            // 
            // txtSumTLBR
            // 
            this.txtSumTLBR.Location = new System.Drawing.Point(169, 399);
            this.txtSumTLBR.Name = "txtSumTLBR";
            this.txtSumTLBR.Size = new System.Drawing.Size(127, 20);
            this.txtSumTLBR.TabIndex = 7;
            // 
            // txtSumTRBL
            // 
            this.txtSumTRBL.Location = new System.Drawing.Point(661, 396);
            this.txtSumTRBL.Name = "txtSumTRBL";
            this.txtSumTRBL.Size = new System.Drawing.Size(127, 20);
            this.txtSumTRBL.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Top Right to Bottom Left Sum";
            // 
            // txtDifference
            // 
            this.txtDifference.Location = new System.Drawing.Point(316, 462);
            this.txtDifference.Name = "txtDifference";
            this.txtDifference.Size = new System.Drawing.Size(161, 20);
            this.txtDifference.TabIndex = 10;
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Location = new System.Drawing.Point(368, 446);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(56, 13);
            this.lblDifference.TabIndex = 11;
            this.lblDifference.Text = "Difference";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.lblDifference);
            this.Controls.Add(this.txtDifference);
            this.Controls.Add(this.txtSumTRBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSumTLBR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDifference);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lbl_Size);
            this.Name = "Form1";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDifference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSumTLBR;
        private System.Windows.Forms.TextBox txtSumTRBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDifference;
        private System.Windows.Forms.Label lblDifference;
    }
}

