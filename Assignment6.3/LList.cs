namespace LList
{
    class node
    {
        public int data;
        public node next;
        public node(int n)
        {
            data = n;
            next = null;
        }

    }
    class LList
    {
        private node head;
        private node tail;
        public int size;
        public int Size
        {
            get { return size; }
        }
        public LList()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public bool IsEmpty()
        {
            return this.size == 0;
        }
        public void AddFirst(int n)
        {
            node newNode = new node(n);
            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            size++;
        }
        public void AddLast(int n)
        {
            node newNode = new node(n);
            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            size++;
        }
        public void AddAnywhere(int n, int pos)
        {             
            if (pos < 1 || pos > size + 1)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            if (pos == 0)
            {
                AddFirst(n);
                return;
            }
            if (pos == size + 1)
            {
                AddLast(n);
                return;
            }
            node newNode = new node(n);
            node current = head;
            for (int i = 0; i < pos - 1; i++)
            {
                current = current.next;
            }
            newNode.next = current.next;
            current.next = newNode;
            size++;
        }
        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return 0;
            }
            int value = head.data;
            head = head.next;
            size--;
            if (IsEmpty())
            {
                tail = null; // If the list becomes empty, reset tail
            }
            return value;
        }
        public int RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return 0;
            }
            if (size == 1)
            {
                int value = head.data;
                head = null;
                tail = null;
                size--;
                return value;
            }
            node current = head;
            while (current.next != tail)
            {
                current = current.next;
            }
            int lastValue = tail.data;
            tail = current;
            tail.next = null;
            size--;
            return lastValue;
        }
        public int RemoveAnywhere(int pos)
        {
                if (pos < 1 || pos > size)
            {
                Console.WriteLine("Invalid position");
                return 0;
            }
                if (pos == 1)
            {
                return RemoveFirst();
            }
                if (pos == size)
            {
                return RemoveLast();
            }
                node current = head;
            for (int i = 1; i < pos - 1; i++)
                {
                current = current.next;
                }
            int value = current.next.data;
            current.next = current.next.next;
            size--;
            return value;
        }
        public bool Contains(int n)
        {
            node current = head;
            while (current != null)
            {
                if (current.data == n)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }
        public void Display()
        {
            node current = head;
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
    
}
