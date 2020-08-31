namespace DesignPatterns.Repository
{
    public interface IEntityRepository<TModel>
    {
        void Insert(TModel model);
    }
}