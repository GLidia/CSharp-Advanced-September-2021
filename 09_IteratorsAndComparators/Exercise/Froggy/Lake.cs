using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    class Lake : IEnumerable<int>
    {
        public int[] Stones { get; private set; }

        public Lake(params int[] stones)
        {
            this.Stones = stones;
        }
        
        public IEnumerator<int> GetEnumerator()
        {
            List<int> orderedStones = new List<int>();

            for (int i = 0; i < this.Stones.Length; i += 2)
            {
                orderedStones.Add(this.Stones[i]);
            }

            if (this.Stones.Length % 2 == 0)
            {
                for (int i = this.Stones.Length - 1; i > 0; i -= 2)
                {
                    orderedStones.Add(this.Stones[i]);
                }
            }
            else
            {
                for (int i = this.Stones.Length - 2; i > 0; i -= 2)
                {
                    orderedStones.Add(this.Stones[i]);
                }
            }

            foreach (var item in orderedStones)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
