using System;
using Microsoft.EntityFrameworkCore;

namespace myapp.Models;

public class myappContext : DbContext
{
	public myappContext(DbContextOptions<myappContext> options) : base(options) { }
	public DbSet<Item> Items { get; set; }
	

}
