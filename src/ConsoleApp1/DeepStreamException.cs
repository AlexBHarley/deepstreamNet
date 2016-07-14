using System;
using System.Runtime.Serialization;

namespace DeepStreamNet
{
    /// <summary>
    /// DeepStreamException
    /// </summary>
    [DataContract]
    public class DeepStreamException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public DeepStreamException()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">Exceptionmessage</param>
        public DeepStreamException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public DeepStreamException(string message, Exception innerException)
        : base(message, innerException)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="error"></param>
        /// <param name="message"></param>
        public DeepStreamException(string error, string message)
            : base(error+" - "+message)
        {
        }
    }
}