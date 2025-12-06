using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenTunnel
{
    internal class IceMelter: IMeltable
    {
        private FrozenTunnel _frozenTunnel;
        public IceMelter(FrozenTunnel frozenTunnel)
        {
            _frozenTunnel = frozenTunnel;
        }
        public int Melt()
        {
            int meltCount = 0;
            bool changed = true;
            while (changed)
            {
                changed = false;
                List<int> position = FindPositionsToMelt();
                if (position.Count > 0)
                {
                    changed = true;
                    
                    foreach (int pos in position)
                    {
                        _frozenTunnel.tunnelList[pos] = '_';
                    }
                meltCount+= position.Count;
                }
            }
            return meltCount;
        }

        private List<int> FindPositionsToMelt()
        {
            List<int> positions = new List<int>();
            int i = 0;
            List<char> tunnel = _frozenTunnel.tunnelList;
            while(i < tunnel.Count - 2)
            {
                if (tunnel[i] == '_' && tunnel[i + 1] == '_' && tunnel[i + 2] == '_')
                {
                    int j = i + 3;
                    while (j < tunnel.Count && tunnel[j] != 'I')
                        j++;

                    if (j < tunnel.Count && tunnel[j] == 'I')
                            positions.Add(j);
                    i = j;
                }
                else
                {
                    i++;
                }
            }
            return positions;
        }
    }
}
