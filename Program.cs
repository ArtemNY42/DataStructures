using DataStructures.Classes;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Linked List
            DataStructures.Classes.LinkedList<int> linkedList = new DataStructures.Classes.LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            foreach(int current in linkedList){
                Console.WriteLine(current);
            }
            linkedList.Delete(2);
            Console.WriteLine();
            foreach(int current in linkedList){
                Console.WriteLine(current);
            }
        }
    }
}