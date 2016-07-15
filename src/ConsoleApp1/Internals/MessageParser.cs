using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepStreamNet.Internals
{
    static class MessageParser
    {
        internal static Message ParseMessage(string raw, Connection conn)
        {
            var parts = raw.Split(Constants.RecordSeperator);

            if (parts.Length < 2)
            {
                conn.OnError(Topic.Empty, Action.Empty, Constants.Errors.MESSAGE_PARSE_ERROR, "Insufficiant message parts");
                return null;
            }

            if (Topic.GetTopic(parts[0]) == null)
            {
                conn.OnError(Topic.Empty, Action.Empty, Constants.Errors.MESSAGE_PARSE_ERROR, "Incorrect Type" );
                return null;
            }

            if (Action.GetAction(parts[1]) == null)
            {
                conn.OnError(Topic.Empty, Action.Empty, Constants.Errors.MESSAGE_PARSE_ERROR, "Incorrect Action");
                return null;
            }

            return new Message(raw, Topic.GetTopic(parts[0]), Action.GetAction(parts[1]), parts.Skip(2).Take(parts.Length - 2).ToArray());
        }
    }
}
