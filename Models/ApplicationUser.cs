using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OmarShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [StringLength(100)]
        public string? Name { get; set; }

        [PersonalData]
        public string? ProfilePicture { get; set; }

        // Navigation properties
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<CartItem>? CartItems { get; set; }
    }
} 