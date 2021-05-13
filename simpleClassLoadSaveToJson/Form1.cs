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
            Meet m = new Meet(textBoxTime.Text, textBoxName.Text);
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
    }
}
