using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication10
{
    class Info
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int Folders { get; set; }
        public int Files { get; set; }

        public Info(string name,string size,int folders,int files)
        {
            Name = name;
            Size = size;
            Folders = folders;
            Files = files;
        }
    }
}
