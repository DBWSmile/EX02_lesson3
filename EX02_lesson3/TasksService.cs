using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace EX02_lesson3
{
    public interface ITasksService
    {
        public bool CreateTask([FromBody] Tasks task);
        //public int CreateTask2([FromBody] Tasks task);
        //public int CreateTask3(string title, string description, DateTime time, Priority preference);
        public bool DeleteTask(int id);
        public List<Tasks> GetTasks();
    }

    public class TasksService : ITasksService
    {
       static List<Tasks> tasksList = new List<Tasks>();
        public TasksService()
        {
            Tasks t = new Tasks(1,"tt", DateTime.Now, 0);
            tasksList.Add(t);

           

        }

        public bool CreateTask([FromBody] Tasks task)
        {
            try
            {
                
                tasksList.Add(task);


            }
            catch 
            {
                return false;
            }

            return true;            //return "errrtyhrtutytyt5";
        }


        public List<Tasks> GetTasks()
        {

            return tasksList;
        }

        //public int CreateTask2([FromBody] Tasks task)
        //{
        //    tasksList.Add(task);
        //    return tasksList.Count();
        //    //return "errrtyhrtutytyt5";
        //}

        //public int CreateTask3(string title, string description, DateTime time, Priority preference)
        //{
        //    Tasks t = new Tasks(title, description, time, preference);
        //    tasksList.Add(t);
        //    return tasksList.Count();
        //    //return t;
        //}


        public bool DeleteTask([FromBody] int id)
        {
            Tasks task = tasksList.Find(x => x.Id == id);
            if(task != null) { 
                tasksList.Remove(task);
                return true;
            }
            return false;
        }
    }
}
