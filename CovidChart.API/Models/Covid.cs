using System;

namespace CovidChart.API.Models
{
    public enum ECity
    {
        Istanbul = 1,
        Ankara,
        Izmir,
        Konya,
        Antalya
    }
    public class Covid
    {
        public int Id { get; set; }
        public ECity ECity { get; set; }
        public int Count { get; set; }
        public DateTime CovidDate { get; set; }
    }
}
