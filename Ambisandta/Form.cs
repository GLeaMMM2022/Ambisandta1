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


        private object currentObject = null;
        public Form()
        {

            selectedProverbs = new List<string>();

            InitializeComponent();
            this.MouseMove += new MouseEventHandler(mouseEvent);
            this.MouseClick += new MouseEventHandler(mouseClick);
        }

        int count = 0;

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right") currentObject = null;
        }

        private void mouseEvent(object sender, MouseEventArgs e)
        {

            //buttonRussian1.Location=new Point(Cursor.Position.X-25,Cursor.Position.Y-80);
            if (currentObject != null)
            currentObject.GetType().GetProperty("Location").SetValue(currentObject, new Point(Cursor.Position.X - 25, Cursor.Position.Y - 80));
        }


        private void buttonRussian1_Click(object sender, EventArgs e)
        {
            currentObject = sender;
        }
        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //listBoxResults.Items.Add(listBoxOssetian + "=" + listBoxRussian.SelectedItem);
           // listView.Items.Add(listBoxOssetian.ToString(),1);
            //listView.Items.Add(listBoxRussian.ToString(),2);
            if (listBoxOssetian.SelectedItems!=null && listBoxRussian.SelectedItems != null)
            {
                var selectedProverb= listBoxOssetian.SelectedItems.ToString();
                var selectedTranslation= listBoxRussian.SelectedItems.ToString() ;


                var listViewItem = new ListViewItem(new[] { selectedProverb, selectedTranslation });
                proverbsListView.Items.Add(listViewItem);
                selectedProverbs.Add(selectedProverb);

            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите пословицу и ее перевод.");

            }

            //listView.Columns.Add(listBoxRussian.Text);
            //listView.Columns.Add(listBoxOssetian.Text);

        }

        List<string> lstOssetian= new List<string>() { "Буцхаст уӕздан кӕны, уӕздан магуса кӕны, магуса та сӕфтмӕ цӕуы",
        "Ӕфсӕст стонджы не 'мбары","Ӕвзӕрыл ма сыкъа вӕййы?"};

        List<string> lstRussian = new List<string>() { "Баловень становится нежным, неженка - лодырем, а лодырь идёт к гибели",
            "Сытый голодного не разумеет","На плохом еще рог бывает?" };

        private void InitializeListBoxes() 
        { 
            proverbsListView.Items.Clear();

            //заполняю пословицами на осет листБокс
            /*foreach (var proverb in listBoxOssetian)
            {
                listBoxOssetian.Items.Add(proverb.ToString());
            }

            //заполняю перевод
            foreach (var translation in listBoxRussian)
            {
                listBoxRussian.Items.Add(translation.ToString());
            }*/

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {

            //listView.Columns.Add(listBoxOssetian.SelectedIndex.ToString(),1);
            //listView.Columns.Add(listBoxRussian.SelectedIndex.ToString(),2);

            proverbsListView.Items.Add(listBoxOssetian.SelectedIndex.ToString(), 1);
            proverbsListView.Items.Add(listBoxRussian.SelectedIndex.ToString(), 2);

            /*
            for (int i = 0; i < listView.Items.Count; i++)
            {
                string listViewItemText = listView.Items[i].Text;

                

                string listItemText = lstOssetian[i];

                if (listViewItemText ==listViewItemText) { count++; }

            }*/

        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбирайте по 1 пословице соответствующие друг другу из списка доступных в двух окнах и нажимайте проверить :)");
        }
    }
}
