using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel void başlangıcı
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
