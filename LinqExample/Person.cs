namespace LinqExample
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }


        public string FullName => $" {FirstName} {LastName} ";

    }
}
