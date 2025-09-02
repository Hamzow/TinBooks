namespace TinBooks.Models.Repositories
{
    public interface IBookstoreRepository<T>
    {
        void Add(T entity);
        void Delete(int id);
        T Find(int id);
        IList<T> List();
        void Update(int id, T entity);
    }
}