/* this code defines the database context, which is the main class that */
/* coodinates Entity Framework */
using Microsoft.EntityFrameworkCore;

class TodoDb : DbContext
{
  public TodoDb(DbContextOptions<TodoDb> options) : base(options) { }

  public DbSet<Todo> Todos => Set<Todo>();
}


