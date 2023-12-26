namespace Company.Business.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        T GetById(int id);
        List<T> GetList();
    }
}
