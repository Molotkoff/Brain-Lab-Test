using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.BTree
{
    public class And : ITree
    {
        public event Action OnEnable;
        public event Action OnDisable;

        private ITree[] trees;

        private int index;

        public And(params ITree[] trees)
        {
            this.trees = trees;
        }

        public void Enable()
        {
            index = 0;
            OnEnable?.Invoke();
            trees[index].Enable();
        }

        public void Disable() => OnDisable?.Invoke();

        public TreeResult Execute(float time)
        {
            var result = trees[index].Execute(time);

            if (result == TreeResult.Failed)
            {
                trees[index].Disable();
                return TreeResult.Failed;
            }

            if (result == TreeResult.Success)
            {
                trees[index].Disable();

                if (++index <= trees.Length)
                {
                    trees[index].Enable();
                    return TreeResult.Running;
                }
                else return TreeResult.Success;
            }

            return TreeResult.Running;
        }
    }
}