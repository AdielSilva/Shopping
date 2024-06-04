namespace Shopping.Domain.Repository
{
    public interface IRepository<T> where T : class
    {
        public List<T> GetAll();
        public T GetById(int id);
        public T Create(T entity);
        public void Update(T entity);
        public void Delete(int id);
    }
}
