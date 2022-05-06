using Microsoft.EntityFrameworkCore;

namespace FAQs.Models
{
    public class FAQContext : DbContext
    {
        public FAQContext(DbContextOptions<FAQContext> options)
            : base(options) { }

        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);
            modelBuilder.Entity<Topic>().HasKey(t => t.TopicId);

            modelBuilder.Entity<Category>().Property(c => c.CategoryId).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Topic>().Property(t => t.TopicId).IsRequired().HasMaxLength(200);

            // seed initial data

            modelBuilder.Entity<Category>().HasData(
               new Category { CategoryId = "gen", CName = "General" },
               new Category { CategoryId = "hist", CName = "History" }

            );

            modelBuilder.Entity<Topic>().HasData(
               //new Topic { TopicId = "all", TName = "All FAQs" },
               new Topic { TopicId = "boot", TName = "Bootstrap" },
               new Topic { TopicId = "csharp", TName = "C#" },
               new Topic { TopicId = "js", TName = "JavaScript" }

            );

            modelBuilder.Entity<FAQ>().HasData(
                new FAQ { 
                    QuestionId = 1,
                    QuestionName = "When was Bootstrap first released?",
                    Answer = "In 2011.",
                    TopicId = "boot",
                    CategoryId = "hist"
                },

                new FAQ
                {
                    QuestionId = 2,
                    QuestionName = "When was C# first released?",
                    Answer = "In 2002.",
                    TopicId = "csharp",
                    CategoryId = "hist"
                },

                new FAQ
                {
                    QuestionId = 3,
                    QuestionName = "When was JavaScript first released?",
                    Answer = "In 1995.",
                    TopicId = "js",
                    CategoryId = "hist"
                },

                new FAQ
                {
                    QuestionId = 4,
                    QuestionName = "What is JavaScript?",
                    Answer = "A general purpose scripting language that executes in a web browser.",
                    TopicId = "js",
                    CategoryId = "gen"
                },

                new FAQ
                {
                    QuestionId = 5,
                    QuestionName = "What is C#?",
                    Answer = "A general purpose object oriented language that uses a concise, Java-like syntax.",
                    TopicId = "csharp",
                    CategoryId = "gen"
                },

                new FAQ
                {
                    QuestionId = 6,
                    QuestionName = "What is Bootstrap?",
                    Answer = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                    TopicId = "boot",
                    CategoryId = "gen"
                }
                );

        }
    }
}
