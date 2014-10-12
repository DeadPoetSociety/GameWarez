using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameWare.Helpers;
using GameWare.Models;

namespace GameWare.Controllers
{
    class PlatformController : ControllerBase
    {
        public PlatformController()
        {
            //Stub
        }

        public List<Platform> getPlatforms()
        {
            string platformsJSON = handler.getResponseString("https://coolrom-api.herokuapp.com/v1/platforms/");
            Platform[] platformsArray = deserializer.deserialize<Platform[]>(platformsJSON);
            List<Platform> platformsList = platformsArray.ToList<Platform>();
            Platform any = new Platform();
            any.code = "any";
            any.name = "All Platforms";
            platformsList.Insert(0, any);
            return platformsList;
        }

        public List<string> getFiltersByPlatform(string platformCode)
        {
            string filtersJSON = handler.getResponseString("https://coolrom-api.herokuapp.com/v1/filters/" + platformCode + "/");
            string[] filters = deserializer.deserialize<string[]>(filtersJSON);
            return filters.ToList<string>();
        }
    }
}
