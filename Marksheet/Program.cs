


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your Roll No");
        string rollno = Console.ReadLine();

        Console.WriteLine("Enter your Class");
        string cls = Console.ReadLine();

        Console.WriteLine("Enter Math marks");
        int math = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Physics marks");
        int physics = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Chemistry marks");
        int chemistry = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Hindi marks");
        int hindi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter English Marks");
        int eng = Convert.ToInt32(Console.ReadLine());


        int obj = math + physics + chemistry + hindi + eng;
        int per = obj * 100 / 500;

        Console.WriteLine("----------------Marksheet-------------------");

        Console.WriteLine("Your total marks {0}",per);
        Console.WriteLine("Your roll number {0}", rollno);
        Console.WriteLine("Your class {0}", cls);
        Console.WriteLine("Your total marks {0}", obj);
        Console.WriteLine("Your percntage {0}", per);

        if (per > 90)
        {
            Console.WriteLine("your grade A+");
        }
        else if (per < 85)
        {
            Console.WriteLine("Your Grade A");
        }
        else if (per > 75)
        {
            Console.WriteLine("Your Grade B+");
        }
        else if (per > 65)
        {
            Console.WriteLine("Your Grade C+");
        }
        else if (per > 55)
        {
            Console.WriteLine("Your Grade C");
        }
        else if (per > 45)
        {
            Console.WriteLine("Your Grade D");
        }
        else
        {
            Console.WriteLine("You are fail");
        }

        //Supplymentry

        //math + physics + chemistry + hindi + eng;


        int supply = 0;

        if (math > 33)
        {
           // supply++;
           Console.WriteLine("You have supply in math");
        }
        if(physics > 33)
        {
            //supply++;
            Console.WriteLine("You have supply in physics");
        }
        if(chemistry > 33)
        {
            //supply++;
            Console.WriteLine("You have supply in Chemistry");
        }
        if(hindi > 33)
        {
            //supply++;
            Console.WriteLine("You have supply in hindi");
        }
        if(eng > 33)
        {
            //supply++;
            Console.WriteLine("You have supply in English");
        }



        Console.ReadLine();
    }

}