namespace Tazhgah.Core.PrimaryConstructors
{
    public class Customer(string firstName, string lastName)
    {

        public DateOnly BirthOfYear { get; set; }

        public Customer(string firstName, string lastName, DateOnly birthOfYear) : this(firstName, lastName)
        {
            BirthOfYear = birthOfYear;
        }

        public string FullName()
        {
            return string.Format("{0} {1}", firstName, lastName);
        }


    }
}
