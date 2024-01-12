namespace FoodDelivery.Models
{
    public class User
    {
        public int ID{ get; set; }
        public string Ad{ get; set; }
        public string Soyad{ get; set; }
        public string Telefon{ get; set; }
        public string Mail{ get; set; }
        public DateTime Dogum_Tarihi { get; set; }
        public string Sifre { get; set; }
        public decimal Cuzdan_Bakiye { get; set; }
    }
}
