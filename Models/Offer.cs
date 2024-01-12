namespace FoodDelivery.Models
{
    public class Offer
    {
        public int ID{ get; set; }
        public int Uye_ID { get; set; }
        public decimal Minimum_Tutar { get; set; }
        public int Tekrar_Kullanim_Sayisi { get; set; }
        public decimal Indirim_Miktari { get; set; }
    }
}
