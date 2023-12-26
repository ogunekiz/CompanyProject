using Company.Business.Concrete;
using Company.DataAccess.DataContext;
using Company.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Company.Test.Tests
{
    public class PersonelTest
    {
        [Fact]

        public void TestGetPersonelListMethod()
        {
            var options = new DbContextOptionsBuilder<CompanyContext>()
                .UseInMemoryDatabase(databaseName: "CompanyDB")
                .Options;

            using (var context = new CompanyContext(options))
            {
                var testData = new List<Personel>
            {
                new Personel { Id = 1, No=12345678, Name="Osman", SurName="Akýn", City="Ýstanbul"}
            };

                context.Personels.AddRange(testData);
                context.SaveChanges();
            }

            using (var context = new CompanyContext(options))
            {
                var service = new PersonelManager(context);
                var result = service.GetList();
            }
        }

        [Fact]
        public void TestGetPersonelMethod()
        {
            var options = new DbContextOptionsBuilder<CompanyContext>()
                .UseInMemoryDatabase(databaseName: "CompanyDB")
                .Options;

            using (var context = new CompanyContext(options))
            {
                var testData = new List<Personel>
            {
                               new Personel {Id = 1, No = 12345678, Name = "Osman", SurName = "Akýn", City = "Ýstanbul"}
            };

                context.Personels.AddRange(testData);
                context.SaveChanges();
            }

            using (var context = new CompanyContext(options))
            {
                var service = new PersonelManager(context);
                var result = service.GetById(1);
            }
        }

        [Fact]
        public void TestDeletePersonelMethod()
        {
            var options = new DbContextOptionsBuilder<CompanyContext>()
                .UseInMemoryDatabase(databaseName: "CompanyDB")
                .Options;

            using (var context = new CompanyContext(options))
            {
                var testData = new List<Personel>
            {
                               new Personel {Id = 1, No = 12345678, Name = "Osman", SurName = "Akýn", City = "Ýstanbul"}
            };

                context.Personels.AddRange(testData);
                context.SaveChanges();
            }

            using (var context = new CompanyContext(options))
            {
                var service = new PersonelManager(context);
                service.Delete(1);
            }
        }

        [Fact]
        public void TestAddPersonelMethod()
        {
            var options = new DbContextOptionsBuilder<CompanyContext>()
                .UseInMemoryDatabase(databaseName: "CompanyDB")
                .Options;

            using (var context = new CompanyContext(options))
            {
                var service = new PersonelManager(context);
                service.Add(new Personel()
                {
                    Id = 1,
                    No = 12345678,
                    Name = "Osman",
                    SurName = "Akýn",
                    City = "Ýstanbul"
                });
            }
        }

        [Fact]
        public void TestUpdatePersonelMethod()
        {
            var options = new DbContextOptionsBuilder<CompanyContext>()
                .UseInMemoryDatabase(databaseName: "CompanyDB")
                .Options;

            using (var context = new CompanyContext(options))
            {
                var testData = new List<Personel>
            {
                                new Personel {Id = 1, No = 12345678, Name = "Osman", SurName = "Akýn", City = "Ýstanbul"}
            };

                context.Personels.AddRange(testData);
                context.SaveChanges();
            }

            using (var context = new CompanyContext(options))
            {
                var service = new PersonelManager(context);
                service.Update(new Personel()
                {
                    Id = 1,
                    No = 12345678,
                    Name = "Osman",
                    SurName = "Akýn",
                    City = "Ýstanbul"
                });
            }
        }
    }
}