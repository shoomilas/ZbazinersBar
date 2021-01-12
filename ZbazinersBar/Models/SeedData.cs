using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ZbazinersBar.Models {

    public static class SeedData {

        public static void EnsurePopulated(IApplicationBuilder app) {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }

            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product {
                        Name = "Pearl",
                        Description = "Cheap=Good",
                        Category = "Lager", Price = 250
                    },
                    new Product {
                        Name = "Zatecky",
                        Description = "The best among the best",
                        Category = "Lager", Price = 270
                    },
                    new Product {
                        Name = "Hazy Baby",
                        Description = "Is it foamy?",
                        Category = "IPA", Price = 550
                     },
                    new Product {
                        Name = "Heart Attack",
                        Description = "Is it nutty?",
                        Category = "APA", Price = 570
                    },
                    new Product {
                        Name = "Very hoppy",
                        Description = "Is it hoppy?",
                        Category = "Pale ale", Price = 670
                    },
                    new Product {
                        Name = "Fruit Ninja",
                        Description = "Does it have a surprisingly fruity taste that lingers on the tongue?",
                        Category = "Pilsner", Price = 620
                    },
                    new Product {
                        Name = "Second Breakfast",
                        Description = "Rich in Vitamin Beer",
                        Category = "Stout", Price = 630
                    },
                    new Product {
                        Name = "Pasaulio Skoniai",
                        Description = "crikey",
                        Category = "Australian Pale Ale", Price = 750
                    },
                    new Product {
                        Name = "Good Fortune",
                        Description = "Lucky you!",
                        Category = "Witbier", Price = 550
                    },
                    new Product {
                        Name = "The Red Dragon",
                        Description = "The more you drink, the more it burns",
                         Category = "Bitter", Price = 420
                    },
                    new Product {
                        Name = "Ale Dead Redemption",
                        Description = "You, Sir, Are A Fish",
                        Category = "Porter", Price = 670
                    },
                    new Product {
                        Name = "Crowning Glory",
                        Description = "It's Beer",
                        Category = "Lager", Price = 320
                    },
                    new Product {
                        Name = "A.L.E Noire",
                        Description = "Tell me the truth",
                        Category = "American pale ale", Price = 580
                    },
                    new Product {
                        Name = "Astronaut",
                        Description = "There ain't no space program for drinkers",
                        Category = "Dunkel", Price = 880
                    },
                    new Product {
                        Name = "Euphoria",
                        Description = "You still don't know my name",
                        Category = "Pilsner", Price = 670
                    },
                    new Product {
                        Name = "The Morning",
                        Description = "Fell it on your face",
                        Category = "Pale ale", Price = 770
                    },
                    new Product {
                        Name = "The Lighthouse",
                        Description = "Let Neptune strike ye dead",
                        Category = "Porter", Price = 640
                    },
                    new Product {
                        Name = "Once upon a beer",
                        Description = "Bounty Law",
                        Category = "Porter", Price = 670
                    },
                    new Product {
                        Name = "1984",
                        Description = "Big Beer is watching you",
                        Category = "APA", Price = 320
                    },
                    new Product {
                        Name = "Fried Gold",
                        Description = "Have a nice cold pint and wait for all of this to blow over",
                        Category = "Lager", Price = 200
                    },
                    new Product {
                        Name = "Grimey Slimey",
                        Description = "Your pal Jessie's favorite beer",
                        Category = "IPA", Price = 580
                    },
                    new Product {
                        Name = "Lost in time",
                        Description = "Like tears in rain",
                        Category = "India pale ale", Price = 340
                    },
                    new Product {
                        Name = "Toxic",
                        Description = "Too drunk, can't come down",
                        Category = "Brown ale", Price = 780
                    },
                    new Product {
                        Name = "Starry Night",
                        Description = "Beer so good, you will cut off your ear!",
                        Category = "Stout", Price = 550
                    },
                    new Product {
                        Name = "Violence",
                        Description = "You can't drink what I drink",
                        Category = "IPA", Price = 440
                    },
                    new Product {
                        Name = "Discovery",
                        Description = "Harder, Better, Faster, Stronger",
                        Category = "Lager", Price = 530
                    },
                    new Product {
                        Name = "After Hours",
                        Description = "You will never be scared to drink again",
                        Category = "Porter", Price = 380
                    },
                    new Product {
                        Name = "Against all logic",
                        Description = "Now I've got you drunk",
                        Category = "Witbier", Price = 490
                    },
                    new Product {
                        Name = "The Foamy Giant",
                        Description = "Superbeer",
                        Category = "Lager", Price = 310
                    },
                    new Product {
                        Name = "American Beauty",
                        Description = "It is hard to stay mad when there's so much beer in the world",
                        Category = "American Pale Ale", Price = 990
                    },
                    new Product {
                        Name = "Good Will Drinking",
                        Description = "How do you like them hops?",
                        Category = "Pilsner", Price = 470
                    },
                    new Product {
                        Name = "Good Time",
                        Description = "It is incredible, do you understand?",
                        Category = "APA", Price = 840
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
