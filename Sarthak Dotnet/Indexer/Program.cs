using Indexer;

class MainClass
{
    static void Main()
    {
        Employee objEmp = new Employee();

        objEmp[0] = "Sarthak";
        objEmp[1] = "Nayan";
        objEmp[2] = "Vinu";
        objEmp[3] = "Omkar";
        objEmp[4] = "Sanika";
        objEmp[5] = "Rudra";

        for(int i = 0;i< Employee.size;i++)
        {
            Console.WriteLine(objEmp[i]);
        }

        Console.WriteLine("------------------------");

        objEmp["Sarthak"] = 101;
        objEmp["Nayan"] = 102;
        objEmp["Vinu"] = 103;
        objEmp["Omkar"] = 104;
        objEmp["Sanika"] = 105;
        objEmp["Rudra"] = 106;

        for(int i = 0;i< Employee.size; i++)
        {
            Console.WriteLine(objEmp[objEmp[i]]);
        }

    }
}