using DataStructures.Classes;

namespace DataStructure
{
    class Program
    {
        static DataStructures.Classes.LinkedList<int> linkedList = new DataStructures.Classes.LinkedList<int>();
        static DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
        static SimpleStack<int> stack = new SimpleStack<int>();
        static DataStructures.Classes.Queue<int> queue = new DataStructures.Classes.Queue<int>();
        static Set<int> set1 = new Set<int>();
        static Set<int> set2 = new Set<int>();
        static Set<int> set3 = new Set<int>();
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
            Console.WriteLine("3. Стек / Stack");
            Console.WriteLine("4. Очередь / Queue");
            Console.WriteLine("5. Множество / Set");
            Console.WriteLine();
            Console.Write("Выберите пункт списка / Select a list item ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            while(true){
                if(input != '1' && input != '2' && input != '3' && input != '4' && input != '5'){
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
                case '3':
                    ShowStackMenu();
                    break;
                case '4':
                    ShowQueueMenu();
                    break;
                case '5':
                    ShowSetMenu();
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
        static void ShowStackMenu(){
            Console.Clear();
            Console.WriteLine("Стек / Stack");
            Console.WriteLine();
            Console.WriteLine("1. В главное меню / To the main menu");
            Console.WriteLine("2. Заполнить стек / Fill stack");
            Console.WriteLine("3. Получить с удалением / Get with deleting");
            Console.WriteLine("4. Получить без удаления / Get without deleting");
            Console.WriteLine();
            Console.WriteLine("Количество элементов: " + stack.Count);
            Console.WriteLine("Все элементы / All elements: ");
            foreach(var element in stack) Console.WriteLine(element);

            Console.Write("Выберите пункт списка / Select a list item ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            while(true){
                if(input != '1' && input != '2' && input != '3' && input != '4'){
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
                    stack.Clear();
                    for(int i = 0; i < 10; i++) stack.Push(i);
                    ShowStackMenu();
                    break;
                case '3':
                    stack.Pop();
                    ShowStackMenu();
                    break;
                case '4':
                    stack.Peek();
                    ShowStackMenu();
                    break;
            }
        }
        static void ShowQueueMenu(){
            Console.Clear();
            Console.WriteLine("Очередь / Queue");
            Console.WriteLine();
            Console.WriteLine("1. В главное меню / To the main menu");
            Console.WriteLine("2. Заполнить очередь / Fill the queue");
            Console.WriteLine("3. Удалить элемент / Delete element");
            Console.WriteLine();
            Console.WriteLine("Количество элементов: " + queue.Count);
            Console.WriteLine("Все элементы / All elements: ");
            foreach(var element in queue) Console.WriteLine(element);

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
                    queue.Clear();
                    for(int i = 0; i < 10; i++) queue.Enqueue(i);
                    ShowQueueMenu();
                    break;
                case '3':
                    queue.Dequeue();
                    ShowQueueMenu();
                    break;
            }
        }
        static void ShowSetMenu(){
            Console.Clear();
            Console.WriteLine("Множество / Set");
            Console.WriteLine();
            Console.WriteLine("1. В главное меню / To the main menu");
            Console.WriteLine("2. Заполнить множества / Fill the sets");
            Console.WriteLine("3. Удалить элемент из первого множества / Delete element from first set");
            Console.WriteLine("4. Удалить элемент из второго множества/ Delete element from second set");
            Console.WriteLine("5. Объединение / Union");
            Console.WriteLine("6. Пересечение / Intersection");
            Console.WriteLine("7. Разность / Difference");
            Console.WriteLine("8. Проверка на вхождение / Checking for entry");
            Console.WriteLine();
            Console.WriteLine("Количество элементов: " + linkedList.Count);
            Console.WriteLine("Все элементы первого множества/ All elements of first set: ");
            foreach(var element in set1) Console.WriteLine(element);
            Console.WriteLine("Все элементы второго множества/ All elements of second set: ");
            foreach(var element in set2) Console.WriteLine(element);
            if(set3.Count > 0){
                Console.WriteLine("Все элементы результирующего/ All elements of result set: ");
                foreach(var element in set3) Console.WriteLine(element);
            }
            
            Console.WriteLine();
            Console.Write("Выберите пункт списка / Select a list item ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            while(true){
                if(input != '1' && input != '2' && input != '3' && input != '4'&& input != '5'&& input != '6'&& input != '7'&& input != '8'){
                    Console.Write("Выберите корректный пункт списка / Select a correct list item ");
                    input = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                } else {
                    break;
                }
            }

            string data;
            int intData;
            switch(input){
                case '1':
                    ShowMainPage();
                    break;
                case '2':
                    set1.Clear();
                    set2.Clear();
                    for(int i = 0; i < 6; i++) set1.Add(i);
                    for(int i = 4; i < 12; i++) set2.Add(i);
                    ShowSetMenu();
                    break;
                case '3':
                    Console.WriteLine("Введите значение элемента / Type value of element: ");
                    data = Console.ReadLine();
                    while(true){
                        try{
                            intData = Int32.Parse(data);
                            if(set1.Contains(intData)) break;
                            else throw new Exception();
                        } catch{
                            Console.WriteLine("Введите корректное значение элемента / Type correct value of element: ");
                            data = Console.ReadLine();
                        }
                    }
                    set1.Delete(intData);
                    ShowSetMenu();
                    break;
                case '4':
                    Console.WriteLine("Введите значение элемента / Type value of element: ");
                    data = Console.ReadLine();
                    while(true){
                        try{
                            intData = Int32.Parse(data);
                            if(set2.Contains(intData)) break;
                            else throw new Exception();
                        } catch{
                            Console.WriteLine("Введите корректное значение элемента / Type correct value of element: ");
                            data = Console.ReadLine();
                        }
                    }
                    set2.Delete(intData);
                    ShowSetMenu();
                    break;
                case '5':
                    set3 = Set<int>.Union(set1, set2);
                    ShowSetMenu();
                    break;
                case '6':
                    set3 = Set<int>.Intersection(set1, set2);
                    ShowSetMenu();
                    break;
                case '7':
                    set3 = Set<int>.Difference(set1, set2);
                    ShowSetMenu();
                    break;
                case '8':
                    Console.WriteLine("Результат / Result: " + Set<int>.Subset(set1, set2));
                    Console.ReadKey();
                    ShowSetMenu();
                    break;    
            }
        }
    }
}