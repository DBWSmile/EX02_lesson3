using System.Reflection.Metadata;
using System.Security.Cryptography.Xml;

namespace EX02_lesson3
{
    public enum Priority {a,b,c }
    public class Tasks
    {
        public int Id { get; } = 0;
        //public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Priority Priority { get; set; }

        public Tasks( int id,string description, DateTime myDate, Priority Priority)
        {
            Id = 888;
            //Title = title;
            Description = description;
            Date = myDate;
            Priority = Priority;

        }
    }
}
