using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP
{
    public class EventArgsMessage : EventArgs
    {
        public string Message { get; set; }
        public EventArgsMessage(string message)
        {
            Message = message;
        }

    }
}
