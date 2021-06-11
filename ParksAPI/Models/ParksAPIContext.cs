using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
  public class ParksAPIContext : DbContext
  {
    public ParksAPIContext(DbContextOptions<ParksAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
          .HasData(
              new Park { ParkId = 1, Name = "Saddle Mountain", Location = "Saddle Mountain State Park Rd, Seaside, OR, 97138", Review = "This park is open year round, but is only open for day use at the moment. Make sure to bring your own water and hand sanitizer, if need be. The hike can be difficult, but I will say the view is worth the work put in! You can see the ocean horizon at the very top!" },
              new Park { ParkId = 2, Name = "Angel's Rest Trailhead", Location = "East Historic Columbia River, Bridal Veil, OR, 97010", Review = "This hike can be pretty intensive, but totally worth the view, at least from the photos I've seen. Make sure you're endurance is up for this hike, or you might have to turn back like me." },
              new Park { ParkId = 3, Name = "Silver Falls", Location = "20024 Silver Falls Hwy SE, Sublimity, OR, 97385", Review = "Some trails have been closed due to the recent wildfires, but there are still some trails open at the moment. The many falls around are quite beautiful and refreshing. Some of the trails are quite narrow, so if you don't feel comfortable around many others, wear a mask and go during a time it's not so busy." },
              new Park { ParkId = 4, Name = "Wallowa Lake", Location = "Wallowa Lake State Park, Joseph, OR, 97846", Review = "Lots of camping and activities around and the lake is gorgeous! It is located in Easter Oregon, but worth the drive! The mountains surrounding the lake are breathtaking too." },
              new Park { ParkId = 5, Name = "Crater Lake", Location = "Crater Lake National Park, Rim Dr, OR, 97604", Review = "This is a must see Park! The water is so blue and beautiful! There are little critters everywhere too. Make sure you check the weather conditions before you go, the north entrance might be snowed in if it's too cold. Overall, lovely place!" }
          );
    }
  }
}