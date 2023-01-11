using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    /// <summary>
    /// circular buffer class
    /// </summary>
    public class CircularBuffer
    {
        private int[] buffer;
        private int lowerBoundCounter;
        private int upperBoundCounter;
        private bool isFull;
        private bool isEmpty;
        private int buffSize;

        public bool IsFull 
        {
            get 
            {
                return isFull;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return isEmpty;
            }
        }

        /// <summary>
        /// constrctor
        /// </summary>
        /// <param name="buffSize"></param>
        public CircularBuffer(int buffSize)
        {
            // set up initial buffer state
            this.buffSize = buffSize;
            isFull = false;
            isEmpty = true;
            buffer = new int[buffSize];
            lowerBoundCounter = 0;
            upperBoundCounter = 0;
        }

        /// <summary>
        /// Adds an item to the end of the circular buffer
        /// </summary>
        /// <param name="item"></param>
        public virtual void AddItem(int item)
        {
            if (isFull)
                throw new Exception("Buffer full. No item can be added.");

            isEmpty = false;
            buffer[upperBoundCounter] = item;

            upperBoundCounter++;

            // loop around the upperbound pointer
            if (upperBoundCounter == buffSize)
                upperBoundCounter = 0;

            if (upperBoundCounter == lowerBoundCounter)
                isFull = true;
        }

        /// <summary>
        /// Removes an item from the front of the circular buffer
        /// </summary>
        /// <returns></returns>
        public virtual int removeItem()
        {
            if (isEmpty)
                throw new Exception("Buffer Empty. No item can be taken.");

            isFull = false;
            int itemToRemove = lowerBoundCounter;

            lowerBoundCounter++;

            if (lowerBoundCounter == buffSize)
                lowerBoundCounter = 0;

            // we could remove an item, now we're empty
            if (upperBoundCounter == lowerBoundCounter)
                isEmpty = true;

            return buffer[itemToRemove];
        }
    }
}
