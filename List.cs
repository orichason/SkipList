using System;
using System.Collections;
using System.Collections.Generic;

namespace SkipList
{
    public class SkipList<T>
    {
        Node<T> head;
        Random random;

        public SkipList(Random random)
        {
            head = new Node<T>(default);
            this.random = random;

        }

        private int GetRandomHeight()
        {
            return random.Next(1, 3);
        }

        public void Insert(T value)
        {
            //determine height
            //make sure height isnt greater than heads height
            //adjust heads height and add node if needed

            Node<T> node = new Node<T>(value);

            while(GetRandomHeight() != 2)
            {
                node.Height++;
            }
        }
        
    }
}
