namespace classzoo.Models
{
    class Lion
    {
        // public int Age; //field
        public int Age { get; private set; }
        public string Name { get; set; }
        public Tiger BestBuddy { get; set; }
        public void Birthday()
        {
            Age++;
        }

        public Lion(int age, string name, Tiger bb)
        {
            Age = age;
            Name = name;
            BestBuddy = bb;
        }
    }
}