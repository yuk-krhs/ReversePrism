using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 processId                                int IL2CPP_TYPE_I4
    // 008 processName                              string IL2CPP_TYPE_STRING
    // 010 TimeStamp                                0001865F7700 ModelPrimitiveType long long long Int64
    // 018 DateTime                                 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 StackTrace                               000186671910 ModelPrimitiveType string string string String
    public partial class TraceEventCache
    {
        public long                                     TimeStamp                               { get; set; }
        public DateTime                                 DateTime                                { get; set; }
        public string                                   StackTrace                              { get; set; }

        public static TraceEventCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TraceEventCache();

            value.TimeStamp                                 = GetInt64(new IntPtr(p + 0x010)); // 0270D79A27E0 0x10 TimeStamp                   ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.DateTime                                  = GetDateTime(new IntPtr(p + 0x018)); // 0270D79A2800 0x18 DateTime                    ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.StackTrace                                = GetString(new IntPtr(p + 0x020)); // 0270D79A2820 0x20 StackTrace                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
