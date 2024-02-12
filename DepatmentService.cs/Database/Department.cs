namespace DepatmentService.cs.Database
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
