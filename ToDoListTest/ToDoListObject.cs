using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ToDoList
{
    private List<string> tasks;

    public ToDoList()
    {
        tasks = new List<string>();
    }

    public void AddTask(string task)
    {
        tasks.Add(task);
    }

    public List<string> GetTasks()
    {
        return tasks;
    }
}
