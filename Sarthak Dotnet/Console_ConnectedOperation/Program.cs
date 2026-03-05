using Microsoft.Data.SqlClient;
using System.Data;
class MainCLass
{
     static void Connected()
    {
        string strConn = @"Data Source=SARTHAK;Initial Catalog=Spektra;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        SqlConnection objconn = new SqlConnection(strConn);
        //SqlCommand cmd = new SqlCommand();
        string strCmd = @"select * from Employees";
        SqlCommand cmd = objconn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = strCmd;
        objconn.Open();

        SqlDataReader  dataReader = cmd.ExecuteReader();
        Console.WriteLine("Id\tName\tSalary\tDeptId\n");

        while(dataReader.Read())
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", dataReader[0].ToString(), dataReader[1].ToString(),
                                                    dataReader[2].ToString(), dataReader[3].ToString());
        }
        dataReader.Close();
        objconn.Close();
      }

    static void DisConnected()
    {
        string strConn = @"Data Source=SARTHAK;Initial Catalog=Spektra;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        SqlConnection objconn = new SqlConnection( strConn);
        objconn.ConnectionString = strConn;

        SqlCommand objCmd = new SqlCommand();
        string strCmd = @"Select * from Employees";
        objCmd.Connection = objconn;
        objCmd.CommandType = CommandType.Text;
        objCmd.CommandText = strCmd;

        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = objCmd;
        DataSet ds = new DataSet();
        //Fill() Method opens connection , Run Command , Stores Resultset , locally in Dataset object and closes connection.
        adapter.Fill(ds, "MyEmployees");
        DataTable empTable = ds.Tables["MyEmployees"];

        Console.Write("\nID");
        Console.Write("\tEmpName");
        Console.Write("\tSalary");
        Console.Write("\tDeptID");
        Console.WriteLine("\n------------------------");

        foreach(DataRow row in empTable.Rows)
        {
            Console.Write(row[0]);
            Console.Write("\t" + row["EmpName"]);
            Console.Write(row["salary"]);
            Console.WriteLine("\t" + row["DepID"]);
        }

        Console.WriteLine("\n************************");
        strCmd = @"Select CustId , FName , LName from Customers";
        adapter.SelectCommand.CommandText = strCmd;

        adapter.Fill(ds, "MyCustomer");

        Console.Write("\nCustomer ID");
        Console.Write("\tFirst Name");
        Console.Write("\tLast Name");

        Console.WriteLine("\n-------------------------");
        foreach (DataRow row in ds.Tables["MyCustomer"].Rows)
        {
            Console.Write(row["CustID"]);
            Console.Write("\t\t" + row[1]);
            Console.WriteLine("\t\t" + row[2]);
        }
    }

    static void Main()
    {
        Connected();
        DisConnected();
    }
}