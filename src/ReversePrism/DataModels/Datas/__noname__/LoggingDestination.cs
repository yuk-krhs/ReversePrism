using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LoggingDestination> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MonitoredResourceFieldNumber             int IL2CPP_TYPE_I4
    // 018 MonitoredResource                        ModelPrimitiveType string string string String
    // 000 LogsFieldNumber                          int IL2CPP_TYPE_I4
    // 008 _repeated_logs_codec                     FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 020 Logs                                     ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class LoggingDestination : DataModel
    {
        public string                                   MonitoredResource                       { get; set; }
        public List<string>?                            Logs                                    { get; set; }

        public static LoggingDestination? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoggingDestination() { Pointer= p0 };

            value.MonitoredResource                         = GetString(new IntPtr(p + 0x018)); // 0x18 MonitoredResource           ( ModelPrimitiveType string string string String )
            value.Logs                                      = GetStringList(new IntPtr(p + 0x020)); // 0x20 Logs                        ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
