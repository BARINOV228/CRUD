namespace NonProject.Interface
{
    public interface IEmployee
    {
        public int Id { get; set; }
        public string? CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public string? DeletedDate { get; set; }
    }
}
