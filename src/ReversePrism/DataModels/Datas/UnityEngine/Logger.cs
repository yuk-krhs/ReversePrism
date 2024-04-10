using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LogHandler                               00018659FC60 ModelClassType ILogHandler ILogHandler ILogHandler Pointer
    // 018 LogEnabled                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C FilterLogType                            0001865B0450 ModelEnumType LogType LogType LogType Int32
    public partial class Logger : DataModel
    {
        public ILogHandler?                             LogHandler                              { get; set; }
        public bool                                     LogEnabled                              { get; set; }
        public LogType                                  FilterLogType                           { get; set; }

        public static Logger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Logger() { Pointer= p0 };

            value.LogHandler                                = GetObject<ILogHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILogHandler.FromPointer); // 0245A32DCA58 0x10 LogHandler                  ( 00018659FC60 ModelClassType ILogHandler ILogHandler ILogHandler Pointer )
            value.LogEnabled                                = GetBool(new IntPtr(p + 0x018)); // 0245A32DCA78 0x18 LogEnabled                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FilterLogType                             = (LogType)GetInt32(new IntPtr(p + 0x01C)); // 0245A32DCA98 0x1C FilterLogType               ( 0001865B0450 ModelEnumType LogType LogType LogType Int32 )

            return value;
        }
    }
}
