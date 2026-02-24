interface Interface1
{
    public void M();
    public void N()
    {
        Console.WriteLine("Interface::N"); //This implementation cannot be accessed by implementer class.
    }

     void P();
    void K();

}

class Class1 : Interface1
{
    public void M()
    {
        Console.WriteLine("Class 1 :: M");
    }

    public void P()
    {
        Console.WriteLine("Class 1 :: P");
    }

    void Interface1.K() // Explict implementation of interface member.We cannot mark it public.
    {
        Console.WriteLine("Class 1 :: K");
    }
}

class MainCLass
{
   static void Main()
    {
        Interface1 i1;
        Class1 c1 = new Class1();
        i1 = c1;
        i1.M();
        i1.N();
        c1.M();
        //c1.N(); // Method defined inside interface cannot be accessed by implementer class object.
        c1.P();
        //c1.K(); Explicitly implemented interface members cannot be accessed by implementer class object.
    }
}