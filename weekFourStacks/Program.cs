using System;

namespace weekFourStacks
{
    class Program
    {
       // public static bool isFULL(in int top, in int max);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void POSTFIX(int E)
        {
            int top, x;
            

        }

        public static void create()
        {
            int top = 0;
        }
        public static void push(int item, ref int top, ref int[] stack, int max)
        {
            if (isFULL(top, max) == true){
                stackFULL();
            }
            else
                top = top + 1;
                stack[top] = item;

            
        }
        public static void pop(out int item, ref int[] stack, ref int top)
        {
            if (isEmpty(top, stack) == true) {
                stackEmpty();
            }
            else{
                item = stack[top];
                top = top + 1;
            }
        }
        public static int getTop(in int top, in int[] stack)
        {
            if (isEmpty(top, stack) == true){
                stackEmpty();
            }
            else
            {
                return stack[top];
            }
        }
        public static bool isEmpty (in int top, in int[] stack)
        {
            if (top == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool isFULL(in int top, in int max)
        {
            if (top == max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string stackFULL()
        {
            string stackFull = "stack Full";
            return stackFull;
        }
        public static string stackEmpty()
        {
            string stackEmpty = "Stack Empty";
            return stackEmpty;
        }
    }
}
