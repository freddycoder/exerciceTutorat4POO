using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public interface IRequest<T>
    {
        T Execute();
    }
}
