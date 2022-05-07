
using System.Data.SqlClient;

public class Student
{
    public void Add(Student s)
    {
        string connectionString = @"Data Source=WAIANGDESK23\MSSQLSERVER01;Initial Catalog=StudentManagement;Integrated Security=True";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            //3. Reader
            SqlCommand command = new SqlCommand("StudentEntry1", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            Console.WriteLine("Enter Roll No: ");
            command.Parameters.Add("@RollNo", System.Data.SqlDbType.Int).Value = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name: ");

            command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 200).Value = Console.ReadLine();

            Console.WriteLine("Enter Email: ");

            command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar, 200).Value = Console.ReadLine();

            Console.WriteLine("Enter Address: ");

            command.Parameters.Add("@Address", System.Data.SqlDbType.VarChar, 200).Value = Console.ReadLine();

            Console.WriteLine("Enter Course_id: ");

            command.Parameters.Add("@Course_id", System.Data.SqlDbType.Int).Value = int.Parse(Console.ReadLine());


            int affectedRows = command.ExecuteNonQuery();

            connection.Close();
        }
    }


    public void Edit(Student s)
    {
        string connectionString = @"Data Source=WAIANGDESK23\MSSQLSERVER01;Initial Catalog=StudentManagement;Integrated Security=True";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            //3. Reader
            SqlCommand command = new SqlCommand("updateStudent", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "select * from Student.Student where Student_id=@Student_id";

            command.Parameters.AddWithValue("@Student_id",System.Data.SqlDbType.Int).Value=int.Parse(Console.ReadLine());
            
            int Choice;
            do
            {
                Console.WriteLine("Enter Your Choice: ");
                 Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                   
                    case 1:
                        command.Parameters.Add("@RollNo", System.Data.SqlDbType.Int).Value = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 200).Value = Console.ReadLine();
                        break;
                    case 3:
                        command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar, 200).Value = Console.ReadLine();
                        break;
                    case 4:
                        command.Parameters.Add("@Address", System.Data.SqlDbType.VarChar, 200).Value = Console.ReadLine();
                        break;
                    case 5:
                        command.Parameters.Add("@Course_id", System.Data.SqlDbType.Int).Value = int.Parse(Console.ReadLine());
                        break;
                        default:
                        if (Choice == 0)
                            Console.WriteLine("Invalid Choice");
                        break;
                        int affectedRows = command.ExecuteNonQuery();

                }
               
            } while (Choice!=0);



            connection.Close();
        }
    }

    public void Delete(int studentId)
    {

    }

    public void DisplayStudentReport()
    {

    }
}