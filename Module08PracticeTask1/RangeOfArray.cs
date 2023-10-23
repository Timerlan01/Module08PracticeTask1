using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08PracticeTask1
{
    public class RangeOfArray
    {
        private int lowerIndex;
        private int upperIndex;
        private int[] array;

        public RangeOfArray(int lowerIndex, int upperIndex)
        {
            if (upperIndex < lowerIndex)
            {
                throw new ArgumentException("Upper index cannot be less than lower index.");
            }

            this.lowerIndex = lowerIndex;
            this.upperIndex = upperIndex;
            this.array = new int[upperIndex - lowerIndex + 1];
        }

        public int this[int index]
        {
            get
            {
                if (IsIndexValid(index))
                {
                    return array[index - lowerIndex];
                }
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            set
            {
                if (IsIndexValid(index))
                {
                    array[index - lowerIndex] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
        }

        private bool IsIndexValid(int index)
        {
            return index >= lowerIndex && index <= upperIndex;
        }
    }

}
