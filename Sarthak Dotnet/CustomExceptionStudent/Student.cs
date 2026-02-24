

namespace CustomExceptionStudent
{
    class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message)
        {
        }
    }
    class Student
    {
        private int marks;

        public void SetMarks(int m)
        {
            if (m < 0 || m > 100)
            {
                throw new InvalidMarksException("Marks should be between 0 and 100");
            }

            marks = m;
            Console.WriteLine("Marks accepted: " + marks);
        }
    }
}
