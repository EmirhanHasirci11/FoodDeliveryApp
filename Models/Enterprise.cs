namespace FoodDelivery.Models
{
    public class Enterprise
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public DateTime Son_Teslim_Tarih { get; set; }
        public decimal Minimum_Getirme_Tutar { get; set; }
        public decimal İsletme_Puan { get; set; }
        public string Adres { get; set; }
    }
}
