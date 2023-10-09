namespace Application.Drivens.PrimaryDatabase;

public interface IPrimaryDbContext
{
    // TODO place your repositories here
    // example: public IBaseRepository<> Repository { get; init; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}