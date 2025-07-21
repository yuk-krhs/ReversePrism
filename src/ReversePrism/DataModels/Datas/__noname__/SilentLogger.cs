using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LogHandler                               ModelClassType ILogHandler ILogHandler ILogHandler Pointer
    // 018 LogEnabled                               ModelPrimitiveType bool bool bool Bool
    // 01C FilterLogType                            ModelEnumType LogType LogType LogType Int32
    public partial class SilentLogger : DataModel
    {
        public ILogHandler?                             LogHandler                              { get; set; }
        public bool                                     LogEnabled                              { get; set; }
        public LogType                                  FilterLogType                           { get; set; }

        public static SilentLogger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SilentLogger() { Pointer= p0 };

            value.LogHandler                                = GetObject<ILogHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILogHandler.FromPointer); // 0x10 LogHandler                  ( ModelClassType ILogHandler ILogHandler ILogHandler Pointer )
            value.LogEnabled                                = GetBool(new IntPtr(p + 0x018)); // 0x18 LogEnabled                  ( ModelPrimitiveType bool bool bool Bool )
            value.FilterLogType                             = (LogType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C FilterLogType               ( ModelEnumType LogType LogType LogType Int32 )

            return value;
        }
    }
}
