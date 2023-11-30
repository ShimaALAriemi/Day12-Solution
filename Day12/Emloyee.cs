
using Day10;

namespace Day9
{
     class Emloyee : Human
    {
        private int count = 0;
        private int id;
        private string role;
        private string department;
        private int workingHours;
        private int wags;


        public Emloyee(string role, string department, int workingHours,  int wags )
        {
            this.id = ++count;
            this.role = role;
            this.department = department;
            this.workingHours = workingHours;
            this.wags = wags;
        }

        public Emloyee()
        {
            this.id = ++count;
        }

        public int getId() => this.id;

        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public int WorkingHours
        {
            get { return this.workingHours; }
            set { this.workingHours = value; }
        }
    

        public int Wags
        {
            get { return this.wags; }
            set { this.wags = value; }
        }


        public decimal calculateSalary() =>  this.wags * 0.3m * this.workingHours; 
        

    }
}
