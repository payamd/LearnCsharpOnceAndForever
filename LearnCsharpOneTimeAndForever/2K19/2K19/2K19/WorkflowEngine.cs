using System.Collections.Generic;

namespace _2K19
{
    class WorkflowEngine
    {
        private List<IWorkflow> list = new List<IWorkflow>();


        public void Addtolist(IWorkflow worlkflow)
        {
            if (worlkflow != null) list.Add(worlkflow);
        }



        public void Run()
        {
            foreach (var work in list)
            {
                work.Execute();
            }
        }
    }
}