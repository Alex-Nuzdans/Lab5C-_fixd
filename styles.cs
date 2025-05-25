using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_1
{
    class Styles
    {
        internal int id;
        private string _name;

        public Styles(int id, string name)
        {
            this.id = id;
            this._name = name;
        }


        public List<string> StrCon()
        {
            var temp = new List<string>();
            temp.Add(Convert.ToString(id));
            temp.Add(_name);
            return temp;
        }


        public void NewValue(string temp, string data)
        {
            if (temp == "name")
            {
                _name = data;
            }
        }


        public override string ToString()
        {
            return ("id: " + Convert.ToString(id) + "\nНазвание: " + Convert.ToString(_name));
        }
    }
}
