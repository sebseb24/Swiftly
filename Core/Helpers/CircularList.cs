using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swiftly.Core.Helpers
{
    public class CircularList<T>
    {
        public List<T> Items { get; }

        private int index = 0;

        public CircularList()
        {
            Items = [];
        }

        public T CurrentElement { get { return Items[index]; } }

        public T NextElement()
        {
            index = (index + 1) % Items.Count;
            return CurrentElement;
        }

        public void PreviousElement()
        {
            index = (index - 1 + Items.Count) % Items.Count;
        }

        public void SetIndexTo(int index)
        {
            if (index >= 0 && index < Items.Count)
            {
                this.index = index;
            }
        }
    }
}
