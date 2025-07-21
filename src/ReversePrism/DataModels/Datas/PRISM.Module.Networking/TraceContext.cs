using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TraceId                                  ModelPrimitiveType string string string String
    // 018 SpanId                                   ModelPrimitiveType int int int Int32
    // 01C IsTrace                                  ModelPrimitiveType bool bool bool Bool
    public partial class TraceContext : DataModel
    {
        public string                                   TraceId                                 { get; set; }
        public int                                      SpanId                                  { get; set; }
        public bool                                     IsTrace                                 { get; set; }

        public static TraceContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TraceContext() { Pointer= p0 };

            value.TraceId                                   = GetString(new IntPtr(p + 0x010)); // 0x10 TraceId                     ( ModelPrimitiveType string string string String )
            value.SpanId                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 SpanId                      ( ModelPrimitiveType int int int Int32 )
            value.IsTrace                                   = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsTrace                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
