namespace Organizations.Domain.Entities {
    public class Address {
        public int Id { get; set; }
        public short City_Id { get; set; }
        public short Street_Id { get; set; }
        public short? House_Number { get; set; }
        public short? Flat_Number { get; set; }
    }
}
