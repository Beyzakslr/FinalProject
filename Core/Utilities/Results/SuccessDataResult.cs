using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //versiyonlar 1-Data,mesaj  2-Data  3-Sadece mesaj  4-Hiçbir şey

        public SuccessDataResult(T data, string message):base(data,true,message)
        {

        }

        public SuccessDataResult(T data):base(data,true)
        {

        }

        public SuccessDataResult(string message):base(default,true,message)
        {

        }

        public SuccessDataResult():base(default,true)
        {

        }
    }

}
