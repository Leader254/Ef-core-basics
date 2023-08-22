using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;
using System.Security.Cryptography;
//using PublisherDomain;

//using (PubContext context = new PubContext())
//{
//    context.Database.EnsureCreated();
//}

PubContext _context = new PubContext();

////GetAuthors();
////AddAuthors();
////GetAuthors();
//AddAuthorWithBook();
//GetAuthorsWithBook();

//InsertNewAuthorWithBook();
//void InsertNewAuthorWithBook()
//{
//    var author = new Author { FirstName = "James", LastName = "Kariuki" };
//    author.Books.Add(new Book { Title = "learning C# With Julie", PublishDate = DateTime.Now });
//    _context.Authors.Add(author);
//    _context.SaveChanges();
//}

//adding a book to an existing author
//InsertToExistingAuthor();
//void InsertToExistingAuthor()
//{
//    var author = _context.Authors.FirstOrDefault(a => a.FirstName == "Grace");
//    if (author != null)
//    {
//        author.Books.Add(new Book { Title = "C# is Fun", PublishDate = DateTime.Now });
//    }
//    _context.SaveChanges();
//}


// add new book to existing author in the database
//AddNewBookToExistingAuthor();
//void AddNewBookToExistingAuthor()
//{
//    var book = new Book
//    {
//        Title = "Many to many efcore",
//        PublishDate = DateTime.Now,
//    };
//    book.Author = _context.Authors.Find(1);
//    _context.Books.Add(book);
//    _context.SaveChanges();
//}
//void AddAuthorWithBook()
//{
//    var author = new Author { FirstName = "Samuel", LastName = "Gatheru" };
//    author.Books.Add(new Book { Title = "Programming with Julie", PublishDate = new DateTime(2023, 08, 19) });
//    author.Books.Add(new Book { Title = "C# Fundamentals", PublishDate = new DateTime(2023, 07, 20) });

//    using var context = new PubContext();
//    context.Authors.Add(author);
//    context.SaveChanges();
//}

//void GetAuthorsWithBook()
//{
//    using var context = new PubContext();
//    var authors = context.Authors.Include(author => author.Books).ToList();

//    foreach (var author in authors)
//    {
//        Console.WriteLine(author.FirstName + " " + author.LastName);
//        foreach(var book in author.Books)
//        {
//            Console.WriteLine("name:" + book.Title);
//        }
//    }
//}

//void AddAuthors()
//{
//    var author = new Author { FirstName = "Gatheru", LastName = "Samuel" };
//    using var context = new PubContext();
//    context.Authors.Add(author);
//    context.SaveChanges();
//}

//void GetAuthors()
//{
//    using var context = new PubContext();
//    var authors = context.Authors.ToList();
//    foreach (var author in authors)
//    {
//        Console.WriteLine(author.FirstName + " " + author.LastName);
//    }
//}

//AddSomeAuthors();
//SkipAndTakeAuthors();
//SortAuthors();

//FilterAuthors();

//void FilterAuthors()
//{
//    //var name = "Samuel";
//    //var authors = _context.Authors.Where(a => a.FirstName == name).ToList();

//    var name = "S%";
//   var authors = _context.Authors.Where(a => EF.Functions.Like(a.FirstName, name)).ToList();
//}

//AddSomeAuthors();
//void AddSomeAuthors()
//{
//    _context.Authors.Add(new Author { FirstName = "Jane", LastName = "Wamunyu" });
//    _context.Authors.Add(new Author { FirstName = "Jane", LastName = "Wamunyu" });
//    _context.Authors.Add(new Author { FirstName = "Jane", LastName = "Wamunyu" });
//    _context.Authors.Add(new Author { FirstName = "Elijah", LastName = "Kamau" });
//    _context.Authors.Add(new Author { FirstName = "Grace", LastName = "Nduta" });
//    _context.Authors.Add(new Author { FirstName = "Mark", LastName = "Wahome" });
//    _context.Authors.Add(new Author { FirstName = "Jane", LastName = "Wanagri" });
//    _context.SaveChanges();
//}

