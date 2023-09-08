using StokTakip.WebApp.Models;

namespace StokTakip.WebApp.Repository;

public interface IBaseRepository<TEntity>
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(int id);
    TEntity GetById(int id);
    List<TEntity> GetAll();
}
