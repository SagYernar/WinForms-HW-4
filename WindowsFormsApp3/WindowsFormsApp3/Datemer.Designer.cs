namespace Homework_WF_4
{
    partial class Datamer
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.yearsRadioButton = new System.Windows.Forms.RadioButton();
            this.monthsRadioButton = new System.Windows.Forms.RadioButton();
            this.daysRadioButton = new System.Windows.Forms.RadioButton();
            this.minutesRadioButton = new System.Windows.Forms.RadioButton();
            this.secondsRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.incorrectDateLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTextBox.Location = new System.Drawing.Point(50, 29);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(210, 26);
            this.dateTextBox.TabIndex = 0;
            this.dateTextBox.Text = " (дд.мм.гггг)";
            this.dateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateTextBox.Click += new System.EventHandler(this.DateTextBox_Click);
            // 
            // yearsRadioButton
            // 
            this.yearsRadioButton.AutoSize = true;
            this.yearsRadioButton.Checked = true;
            this.yearsRadioButton.Location = new System.Drawing.Point(65, 91);
            this.yearsRadioButton.Name = "yearsRadioButton";
            this.yearsRadioButton.Size = new System.Drawing.Size(62, 17);
            this.yearsRadioButton.TabIndex = 1;
            this.yearsRadioButton.TabStop = true;
            this.yearsRadioButton.Text = "в годах";
            this.yearsRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthsRadioButton
            // 
            this.monthsRadioButton.AutoSize = true;
            this.monthsRadioButton.Location = new System.Drawing.Point(183, 91);
            this.monthsRadioButton.Name = "monthsRadioButton";
            this.monthsRadioButton.Size = new System.Drawing.Size(77, 17);
            this.monthsRadioButton.TabIndex = 2;
            this.monthsRadioButton.TabStop = true;
            this.monthsRadioButton.Text = "в месяцах";
            this.monthsRadioButton.UseVisualStyleBackColor = true;
            // 
            // daysRadioButton
            // 
            this.daysRadioButton.AutoSize = true;
            this.daysRadioButton.Location = new System.Drawing.Point(51, 139);
            this.daysRadioButton.Name = "daysRadioButton";
            this.daysRadioButton.Size = new System.Drawing.Size(57, 17);
            this.daysRadioButton.TabIndex = 3;
            this.daysRadioButton.TabStop = true;
            this.daysRadioButton.Text = "в днях";
            this.daysRadioButton.UseVisualStyleBackColor = true;
            // 
            // minutesRadioButton
            // 
            this.minutesRadioButton.AutoSize = true;
            this.minutesRadioButton.Location = new System.Drawing.Point(203, 139);
            this.minutesRadioButton.Name = "minutesRadioButton";
            this.minutesRadioButton.Size = new System.Drawing.Size(75, 17);
            this.minutesRadioButton.TabIndex = 4;
            this.minutesRadioButton.TabStop = true;
            this.minutesRadioButton.Text = "в минутах";
            this.minutesRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondsRadioButton
            // 
            this.secondsRadioButton.AutoSize = true;
            this.secondsRadioButton.Location = new System.Drawing.Point(112, 173);
            this.secondsRadioButton.Name = "secondsRadioButton";
            this.secondsRadioButton.Size = new System.Drawing.Size(80, 17);
            this.secondsRadioButton.TabIndex = 5;
            this.secondsRadioButton.TabStop = true;
            this.secondsRadioButton.Text = "в секундах";
            this.secondsRadioButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(114, 116);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 40);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(154, 230);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 7;
            // 
            // incorrectDateLabel
            // 
            this.incorrectDateLabel.AutoSize = true;
            this.incorrectDateLabel.Location = new System.Drawing.Point(106, 58);
            this.incorrectDateLabel.Name = "incorrectDateLabel";
            this.incorrectDateLabel.Size = new System.Drawing.Size(86, 13);
            this.incorrectDateLabel.TabIndex = 9;
            this.incorrectDateLabel.Text = "Неверная дата!";
            this.incorrectDateLabel.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(62, 230);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(84, 17);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "Результат: ";
            // 
            // Datamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 288);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secondsRadioButton);
            this.Controls.Add(this.incorrectDateLabel);
            this.Controls.Add(this.minutesRadioButton);
            this.Controls.Add(this.daysRadioButton);
            this.Controls.Add(this.monthsRadioButton);
            this.Controls.Add(this.result);
            this.Controls.Add(this.yearsRadioButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.dateTextBox);
            this.Name = "Datamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.RadioButton yearsRadioButton;
        private System.Windows.Forms.RadioButton monthsRadioButton;
        private System.Windows.Forms.RadioButton daysRadioButton;
        private System.Windows.Forms.RadioButton minutesRadioButton;
        private System.Windows.Forms.RadioButton secondsRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label incorrectDateLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

