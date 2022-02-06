using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections.ObjectModel;

namespace Molotkoff.Core
{
    public class Commands
    {
        private ObservableCollection<ICommand> observeableList = new ObservableCollection<ICommand>();
    }
}