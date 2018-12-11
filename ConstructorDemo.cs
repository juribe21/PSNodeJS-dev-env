public string firstName { get; set; }
        public string lastName { get; set; }
        public static string discount { get; set; }
        public static int A { get; set; }
        public static int B { get; set; }

        public StaticConstructorDemo(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        static StaticConstructorDemo()
        {
            discount = 10 + "%";
            A = 10;
            B = 15;
            sum();
        }

        public void CustomerDetails()
        {
            Console.WriteLine("Full Name:{0}", firstName + " " + lastName);
            Console.WriteLine("Discount:{0}", discount);
            Console.WriteLine("Resultof sum:" + B + "\n");
        }  


        public static int sum()
        {
            return B = A + B;
        }
