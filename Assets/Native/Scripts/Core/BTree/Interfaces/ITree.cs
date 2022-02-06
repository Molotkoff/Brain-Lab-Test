using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Molotkoff.FPS;

namespace Molotkoff.BTree
{
    public interface ITree : IEnable, IDisable
    {
        TreeResult Execute(float time);
    }
}