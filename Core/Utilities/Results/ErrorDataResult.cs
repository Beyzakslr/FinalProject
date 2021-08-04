using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{ 
        public class ErrorDataResult<T> : DataResult<T>
        {
            //versiyonlar 1-Data,mesaj  2-Data  3-Sadece mesaj  4-Hiçbir şey

            public ErrorDataResult(T data, string message) : base(data, false, message)
            {

            }

            public ErrorDataResult(T data) : base(data, false)
            {

            }

            public ErrorDataResult(string message) : base(default, false, message)
            {

            }

            public ErrorDataResult() : base(default, false)
            {

            }
        }

    
}
