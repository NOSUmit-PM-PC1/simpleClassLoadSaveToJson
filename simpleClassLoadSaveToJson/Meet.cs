using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleClassLoadSaveToJson
{
    class Meet
    {
        public DateTime Time { get; set; }
        public string Name { get; set; }

        public Meet(DateTime time, string name)
        {
            Time = time;
            Name = name;
        }

        public override string ToString()
        {
            return Time + " " + Name;
        }
    }

    class ListMeet
    {
        List<Meet> listMeets = new List<Meet>();


        public void Add(Meet m)
        {
            listMeets.Add(m);
        }

        public void ViewToListBox(ListBox l)
        {
            foreach (var v in listMeets)
                l.Items.Add(v);
        }

        public void LoadFromFile()
        {
            using (StreamReader sr = new StreamReader("listmeets.json"))
            {
                listMeets = JsonConvert.DeserializeObject<List<Meet>>(sr.ReadToEnd());
            }
        }
        public void SaveToFile()
        {
            var mdJson = JsonConvert.SerializeObject(listMeets);
            MessageBox.Show(mdJson);
            using (StreamWriter sw = new StreamWriter("listmeets.json"))
                sw.WriteLine(mdJson);
        }

    }
}
