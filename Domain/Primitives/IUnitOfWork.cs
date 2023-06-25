namespace Domain.Primitives;

public interface IUnitOfWokr
{
    Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
}