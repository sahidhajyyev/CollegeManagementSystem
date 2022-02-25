#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CollegeManagementSystem.Models;

namespace CollegeManagementSystem.Data
{
    public class CollegeManagementSystemContext : DbContext
    {
        public CollegeManagementSystemContext (DbContextOptions<CollegeManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<CollegeManagementSystem.Models.students> students { get; set; }
    }
}
