using System;

    namespace ConstructorSample
{
    class customer
    {
        public string Name;

        public customer()
            {
            Console.WriteLine("Welcome Constructor");
            }
        public customer(string fname, string lname)
        {
            Name = fname + " " + lname;
        }

        public void AppendData()
        {
            Console.WriteLine(Name);
        }


        static void Main(string[] args)
        {
            string fname, lname;

            Console.WriteLine("Enter the First Name and the Last Name");
            fname = Console.ReadLine();
            lname = Console.ReadLine();

            customer obj1 = new customer();

            customer obj = new customer(fname, lname);

            obj.AppendData();

            Console.ReadLine();
            Console.Clear();
        }

    }   
}