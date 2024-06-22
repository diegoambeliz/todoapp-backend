using TodoApp.Entity.Db;

namespace TodoApp.Entity.Classes
{
    public class TaskGroupEntity
    {
        public string status { get; set; } = string.Empty;
        public IEnumerable<TaskEntity> tasks { get; set; } = Enumerable.Empty<TaskEntity>();
    }
}
