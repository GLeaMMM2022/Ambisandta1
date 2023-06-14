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
        private object currentObject = null;
        public Form()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            //listBoxResults.Items.Add(listBoxOssetian + "=" + listBoxRussian.SelectedItem);
            listView.Items.Add(listBoxOssetian.ToString(),1);
            
            listView.Items.Add(listBoxRussian.ToString(),2);

            
            //listView.Columns.Add(listBoxRussian.Text);
            //listView.Columns.Add(listBoxOssetian.Text);

        }

        List<string> lstOssetian= new List<string>() { "Буцхаст уӕздан кӕны, уӕздан магуса кӕны, магуса та сӕфтмӕ цӕуы",
        "Ӕфсӕст стонджы не 'мбары"};

        List<string> lstRussian = new List<string>() { "Баловень становится нежным, неженка - лодырем, а лодырь идёт к гибели",
            "Сытый голодного не разумеет" };

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {

            //listView.Columns.Add(listBoxOssetian.SelectedIndex.ToString(),1);
            //listView.Columns.Add(listBoxRussian.SelectedIndex.ToString(),2);

            listView.Items.Add(listBoxOssetian.SelectedIndex.ToString(), 1);
            listView.Items.Add(listBoxRussian.SelectedIndex.ToString(), 2);

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
