using System.Collections.Generic;

namespace EFUOWTest
{
    public interface IRepository<T>
    where T : class
    {
        IEnumerable<T> GetPeopleList();
        void Create(T item);
        void Delete(int id);
    }
    public class SQLPeopleRepository
    {
        private PeopleContext db;

        public SQLPeopleRepository(PeopleContext context)
        {
            db = context;
        }

        public IEnumerable<Person> GetPeopleList()
        {
            return db.People;
        }

        public void Create(Person person)
        {
            db.People.Add(person);
        }

        public void Delete(int id)
        {
            Person person = db.People.Find(id);
            if (person != null)
                db.People.Remove(person);
        }
    }
}