//void SkipAndTakeAuthors()
//{
//    var GroupSize = 2;
//    for (int i = 0; i < 5; i++)
//    {
//        var authors = _context.Authors.Skip(GroupSize * i).Take(GroupSize).ToList();
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine($"Group {i}");
//        Console.ResetColor();
//        foreach (var item in authors)
//        {
//            Console.WriteLine($"{item.FirstName} {item.LastName}");
//        }
//    }
//}
//QueryAggregate();
//void QueryAggregate()
//{
//    var author = _context.Authors.OrderByDescending(a => a.LastName)
//        .FirstOrDefault(a => a.FirstName == "Jane");
//}

//void SortAuthors()
//{
//    var authorsSortName = _context.Authors.OrderBy(a => a.FirstName).ThenBy(a => a.LastName).ToList();
//    authorsSortName.ForEach(a => Console.WriteLine(a.LastName + " " + a.FirstName));
//}

//UpdateNameFromDatabase();
//void UpdateNameFromDatabase()
//{
//    var author = _context.Authors.FirstOrDefault(a => a.FirstName == "Jane" && a.LastName == "Wanagri");
//    if (author != null)
//    {
//        author.LastName = "Wangari";
//        _context.SaveChanges();
//    }
//}

//UpdateMultipleAuthors();
//void UpdateMultipleAuthors()
//{
//    var authors = _context.Authors.Where(a => a.LastName == "Wamunyu").ToList();
//    foreach (var author in authors)
//    {
//        author.LastName = "Wamuyu";
//    }
//    _context.SaveChanges();
//}

//VariousOpsInDb();
//void VariousOpsInDb()
//{
//    var author = _context.Authors.Find(23);
//    author.FirstName = "Janet";

//    // var newAuthor = new Auth { FirstName = "David", LastName = "Munyiri" };
//    // _context.Authors.Add(newAuthor);
//    _context.Authors.Add(new Author { FirstName = "David", LastName = "Munyiri" });
//    _context.SaveChanges();

//}

//SaveAuthorInfo();
//void SaveAuthorInfo()
//{
//    var author = FindSpecificAuthor(30);
//    if(author?.FirstName == "Jane")
//    {
//        author.LastName = "Gatheru";
//        SaveThatSpecificAuthor(author);
//    }
//}
//Author FindSpecificAuthor(int id)
//{
//    using var context = new PubContext();
//    return context.Authors.Find(id);
//}

//void SaveThatSpecificAuthor(Author author)
//{
//    using var contextb = new PubContext();
//    contextb.Authors.Update(author);
//    contextb.SaveChanges();
//}

//DeleteAuthor();
//void DeleteAuthor()
//{
//    var author = _context.Authors.Find(29);
//    if(author != null)
//    {
//        _context.Authors.Remove(author);
//        _context.SaveChanges();
//    }
//}
//BulkAddUpdate();
//void BulkAddUpdate()
//{
//    var newAuthors = new Author[]
//    {
//        new Author {FirstName = "David", LastName = "Ngatia"},
//        new Author {FirstName = "Andrew", LastName = "Mucemi"}
//    };
//    _context.Authors.AddRange(newAuthors);
//    var book = _context.Books.Find(4);
//    book.Title = "C# and .NET";
//    _context.SaveChanges();
//}

//Eager loading in efcore
//EagerLoadAuthorsWithBooks();
//void EagerLoadAuthorsWithBooks()
//{
//    var authors = _context.Authors.Include(a => a.Books).ToList();
//    authors.ForEach(a =>
//    {
//        Console.WriteLine($"{a.FirstName} - ({a.Books.Count})");
//        a.Books.ForEach(b => Console.WriteLine("  " + b.Title));

//    });
//}

//explicit load a collection
//LoadCollection();
//void LoadCollection()
//{
//    var author = _context.Authors.FirstOrDefault(a => a.FirstName == "Samuel");
//    _context.Entry(author).Collection(a => a.Books).Load();
//}

