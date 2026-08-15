using Computer_shop.Models;
using Microsoft.EntityFrameworkCore;

namespace Computer_shop.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                // Create database if it doesn't exist
                context.Database.EnsureCreated();

                // Seed Categories
                if (!context.Categories.Any())
                {
                    var categories = new List<Category>()
                    {
                        new Category()
                        {
                            Name = "Laptops",
                            Description = "Portable computers for work and gaming"
                        },
                        new Category()
                        {
                            Name = "Desktops",
                            Description = "Desktop computers for office and gaming"
                        },
                        new Category()
                        {
                            Name = "Monitors",
                            Description = "Display monitors for computers"
                        },
                        new Category()
                        {
                            Name = "Peripherals",
                            Description = "Keyboards, mice, and other accessories"
                        },
                        new Category()
                        {
                            Name = "Components",
                            Description = "CPU, GPU, RAM, and other hardware components"
                        }
                    };

                    context.Categories.AddRange(categories);
                    context.SaveChanges();
                }

                // Seed Products
                if (!context.Products.Any())
                {
                    var products = new List<Product>()
                    {
                        new Product()
                        {
                            Name = "ASUS ROG Zephyrus",
                            Description = "High-performance gaming laptop with RTX 4060",
                            Price = 1299.99m,
                            Stock = 15,
                            ImagePath = "/images/products/asus-rog.jpg",
                            CategoryId = 1  // Laptops
                        },
                        new Product()
                        {
                            Name = "Lenovo Legion Pro",
                            Description = "Business laptop with Intel Core i7 and 16GB RAM",
                            Price = 899.99m,
                            Stock = 20,
                            ImagePath = "/images/products/lenovo-legion.jpg",
                            CategoryId = 1  // Laptops
                        },
                        new Product()
                        {
                            Name = "Dell XPS 15",
                            Description = "Premium laptop for professionals and creators",
                            Price = 1599.99m,
                            Stock = 10,
                            ImagePath = "/images/products/dell-xps.jpg",
                            CategoryId = 1  // Laptops
                        },
                        new Product()
                        {
                            Name = "HP Pavilion Desktop",
                            Description = "Affordable desktop for everyday computing",
                            Price = 599.99m,
                            Stock = 25,
                            ImagePath = "/images/products/hp-pavilion.jpg",
                            CategoryId = 2  // Desktops
                        },
                        new Product()
                        {
                            Name = "NZXT Builder PC",
                            Description = "Pre-built gaming desktop with RTX 4070",
                            Price = 1799.99m,
                            Stock = 12,
                            ImagePath = "/images/products/nzxt-builder.jpg",
                            CategoryId = 2  // Desktops
                        },
                        new Product()
                        {
                            Name = "LG 27\" 4K Monitor",
                            Description = "27-inch 4K IPS monitor for professional work",
                            Price = 399.99m,
                            Stock = 30,
                            ImagePath = "/images/products/lg-4k-monitor.jpg",
                            CategoryId = 3  // Monitors
                        },
                        new Product()
                        {
                            Name = "Dell S2421H 24\" Monitor",
                            Description = "24-inch Full HD monitor, great for office work",
                            Price = 199.99m,
                            Stock = 40,
                            ImagePath = "/images/products/dell-24-monitor.jpg",
                            CategoryId = 3  // Monitors
                        },
                        new Product()
                        {
                            Name = "Logitech MX Master 3S",
                            Description = "Advanced wireless mouse for productivity",
                            Price = 99.99m,
                            Stock = 50,
                            ImagePath = "/images/products/logitech-mx-master.jpg",
                            CategoryId = 4  // Peripherals
                        },
                        new Product()
                        {
                            Name = "Corsair K95 Mechanical Keyboard",
                            Description = "Premium mechanical keyboard with RGB lighting",
                            Price = 199.99m,
                            Stock = 35,
                            ImagePath = "/images/products/corsair-keyboard.jpg",
                            CategoryId = 4  // Peripherals
                        },
                        new Product()
                        {
                            Name = "Intel Core i9-13900KS",
                            Description = "Latest generation high-end CPU",
                            Price = 699.99m,
                            Stock = 8,
                            ImagePath = "/images/products/intel-i9.jpg",
                            CategoryId = 5  // Components
                        },
                        new Product()
                        {
                            Name = "NVIDIA RTX 4090",
                            Description = "Flagship graphics card for extreme performance",
                            Price = 1599.99m,
                            Stock = 5,
                            ImagePath = "/images/products/nvidia-4090.jpg",
                            CategoryId = 5  // Components
                        },
                        new Product()
                        {
                            Name = "Corsair Vengeance DDR5 32GB",
                            Description = "High-speed DDR5 memory kit (2x16GB)",
                            Price = 249.99m,
                            Stock = 22,
                            ImagePath = "/images/products/corsair-ram.jpg",
                            CategoryId = 5  // Components
                        }
                    };

                    context.Products.AddRange(products);
                    context.SaveChanges();
                }

                // Seed Customers
                if (!context.Customers.Any())
                {
                    var customers = new List<Customer>()
                    {
                        new Customer()
                        {
                            FirstName = "John",
                            LastName = "Smith",
                            Email = "john.smith@email.com",
                            Phone = "+1-555-0101",
                            Address = "123 Main St, New York, NY 10001"
                        },
                        new Customer()
                        {
                            FirstName = "Sarah",
                            LastName = "Johnson",
                            Email = "sarah.johnson@email.com",
                            Phone = "+1-555-0102",
                            Address = "456 Oak Ave, Los Angeles, CA 90001"
                        },
                        new Customer()
                        {
                            FirstName = "Michael",
                            LastName = "Williams",
                            Email = "michael.w@email.com",
                            Phone = "+1-555-0103",
                            Address = "789 Pine Rd, Chicago, IL 60601"
                        },
                        new Customer()
                        {
                            FirstName = "Emily",
                            LastName = "Brown",
                            Email = "emily.brown@email.com",
                            Phone = "+1-555-0104",
                            Address = "321 Elm St, Houston, TX 77001"
                        },
                        new Customer()
                        {
                            FirstName = "David",
                            LastName = "Davis",
                            Email = "david.davis@email.com",
                            Phone = "+1-555-0105",
                            Address = "654 Maple Dr, Phoenix, AZ 85001"
                        }
                    };

                    context.Customers.AddRange(customers);
                    context.SaveChanges();
                }

                // Seed Orders and OrderDetails
                if (!context.Orders.Any())
                {
                    var orders = new List<Order>()
                    {
                        new Order()
                        {
                            OrderDate = DateTime.Now.AddDays(-30),
                            TotalAmount = 1499.98m,
                            CustomerId = 1
                        },
                        new Order()
                        {
                            OrderDate = DateTime.Now.AddDays(-20),
                            TotalAmount = 599.98m,
                            CustomerId = 2
                        },
                        new Order()
                        {
                            OrderDate = DateTime.Now.AddDays(-10),
                            TotalAmount = 2099.97m,
                            CustomerId = 3
                        },
                        new Order()
                        {
                            OrderDate = DateTime.Now.AddDays(-5),
                            TotalAmount = 299.97m,
                            CustomerId = 4
                        },
                        new Order()
                        {
                            OrderDate = DateTime.Now,
                            TotalAmount = 1899.98m,
                            CustomerId = 5
                        }
                    };

                    context.Orders.AddRange(orders);
                    context.SaveChanges();
                }

                // Seed OrderDetails
                if (!context.OrderDetails.Any())
                {
                    var orderDetails = new List<OrderDetail>()
                    {
                        new OrderDetail()
                        {
                            OrderId = 1,
                            ProductId = 1,  // ASUS ROG Zephyrus
                            Quantity = 1,
                            UnitPrice = 1299.99m
                        },
                        new OrderDetail()
                        {
                            OrderId = 1,
                            ProductId = 8,  // Logitech MX Master
                            Quantity = 1,
                            UnitPrice = 99.99m
                        },
                        new OrderDetail()
                        {
                            OrderId = 2,
                            ProductId = 4,  // HP Pavilion Desktop
                            Quantity = 1,
                            UnitPrice = 599.99m
                        },
                        new OrderDetail()
                        {
                            OrderId = 3,
                            ProductId = 2,  // Lenovo Legion
                            Quantity = 1,
                            UnitPrice = 899.99m
                        },
                        new OrderDetail()
                        {
                            OrderId = 3,
                            ProductId = 6,  // LG 4K Monitor
                            Quantity = 1,
                            UnitPrice = 399.99m
                        },
                        new OrderDetail()
                        {
                            OrderId = 3,
                            ProductId = 9,  // Corsair Keyboard
                            Quantity = 1,
                            UnitPrice = 199.99m
                        },
                        new OrderDetail()
                        {
                            OrderId = 4,
                            ProductId = 8,  // Logitech MX Master
                            Quantity = 3,
                            UnitPrice = 99.99m
                        },
                        new OrderDetail()
                        {
                            OrderId = 5,
                            ProductId = 5,  // NZXT Builder
                            Quantity = 1,
                            UnitPrice = 1799.99m
                        },
                        new OrderDetail()
                        {
                            OrderId = 5,
                            ProductId = 8,  // Logitech Mouse
                            Quantity = 1,
                            UnitPrice = 99.99m
                        }
                    };

                    context.OrderDetails.AddRange(orderDetails);
                    context.SaveChanges();
                }
            }
        }
    }
}
