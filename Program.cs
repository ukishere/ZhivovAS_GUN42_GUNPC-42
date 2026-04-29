using Microsoft.VisualBasic;

namespace HomeWork
{
    internal class Program
    {
        private class ListTask
        {
            List<string> _list = new List<string>() {"One", "Two", "Three"};

            public void TaskLoop()
            {
                Console.WriteLine("You are in Task 1 (List)");
                Console.WriteLine("1: Add element to the end of the list");
                Console.WriteLine("2: Add element to the center of the list");
                Console.WriteLine("0: Exit");

                while(true)
                {
                    Console.Write("Your input: ");
                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.WriteLine("Insert element: ");
                        string element = Console.ReadLine();
                        _list.Add(element);
                        Display(_list);
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("Insert element: ");
                        string element = Console.ReadLine();
                        _list.Insert(_list.Count/2, element);
                        Display(_list);
                    }
                    else if (input == "0") 
                    {
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Incorrect input");
                    }
                }
            }
       
            private void Display(List<string> list)
            {
                Console.Write("Current list: ");
                for(int i = 0; i < list.Count; i++)
                {
                    Console.Write($"{list[i]} ");
                }
                Console.WriteLine();
            }
        }

        private class DictionaryTask
        {
            Dictionary<string, float> _dictionary = new Dictionary<string, float>() 
            {
                {"Ivanov", 3.3f}, {"Petrov", 4.4f}, {"Sidorov", 5.0f}
            };

            public void TaskLoop()
            {
                Console.WriteLine("You are in Task 2 (Dictionary)");
                Console.WriteLine("1: Add new student");
                Console.WriteLine("2: Check student's score");
                Console.WriteLine("0: Exit");

                while(true)
                {
                    Console.Write("Your input: ");
                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.WriteLine("Insert student's name: ");
                        string name = Console.ReadLine();
                        while (true)
                        {
                            Console.WriteLine("Insert student's score (2-5): ");
                            string score = Console.ReadLine();
                            bool check = CheckingScore(score);
                            if (!check) { Console.WriteLine("Incorrect input. Try again."); }
                            else { _dictionary.Add(name, float.Parse(score)); break; }
                        }

                        Display(_dictionary);
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("Insert student's name: ");
                        string name = Console.ReadLine();

                        if (_dictionary.TryGetValue(name, out float value)) 
                        { 
                            Console.WriteLine($"Student's score = {value}"); 
                        }
                        else
                        {
                            Console.WriteLine("No such student"); 
                        }
                    }
                    else if (input == "0") 
                    {
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Incorrect input");
                    }
                }
            }
       
            private bool CheckingScore(string input)
            {
                if (float.TryParse(input, out float score)) { }
                else {return false;}

                if (score < 2f || score > 5f) {return false;}
                else return true;
            }
        
            private void Display(Dictionary<string, float> dictionary)
            {
                Console.WriteLine("Current dicrionary:");
                foreach (KeyValuePair<string, float> pair in dictionary)
                {
                    Console.WriteLine($"Student: {pair.Key}; Score: {pair.Value}");
                }
            }
        }

        private class LinkedListTask
        {
            LinkedList<string> _linkedList = new LinkedList<string>();

            private bool CheckingElements(string[] elements)
            {
                  if (elements.Count() < 3) 
                { 
                    Console.WriteLine("Not enough elements"); 
                    return false;
                }
                else if (elements.Count() > 6) 
                { 
                    Console.WriteLine("Too many elements"); 
                    return false;
                }
                else 
                    return true;
            }

            public void TaskLoop()
            {
                Console.WriteLine("You are in Task 3 (Linked List)");
                Console.WriteLine("Let's create a list (3-6 elements separeted with spaces)");
                
                while(true)
                {
                    Console.WriteLine("Your input (press 0 for exit): ");
                    string input = Console.ReadLine();

                    if (input == "0") break;

                    string[] elements = input.Split(' ');
                    if (CheckingElements(elements))
                    {
                        foreach (string element in elements)
                        {
                            _linkedList.AddLast(element);
                        }
                        
                        Console.WriteLine("Your List starting form the beginning:");
                        foreach (string element in _linkedList)
                        {
                            Console.Write($"{element} ");
                        }

                        Console.WriteLine("\nYour List starting form the end:");
                        LinkedListNode<string> last = _linkedList.Last;
                        while(last != null)
                        {
                            Console.Write($"{last.Value} ");
                            last = last.Previous;
                        }
                        
                        break;
                    }
                }    
            }
        }

        private static void Main(string[] args)
        {
           //Task 1
           ListTask list = new ListTask(); 
           list.TaskLoop();

           //Task 2
           DictionaryTask dictionary = new DictionaryTask();
           dictionary.TaskLoop();

           //Task 3 
           LinkedListTask linkedList = new LinkedListTask();
           linkedList.TaskLoop();
        }
    }
}
