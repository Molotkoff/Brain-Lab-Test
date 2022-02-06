using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.Core
{
    public class EveryCommandObserver : ICommandObserver
    {
        public event Action<ICommand> OnCommandCreated;
    }
}