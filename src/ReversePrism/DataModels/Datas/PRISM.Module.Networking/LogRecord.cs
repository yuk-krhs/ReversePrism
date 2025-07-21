using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DateTime                                 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 LogLevel                                 ModelEnumType LogLevel LogLevel LogLevel Int32
    // 020 Message                                  ModelPrimitiveType string string string String
    // 000 datetimeFormat                           string IL2CPP_TYPE_STRING
    // 028 Culture                                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    public partial class LogRecord : DataModel
    {
        public DateTime                                 DateTime                                { get; set; }
        public LogLevel                                 LogLevel                                { get; set; }
        public string                                   Message                                 { get; set; }
        public CultureInfo?                             Culture                                 { get; set; }

        public static LogRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogRecord() { Pointer= p0 };

            value.DateTime                                  = GetDateTime(new IntPtr(p + 0x010)); // 0x10 DateTime                    ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.LogLevel                                  = (LogLevel)GetInt32(new IntPtr(p + 0x018)); // 0x18 LogLevel                    ( ModelEnumType LogLevel LogLevel LogLevel Int32 )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Message                     ( ModelPrimitiveType string string string String )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x28 Culture                     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )

            return value;
        }
    }
}
