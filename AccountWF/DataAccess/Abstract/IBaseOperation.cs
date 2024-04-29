namespace AccountWF.DataAccess.Abstract
{
    public interface IBaseOperation<T> where T : class, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);

    }
}
