namespace Interface
{
    // Interfaces are always abstract (methods have no body)
    interface IMath1
    {
        void Add(int a, int b);   // By default: public + abstract
        void Sub(int a, int b);
    }

    // Interface can inherit another interface (MULTIPLE inheritance of interfaces)
    interface IMath2 : IMath1
    {
        void Mul(int a, int b);
        void Div(int a, int b);
    }

    // A class can implement MULTIPLE interfaces (multiple inheritance is achieved here)
    internal class Program : IMath1, IMath2
    {
        // MUST implement all interface methods, otherwise class becomes abstract.
        // All implemented methods MUST be public (interface methods are public by default)

        public void Add(int a, int b)
        {
            // Interface method implementation
            int c = a + b;
            Console.WriteLine("Add: " + c);
        }

        public void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Sub: " + c);
        }

        public void Mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Mul: " + c);
        }

        public void Div(int a, int b)
        {
            // No exception handling — assuming b != 0
            int c = a / b;
            Console.WriteLine("Div: " + c);
        }

        // Class's own method — NOT part of the interface
        public void Display()
        {
            Console.WriteLine("Pure Child Class Member");
        }


        static void Main()
        {
            // ❌ IMath1 m1 = new IMath1();   // Interface cannot be instantiated (100% interview point)

            Program obj1 = new Program();
            obj1.Add(1, 2);
            obj1.Sub(1, 2);
            obj1.Mul(1, 2);
            obj1.Div(2, 2);
            obj1.Display();

            Console.WriteLine("*********************************");

            // ✔ Interface reference → Object of class (POLYMORPHISM)
            IMath1 m1 = new Program();
            m1.Add(1, 2);
            m1.Sub(1, 2);

            // ❌ NOT allowed: Interface reference calls only its own members
            // m1.Display();  

            Console.WriteLine("*********************************");

            IMath2 m2 = new Program();
            m2.Add(1, 2);   // From IMath1
            m2.Sub(1, 2);   // From IMath1
            m2.Mul(1, 2);   // From IMath2
            m2.Div(2, 2);   // From IMath2

            // ❌ Not allowed
            // m2.Display();

            Console.ReadLine();
        }
    }
}
