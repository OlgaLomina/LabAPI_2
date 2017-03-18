using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAPI_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[3];
            //int num1 = 0;
            /*Console.Write("enter first integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            nums[0] = num1;
            Console.WriteLine("enter second integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            nums[1] = num1;
            Console.WriteLine("enter third integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            nums[2] = num1;*/


            int[] nums = { 4, 4, 6, 1, 1, 3, -2, 0, 0, 1, 1, 8 };
            Lab2.Smoosh(nums);
            Console.ReadLine();

            MyLinkedList list = new MyLinkedList(); //0 0 0 0 1 1 0 0 0 3 3 3 1 1 0
            list.AddAtTail(0);
            list.AddAtTail(0);
            list.AddAtTail(0);
            list.AddAtTail(0);
            list.AddAtTail(1);
            list.AddAtTail(1);
            list.AddAtTail(0);
            list.AddAtTail(0);
            list.AddAtTail(0);
            list.AddAtTail(3);
            list.AddAtTail(3);
            list.AddAtTail(3);
            list.AddAtTail(1);
            list.AddAtTail(1);
            list.AddAtTail(0);
            

            /*list.AddAtHead(0);
            list.AddAtHead(1);
            list.AddAtHead(1);
            list.AddAtHead(0);
            list.AddAtHead(0);
            list.AddAtHead(0);
            list.AddAtHead(3);*/

            list.printnodes();

            list.Squish(list);
            list.printnodes();

            list.Twin(list);
            list.printnodes();
        }
    }
}
