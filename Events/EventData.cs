using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    public class EventData
    {
        public EventData(string source, Object dataObject=null)
        {
            Source = source;
            DataObject = dataObject;
        }
        public string Source
        { get; set; }

        public Object DataObject
        {
            get;
            set;
        }
    }
}
