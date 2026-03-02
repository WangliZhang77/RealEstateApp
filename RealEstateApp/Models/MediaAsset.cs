namespace RealEstateApp.Models
{
    public class MediaAsset
    {
        public int Id { get; set; }
        public string MediaType { get; set; } = string.Empty;
        public string MediaUrl { get; set; } = string.Empty;
        public bool IsSelected { get; set; }
        public bool IsMain { get; set; }
        public int ListingCaseId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }

        public ListingCase ListingCase { get; set; } = null!;
    }
}