namespace TIPO_KURSACH
{
    partial class Add_Change_Form
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
            this.EnterTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterTextBox
            // 
            this.EnterTextBox.Location = new System.Drawing.Point(12, 12);
            this.EnterTextBox.Name = "EnterTextBox";
            this.EnterTextBox.Size = new System.Drawing.Size(395, 20);
            this.EnterTextBox.TabIndex = 0;
            // 
            // EnterButton
            // 
            this.EnterButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EnterButton.Location = new System.Drawing.Point(12, 38);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(395, 23);
            this.EnterButton.TabIndex = 1;
            this.EnterButton.Text = "OK";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // Add_Change_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 69);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.EnterTextBox);
            this.Name = "Add_Change_Form";
            this.Text = "Add_Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterTextBox;
        private System.Windows.Forms.Button EnterButton;
    }
}