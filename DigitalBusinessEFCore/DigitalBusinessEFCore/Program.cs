using System;
using System.Linq;
using DigitalBusinessEFCore.Data;
using DigitalBusinessEFCore.Models;

class Program
{
    static void Main(string[] args)
    {
        using var context = new AppDbContext();

        // Criar o banco de dados e a tabela, se não existirem
        context.Database.EnsureCreated();

        // Adicionar Produtos
        // Console.WriteLine("Adicionando Produtos...");
        // context.Products.Add(new Product { Name = "Produto A", Price = 10.50m });
        // context.Products.Add(new Product { Name = "Produto B", Price = 20.75m });
        // context.SaveChanges();

        // Ler Produtos
        Console.WriteLine("Listando Produtos:");
        var products = context.Products.ToList();
        foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price:C}");
        }

        // // Atualizar Produto
        // Console.WriteLine("Atualizando Produto...");
        // var productToUpdate = context.Products.First();
        // productToUpdate.Name = "Produto Atualizado";
        // productToUpdate.Price = 15.99m;
        // context.SaveChanges();

        // // Excluir Produto
        // Console.WriteLine("Excluindo Produto...");
        // // Usar LastOrDefault para evitar exceção caso não haja produtos
        // var productToDelete = context.Products.OrderBy(p => p.Id).LastOrDefault();
        // if (productToDelete != null)
        // {
        //     context.Products.Remove(productToDelete);
        //     context.SaveChanges();
        // }
        // else
        // {
        //     Console.WriteLine("Nenhum produto para excluir.");
        // }

        // // Mostrar Produtos Restantes
        // Console.WriteLine("Produtos Finais:");
        // products = context.Products.ToList();
        // foreach (var product in products)
        // {
        //     Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price:C}");
        // }
    }
}
