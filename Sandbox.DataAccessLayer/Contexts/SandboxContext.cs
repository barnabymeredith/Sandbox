using Microsoft.EntityFrameworkCore;
using Sandbox.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DataAccessLayer.Contexts
{
    public class SandboxContext : DbContext
    {
        public DbSet<SpearmanDbo> SpearmanDbos { get; set; }
        public DbSet<SpearDbo> Spears {  get; set; }

        public string DbPath { get; }

        public SandboxContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "sandbox.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
