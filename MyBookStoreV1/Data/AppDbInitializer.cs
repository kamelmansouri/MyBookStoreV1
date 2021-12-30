using MyBookStoreV1.Data.Models;

namespace MyBookStoreV1.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {

            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(

                    new Book()
                    {
                        Title = "First Asp.net Core",
                        Description = "Fisrt description",
                        CoverURL = "//",
                        DateAdd = DateTime.Now.AddDays(-5),
                        DateRead = DateTime.Now,
                        Genre = "Develepment",
                        IsRead = true,
                        Rate = 4
                    },
                    new Book()
                    {
                        Title = "Angular",
                        Description = "Angular description",
                        CoverURL = "//",
                        DateAdd = DateTime.Now.AddDays(-15),
                        DateRead = DateTime.Now,
                        Genre = "Develepment",
                        IsRead = true,
                        Rate = 3
                    },
                    new Book()
                    {
                        Title = "First Head Asp.net Core",
                        Description = "Fisrt Head",
                        CoverURL = "//",
                        DateAdd = DateTime.Now.AddDays(-10),
                        DateRead = DateTime.Now,
                        Genre = "Develepment",
                        IsRead = true,
                        Rate = 5
                    }

                );

                    context.SaveChanges();
                }
            }
        }
    }
}
