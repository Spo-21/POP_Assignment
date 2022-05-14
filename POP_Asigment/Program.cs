// See https://aka.ms/new-console-template for more information
namespace POP_Asigment
{
    class Program
    {
        static void passValue(string studentsInfo)
        {
            studentsInfo = Console.ReadLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var student = new Student();
            var address = new Address();
            while (true)
            {
                try
                {
                    Console.Clear();

                    Console.Write("Please enter student First Name: ");
                    passValue(student.FirstName);

                    Console.Write("Please enter student Last Name: ");
                    passValue(student.LastName);

                    Console.Write("Please enter student Number: ");
                    passValue(student.StudentNumber);

                    Console.Write("Please enter student Age: ");
                    student.Age = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.Write("Please enter student Street: ");
                    passValue(address.Street);

                    Console.Write("Please enter student City: ");
                    passValue(address.City);

                    Console.Write("Please enter student Country: ");
                    passValue(address.Country);

                    student.Adsress = address;

                    int[] scores = new int[7];

                    for (int i = 0; i < scores.Length; i++)
                    {
                        Console.Write("Please input " + (i + 1) + "th mark:  ");
                        scores[i] = Int32.Parse(Console.ReadLine());
                    }

                    student.Scores = scores;

                    Console.WriteLine();
                    Console.WriteLine(student);
                    break;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Invalid data");
                    Console.ReadKey();
                }
            }
        }
    }
}