//filter using related data
//FilterRelatedData(); 
//void FilterRelatedData()
//{
//    var authors = _context.Authors.Where(a => a.Books.Any(b => b.PublishDate.Month == 10 )).ToList();

//}
//CascadeDeleteInActionWhenTracked();
//void CascadeDeleteInActionWhenTracked()
//{
//    //note : I knew that author with id 2 had books in my sample database
//    var author = _context.Authors.Include(a => a.Books)
//     .FirstOrDefault(a => a.AuthorId == 2);
//    author.Books.Remove(author.Books[0]);
//    _context.ChangeTracker.DetectChanges();
//    _context.SaveChanges();
//}

//many to many

//1.existing-Artist-is given existing cover
//ConnectExistingArtistAndCoverObjects();
//void ConnectExistingArtistAndCoverObjects()
//{
//    var artistA = _context.Artists.Find(1);
//    var artistB = _context.Artists.Find(2);
//    var coverA = _context.Covers.Find(1);
//    coverA.Artists.Add(artistA);
//    coverA.Artists.Add(artistB);
//    _context.SaveChanges();
//}


//2.new cover to an existing artist
//CreateNewCoverWithExistingArtist();
//void CreateNewCoverWithExistingArtist()
//{
//    var artistA = _context.Artists.Find(1);
//    var cover = new Cover { DesignIdea = "Author has provided a photo" };
//    cover.Artists.Add(artistA);
//    _context.Covers.Add(cover);
//    _context.SaveChanges();
//}

//3.new cover + new artist
//CreateNewArtistWithNewCover();
//void CreateNewArtistWithNewCover()
//{
//    var artist = new Artist { FirstName = "Grace", LastName = "Nduta" };
//    var newCover = new Cover { DesignIdea = "River and the source" };
//    artist.Covers.Add(newCover);
//    _context.Artists.Add(artist);
//    _context.SaveChanges();
//}

//4.Retrive an artist with their covers

//RetrieveAnArtistWithCovers();
//void RetrieveAnArtistWithCovers()
//{
//    var artistWithCovers = _context.Artists
//        .Include(x => x.Covers)
//        .FirstOrDefault(a => a.ArtistId == 1);

//    if (artistWithCovers != null)
//    {
//        Console.WriteLine($"Artist: {artistWithCovers.FirstName} {artistWithCovers.LastName}");

//        foreach (var cover in artistWithCovers.Covers)
//        {
//            Console.WriteLine($"Cover Design Idea: {cover.DesignIdea}");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Artist not found.");
//    }
//}

//5.Retrive a cover with its artist
//RetriveCoverWithArtists();
//void RetriveCoverWithArtists()
//{
//    var coverWithArtists = _context.Covers.Include(c => c.Artists).FirstOrDefault(c => c.CoverId == 1);
//    if (coverWithArtists != null)
//    {
//        Console.WriteLine($"Covers : {coverWithArtists.DesignIdea}");
//        foreach (var item in coverWithArtists.Artists)
//        {
//            Console.WriteLine($"Artists : {item.FirstName}");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Covers not found");
//    }
//}

//6.Unassign an artist from a cover
//UnAssignAnArtistFromACover();
//void UnAssignAnArtistFromACover()
//{
//    var coverwithartist = _context.Covers
//        .Include(c => c.Artists.Where(a => a.ArtistId == 2))
//        .FirstOrDefault(c => c.CoverId == 1);
//    //coverwithartist.Artists.RemoveAt(0);
//    _context.Artists.Remove(coverwithartist.Artists[0]);
//    _context.ChangeTracker.DetectChanges();
//    //var debugview = _context.ChangeTracker.DebugView.ShortView;
//    _context.SaveChanges();
//}

//7.Reassign cover
ReassignACover();

void ReassignACover()
{
    var coverwithartist4 = _context.Covers
    .Include(c => c.Artists.Where(a => a.ArtistId == 4))
    .FirstOrDefault(c => c.CoverId == 5);

    coverwithartist4.Artists.RemoveAt(0);
    var artist3 = _context.Artists.Find(3);
    coverwithartist4.Artists.Add(artist3);
    _context.SaveChanges();
}


