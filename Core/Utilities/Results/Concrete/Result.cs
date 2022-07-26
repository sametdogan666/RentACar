﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success)
        {
            Success = success;
        }
        public Result(bool success, string message) : this(success) // Ustteki constructor'ı da çalıştırıyoruz.
        {
            Message = message;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
