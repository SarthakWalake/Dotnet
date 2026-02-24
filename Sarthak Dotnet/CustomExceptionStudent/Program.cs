
using CustomExceptionStudent;

class Program
{
    static void Main()
    {
        Student s = new Student();

        try
        {
            Console.Write("Enter student marks: ");
            int m = int.Parse(Console.ReadLine());

            s.SetMarks(m);
        }
        catch (InvalidMarksException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Exception: " + ex.Message);
        }
    }
}
