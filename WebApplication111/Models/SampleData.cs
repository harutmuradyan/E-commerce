using System.Linq;
using WebApplication111.Models;

namespace WebApplication111
{
    public static class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                new Phone
                {
                    Name = "iPhone X",
                    Company = "Apple",
                    Price = 600
                },
                new Phone
                {
                    Name = "Samsung Galaxy Edge",
                    Company = "Samsung",
                    Price = 550
                },
                new Phone
                {
                    Name = "Pixel 3",
                    Company = "Google",
                    Price = 500
                },
                new Phone
                {
                    Name = "Pixel 5",
                    Company = "Google",
                    Price = 700
                }
                );
                context.SaveChanges();
            }
        }
    }
}