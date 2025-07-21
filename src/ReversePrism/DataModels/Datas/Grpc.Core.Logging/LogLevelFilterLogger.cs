using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CoreVerbosityEnvVarName                  string IL2CPP_TYPE_STRING
    // 010 InnerLogger                              ModelClassType ILogger ILogger ILogger Pointer
    // 018 LogLevel                                 ModelEnumType LogLevel LogLevel LogLevel Int32
    public partial class LogLevelFilterLogger : DataModel
    {
        public ILogger?                                 InnerLogger                             { get; set; }
        public LogLevel                                 LogLevel                                { get; set; }

        public static LogLevelFilterLogger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogLevelFilterLogger() { Pointer= p0 };

            value.InnerLogger                               = GetObject<ILogger>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILogger.FromPointer); // 0x10 InnerLogger                 ( ModelClassType ILogger ILogger ILogger Pointer )
            value.LogLevel                                  = (LogLevel)GetInt32(new IntPtr(p + 0x018)); // 0x18 LogLevel                    ( ModelEnumType LogLevel LogLevel LogLevel Int32 )

            return value;
        }
    }
}
