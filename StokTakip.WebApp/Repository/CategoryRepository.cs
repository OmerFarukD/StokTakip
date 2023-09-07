using StokTakip.WebApp.Models;

namespace StokTakip.WebApp.Repository;

// S single responsibility
// O Open Closed 
// L Liskov subtition
// ı iNTERFACE ayrışması 
// D Dependency Inversion

public class CategoryRepository : ICategoryRepository
{
    private readonly BaseDbContext _baseDbContext;


    public CategoryRepository(BaseDbContext baseDbContext)
    {
            _baseDbContext = baseDbContext;
    }

    public void Add(Category category)
    {
       _baseDbContext.Categories.Add(category); 
        _baseDbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        Category category = _baseDbContext.Categories.Find(id);
        _baseDbContext.Categories.Remove(category);
        _baseDbContext.SaveChanges();
    }

    public List<Category> GetAll()
    {
        return _baseDbContext.Categories.ToList();
    }

    public Category GetById(int id)
    {
        return _baseDbContext.Categories.Find(id);
    }

    public void Update(Category category)
    {
        _baseDbContext.Categories.Update(category);
        _baseDbContext.SaveChanges();
    }
}
