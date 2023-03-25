using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTestes
{
    [TestClass]
    public class TodoQueriesTests
    {
        private List<TodoItem> _items;

        public TodoQueriesTests() 
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", "usuário A", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 2", "usuário A", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 3", "andersoncosta", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 4", "usuário A", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 5", "andersoncosta", DateTime.Now));
        }

        [TestMethod]
        public void Deve_retornar_tarefas_apenas_do_usario_andersoncosta()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("andersoncosta"));
            Assert.AreEqual(2, result.Count());
        }
    }
}
