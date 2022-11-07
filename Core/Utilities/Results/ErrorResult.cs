using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result 
    {
        public ErrorResult()
        {
        }

        public ErrorResult(string message) : base(false, message)
        {

        }

        public ErrorResult(object productCountOfCategoryError) : base(false)
        {

        }
    }
}
