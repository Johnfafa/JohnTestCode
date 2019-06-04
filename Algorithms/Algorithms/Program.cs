using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = MakeList( 1, 3, 5, 7, 7,  9 );
            var list2 = MakeList(2,6, 7,8 );
            var list3 = Zip(list1, list2);
            PrintList(list3);

            //PhoneNumber
            (new PhoneNumber()).Run();

            //ApplePee
            ApplePeelercs.Run();
        }

        static Node Zip(Node p, Node q)
        {
            Node head = new Node(), zipper = new Node();
            while (p!=null && q!=null)
            {
                if (p.val <= q.val)
                {
                    zipper.next = p;
                    p = p.next;
                }
                else
                {
                    zipper.next = q;
                    q = q.next;
                }
                zipper = zipper.next;
            }
            zipper.next = p ?? q;
            return head.next;
        }

        static Node MakeList(params int[] a)
        {
            Node head = null;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                head = new Node { val = a[i], next = head };
            }
            return head;
        }

        static void PrintList(Node list)
        {
            while (list != null)
            {
                Console.Write($"{list.val}->");
                list = list.next;
            }
        }
    }



    class Node
    {
        public int val;
        public Node next;
    }

}
