using Logistics.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Logistics.Startup))]
namespace Logistics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();
            //AddToAdmin();
        }

        // In this method we will create default User roles and Admin user for login   
        private void CreateRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // Create Roles witihin Identity    
            if (!roleManager.RoleExists("Admin"))
            {
                // Create Admin role   
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

            }

            // Creating Manager role    
            if (!roleManager.RoleExists("Manager"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Manager";
                roleManager.Create(role);

            }

            // Creating Employee role    
            if (!roleManager.RoleExists("Employee"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Employee";
                roleManager.Create(role);
            }
        }

        //private void AddToAdmin()
        //{
        //    ApplicationDbContext context = new ApplicationDbContext();

        //    var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
        //    string userName = "rickywhite@outlook.com";
        //    string roleName = "Admin";

        //    try
        //    {
        //        var user = UserManager.FindByName(userName);
        //        UserManager.AddToRole(user.Id, roleName);
        //        context.SaveChanges();
        //    }
        //    catch
        //    {
        //        throw;
        //    }
            
        //}
    
    }

    
}