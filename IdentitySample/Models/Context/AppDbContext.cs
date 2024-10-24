
using IdentitySample.Models.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentitySample.Models.Context
{
    // Identity tablolarına CRUD işlemleri yapabilmek için kullanılacak sınıflar
    // 1- UserManager: User işlemleri için kullanılır (user ekleme çıkarma, user'a role ekleme çıkarma, hash ekleme, Password Provider)
    // 2- RoleManager: Role işlemleri için kullanılır
    // 3- SignInManager: Login, Logout işlemlerini yönetmek için kullanılır
    // *** Claimler: User claims --> UserManager, Role claims --> RoleManager
    // *** Token, 3rd PA --> UserManager
    // *** Username, password, email için policy uygulayabileceğim


    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int, AppUserClaim, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>> 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
