using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostManager
{
    class Server
    {
        public string Identity { get; set; }
        public string Hostname { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string HeaderImage { get; set; }
        public int Port { get; set; }
        public enum Level { 
            ProceduralMap,
            Barren,
            HapisIsland,
            SavisIsland_Koth,
            CraggyIsland
        }
        public string LevelURL { get; set; }
        public int WorldSize { get; set; }
        public int Seed { get; set; }
        public int MaxPlayers { get; set; }
        public int RconPort { get; set; }
        public string RconPassword { get; set; }
        public int RconWeb { get; } = 1;

    }
}
