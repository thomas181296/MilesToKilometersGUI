namespace ProjectedRaisesGUI
{
    partial class ProjectedRaises
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
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btn_result = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the employee\'s salary:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(358, 87);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 1;
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(265, 168);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(135, 77);
            this.btn_result.TabIndex = 2;
            this.btn_result.Text = "Click me for new salary";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New salary:";
            // 
            // newSalary
            // 
            this.newSalary.Location = new System.Drawing.Point(391, 313);
            this.newSalary.Name = "newSalary";
            this.newSalary.Size = new System.Drawing.Size(100, 20);
            this.newSalary.TabIndex = 4;
            // 
            // ProjectedRaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label1);
            this.Name = "ProjectedRaises";
            this.Text = "Projected Raises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newSalary;
    }
}

