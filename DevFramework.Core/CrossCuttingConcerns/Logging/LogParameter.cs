using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Core.CrossCuttingConcerns.Logging
{
    public class LogParameter
    {
        public string Name { get; internal set; }
        public Type Type { get; internal set; }
        public object Value { get; internal set; }
    }
}
