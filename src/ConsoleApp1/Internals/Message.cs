using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepStreamNet.Internals
{
    public class Message
    {
        internal String Raw { get; set; }

        internal Topic? Topic { get; set; } 

        internal Action? Action { get; set; }

        internal String[] Data { get; set; }

        internal Message(String raw, Topic? topic, Action? action, String[] data)
        {
            Raw = raw;
            Topic = topic;
            Action = action;
            Data = data;
        }
    }
}
