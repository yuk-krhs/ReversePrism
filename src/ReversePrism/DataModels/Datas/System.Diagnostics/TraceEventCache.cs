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
    // 010 TimeStamp                                ModelPrimitiveType long long long Int64
    // 018 DateTime                                 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 StackTrace                               ModelPrimitiveType string string string String
    public partial class TraceEventCache : DataModel
    {
        public long                                     TimeStamp                               { get; set; }
        public DateTime                                 DateTime                                { get; set; }
        public string                                   StackTrace                              { get; set; }

        public static TraceEventCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TraceEventCache() { Pointer= p0 };

            value.TimeStamp                                 = GetInt64(new IntPtr(p + 0x010)); // 0x10 TimeStamp                   ( ModelPrimitiveType long long long Int64 )
            value.DateTime                                  = GetDateTime(new IntPtr(p + 0x018)); // 0x18 DateTime                    ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.StackTrace                                = GetString(new IntPtr(p + 0x020)); // 0x20 StackTrace                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
