using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWare.Models
{
    //{"code":"atari2600","name":"Atari 2600"}
    class Platform
    {
        private string _name;
        private string _code;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string code
        {
            get { return _code; }
            set { _code = value; }
        }
    }
}
