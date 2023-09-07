using StokTakip.WebApp.Models;

namespace StokTakip.WebApp.Repository;

public interface ICategoryRepository
{
    void Add(Category category);
    void Update(Category category);
    void Delete(int id);
    Category GetById(int id);
    List<Category> GetAll();

}
