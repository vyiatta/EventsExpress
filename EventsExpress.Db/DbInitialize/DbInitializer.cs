﻿using EventsExpress.Db.EF;
using EventsExpress.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsExpress.Db.DbInitialize
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }
    public static class DbInitializer
    {

        public static void Seed(AppDbContext dbContext) {
            dbContext.Database.EnsureCreated();

            //Look for any users
            if (dbContext.Users.Any()) {
                return; // DB has been seeded
            }

            var users = new User[] {
                 new User{Name="Admin", PasswordHash="1234ADMIN", Email="admin@gmail.com", EmailConfirmed= true,
                 Phone="+380974293583", Birthday=DateTime.Parse("2000-01-01"), Gender=Enums.Gender.Male, IsBlocked=false},
                  new User{Name="User1", PasswordHash="1234ABCD", Email="user@gmail.com", EmailConfirmed= true,
                 Phone="+380970101013", Birthday=DateTime.Parse("2000-01-01"), Gender=Enums.Gender.Male, IsBlocked=false}
            };
            foreach (User u in users) {
                dbContext.Users.Add(u);
            }
            dbContext.SaveChanges();

            var categories = new Category[]
           {
                new Category{ Name="Sea"},
                new Category{ Name="Mount"},
                new Category{ Name="Summer"},
                new Category{ Name="Golf"},
                new Category{ Name="Team-Building"},
                new Category{ Name="Swimming"},
                new Category{ Name="Gaming"},
           };
            foreach (Category c in categories)
            {
                dbContext.Categories.Add(c);
            }
            dbContext.SaveChanges();
        }
    }
}
