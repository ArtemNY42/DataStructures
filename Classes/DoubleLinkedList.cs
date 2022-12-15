using System.Collections;

namespace DataStructures.Classes
{
    public class DoubleLinkedList<T>: IEnumerable<T>
    {
        DoubleLinkedNode<T> head; // First element
        DoubleLinkedNode<T> tail; // Last element
        int count; // Total count
        public void Add(T data){
            DoubleLinkedNode<T> newNode = new DoubleLinkedNode<T>(data);
            if(head == null){
                head = newNode;
            } else {
                tail.Next = newNode;
                newNode.Previous = tail;
            }
            tail = newNode;
            count ++;
        }
        public bool Delete(T data){
            DoubleLinkedNode<T> current = head;
            DoubleLinkedNode<T> previous = null;
            while(current != null){
                if(current.Data.Equals(data)){
                    if(previous != null){
                        previous.Next = current.Next;
                        if(current.Next == null){
                            tail = previous;
                        } else {
                            current.Next.Previous = previous;
                        }
                    } else {
                        head = current.Next;
                        current.Next.Previous = null;
                        if(head == null){
                            tail = null;
                        }
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
         public bool Contains(T data){
            DoubleLinkedNode<T> current = head;
            while(current != null){
                if(current.Data.Equals(data)){
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public int Count{get {return count;}}
        public bool IsEmpty{get {return count == 0;}}
        public void Clear(){
            head = null;
            tail = null;
            count = 0;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
 
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoubleLinkedNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
 
        public IEnumerable<T> BackEnumerator()
        {
            DoubleLinkedNode<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}