using Microsoft.EntityFrameworkCore;

namespace EventBuddyMVC.Models{

    public class EventBuddyContext:DbContext{

        public EventBuddyContext(DbContextOptions<EventBuddyContext> options):base(options){}

        public DbSet<EventBuddy> EventBuddy{get; set;}

        public DbSet<Users> Users {get; set;}
    }


}