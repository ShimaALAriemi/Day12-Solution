
using Day10;
using System.Xml.Linq;

namespace Day12
{
    internal class Student : Human
    {
       public string qualification;
       public bool isIntern;
       public double totalGrage;
       public int studentHours;

        public Student(string name, bool hasJob, int age, bool isMarried, string qualification, bool isIntern, double totalGrage,int studentHours) : base( name,  hasJob,  age,  isMarried)
        {
            
            this.qualification = qualification;
            this.isIntern = isIntern;
            this.totalGrage = totalGrage;
            this.studentHours = studentHours;

        }

        public override void discribe() {
            Console.WriteLine("_________________________________\n" +
                $"|Human ID: {getID()}\n" +
                    $"|Human Name: {this.name}\n" +
                    $"|Human Job state: {(((this.hasJob) ? "Married" : " Not Married"))}\n" +
                    $"|Human state: {((this.isMarried) ? "Married" : " Not Married")} \n");
        }
    }
}
