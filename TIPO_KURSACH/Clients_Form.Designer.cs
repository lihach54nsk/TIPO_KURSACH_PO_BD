namespace TIPO_KURSACH
{
    partial class Clients_Form
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
            this.ClientsComputersDataGridView = new System.Windows.Forms.DataGridView();
            this.otchestvoClientTextBox = new System.Windows.Forms.TextBox();
            this.firstNameClientTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameClientTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.computerNumberTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.UseComputerButton = new System.Windows.Forms.Button();
            this.ReserveComputerButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.DeleteReserveComputerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsComputersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsComputersDataGridView
            // 
            this.ClientsComputersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsComputersDataGridView.Location = new System.Drawing.Point(301, 12);
            this.ClientsComputersDataGridView.Name = "ClientsComputersDataGridView";
            this.ClientsComputersDataGridView.Size = new System.Drawing.Size(487, 215);
            this.ClientsComputersDataGridView.TabIndex = 0;
            // 
            // otchestvoClientTextBox
            // 
            this.otchestvoClientTextBox.Location = new System.Drawing.Point(131, 63);
            this.otchestvoClientTextBox.Name = "otchestvoClientTextBox";
            this.otchestvoClientTextBox.Size = new System.Drawing.Size(164, 20);
            this.otchestvoClientTextBox.TabIndex = 15;
            // 
            // firstNameClientTextBox
            // 
            this.firstNameClientTextBox.Location = new System.Drawing.Point(131, 37);
            this.firstNameClientTextBox.Name = "firstNameClientTextBox";
            this.firstNameClientTextBox.Size = new System.Drawing.Size(164, 20);
            this.firstNameClientTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Отчество: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Имя: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Фамилия: ";
            // 
            // lastNameClientTextBox
            // 
            this.lastNameClientTextBox.Location = new System.Drawing.Point(131, 11);
            this.lastNameClientTextBox.Name = "lastNameClientTextBox";
            this.lastNameClientTextBox.Size = new System.Drawing.Size(164, 20);
            this.lastNameClientTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Начало брони: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Конец брони: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Номер компьютера: ";
            // 
            // computerNumberTextBox
            // 
            this.computerNumberTextBox.Location = new System.Drawing.Point(131, 89);
            this.computerNumberTextBox.Name = "computerNumberTextBox";
            this.computerNumberTextBox.Size = new System.Drawing.Size(164, 20);
            this.computerNumberTextBox.TabIndex = 21;
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimePickerBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBegin.Location = new System.Drawing.Point(131, 118);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerBegin.TabIndex = 22;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(131, 144);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerEnd.TabIndex = 23;
            // 
            // UseComputerButton
            // 
            this.UseComputerButton.Location = new System.Drawing.Point(12, 177);
            this.UseComputerButton.Name = "UseComputerButton";
            this.UseComputerButton.Size = new System.Drawing.Size(127, 23);
            this.UseComputerButton.TabIndex = 24;
            this.UseComputerButton.Text = "Занять";
            this.UseComputerButton.UseVisualStyleBackColor = true;
            this.UseComputerButton.Click += new System.EventHandler(this.UseComputerButton_Click);
            // 
            // ReserveComputerButton
            // 
            this.ReserveComputerButton.Location = new System.Drawing.Point(145, 177);
            this.ReserveComputerButton.Name = "ReserveComputerButton";
            this.ReserveComputerButton.Size = new System.Drawing.Size(150, 23);
            this.ReserveComputerButton.TabIndex = 25;
            this.ReserveComputerButton.Text = "Бронь";
            this.ReserveComputerButton.UseVisualStyleBackColor = true;
            this.ReserveComputerButton.Click += new System.EventHandler(this.ReserveComputerButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(12, 206);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(127, 23);
            this.CheckButton.TabIndex = 26;
            this.CheckButton.Text = "Счёт";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // DeleteReserveComputerButton
            // 
            this.DeleteReserveComputerButton.Location = new System.Drawing.Point(145, 206);
            this.DeleteReserveComputerButton.Name = "DeleteReserveComputerButton";
            this.DeleteReserveComputerButton.Size = new System.Drawing.Size(150, 23);
            this.DeleteReserveComputerButton.TabIndex = 27;
            this.DeleteReserveComputerButton.Text = "Снять бронь";
            this.DeleteReserveComputerButton.UseVisualStyleBackColor = true;
            this.DeleteReserveComputerButton.Click += new System.EventHandler(this.DeleteReserveComputerButton_Click);
            // 
            // Clients_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 239);
            this.Controls.Add(this.DeleteReserveComputerButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.ReserveComputerButton);
            this.Controls.Add(this.UseComputerButton);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerBegin);
            this.Controls.Add(this.computerNumberTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.otchestvoClientTextBox);
            this.Controls.Add(this.firstNameClientTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameClientTextBox);
            this.Controls.Add(this.ClientsComputersDataGridView);
            this.Name = "Clients_Form";
            this.Text = "Clients";
            ((System.ComponentModel.ISupportInitialize)(this.ClientsComputersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientsComputersDataGridView;
        private System.Windows.Forms.TextBox otchestvoClientTextBox;
        private System.Windows.Forms.TextBox firstNameClientTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameClientTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox computerNumberTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button UseComputerButton;
        private System.Windows.Forms.Button ReserveComputerButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button DeleteReserveComputerButton;
    }
}