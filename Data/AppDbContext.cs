using auth_server.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace auth_server.Data;

public class AppDbContext(DbContextOptions options) : IdentityDbContext<User>(options);