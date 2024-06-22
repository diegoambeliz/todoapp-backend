using Dapper.Contrib.Extensions;

namespace TodoApp.Entity.Db
{
    [Table("task")]
    public class TaskEntity
    {
        [ExplicitKey]
        public Guid id { get; set; } = Guid.Empty;
        public string description { get; set; } = string.Empty;
        public DateTime deadline { get; set; } = DateTime.MinValue;
        public string status { get; set; } = string.Empty;
        public DateTime created_at { get; set; } = DateTime.MinValue;

    }
}
