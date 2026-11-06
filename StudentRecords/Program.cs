class Program
{
    public static void Main ()
    {
        static void VersionChk()
        {
            Console.WriteLine("Enviroment : "+ Environment.Version);
        }

        static void StudentRecord()
        {
            Console.Write("Name :  ");
            string name = Console.ReadLine();
            Console.WriteLine("enter reg no : ");
            string regNo = Console.ReadLine();
            Console.WriteLine("enter program :  ");
            string program = Console.ReadLine();
            double cgpa  = double.Parse(Console.ReadLine());
            string Record = $"Name = {name} RegNo = {regNo} program = {program} cgpa = {cgpa}";
            File.AppendAllText("RollNowise.txt",Record);

            string Display = File.ReadAllText("RollNowise.txt");
            Console.WriteLine(Display);


        }

        static void Patient()
        {
            Console.WriteLine("Patient id : ");
            string id = Console.ReadLine();
            Console.WriteLine("Age : ");
            short age = short.Parse(Console.ReadLine());
            Console.WriteLine("enter gender : ");
            string gender  = Console.ReadLine();
            Console.WriteLine("enter disease : ");
            string disease = Console.ReadLine();
            string record = $"id = {id} , age = {age} , gender = {gender} , disease = {disease}";
            File.AppendAllText("PatientRecord.txt",record);
            string Display = File.ReadAllText("PatientRecord.txt");
            Console.WriteLine(Display);

        }


        Console.WriteLine("1: Display .net version");
        Console.WriteLine(" 2 : Student record ");
        Console.WriteLine("3 : Patient record ");
        int choice = int.Parse(Console.ReadLine());
        if(choice == 1)
        {
            VersionChk();
        }
        else if(choice == 2)
        {
            StudentRecord();
        }
        else if(choice == 3)
        {
            Patient();
        }
  
    }

    }
