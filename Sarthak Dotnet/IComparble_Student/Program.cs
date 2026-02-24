namespace IComparable_Employee
{
    class Student : IComparable
    {
        private int RollNo;
        private string Name;
        private int Marks;
        public Student(int rollNo, string name, int marks)
        {
            this.RollNo = rollNo;
            this.Name = name;
            this.Marks = marks;
        }

        public int CompareTo(object obj)
        {
            Student std = (Student)obj;
            return this.Marks.CompareTo(std.Marks);
        }

        public override string ToString()
        {
            return "RollNo: " + RollNo + " Name: " + Name + " Marks: " + Marks;
        }
    }

    class MainClass
    {
        static void Main()
        {
            Student[] stdArray = new Student[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nEnter details for Student " + (i + 1));

                Console.Write("Enter RollNo: ");
                int rollNo = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Marks: ");
                int marks = int.Parse(Console.ReadLine());

                stdArray[i] = new Student(rollNo, name, marks);
            }

            Console.WriteLine("--------------------------");

            Array.Reverse(stdArray);
            foreach (Student std in stdArray)
            {
                Console.WriteLine(std);
            }

            Console.WriteLine("--------------------------");

            Array.Sort(stdArray);

            foreach (Student std in stdArray)
            {
                Console.WriteLine(std);
            }
        }
    }
}