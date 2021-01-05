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
<<<<<<< HEAD
                                           Name = "Pearl",
                                           Description = "Cheap=Good",
                                           Category = "Lager", Price = 2.5
                                       },
                    new Product {
                                           Name = "Zatecky",
                                           Description = "The best among the best",
                                           Category = "Lager", Price = 2.7
                                       },
                    new Product {
                                           Name = "Hazy Baby",
                                           Description = "Is it foamy?",
                                           Category = "IPA", Price = 5.5
                                        },
                    new Product {
                                           Name = "Heart Attack",
                                           Description = "Is it nutty?",
                                           Category = "APA", Price = 5.7
                                       },
                    new Product {
                                           Name = "Very hoppy",
                                           Description = "Is it hoppy?",
                                           Category = "Pale ale", Price = 6.7
                                       },
                    new Product {
                                           Name = "Fruit Ninja",
                                           Description = "Does it have a surprisingly fruity taste that lingers on the tongue?",
                                           Category = "Pilsner", Price = 6.2
                                       },
                    new Product {
                                           Name = "Second Breakfast",
                                           Description = "Rich in Vitamin Beer",
                                           Category = "Stout", Price = 6.3
                                       },
                    new Product {
                                           Name = "Pasaulio Skoniai",
                                           Description = "crikey",
                                           Category = "Australian Pale Ale", Price = 7.5
                                       },
                    new Product {
                                           Name = "Good Fortune",
                                           Description = "Lucky you!",
                                           Category = "Witbier", Price = 5.5
                                       },
                    new Product {
                                           Name = "The Red Dragon",
                                           Description = "The more you drink, the more it burns",
                                            Category = "Bitter", Price = 4.2
                                       },
                    new Product {
                                           Name = "Ale Dead Redemption",
                                           Description = "You, Sir, Are A Fish",
                                           Category = "Porter", Price = 6.7
                                       },
                    new Product {
                                           Name = "Crowning Glory",
                                           Description = "It's Beer",
                                           Category = "Lager", Price = 3.2
                                       },
                                       new Product {
                                           Name = "A.L.E Noire",
                                           Description = "Tell me the truth",
                                           Category = "American pale ale", Price = 5.8
                                       },
                                       new Product {
                                           Name = "Astronaut",
                                           Description = "There ain't no space program for drinkers",
                                           Category = "Dunkel", Price = 8.8
                                       },
                                       new Product {
                                           Name = "Euphoria",
                                           Description = "You still don't know my name",
                                           Category = "Pilsner", Price = 6.7
                                       },
                                       new Product {
                                           Name = "The Morning",
                                           Description = "Fell it on your face",
                                           Category = "Pale ale", Price = 7.7
                                       },
                                       new Product {
                                           Name = "The Lighthouse",
                                           Description = "Let Neptune strike ye dead",
                                           Category = "Porter", Price = 6.4
                                       },
                                       new Product {
                                           Name = "Once upon a beer",
                                           Description = "Bounty Law",
                                           Category = "Porter", Price = 6.7
                                       },
                                       new Product {
                                           Name = "1984",
                                           Description = "Big Beer is watching you",
                                           Category = "APA", Price = 3.2
                                       },
                                       new Product {
                                           Name = "Fried Gold",
                                           Description = "Have a nice cold pint and wait for all of this to blow over",
                                           Category = "Lager", Price = 2.0
                                       },
                                       new Product {
                                           Name = "Grimey Slimey",
                                           Description = "Your pal Jessie's favorite beer",
                                           Category = "IPA", Price = 5.8
                                       },
                                       new Product {
                                           Name = "Lost in time",
                                           Description = "Like tears in rain",
                                           Category = "India pale ale", Price = 3.4
                                       },
                                       new Product {
                                           Name = "Toxic",
                                           Description = "Too high, can't come down",
                                           Category = "Brown ale", Price = 7.8
                                       },
                                       new Product {
                                           Name = "Starry Night",
                                           Description = "Beer so good, you will cut off your ear!",
                                           Category = "Stout", Price = 5.5
                                       },
                                       new Product {
                                           Name = "Violence",
                                           Description = "You can't drink what I drink",
                                           Category = "IPA", Price = 4.4
                                       },
                                       new Product {
                                           Name = "Discovery",
                                           Description = "Harder, Better, Faster, Stronger",
                                           Category = "Lager", Price = 5.3
                                       },
                                       new Product {
                                           Name = "After Hours",
                                           Description = "You will never be scared to drink again",
                                           Category = "Porter", Price = 3.8
                                       },
                                       new Product {
                                           Name = "Against all logic",
                                           Description = "Now I've got you drunk",
                                           Category = "Witbier", Price = 4.9
                                       },
                                       new Product {
                                           Name = "The Foamy Giant",
                                           Description = "Superbeer",
                                           Category = "Lager", Price = 3.1
                                       },
                                       new Product {
                                           Name = "American Beauty",
                                           Description = "It is hard to stay nad when there's so much beer in the world",
                                           Category = "American Pale Ale", Price = 9.9
                                       },
                                       new Product {
                                           Name = "Good Will Drinking",
                                           Description = "How do you like them hops?",
                                           Category = "Pilsner", Price = 4.7
                                       },
                                       new Product {
                                           Name = "Good Time",
                                           Description = "It is incredible, do you understand?",
                                           Category = "APA", Price = 8.4
                                       }
=======
                        Name = "Kayak", Description = "A boat for one person",
                        Category = "Watersports", Price = 275
                    },
                    new Product {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports", Price = 48.95m
                    },
                    new Product {
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer", Price = 19.50m
                    },
                    new Product {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer", Price = 34.95m
                    },
                    new Product {
                        Name = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer", Price = 79500
                    },
                    new Product {
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Chess", Price = 16
                    },
                    new Product {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess", Price = 29.95m
                    },
                    new Product {
                        Name = "Human Chess Board",
                        Description = "A fun game for the family",
                        Category = "Chess", Price = 75
                    },
                    new Product {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "Chess", Price = 1200
                    }
>>>>>>> parent of ffd75d8... piwka
                );
                context.SaveChanges();
            }
        }
    }
}
