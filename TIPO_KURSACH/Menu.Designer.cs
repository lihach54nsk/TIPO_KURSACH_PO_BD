namespace TIPO_KURSACH
{
    partial class Menu
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
            this.WorkersButton = new System.Windows.Forms.Button();
            this.ComputersButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WorkersButton
            // 
            this.WorkersButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.WorkersButton.Location = new System.Drawing.Point(12, 12);
            this.WorkersButton.Name = "WorkersButton";
            this.WorkersButton.Size = new System.Drawing.Size(132, 122);
            this.WorkersButton.TabIndex = 0;
            this.WorkersButton.Text = "Работники";
            this.WorkersButton.UseVisualStyleBackColor = true;
            this.WorkersButton.Click += new System.EventHandler(this.WorkersButton_Click);
            // 
            // ComputersButton
            // 
            this.ComputersButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.ComputersButton.Location = new System.Drawing.Point(150, 12);
            this.ComputersButton.Name = "ComputersButton";
            this.ComputersButton.Size = new System.Drawing.Size(132, 122);
            this.ComputersButton.TabIndex = 1;
            this.ComputersButton.Text = "Компьютеры";
            this.ComputersButton.UseVisualStyleBackColor = true;
            this.ComputersButton.Click += new System.EventHandler(this.ComputersButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ClientsButton.Location = new System.Drawing.Point(288, 12);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(132, 122);
            this.ClientsButton.TabIndex = 2;
            this.ClientsButton.Text = "Клиенты";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 139);
            this.Controls.Add(this.ClientsButton);
            this.Controls.Add(this.ComputersButton);
            this.Controls.Add(this.WorkersButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WorkersButton;
        private System.Windows.Forms.Button ComputersButton;
        private System.Windows.Forms.Button ClientsButton;
    }
}