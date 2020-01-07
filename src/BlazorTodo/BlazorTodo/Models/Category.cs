using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodo.Models
{
    public class Category
    {
        public string Name { get; set; }

        public List<TodoItem> TodoItems { get; set; }

        public Category()
        {
            TodoItems = new List<TodoItem>();
        }
    }
}
