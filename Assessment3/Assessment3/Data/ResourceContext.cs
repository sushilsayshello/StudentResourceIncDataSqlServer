using Microsoft.EntityFrameworkCore;
using Assessment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment3.Data
{
    public class ResourceContext : DbContext
    {
        public ResourceContext(DbContextOptions<ResourceContext> options)
            : base(options)
        {
        }

        public DbSet<StudentModel> StudentModels { get; set; }
        public DbSet<ResourceModel> ResourceModels { get; set; }
        public DbSet<RequestModel> Requests { get; set; }
        public DbSet<CourseModel> CourseModels { get; set; }
        public DbSet<UnitModel> UnitModels { get; set; }
        public DbSet<TeacherModel> TeacherModels { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<RequestModel> Reequest { get; set; }



/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitModel>()
                .HasOne(b => b.TeacherModel)
                .WithOne(i => i.UnitModel)
                .HasForeignKey<TeacherModel>(b => b.UnitForeignKey);

            modelBuilder.Entity<StudentResourceModel>()
            .HasOne(x => x.StudentModel)
            .WithMany(x => x.StudentResourceModels)
            .HasForeignKey(x => x.ResourceId); 

          modelBuilder.Entity<StudentResourceModel>()
                .HasOne(x => x.ResourceModel)
                .WithMany(x => x.StudentResourceModels)
                .HasForeignKey(x => x.StudentId);
        }*/

    }

}
