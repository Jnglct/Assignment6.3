namespace Assignment6._3
{
    enum reason
    {
        LowBalance,
        HighBalance,
        FraudAlert,
        Other
    }
    class node
    {
        public int data;
        public reason reason;
        public node next;
        public node(int n, reason j)
        {
            data = n;
            reason = j;
            next = null;
        }

    }
    class ListQueue
    {
        private node head;
        private node tail;
        private int size;
        public int Size
        {
            get { return size; }
        }
        public ListQueue()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public bool IsEmpty()
        {
            return this.size == 0;
        }
        public void Enqueue(int n, reason j)
        {
            node newNode = new node(n, j);
            if (IsEmpty())
            {
                head = newNode;
            }
            else
            {
                tail.next = newNode;
            }
            tail = newNode;
            size++;
        }
        public int? Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return null;
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
                Console.WriteLine("Queue is empty");
                return;
            }
            while (current != null)
            {
                Console.WriteLine(current.data + " " + current.reason);
                current = current.next;
            }
        }
    }

}
