using Microsoft.Data.SqlClient;
using System.Data;
class MainCLass
{
    public static void Main()
    {

        SqlConnection objconn = new SqlConnection();
        objconn.ConnectionString = @"Data Source=SARTHAK;Initial Catalog=Spektra;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = @"select * from Employees";
        cmd.Connection = objconn;
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
}