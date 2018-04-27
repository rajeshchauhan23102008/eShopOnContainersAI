﻿using System;
using System.Collections.Generic;
using System.Text;
using eDashboard.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Scripts.Cli
{
    public class CatalogContextDesignTimeFactory : IDesignTimeDbContextFactory<CatalogContext>
    {
        public CatalogContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CatalogContext>();

            builder.UseSqlServer("x");

            return new CatalogContext(builder.Options);
        }
    }
}
