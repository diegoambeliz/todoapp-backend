using TodoApp.Entity.Classes;
using TodoApp.Entity.Db;
using TodoApp.Repository.Classes;

namespace TodoApp.Service.Classes
{
    public class TaskService
    {
        protected readonly TaskRepository _repo;
        public TaskService(TaskRepository repo) => _repo = repo;

        public IEnumerable<TaskGroupEntity> GetAll(string cs) {
            var tasks = _repo.GetAll(cs);

            var groupByStatus = tasks.GroupBy(b => b.status).ToList();

            var taskGroups = groupByStatus.Select(b => new TaskGroupEntity()
            {
                status = b.Key,
                tasks = b
            });

            return taskGroups;
        }
        public TaskEntity? GetById(string cs, Guid id) => _repo.GetById(cs, id);

        public void Insert(string cs, TaskEntity entity)
        {
            entity.id = Guid.NewGuid();
            entity.created_at = DateTime.Now;
            _repo.Insert(cs, entity);
        }

        public void Update(string cs, TaskEntity entityModified)
        {
            var entity = GetById(cs, entityModified.id);

            if (entity == null) throw new ArgumentException("Task not found");

            entity.description = entityModified.description;
            entity.deadline = entityModified.deadline;
            entity.status = entityModified.status;

            _repo.Update(cs, entity);
        }

        public void Delete(string cs, Guid id)
        {
            var entity = GetById(cs, id);

            if (entity == null) throw new ArgumentException("Task not found");

            _repo.Delete(cs, entity);
        }

    }
}
