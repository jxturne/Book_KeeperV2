using System;
using System.Collections.Generic;
using System.Text;

namespace Book_KeeperV2
{
   

    //Tha plan here is to iniate some sort of userqueue, maybe for a waitlist or high demand books.
     public class Myqueue<T>
    {

        private int front;
        private int back;
        private int size;
        private int capacity;
        private T[] users;

        public Myqueue(int capacity)
        {
            this.capacity = capacity;
            front = 0;
            back = -1;
            size = 0;
            users = new T[capacity];
        }

        public void Enqueue(T users)
        {
            if (size == capacity)
            {
                throw new InvalidOperationException("Queue is full");
            }
            back = (back + 1) % capacity;
            this.users[back] = users;
            size++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T item = users[front];
            front = (front + 1) % capacity; //circular queue logic, first become last
            size--;
            return item;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool IsFull()
            {
                return size == capacity;
        }

        public int Count()
        {
            return size;
        }
    }
}
