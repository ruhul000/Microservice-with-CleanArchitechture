﻿using Domain.Entities;

namespace Domain.Abstractions;

public interface IProductCommandRepository
{
    //Task<bool> IsProductNameExist(string name);
    //Task<IEnumerable<Product>> GetAllProducts();
    //Task<Product?> GetProductById(Guid id);
    //Task<Product?> GetProductByName(string name);
    void AddProduct(Product product);
}
