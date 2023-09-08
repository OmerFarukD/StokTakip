using StokTakip.WebApp.Models;

namespace StokTakip.WebApp.Repository;

public class ProductRepository : IProductRepository
{
    private readonly BaseDbContext _context;

    public ProductRepository(BaseDbContext baseDbContext)
    {
        _context = baseDbContext;
    }


    public void Add(Product product)
    {
       _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var product = _context.Products.Find(id);
        _context.Products.Remove(product);
        _context.SaveChanges();
    }

    public List<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public List<Product> GetByContainsName(string name)
    {
        return _context.Products.Where(x=> x.Name.Contains(name)).ToList();
    }

    public Product GetById(int id)
    {
        return _context.Products.SingleOrDefault(x=> x.Id==id);
    }

    public List<Product> GetByStockRange(int min, int max)
    {
        return _context.Products.Where(x => x.Stock >= min && x.Stock <= max).ToList();
    }

    public void Update(Product product)
    {
       _context.Update(product);
        _context.SaveChanges();
    }
}
