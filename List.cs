using System;
using System.Collections;
using System.Collections.Generic;

namespace SkipList
{
    public class SkipList<T> where T : IComparable
    {
        Node<T> head;
        Random random;

        public SkipList(Random random)
        {
            head = new Node<T>(default, null, null, 2);
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

            Node<T> newNode = new Node<T>(value);

            while (GetRandomHeight() != 2 && newNode.Height <= head.Height)
            {
                newNode.Height++;
                if(newNode.Height.CompareTo(head.Height) > 0)
                {
                    head.Height++;
                    head.Below = new Node<T>(default);
                }
                newNode.Below = new Node<T>(value, newNode.Height - 1);
            }

            if (newNode.Height <= head.Height)
            {

            }



            Node<T> current = head;
            Node<T> parent = head;

            while (current.Right != null || current.Right.Value.CompareTo(value) > 0)
            {
                current = current.Right;

                if (value.CompareTo(current.Right.Value) <= 0)
                {
                    current = current.Below;
                    parent.Right = newNode;
                    newNode.Right = current;
                    return;
                }

                current = current.Right;
                parent = parent.Right;
            }

            parent.Right = newNode;
        }

    }
}
