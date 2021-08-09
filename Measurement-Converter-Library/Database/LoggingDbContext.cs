using Measurement_Converter_Library.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Measurement_Converter_FrontEnd.Database
{
    public class LoggingDbContext : DbContext
    {
        public LoggingDbContext(DbContextOptions<LoggingDbContext> options) : base(options)
        { 
        
        }

        public DbSet<LoggingObj> Logs { get; set; }
    }
}
