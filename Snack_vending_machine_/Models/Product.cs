namespace Snack_vending_machine_.Models
{
    public class Product
    {
        public string Photo { get; set; }
        public float? Cost { get; set; }
        public int? Count { get; set; }

        public Product(string Photo, float Cost,int Count)
        {
            this.Photo = Photo;
            this.Cost = Cost;
            this.Count = Count;
        }
    }
}
