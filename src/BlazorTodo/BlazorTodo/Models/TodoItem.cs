using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodo.Models
{
    public class TodoItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreatedDate { get; set; }

        public string BorderStatus
        {
            get
            {
                return IsDone ? "border border-success" : "";
            }
        }

        public string HeaderStatus
        {
            get
            {
                return IsDone ? "bg-success" : "";
            }
        }
    }
}
