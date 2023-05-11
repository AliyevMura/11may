namespace WebBackToFront.Models
{
    public class Category
    {
        private readonly List<Service> Service;

        public Category()
        {
            Service = new List<Service>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted{ get; set; }
        public virtual List<Service> Services { get; set; }
       
    }
}
