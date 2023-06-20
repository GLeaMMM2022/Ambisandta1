using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambisandta
{
    public partial class Form : System.Windows.Forms.Form
    {
        private List<string> ossetianProverbs;
        private List<string> russianTranslations;
        private List<string> selectedProverbs;

        public Form()
        {

            selectedProverbs = new List<string>();
            InitializeComponent();
            InitializeProverbs();
            InitializeListBoxes();

            InitializeComponent();
            
        }

        int count = 0;

        private void InitializeProverbs()
        {
            ossetianProverbs = new List<string>() { "Буцхаст уӕздан кӕны, уӕздан магуса кӕны, магуса та сӕфтмӕ цӕуы",
        "Ӕфсӕст стонджы не 'мбары","Ӕвзӕрыл ма сыкъа вӕййы?"};

            russianTranslations = new List<string>() { "Баловень становится нежным, неженка - лодырем, а лодырь идёт к гибели",
            "Сытый голодного не разумеет","На плохом еще рог бывает?" };

        }

        private void InitializeListBoxes() 
        {

            proverbsListView.Items.Clear();

            //заполняю пословицами на осет листБокс
            foreach (var proverb in ossetianProverbs)
            {
                ossetianListBox.Items.Add(proverb.ToString());
            }

            //заполняю перевод
            foreach (var translation in russianTranslations)
            {
                russianListBox.Items.Add(translation.ToString());
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //listBoxResults.Items.Add(listBoxOssetian + "=" + listBoxRussian.SelectedItem);
            //listView.Items.Add(listBoxOssetian.ToString(),1);
            //listView.Items.Add(listBoxRussian.ToString(),2);

            if (ossetianListBox.SelectedItems != null && russianListBox.SelectedItems != null)
            {
                var selectedProverb = ossetianListBox.SelectedItems.ToString();
                var selectedTranslation = russianListBox.SelectedItems.ToString();

                //добавляем выбранную пословицу и перевод в листвью
                var listViewItem = new ListViewItem(new[] { selectedProverb, selectedTranslation });
                proverbsListView.Items.Add(listViewItem);
                selectedProverbs.Add(selectedProverb);

            }

            else
            {
                MessageBox.Show("Пожалуйста, выберите пословицу и ее перевод.");

            }

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in proverbsListView.Items)
            {
                var proverb = item.SubItems[0].Text;
                var translation = item.SubItems[1].Text;
                var index = ossetianProverbs.IndexOf(proverb);

                if (index != -1 && russianTranslations[index] == translation)
                {
                    // правильный перевод
                    item.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    // неправильный перевод
                    item.BackColor = System.Drawing.Color.LightPink;
                }
            }

           
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбирайте по 1 пословице соответствующие друг другу из списка доступных в двух окнах и нажимайте проверить :)");
        }
    }
}
