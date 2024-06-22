namespace TodoApp.Dto
{
    public class TaskGroupViewDto
    {
        public string status { get; set; } = string.Empty;
        public IEnumerable<TaskViewDto> tasks { get; set; } = Enumerable.Empty<TaskViewDto>();
    }
}
