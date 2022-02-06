using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.FPS
{
    public class RicochetModel : IRicochetModel
    {
        public int Ricochets { get; set; }

        public RicochetModel(int ricochetsCount)
        {
            Ricochets = ricochetsCount;
        }
    }
}