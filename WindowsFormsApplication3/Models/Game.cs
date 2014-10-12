using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWare.Models
{
    class Game
    {
        private int _id;
        private string _platform;
        private string[] _screenshots;
        private string _name;
        private string _link;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string platform
        {
            get { return _platform; }
            set { _platform = value; }
        }

        public string[] screenshots
        {
            get { return _screenshots; }
            set { _screenshots = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string link
        {
            get { return _link; }
            set { _link = value; }
        }
    }
}
