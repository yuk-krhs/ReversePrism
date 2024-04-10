using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LoggerName                               000186671910 ModelPrimitiveType string string string String
    // 018 LogType                                  0001865B0450 ModelEnumType LogType LogType LogType Int32
    // 020 Message                                  000186671910 ModelPrimitiveType string string string String
    // 028 Timestamp                                0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 030 Context                                  000186638250 ModelClassType Object Object Object Pointer
    // 038 Exception                                0001865CA820 ModelClassType Exception Exception Exception Pointer
    // 040 StackTrace                               000186671910 ModelPrimitiveType string string string String
    // 048 <State>k__BackingField                   <object> IL2CPP_TYPE_OBJECT
    public partial class LogEntry : DataModel
    {
        public string                                   LoggerName                              { get; set; }
        public LogType                                  LogType                                 { get; set; }
        public string                                   Message                                 { get; set; }
        public DateTime                                 Timestamp                               { get; set; }
        public Object?                                  Context                                 { get; set; }
        public Exception?                               Exception                               { get; set; }
        public string                                   StackTrace                              { get; set; }

        public static LogEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogEntry() { Pointer= p0 };

            value.LoggerName                                = GetString(new IntPtr(p + 0x010)); // 0246696A7E98 0x10 LoggerName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.LogType                                   = (LogType)GetInt32(new IntPtr(p + 0x018)); // 0246696A7EB8 0x18 LogType                     ( 0001865B0450 ModelEnumType LogType LogType LogType Int32 )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 0246696A7ED8 0x20 Message                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Timestamp                                 = GetDateTime(new IntPtr(p + 0x028)); // 0246696A7EF8 0x28 Timestamp                   ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Context                                   = GetObject<Object>(new IntPtr(p + 0x030), ReversePrism.DataModels.Object.FromPointer); // 0246696A7F18 0x30 Context                     ( 000186638250 ModelClassType Object Object Object Pointer )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x038), ReversePrism.DataModels.Exception.FromPointer); // 0246696A7F38 0x38 Exception                   ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )
            value.StackTrace                                = GetString(new IntPtr(p + 0x040)); // 0246696A7F58 0x40 StackTrace                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
