namespace Topic_9_Assignment_part_2
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblSubtract = new System.Windows.Forms.Label();
            this.lblMultiply = new System.Windows.Forms.Label();
            this.lblDivide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 81);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnSubtract.Location = new System.Drawing.Point(12, 128);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(80, 81);
            this.btnSubtract.TabIndex = 1;
            this.btnSubtract.Text = "−";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnMultiply.Location = new System.Drawing.Point(12, 246);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(80, 81);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnDivide.Location = new System.Drawing.Point(12, 357);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(80, 81);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblAdd.Location = new System.Drawing.Point(177, 33);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(122, 39);
            this.lblAdd.TabIndex = 6;
            this.lblAdd.Text = "8 + 8 =";
            this.lblAdd.Visible = false;
            // 
            // lblSubtract
            // 
            this.lblSubtract.AutoSize = true;
            this.lblSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblSubtract.Location = new System.Drawing.Point(186, 149);
            this.lblSubtract.Name = "lblSubtract";
            this.lblSubtract.Size = new System.Drawing.Size(113, 39);
            this.lblSubtract.TabIndex = 7;
            this.lblSubtract.Text = "8 - 8 =";
            this.lblSubtract.Visible = false;
            // 
            // lblMultiply
            // 
            this.lblMultiply.AutoSize = true;
            this.lblMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblMultiply.Location = new System.Drawing.Point(184, 267);
            this.lblMultiply.Name = "lblMultiply";
            this.lblMultiply.Size = new System.Drawing.Size(115, 39);
            this.lblMultiply.TabIndex = 8;
            this.lblMultiply.Text = "8 * 8 =";
            this.lblMultiply.Visible = false;
            // 
            // lblDivide
            // 
            this.lblDivide.AutoSize = true;
            this.lblDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblDivide.Location = new System.Drawing.Point(188, 378);
            this.lblDivide.Name = "lblDivide";
            this.lblDivide.Size = new System.Drawing.Size(111, 39);
            this.lblDivide.TabIndex = 9;
            this.lblDivide.Text = "8 / 8 =";
            this.lblDivide.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDivide);
            this.Controls.Add(this.lblMultiply);
            this.Controls.Add(this.lblSubtract);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = " Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblSubtract;
        private System.Windows.Forms.Label lblMultiply;
        private System.Windows.Forms.Label lblDivide;
    }
}

