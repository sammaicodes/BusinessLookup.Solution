using Microsoft.EntityFrameworkCore;

namespace BusinessLookup.Models
{
  public class BusinessLookupContext : DbContext
  {
    public BusinessLookupContext(DbContextOptions<BusinessLookupContext> options)
        : base(options)
        {
        }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<LocalBusiness>()
        .HasData(
          new LocalBusiness { LocalBusinessId = 1, BusinessType = "Restaurant", BusinessName = "Pok Pok", Review = "I love this restautant. It is SE Asian inspired and the food is sooo delicious. The only downside is you do have to wait a long time", RateReview = 4 },
          new LocalBusiness { LocalBusinessId = 2, BusinessType = "Restaurant", BusinessName = "Loving Hut", Review = "Even though i'm not vegan, the food here is absolutely delicious. I've eaten here numerous times and everything I've tryied is mouthwatering", RateReview = 5 },
          new LocalBusiness { LocalBusinessId = 2, BusinessType = "Bar", BusinessName = "Chowder Tavern", Review = "Its a must. All their drinks are super different. I had the clammy blody mary and it was one of the best I've had", RateReview = 4 },
          new LocalBusiness { LocalBusinessId = 3, BusinessType = "Flowe Shop", BusinessName = "Happy Orchid", Review = "They have a wide veriety of flowers and they also offer classes with a pretty awesome instructor", RateReview = 5 },
          new LocalBusiness { LocalBusinessId = 4, BusinessType = "Hardware Shop", BusinessName = "Crazy Hammer", Review = "Its your regular well-stock hardware store. But their staff is limited and hard to get help.", RateReview = 3 },
          new LocalBusiness { LocalBusinessId = 5, BusinessType = "Grocery Shop", BusinessName = "Freemont", Review = "Even though its a small neighborhood store, it is very well stocked, you can find just about anything", RateReview = 5 }
        );
    }
    public DbSet<LocalBusiness> LocalBusinesses { get; set; }
  }
}