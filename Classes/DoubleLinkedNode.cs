namespace DataStructures.Classes
{
    public class DoubleLinkedNode<T>
    {
        public DoubleLinkedNode(T data){
            Data = data;
        }
        public T Data;
        public DoubleLinkedNode<T> Next;
        public DoubleLinkedNode<T> Previous;
    }
}