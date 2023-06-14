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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.buttonRules = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelOssetian1 = new System.Windows.Forms.Label();
            this.listBoxOssetian = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxRussian = new System.Windows.Forms.ListBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderOssetian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRussian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCheck = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Перевод пословиц";
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
            // listBoxRussian
            // 
            this.listBoxRussian.FormattingEnabled = true;
            this.listBoxRussian.ItemHeight = 25;
            this.listBoxRussian.Items.AddRange(new object[] {
            "Баловень становится нежным, неженка - лодырем, а лодырь идёт к гибели",
            "Сытый голодного не разумеет"});
            this.listBoxRussian.Location = new System.Drawing.Point(602, 184);
            this.listBoxRussian.Name = "listBoxRussian";
            this.listBoxRussian.Size = new System.Drawing.Size(537, 379);
            this.listBoxRussian.TabIndex = 15;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOssetian,
            this.columnHeaderRussian});
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView.Location = new System.Drawing.Point(1211, 184);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(703, 379);
            this.listView.TabIndex = 16;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeaderOssetian
            // 
            this.columnHeaderOssetian.Text = "На осетинском";
            this.columnHeaderOssetian.Width = 295;
            // 
            // columnHeaderRussian
            // 
            this.columnHeaderRussian.Text = "На русском";
            this.columnHeaderRussian.Width = 274;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(1180, 652);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(155, 71);
            this.buttonCheck.TabIndex = 17;
            this.buttonCheck.Text = "Проверка";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2002, 933);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.listBoxRussian);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxRussian;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderOssetian;
        private System.Windows.Forms.ColumnHeader columnHeaderRussian;
        private System.Windows.Forms.Button buttonCheck;
    }
}

