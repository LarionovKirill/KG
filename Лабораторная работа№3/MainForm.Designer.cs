
namespace Лабораторная_работа_3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.createAxesButton = new System.Windows.Forms.Button();
            this.createFigureButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.shiftToRightButton = new System.Windows.Forms.Button();
            this.shiftToLeftButton = new System.Windows.Forms.Button();
            this.shiftToUpButton = new System.Windows.Forms.Button();
            this.shiftToDownButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.turnTo270Button = new System.Windows.Forms.Button();
            this.turnTo90Button = new System.Windows.Forms.Button();
            this.turnTo180Button = new System.Windows.Forms.Button();
            this.reflectionGroupBox = new System.Windows.Forms.GroupBox();
            this.reflectionYXButton = new System.Windows.Forms.Button();
            this.reflectionOYButton = new System.Windows.Forms.Button();
            this.reflectionOXButton = new System.Windows.Forms.Button();
            this.changingGroupBox = new System.Windows.Forms.GroupBox();
            this.decreaseButton = new System.Windows.Forms.Button();
            this.increaseButton = new System.Windows.Forms.Button();
            this.leftSteps = new System.Windows.Forms.CheckBox();
            this.rightSteps = new System.Windows.Forms.CheckBox();
            this.upSteps = new System.Windows.Forms.CheckBox();
            this.downSteps = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.reflectionGroupBox.SuspendLayout();
            this.changingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(576, 543);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // createAxesButton
            // 
            this.createAxesButton.Location = new System.Drawing.Point(586, 12);
            this.createAxesButton.Name = "createAxesButton";
            this.createAxesButton.Size = new System.Drawing.Size(144, 36);
            this.createAxesButton.TabIndex = 1;
            this.createAxesButton.Text = "Нарисовать оси";
            this.createAxesButton.UseVisualStyleBackColor = true;
            this.createAxesButton.Click += new System.EventHandler(this.СreateAxesButton_Click);
            // 
            // createFigureButton
            // 
            this.createFigureButton.Location = new System.Drawing.Point(736, 12);
            this.createFigureButton.Name = "createFigureButton";
            this.createFigureButton.Size = new System.Drawing.Size(169, 36);
            this.createFigureButton.TabIndex = 2;
            this.createFigureButton.Text = "Нарисовать фигуру";
            this.createFigureButton.UseVisualStyleBackColor = true;
            this.createFigureButton.Click += new System.EventHandler(this.CreateFigureButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(911, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(144, 36);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // shiftToRightButton
            // 
            this.shiftToRightButton.Location = new System.Drawing.Point(16, 30);
            this.shiftToRightButton.Name = "shiftToRightButton";
            this.shiftToRightButton.Size = new System.Drawing.Size(99, 44);
            this.shiftToRightButton.TabIndex = 4;
            this.shiftToRightButton.Text = "По оси OX вправо";
            this.shiftToRightButton.UseVisualStyleBackColor = true;
            this.shiftToRightButton.Click += new System.EventHandler(this.shiftToRightButton_Click);
            // 
            // shiftToLeftButton
            // 
            this.shiftToLeftButton.Location = new System.Drawing.Point(16, 98);
            this.shiftToLeftButton.Name = "shiftToLeftButton";
            this.shiftToLeftButton.Size = new System.Drawing.Size(99, 44);
            this.shiftToLeftButton.TabIndex = 5;
            this.shiftToLeftButton.Text = "По оси OX влево";
            this.shiftToLeftButton.UseVisualStyleBackColor = true;
            this.shiftToLeftButton.Click += new System.EventHandler(this.ShiftToLeftButton_Click);
            // 
            // shiftToUpButton
            // 
            this.shiftToUpButton.Location = new System.Drawing.Point(121, 30);
            this.shiftToUpButton.Name = "shiftToUpButton";
            this.shiftToUpButton.Size = new System.Drawing.Size(99, 44);
            this.shiftToUpButton.TabIndex = 6;
            this.shiftToUpButton.Text = "По оси OY вверх";
            this.shiftToUpButton.UseVisualStyleBackColor = true;
            this.shiftToUpButton.Click += new System.EventHandler(this.ShiftToUpButton_Click);
            // 
            // shiftToDownButton
            // 
            this.shiftToDownButton.Location = new System.Drawing.Point(121, 98);
            this.shiftToDownButton.Name = "shiftToDownButton";
            this.shiftToDownButton.Size = new System.Drawing.Size(99, 44);
            this.shiftToDownButton.TabIndex = 7;
            this.shiftToDownButton.Text = "По оси OY вниз";
            this.shiftToDownButton.UseVisualStyleBackColor = true;
            this.shiftToDownButton.Click += new System.EventHandler(this.ShiftToDownButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(788, 499);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(63, 27);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.shiftToRightButton);
            this.groupBox.Controls.Add(this.shiftToLeftButton);
            this.groupBox.Controls.Add(this.shiftToUpButton);
            this.groupBox.Controls.Add(this.shiftToDownButton);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.Location = new System.Drawing.Point(586, 67);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(233, 168);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Сдвиг";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.turnTo270Button);
            this.groupBox2.Controls.Add(this.turnTo90Button);
            this.groupBox2.Controls.Add(this.turnTo180Button);
            this.groupBox2.Location = new System.Drawing.Point(839, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 168);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поворот";
            // 
            // turnTo270Button
            // 
            this.turnTo270Button.Location = new System.Drawing.Point(29, 123);
            this.turnTo270Button.Name = "turnTo270Button";
            this.turnTo270Button.Size = new System.Drawing.Size(144, 31);
            this.turnTo270Button.TabIndex = 14;
            this.turnTo270Button.Text = "Поворот на 270";
            this.turnTo270Button.UseVisualStyleBackColor = true;
            this.turnTo270Button.Click += new System.EventHandler(this.TurnTo270Button_Click);
            // 
            // turnTo90Button
            // 
            this.turnTo90Button.Location = new System.Drawing.Point(29, 30);
            this.turnTo90Button.Name = "turnTo90Button";
            this.turnTo90Button.Size = new System.Drawing.Size(144, 31);
            this.turnTo90Button.TabIndex = 12;
            this.turnTo90Button.Text = "Поворот на 90";
            this.turnTo90Button.UseVisualStyleBackColor = true;
            this.turnTo90Button.Click += new System.EventHandler(this.TurnTo90Button_Click);
            // 
            // turnTo180Button
            // 
            this.turnTo180Button.Location = new System.Drawing.Point(29, 77);
            this.turnTo180Button.Name = "turnTo180Button";
            this.turnTo180Button.Size = new System.Drawing.Size(144, 31);
            this.turnTo180Button.TabIndex = 13;
            this.turnTo180Button.Text = "Поворот на 180";
            this.turnTo180Button.UseVisualStyleBackColor = true;
            this.turnTo180Button.Click += new System.EventHandler(this.TurnTo180Button_Click);
            // 
            // reflectionGroupBox
            // 
            this.reflectionGroupBox.Controls.Add(this.reflectionYXButton);
            this.reflectionGroupBox.Controls.Add(this.reflectionOYButton);
            this.reflectionGroupBox.Controls.Add(this.reflectionOXButton);
            this.reflectionGroupBox.Location = new System.Drawing.Point(586, 251);
            this.reflectionGroupBox.Name = "reflectionGroupBox";
            this.reflectionGroupBox.Size = new System.Drawing.Size(233, 160);
            this.reflectionGroupBox.TabIndex = 12;
            this.reflectionGroupBox.TabStop = false;
            this.reflectionGroupBox.Text = "Отображение";
            // 
            // reflectionYXButton
            // 
            this.reflectionYXButton.Location = new System.Drawing.Point(37, 123);
            this.reflectionYXButton.Name = "reflectionYXButton";
            this.reflectionYXButton.Size = new System.Drawing.Size(144, 31);
            this.reflectionYXButton.TabIndex = 2;
            this.reflectionYXButton.Text = "Относительно y=x";
            this.reflectionYXButton.UseVisualStyleBackColor = true;
            this.reflectionYXButton.Click += new System.EventHandler(this.reflectionYXButton_Click);
            // 
            // reflectionOYButton
            // 
            this.reflectionOYButton.Location = new System.Drawing.Point(37, 76);
            this.reflectionOYButton.Name = "reflectionOYButton";
            this.reflectionOYButton.Size = new System.Drawing.Size(144, 31);
            this.reflectionOYButton.TabIndex = 1;
            this.reflectionOYButton.Text = "Относительно OY";
            this.reflectionOYButton.UseVisualStyleBackColor = true;
            this.reflectionOYButton.Click += new System.EventHandler(this.ReflectionOYButton_Click);
            // 
            // reflectionOXButton
            // 
            this.reflectionOXButton.Location = new System.Drawing.Point(37, 30);
            this.reflectionOXButton.Name = "reflectionOXButton";
            this.reflectionOXButton.Size = new System.Drawing.Size(144, 31);
            this.reflectionOXButton.TabIndex = 0;
            this.reflectionOXButton.Text = "Относительно OX";
            this.reflectionOXButton.UseVisualStyleBackColor = true;
            this.reflectionOXButton.Click += new System.EventHandler(this.ReflectionOXButton_Click);
            // 
            // changingGroupBox
            // 
            this.changingGroupBox.Controls.Add(this.decreaseButton);
            this.changingGroupBox.Controls.Add(this.increaseButton);
            this.changingGroupBox.Location = new System.Drawing.Point(839, 258);
            this.changingGroupBox.Name = "changingGroupBox";
            this.changingGroupBox.Size = new System.Drawing.Size(216, 153);
            this.changingGroupBox.TabIndex = 13;
            this.changingGroupBox.TabStop = false;
            this.changingGroupBox.Text = "Масштабирование";
            // 
            // decreaseButton
            // 
            this.decreaseButton.Location = new System.Drawing.Point(29, 90);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(144, 31);
            this.decreaseButton.TabIndex = 1;
            this.decreaseButton.Text = "Уменьшить";
            this.decreaseButton.UseVisualStyleBackColor = true;
            this.decreaseButton.Click += new System.EventHandler(this.decreaseButton_Click);
            // 
            // increaseButton
            // 
            this.increaseButton.Location = new System.Drawing.Point(29, 33);
            this.increaseButton.Name = "increaseButton";
            this.increaseButton.Size = new System.Drawing.Size(144, 31);
            this.increaseButton.TabIndex = 0;
            this.increaseButton.Text = "Увеличить";
            this.increaseButton.UseVisualStyleBackColor = true;
            this.increaseButton.Click += new System.EventHandler(this.increaseButton_Click);
            // 
            // leftSteps
            // 
            this.leftSteps.AutoSize = true;
            this.leftSteps.Location = new System.Drawing.Point(633, 432);
            this.leftSteps.Name = "leftSteps";
            this.leftSteps.Size = new System.Drawing.Size(155, 21);
            this.leftSteps.TabIndex = 14;
            this.leftSteps.Text = "Непрерывно влево";
            this.leftSteps.UseVisualStyleBackColor = true;
            this.leftSteps.Click += new System.EventHandler(this.leftSteps_CheckedChanged);
            // 
            // rightSteps
            // 
            this.rightSteps.AutoSize = true;
            this.rightSteps.Location = new System.Drawing.Point(632, 472);
            this.rightSteps.Name = "rightSteps";
            this.rightSteps.Size = new System.Drawing.Size(163, 21);
            this.rightSteps.TabIndex = 15;
            this.rightSteps.Text = "Непрерывно вправо";
            this.rightSteps.UseVisualStyleBackColor = true;
            this.rightSteps.Click += new System.EventHandler(this.rightSteps_CheckedChanged);
            // 
            // upSteps
            // 
            this.upSteps.AutoSize = true;
            this.upSteps.Location = new System.Drawing.Point(839, 432);
            this.upSteps.Name = "upSteps";
            this.upSteps.Size = new System.Drawing.Size(153, 21);
            this.upSteps.TabIndex = 16;
            this.upSteps.Text = "Непрерывно вверх";
            this.upSteps.UseVisualStyleBackColor = true;
            this.upSteps.Click += new System.EventHandler(this.upSteps_CheckedChanged);
            // 
            // downSteps
            // 
            this.downSteps.AutoSize = true;
            this.downSteps.Location = new System.Drawing.Point(839, 472);
            this.downSteps.Name = "downSteps";
            this.downSteps.Size = new System.Drawing.Size(147, 21);
            this.downSteps.TabIndex = 17;
            this.downSteps.Text = "Непрерывно вниз";
            this.downSteps.UseVisualStyleBackColor = true;
            this.downSteps.Click += new System.EventHandler(this.downSteps_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.downSteps);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.upSteps);
            this.Controls.Add(this.rightSteps);
            this.Controls.Add(this.leftSteps);
            this.Controls.Add(this.changingGroupBox);
            this.Controls.Add(this.reflectionGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.createFigureButton);
            this.Controls.Add(this.createAxesButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.reflectionGroupBox.ResumeLayout(false);
            this.changingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button createAxesButton;
        private System.Windows.Forms.Button createFigureButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button shiftToRightButton;
        private System.Windows.Forms.Button shiftToLeftButton;
        private System.Windows.Forms.Button shiftToUpButton;
        private System.Windows.Forms.Button shiftToDownButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button turnTo270Button;
        private System.Windows.Forms.Button turnTo90Button;
        private System.Windows.Forms.Button turnTo180Button;
        private System.Windows.Forms.GroupBox reflectionGroupBox;
        private System.Windows.Forms.Button reflectionYXButton;
        private System.Windows.Forms.Button reflectionOYButton;
        private System.Windows.Forms.Button reflectionOXButton;
        private System.Windows.Forms.GroupBox changingGroupBox;
        private System.Windows.Forms.Button increaseButton;
        private System.Windows.Forms.Button decreaseButton;
        private System.Windows.Forms.CheckBox leftSteps;
        private System.Windows.Forms.CheckBox rightSteps;
        private System.Windows.Forms.CheckBox upSteps;
        private System.Windows.Forms.CheckBox downSteps;
    }
}