namespace FoodDelivery.Models
{
    public class EnterpriseStat
    {
        public int ID{ get; set; }
        public int Isletme_ID { get; set; }
        public int Uye_ID { get; set; }
        public decimal Puan { get; set; }
        public string Yorum { get; set; }
        public DateTime Tarih { get; set; }
    }
}
