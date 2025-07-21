using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LoggerName                               ModelPrimitiveType string string string String
    // 018 LogType                                  ModelEnumType LogType LogType LogType Int32
    // 020 Message                                  ModelPrimitiveType string string string String
    // 028 Timestamp                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 030 Context                                  ModelClassType Object Object Object Pointer
    // 038 Exception                                ModelClassType Exception Exception Exception Pointer
    // 040 StackTrace                               ModelPrimitiveType string string string String
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

            value.LoggerName                                = GetString(new IntPtr(p + 0x010)); // 0x10 LoggerName                  ( ModelPrimitiveType string string string String )
            value.LogType                                   = (LogType)GetInt32(new IntPtr(p + 0x018)); // 0x18 LogType                     ( ModelEnumType LogType LogType LogType Int32 )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Message                     ( ModelPrimitiveType string string string String )
            value.Timestamp                                 = GetDateTime(new IntPtr(p + 0x028)); // 0x28 Timestamp                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Context                                   = GetObject<Object>(new IntPtr(p + 0x030), ReversePrism.DataModels.Object.FromPointer); // 0x30 Context                     ( ModelClassType Object Object Object Pointer )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x038), ReversePrism.DataModels.Exception.FromPointer); // 0x38 Exception                   ( ModelClassType Exception Exception Exception Pointer )
            value.StackTrace                                = GetString(new IntPtr(p + 0x040)); // 0x40 StackTrace                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
