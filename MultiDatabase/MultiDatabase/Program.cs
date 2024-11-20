using System;
using System.Collections.Generic;

namespace MultiDatabaseSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema Multibase de Datos");
            Console.WriteLine("-----------------------------------------");

            // Simular bases de datos
            var mysqlDatabase = new MySQLDatabase();
            var sqliteDatabase = new SQLiteDatabase();

            // Agregar datos simulados
            mysqlDatabase.AddUser(new User { Id = 1, Name = "Alice" });
            mysqlDatabase.AddUser(new User { Id = 2, Name = "Bob" });
            mysqlDatabase.AddUser(new User { Id = 3, Name = "Charlie" });

            sqliteDatabase.AddProduct(new Product { Id = 1, Name = "Laptop" });
            sqliteDatabase.AddProduct(new Product { Id = 2, Name = "Phone" });
            sqliteDatabase.AddProduct(new Product { Id = 3, Name = "Tablet" });

            // Mostrar datos simulados
            Console.WriteLine("Datos de la base de datos MySQL simulada:");
            mysqlDatabase.ShowUsers();

            Console.WriteLine("\nDatos de la base de datos SQLite simulada:");
            sqliteDatabase.ShowProducts();

            Console.WriteLine("\nFin de la simulación.");
        }
    }

    // Clase para usuarios (MySQL)
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Clase para productos (SQLite)
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Simulación de base de datos MySQL
    class MySQLDatabase
    {
        private List<User> users;

        public MySQLDatabase()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void ShowUsers()
        {
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Id}, Nombre: {user.Name}");
            }
        }
    }

    // Simulación de base de datos SQLite
    class SQLiteDatabase
    {
        private List<Product> products;

        public SQLiteDatabase()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ShowProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id}, Nombre: {product.Name}");
            }
        }
    }
}
