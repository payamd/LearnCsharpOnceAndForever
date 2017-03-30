namespace LearnCsharpOneTimeAndForever
{
    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (var work in workFlow.GetTask())
            {
                work.Execute();
            }
        }
    }
}