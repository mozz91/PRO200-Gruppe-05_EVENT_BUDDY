using System.ComponentModel.DataAnnotations;

namespace EventBuddyMVC.Models{

public class EventBuddy{

[Key]
public int ID { get; set; }

public string Name { get; set; }

public int Age { get; set; }

    }

}