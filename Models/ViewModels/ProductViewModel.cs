namespace BharatCrafted.Models.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Prod> Products { get; set; }
    }
}
