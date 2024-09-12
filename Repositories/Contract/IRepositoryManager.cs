using Repositories.Contracts;
namespace Repositories.Contract


{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        void Save();
    }
}