namespace classzoo.Models
{
    class Tiger
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public string Eat(string food)
        {
            if (food == Food)
            {
                return "YUM!!!";
            }
            return "Yuck";
        }
    }
}