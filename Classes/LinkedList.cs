using System.Collections;

namespace DataStructures.Classes
{
    public class LinkedList<T>: IEnumerable<T>
    {
        Node<T> head; // First element
        Node<T> tail; // Last element
        int count; // Total count
        public void Add(T data){
            Node<T> newNode = new Node<T>(data);
            if(head == null){
                head = newNode;
            } else {
                tail.Next = newNode;
            }
            tail = newNode;
            count ++;
        }
        public bool Delete(T data){
            Node<T> current = head;
            Node<T> previous = null;
            while(current != null){
                if(current.Data.Equals(data)){
                    if(previous != null){
                        previous.Next = current.Next;
                        if(current.Next == null){
                            tail = previous;
                        }
                    } else {
                        head = current.Next;
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
            Node<T> current = head;
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
        IEnumerator IEnumerable.GetEnumerator(){
            return ((IEnumerable)this).GetEnumerator();
        }
 
        IEnumerator<T> IEnumerable<T>.GetEnumerator(){
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}