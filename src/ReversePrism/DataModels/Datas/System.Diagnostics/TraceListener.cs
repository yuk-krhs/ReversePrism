using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 IndentLevel                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C IndentSize                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 TraceOptions                             000186699CB0 ModelEnumType TraceOptions TraceOptions TraceOptions Int32
    // 024 NeedIndent                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 ListenerName                             000186671910 ModelPrimitiveType string string string String
    // 030 Filter                                   000186697D40 ModelClassType TraceFilter TraceFilter TraceFilter Pointer
    public partial class TraceListener
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
            var value   = new TraceListener();

            value.IndentLevel                               = GetInt32(new IntPtr(p + 0x018)); // 027004D015E0 0x18 IndentLevel                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IndentSize                                = GetInt32(new IntPtr(p + 0x01C)); // 027004D01600 0x1C IndentSize                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TraceOptions                              = (TraceOptions)GetInt32(new IntPtr(p + 0x020)); // 027004D01620 0x20 TraceOptions                ( 000186699CB0 ModelEnumType TraceOptions TraceOptions TraceOptions Int32 )
            value.NeedIndent                                = GetBool(new IntPtr(p + 0x024)); // 027004D01640 0x24 NeedIndent                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ListenerName                              = GetString(new IntPtr(p + 0x028)); // 027004D01660 0x28 ListenerName                ( 000186671910 ModelPrimitiveType string string string String )
            value.Filter                                    = GetObject<TraceFilter>(new IntPtr(p + 0x030), ReversePrism.DataModels.TraceFilter.FromPointer); // 027004D01680 0x30 Filter                      ( 000186697D40 ModelClassType TraceFilter TraceFilter TraceFilter Pointer )

            return value;
        }
    }
}
