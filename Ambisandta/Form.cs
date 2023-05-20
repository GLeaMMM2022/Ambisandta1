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
            listBoxResults.Items.Add(listBoxOssetian + "=" + comboBoxRussian.SelectedItem);
        }
    }
}
