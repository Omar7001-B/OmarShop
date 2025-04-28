using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OmarShop.Models;

namespace OmarShop.Data
{
    public static class DbInitializer
    {
        public static async Task InitializeAsync(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // Make sure the database is created
            context.Database.EnsureCreated();

            // Look for roles
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                // Create Admin role
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            if (!await roleManager.RoleExistsAsync("Customer"))
            {
                // Create Customer role
                await roleManager.CreateAsync(new IdentityRole("Customer"));
            }

            // Look for an admin user
            if (!await context.Users.AnyAsync(u => u.Email == "admin@omarshop.com"))
            {
                // Create the admin user
                var adminUser = new ApplicationUser
                {
                    UserName = "admin@omarshop.com",
                    Email = "admin@omarshop.com",
                    EmailConfirmed = true,
                    Name = "Admin User",
                    ProfilePicture = "/images/defaults/admin-profile.jpg"
                };

                var result = await userManager.CreateAsync(adminUser, "Admin@123");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }

            // Look for products
            if (!await context.Products.AnyAsync())
            {
                // Add sample products
                var products = new List<Product>
                {
                    new Product
                    {
                        Name = "Smartphone X",
                        Description = "Latest smartphone with advanced features and high-resolution camera.",
                        Price = 799.99m,
                        StockQuantity = 50,
                        ImageUrl = "/uploads/images/smartphone-x.jpg"
                    },
                    new Product
                    {
                        Name = "Laptop Pro",
                        Description = "Powerful laptop for professionals with high performance and long battery life.",
                        Price = 1299.99m,
                        StockQuantity = 30,
                        ImageUrl = "/uploads/images/laptop-pro.jpg"
                    },
                    new Product
                    {
                        Name = "Wireless Headphones",
                        Description = "Premium wireless headphones with noise cancellation and superior sound quality.",
                        Price = 199.99m,
                        StockQuantity = 100,
                        ImageUrl = "/uploads/images/wireless-headphones.jpg"
                    },
                    new Product
                    {
                        Name = "Smart Watch",
                        Description = "Feature-rich smartwatch with health tracking and notification capabilities.",
                        Price = 249.99m,
                        StockQuantity = 45,
                        ImageUrl = "/uploads/images/smart-watch.jpg"
                    },
                    new Product
                    {
                        Name = "Bluetooth Speaker",
                        Description = "Portable Bluetooth speaker with superior sound quality and long battery life.",
                        Price = 89.99m,
                        StockQuantity = 75,
                        ImageUrl = "/uploads/images/bluetooth-speaker.jpg"
                    }
                };

                await context.Products.AddRangeAsync(products);
                await context.SaveChangesAsync();
            }
        }
    }
} 