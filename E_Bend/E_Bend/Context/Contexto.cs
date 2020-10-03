using E_Bend.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace E_Bend.Context
{
    public class Contexto : DbContext
    {
        public DbSet<DobradorModel> Dobradores { get; set; }
        public DbSet<EquipeModel> Equipes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}