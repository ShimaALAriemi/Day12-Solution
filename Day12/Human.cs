
using System.Reflection.Metadata.Ecma335;

namespace Day10
{
    internal class Human
    {
        private static int con;
        private int id;
        private string name;
        private bool hasJob;
        private int age;
        private bool isMarried;



        public Human()
        {
            id= ++con;
        }
        public Human(string name,  bool hasJob, int age, bool isMarried)
        {
            id = ++con;
            this.name = name;
            this.hasJob = hasJob;
            this.age = age;
            this.isMarried = isMarried;
        }

        public static int getCon() => con;

        public int getID() => id;

        public string Name
        {
            get { return this.name; }

            set { this.name = value; }
        }

        public int getAge() => age;
        public void setAge(int age) => this.age = age;

        public bool getJob() => hasJob;
        public void setJob(bool hasJob) => this.hasJob = hasJob;


        public bool Married
        {
            get{ return this.isMarried; }

            set{  this.isMarried = value; }
        }


        public virtual void discribe() =>
        
            Console.WriteLine("_________________________________\n"+
            $"|Human ID: {id}\n" +
                $"|Human Name: {this.name}\n" +
                $"|Human Job state: {(((this.hasJob) ? "Married" : " Not Married"))}\n" +
                $"|Human state: {((this.isMarried) ? "Married" : " Not Married")} \n");
        

        public static bool Validation(int age) => (age <=0 || age>=100)?  false : true;

            

        

    }
}
