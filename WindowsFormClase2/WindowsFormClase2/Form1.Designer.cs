namespace WindowsFormClase2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DNI_txtBox = new System.Windows.Forms.TextBox();
            this.Tipo_txtBox = new System.Windows.Forms.TextBox();
            this.DV_txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresar CUIL:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(152, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DNI_txtBox
            // 
            this.DNI_txtBox.Location = new System.Drawing.Point(143, 57);
            this.DNI_txtBox.MaxLength = 8;
            this.DNI_txtBox.Name = "DNI_txtBox";
            this.DNI_txtBox.Size = new System.Drawing.Size(100, 20);
            this.DNI_txtBox.TabIndex = 2;
            // 
            // Tipo_txtBox
            // 
            this.Tipo_txtBox.Location = new System.Drawing.Point(107, 57);
            this.Tipo_txtBox.MaxLength = 2;
            this.Tipo_txtBox.Name = "Tipo_txtBox";
            this.Tipo_txtBox.Size = new System.Drawing.Size(25, 20);
            this.Tipo_txtBox.TabIndex = 1;
            // 
            // DV_txtBox
            // 
            this.DV_txtBox.Location = new System.Drawing.Point(255, 57);
            this.DV_txtBox.MaxLength = 1;
            this.DV_txtBox.Name = "DV_txtBox";
            this.DV_txtBox.Size = new System.Drawing.Size(25, 20);
            this.DV_txtBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(312, 147);
            this.Controls.Add(this.DV_txtBox);
            this.Controls.Add(this.Tipo_txtBox);
            this.Controls.Add(this.DNI_txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DNI_txtBox;
        private System.Windows.Forms.TextBox Tipo_txtBox;
        private System.Windows.Forms.TextBox DV_txtBox;
    }
}

