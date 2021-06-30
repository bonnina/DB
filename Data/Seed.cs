using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using DB.Models;

namespace DB.Data
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(
                serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                SeedFood(context);
                SeedIllneses(context);
                SeedVaccinations(context);
                SeedMedicalRecords(context);
                SeedMeals(context);
                SeedMenus(context);
                SeedAnimals(context);
                SeedWorkers(context);
                SeedSuppliers(context);
                SeedTrades(context);
            }
        }

        public static void SeedWorkers(Context context)
        {
            if (!context.Workers.Any())
            {
                context.Workers.AddRange(
                    new Worker()
                    {
                        Id = 1,
                        FirstName = "Anna",
                        LastName = "Clark",
                        Gender = Worker.Sex.Female,
                        Age = 26,
                        Occupation = Worker.Job.Vet,
                        Payrate = 90000,
                        DateJoined = new DateTime(2020, 11, 08),
                        Animals = new List<Animal>
                        {
                            context.Animals.Where(a => a.Id == 1).FirstOrDefault(),
                            context.Animals.Where(a => a.Id == 3).FirstOrDefault()
                        }
                    },
                    new Worker()
                    {
                        Id = 2,
                        FirstName = "Tim",
                        LastName = "Franks",
                        Gender = Worker.Sex.Male,
                        Age = 23,
                        Occupation = Worker.Job.Cleaner,
                        Payrate = 50000,
                        DateJoined = new DateTime(2019, 04, 10),
                        Animals = new List<Animal>
                        {
                            context.Animals.Where(a => a.Id == 2).FirstOrDefault(),
                            context.Animals.Where(a => a.Id == 4).FirstOrDefault()
                        }
                    },
                    new Worker()
                    {
                        Id = 3,
                        FirstName = "Joy",
                        LastName = "Adams",
                        Gender = Worker.Sex.Female,
                        Age = 31,
                        Occupation = Worker.Job.Cleaner,
                        Payrate = 50000,
                        DateJoined = new DateTime(2021, 02, 03),
                        Animals = new List<Animal>
                        {
                            context.Animals.Where(a => a.Id == 7).FirstOrDefault()
                        }
                    },
                    new Worker()
                    {
                        Id = 4,
                        FirstName = "Mark",
                        LastName = "Prims",
                        Gender = Worker.Sex.Male,
                        Age = 21,
                        Occupation = Worker.Job.Builder,
                        Payrate = 65000,
                        DateJoined = new DateTime(2020, 12, 15)
                    },
                    new Worker()
                    {
                        Id = 5,
                        FirstName = "Kate",
                        LastName = "Kim",
                        Gender = Worker.Sex.Female,
                        Age = 34,
                        Occupation = Worker.Job.Administrator,
                        Payrate = 60000,
                        DateJoined = new DateTime(2018, 06, 05),
                        Animals = new List<Animal>
                        {
                            context.Animals.Where(a => a.Id == 11).FirstOrDefault(),
                            context.Animals.Where(a => a.Id == 13).FirstOrDefault()
                        }
                    },
                    new Worker()
                    {
                        Id = 6,
                        FirstName = "Dennis",
                        LastName = "Brown",
                        Gender = Worker.Sex.Male,
                        Age = 40,
                        Occupation = Worker.Job.Trainer,
                        Payrate = 65000,
                        DateJoined = new DateTime(2020, 07, 11),
                        Animals = new List<Animal>
                        {
                            context.Animals.Where(a => a.Id == 5).FirstOrDefault(),
                            context.Animals.Where(a => a.Id == 10).FirstOrDefault()
                        }
                    },
                    new Worker()
                    {
                        Id = 7,
                        FirstName = "Tom",
                        LastName = "Clark",
                        Gender = Worker.Sex.Male,
                        Age = 27,
                        Occupation = Worker.Job.Vet,
                        Payrate = 90000,
                        DateJoined = new DateTime(2020, 11, 10),
                        Animals = new List<Animal>
                        {
                            context.Animals.Where(a => a.Id == 6).FirstOrDefault(),
                            context.Animals.Where(a => a.Id == 9).FirstOrDefault()
                        }
                    },
                    new Worker()
                    {
                        Id = 8,
                        FirstName = "Jim",
                        LastName = "Wans",
                        Gender = Worker.Sex.Male,
                        Age = 39,
                        Occupation = Worker.Job.Cleaner,
                        Payrate = 52000,
                        DateJoined = new DateTime(2017, 10, 13)
                    },
                    new Worker()
                    {
                        Id = 9,
                        FirstName = "Kate",
                        LastName = "Bardwell",
                        Gender = Worker.Sex.Female,
                        Age = 30,
                        Occupation = Worker.Job.Cleaner,
                        Payrate = 51000,
                        DateJoined = new DateTime(2016, 04, 04),
                        Animals = new List<Animal>
                        {
                            context.Animals.Where(a => a.Id == 8).FirstOrDefault()
                        }
                    },
                    new Worker()
                    {
                        Id = 10,
                        FirstName = "Bob",
                        LastName = "Brado",
                        Gender = Worker.Sex.Male,
                        Age = 21,
                        Occupation = Worker.Job.Trainer,
                        Payrate = 65000,
                        DateJoined = new DateTime(2019, 11, 14),
                        Animals = new List<Animal>
                        {
                            context.Animals.Where(a => a.Id == 12).FirstOrDefault()
                        }
                    }
                );

                context.SaveChanges();
            }
        }

        public static void SeedFood(Context context)
        {
            if (!context.Foods.Any())
            {
                context.Foods.AddRange(
                    new Food() { Type = Food.FoodType.Birds },
                    new Food() { Type = Food.FoodType.Fish },
                    new Food() { Type = Food.FoodType.FishFood },
                    new Food() { Type = Food.FoodType.Fruit },
                    new Food() { Type = Food.FoodType.Grains },
                    new Food() { Type = Food.FoodType.Grass },
                    new Food() { Type = Food.FoodType.Hay },
                    new Food() { Type = Food.FoodType.Insects },
                    new Food() { Type = Food.FoodType.Meat },
                    new Food() { Type = Food.FoodType.Mice },
                    new Food() { Type = Food.FoodType.Vegetables }
                );

                context.SaveChanges();
            }
        }

        public static void SeedMeals(Context context)
        {
            if (!context.Meals.Any())
            {
                context.Meals.AddRange(
                    new Meal()
                    {
                        Id = 1,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Fish).FirstOrDefault(),
                        Amount = 0.05,
                        Time = new TimeSpan(8, 0, 0)
                    },
                    new Meal()
                    {
                        Id = 2,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Meat).FirstOrDefault(),
                        Amount = 0.1,
                        Time = new TimeSpan(19, 0, 0)
                    },
                    new Meal()
                    {
                        Id = 3,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Fruit).FirstOrDefault(),
                        Amount = 60,
                        Time = new TimeSpan(7, 0, 0)
                    },
                    new Meal()
                    {
                        Id = 4,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Hay).FirstOrDefault(),
                        Amount = 10,
                        Time = new TimeSpan(14, 0, 0)
                    },
                    new Meal()
                    {
                        Id = 5,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Grass).FirstOrDefault(),
                        Amount = 20.5,
                        Time = new TimeSpan(20, 0, 0)
                    },
                    new Meal()
                    {
                        Id = 6,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Fruit).FirstOrDefault(),
                        Amount = 30,
                        Time = new TimeSpan(14, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 7,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Meat).FirstOrDefault(),
                        Amount = 2,
                        Time = new TimeSpan(7, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 8,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Mice).FirstOrDefault(),
                        Amount = 1.5,
                        Time = new TimeSpan(16, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 9,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Fruit).FirstOrDefault(),
                        Amount = 2,
                        Time = new TimeSpan(7, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 10,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Vegetables).FirstOrDefault(),
                        Amount = 1.5,
                        Time = new TimeSpan(12, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 11,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Grass).FirstOrDefault(),
                        Amount = 1.5,
                        Time = new TimeSpan(20, 45, 0)
                    },
                    new Meal()
                    {
                        Id = 12,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Grains).FirstOrDefault(),
                        Amount = 2,
                        Time = new TimeSpan(7, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 13,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Grass).FirstOrDefault(),
                        Amount = 1.5,
                        Time = new TimeSpan(12, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 14,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Birds).FirstOrDefault(),
                        Amount = 2,
                        Time = new TimeSpan(9, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 15,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Fish).FirstOrDefault(),
                        Amount = 1.5,
                        Time = new TimeSpan(17, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 16,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Insects).FirstOrDefault(),
                        Amount = 0.1,
                        Time = new TimeSpan(10, 00, 0)
                    },
                    new Meal()
                    {
                        Id = 17,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Grains).FirstOrDefault(),
                        Amount = 0.05,
                        Time = new TimeSpan(20, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 18,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Fruit).FirstOrDefault(),
                        Amount = 0.1,
                        Time = new TimeSpan(8, 00, 0)
                    },
                    new Meal()
                    {
                        Id = 19,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Vegetables).FirstOrDefault(),
                        Amount = 0.05,
                        Time = new TimeSpan(14, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 20,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Fruit).FirstOrDefault(),
                        Amount = 0.05,
                        Time = new TimeSpan(21, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 21,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Fish).FirstOrDefault(),
                        Amount = 7,
                        Time = new TimeSpan(14, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 22,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Meat).FirstOrDefault(),
                        Amount = 2,
                        Time = new TimeSpan(7, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 23,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Mice).FirstOrDefault(),
                        Amount = 1.5,
                        Time = new TimeSpan(16, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 24,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Grains).FirstOrDefault(),
                        Amount = 2,
                        Time = new TimeSpan(7, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 25,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Grass).FirstOrDefault(),
                        Amount = 1.5,
                        Time = new TimeSpan(12, 30, 0)
                    },
                    new Meal()
                    {
                        Id = 26,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Fish).FirstOrDefault(),
                        Amount = 0.05,
                        Time = new TimeSpan(8, 0, 0)
                    },
                    new Meal()
                    {
                        Id = 27,
                        Food = context.Foods.Where(f => f.Type == Food.FoodType.Meat).FirstOrDefault(),
                        Amount = 0.1,
                        Time = new TimeSpan(19, 0, 0)
                    }
                );

                context.SaveChanges();
            }
        }

        public static void SeedMenus(Context context)
        {
            if (!context.Menus.Any())
            {
                context.Menus.AddRange(
                    new Menu
                    {
                        Id = 1,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 1).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 2).FirstOrDefault()
                        }
                    },
                    new Menu
                    {
                        Id = 2,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 3).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 4).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 5).FirstOrDefault()
                        }
                    },
                    new Menu
                    {
                        Id = 3,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 6).FirstOrDefault()
                        }
                    },
                    new Menu
                    {
                        Id = 4,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 7).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 8).FirstOrDefault()
                        }
                    },
                    new Menu
                    {
                        Id = 5,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 9).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 10).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 11).FirstOrDefault()
                        }
                    },
                    new Menu
                    {
                        Id = 6,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 12).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 13).FirstOrDefault()
                        }
                    },
                    new Menu
                    {
                        Id = 7,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 14).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 15).FirstOrDefault()
                        }
                    },
                    new Menu
                    {
                        Id = 8,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 16).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 17).FirstOrDefault()
                        }
                    },
                    new Menu
                    {
                        Id = 9,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 18).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 19).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 20).FirstOrDefault()
                        }
                    },
                    new Menu
                    {
                        Id = 10,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 21).FirstOrDefault()
                        }
                    },
                    new Menu
                    {
                        Id = 11,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 22).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 23).FirstOrDefault()
                        }
                    },
                    new Menu
                    {
                        Id = 12,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 24).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 25).FirstOrDefault()
                        }
                    },
                    new Menu
                    {
                        Id = 13,
                        Meals = new List<Meal>
                        {
                            context.Meals.Where(m => m.Id == 26).FirstOrDefault(),
                            context.Meals.Where(m => m.Id == 27).FirstOrDefault()
                        }
                    }
                );

                context.SaveChanges();
            }
        }

        public static void SeedIllneses(Context context)
        {
            if (!context.Illnesses.Any())
            {
                context.Illnesses.AddRange(
                    new Illness()
                    {
                        Id = 1,
                        Name = Illness.Desease.Rabies,
                        IsolationRequired = true,
                        DateStarted = new DateTime(2020, 12, 12),
                        DateEnded = new DateTime(2020, 12, 23)
                    },
                    new Illness()
                    {
                        Id = 2,
                        Name = Illness.Desease.Tetanus,
                        IsolationRequired = false,
                        DateStarted = new DateTime(2019, 03, 10),
                        DateEnded = new DateTime(2019, 04, 10)
                    },
                    new Illness()
                    {
                        Id = 3,
                        Name = Illness.Desease.Influenza,
                        IsolationRequired = true,
                        DateStarted = new DateTime(2021, 02, 19),
                        DateEnded = new DateTime(2021, 02, 28)
                    },
                    new Illness()
                    {
                        Id = 4,
                        Name = Illness.Desease.Tick,
                        IsolationRequired = true,
                        DateStarted = new DateTime(2020, 11, 10),
                        DateEnded = new DateTime(2020, 12, 05)
                    },
                    new Illness()
                    {
                        Id = 5,
                        Name = Illness.Desease.Anthrax,
                        IsolationRequired = true,
                        DateStarted = new DateTime(2020, 12, 10),
                        DateEnded = new DateTime(2020, 12, 25)
                    },
                    new Illness()
                    {
                        Id = 6,
                        Name = Illness.Desease.Arthritis,
                        IsolationRequired = false,
                        DateStarted = new DateTime(2020, 01, 06),
                        DateEnded = new DateTime(2020, 06, 05)
                    },
                    new Illness()
                    {
                        Id = 7,
                        Name = Illness.Desease.Botulism,
                        IsolationRequired = false,
                        DateStarted = new DateTime(2018, 10, 19),
                        DateEnded = new DateTime(2018, 10, 24)
                    },
                    new Illness()
                    {
                        Id = 8,
                        Name = Illness.Desease.Tick,
                        IsolationRequired = true,
                        DateStarted = new DateTime(2020, 12, 15),
                        DateEnded = new DateTime(2020, 12, 05)
                    },
                    new Illness()
                    {
                        Id = 9,
                        Name = Illness.Desease.Rabies,
                        IsolationRequired = true,
                        DateStarted = new DateTime(2020, 12, 14),
                        DateEnded = new DateTime(2020, 12, 25)
                    },
                    new Illness()
                    {
                        Id = 10,
                        Name = Illness.Desease.Encephalitis,
                        IsolationRequired = false,
                        DateStarted = new DateTime(2021, 04, 13),
                        DateEnded = new DateTime(2020, 04, 29)
                    },
                    new Illness()
                    {
                        Id = 11,
                        Name = Illness.Desease.Encephalitis,
                        IsolationRequired = false,
                        DateStarted = new DateTime(2021, 04, 15),
                        DateEnded = new DateTime(2020, 04, 30)
                    },
                    new Illness()
                    {
                        Id = 12,
                        Name = Illness.Desease.Influenza,
                        IsolationRequired = true,
                        DateStarted = new DateTime(2021, 02, 22),
                        DateEnded = new DateTime(2021, 03, 04)
                    }
                );

                context.SaveChanges();
            }
        }

        public static void SeedVaccinations(Context context)
        {
            if (!context.Vaccinations.Any())
            {
                context.Vaccinations.AddRange(
                    new Vaccination()
                    {
                        Id = 1,
                        Vaccine = Vaccination.Desease.Rabies,
                        Date = new DateTime(2019, 08, 01)
                    },
                    new Vaccination()
                    {
                        Id = 2,
                        Vaccine = Vaccination.Desease.Rabies,
                        Date = new DateTime(2020, 09, 01)
                    },
                    new Vaccination()
                    {
                        Id = 3,
                        Vaccine = Vaccination.Desease.Rabies,
                        Date = new DateTime(2021, 10, 01)
                    },
                    new Vaccination()
                    {
                        Id = 4,
                        Vaccine = Vaccination.Desease.Tetanus,
                        Date = new DateTime(2021, 12, 01)
                    },
                    new Vaccination()
                    {
                        Id = 5,
                        Vaccine = Vaccination.Desease.Leptospirosis,
                        Date = new DateTime(2020, 05, 01)
                    },
                    new Vaccination()
                    {
                        Id = 6,
                        Vaccine = Vaccination.Desease.Leptospirosis,
                        Date = new DateTime(2021, 05, 01)
                    },
                    new Vaccination()
                    {
                        Id = 7,
                        Vaccine = Vaccination.Desease.Leptospirosis,
                        Date = new DateTime(2022, 05, 01)
                    },
                    new Vaccination()
                    {
                        Id = 8,
                        Vaccine = Vaccination.Desease.Tetanus,
                        Date = new DateTime(2021, 12, 02)
                    },
                    new Vaccination()
                    {
                        Id = 9,
                        Vaccine = Vaccination.Desease.Tetanus,
                        Date = new DateTime(2021, 12, 04)
                    },
                     new Vaccination()
                     {
                         Id = 10,
                         Vaccine = Vaccination.Desease.Rabies,
                         Date = new DateTime(2021, 10, 02)
                     },
                     new Vaccination()
                     {
                         Id = 11,
                         Vaccine = Vaccination.Desease.Rabies,
                         Date = new DateTime(2021, 10, 03)
                     },
                      new Vaccination()
                      {
                          Id = 12,
                          Vaccine = Vaccination.Desease.Rabies,
                          Date = new DateTime(2021, 10, 04)
                      },
                       new Vaccination()
                       {
                           Id = 13,
                           Vaccine = Vaccination.Desease.Encephalitis,
                           Date = new DateTime(2019, 08, 01)
                       },
                       new Vaccination()
                       {
                           Id = 14,
                           Vaccine = Vaccination.Desease.Encephalitis,
                           Date = new DateTime(2019, 08, 03)
                       },
                       new Vaccination()
                       {
                           Id = 15,
                           Vaccine = Vaccination.Desease.Encephalitis,
                           Date = new DateTime(2019, 08, 04)
                       }
                );

                context.SaveChanges();
            }
        }

        public static void SeedMedicalRecords(Context context)
        {
            if (!context.MedicalRecords.Any())
            {
                context.MedicalRecords.AddRange(
                    new MedicalRecord()
                    {
                        Id = 1,
                        Fertility = true,
                        ExpectingChildren = false,
                        Illnesses = new List<Illness>
                        {
                            context.Illnesses.Where(i => i.Id == 1).FirstOrDefault(),
                            context.Illnesses.Where(i => i.Id == 3).FirstOrDefault()
                        },
                        Vaccinations = new List<Vaccination>
                        {
                            context.Vaccinations.Where(v => v.Id == 4).FirstOrDefault()
                        }
                    },
                    new MedicalRecord()
                    {
                        Id = 2,
                        Fertility = false,
                        ExpectingChildren = false,
                        Illnesses = new List<Illness>
                        {
                            context.Illnesses.Where(i => i.Id == 2).FirstOrDefault()
                        },
                        Vaccinations = new List<Vaccination>
                        {
                            context.Vaccinations.Where(v => v.Id == 1).FirstOrDefault(),
                            context.Vaccinations.Where(v => v.Id == 2).FirstOrDefault(),
                            context.Vaccinations.Where(v => v.Id == 3).FirstOrDefault()
                        }
                    },
                    new MedicalRecord()
                    {
                        Id = 3,
                        Fertility = false,
                        ExpectingChildren = true,
                        DateExpectingChildren = new DateTime(2021, 12, 30),
                        Vaccinations = new List<Vaccination>
                        {
                            context.Vaccinations.Where(v => v.Id == 5).FirstOrDefault(),
                            context.Vaccinations.Where(v => v.Id == 6).FirstOrDefault(),
                            context.Vaccinations.Where(v => v.Id == 7).FirstOrDefault()
                        }
                    },
                    new MedicalRecord()
                    {
                        Id = 4,
                        Fertility = true,
                        ExpectingChildren = false,
                        Illnesses = new List<Illness>
                        {
                            context.Illnesses.Where(i => i.Id == 4).FirstOrDefault()
                        },
                        Vaccinations = new List<Vaccination>
                        {
                            context.Vaccinations.Where(v => v.Id == 8).FirstOrDefault()
                        }
                    },
                    new MedicalRecord()
                    {
                        Id = 5,
                        Fertility = true,
                        ExpectingChildren = true,
                        DateExpectingChildren = new DateTime(2021, 12, 30),
                        Illnesses = new List<Illness>
                        {
                            context.Illnesses.Where(i => i.Id == 5).FirstOrDefault()
                        },
                        Vaccinations = new List<Vaccination>
                        {
                            context.Vaccinations.Where(v => v.Id == 9).FirstOrDefault()
                        }
                    },
                    new MedicalRecord()
                    {
                        Id = 6,
                        Fertility = true,
                        ExpectingChildren = true,
                        DateExpectingChildren = new DateTime(2023, 05, 10),
                        Illnesses = new List<Illness>
                        {
                            context.Illnesses.Where(i => i.Id == 6).FirstOrDefault(),
                            context.Illnesses.Where(i => i.Id == 7).FirstOrDefault()
                        },
                        Vaccinations = new List<Vaccination>
                        {
                            context.Vaccinations.Where(v => v.Id == 10).FirstOrDefault(),
                            context.Vaccinations.Where(v => v.Id == 13).FirstOrDefault()
                        }
                    },
                    new MedicalRecord()
                    {
                        Id = 7,
                        Fertility = true,
                        ExpectingChildren = false
                    },
                    new MedicalRecord()
                    {
                        Id = 8,
                        Fertility = false,
                        ExpectingChildren = false
                    },
                    new MedicalRecord()
                    {
                        Id = 9,
                        Fertility = true,
                        ExpectingChildren = true,
                        DateExpectingChildren = new DateTime(2022, 01, 20),
                        Vaccinations = new List<Vaccination>
                        {
                            context.Vaccinations.Where(v => v.Id == 11).FirstOrDefault()
                        }
                    },
                    new MedicalRecord()
                    {
                        Id = 10,
                        Fertility = true,
                        ExpectingChildren = false,
                        Vaccinations = new List<Vaccination>
                        {
                            context.Vaccinations.Where(v => v.Id == 12).FirstOrDefault(),
                            context.Vaccinations.Where(v => v.Id == 15).FirstOrDefault()
                        }
                    },
                    new MedicalRecord()
                    {
                        Id = 11,
                        Fertility = true,
                        ExpectingChildren = false,
                        Illnesses = new List<Illness>
                        {
                            context.Illnesses.Where(i => i.Id == 8).FirstOrDefault()
                        },
                        Vaccinations = new List<Vaccination>
                        {
                            context.Vaccinations.Where(v => v.Id == 14).FirstOrDefault()
                        }
                    },
                    new MedicalRecord()
                    {
                        Id = 12,
                        Fertility = true,
                        ExpectingChildren = false,
                        Illnesses = new List<Illness>
                        {
                            context.Illnesses.Where(i => i.Id == 9).FirstOrDefault(),
                            context.Illnesses.Where(i => i.Id == 10).FirstOrDefault()
                        }
                    },
                    new MedicalRecord()
                    {
                        Id = 13,
                        Fertility = true,
                        ExpectingChildren = false,
                        Illnesses = new List<Illness>
                        {
                            context.Illnesses.Where(i => i.Id == 11).FirstOrDefault(),
                            context.Illnesses.Where(i => i.Id == 12).FirstOrDefault()
                        }
                    }
                );

                context.SaveChanges();
            }
        }

        public static void SeedAnimals(Context context)
        {
            if (!context.Animals.Any())
            {
                context.Animals.AddRange(
                    new Animal()
                    {
                        Id = 1,
                        Name = "Teddy",
                        Species = "Bear",
                        Gender = Animal.Sex.Male,
                        Age = 5,
                        Weight = 175.5,
                        ClimatZone = Animal.Zone.Temperate,
                        DietType = Animal.Diet.Carnivore,
                        EnclosureNumber = 125,
                        DateJoined = new DateTime(2016, 07, 01),
                        NeedsRelocation = true,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 1).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 1).FirstOrDefault()
                    },
                    new Animal()
                    {
                        Id = 2,
                        Name = "Jumbo",
                        Species = "Elephant",
                        Gender = Animal.Sex.Female,
                        Age = 17,
                        Weight = 1504,
                        ClimatZone = Animal.Zone.Tropical,
                        DietType = Animal.Diet.Herbivore,
                        EnclosureNumber = 75,
                        DateJoined = new DateTime(2015, 11, 03),
                        NeedsRelocation = false,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 2).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 2).FirstOrDefault()
                    },
                    new Animal()
                    {
                        Id = 3,
                        Name = "Splash",
                        Species = "Dolphin",
                        Gender = Animal.Sex.Female,
                        Age = 4,
                        Weight = 560,
                        ClimatZone = Animal.Zone.Subtropical,
                        DietType = Animal.Diet.Carnivore,
                        EnclosureNumber = 101,
                        DateJoined = new DateTime(2018, 10, 10),
                        NeedsRelocation = false,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 3).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 3).FirstOrDefault(),
                    },
                    new Animal()
                    {
                        Id = 4,
                        Name = "Jo",
                        Species = "Wolf",
                        Gender = Animal.Sex.Male,
                        Age = 8,
                        Weight = 100,
                        ClimatZone = Animal.Zone.Temperate,
                        DietType = Animal.Diet.Carnivore,
                        EnclosureNumber = 23,
                        DateJoined = new DateTime(2020, 3, 11),
                        NeedsRelocation = false,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 4).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 4).FirstOrDefault()
                    },
                    new Animal()
                    {
                        Id = 5,
                        Name = "Wavy",
                        Species = "Dolphin",
                        Gender = Animal.Sex.Male,
                        Age = 5,
                        Weight = 500,
                        ClimatZone = Animal.Zone.Subtropical,
                        DietType = Animal.Diet.Carnivore,
                        EnclosureNumber = 100,
                        DateJoined = new DateTime(2018, 10, 01),
                        NeedsRelocation = false,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 5).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 10).FirstOrDefault()
                    },
                    new Animal()
                    {
                        Id = 6,
                        Name = "Motty",
                        Species = "Hippo",
                        Gender = Animal.Sex.Female,
                        Age = 3,
                        Weight = 2500,
                        ClimatZone = Animal.Zone.Subtropical,
                        DietType = Animal.Diet.Herbivore,
                        EnclosureNumber = 55,
                        DateJoined = new DateTime(2017, 01, 06),
                        NeedsRelocation = true,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 6).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 5).FirstOrDefault()
                    },
                    new Animal()
                    {
                        Id = 7,
                        Name = "Wu",
                        Species = "Wolf",
                        Gender = Animal.Sex.Female,
                        Age = 5,
                        Weight = 140,
                        ClimatZone = Animal.Zone.Subtropical,
                        DietType = Animal.Diet.Carnivore,
                        EnclosureNumber = 55,
                        DateJoined = new DateTime(2017, 01, 06),
                        NeedsRelocation = true,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 7).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 11).FirstOrDefault()
                    },
                    new Animal()
                    {
                        Id = 8,
                        Name = "Chip",
                        Species = "Octrich",
                        Gender = Animal.Sex.Female,
                        Age = 1,
                        Weight = 470,
                        ClimatZone = Animal.Zone.Subtropical,
                        DietType = Animal.Diet.Herbivore,
                        EnclosureNumber = 91,
                        DateJoined = new DateTime(2021, 02, 13),
                        NeedsRelocation = false,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 8).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 12).FirstOrDefault()
                    },
                    new Animal()
                    {
                        Id = 9,
                        Name = "Leo",
                        Species = "Lion",
                        Gender = Animal.Sex.Female,
                        Age = 1,
                        Weight = 1030,
                        ClimatZone = Animal.Zone.Subtropical,
                        DietType = Animal.Diet.Carnivore,
                        EnclosureNumber = 7,
                        DateJoined = new DateTime(2020, 08, 14),
                        NeedsRelocation = false,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 9).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 13).FirstOrDefault()
                    },
                    new Animal()
                    {
                        Id = 10,
                        Name = "Snif",
                        Species = "Fox",
                        Gender = Animal.Sex.Male,
                        Age = 2,
                        Weight = 130,
                        ClimatZone = Animal.Zone.Arctic,
                        DietType = Animal.Diet.Carnivore,
                        EnclosureNumber = 17,
                        DateJoined = new DateTime(2021, 05, 14),
                        NeedsRelocation = true,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 10).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 7).FirstOrDefault()
                    },
                    new Animal()
                    {
                        Id = 11,
                        Name = "Coco",
                        Species = "Parrot",
                        Gender = Animal.Sex.Female,
                        Age = 3,
                        Weight = 0.5,
                        ClimatZone = Animal.Zone.Tropical,
                        DietType = Animal.Diet.Herbivore,
                        EnclosureNumber = 2,
                        DateJoined = new DateTime(2018, 03, 14),
                        NeedsRelocation = false,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 11).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 8).FirstOrDefault()
                    },
                    new Animal()
                    {
                        Id = 12,
                        Name = "Macy",
                        Species = "Gorilla",
                        Gender = Animal.Sex.Male,
                        Age = 12,
                        Weight = 90.6,
                        ClimatZone = Animal.Zone.Tropical,
                        DietType = Animal.Diet.Herbivore,
                        EnclosureNumber = 83,
                        DateJoined = new DateTime(2017, 07, 25),
                        NeedsRelocation = true,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 12).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 9).FirstOrDefault()
                    },
                    new Animal()
                    {
                        Id = 13,
                        Name = "Trumpet",
                        Species = "Elephant",
                        Gender = Animal.Sex.Male,
                        Age = 2,
                        Weight = 1000,
                        ClimatZone = Animal.Zone.Tropical,
                        DietType = Animal.Diet.Herbivore,
                        EnclosureNumber = 76,
                        DateJoined = new DateTime(2019, 03, 05),
                        NeedsRelocation = false,
                        MedicalRecord = context.MedicalRecords.Where(m => m.Id == 13).FirstOrDefault(),
                        Menu = context.Menus.Where(m => m.Id == 6).FirstOrDefault()
                    }
                );

                context.SaveChanges();
            }
        }

        public static void SeedSuppliers(Context context)
        {
            if (!context.Suppliers.Any())
            {
                context.Suppliers.AddRange(
                    new Supplier()
                    {
                        Name = "Marine Foods LTD",
                        Food = new List<Food>
                        {
                            context.Foods.Where(f => f.Type == Food.FoodType.Fish).FirstOrDefault(),
                            context.Foods.Where(f => f.Type == Food.FoodType.FishFood).FirstOrDefault()
                        }
                    },
                    new Supplier()
                    {
                        Name = "Golden Grain",
                        Food = new List<Food>
                        {
                            context.Foods.Where(f => f.Type == Food.FoodType.Grains).FirstOrDefault()
                        }
                    },
                    new Supplier()
                    {
                        Name = "Freshy",
                        Food = new List<Food>
                        {
                            context.Foods.Where(f => f.Type == Food.FoodType.Fruit).FirstOrDefault(),
                            context.Foods.Where(f => f.Type == Food.FoodType.Vegetables).FirstOrDefault()
                        }
                    },
                    new Supplier()
                    {
                        Name = "Tim's Butchery",
                        Food = new List<Food>
                        {
                            context.Foods.Where(f => f.Type == Food.FoodType.Meat).FirstOrDefault()
                        }
                    },
                    new Supplier()
                    {
                        Name = "Poultry LTD",
                        Food = new List<Food>
                        {
                            context.Foods.Where(f => f.Type == Food.FoodType.Birds).FirstOrDefault()
                        }
                    }
                );

                context.SaveChanges();
            }
        }

        public static void SeedTrades(Context context)
        {
            if (!context.Trades.Any())
            {
                context.Trades.AddRange(
                    new Trade()
                    {
                        ZooName = "Bazel City Zoo",
                        Date = new DateTime(2021, 05, 14),
                        TradeType = Trade.Type.Recieved,
                        Animal = context.Animals.Where(w => w.Id == 10).FirstOrDefault()
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
