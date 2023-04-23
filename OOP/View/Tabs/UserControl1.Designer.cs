
namespace OOP.View.Tabs
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.selectedCustomerLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idCustomerTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.customersLabel = new System.Windows.Forms.Label();
            this.removeCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(432, 119);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(303, 122);
            this.addressTextBox.TabIndex = 30;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(355, 119);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(64, 17);
            this.addressLabel.TabIndex = 29;
            this.addressLabel.Text = "Address:";
            // 
            // selectedCustomerLabel
            // 
            this.selectedCustomerLabel.AutoSize = true;
            this.selectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedCustomerLabel.Location = new System.Drawing.Point(355, 9);
            this.selectedCustomerLabel.Name = "selectedCustomerLabel";
            this.selectedCustomerLabel.Size = new System.Drawing.Size(147, 17);
            this.selectedCustomerLabel.TabIndex = 28;
            this.selectedCustomerLabel.Text = "Selected customer:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(355, 85);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(75, 17);
            this.fullNameLabel.TabIndex = 27;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(355, 50);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 17);
            this.idLabel.TabIndex = 26;
            this.idLabel.Text = "ID:";
            // 
            // idCustomerTextBox
            // 
            this.idCustomerTextBox.Location = new System.Drawing.Point(432, 47);
            this.idCustomerTextBox.Name = "idCustomerTextBox";
            this.idCustomerTextBox.ReadOnly = true;
            this.idCustomerTextBox.Size = new System.Drawing.Size(133, 22);
            this.idCustomerTextBox.TabIndex = 25;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(432, 82);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(303, 22);
            this.fullNameTextBox.TabIndex = 24;
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersLabel.Location = new System.Drawing.Point(11, 9);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(89, 17);
            this.customersLabel.TabIndex = 23;
            this.customersLabel.Text = "Customers:";
            // 
            // removeCustomerButton
            // 
            this.removeCustomerButton.Location = new System.Drawing.Point(133, 487);
            this.removeCustomerButton.Name = "removeCustomerButton";
            this.removeCustomerButton.Size = new System.Drawing.Size(115, 54);
            this.removeCustomerButton.TabIndex = 22;
            this.removeCustomerButton.Text = "Remove";
            this.removeCustomerButton.UseVisualStyleBackColor = true;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(12, 487);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(115, 54);
            this.addCustomerButton.TabIndex = 21;
            this.addCustomerButton.Text = "Add";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            // 
            // customersListBox
            // 
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.ItemHeight = 16;
            this.customersListBox.Location = new System.Drawing.Point(14, 29);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(335, 452);
            this.customersListBox.TabIndex = 20;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.selectedCustomerLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idCustomerTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.customersLabel);
            this.Controls.Add(this.removeCustomerButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.customersListBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(749, 556);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label selectedCustomerLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idCustomerTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.Button removeCustomerButton;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.ListBox customersListBox;
    }
}
