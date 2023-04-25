using System.Data.Entity;

namespace EFUOWTest
{
    public class PeopleContext : DbContext
    {
        public PeopleContext()
            : base("PeopleEntities")
        { }

        public DbSet<Person> People { get; set; }

        public DbSet<Hobby> Hobbies { get; set; }
    }
}

