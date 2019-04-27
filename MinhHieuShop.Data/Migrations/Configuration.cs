namespace MinhHieuShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MinhHieuShop.Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MinhHieuShop.Data.MinhHieuShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MinhHieuShop.Data.MinhHieuShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            CreateProductCategorySample(context);
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new MinhHieuShopDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new MinhHieuShopDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "thanhoangz",
            //    Email = "thanhoangz.international@gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Than Hoang"

            //};

            //manager.Create(user, "123654$");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("thanhoangz.international@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }

        private void CreateProductCategorySample(MinhHieuShop.Data.MinhHieuShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
                {
                    new ProductCategory() { Name="Điện lạnh",Alias="dien-lanh",Status=true },
                    new ProductCategory() { Name="Viễn thông",Alias="vien-thong",Status=true },
                    new ProductCategory() { Name="Đồ gia dụng",Alias="do-gia-dung",Status=true },
                    new ProductCategory() { Name="Mỹ phẩm",Alias="my-pham",Status=true }
                };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }

        }
    }
}
