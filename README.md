# Many to Many

## 1. Create classes

### Cover.cs and Artist.cs

```csharp
namespace PublisherDomain
{
public class Cover
{
public Cover()
{
Artists = new List<Artist>();
}
public int CoverId { get; set; }
public string DesignIdea { get; set; }
public bool DigitalOnly { get; set; }
public List<Artist> Artists { get; set; }
}
}

namespace PublisherDomain
{
public class Cover
{
public Cover()
{
Artists = new List<Artist>();
}
public int CoverId { get; set; }
public string DesignIdea { get; set; }
public bool DigitalOnly { get; set; }
public List<Artist> Artists { get; set; }
}
}
```

## 1. Create a new project pubcontext

```csharp

using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData
{
public class PubContext : DbContext
{
public DbSet<Artist> Artists { get; set; }
public DbSet<Cover> Covers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=EfcoreBasics; User Id=sa; Password=Samuel@sql; Encrypt=False; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

```

## 1.existing-Artist-is given existing cover

```csharp
ConnectExistingArtistAndCoverObjects();
void ConnectExistingArtistAndCoverObjects()
{
var artistA = \_context.Artists.Find(1);
var artistB = \_context.Artists.Find(2);
var coverA = \_context.Covers.Find(1);
coverA.Artists.Add(artistA);
coverA.Artists.Add(artistB);
\_context.SaveChanges();
}
```

## 2.new cover to an existing artist

```csharp
CreateNewCoverWithExistingArtist();
void CreateNewCoverWithExistingArtist()
{
var artistA = \_context.Artists.Find(1);
var cover = new Cover { DesignIdea = "Author has provided a photo" };
cover.Artists.Add(artistA);
\_context.Covers.Add(cover);
\_context.SaveChanges();
}
```

## 3.new cover + new artist

```csharp
CreateNewArtistWithNewCover();
void CreateNewArtistWithNewCover()
{
var artist = new Artist { FirstName = "Grace", LastName = "Nduta" };
var newCover = new Cover { DesignIdea = "River and the source" };
artist.Covers.Add(newCover);
\_context.Artists.Add(artist);
\_context.SaveChanges();
}
```

## 4.Retrieve an artist with covers

```csharp
RetrieveAnArtistWithCovers();
void RetrieveAnArtistWithCovers()
{
var artistWithCovers = \_context.Artists
.Include(x => x.Covers)
.FirstOrDefault(a => a.ArtistId == 1);

if (artistWithCovers != null)
{
Console.WriteLine($"Artist: {artistWithCovers.FirstName} {artistWithCovers.LastName}");

       foreach (var cover in artistWithCovers.Covers)
       {
           Console.WriteLine($"Cover Design Idea: {cover.DesignIdea}");
       }

}
else
{
Console.WriteLine("Artist not found.");
}
}
```

## 5.Retrive a cover with its artist

```csharp
RetriveCoverWithArtists();
void RetriveCoverWithArtists()
{
var coverWithArtists = \_context.Covers.Include(c => c.Artists).FirstOrDefault(c => c.CoverId == 1);
if (coverWithArtists != null)
{
Console.WriteLine($"Covers : {coverWithArtists.DesignIdea}");
       foreach (var item in coverWithArtists.Artists)
       {
           Console.WriteLine($"Artists : {item.FirstName}");
}
}
else
{
Console.WriteLine("Covers not found");
}
}
```

## 6.Unassign an artist from a cover

```csharp
UnAssignAnArtistFromACover();
void UnAssignAnArtistFromACover()
{
var coverwithartist = \_context.Covers
.Include(c => c.Artists.Where(a => a.ArtistId == 2))
.FirstOrDefault(c => c.CoverId == 1);
//coverwithartist.Artists.RemoveAt(0);
\_context.Artists.Remove(coverwithartist.Artists[0]);
\_context.ChangeTracker.DetectChanges();
//var debugview = \_context.ChangeTracker.DebugView.ShortView;
\_context.SaveChanges();
}
```

## 7.Reassign cover

```csharp
ReassignACover();

void ReassignACover()
{
var coverwithartist4 = \_context.Covers
.Include(c => c.Artists.Where(a => a.ArtistId == 4))
.FirstOrDefault(c => c.CoverId == 5);

    coverwithartist4.Artists.RemoveAt(0);
    var artist3 = _context.Artists.Find(3);
    coverwithartist4.Artists.Add(artist3);
    _context.SaveChanges();

}
```

# End

```

```
