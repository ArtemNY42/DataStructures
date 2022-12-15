using DataStructures.Classes;

namespace DataStructure
{
    class Program
    {
        static DataStructures.Classes.LinkedList<int> linkedList = new DataStructures.Classes.LinkedList<int>();
        static DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
        static void Main(string[] args)
        {
            //Test lists
            ShowMainPage();
        }
        static void ShowMainPage(){
            Console.Clear();
            Console.WriteLine("Структуры данных / Data structures");
            Console.WriteLine();
            Console.WriteLine("1. Односвязный список / Linked List");
            Console.WriteLine("2. Двусвязный список / Double linked list");
            Console.Write("Выберите пункт списка / Select a list item ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            while(true){
                if(input != '1' && input != '2'){
                    Console.Write("Выберите корректный пункт списка / Select a correct list item ");
                    input = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                } else {
                    break;
                }
            }
            switch(input){
                case '1':
                    ShowLinkedListMenu();
                    break;
                case '2':
                    ShowDoubleLinkedListMenu();
                    break;
            }
            Console.ReadKey();
        }
        static void ShowLinkedListMenu(){
            Console.Clear();
            Console.WriteLine("Односвязный список / Linked List");
            Console.WriteLine();
            Console.WriteLine("1. В главное меню / To the main menu");
            Console.WriteLine("2. Заполнить список / Fill the list");
            Console.WriteLine("3. Удалить элемент / Delete element");
            Console.WriteLine();
            Console.WriteLine("Количество элементов: " + linkedList.Count);
            Console.WriteLine("Все элементы / All elements: ");
            foreach(var element in linkedList) Console.WriteLine(element);

            Console.Write("Выберите пункт списка / Select a list item ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            while(true){
                if(input != '1' && input != '2' && input != '3'){
                    Console.Write("Выберите корректный пункт списка / Select a correct list item ");
                    input = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                } else {
                    break;
                }
            }

            switch(input){
                case '1':
                    ShowMainPage();
                    break;
                case '2':
                    linkedList.Clear();
                    for(int i = 0; i < 10; i++) linkedList.Add(i);
                    ShowLinkedListMenu();
                    break;
                case '3':
                    Console.WriteLine("Введите значение элемента / Type value of element: ");
                    string data = Console.ReadLine();
                    int intData;
                    while(true){
                        try{
                            intData = Int32.Parse(data);
                            if(linkedList.Contains(intData)) break;
                            else throw new Exception();
                        } catch{
                            Console.WriteLine("Введите корректное значение элемента / Type correct value of element: ");
                            data = Console.ReadLine();
                        }
                    }
                    linkedList.Delete(intData);
                    ShowLinkedListMenu();
                    break;
            }
        }
        static void ShowDoubleLinkedListMenu(){
            Console.Clear();
            Console.WriteLine("Двусвязный список / DoubleLinked List");
            Console.WriteLine();
            Console.WriteLine("1. В главное меню / To the main menu");
            Console.WriteLine("2. Заполнить список / Fill the list");
            Console.WriteLine("3. Удалить элемент / Delete element");
            Console.WriteLine();
            Console.WriteLine("Количество элементов: " + doubleLinkedList.Count);
            Console.WriteLine("Все элементы / All elements: ");
            foreach(var element in doubleLinkedList) Console.WriteLine(element);

            Console.Write("Выберите пункт списка / Select a list item ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            while(true){
                if(input != '1' && input != '2' && input != '3'){
                    Console.Write("Выберите корректный пункт списка / Select a correct list item ");
                    input = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                } else {
                    break;
                }
            }

            switch(input){
                case '1':
                    ShowMainPage();
                    break;
                case '2':
                    doubleLinkedList.Clear();
                    for(int i = 0; i < 10; i++) doubleLinkedList.Add(i);
                    ShowDoubleLinkedListMenu();
                    break;
                case '3':
                    Console.WriteLine("Введите значение элемента / Type value of element: ");
                    string data = Console.ReadLine();
                    int intData;
                    while(true){
                        try{
                            intData = Int32.Parse(data);
                            if(doubleLinkedList.Contains(intData)) break;
                            else throw new Exception();
                        } catch{
                            Console.WriteLine("Введите корректное значение элемента / Type correct value of element: ");
                            data = Console.ReadLine();
                        }
                    }
                    doubleLinkedList.Delete(intData);
                    ShowDoubleLinkedListMenu();
                    break;
            }
        }
    }
}