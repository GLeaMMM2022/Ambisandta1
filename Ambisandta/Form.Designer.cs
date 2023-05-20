namespace Ambisandta
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.buttonRules = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelOssetian1 = new System.Windows.Forms.Label();
            this.listBoxOssetian = new System.Windows.Forms.ListBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRussian = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRules
            // 
            this.buttonRules.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonRules.Location = new System.Drawing.Point(1404, 23);
            this.buttonRules.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(172, 63);
            this.buttonRules.TabIndex = 1;
            this.buttonRules.Text = "Правила";
            this.buttonRules.UseVisualStyleBackColor = true;
            // 
            // labelOssetian1
            // 
            this.labelOssetian1.AutoSize = true;
            this.labelOssetian1.Location = new System.Drawing.Point(43, 156);
            this.labelOssetian1.Name = "labelOssetian1";
            this.labelOssetian1.Size = new System.Drawing.Size(278, 25);
            this.labelOssetian1.TabIndex = 8;
            this.labelOssetian1.Text = "Пословицы на осетинском";
            // 
            // listBoxOssetian
            // 
            this.listBoxOssetian.FormattingEnabled = true;
            this.listBoxOssetian.ItemHeight = 25;
            this.listBoxOssetian.Items.AddRange(new object[] {
            "Буцхаст уӕздан кӕны, уӕздан магуса кӕны, магуса та сӕфтмӕ цӕуы",
            "Ӕфсӕст стонджы не \'мбары"});
            this.listBoxOssetian.Location = new System.Drawing.Point(39, 184);
            this.listBoxOssetian.Name = "listBoxOssetian";
            this.listBoxOssetian.Size = new System.Drawing.Size(486, 379);
            this.listBoxOssetian.TabIndex = 10;
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 25;
            this.listBoxResults.Location = new System.Drawing.Point(947, 184);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(486, 379);
            this.listBoxResults.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(942, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Перевод пословиц";
            // 
            // comboBoxRussian
            // 
            this.comboBoxRussian.FormattingEnabled = true;
            this.comboBoxRussian.Items.AddRange(new object[] {
            "Баловень становится нежным, неженка - лодырем, а лодырь идёт к гибели"});
            this.comboBoxRussian.Location = new System.Drawing.Point(602, 184);
            this.comboBoxRussian.Name = "comboBoxRussian";
            this.comboBoxRussian.Size = new System.Drawing.Size(273, 33);
            this.comboBoxRussian.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 652);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 72);
            this.button1.TabIndex = 14;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1948, 916);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxRussian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.listBoxOssetian);
            this.Controls.Add(this.labelOssetian1);
            this.Controls.Add(this.buttonRules);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelOssetian1;
        private System.Windows.Forms.ListBox listBoxOssetian;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRussian;
        private System.Windows.Forms.Button button1;
    }
}

