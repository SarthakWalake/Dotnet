namespace StudentMarksheet
{
    class Student
    {
        protected int rollNo;
        protected string Name;
        protected int English;
        protected int generalStudies;

        public Student(int rollNo , string Name , int English , int generalStudies)
        {
            this.rollNo = rollNo;
            this.Name = Name;
            this.English = English;
            this.generalStudies = generalStudies;
        }

        public int GetRollNo()
        {
            return rollNo;
        }

        public virtual void PrintResult()
        {
            Console.WriteLine("Roll no : "+rollNo);
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("English : "+English);
            Console.WriteLine("General Studies : "+generalStudies);
        }
    }
}