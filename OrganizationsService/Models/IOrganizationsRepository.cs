namespace OrganizationsService.Models {
    public interface IOrganizationsRepository {
        IQueryable<Organization> Organizations { get; }
        IQueryable<Organization_contact> Organizations_contacts { get; }
        IQueryable<Organization_category> Organizations_categories { get; }
        IQueryable<Address> Addresses { get; }
        IQueryable<City> Cities { get; }
        IQueryable<Street> Streets { get; }
        IQueryable<Chain> Chains { get; }
    }
}
