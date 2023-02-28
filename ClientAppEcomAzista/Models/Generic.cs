namespace ClientAppEcomAzista.Models
{
    public class Generic
    {
        public int Id { get; set; }
        public string GenericCode { get; set; }
        public string GenericName { get; set; }
        public string GenericSynonyms { get; set; }
        public string Group { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
