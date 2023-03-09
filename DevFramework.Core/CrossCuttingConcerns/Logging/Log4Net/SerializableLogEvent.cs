using log4net.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Core.CrossCuttingConcerns.Logging.Log4Net
{
    [Serializable]
    public class SerializableLogEvent
    {
        private LoggingEvent _logginEvent;

        public SerializableLogEvent(LoggingEvent logginEvent)
        {
            _logginEvent = logginEvent;
        }
        public string UserName => _logginEvent.UserName;
        public object MessageObject => _logginEvent.MessageObject;

    }
}
