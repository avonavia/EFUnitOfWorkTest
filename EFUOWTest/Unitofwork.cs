namespace EFUOWTest
{
    public class UnitOfWork
    {
        private PeopleContext db = new PeopleContext();
        private SQLPeopleRepository peopleRepository;
        private SQLHobbyRepository hobbyRepository;

        public SQLPeopleRepository Person
        {
            get
            {
                if (peopleRepository == null)
                    peopleRepository = new SQLPeopleRepository(db);
                return peopleRepository;
            }
        }

        public SQLHobbyRepository Hobby
        {
            get
            {
                if (hobbyRepository == null)
                    hobbyRepository = new SQLHobbyRepository(db);
                return hobbyRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
