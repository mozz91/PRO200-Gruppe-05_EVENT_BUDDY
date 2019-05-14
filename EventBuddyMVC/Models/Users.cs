using System.ComponentModel.DataAnnotations;

namespace EventBuddyMVC.Models{

    public class Users{

        [Key]
        public int ID {get; set;}
        
        public string userName { get; set; }
       
    }





}