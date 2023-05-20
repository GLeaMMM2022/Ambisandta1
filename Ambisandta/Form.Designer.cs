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
            this.buttonRussian1 = new System.Windows.Forms.Button();
            this.buttonRussian2 = new System.Windows.Forms.Button();
            this.labelOssetian1 = new System.Windows.Forms.Label();
            this.labelOssetian2 = new System.Windows.Forms.Label();
            this.listBoxOssetian = new System.Windows.Forms.ListBox();
            this.listBoxRussian = new System.Windows.Forms.ListBox();
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
            // buttonRussian1
            // 
            this.buttonRussian1.Location = new System.Drawing.Point(856, 163);
            this.buttonRussian1.Name = "buttonRussian1";
            this.buttonRussian1.Size = new System.Drawing.Size(305, 136);
            this.buttonRussian1.TabIndex = 5;
            this.buttonRussian1.Text = "Баловень становится нежным, неженка - лодырем, а лодырь идёт к гибели";
            this.buttonRussian1.UseVisualStyleBackColor = true;
            this.buttonRussian1.Click += new System.EventHandler(this.buttonRussian1_Click);
            // 
            // buttonRussian2
            // 
            this.buttonRussian2.Location = new System.Drawing.Point(856, 356);
            this.buttonRussian2.Name = "buttonRussian2";
            this.buttonRussian2.Size = new System.Drawing.Size(305, 136);
            this.buttonRussian2.TabIndex = 6;
            this.buttonRussian2.Text = "Сытый голодного не разумеет";
            this.buttonRussian2.UseVisualStyleBackColor = true;
            this.buttonRussian2.Click += new System.EventHandler(this.buttonRussian1_Click);
            // 
            // labelOssetian1
            // 
            this.labelOssetian1.AutoSize = true;
            this.labelOssetian1.Location = new System.Drawing.Point(289, 210);
            this.labelOssetian1.Name = "labelOssetian1";
            this.labelOssetian1.Size = new System.Drawing.Size(356, 75);
            this.labelOssetian1.TabIndex = 8;
            this.labelOssetian1.Text = "Буцхаст уӕздан кӕны, уӕздан\r\n магуса кӕны, магуса та сӕфтмӕ\r\n цӕуы";
            // 
            // labelOssetian2
            // 
            this.labelOssetian2.AutoSize = true;
            this.labelOssetian2.Location = new System.Drawing.Point(289, 421);
            this.labelOssetian2.Name = "labelOssetian2";
            this.labelOssetian2.Size = new System.Drawing.Size(300, 25);
            this.labelOssetian2.TabIndex = 9;
            this.labelOssetian2.Text = "Ӕфсӕст стонджы не \'мбары";
            // 
            // listBoxOssetian
            // 
            this.listBoxOssetian.FormattingEnabled = true;
            this.listBoxOssetian.ItemHeight = 25;
            this.listBoxOssetian.Items.AddRange(new object[] {
            "Буцхаст уӕздан кӕны, уӕздан",
            " магуса кӕны, магуса та сӕфтмӕ",
            " цӕуы"});
            this.listBoxOssetian.Location = new System.Drawing.Point(294, 580);
            this.listBoxOssetian.Name = "listBoxOssetian";
            this.listBoxOssetian.Size = new System.Drawing.Size(369, 154);
            this.listBoxOssetian.TabIndex = 10;
            // 
            // listBoxRussian
            // 
            this.listBoxRussian.FormattingEnabled = true;
            this.listBoxRussian.ItemHeight = 25;
            this.listBoxRussian.Items.AddRange(new object[] {
            "Баловень становится нежным, неженка - лодырем, а лодырь идёт к гибели"});
            this.listBoxRussian.Location = new System.Drawing.Point(856, 580);
            this.listBoxRussian.Name = "listBoxRussian";
            this.listBoxRussian.Size = new System.Drawing.Size(275, 154);
            this.listBoxRussian.TabIndex = 11;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.listBoxRussian);
            this.Controls.Add(this.listBoxOssetian);
            this.Controls.Add(this.labelOssetian2);
            this.Controls.Add(this.labelOssetian1);
            this.Controls.Add(this.buttonRussian2);
            this.Controls.Add(this.buttonRussian1);
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
        private System.Windows.Forms.Button buttonRussian1;
        private System.Windows.Forms.Button buttonRussian2;
        private System.Windows.Forms.Label labelOssetian1;
        private System.Windows.Forms.Label labelOssetian2;
        private System.Windows.Forms.ListBox listBoxOssetian;
        private System.Windows.Forms.ListBox listBoxRussian;
    }
}

