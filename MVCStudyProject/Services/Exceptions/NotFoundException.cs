using System;

namespace MVCStudyProject.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message) 
        {            
        }
    }
}
