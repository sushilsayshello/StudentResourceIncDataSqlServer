using Assessment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment3.Data
{
    public class DbInitialiser
    {
        public static void Initialize(ResourceContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.StudentModels.Any() || context.ResourceModels.Any() || context.UnitModels.Any() || context.TeacherModels.Any() || context.CourseModels.Any())
            {
                return;   // DB has been seeded
            }

            var Student = new StudentModel[]
            {
                new StudentModel{ FirstName ="Sushil", LastName="Shakya", Email="email@gmail.com", Address="abc st nsw", Contact = "00123212"},
                new StudentModel{ FirstName ="Sushil", LastName="Shakya", Email="email@gmail.com", Address="abc st nsw", Contact = "00123212"},
                new StudentModel{ FirstName ="Sushil", LastName="Shakya", Email="email@gmail.com", Address="abc st nsw", Contact = "00123212"},
                new StudentModel{ FirstName ="Sushil", LastName="Shakya", Email="email@gmail.com", Address="abc st nsw", Contact = "00123212"},
                new StudentModel{ FirstName ="Sushil", LastName="Shakya", Email="email@gmail.com", Address="abc st nsw", Contact = "00123212"},
               
            };

            context.StudentModels.AddRange(Student);
            context.SaveChanges();


            var Resources = new ResourceModel[]
            {
                new ResourceModel{ ResourceName = "Laptop", ResourceType = "Level 1 Valuable", ResourceAvailability = true, ResourceQuantity = 100 },
                new ResourceModel{ ResourceName = "Laptop", ResourceType = "Level 1 Valuable", ResourceAvailability = true, ResourceQuantity = 100 },
                new ResourceModel{ ResourceName = "Laptop", ResourceType = "Level 1 Valuable", ResourceAvailability = true, ResourceQuantity = 100 },
                new ResourceModel{ ResourceName = "Laptop", ResourceType = "Level 1 Valuable", ResourceAvailability = true, ResourceQuantity = 100 },
                new ResourceModel{ ResourceName = "Laptop", ResourceType = "Level 1 Valuable", ResourceAvailability = true, ResourceQuantity = 100 },

            };

            context.ResourceModels.AddRange(Resources);
            context.SaveChanges();

            var Units = new UnitModel[]
                {
                new UnitModel{ UnitSpecification="ABC", ResourceRequirements="Abc" },
                new UnitModel{ UnitSpecification="ABC", ResourceRequirements="Abc" },
                new UnitModel{ UnitSpecification="ABC", ResourceRequirements="Abc" },
                new UnitModel{ UnitSpecification="ABC", ResourceRequirements="Abc" },
                new UnitModel{ UnitSpecification="ABC", ResourceRequirements="Abc" },
           

                };

            context.UnitModels.AddRange(Units);
            context.SaveChanges();

            var Teachers = new TeacherModel[]
                {
                    new TeacherModel{ FirstName ="Sushil", LastName="Shakya", Email="email@gmail.com", Address="abc st nsw", Contact = "00123212"},
                    new TeacherModel{ FirstName ="Sushil", LastName="Shakya", Email="email@gmail.com", Address="abc st nsw", Contact = "00123212"},
                    new TeacherModel{ FirstName ="Sushil", LastName="Shakya", Email="email@gmail.com", Address="abc st nsw", Contact = "00123212"},
                    new TeacherModel{ FirstName ="Sushil", LastName="Shakya", Email="email@gmail.com", Address="abc st nsw", Contact = "00123212"},
                    new TeacherModel{ FirstName ="Sushil", LastName="Shakya", Email="email@gmail.com", Address="abc st nsw", Contact = "00123212"},

                };

            context.TeacherModels.AddRange(Teachers);
            context.SaveChanges();

            var Courses = new CourseModel[]
                {

                    new CourseModel{ CourseName ="ABC", CourseUnits ="ABD", CourseDescription="ABD" },
                    new CourseModel{ CourseName ="ABC", CourseUnits ="ABD", CourseDescription="ABD" },
                    new CourseModel{ CourseName ="ABC", CourseUnits ="ABD", CourseDescription="ABD" },
                    new CourseModel{ CourseName ="ABC", CourseUnits ="ABD", CourseDescription="ABD" },
                    new CourseModel{ CourseName ="ABC", CourseUnits ="ABD", CourseDescription="ABD" },
                };

            context.CourseModels.AddRange(Courses);
            context.SaveChanges();


        }
    }
}
