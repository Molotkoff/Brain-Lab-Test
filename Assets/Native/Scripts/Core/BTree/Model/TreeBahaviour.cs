using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Molotkoff.BTree
{
    [CreateAssetMenu(menuName = "BTree/Bahaviour")]
    public class TreeBahaviour : ScriptableObject
    {
        public ITree Tree;
    }
}