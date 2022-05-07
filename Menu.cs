

public class Menu
{
    public void Courses()

    {
        var course = new Course();
        Console.WriteLine("1.Add Course");
        Console.WriteLine("1.Edit Course");
        Console.WriteLine("1.Delete Course");
        Console.WriteLine("1.Display Course");
        Console.WriteLine();
        Console.WriteLine("==== Press 0 for Main Menu====");
        Console.WriteLine("Enter Your Choice");

       
        int Choice = int.Parse(Console.ReadLine());

        switch (Choice)
        {
            case 1:

                break;
            default:
                if (Choice == 0)
                    Console.WriteLine("Invalid Choice!!");
                break;
        }
        while (Choice != 0) ;
    }

    public void Students()
    {
        var student = new Student();
        Console.WriteLine("1.Add Student");
        Console.WriteLine("2.Edit Student");
        Console.WriteLine("3.Delete Student");
        Console.WriteLine("4.Display Student");
        Console.WriteLine();
        Console.WriteLine("==== Press 0 for Main Menu====");
        Console.WriteLine("Enter Your Choice");
        int Choice = int.Parse(Console.ReadLine());

        switch (Choice)
        {
            case 1:
                student.Add(new Student());
                break;
            case 2:
                student.Edit(new Student());
                break;
            case 3:

                break;
            case 4:

                break;

            default:
                if (Choice == 0)
                    Console.WriteLine("Invalid Choice!!");
                break;
        }
        while (Choice != 0) ;
    }


    public void Subjects()
    {
        var subject = new Subject();
        Console.WriteLine("1.Add Subject");
        Console.WriteLine("1.Edit Subject");
        Console.WriteLine("1.Delete Subject");
        Console.WriteLine("1.Display Subject");
        Console.WriteLine();
        Console.WriteLine("==== Press 0 for Main Menu====");
        Console.WriteLine("Enter Your Choice");
        int Choice = int.Parse(Console.ReadLine());

        switch (Choice)
        {
            case 1:

                break;
            default:
                if (Choice == 0)
                    Console.WriteLine("Invalid Choice!!");
                break;
        }
        while (Choice != 0) ;
    }


    public void Mark()
    {
        var mark = new Marks();
        Console.WriteLine("1.Add Marks");
        Console.WriteLine("1.Edit Marks");
        Console.WriteLine("1.Delete Marks");
        Console.WriteLine("1.Display Marks");
        Console.WriteLine();
        Console.WriteLine("==== Press 0 for Main Menu====");
        Console.WriteLine("Enter Your Choice");
        int Choice = int.Parse(Console.ReadLine());

        switch (Choice)
        {
            case 1:

                break;
            default:
                if (Choice == 0)
                    Console.WriteLine("Invalid Choice!!");
                break;
        }
        while (Choice != 0) ;
    }
}