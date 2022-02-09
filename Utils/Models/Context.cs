using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Utils.Services;

namespace Utils.Models
{
    public class Context :DbContext
    {
        static DbContextOptionsBuilder<Context> dbBuilder = new DbContextOptionsBuilder<Context>();
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Context(DbContextOptions<Context> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            
        }

        public static Context GetNew()
        {
            dbBuilder = new DbContextOptionsBuilder<Context>();
            dbBuilder.UseSqlServer(JasonManger.GetConnectionString());
            return new Context(dbBuilder.Options);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Analysis> Analysiss { get; set; }
        public DbSet<AnalysisInfo> AnalysisInfos { get; set; }
        public DbSet<AnalysisResult> AnalysisResults { get; set; }
        public DbSet<AnalysisResultFile> AnalysisResultFiles { get; set; }
        public DbSet<ChronicDisease> ChronicDiseases { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<HealingPoint> HealingPoints { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Sensitive> Sensitives { get; set; }
        public DbSet<TherapeuticStage> TherapeuticStage { get; set; }
        public DbSet<UserBasicInfo> UserBasicInfos { get; set; }
        public DbSet<UserChronicDisease> UserChronicDiseases { get; set; }
        public DbSet<UserSecondaryInfo> UserSecondaryInfos { get; set; }
        public DbSet<UserSensitive> UserSensitives { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetForeignKeys())
                             .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);
        }

    }

    //we need this class in design time for update database, but in run time we dont need it
    public class SiteContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlServer();
            return new Context(optionsBuilder.Options);
        }

    }
}