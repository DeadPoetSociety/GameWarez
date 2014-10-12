using GameWare.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWare.Controllers
{
    class ControllerBase
    {
        protected ResponseHandler handler;
        protected EntityDeserializer deserializer;

        public ControllerBase(){
            handler = new ResponseHandler();
            deserializer = new EntityDeserializer();
        }
    }
}
