using System.ComponentModel.DataAnnotations.Schema;

namespace Organizations.Domain.Entities {
    public class Organization {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public byte Rating { get; set; }
        public int? Chain_Id { get; set; }
        public int? Feedback_Id { get; set; }
        public short? Image_Id { get; set; }
        public byte Organization_Category_Id { get; set; }
    }
}
