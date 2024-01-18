using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MILILAssesment.Models.Entities;

namespace MILILAssesment.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<PRBookInfo> tblPRBookInfo { get; set; }
    }

}
