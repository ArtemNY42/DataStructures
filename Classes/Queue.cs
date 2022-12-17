using System.Collections;

namespace DataStructures.Classes
{
    public class Queue<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;
        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = newNode;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
        }
        public T Dequeue()
        {
            T output = head.Data;
            if(count != 0){
                head = head.Next;
                count--;
            }
            return output;
        }
        public void Clear(){
            head = null;
            tail = null;
            count = 0;
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
 
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}