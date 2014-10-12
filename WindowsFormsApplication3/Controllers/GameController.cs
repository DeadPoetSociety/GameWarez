using GameWare.Helpers;
using GameWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWare.Controllers
{
    class GameController: ControllerBase
    {
        public List<Game> getGamesByQuery(string query){
            query.Replace(' ','+');
            string gamesJSON = handler.getResponseString("https://coolrom-api.herokuapp.com/v1/search/" + query + "/");
            Game[] games = deserializer.deserialize<Game[]>(gamesJSON);
            for(int i=0; i<games.Length; i++)
            {
                games[i].link = "coolrom.com/roms/" + games[i].platform + "/" + games[i].id + "/" + games[i].name.Replace(' ', '_') + ".php";
            }
            return games.ToList<Game>();
        }

        public List<Game> getGamesByQuery(string query, string platformCode)
        {
            query.Replace(' ', '+');
            string gamesJSON = handler.getResponseString("https://coolrom-api.herokuapp.com/v1/search/" + query + "/" + platformCode + "/");
            Game[] games = deserializer.deserialize<Game[]>(gamesJSON);
            return games.ToList<Game>();
        }

        //public List<Game> getGamesByPlatform()
        //{

        //}
    }
}
