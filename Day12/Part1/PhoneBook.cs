namespace Day12.Part1
{
    class PhoneBook
    {
        public static int con = 0;
        string[] Names;
        long[] Numbers;
        int size;

        public PhoneBook(int size)
        {
            this.size = size;
            Names = new string[size];
            Numbers = new long[size];
        }

        public int get() => size;
        public void addPhone(string name, long number)
        {
            Names[con] = name;
            Numbers[con] = number;
            con++;
        }

        public void getNumber()
        {
            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i] != null)
                    Console.WriteLine($" {i + 1}.{Names[i]} || {Numbers[i]}");
            }
        }

        public long this[string Name, int val]
        {
            get
            {
                return Numbers[Array.IndexOf(Names, Name)];
            }
            set
            {
                if (val == 0) Numbers[Array.IndexOf(Names, Name)] = value;
                else if (val == 1)
                {
                    Names[con] = Name;
                    Numbers[con] = value;
                    con++;
                }
            }
        }

        //*here I edit the value of index

        public long this[string Name]
        {
            get
            {
                return Numbers[Array.IndexOf(Names, Name)];
            }
            set
            {
                Numbers[Array.IndexOf(Names, Name)] = value;
            }
        }


        public long getNumber(string name)
        {
            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i] == name)
                    return Numbers[i];
            }
            return -1;
        }

        public string getNumber(long number)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] == number)
                    return Names[i];
            }
            return "";
        }

    }
}
