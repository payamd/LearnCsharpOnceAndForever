using System.Collections.Generic;

namespace LearnCsharpOneTimeAndForever
{
    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTask();
    }
}