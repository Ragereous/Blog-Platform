using blog_template_practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice
{
    public class BlogContext : DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogDB_templatetest;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add seed data for Category model:
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "MMO"
                },

                new Category()
                {
                    Id = 2,
                    Name = "RPG"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Shooter"
                });

            // Add seed data for Content model:
            modelBuilder.Entity<Content>().HasData(
                new Content()
                {
                    Id = 1,
                    Title = "World of Warcraft",
                    Body = "One of the most prominent MMOs out there, you’d think there’s more memes than players at this point. If you don’t have a life, or a significant other… Welcome home. If you have either of those things, when you pick up this game, buy them something nice to compensate for your soon-to-be missing presence.",
                    Author = "Leeroy Jenkins",
                    PublishDate = "10/21/2020",
                    CategoryId = 1
                },

                new Content()
                {
                    Id = 2,
                    Title = "New World",
                    Body = "Do you like crafting? Do you like running around, cutting down trees, heaving a metal object at rocks for hours at end? Well… you’ll like this. Sure you can fight things, but why do that when you can literally live your best life in this game?",
                    Author = "ILeftMyStoveOn",
                    PublishDate = "10/21/2020",
                    CategoryId = 1
                },

                new Content()
                {
                    Id = 3,
                    Title = "Star Wars: The Old Republic",
                    Body = "Oldie but goldie. Do you want to be a Sith, frying your boss with lightning to get a promotion? We got you. Do you want to be a Jedi who makes mildly amusing comments to your enemies? We got you. You’ve got a ship, a galaxy to explore and crewmates to romance. No excuses.",
                    Author = "HanShotFirst",
                    PublishDate = "10/21/2020",
                    CategoryId = 1,
                },

                new Content()
                {
                    Id = 4,
                    Title = "Jedi: Fallen Order",
                    Body = "I expected this to be terrible in typical EA fashion. It turned out to be one of the best Star Wars games in recent memory. Congratulations. If they had given us less ponchos and more sith magic, it’d be a 10/10.",
                    Author = "Order 66",
                    PublishDate = "10/21/2020",
                    CategoryId = 2
                },

                new Content()
                {
                    Id = 5,
                    Title = "Skyrim",
                    Body = "Do I even need to say anything? I Fus Ro Dah’d my horse off a cliff. Top that.",
                    Author = "DudeSomeoneStoleMySweetRoll",
                    PublishDate = "10/21/2020",
                    CategoryId = 2
                },

                new Content()
                {
                    Id = 6,
                    Title = "God of War",
                    Body = "Most commonly referred to as ‘Disappointed Father Simulator 2018’. Also, there’s a giant talking snake that is friendly.",
                    Author = "Boy",
                    PublishDate = "10/21/2020",
                    CategoryId = 2
                },

                new Content()
                {
                    Id = 7,
                    Title = "Destiny 2",
                    Body = "I don’t even have time to explain why I don’t have time to explain. That’s it. Go away.",
                    Author = "Activision",
                    PublishDate = "10/21/2020",
                    CategoryId = 3
                },

                new Content()
                {
                    Id = 8,
                    Title = "Star Wars: Squadrons",
                    Body = "You get to live out your fantasies of flying Star Wars ships, killing opposing faction pilots. You get to have a cute little dangly mini Ewok in your cockpit.",
                    Author = "Don’t Get Cocky, Kid",
                    PublishDate = "10/21/2020",
                    CategoryId = 3
                },

                new Content()
                {
                    Id = 9,
                    Title = "Warzone",
                    Body = "Lack of originality meets tons of Activision money. They made something that has few original ideas, but has enough polish to put other games to shame. Good job, I guess?",
                    Author = "ReviveMePls",
                    PublishDate = "10/21/2020",
                    CategoryId = 3
                });
        }
    }
}
