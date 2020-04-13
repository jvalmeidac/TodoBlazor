using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Model
{
    public class TodoItem
    {
        public TodoItem()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }
        public string Title { get; set; }
        public bool isDone { get; set; }
        [DataType(DataType.Date)]
        public DateTime AddedIn { get; set; }
    }
}
