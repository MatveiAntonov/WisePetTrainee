namespace Organizations.Domain.Entities {
    public class OrganizationСontact {
        public int Id { get; set; }
        public int Organization_Id { get; set; }
        public int? Organization_Address_Id { get; set; }
        public string? Organization_Phone { get; set; } = String.Empty;

    }
}
