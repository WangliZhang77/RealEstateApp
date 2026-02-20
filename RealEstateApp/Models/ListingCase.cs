using System.Data;

namespace RealEstateApp.Models
{
    public class ListingCase
    {
    public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string Street { get; set;}

        public string City { get; set; }

        public string State { get; set; }

        public int postcode { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }

        public decimal Price { get; set; }

        public int Bedrooms { get; set; }

        public int Bathrooms { get; set;}

        public int Garages { get; set;}

        public double FloorArea { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsDeleted { get; set; }

        public PropertyType PropertyType { get; set; }
        public SaleCategory SaleCategory { get; set; }
        public ListingCaseStatus ListingCaseStatus { get; set; }
        public string UserId { get; set; }

    }
    public enum PropertyType
    {
        Unknown = 0,
        House = 1,
        Apartment = 2,
        Townhouse = 3
    }

    public enum SaleCategory
    {
        Unknown = 0,
        ForSale = 1,
        ForRent = 2
    }

    public enum ListingCaseStatus
    {
        Draft = 0,
        Active = 1,
        UnderOffer = 2,
        Sold = 3
    }
}
