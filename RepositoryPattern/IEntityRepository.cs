namespace RepositoryPattern
{
    public interface IEntityRepository
    {
        void Insert(TModel model);
    }
}