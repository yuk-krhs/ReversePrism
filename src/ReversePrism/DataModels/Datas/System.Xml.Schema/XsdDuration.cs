using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Years                                    ModelPrimitiveType int int int Int32
    // 014 Months                                   ModelPrimitiveType int int int Int32
    // 018 Days                                     ModelPrimitiveType int int int Int32
    // 01C Hours                                    ModelPrimitiveType int int int Int32
    // 020 Minutes                                  ModelPrimitiveType int int int Int32
    // 024 Seconds                                  ModelPrimitiveType int int int Int32
    // 028 Nanoseconds                              ModelPrimitiveType uint uint uint UInt32
    public partial class XsdDuration : DataModel
    {
        public int                                      Years                                   { get; set; }
        public int                                      Months                                  { get; set; }
        public int                                      Days                                    { get; set; }
        public int                                      Hours                                   { get; set; }
        public int                                      Minutes                                 { get; set; }
        public int                                      Seconds                                 { get; set; }
        public uint                                     Nanoseconds                             { get; set; }

        public static XsdDuration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XsdDuration() { Pointer= p0 };

            value.Years                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Years                       ( ModelPrimitiveType int int int Int32 )
            value.Months                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Months                      ( ModelPrimitiveType int int int Int32 )
            value.Days                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Days                        ( ModelPrimitiveType int int int Int32 )
            value.Hours                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Hours                       ( ModelPrimitiveType int int int Int32 )
            value.Minutes                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 Minutes                     ( ModelPrimitiveType int int int Int32 )
            value.Seconds                                   = GetInt32(new IntPtr(p + 0x024)); // 0x24 Seconds                     ( ModelPrimitiveType int int int Int32 )
            value.Nanoseconds                               = GetUInt32(new IntPtr(p + 0x028)); // 0x28 Nanoseconds                 ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
