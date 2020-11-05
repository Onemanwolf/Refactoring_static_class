using System;
using WorkerServiceRefactoreStatic.Interfaces;

namespace WorkerServiceRefactoreStatic.Models
{
    public class StaticAdapter : IStaticBehaviorAdapter
    {
        public IAnotherStaticClassAdapter _anotherStaticClassAdapter;
        public string Message { get; set; }

        public StaticAdapter(IAnotherStaticClassAdapter adapter)
        {
            _anotherStaticClassAdapter = adapter;
        }



        //Refactor behavoir safely 
        public void PrintService()
        {
            var messageFromService = _anotherStaticClassAdapter.GetMessage();
            Message = $"Message from Service {messageFromService}";
            
            Console.WriteLine(Message);

        }


        public void Print(bool? isService)
        {
          //Switch from static behavior to instance behavior 
            if (isService == false || isService == null)
            {
                StaticBehavior.Print();
            }
            else
            {
                PrintService();
            }
           

        }
    }
}
