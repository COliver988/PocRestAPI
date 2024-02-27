namespace PocRestAPI.Models
{
    public class LoggerData
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public string? MessageTemplate { get; set; }
        public string? Level { get; set; }
        public DateTime TimeStanp { get; set; }
        public string? Exception { get; set; }
        public string? Properties { get; set; }
    }
}