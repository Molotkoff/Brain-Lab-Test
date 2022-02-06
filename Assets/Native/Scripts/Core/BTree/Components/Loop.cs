using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.BTree
{
    public class Loop : ITree
    {
        public event Action OnEnable;
        public event Action OnDisable;

        private Func<Func<bool>> conditionGenerator;
        private Func<bool> condition;

        private ITree tree;

        public Loop(Func<Func<bool>> conditionGenerator, ITree tree)
        {
            this.conditionGenerator = conditionGenerator;
            this.tree = tree;
        }

        public void Enable()
        {
            condition = conditionGenerator();
            OnEnable?.Invoke();
            tree.Enable();
        }

        public void Disable()
        {
            condition = null;
            OnDisable?.Invoke();
            tree.Disable();
        }

        public TreeResult Execute(float time)
        {
            if (condition())
            {
                var result = tree.Execute(time);

                return TreeResult.Running;
            }

            return TreeResult.Success;
        }
    }
}