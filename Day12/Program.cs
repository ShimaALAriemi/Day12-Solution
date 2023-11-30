using Day12.Part1;

namespace Day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            PhoneBook phoneBook = new PhoneBook(5);
            phoneBook.addPhone("Shaima", 987896567);
            phoneBook.addPhone("Ahmed", 45657776);
            phoneBook.addPhone("Noor", 557766);

            phoneBook.getNumber();
            Console.WriteLine(phoneBook.getNumber("Shaima"));
            Console.WriteLine(phoneBook.getNumber(987896567));
            Console.WriteLine("_____________________");
            Console.WriteLine(phoneBook["Shaima"]);

            phoneBook["Bader", 1] = 555555555444;
            Console.WriteLine(phoneBook.getNumber("Shaima"));

            phoneBook.getNumber();
            Console.WriteLine("_____________________");

            phoneBook["Bader", 0] = 55222225444;
            phoneBook.getNumber();

            */

            Student student = new Student("Ahmed",true,23,false,"Bhb", true,2.4,8);
            student.discribe();



        }
    }
}