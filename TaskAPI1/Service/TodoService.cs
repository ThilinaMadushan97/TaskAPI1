using TaskAPI1.Models;

namespace TaskAPI1.Service
{
    public class TodoService
    {
        //Get Todos
        public List<Todo> GetAllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Test1",
                Description = "Description1",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Test2",
                Description = "Description2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Completed

            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Test3",
                Description = "Description3",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Inprogress

            };
            todos.Add(todo3);

            return todos;
        }
    }
}
