namespace TIPO_KURSACH
{
    partial class Add_Computer_Form
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
            this.PerefComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PC_ComboBox = new System.Windows.Forms.ComboBox();
            this.PS_ComboBox = new System.Windows.Forms.ComboBox();
            this.AddPerefButton = new System.Windows.Forms.Button();
            this.AddPC_Button = new System.Windows.Forms.Button();
            this.AddPS_Button = new System.Windows.Forms.Button();
            this.ChangePerefButton = new System.Windows.Forms.Button();
            this.ChangePC_Button = new System.Windows.Forms.Button();
            this.ChangePS_Button = new System.Windows.Forms.Button();
            this.DeletePerefButton = new System.Windows.Forms.Button();
            this.DeletePC_Button = new System.Windows.Forms.Button();
            this.DeletePS_Button = new System.Windows.Forms.Button();
            this.AddComputerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Периферия: ";
            // 
            // PerefComboBox
            // 
            this.PerefComboBox.FormattingEnabled = true;
            this.PerefComboBox.Location = new System.Drawing.Point(115, 6);
            this.PerefComboBox.Name = "PerefComboBox";
            this.PerefComboBox.Size = new System.Drawing.Size(418, 21);
            this.PerefComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ПО: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Комплектующие: ";
            // 
            // PC_ComboBox
            // 
            this.PC_ComboBox.FormattingEnabled = true;
            this.PC_ComboBox.Location = new System.Drawing.Point(115, 33);
            this.PC_ComboBox.Name = "PC_ComboBox";
            this.PC_ComboBox.Size = new System.Drawing.Size(418, 21);
            this.PC_ComboBox.TabIndex = 4;
            // 
            // PS_ComboBox
            // 
            this.PS_ComboBox.FormattingEnabled = true;
            this.PS_ComboBox.Location = new System.Drawing.Point(115, 61);
            this.PS_ComboBox.Name = "PS_ComboBox";
            this.PS_ComboBox.Size = new System.Drawing.Size(418, 21);
            this.PS_ComboBox.TabIndex = 5;
            // 
            // AddPerefButton
            // 
            this.AddPerefButton.Location = new System.Drawing.Point(15, 88);
            this.AddPerefButton.Name = "AddPerefButton";
            this.AddPerefButton.Size = new System.Drawing.Size(161, 23);
            this.AddPerefButton.TabIndex = 6;
            this.AddPerefButton.Text = "Добавить периферию";
            this.AddPerefButton.UseVisualStyleBackColor = true;
            this.AddPerefButton.Click += new System.EventHandler(this.AddPerefButton_Click);
            // 
            // AddPC_Button
            // 
            this.AddPC_Button.Location = new System.Drawing.Point(15, 117);
            this.AddPC_Button.Name = "AddPC_Button";
            this.AddPC_Button.Size = new System.Drawing.Size(161, 23);
            this.AddPC_Button.TabIndex = 7;
            this.AddPC_Button.Text = "Добавить комплектующие";
            this.AddPC_Button.UseVisualStyleBackColor = true;
            this.AddPC_Button.Click += new System.EventHandler(this.AddPC_Button_Click);
            // 
            // AddPS_Button
            // 
            this.AddPS_Button.Location = new System.Drawing.Point(15, 146);
            this.AddPS_Button.Name = "AddPS_Button";
            this.AddPS_Button.Size = new System.Drawing.Size(161, 23);
            this.AddPS_Button.TabIndex = 8;
            this.AddPS_Button.Text = "Добавить ПО";
            this.AddPS_Button.UseVisualStyleBackColor = true;
            this.AddPS_Button.Click += new System.EventHandler(this.AddPS_Button_Click);
            // 
            // ChangePerefButton
            // 
            this.ChangePerefButton.Location = new System.Drawing.Point(182, 88);
            this.ChangePerefButton.Name = "ChangePerefButton";
            this.ChangePerefButton.Size = new System.Drawing.Size(175, 23);
            this.ChangePerefButton.TabIndex = 9;
            this.ChangePerefButton.Text = "Редактировать периферию";
            this.ChangePerefButton.UseVisualStyleBackColor = true;
            this.ChangePerefButton.Click += new System.EventHandler(this.ChangePerefButton_Click);
            // 
            // ChangePC_Button
            // 
            this.ChangePC_Button.Location = new System.Drawing.Point(182, 117);
            this.ChangePC_Button.Name = "ChangePC_Button";
            this.ChangePC_Button.Size = new System.Drawing.Size(175, 23);
            this.ChangePC_Button.TabIndex = 10;
            this.ChangePC_Button.Text = "Редактирвать комплектующие";
            this.ChangePC_Button.UseVisualStyleBackColor = true;
            this.ChangePC_Button.Click += new System.EventHandler(this.ChangePC_Button_Click);
            // 
            // ChangePS_Button
            // 
            this.ChangePS_Button.Location = new System.Drawing.Point(182, 146);
            this.ChangePS_Button.Name = "ChangePS_Button";
            this.ChangePS_Button.Size = new System.Drawing.Size(175, 23);
            this.ChangePS_Button.TabIndex = 11;
            this.ChangePS_Button.Text = "Редактировать ПО";
            this.ChangePS_Button.UseVisualStyleBackColor = true;
            this.ChangePS_Button.Click += new System.EventHandler(this.ChangePS_Button_Click);
            // 
            // DeletePerefButton
            // 
            this.DeletePerefButton.Location = new System.Drawing.Point(363, 88);
            this.DeletePerefButton.Name = "DeletePerefButton";
            this.DeletePerefButton.Size = new System.Drawing.Size(175, 23);
            this.DeletePerefButton.TabIndex = 12;
            this.DeletePerefButton.Text = "Удалить периферию";
            this.DeletePerefButton.UseVisualStyleBackColor = true;
            this.DeletePerefButton.Click += new System.EventHandler(this.DeletePerefButton_Click);
            // 
            // DeletePC_Button
            // 
            this.DeletePC_Button.Location = new System.Drawing.Point(363, 117);
            this.DeletePC_Button.Name = "DeletePC_Button";
            this.DeletePC_Button.Size = new System.Drawing.Size(175, 23);
            this.DeletePC_Button.TabIndex = 13;
            this.DeletePC_Button.Text = "Удалить комплектующие";
            this.DeletePC_Button.UseVisualStyleBackColor = true;
            this.DeletePC_Button.Click += new System.EventHandler(this.DeletePC_Button_Click);
            // 
            // DeletePS_Button
            // 
            this.DeletePS_Button.Location = new System.Drawing.Point(363, 146);
            this.DeletePS_Button.Name = "DeletePS_Button";
            this.DeletePS_Button.Size = new System.Drawing.Size(175, 23);
            this.DeletePS_Button.TabIndex = 14;
            this.DeletePS_Button.Text = "Удалить ПО";
            this.DeletePS_Button.UseVisualStyleBackColor = true;
            this.DeletePS_Button.Click += new System.EventHandler(this.DeletePS_Button_Click);
            // 
            // AddComputerButton
            // 
            this.AddComputerButton.Location = new System.Drawing.Point(15, 175);
            this.AddComputerButton.Name = "AddComputerButton";
            this.AddComputerButton.Size = new System.Drawing.Size(518, 23);
            this.AddComputerButton.TabIndex = 15;
            this.AddComputerButton.Text = "Добавить компьютер";
            this.AddComputerButton.UseVisualStyleBackColor = true;
            this.AddComputerButton.Click += new System.EventHandler(this.AddComputerButton_Click);
            // 
            // Add_Computer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 206);
            this.Controls.Add(this.AddComputerButton);
            this.Controls.Add(this.DeletePS_Button);
            this.Controls.Add(this.DeletePC_Button);
            this.Controls.Add(this.DeletePerefButton);
            this.Controls.Add(this.ChangePS_Button);
            this.Controls.Add(this.ChangePC_Button);
            this.Controls.Add(this.ChangePerefButton);
            this.Controls.Add(this.AddPS_Button);
            this.Controls.Add(this.AddPC_Button);
            this.Controls.Add(this.AddPerefButton);
            this.Controls.Add(this.PS_ComboBox);
            this.Controls.Add(this.PC_ComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PerefComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Add_Computer_Form";
            this.Text = "AddComputerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PerefComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PC_ComboBox;
        private System.Windows.Forms.ComboBox PS_ComboBox;
        private System.Windows.Forms.Button AddPerefButton;
        private System.Windows.Forms.Button AddPC_Button;
        private System.Windows.Forms.Button AddPS_Button;
        private System.Windows.Forms.Button ChangePerefButton;
        private System.Windows.Forms.Button ChangePC_Button;
        private System.Windows.Forms.Button ChangePS_Button;
        private System.Windows.Forms.Button DeletePerefButton;
        private System.Windows.Forms.Button DeletePC_Button;
        private System.Windows.Forms.Button DeletePS_Button;
        private System.Windows.Forms.Button AddComputerButton;
    }
}