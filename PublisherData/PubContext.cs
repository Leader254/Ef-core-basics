using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData
{
    public class PubContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cover> Covers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PublisherDatabase").LogTo(Console.WriteLine,
            //new[] { DbLoggerCategory.Database.Command.Name },
            //        LogLevel.Information);
            optionsBuilder.UseSqlServer("Server=localhost; Database=EfcoreBasics; User Id=sa; Password=Samuel@sql; Encrypt=False; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to many
            //modelBuilder.Entity<Author>().HasData(
            //    new Author { AuthorId = 1, FirstName = "Samuel", LastName = "Wachira" }
            //    );

            //var authorsList = new Author[]
            //{
            //    new Author {AuthorId = 2, FirstName = "Janet", LastName = "Gatheru"},
            //    new Author {AuthorId = 3, FirstName = "Grace", LastName = "Nduta"}
            //};
            //modelBuilder.Entity<Author>().HasData(authorsList);

            //var bookList = new Book[]
            //{
            //    new Book { AuthorId = 1, BookId = 2, Title = "C# Learning", PublishDate = new DateTime(2023, 08, 08) },
            //    new Book { AuthorId = 2, BookId = 3, Title = "Fundamentals", PublishDate = new DateTime(2023, 10, 10) },
            //};
            //modelBuilder.Entity<Book>().HasData(bookList);

            //many to many
            var someArtists = new Artist[]{
                new Artist {ArtistId = 1, FirstName = "Pablo", LastName="Picasso"},
                new Artist {ArtistId = 2, FirstName = "Dee", LastName="Bell"},
                new Artist {ArtistId = 3, FirstName ="Katharine", LastName="Kuharic"} };
            modelBuilder.Entity<Artist>().HasData(someArtists);
            var someCovers = new Cover[]{
                new Cover {CoverId = 1, DesignIdea="How about a left hand in the dark?", DigitalOnly=false},
                new Cover {CoverId = 2, DesignIdea= "Should we put a clock?", DigitalOnly=true},
                new Cover {CoverId = 3, DesignIdea="A big ear in the clouds?", DigitalOnly = false}};
            modelBuilder.Entity<Cover>().HasData(someCovers);


        }
    }
}