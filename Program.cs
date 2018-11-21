using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
          DoubleLinkedList obj1 = new DoubleLinkedList();
          DoubleLinkedList obj2 = new DoubleLinkedList();
          DoubleLinkedList obj3 = new DoubleLinkedList();
          DoubleLinkedList obj4 = new DoubleLinkedList();
          DoubleLinkedList obj5 = new DoubleLinkedList();

            obj1.InsertAtHead("InitialData-1");
            obj2.InsertAtHead("InitialData-2");
            obj3.InsertAtHead("InitialData-3");
            obj4.InsertAtHead("InitialData-4");
            obj5.InsertAtHead("InitialData-5");

            Console.Write("Enter Data: ");
            string Newnode=Console.ReadLine();
            //Adding
            Add(Newnode,obj1,obj2,obj3,obj4,obj5);

            //Update
            Update("InitialData-1","Ali Karani",obj1);

            //Printing 
            Printing(obj1);
            Printing(obj2);
            Printing(obj3);
            Printing(obj4);
            Printing(obj5);

            Console.ReadLine();
        }
            public static void Add(string Data,DoubleLinkedList obj1,DoubleLinkedList obj2,DoubleLinkedList obj3,DoubleLinkedList obj4,DoubleLinkedList obj5)
            {
            obj1.InsertAtHead(Data);
            obj2.InsertAtHead(Data);
            obj3.InsertAtHead(Data);
            obj4.InsertAtHead(Data);
            obj5.InsertAtHead(Data);
            }
            public static void Printing(DoubleLinkedList obj)
            {
            obj.PrintFwd();
            }
            public static void Update(string OldData,string Newnode,DoubleLinkedList obj)
            {
            obj.Update(OldData,Newnode);
            }

    }
    class DoubleLinkedList
    {
        Node head, tail;
        public void PrintFwd()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data+ ",");
                current = current.NextNode;
            }
            Console.WriteLine("");
        }
        public void InsertAtHead(string _data)
        {
            Node node = new Node(_data);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.NextNode = head;
                node.PreviousNode = null;
                head.PreviousNode = node;
                head = node;
            }
        }
        public void Update(string OldData,string NewData)
        {
                Node current = head;
                while (current != null)
                {
                    if (current.data == OldData)
                    {
                        current.data =NewData;
                    }
                    current = current.NextNode;
                }

        }
    }
    class Node
    {
        public string data ="";
        public Node NextNode { get; set; }
        public Node PreviousNode { get; set; }

        public Node(string _data)
        {
            data = _data;
        }
       public void SetNextNode(Node _nextNode)
        {
            NextNode = _nextNode;
        }
        public Node GetNextNode()
        {
            return NextNode;
        }
    }
}
