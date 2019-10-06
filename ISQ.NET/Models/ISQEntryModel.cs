namespace ISQ.NET.Models
{
    public class ISQEntryModel
    {
        public int Id { get; set; }
        public string Term { get; set; }
        public string Professor { get; set; }
        public int CRN { get; set; }
        public int NResponded { get; set; }
        public int NTotal { get; set; }
        public int Pct5 { get; set; }
        public int Pct4 { get; set; }
        public int Pct3 { get; set; }
        public int Pct2 { get; set; }
        public int Pct1 { get; set; }
    }
}