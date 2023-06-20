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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.buttonRules = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelOssetian1 = new System.Windows.Forms.Label();
            this.ossetianListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.russianListBox = new System.Windows.Forms.ListBox();
            this.proverbsListView = new System.Windows.Forms.ListView();
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
            this.buttonRules.Click += new System.EventHandler(this.buttonRules_Click);
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
            // ossetianListBox
            // 
            this.ossetianListBox.FormattingEnabled = true;
            this.ossetianListBox.ItemHeight = 25;
            this.ossetianListBox.Location = new System.Drawing.Point(39, 184);
            this.ossetianListBox.Name = "ossetianListBox";
            this.ossetianListBox.Size = new System.Drawing.Size(486, 379);
            this.ossetianListBox.TabIndex = 10;
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
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(635, 652);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(196, 72);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Выбрать";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // russianListBox
            // 
            this.russianListBox.FormattingEnabled = true;
            this.russianListBox.ItemHeight = 25;
            this.russianListBox.Location = new System.Drawing.Point(602, 184);
            this.russianListBox.Name = "russianListBox";
            this.russianListBox.Size = new System.Drawing.Size(537, 379);
            this.russianListBox.TabIndex = 15;
            // 
            // proverbsListView
            // 
            this.proverbsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOssetian,
            this.columnHeaderRussian});
            this.proverbsListView.HideSelection = false;
            this.proverbsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.proverbsListView.Location = new System.Drawing.Point(1211, 184);
            this.proverbsListView.Name = "proverbsListView";
            this.proverbsListView.Size = new System.Drawing.Size(703, 379);
            this.proverbsListView.TabIndex = 16;
            this.proverbsListView.UseCompatibleStateImageBehavior = false;
            this.proverbsListView.View = System.Windows.Forms.View.Details;
            this.proverbsListView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
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
            this.Controls.Add(this.proverbsListView);
            this.Controls.Add(this.russianListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ossetianListBox);
            this.Controls.Add(this.labelOssetian1);
            this.Controls.Add(this.buttonRules);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form";
            this.Text = "\\";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelOssetian1;
        private System.Windows.Forms.ListBox ossetianListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox russianListBox;
        private System.Windows.Forms.ListView proverbsListView;
        private System.Windows.Forms.ColumnHeader columnHeaderOssetian;
        private System.Windows.Forms.ColumnHeader columnHeaderRussian;
        private System.Windows.Forms.Button buttonCheck;
    }
}

