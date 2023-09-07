﻿using StokTakip.WebApp.Models;

namespace StokTakip.WebApp.Repository;

public interface IProductRepository
{
    void Add(Product product);
    void Update(Product product);
    void Delete(int id);
    Product GetById(int id);
    List<Product> GetAll();

}
