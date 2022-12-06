namespace DataStructures.Classes
{
    public class Node<T>
    {
        public Node(T data){
            Data = data;
        }
        public T Data;
        public Node<T> Next;
    }
}