﻿using Microsoft.EntityFrameworkCore;

namespace Fiorella.DAL
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
    }
}
