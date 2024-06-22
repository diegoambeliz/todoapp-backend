using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;
using System.Data.SqlClient;
using TodoApp.Entity.Db;

namespace TodoApp.Repository.Classes
{
    public class TaskRepository
    {
        public IEnumerable<TaskEntity> GetAll(string cs)
        {
			try
			{
				var cn = new SqlConnection(cs);
				return cn.Query<TaskEntity>("sp_task_GetAll", commandType: CommandType.StoredProcedure);
			}
			catch(SqlException sqlEx)
			{
				throw new Exception($"Database error no. {sqlEx.Number}");
			}
        }

        public TaskEntity? GetById(string cs, Guid id)
        {
            try
            {
                var cn = new SqlConnection(cs);
                return cn.QueryFirstOrDefault<TaskEntity>("sp_task_GetById", new { id }, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException sqlEx)
            {
                throw new Exception($"Database error no. {sqlEx.Number}");
            }
        }

        public void Insert(string cs, TaskEntity entity) {
            try
            {
                var cn = new SqlConnection(cs);
                cn.Insert(entity);
            }
            catch (SqlException sqlEx)
            {
                throw new Exception($"Database error no. {sqlEx.Number}");
            }
        }

        public void Update(string cs, TaskEntity entity)
        {
            try
            {
                var cn = new SqlConnection(cs);
                cn.Update(entity);
            }
            catch (SqlException sqlEx)
            {
                throw new Exception($"Database error no. {sqlEx.Number}");
            }
        }

        public void Delete(string cs, TaskEntity entity)
        {
            try
            {
                var cn = new SqlConnection(cs);
                cn.Delete(entity);
            }
            catch (SqlException sqlEx)
            {
                throw new Exception($"Database error no. {sqlEx.Number}");
            }
        }
    }
}
