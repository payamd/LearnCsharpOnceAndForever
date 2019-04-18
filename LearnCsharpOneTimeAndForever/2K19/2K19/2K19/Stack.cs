using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

namespace _2K19
{
     class Stack

     {
         public int Age { get; set; }
         public string Name { get; set; }   
         readonly ArrayList _stack = new ArrayList();

         public void Push(object obj)
         {
             _stack.Add(obj);
             Console.WriteLine(obj.ToString() + " successfully added to stack");
         }

         public void Pop()
         {
             var count = _stack.Count;

             Console.WriteLine("you poped: " + _stack[count - 1] + " from the stack");
             _stack.RemoveAt(count - 1);
        }

         public void Clear()
         {
             Console.WriteLine("you cleared the stack completely!");
             _stack.Clear();
         }
     }
}