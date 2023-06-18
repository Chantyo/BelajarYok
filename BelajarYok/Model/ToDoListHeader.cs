using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BelajarYok.Model
{
    public class ToDoListHeader : BaseObservableModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<ToDoList> toDoLists { get; set; }
    }
}
