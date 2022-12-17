using System.Collections;

namespace DataStructures.Classes
{
    public class SimpleStack<T> : IEnumerable<T>
    {
        Node<T> head;
        int count;
        public void Push(T item){
            Node<T> newNode = new Node<T>(item);
            newNode.Next = head;
            head = newNode;
            count++;
        }
        public T Pop(){ // Получение с удалением
            Node<T> getNode = head;
            if(!IsEmpty){
                head = head.Next;
                count--;
            }
            return getNode.Data;
        }
        public T Peek(){ // Получение без удаления
            return head.Data;
        }
        public void Clear(){
            head = null;
            count = 0;
        }
        public bool IsEmpty{get { return count == 0; }}
        public int Count{get { return count; }}

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