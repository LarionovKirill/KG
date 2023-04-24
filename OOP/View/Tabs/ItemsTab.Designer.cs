
namespace OOP.View.Tabs
{
    partial class ItemsTab
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
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.descriptionItemTextBox = new System.Windows.Forms.TextBox();
            this.nameItemTextBox = new System.Windows.Forms.TextBox();
            this.costItemTextBox = new System.Windows.Forms.TextBox();
            this.idItemTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.selectedItemLabel = new System.Windows.Forms.Label();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 16;
            this.itemListBox.Location = new System.Drawing.Point(12, 29);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(289, 452);
            this.itemListBox.TabIndex = 0;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.ItemListBox_SelectedIndexChanged);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(10, 487);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(115, 54);
            this.addItemButton.TabIndex = 1;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // descriptionItemTextBox
            // 
            this.descriptionItemTextBox.Location = new System.Drawing.Point(320, 271);
            this.descriptionItemTextBox.Multiline = true;
            this.descriptionItemTextBox.Name = "descriptionItemTextBox";
            this.descriptionItemTextBox.Size = new System.Drawing.Size(377, 119);
            this.descriptionItemTextBox.TabIndex = 3;
            this.descriptionItemTextBox.TextChanged += new System.EventHandler(this.DescriptionItemTextBox_TextChanged);
            // 
            // nameItemTextBox
            // 
            this.nameItemTextBox.Location = new System.Drawing.Point(320, 139);
            this.nameItemTextBox.Multiline = true;
            this.nameItemTextBox.Name = "nameItemTextBox";
            this.nameItemTextBox.Size = new System.Drawing.Size(377, 96);
            this.nameItemTextBox.TabIndex = 4;
            this.nameItemTextBox.TextChanged += new System.EventHandler(this.NameItemTextBox_TextChanged);
            // 
            // costItemTextBox
            // 
            this.costItemTextBox.Location = new System.Drawing.Point(363, 84);
            this.costItemTextBox.Name = "costItemTextBox";
            this.costItemTextBox.Size = new System.Drawing.Size(129, 22);
            this.costItemTextBox.TabIndex = 5;
            this.costItemTextBox.TextChanged += new System.EventHandler(this.СostItemTextBox_TextChanged);
            // 
            // idItemTextBox
            // 
            this.idItemTextBox.Location = new System.Drawing.Point(363, 49);
            this.idItemTextBox.Name = "idItemTextBox";
            this.idItemTextBox.ReadOnly = true;
            this.idItemTextBox.Size = new System.Drawing.Size(129, 22);
            this.idItemTextBox.TabIndex = 6;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(317, 52);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 17);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(317, 87);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(40, 17);
            this.costLabel.TabIndex = 8;
            this.costLabel.Text = "Cost:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(317, 119);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(317, 251);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description:";
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsLabel.Location = new System.Drawing.Point(9, 9);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(51, 17);
            this.itemsLabel.TabIndex = 11;
            this.itemsLabel.Text = "Items:";
            // 
            // selectedItemLabel
            // 
            this.selectedItemLabel.AutoSize = true;
            this.selectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedItemLabel.Location = new System.Drawing.Point(317, 11);
            this.selectedItemLabel.Name = "selectedItemLabel";
            this.selectedItemLabel.Size = new System.Drawing.Size(111, 17);
            this.selectedItemLabel.TabIndex = 12;
            this.selectedItemLabel.Text = "Selected Item:";
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(131, 487);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(115, 54);
            this.removeItemButton.TabIndex = 2;
            this.removeItemButton.Text = "Remove";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectedItemLabel);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idItemTextBox);
            this.Controls.Add(this.costItemTextBox);
            this.Controls.Add(this.nameItemTextBox);
            this.Controls.Add(this.descriptionItemTextBox);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemListBox);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(719, 553);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox descriptionItemTextBox;
        private System.Windows.Forms.TextBox nameItemTextBox;
        private System.Windows.Forms.TextBox costItemTextBox;
        private System.Windows.Forms.TextBox idItemTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Label selectedItemLabel;
        private System.Windows.Forms.Button removeItemButton;
    }
}
