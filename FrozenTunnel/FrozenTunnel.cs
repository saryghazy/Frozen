using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenTunnel
{
    internal class FrozenTunnel
    {
        public List<char> tunnelList { get; private set; }
        public FrozenTunnel(string tunnel)
        {
            tunnelList = new List<char>(tunnel.ToCharArray());
        }
        
    }
}
