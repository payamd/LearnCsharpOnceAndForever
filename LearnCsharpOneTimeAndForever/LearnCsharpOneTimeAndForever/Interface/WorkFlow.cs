using System.Collections.Generic;

namespace LearnCsharpOneTimeAndForever
{
    public class WorkFlow:IWorkFlow

    {
        private readonly List<ITask> _tasks = new List<ITask>();

        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTask()
        {
            return _tasks;
        }


    }
}