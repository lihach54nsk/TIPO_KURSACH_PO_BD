namespace TIPO_KURSACH
{
    partial class Sure_Form
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
            this.YesButtton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы точно хотите это сделать?";
            // 
            // YesButtton
            // 
            this.YesButtton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.YesButtton.Location = new System.Drawing.Point(10, 29);
            this.YesButtton.Name = "YesButtton";
            this.YesButtton.Size = new System.Drawing.Size(75, 23);
            this.YesButtton.TabIndex = 1;
            this.YesButtton.Text = "Да";
            this.YesButtton.UseVisualStyleBackColor = true;
            this.YesButtton.Click += new System.EventHandler(this.YesButtton_Click);
            // 
            // NoButton
            // 
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.NoButton.Location = new System.Drawing.Point(91, 29);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "Нет";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // Sure_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 59);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButtton);
            this.Controls.Add(this.label1);
            this.Name = "Sure_Form";
            this.Text = "Sure_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YesButtton;
        private System.Windows.Forms.Button NoButton;
    }
}