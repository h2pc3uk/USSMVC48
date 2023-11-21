using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using USSMVC48.Models;

namespace USSMVC48.Data
{
    public class USSMVC48Context : DbContext
    {
        public USSMVC48Context() : base("name=SurveySystem")
        {
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<Form> Forms { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Response> Responses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>()
                .HasMany(f => f.Questions)
                .WithRequired(q => q.Form)
                .HasForeignKey(q => q.FormID);

            modelBuilder.Entity<Question>()
                .HasMany(q => q.Options)
                .WithRequired()
                .HasForeignKey(o =>  o.QuestionID);

            modelBuilder.Entity<Option>()
                .HasOptional(o => o.SkipToQuestion)
                .WithMany()
                .HasForeignKey(o => o.SkipToQuestionID);
        }
    }
}