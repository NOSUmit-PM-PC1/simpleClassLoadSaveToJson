using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleClassLoadSaveToJson
{
    public partial class Form1 : Form
    {
        ListMeet lst = new ListMeet();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePickerDate.Value.Date +
                    dateTimePickerTime.Value.TimeOfDay;
            Meet m = new Meet(dt, textBoxName.Text);
            lst.Add(m);
            listBoxMeets.Items.Add(m);
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            lst.SaveToFile();
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            lst.LoadFromFile();
            lst.ViewToListBox(listBoxMeets);
        }

        private void listBoxMeets_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxMeets.SelectedIndex;
            string[] s = listBoxMeets.Items[index].ToString().Split();
            DateTime dt = DateTime.Parse(s[0] + " " + s[1]);
            labelDeltaTime.Text = (dt - DateTime.Today).Days.ToString() + " дней";

        }
    }
}
