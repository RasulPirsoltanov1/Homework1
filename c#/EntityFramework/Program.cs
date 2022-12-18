using EntityFramework.Core.Entities;
using EntityFramework.DataAccess;
using Microsoft.EntityFrameworkCore;

AppDbContext context = new AppDbContext();
#region Insert
//Product product1 = new Product()
//{
//    Name = "Xiaomi",
//    Price = 8300,
//};
//Console.WriteLine(context.Entry(product1).State);
//await context.AddAsync<Product>(product1);
//Console.WriteLine(context.Entry(product1).State);
//await context.SaveChangesAsync();
//Console.WriteLine(context.Entry(product1).State);


//Product? updateProduct=context.Products.FirstOrDefault(p => p.Id == 1);
//Console.WriteLine(updateProduct.Name+" "+updateProduct.Id+" "+updateProduct.Price);
//updateProduct.Name = "Sagumi";
//await context.SaveChangesAsync();
//Console.WriteLine(updateProduct.Name + " " + updateProduct.Id + " " + updateProduct.Price);

#endregion
#region Update

//Product Product2 = new()
//{
//    Id = 2,
//    Name = "UpdattedProduct",
//};
//Console.WriteLine(context.Entry(Product2).State);
//context.Products.Update(Product2);
//await context.SaveChangesAsync();
#endregion
#region Delete

//Product p1= context.Products.Find(5);
//context.Products.Remove(p1);
//await context.SaveChangesAsync();
#endregion
#region Select
var products=context.Products.Where(p=>p.Price>2300);
foreach (var item in products)
{
    Console.WriteLine(item.Name);
}
#endregion