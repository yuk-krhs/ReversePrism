using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 IndentLevel                              ModelPrimitiveType int int int Int32
    // 01C IndentSize                               ModelPrimitiveType int int int Int32
    // 020 TraceOptions                             ModelEnumType TraceOptions TraceOptions TraceOptions Int32
    // 024 NeedIndent                               ModelPrimitiveType bool bool bool Bool
    // 028 ListenerName                             ModelPrimitiveType string string string String
    // 030 Filter                                   ModelClassType TraceFilter TraceFilter TraceFilter Pointer
    public partial class TraceListener : DataModel
    {
        public int                                      IndentLevel                             { get; set; }
        public int                                      IndentSize                              { get; set; }
        public TraceOptions                             TraceOptions                            { get; set; }
        public bool                                     NeedIndent                              { get; set; }
        public string                                   ListenerName                            { get; set; }
        public TraceFilter?                             Filter                                  { get; set; }

        public static TraceListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TraceListener() { Pointer= p0 };

            value.IndentLevel                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 IndentLevel                 ( ModelPrimitiveType int int int Int32 )
            value.IndentSize                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C IndentSize                  ( ModelPrimitiveType int int int Int32 )
            value.TraceOptions                              = (TraceOptions)GetInt32(new IntPtr(p + 0x020)); // 0x20 TraceOptions                ( ModelEnumType TraceOptions TraceOptions TraceOptions Int32 )
            value.NeedIndent                                = GetBool(new IntPtr(p + 0x024)); // 0x24 NeedIndent                  ( ModelPrimitiveType bool bool bool Bool )
            value.ListenerName                              = GetString(new IntPtr(p + 0x028)); // 0x28 ListenerName                ( ModelPrimitiveType string string string String )
            value.Filter                                    = GetObject<TraceFilter>(new IntPtr(p + 0x030), ReversePrism.DataModels.TraceFilter.FromPointer); // 0x30 Filter                      ( ModelClassType TraceFilter TraceFilter TraceFilter Pointer )

            return value;
        }
    }
}
