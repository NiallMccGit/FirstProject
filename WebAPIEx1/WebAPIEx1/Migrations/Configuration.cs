namespace WebAPIEx1.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPIEx1.Models.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAPIEx1.Models.DBContext context)
        {
            //var Students = new List<Student>
            //{
            //    new Student() {FirstName= "John",SecondName="Frank"},
            //    new Student() {FirstName= "Jane",SecondName="Frank"},
            //    new Student() {FirstName= "Mark",SecondName="Frank"},
            //    new Student() {FirstName= "Mary",SecondName="Frank"}
            //};
            //Students.ForEach(u => context.Students.Add(u));

            //base.Seed(context);
        }
    }
}
