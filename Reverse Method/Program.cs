/********************************************************************************************************/
/* file Name: Reverse Method.sln                                                                        */
/* file info: This file for reverse the double linkend list element's.                                  */
/* version  : V1.0                                                                                      */
/* Date     : 20 Nov021                                                                                 */
/* Author   : Ahmed Zoher                                                                               */
/********************************************************************************************************/
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace Reverse_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> ZOHERLinkedList = new LinkedList<string>();

            LinkedListNode<string> ZOHERNode1 = ZOHERLinkedList.AddFirst("Mohammed");

            ZOHERLinkedList.AddLast("Abd Elmaged");
            ZOHERLinkedList.AddAfter(ZOHERNode1, "Zohir");
            ZOHERLinkedList.AddBefore(ZOHERNode1, "Ahmed");
            ZOHERLinkedList.AddLast("EL-KONE");

            Console.WriteLine("\t\t---> The linked List Before Reversing <---\n");
            Console.Write("[HEAD] --> ");

            foreach (var item in ZOHERLinkedList)
            {
                Console.Write(item + " --> ");
            }

            Console.WriteLine("[NULL]\n");

            Console.WriteLine("\t\t---> The linked List After Reversing <---\n");
            Console.Write("[HEAD] --> ");

            foreach (var item in ZOHERLinkedList.Reverse())
            {
                Console.Write(item + " --> ");
            }

            Console.WriteLine("[NULL]\n");

            Console.WriteLine("\t\t---> ******************************* <---\n");
        }
    }
}
