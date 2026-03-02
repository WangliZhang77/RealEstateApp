namespace RealEstateApp.Models
{
    public class UserIdentityUser
    {
        public string Id { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}