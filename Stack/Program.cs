using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            var stack = new Stack(10);
            while(!exit)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display Stack");
                int num = Convert.ToInt32(Console.ReadLine());
                int n;
                switch (num)
                {
                    case 1:
                        Console.Write("Insert a number:");
                        var line = Console.ReadLine();
                        if (int.TryParse(line, out n))
                            stack.push(n);
                        else
                        {
                            Console.WriteLine("Invalid Input........");
                        }
                        break;
                    case 2:
                        n = stack.Pop();
                        Console.WriteLine($"Deleted data:{n}");
                        break;
                    case 3:
                        stack.Display();
                        break;
                    default:
                        Console.WriteLine("Exiting........");
                        exit = true;
                        break;
                }
                Console.WriteLine();

            }

        }
        class Stack
        {
            public int Count { get; private set; }
            private int[] stack;
            public Stack(int size)
            {
                stack = new int[size];
                Count = 0;
            }
            public void push(int n)
            {
                if (stack.Length == Count)
                {
                    Console.WriteLine("Stack is full");
                }
                else
                {
                    stack[Count++] = n;
                }
            }

            public int Pop()
            {
                int result = -1;
                if (Count == 0)
                {
                    Console.WriteLine("Stack is empty");
                }
                else
                {
                    result = stack[--Count];
                }

                return result;
            }

            public void Display()
            {
                if (Count == 0)
                {
                    Console.WriteLine("Stack is empty");
                }
                else
                {
                    Console.WriteLine("Stack data:");
                    for (int i = Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }
        }


    }
}
