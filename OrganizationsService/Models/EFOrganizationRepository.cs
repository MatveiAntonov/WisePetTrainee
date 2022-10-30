namespace OrganizationsService.Models {
    public class EFOrganizationRepository : IOrganizationsRepository {
        private OrganizationsDbContext context;

        public EFOrganizationRepository(OrganizationsDbContext ctx) {
            context = ctx;
        }

        public IQueryable<Organization> Organizations => context.Organization;
        public IQueryable<Organization_category> Organizations_categories => context.Organization_category;
        public IQueryable<Organization_contact> Organizations_contacts => context.Organization_contact;
        public IQueryable<Address> Addresses => context.Address;
        public IQueryable<City> Cities => context.City;
        public IQueryable<Street> Streets => context.Street;
        public IQueryable<Chain> Chains => context.Chain;
    }
}
