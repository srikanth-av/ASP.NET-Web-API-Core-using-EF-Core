﻿using Microsoft.EntityFrameworkCore;

namespace DAL.EF.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItem { get; set; }

    }
}
