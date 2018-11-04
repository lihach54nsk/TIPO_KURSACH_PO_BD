namespace TIPO_KURSACH
{
    partial class Computers_Form
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
            this.ComputersDataGridView = new System.Windows.Forms.DataGridView();
            this.AddComputerButton = new System.Windows.Forms.Button();
            this.DeleteComputerButton = new System.Windows.Forms.Button();
            this.ShowComputersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComputersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ComputersDataGridView
            // 
            this.ComputersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComputersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ComputersDataGridView.Name = "ComputersDataGridView";
            this.ComputersDataGridView.Size = new System.Drawing.Size(776, 152);
            this.ComputersDataGridView.TabIndex = 0;
            // 
            // AddComputerButton
            // 
            this.AddComputerButton.Location = new System.Drawing.Point(12, 170);
            this.AddComputerButton.Name = "AddComputerButton";
            this.AddComputerButton.Size = new System.Drawing.Size(171, 23);
            this.AddComputerButton.TabIndex = 1;
            this.AddComputerButton.Text = "Добавить/изменить";
            this.AddComputerButton.UseVisualStyleBackColor = true;
            this.AddComputerButton.Click += new System.EventHandler(this.AddComputerButton_Click);
            // 
            // DeleteComputerButton
            // 
            this.DeleteComputerButton.Location = new System.Drawing.Point(617, 170);
            this.DeleteComputerButton.Name = "DeleteComputerButton";
            this.DeleteComputerButton.Size = new System.Drawing.Size(171, 23);
            this.DeleteComputerButton.TabIndex = 2;
            this.DeleteComputerButton.Text = "Удалить";
            this.DeleteComputerButton.UseVisualStyleBackColor = true;
            this.DeleteComputerButton.Click += new System.EventHandler(this.DeleteComputerButton_Click);
            // 
            // ShowComputersButton
            // 
            this.ShowComputersButton.Location = new System.Drawing.Point(189, 170);
            this.ShowComputersButton.Name = "ShowComputersButton";
            this.ShowComputersButton.Size = new System.Drawing.Size(171, 23);
            this.ShowComputersButton.TabIndex = 4;
            this.ShowComputersButton.Text = "Показать";
            this.ShowComputersButton.UseVisualStyleBackColor = true;
            this.ShowComputersButton.Click += new System.EventHandler(this.ShowComputersButton_Click);
            // 
            // Computers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 201);
            this.Controls.Add(this.ShowComputersButton);
            this.Controls.Add(this.DeleteComputerButton);
            this.Controls.Add(this.AddComputerButton);
            this.Controls.Add(this.ComputersDataGridView);
            this.Name = "Computers_Form";
            this.Text = "Computers";
            ((System.ComponentModel.ISupportInitialize)(this.ComputersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ComputersDataGridView;
        private System.Windows.Forms.Button AddComputerButton;
        private System.Windows.Forms.Button DeleteComputerButton;
        private System.Windows.Forms.Button ShowComputersButton;
    }
}