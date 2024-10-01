namespace SOFARI
{
    public class Product
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string PreviewImg { get; set; }
        public required decimal? Price { get; set; }
        public required string Colors { get; set; }
        //public required string ColorTitleProduct { get; set; }
        //public required string ColorHex { get; set; }
        public required List<ProductImg> productImgs { get; set; }
        public Category? Category { get; set; }
    }
}
