namespace TodoApp.Dto
{
    public class TaskViewDto
    {
        public Guid id { get; set; } = Guid.Empty;
        public string description { get; set; } = string.Empty;
        public DateTime deadline { get; set; } = DateTime.MinValue;
    }
}
