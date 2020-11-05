using WorkerServiceRefactoreStatic.Interfaces;

namespace WorkerServiceRefactoreStatic.Models
{
    public class AnotherStaticClassAdapter : IAnotherStaticClassAdapter
    {
        public string GetMessage()
        {
         return  AnotherStaticClass.GetMessage();
        }
    }
}
