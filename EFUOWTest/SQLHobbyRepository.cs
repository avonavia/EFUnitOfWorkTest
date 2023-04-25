using System.Collections.Generic;

namespace EFUOWTest
{
    public interface HobbyRepository<T>
    where T : class
    {
        IEnumerable<T> GetHobbiesList();
        void DeleteHobby(int id);
    }
    public class SQLHobbyRepository
    {
        private PeopleContext db;

        public SQLHobbyRepository(PeopleContext context)
        {
            db = context;
        }

        public IEnumerable<Hobby> GetHobbiesList()
        {
            return db.Hobbies;
        }
        public void DeleteHobby(int id)
        {
            Hobby hobby = db.Hobbies.Find(id);
            if (hobby != null)
            db.Hobbies.Remove(hobby);
            db.SaveChanges();
        }
    }
}

