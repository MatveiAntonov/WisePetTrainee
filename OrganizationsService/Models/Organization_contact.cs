namespace OrganizationsService.Models {
    public class Organization_contact {
        public int Id { get; set; }
        public int Organization_Id { get; set; }
        public int? Organization_Address_Id { get; set; }
        public string? Organization_Phone { get; set; } = String.Empty;

    }
}
