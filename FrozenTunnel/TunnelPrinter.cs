using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenTunnel
{
    internal class TunnelPrinter
    {public static void PrintTunnel(FrozenTunnel frozenTunnel)
        {
            Console.WriteLine(new string(frozenTunnel.tunnelList.ToArray()));
        }
    }
}
