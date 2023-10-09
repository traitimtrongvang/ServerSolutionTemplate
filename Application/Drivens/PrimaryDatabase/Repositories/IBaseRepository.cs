using Application.Domain.Entities;
using Application.Domain.ValueObjects;

namespace Application.Drivens.PrimaryDatabase.Repositories;

public interface IBaseRepository<TEntity, in TId>
    where TEntity : BaseEntity<TId>
    where TId : BaseGuidId
{
    Task<TEntity?> GetSingleAsync(TId id, CancellationToken cancelToken = default);
    
    Task TrackAsync(TEntity entity, CancellationToken cancelToken = default);
    
    Task TrackManyAsync(IEnumerable<TEntity> entities, CancellationToken cancelToken = default);
}