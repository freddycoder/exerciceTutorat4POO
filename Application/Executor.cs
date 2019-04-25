using System;

namespace Application
{
    public class Executor
    {
        public void Send<T>(ICommand<T> command)
        {
            command.Execute();
        }

        public T Send<T>(IRequest<T> request)
        {
            return request.Execute();
        }
    }
}
