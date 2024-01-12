namespace FoodDelivery.Models
{
    public class Order
    {
        public int ID{ get; set; }
        public int Uye_ID { get; set; }
        public int Adres_ID { get; set; }
        public int Isletme_ID { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
        public string Odeme_Turu { get; set; }
    }
}
