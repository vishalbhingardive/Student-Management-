
//var  s = new Student();

//s.Add(new Student());
Test();

 void Test()
{
    int Choice;
    do
    {

    var student = new Student();
        var menu=new Menu();
        Console.WriteLine("1.Course");
        Console.WriteLine("2.Student");
        Console.WriteLine("3.Subjects");
        Console.WriteLine("4.Marks");
        Console.WriteLine();
        Console.WriteLine("Enter Your Choice:");
         Choice = int.Parse(Console.ReadLine());
        switch(Choice)
        {
            case 1:
                menu.Courses();
                break;
            case 2:
                menu.Students();
                break;
            case 3:
                menu.Subjects();
                break;
            case 4:
                menu.Mark();
                break;
                default:
                if(Choice == 0)
                Console.WriteLine("Invalid Choice!!");
                break;
        }
    }while (Choice!=0);
}
